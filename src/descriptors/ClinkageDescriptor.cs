using System.Text;
// ReSharper disable All

namespace imgui_net_export;

public unsafe partial class ClinkageDescriptor : Descriptor
{
    private readonly StringBuilder _cpp;
    
    public ClinkageDescriptor(IDiaSession* session) : base(session)
    {
        _cpp = new StringBuilder();
    }

    protected override string GetBaseTypeName(IDiaSymbol* symbol)
    {
        BasicType baseType = GetBaseType(symbol);
        ulong bytes = GetLength(symbol);

        if (bytes == 0 && baseType == BasicType.btVoid) return "void"; //

        if (bytes == 1 && baseType == BasicType.btChar) return "char"; //
        if (bytes == 1 && baseType == BasicType.btBool) return "bool";
        if (bytes == 1 && baseType == BasicType.btInt) return "sbyte";
        if (bytes == 1 && baseType == BasicType.btUInt) return "byte";

        if (bytes == 2 && baseType == BasicType.btWChar) return "char";
        if (bytes == 2 && baseType == BasicType.btInt) return "short";
        if (bytes == 2 && baseType == BasicType.btUInt) return "unsigned short";

        if (bytes == 4 && baseType == BasicType.btInt) return "int"; //
        if (bytes == 4 && baseType == BasicType.btLong) return "long";
        if (bytes == 4 && baseType == BasicType.btUInt) return "unsigned int"; //
        if (bytes == 4 && baseType == BasicType.btULong) return "unsigned long";
        if (bytes == 4 && baseType == BasicType.btFloat) return "float"; //
        

        if (bytes == 8 && baseType == BasicType.btInt) return "long long";
        if (bytes == 8 && baseType == BasicType.btUInt) return "unsigned long long";
        if (bytes == 8 && baseType == BasicType.btFloat) return "double";

        throw new NotImplementedException();
    }

    protected override string GetTypeName(IDiaSymbol* symbol, in string argName = "")
    {

        SymTag symTag = GetSymTag(symbol);
        
        byte isConstant = 0;
        symbol->lpVtbl->get_constantExport(symbol, &isConstant).ThrowIfFailed();
        byte isReference = 0;
        symbol->lpVtbl->get_reference(symbol, &isReference).ThrowIfFailed();
        
        switch (symTag)
        {
            case SymTag.SymTagUDT:
                return $"{(isConstant == 1 ? "const " : "")}{GetName(symbol)}";
            case SymTag.SymTagBaseType:
                return $"{(isConstant == 1 ? "const " : "")}{GetBaseTypeName(symbol)}";
            case SymTag.SymTagPointerType:
                IDiaSymbol* pointerType = GetType(symbol);
                SymTag pointerTypeSymTag = GetSymTag(pointerType);
                
                var typeName = GetTypeName(pointerType, argName);

                if (pointerTypeSymTag == SymTag.SymTagFunctionType)
                {
                    pointerType->Release(pointerType);
                    return typeName;
                }

                if (pointerTypeSymTag == SymTag.SymTagPointerType)
                {
                    if (typeName.Contains($" *{argName})"))
                    {
                        typeName = typeName.Replace($" *{argName}", $" **{argName}");
                        pointerType->Release(pointerType);
                        return typeName;    
                    }
                }

                typeName = $"{typeName}{(isReference == 1 ? "&" : "*")}";
                
                /*if (symbol->lpVtbl->get_reference(symbol, &isReference) && isReference == 1)
                    typeName = $"const {typeName}&";
                else
                    typeName = $"{typeName}*";*/

                pointerType->Release(pointerType);

                return typeName;
            case SymTag.SymTagFunctionType:
                
                // typedef void (*ImDrawCallback)(const ImDrawList* parent_list, const ImDrawCmd* cmd);
                // void (__cdecl *callback)(const ImDrawList *, const ImDrawCmd *)
                
                IDiaSymbol* returnType = GetType(symbol);

                var args = new List<string>();
                EnumChildren(symbol, SymTag.SymTagFunctionArgType, arg =>
                {
                    var t = GetTypeName(arg);
                    args.Add(t);
                    return true;
                });

                var ret = $"{GetTypeName(returnType, argName)} ({GetCallingConvention(symbol)} *{argName})({string.Join(", ", args)})";
                //argName = string.Empty;

                returnType->Release(returnType);

                return ret;
            case SymTag.SymTagFunctionArgType:
                var functionArg = GetType(symbol);
                var v0 = GetTypeName(functionArg);
                functionArg->Release(functionArg);
                return v0;
                break;
            case SymTag.SymTagArrayType:
                throw new NotImplementedException();
            case SymTag.SymTagEnum:
                return GetName(symbol);
            default:
                throw new NotImplementedException();
        }

        return "void*";
    }

    public override string ToString()
    {
        var functionNameIndexer = new NameIndexer();
        
        IDiaEnumSymbols* pEnumSymbol = GetExports();
        IDiaSymbol* pSymbol = null;
        uint fetched;
        while (pEnumSymbol->Next(pEnumSymbol, 1, &pSymbol, &fetched) && fetched == 1)
        {
            IDiaSymbol* function = null;
            IDiaSymbol* functionType = null;
            IDiaSymbol* returnType = null;
            try
            {
                if (!GetFunction(pSymbol)) continue;
                int rva = GetRelativeVirtualAddress(pSymbol);
                function = GetFunctionByRelativeVirtualAddress(rva);
                functionType = GetType(function);
                string callingConvention = GetCallingConvention(functionType);
                string functionName = GetName(function);
                var length = GetLength(function);
                if (length < 4) continue; // TODO EMPTY METHOD BODY conditional skipping
                
                IDiaSymbol* publicSymbol = GetPublicSymbolByRelativeVirtualAddress(rva);
                string undecoratedName = GetUndecoratedName(publicSymbol);

                if (callingConvention == "__cdecl" || callingConvention == "__vectorcall")
                {
                    // extreme laziness
                    // TODO correctly detect varargs
                    if (undecoratedName.Contains("...")) 
                        continue;
                }
                
                if (callingConvention == "__thiscall")
                {
                    if (functionName.Contains("::~")) continue;
                    if (functionName.Contains("::operator")) continue;
                    if (functionName.Contains("::`")) continue;
                    var v0 = functionName.Split("::");
                    if (v0.Length == 2 && v0[0] == v0[1]) continue;
                }

                if (functionName.Contains("::"))
                {
                    var t = functionName.Split("::");
                    if (t.Length == 2)
                    {
                        if (t[0] == t[1])
                            continue;
                    }
                }

                // __cdecl ImGuiContext* ImGui_CreateContext(ImFontAtlas* shared_font_atlas = NULL) { return ImGui::CreateContext(shared_font_atlas); }

                returnType = GetType(functionType);

                var args = new List<string>();
                var argsWithoutType = new List<string>();
                var argsNameIndexer = new NameIndexer();

                EnumArguments(function, arg =>
                {
                    string name = argsNameIndexer.Get(Sanitize(GetName(arg)));
                    argsWithoutType.Add($"{name}");
                    IDiaSymbol* argType = GetType(arg);
                    var typeName = GetTypeName(argType, name);
                    if (typeName.EndsWith($")")) name = string.Empty;
                    args.Add($"{typeName} {name}");
                    argType->Release(argType);
                    return true;
                });
                
                var functionNameNormalized = GetUniqueFunctionName(functionName);

                var rt = GetTypeName(returnType);
                var rtVoid = rt == "void";

                const string c = "__declspec(dllexport)";

                if (callingConvention == "__thiscall")
                {
                    var thisFunctionName = functionName.Split("::").Last();
                    
                    var ret = $"{argsWithoutType[0]}->{thisFunctionName}({string.Join(", ", argsWithoutType.Skip(1))})";

                    _cpp.AppendLine($"{c} {(rtVoid ? "void" : rt)} {functionNameNormalized}({string.Join(", ", args)}) {{ {(rt == "void" ? "" : "return ")}{ret}; }}");
                }
                else
                {
                    _cpp.AppendLine($"{c} {(rtVoid ? "void" : rt)} {functionNameNormalized}({string.Join(", ", args)}) {{ {(rt == "void" ? "" : "return ")}{functionName}({string.Join(", ", argsWithoutType)}); }}");    
                }

                //_stringBuilder.AppendLine($"Wrap({functionNameNormalized}, {functionName})");

            }
            finally
            {
                if(function != null) function->Release(function);
                if(functionType != null) returnType->Release(functionType);
                if(returnType != null) returnType->Release(returnType);

                pSymbol->Release(pSymbol);
                pSymbol = null;
            }
        }
        pEnumSymbol->Release(pEnumSymbol);
        pEnumSymbol = null;
        
        return _cpp.ToString();
    }
}