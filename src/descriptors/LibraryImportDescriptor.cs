using System.Text;

namespace imgui_net_export;

public unsafe partial class LibraryImportDescriptor : CSharpDescriptor
{
    private readonly string _libraryName;
    private readonly StringBuilder _libraryImports;
    
    public bool UseOrdinal { get; set; }
    public bool Description { get; set; }
    public string Visibility { get; set; } = "internal";

    public LibraryImportDescriptor(string libraryName, IDiaSession* session) : base(session)
    {
        _libraryName = libraryName;
        _libraryImports = new StringBuilder();
    }

    public override string ToString()
    {
        // expection fully C LINKAGE
        
        IDiaEnumSymbols* enumSymbols = GetExports();
        IDiaSymbol* symbol = null;
        uint fetched;
        while (enumSymbols->Next(enumSymbols, 1, &symbol, &fetched) && fetched == 1)
        {
            IDiaSymbol* function = null;
            IDiaSymbol* functionType = null;
            IDiaSymbol* returnType = null;
            IDiaSymbol* publicSymbol = null;
            try
            {
                if (!GetFunction(symbol)) continue;

                int rva = GetRelativeVirtualAddress(symbol);
                function = GetFunctionByRelativeVirtualAddress(rva);
                functionType = GetType(function);
                string callingConvention = GetCallingConvention(functionType);
                string functionName = GetName(function);
                publicSymbol = GetPublicSymbolByRelativeVirtualAddress(rva);
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

                returnType = GetType(functionType);

                var returnTypeName = GetTypeName(returnType);
                
                var args = new List<string>();
                var argsNameIndexer = new NameIndexer();
                
                SymTag symTag = GetSymTag(returnType);;
                if (symTag == SymTag.SymTagUDT)
                {
                    returnTypeName = $"{returnTypeName}*";
                    args.Add($"{returnTypeName} pRetVal");
                }

                EnumArguments(function, arg =>
                {
                    string name = argsNameIndexer.Get(Sanitize(GetName(arg)));
                    IDiaSymbol* argType = GetType(arg);
                    var typeName = GetTypeName(argType, name);
                    args.Add($"{typeName} {name}");
                    argType->Release(argType);
                    return true;
                });

                var functionNameNormalized = GetUniqueFunctionName(functionName);
                functionName = Sanitize(functionName);

                _libraryImports.AppendLine($"[LibraryImport(\"{_libraryName}\", EntryPoint = \"{functionNameNormalized}\"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]");

                if (Description)
                {
                    _libraryImports.AppendLine($"[Description(\"{undecoratedName}\")]");    
                }
                
                _libraryImports.AppendLine($"{Visibility} static partial {returnTypeName} {functionName}({string.Join(", ", args)});");
                ;

            }
            finally
            {
                if(function != null) function->Release(function);
                if(functionType != null) functionType->Release(functionType);
                if(returnType != null) returnType->Release(returnType);
                if(publicSymbol != null) publicSymbol->Release(publicSymbol);

                symbol->Release(symbol);
                symbol = null;
            }
        }
        enumSymbols->Release(enumSymbols);
        enumSymbols = null;
        
        return _libraryImports.ToString();
    }

    private string GetEntryPoint(IDiaSymbol* symbol)
    {
        return UseOrdinal ? $"#{GetOrdinal(symbol)}" : GetName(symbol);
    }
}