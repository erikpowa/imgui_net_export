using System.Text;

namespace imgui_net_export;

public unsafe class StructDescriptor : CSharpDescriptor
{
    private readonly StringBuilder _structs;
    private HashSet<string> _generic = [];

    public StructDescriptor(IDiaSession* session) : base(session)
    {
        _structs = new StringBuilder();
    }
    
    private HashSet<int> _exposedTypes = [];

    private bool MapExposedType(IDiaSymbol* symbol)
    {
        if (symbol == null) return true;
        
        IDiaSymbol* unmodified = GetUnmodifiedType(symbol);
        if (unmodified != null)
        {
            MapExposedType(unmodified);
            unmodified->Release(unmodified);
            return true;
        }

        SymTag symTag = GetSymTag(symbol);

        switch (symTag)
        {
            case SymTag.SymTagNull:
                throw new NotImplementedException();
            case SymTag.SymTagExe:
                throw new NotImplementedException();
            case SymTag.SymTagCompiland:
                throw new NotImplementedException();
            case SymTag.SymTagCompilandDetails:
                throw new NotImplementedException();
            case SymTag.SymTagCompilandEnv:
                throw new NotImplementedException();
            case SymTag.SymTagFunction:
                var functionType = GetType(symbol);
                MapExposedType(functionType);
                functionType->Release(functionType);
                // TODO remember enum:SymTagFunctionArgType case is bad, its missing the "this", therefore unhandled type
                // eg EnumChildren(symbol, SymTag.SymTagFunctionArgType, MapExposedType);
                // use EnumArguments instead
                EnumArguments(symbol, MapExposedType);
                return true;
            case SymTag.SymTagBlock:
                throw new NotImplementedException();
            case SymTag.SymTagData:
                var variableType = GetType(symbol);
                MapExposedType(variableType);
                variableType->Release(variableType);
                return true;
            case SymTag.SymTagAnnotation:
                throw new NotImplementedException();
            case SymTag.SymTagLabel:
                throw new NotImplementedException();
            case SymTag.SymTagPublicSymbol:
                throw new NotImplementedException();
            case SymTag.SymTagUDT:
                break;
            case SymTag.SymTagEnum:
                return true;
            case SymTag.SymTagFunctionType:
                var returnType = GetType(symbol);
                MapExposedType(returnType);
                returnType->Release(returnType);
                return true;
            case SymTag.SymTagPointerType:
                IDiaSymbol* pointerType = GetType(symbol);
                MapExposedType(pointerType);
                pointerType->Release(pointerType);
                return true;
            case SymTag.SymTagArrayType:
                IDiaSymbol* arrayType = GetType(symbol);
                MapExposedType(arrayType);
                arrayType->Release(arrayType);
                return true;
            case SymTag.SymTagBaseType:
                return true;
            case SymTag.SymTagTypedef:
                throw new NotImplementedException();
            case SymTag.SymTagBaseClass:
                throw new NotImplementedException();
            case SymTag.SymTagFriend:
                throw new NotImplementedException();
            case SymTag.SymTagFunctionArgType:
                var functionArg = GetType(symbol);
                MapExposedType(functionArg);
                functionArg->Release(functionArg);
                return true;
            case SymTag.SymTagFuncDebugStart:
                throw new NotImplementedException();
            case SymTag.SymTagFuncDebugEnd:
                throw new NotImplementedException();
            case SymTag.SymTagUsingNamespace:
                throw new NotImplementedException();
            case SymTag.SymTagVTableShape:
                throw new NotImplementedException();
            case SymTag.SymTagVTable:
                throw new NotImplementedException();
            case SymTag.SymTagCustom:
                throw new NotImplementedException();
            case SymTag.SymTagThunk:
                throw new NotImplementedException();
            case SymTag.SymTagCustomType:
                throw new NotImplementedException();
            case SymTag.SymTagManagedType:
                throw new NotImplementedException();
            case SymTag.SymTagDimension:
                throw new NotImplementedException();
            case SymTag.SymTagCallSite:
                throw new NotImplementedException();
            case SymTag.SymTagInlineSite:
                throw new NotImplementedException();
            case SymTag.SymTagBaseInterface:
                throw new NotImplementedException();
            case SymTag.SymTagVectorType:
                throw new NotImplementedException();
            case SymTag.SymTagMatrixType:
                throw new NotImplementedException();
            case SymTag.SymTagHLSLType:
                throw new NotImplementedException();
            case SymTag.SymTagCaller:
                throw new NotImplementedException();
            case SymTag.SymTagCallee:
                throw new NotImplementedException();
            case SymTag.SymTagExport:
                if (GetFunction(symbol))
                {
                    int rva = GetRelativeVirtualAddress(symbol);
                    IDiaSymbol* function = GetFunctionByRelativeVirtualAddress(rva);
                    MapExposedType(function);
                    Console.WriteLine(function->GetDebugString(function));
                    function->Release(function);
                    return true;
                }
                // global variable
                return true;
            case SymTag.SymTagHeapAllocationSite:
                throw new NotImplementedException();
            case SymTag.SymTagCoffGroup:
                throw new NotImplementedException();
            case SymTag.SymTagInlinee:
                throw new NotImplementedException();
            case SymTag.SymTagTaggedUnionCase:
                throw new NotImplementedException();
            case SymTag.SymTagMax:
                throw new NotImplementedException();
            default:
                throw new NotImplementedException();
        }

        if (GetHasNestedTypes(symbol))
        {
            /*var name = GetName(symbol);
            if (name.Contains("ImBitArray"))
            {
                EnumChildren(symbol, SymTag.SymTagNull, x =>
                {
                    Console.WriteLine(x->GetDebugString(x));
                    var typeDef = GetType(x);
                    Console.WriteLine(typeDef->GetDebugString(typeDef));
                    return true;
                });
            }

            Console.WriteLine();*/
            
            EnumChildren(symbol, SymTag.SymTagTypedef, x =>
            {
                var typeDef = GetType(x);
                MapExposedType(typeDef);
                typeDef->Release(typeDef);
                return true;
            });
        }
        
        int symIndexId = GetSymIndexId(symbol);

        if (!_exposedTypes.Add(symIndexId))
            return true;

        Console.WriteLine(GetName(symbol));

        EnumChildren(symbol, SymTag.SymTagData, (int)NameSearchOptions.nsfCaseInsensitive, MapExposedType);

        return true;
    }

    
    private bool EnumStructTypes(IDiaSymbol* @struct)
    {
        var udtKind = GetKind(@struct);
        if (udtKind != UdtKind.UdtStruct) return true;

        string typeNameOriginal = GetTypeName(@struct);
        
        ulong length = GetLength(@struct);

        bool generic = false;
        
        string typeName = typeNameOriginal;
        string genericReplace = string.Empty;
        var typeNameSplit = typeName.Split('<');
        if (typeNameSplit.Length == 2)
        {
            typeName = typeNameSplit[0];
            if (!_generic.Add(typeName)) return true; // add template once
            generic = true;
            genericReplace = typeNameSplit[1].Replace(">", string.Empty);
        }

        if (IsTypeForwarded(typeName))
            return true;
        
        _structs.AppendLine($"[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x{length:X4})]"); // [StructLayout(LayoutKind.Explicit, Size = 0x0000)]
        _structs.AppendLine($"public unsafe partial struct {typeName}{(generic ? "<T> where T : unmanaged" : "")} {{");
        
        EnumChildren(@struct, SymTag.SymTagData, (int)NameSearchOptions.nsfCaseInsensitive, field =>
        {
            var offset = GetOffset(field);
            var access = GetAccess(field);
            
            IDiaSymbol* fieldType = GetType(field);

            string fieldName = GetName(field);

            string fieldTypeName = GetTypeName(fieldType);

            if (fieldTypeName == "ImGuiWindowTempData") fieldTypeName = "byte"; // TODO, NET JIT RECURSION DETECTION, typeloadexception, even in NET10

            if (generic)
            {
                fieldTypeName = fieldTypeName.Replace($"<{genericReplace}>", "<T>");
                fieldTypeName = fieldTypeName.Replace($"{genericReplace}*", "T*");
            }

            // [FieldOffset(0x0004)] public readonly int Hello;
            _structs.AppendLine($"\t[FieldOffset(0x{offset:X4})] {access} {fieldTypeName} {fieldName};");

            fieldType->Release(fieldType);
            
            return true;
        });
        
        _structs.AppendLine("}");
        return true;
    }

    public override string ToString()
    {
        var exports = GetExports();
        EnumChildren(exports, MapExposedType);
        exports->Release(exports);

        foreach (var symTypeId in _exposedTypes)
        {
            IDiaSymbol* symbol = null;
            Session->symbolById(Session, symTypeId, &symbol).ThrowIfFailed();
            EnumStructTypes(symbol);
        }
        
        /*var global = GetGlobal();
        EnumChildren(global, SymTag.SymTagUDT, symbol =>
        {
            // TODO, IMGUI doesnt decorate some things with IMGUI_IMPL, so unable to determine for 100% accuracy the public API
            var isExported = GetConstantExport(symbol);
            if (!isExported)
            {
                var name = GetName(symbol);
                if (name == "ASD")
                    isExported = true;
            }
            if (!isExported) return true;  
            if (GetScoped(@symbol)) return true; // TODO, handle on demand, not yet needed
            EnumStructTypes(symbol);
            return true;
        });*/
        
       // global->Release(global);
        
        return _structs.ToString();
    }
}