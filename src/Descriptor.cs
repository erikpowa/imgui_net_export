using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace imgui_net_export;

public unsafe partial class Descriptor
{
    private readonly string _libraryName;
    private readonly IDiaSession* _pDiaSession;
    private readonly bool _useOrdinal;
    private readonly StringBuilder _stringBuilder;
    private Dictionary<string, int> _exportedFunctionNamingIndexer = [];
    private HashSet<int> _exposedTypes = [];
    private HashSet<int> _alreadyProced = [];
    private HashSet<string> _genericTypes = [];
    
    public Descriptor(string libraryName, IDiaSession* pDiaSession, bool useOrdinal = true)
    {
        _libraryName = libraryName;
        _pDiaSession = pDiaSession;
        _useOrdinal = useOrdinal;
        _stringBuilder = new StringBuilder();
    }
    
    public override string ToString()
    {
        _stringBuilder.Clear();

        _stringBuilder.AppendLine("using System.Runtime.InteropServices;");
        _stringBuilder.AppendLine("using System.Runtime.CompilerServices;");
        _stringBuilder.AppendLine("using System.ComponentModel;");
        _stringBuilder.AppendLine("using ImVec2 = System.Numerics.Vector2;");
        _stringBuilder.AppendLine("using ImVec4 = System.Numerics.Vector4;");
        _stringBuilder.AppendLine("using ImU32 = System.UInt32;");
        _stringBuilder.AppendLine();
        _stringBuilder.AppendLine("namespace GameExtensions;");
        _stringBuilder.AppendLine("public unsafe partial struct ImGui {");
        EnumExportedFunctions();
        _stringBuilder.AppendLine("}");

        IDiaSymbol* pDiaSymbolGlobal = null;
        _pDiaSession->get_globalScope(_pDiaSession, &pDiaSymbolGlobal).ThrowIfFailed();
        EnumChildren(pDiaSymbolGlobal, SymTagEnum.SymTagUDT, EnumStructTypes);
        EnumChildren(pDiaSymbolGlobal, SymTagEnum.SymTagEnum, EnumEnumTypes);
        OnClosing(string.Empty);
        

        return _stringBuilder.ToString();
    }
    
    private void MapExposedType(IDiaSymbol* pDiaSymbol)
    {
        int symIndexId = 0;
        if (!pDiaSymbol->get_symIndexId(pDiaSymbol, &symIndexId))
            return;

        if (!_alreadyProced.Add(symIndexId))
            return;

        SymTagEnum symTag;
        pDiaSymbol->get_symTag(pDiaSymbol, &symTag).ThrowIfFailed();
        
        if (symTag == SymTagEnum.SymTagBaseType)
            return;

        if (symTag == SymTagEnum.SymTagFunctionType)
            return; // TODO , IMPLEMENT DELEGATE*

        if (symTag == SymTagEnum.SymTagPointerType)
        {
            IDiaSymbol* pointerType;
            if (pDiaSymbol->get_type(pDiaSymbol, &pointerType) && pointerType != null)
            {
                MapExposedType(pointerType);
                pointerType->Release(pointerType);
                return;
            }

            return;
        }

        if (symTag == SymTagEnum.SymTagArrayType)
        {
            IDiaSymbol* arrayType = null;
            if (pDiaSymbol->get_type(pDiaSymbol, &arrayType) && arrayType != null)
            {
                MapExposedType(arrayType);
                arrayType->Release(arrayType);
                return;
            }

            return;
        }
        
        if (symTag != SymTagEnum.SymTagUDT && symTag != SymTagEnum.SymTagEnum)
            return;
        
        int unmodifiedTypeId = 0;
        if (pDiaSymbol->get_unmodifiedTypeId(pDiaSymbol, &unmodifiedTypeId) && unmodifiedTypeId > 0) {
            IDiaSymbol* unmodifiedSymbol = null;
            if (_pDiaSession->symbolById(_pDiaSession, unmodifiedTypeId, &unmodifiedSymbol) && unmodifiedSymbol != null) {
                MapExposedType(unmodifiedSymbol);
                unmodifiedSymbol->Release(unmodifiedSymbol);
                return;
            }
        }
        
        var name = pDiaSymbol->GetName(pDiaSymbol); // TODO, how to get template types, associated_types?
        var genericTypeNameSplit = name.Split('<');
        if (genericTypeNameSplit.Length == 2)
        {
            var genericTypeName = genericTypeNameSplit[0];
            var genericTypeArgumentName = genericTypeNameSplit[1].Replace(">", string.Empty);
            fixed (char* ptr = genericTypeArgumentName)  // Pin the string in memory
            {
                IDiaSymbol* pDiaSymbolGlobal = null;
                _pDiaSession->get_globalScope(_pDiaSession, &pDiaSymbolGlobal).ThrowIfFailed();
                EnumChildren(pDiaSymbolGlobal, SymTagEnum.SymTagUDT, ptr, (int)NameSearchOptions.nsCaseSensitive, symbol =>
                {
                    MapExposedType(symbol);
                    return true;
                });
                pDiaSymbolGlobal->Release(pDiaSymbolGlobal);
            }
            return;

            if (!_genericTypes.Add(genericTypeName))
                return;
        }
        
        if (!_exposedTypes.Add(symIndexId))
            return;

        UdtKind udtKind = 0;
        pDiaSymbol->get_udtKind(pDiaSymbol, &udtKind).ThrowIfFailed();
        if (udtKind != UdtKind.UdtStruct)
            return;

        byte scoped = 0;
        if (pDiaSymbol->get_scoped(pDiaSymbol, &scoped) && scoped > 0)
            return;
        
        EnumChildren(pDiaSymbol, SymTagEnum.SymTagData, (int)NameSearchOptions.nsfCaseInsensitive, symbol =>
        {
            IDiaSymbol* fieldType = null;
            if(symbol->get_type(symbol, &fieldType) && fieldType != null) {
                MapExposedType(fieldType);
                fieldType->Release(fieldType);
            }
            return true;
        });
    }
    
    public void Test()
    {
        IDiaSymbol* pDiaSymbolGlobal = null;
        _pDiaSession->get_globalScope(_pDiaSession, &pDiaSymbolGlobal).ThrowIfFailed();
        EnumChildren(pDiaSymbolGlobal, SymTagEnum.SymTagUDT, pDiaSymbol =>
        {
            SymTagEnum symTag;
            pDiaSymbol->get_symTag(pDiaSymbol, &symTag).ThrowIfFailed();
            Console.WriteLine($"{pDiaSymbol->GetName(pDiaSymbol)} : {symTag}" );
            return true;
        });
    }

    private int GetExportOrdinal(IDiaSymbol* pSymbol)
    {
        int ordinal = 0;
        pSymbol->get_ordinal(pSymbol, &ordinal).ThrowIfFailed();
        return ordinal;
    }
    
    private string GetExportEntryPoint(IDiaSymbol* pSymbol)
    {
        if (_useOrdinal)
            return $"#{GetExportOrdinal(pSymbol)}";
        BSTR name = default;
        pSymbol->get_name(pSymbol, &name).ThrowIfFailed();
        var ret = name.GetString();
        name.Dispose();
        return ret;
    }

    private IDiaSymbol* GetExportFunction(IDiaSymbol* pSymbol)
    {
        uint rva = GetExportRVA(pSymbol);
        
        IDiaSymbol* pSymbolFunction = null;
        if (!_pDiaSession->findSymbolByRVA(_pDiaSession, rva, SymTagEnum.SymTagFunction, &pSymbolFunction) || pSymbolFunction == null)
            throw new NotImplementedException();

        return pSymbolFunction;
    }
    
    private IDiaSymbol* GetExportFunctionType(IDiaSymbol* pSymbol)
    {
        IDiaSymbol* pSymbolFunction = GetExportFunction(pSymbol);
        IDiaSymbol* pFuncTypeDiaSymbol = null;
        pSymbolFunction->get_type(pSymbolFunction, &pFuncTypeDiaSymbol).ThrowIfFailed();
        pSymbolFunction->Release(pSymbolFunction);
        if (pFuncTypeDiaSymbol == null) throw new NotImplementedException();
        return pFuncTypeDiaSymbol;
    }

    private bool IsExportFunction(IDiaSymbol* pSymbol)
    {
        byte b = 0;
        pSymbol->get_function(pSymbol, &b);
        return b > 0;
    }

    private string GetExportFunctionName(IDiaSymbol* pSymbol)
    {
        IDiaSymbol* pSymbolFunction = GetExportFunction(pSymbol);

        BSTR exportName = default;
        pSymbolFunction->get_name(pSymbolFunction, &exportName).ThrowIfFailed();
        string name = exportName;
        exportName.Dispose();
        pSymbolFunction->Release(pSymbolFunction);
        
        if (string.IsNullOrEmpty(name)) throw new NotImplementedException();

        return name;
        
        ref var value = ref CollectionsMarshal.GetValueRefOrNullRef(_exportedFunctionNamingIndexer, name);

        if (!Unsafe.IsNullRef(ref value))
        {
            return $"{name}{value++}";
        }

        _exportedFunctionNamingIndexer[name] = 0;
        return name;
    }

    private uint GetExportRVA(IDiaSymbol* pSymbol)
    {
        uint rva = 0;
        pSymbol->get_relativeVirtualAddress(pSymbol, &rva).ThrowIfFailed();
        return rva;
    }

    private IDiaSymbol* GetExportFunctionReturnType(IDiaSymbol* pSymbol)
    {
        IDiaSymbol* pSymbolFunctionType = GetExportFunctionType(pSymbol);
        IDiaSymbol* pSymbolFunctionTypeReturnType = null;
        pSymbolFunctionType->get_type(pSymbolFunctionType, &pSymbolFunctionTypeReturnType).ThrowIfFailed();
        if (pSymbolFunctionTypeReturnType == null) throw new NotImplementedException();
        pSymbolFunctionType->Release(pSymbolFunctionType);
        return pSymbolFunctionTypeReturnType;
    }

    delegate bool dCallback(IDiaSymbol* pSymbol);
    
    private bool EnumChildren(IDiaSymbol* pSymbol, SymTagEnum symTagEnum, char* name, int dwFlags, dCallback callback)
    {
        IDiaEnumSymbols* pEnumSymTagData = null;
        if (pSymbol->findChildren(pSymbol, symTagEnum, name, dwFlags, &pEnumSymTagData) && pEnumSymTagData != null)
        {
            IDiaSymbol* pSymbolChild = null;
            uint fetched = 0;
            while (pEnumSymTagData->Next(pEnumSymTagData, 1, &pSymbolChild, &fetched) && fetched == 1)
            {
                if (!callback(pSymbolChild))
                {
                    pSymbolChild->Release(pSymbolChild);
                    pEnumSymTagData->Release(pEnumSymTagData);
                    return false;
                }
                pSymbolChild->Release(pSymbolChild);
                pSymbolChild = null;
            }
            pEnumSymTagData->Release(pEnumSymTagData);
        }
        return true;
    }
    
    private bool EnumChildren(IDiaSymbol* pSymbol, SymTagEnum symTagEnum, int dwFlags, dCallback callback)
    {
        IDiaEnumSymbols* pEnumSymTagData = null;
        if (pSymbol->findChildren(pSymbol, symTagEnum, null, dwFlags, &pEnumSymTagData) && pEnumSymTagData != null)
        {
            IDiaSymbol* pSymbolChild = null;
            uint fetched = 0;
            while (pEnumSymTagData->Next(pEnumSymTagData, 1, &pSymbolChild, &fetched) && fetched == 1)
            {
                if (!callback(pSymbolChild))
                {
                    pSymbolChild->Release(pSymbolChild);
                    pEnumSymTagData->Release(pEnumSymTagData);
                    return false;
                }
                pSymbolChild->Release(pSymbolChild);
                pSymbolChild = null;
            }
            pEnumSymTagData->Release(pEnumSymTagData);
        }
        return true;
    }
    
    private bool EnumChildren(IDiaSymbol* pSymbol, SymTagEnum symTagEnum, dCallback callback)
    {
        IDiaEnumSymbols* pEnumSymTagData = null;
        if (pSymbol->findChildren(pSymbol, symTagEnum, null, 0, &pEnumSymTagData) && pEnumSymTagData != null)
        {
            IDiaSymbol* pSymbolChild = null;
            uint fetched = 0;
            while (pEnumSymTagData->Next(pEnumSymTagData, 1, &pSymbolChild, &fetched) && fetched == 1)
            {
                if (!callback(pSymbolChild))
                {
                    pSymbolChild->Release(pSymbolChild);
                    pEnumSymTagData->Release(pEnumSymTagData);
                    return false;
                }
                pSymbolChild->Release(pSymbolChild);
                pSymbolChild = null;
            }
            pEnumSymTagData->Release(pEnumSymTagData);
        }
        return true;
    }
    
    private bool EnumExportFunctionArguments(IDiaSymbol* pSymbol, dCallback callback)
    {
        var pSymbolFunction = GetExportFunction(pSymbol);
        var ret = EnumChildren(pSymbolFunction, SymTagEnum.SymTagData, pSymbolFunctionArgument =>
        {
            DataKind dwDataKind;
            if (pSymbolFunctionArgument->get_dataKind(pSymbolFunctionArgument, &dwDataKind) && dwDataKind != DataKind.DataIsUnknown)
            {
                switch (dwDataKind)
                {
                    case DataKind.DataIsObjectPtr: // this
                    case DataKind.DataIsParam: // param arg
                        if (!callback(pSymbolFunctionArgument))
                            return false;
                        break;
                    default:
                        break;
                }
            }

            return true;
        });
        pSymbolFunction->Release(pSymbolFunction);
        return ret;
    }
    
    private string GetLibraryImportForExport(IDiaSymbol* pSymbol)
    {
//[LibraryImport("imgui", EntryPoint = "#1128"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
//[Description("void __cdecl ImGui::TextV(char const *,char *)")]
//private static partial void ImGui_TextV2(byte* a1, byte* a2);
        string entryPoint = GetExportEntryPoint(pSymbol);
        Type callingConvention = GetExportCallingConvention(pSymbol);
        string undecoratedName = GetExportUndecoratedName(pSymbol);
        string functionName = GetExportFunctionName(pSymbol);

        if (functionName.Contains("::"))
        {
            var t = functionName.Split("::");
            if (t.Length == 2)
            {
                if (t[0] == t[1])
                    return String.Empty;
            }
        }

        if (functionName.Contains("`default constructor closure'"))
            return string.Empty;
        
        if (functionName.Contains("~") || functionName.Contains("="))
            return string.Empty;

        functionName = functionName.Replace("=", "Equal");
        functionName = functionName.Replace("::", "_");
        functionName = functionName.Replace("~", "_Dtor_");
        functionName = functionName.Replace("`default constructor closure'", "_Ctor_");

        //if (functionName != "ImGuiTextFilter_ImGuiTextRange_split") return string.Empty;
        
        var sb = new StringBuilder();
        sb.AppendLine($"[LibraryImport(\"{_libraryName}\", EntryPoint = \"{entryPoint}\"), UnmanagedCallConv(CallConvs = [typeof({callingConvention.Name})])]");
        sb.AppendLine($"[Description(\"{undecoratedName}\")]");
        
        IDiaSymbol* returnType = GetExportFunctionReturnType(pSymbol);
        MapExposedType(returnType);
        var returnTypeName =  GetTypeName(returnType);

        var args = new StringBuilder();
        
        SymTagEnum symTag;
        returnType->get_symTag(returnType, &symTag).ThrowIfFailed();
        if (symTag == SymTagEnum.SymTagUDT)
        {
            returnTypeName = $"{returnTypeName}*";
            args.Append($"{returnTypeName} pRetVal, ");
        }

        EnumExportFunctionArguments(pSymbol, pSymbolArg =>
        {
            string name = pSymbolArg->GetName(pSymbolArg);
            IDiaSymbol* pSymbolArgType = null;
            pSymbolArg->get_type(pSymbolArg, &pSymbolArgType).ThrowIfFailed();
            MapExposedType(pSymbolArgType);
            args.Append($"{GetTypeName(pSymbolArgType)} @{name}, ");
            pSymbolArgType->Release(pSymbolArgType);
            return true;
        });
        
        if (args.Length > 2)
            args.Length -= 2;    
        
        sb.AppendLine($"internal static partial {returnTypeName} {functionName}({args.ToString()});");

        returnType->Release(returnType);
        
        return sb.ToString();
    }
    
    private void EnumExportedFunctions()
    {
        IDiaEnumSymbols* pEnumSymbol = null;
        if (!_pDiaSession->getExports(_pDiaSession, &pEnumSymbol)) return;
        IDiaSymbol* pSymbol = null;
        uint fetched;
        while (pEnumSymbol->Next(pEnumSymbol, 1, &pSymbol, &fetched) && fetched == 1)
        {
            if (IsExportFunction(pSymbol))
            {
                var t = GetLibraryImportForExport(pSymbol);
                if (!string.IsNullOrEmpty(t)) _stringBuilder.AppendLine(t);
            }
            pSymbol->Release(pSymbol);
            pSymbol = null;
        }
        pEnumSymbol->Release(pEnumSymbol);
        pEnumSymbol = null;
    }

    private string GetExportUndecoratedName(IDiaSymbol* pSymbol)
    {
        uint rva = GetExportRVA(pSymbol);
        
        IDiaSymbol* pSymbolPublicSymbol = null;
        if (_pDiaSession->findSymbolByRVA(_pDiaSession, rva, SymTagEnum.SymTagPublicSymbol, &pSymbolPublicSymbol) && pSymbolPublicSymbol != null)
        {
            BSTR undecoratedName = default;
            if (pSymbolPublicSymbol->get_undecoratedName(pSymbolPublicSymbol, &undecoratedName))
            {
                var name = undecoratedName.GetString();
                pSymbolPublicSymbol->Release(pSymbolPublicSymbol);
                undecoratedName.Dispose();
                return name;
            }
        }

        throw new NotImplementedException();
    }

    private bool EnumEnumMembers(IDiaSymbol* pDiaSymbol)
    {
        var name = pDiaSymbol->GetName(pDiaSymbol);

        VARIANT variant = default;
        pDiaSymbol->get_value(pDiaSymbol, &variant).ThrowIfFailed();

        switch (variant.mVT)
        {
            case VARENUM.VT_I2:
                _stringBuilder.AppendLine($"\t{name} = {variant.mInt16.ToBitShiftExpression()}, // {variant.mInt16.ToHex()}");
                break;
            case VARENUM.VT_UI2:
                _stringBuilder.AppendLine($"\t{name} = {variant.mUInt16.ToBitShiftExpression()}, // {variant.mInt16.ToHex()}");
                break;
            case VARENUM.VT_I1:
                _stringBuilder.AppendLine($"\t{name} = {variant.mInt8.ToBitShiftExpression()}, // {variant.mInt16.ToHex()}");
                break;
            case VARENUM.VT_UI4:
                _stringBuilder.AppendLine($"\t{name} = {variant.mUInt32.ToBitShiftExpression()}, // {variant.mInt16.ToHex()}");
                break;
            case VARENUM.VT_I4:
                _stringBuilder.AppendLine($"\t{name} = {variant.mInt32.ToBitShiftExpression()}, // {variant.mInt16.ToHex()}");
                break;
            default:
                throw new NotImplementedException();
        }
        
        return true;
    }
    
    private bool EnumEnumTypes(IDiaSymbol* pDiaSymbol)
    {
        byte scoped = 0;
        pDiaSymbol->get_scoped(pDiaSymbol, &scoped);
        if (scoped > 0) {
            return true;
        }

        int unmodifiedTypeId = 0;
        if (pDiaSymbol->get_unmodifiedTypeId(pDiaSymbol, &unmodifiedTypeId) && unmodifiedTypeId > 0) {
            IDiaSymbol* unmodifiedSymbol = null;
            if (_pDiaSession->symbolById(_pDiaSession, unmodifiedTypeId, &unmodifiedSymbol) && unmodifiedSymbol != null) {
                return true;
            }
        }

        string name = GetTypeNameUserDefined(pDiaSymbol);
        name = name.Trim('_');
        
        if (!OnEnumEnumType(name)) 
            return true;
        
        if (name.Contains("Flags")) _stringBuilder.AppendLine("[Flags]");
        _stringBuilder.AppendLine($"public enum {name} {{");
        EnumChildren(pDiaSymbol, SymTagEnum.SymTagData, (int)(NameSearchOptions.nsfCaseInsensitive | NameSearchOptions.nsfUndecoratedName), EnumEnumMembers);
        _stringBuilder.AppendLine("}");
        return true;
    }

    private bool EnumStructTypes(IDiaSymbol* pDiaSymbol)
    {
        int symIndexId = 0;
        if (!pDiaSymbol->get_symIndexId(pDiaSymbol, &symIndexId))
            return true;

        if (!_exposedTypes.Contains(symIndexId))
            return true;
        
        UdtKind udtKind = 0;
        pDiaSymbol->get_udtKind(pDiaSymbol, &udtKind).ThrowIfFailed();
        if (udtKind != UdtKind.UdtStruct) 
            return true;

        byte scoped = 0;
        if (pDiaSymbol->get_scoped(pDiaSymbol, &scoped) && scoped > 0) 
            return true;

        int unmodifiedTypeId = 0;
        if (pDiaSymbol->get_unmodifiedTypeId(pDiaSymbol, &unmodifiedTypeId) && unmodifiedTypeId > 0) {
            IDiaSymbol* unmodifiedSymbol = null;
            if (_pDiaSession->symbolById(_pDiaSession, unmodifiedTypeId, &unmodifiedSymbol) && unmodifiedSymbol != null) {
                return true; // ignore modified type
            }
        }

        ulong length = 0;
        if (!pDiaSymbol->get_length(pDiaSymbol, &length)) {
            return true;
        }

        string typeNameOriginal = GetTypeName(pDiaSymbol);

        if (typeNameOriginal == "ImVec2") return true;
        if (typeNameOriginal == "ImVec4") return true;

        bool generic = false;
        string typeName = typeNameOriginal;
        string genericReplace = string.Empty;
        var typeNameSplit = typeName.Split('<');
        if (typeNameSplit.Length == 2)
        {
            return true;
            generic = true;
            typeName = typeNameSplit[0];
            genericReplace = typeNameSplit[1].Replace(">", string.Empty);
        }
        
        if (!OnEnumStructType(typeName))
            return true;

        _stringBuilder.AppendLine($"[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x{length:X4})]"); // [StructLayout(LayoutKind.Explicit, Size = 0x0000)]
        _stringBuilder.AppendLine($"public unsafe partial struct {typeName}{(generic ? "<T> where T : unmanaged" : "")} {{ // {typeNameOriginal}");
        EnumChildren(pDiaSymbol, SymTagEnum.SymTagData, (int)NameSearchOptions.nsfCaseInsensitive, symbol =>
        {
            int offset = 0;
            if (!symbol->get_offset(symbol, &offset))
            {
                return true;
            }

            CV_access_e access = 0;
            if (!symbol->get_access(symbol, &access))
            {
                return true;
            }

            string accessString;
            switch (access)
            {
                case CV_access_e.CV_private:
                    accessString = "private";
                    break;
                case CV_access_e.CV_protected:
                    accessString = "protected";
                    break;
                case CV_access_e.CV_public:
                default:
                    accessString = "public";
                    break;
            }

            IDiaSymbol* fieldType = null;
            if (!symbol->get_type(symbol, &fieldType))
            {
                return true;
            }

            string fieldName = symbol->GetName(symbol);

            string fieldTypeName = GetTypeName(fieldType);

            if (generic)
            {
                fieldTypeName = fieldTypeName.Replace($"<{genericReplace}>", "<T>");
            }

            // wcout << L"\t[FieldOffset(" << wstring_tohex(offset, 4) << L")] " << accessString << " " << fieldTypeName << " " << fieldName << L";" << endl;

            // [FieldOffset(0x0004)] public readonly int Hello;
            _stringBuilder.AppendLine($"\t[FieldOffset(0x{offset:X4})] {accessString} {fieldTypeName} {fieldName};");
            return true;
        });
        _stringBuilder.AppendLine("}");
        return true;
    }
    
    private string GetTypeNameByBaseType(BasicType baseType, ulong bytes)
    {
        if (baseType == BasicType.btNoType) return "void";
        if (bytes == 0 && baseType == BasicType.btVoid) return "void";

        if (bytes == 1 && baseType == BasicType.btChar) return "byte"; // ? make "char" signed since its unspecified in c++ whenever its signed or not
        if (bytes == 1 && baseType == BasicType.btBool) return "byte";
        if (bytes == 1 && baseType == BasicType.btInt) return "sbyte";
        if (bytes == 1 && baseType == BasicType.btUInt) return "byte";

        if (bytes == 2 && baseType == BasicType.btWChar) return "char";
        if (bytes == 2 && baseType == BasicType.btInt) return "short";
        if (bytes == 2 && baseType == BasicType.btUInt) return "ushort";

        if (bytes == 4 && baseType == BasicType.btInt) return "int";
        if (bytes == 4 && baseType == BasicType.btLong) return "int";
        if (bytes == 4 && baseType == BasicType.btUInt) return "uint";
        if (bytes == 4 && baseType == BasicType.btULong) return "uint";
        if (bytes == 4 && baseType == BasicType.btFloat) return "float";
        

        if (bytes == 8 && baseType == BasicType.btInt) return "long";
        if (bytes == 8 && baseType == BasicType.btUInt) return "ulong";
        //if(bytes == 8 && baseType == btULong) return "ulong";
        if (bytes == 8 && baseType == BasicType.btFloat) return OnGetBaseTypeName(baseType, bytes, "double");

        throw new NotImplementedException();

        return $"void /* {baseType} / {bytes} */";
    }

    private Type GetExportCallingConvention(IDiaSymbol* pSymbol)
    {
        IDiaSymbol* pSymbolFunctionType = GetExportFunctionType(pSymbol);
        CallConv callConv;
        pSymbolFunctionType->get_callingConvention(pSymbolFunctionType, &callConv).ThrowIfFailed();
        pSymbolFunctionType->Release(pSymbolFunctionType);
        
        switch (callConv)
        {
            case CallConv.CV_CALL_NEAR_STD:
                return typeof(CallConvStdcall);
            case CallConv.CV_CALL_NEAR_FAST:
                return typeof(CallConvFastcall);
            case CallConv.CV_CALL_THISCALL:
                return typeof(CallConvThiscall);
            case CallConv.CV_CALL_NEAR_C:
                return typeof(CallConvCdecl);
            case CallConv.CV_CALL_SWIFT:
                return typeof(CallConvSwift);
            case CallConv.CV_CALL_FAR_C:
            case CallConv.CV_CALL_NEAR_PASCAL:
            case CallConv.CV_CALL_FAR_PASCAL:
            case CallConv.CV_CALL_FAR_FAST:
            case CallConv.CV_CALL_SKIPPED:
            case CallConv.CV_CALL_FAR_STD:
            case CallConv.CV_CALL_NEAR_SYS:
            case CallConv.CV_CALL_FAR_SYS:
            case CallConv.CV_CALL_MIPSCALL:
            case CallConv.CV_CALL_GENERIC:
            case CallConv.CV_CALL_ALPHACALL:
            case CallConv.CV_CALL_PPCCALL:
            case CallConv.CV_CALL_SHCALL:
            case CallConv.CV_CALL_ARMCALL:
            case CallConv.CV_CALL_AM33CALL:
            case CallConv.CV_CALL_TRICALL:
            case CallConv.CV_CALL_SH5CALL:
            case CallConv.CV_CALL_M32RCALL:
            case CallConv.CV_CALL_CLRCALL:
            case CallConv.CV_CALL_INLINE:
            case CallConv.CV_CALL_NEAR_VECTOR:
            case CallConv.CV_CALL_RESERVED:
            default:
                throw new NotImplementedException();
        }
    }
    
    private string GetTypeNameUserDefined(IDiaSymbol* pSymbol)
    {
        string result = pSymbol->GetName(pSymbol);

        if (string.IsNullOrEmpty(result))
            throw new NotImplementedException();

        if (result.StartsWith("ImBitArray<"))  // TODO: break down generic and reconstruct manually
        {
            return "byte";
        }

        // TODO manually reconstruct names instead of replace
        result = result.Replace("::", "__");

        result = result.Replace("<char const *>", "<byte>");

        result = result.Replace("<unsigned char>", "<byte>");
        result = result.Replace("<signed char>", "<sbyte>");
        result = result.Replace("<unsigned short>", "<ushort>");
        result = result.Replace("<signed short>", "<short>");
        result = result.Replace("<unsigned int>", "<uint>");
        result = result.Replace("<signed int>", "<int>");
        result = result.Replace("<unsigned __int64>", "<ulong>");
        result = result.Replace("<signed __int64>", "<long>");

        /*result = result.Replace("<char const", "<byte");
        result = result.Replace("<char>", "<byte>");
        result = result.Replace("__int64", "long");
        result = result.Replace("<unsigned ", "<u");
        result = result.Replace("<signed ", "<s");
        result = result.Replace(" ", "");
        result = result.Replace("*", "");*/
       // result = result.Replace(" ", string.Empty);
        result = result.Replace(" *>", ">");
        return result;
    }

    private string GetTypeName(IDiaSymbol* pDiaSymbol)
    {
        SymTagEnum symTag;
        if (!pDiaSymbol->get_symTag(pDiaSymbol, &symTag))
            return "void*";

        switch (symTag)
        {
            case SymTagEnum.SymTagUDT:
                return GetTypeNameUserDefined(pDiaSymbol);
            case SymTagEnum.SymTagBaseType:
                BasicType baseType;
                ulong length;
                if (pDiaSymbol->get_baseType(pDiaSymbol, &baseType) && pDiaSymbol->get_length(pDiaSymbol, &length))
                {
                    return GetTypeNameByBaseType(baseType, length);
                }
                return "void*";
                break;
            case SymTagEnum.SymTagPointerType:
                IDiaSymbol* pointerType;
                if (pDiaSymbol->get_type(pDiaSymbol, &pointerType) && pointerType != null)
                {
                    return $"{GetTypeName(pointerType)}*"; // Append '*' for pointer types
                }
                return "void*";
            case SymTagEnum.SymTagFunctionType:
                return "void*"; // TODO: break-down typedef parts and reconstruct as delegate*<>
            case SymTagEnum.SymTagArrayType:
                // char Name[40];
                // byte /*char[40]*/ Name;
                // TODO: generate InlineArray types "Array_char_40" or "Array_ImGuiKeyOwnerData_154"
                int arraySize;
                IDiaSymbol* arrayType;
                if (pDiaSymbol->get_count(pDiaSymbol, &arraySize) && pDiaSymbol->get_type(pDiaSymbol, &arrayType) && arrayType != null)
                {
                    BasicType baseType2;
                    if (arrayType->get_baseType(arrayType, &baseType2))
                    {
                        string arrayTypeName = GetTypeName(arrayType);
                        return $"byte /* {arrayTypeName} [{arraySize}] */";
                    }
                }

                return "byte /* array, unknown length */";
            case SymTagEnum.SymTagEnum:
                return pDiaSymbol->GetName(pDiaSymbol);
            default:
                // unhandled
                return "void*";
        }

        return "void*";
    }
    
    protected virtual string OnGetBaseTypeName(BasicType baseType, ulong bytes, string baseTypeName) => baseTypeName;
    
    protected virtual bool OnEnumEnumType(string name)
    {
        if (name.Contains("unnamed")) return false;
        
        //if (!name.StartsWith("ImG")) return false;
        //if (name.EndsWith("Private_")) return false;
        //
        return true;
    }
    
    protected virtual bool OnEnumStructType(string name)
    {
        //if (!name.StartsWith("Im")) return false;
        //if (name.Contains("ImVec4")) return false;
        //if (name.Contains("ImVec2")) return false;
        //if (name.Contains("<")) return false;
        //if (name.Contains(":")) return false;
        //
        return true;
    }

    protected virtual void OnClosing(string extra)
    {
        _stringBuilder.AppendLine("public unsafe struct ImVector<T> where T : unmanaged { public int Size; public int Capacity; public T* Data; }");
        _stringBuilder.AppendLine("public unsafe struct ImChunkStream<T> where T : unmanaged { public ImVector<byte> Buff; }");
        _stringBuilder.AppendLine("public unsafe struct ImSpan<T> where T : unmanaged {  public T* Data; public T* DataEnd; }" );
        _stringBuilder.AppendLine("public unsafe struct ImPool<T> where T : unmanaged { public ImVector<T> Map; public int FreeIdx; public int AliveCount;  }");
        
        if (!string.IsNullOrEmpty(extra)) _stringBuilder.AppendLine(extra);
    }

    

}