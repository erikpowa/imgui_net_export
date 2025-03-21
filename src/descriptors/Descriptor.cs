namespace imgui_net_export;

public unsafe partial class Descriptor
{
    
    protected readonly IDiaSession* Session;

    private readonly NameIndexer _functionNameIndexer;

    protected Descriptor(IDiaSession* session)
    {
        Session = session;
        _functionNameIndexer = new NameIndexer();
    }

    protected string GetUniqueFunctionName(string functionName)
    {
        var functionNameNormalized = Sanitize(functionName);
        functionNameNormalized = _functionNameIndexer.Get(functionNameNormalized);
        if (functionNameNormalized == functionName)
            functionNameNormalized = $"{functionNameNormalized}X";
        return functionNameNormalized;
    }

    protected virtual bool IsTypeForwarded(string typeName)
    {
        return false;
    }
    
    /*protected string GetIndexedFunctionName(string functionName, int argumentCount)
    {
        var key = $"{functionName}__{argumentCount}";
        ref var value = ref CollectionsMarshal.GetValueRefOrNullRef(_indexedFunctionNames, key);
        if (!Unsafe.IsNullRef(ref value))
            return $"{functionName}{value++}";
        _indexedFunctionNames[key] = 0;
        return functionName;
    }*/

    protected UdtKind GetKind(IDiaSymbol* symbol)
    {
        UdtKind udtKind = 0;
        symbol->get_udtKind(symbol, &udtKind).ThrowIfFailed();
        return udtKind;
    }
    
    protected IDiaSymbol* GetUnmodifiedType(IDiaSymbol* symbol)
    {
        IDiaSymbol* unmodifiedType;
        symbol->lpVtbl->get_unmodifiedType(symbol, &unmodifiedType).ThrowIfFailed();
        return unmodifiedType;
    }
    
    protected string GetAccess(IDiaSymbol* symbol)
    {
        CV_access_e access = 0;
        symbol->lpVtbl->get_access(symbol, &access).ThrowIfFailed();
        switch (access)
        {
            case CV_access_e.CV_private:
                return "private";
            case CV_access_e.CV_protected:
                return "protected";
            case CV_access_e.CV_public:
            default:
                return "public";
        }
    }
    
    protected int GetOffset(IDiaSymbol* symbol)
    {
        int offset = 0;
        symbol->lpVtbl->get_offset(symbol, &offset).ThrowIfFailed();
        return offset;
    }
    
    protected bool GetHasNestedTypes(IDiaSymbol* symbol)
    {
        byte hasNestedType = 0;
        symbol->lpVtbl->get_hasNestedTypes(symbol, &hasNestedType).ThrowIfFailed();
        return hasNestedType == 1;
    }
    
    protected bool GetNested(IDiaSymbol* symbol)
    {
        byte nested = 0;
        symbol->lpVtbl->get_nested(symbol, &nested).ThrowIfFailed();
        return nested == 1;
    }
    
    protected bool GetConstantExport(IDiaSymbol* symbol)
    {
        byte constantExport = 0;
        symbol->lpVtbl->get_constantExport(symbol, &constantExport).ThrowIfFailed();
        return constantExport == 1;
    }

    protected int GetSymIndexId(IDiaSymbol* symbol)
    {
        int symIndexId = 0;
        symbol->get_symIndexId(symbol, &symIndexId).ThrowIfFailed();
        return symIndexId;
    }

    protected bool GetScoped(IDiaSymbol* symbol)
    {
        byte scoped = 0;
        symbol->lpVtbl->get_scoped(symbol, &scoped).ThrowIfFailed();
        return scoped == 1;
    }

    protected SymTag GetSymTag(IDiaSymbol* symbol)
    {
        SymTag symTag = SymTag.SymTagNull;
        symbol->get_symTag(symbol, &symTag).ThrowIfFailed();
        return symTag;
    }
    
    protected bool EnumArguments(IDiaSymbol* function, dCallback callback)
    {
        return EnumChildren(function, SymTag.SymTagData, arg =>
        {
            DataKind dwDataKind;
            if (arg->get_dataKind(arg, &dwDataKind) && dwDataKind != DataKind.DataIsUnknown)
            {
                switch (dwDataKind)
                {
                    case DataKind.DataIsObjectPtr: // this
                    case DataKind.DataIsParam: // param arg
                        if (!callback(arg))
                            return false;
                        break;
                    default:
                        break;
                }
            }

            return true;
        });
    }
    
    protected int GetOrdinal(IDiaSymbol* symbol)
    {
        int ordinal = 0;
        symbol->get_ordinal(symbol, &ordinal).ThrowIfFailed();
        return ordinal;
    }

    protected string Sanitize(string name)
    {
        if (name == "this") return "_this";
        if (name == "in") return "_in";
        if (name == "out") return "_out";
        if (name == "ref") return "_ref";
        if (name == "string") return "_string";
        name = name.Replace("::", "_");
        name = name.Replace("<", "_");
        name = name.Replace(">", "_");
        name = name.Replace(",", "_");
        name = name.Replace("-", "_");
        name = name.Replace("+", "_");
        name = name.Replace("`", "_");
        name = name.Replace("~", "_");
        name = name.Replace("=", "_");
        return name;
    }
    
    protected bool GetFunction(IDiaSymbol* symbol)
    {
        byte isFunction = 0;
        symbol->get_function(symbol, &isFunction).ThrowIfFailed();
        return isFunction > 0;
    }
    
    protected int GetRelativeVirtualAddress(IDiaSymbol* symbol)
    {
        int rva = 0;
        symbol->get_relativeVirtualAddress(symbol, &rva).ThrowIfFailed();
        return rva;
    }
    
    protected IDiaSymbol* GetFunctionByRelativeVirtualAddress(int rva)
    {
        IDiaSymbol* pSymbolFunction = null;
        Session->findSymbolByRVA(Session, rva, SymTag.SymTagFunction, &pSymbolFunction).ThrowIfFailed();
        if (pSymbolFunction == null) throw new NotImplementedException();
        return pSymbolFunction;
    }
    
    protected IDiaSymbol* GetType(IDiaSymbol* symbol)
    {
        IDiaSymbol* type = null;
        symbol->get_type(symbol, &type).ThrowIfFailed();
        if (type == null) throw new NotImplementedException();
        return type;
    }
    
    protected ulong GetLength(IDiaSymbol* symbol)
    {
        ulong length = 0;
        symbol->get_length(symbol, &length).ThrowIfFailed();
        return length;
    }

    protected string GetName(IDiaSymbol* symbol)
    {
        using BSTR bstr = default;
        symbol->get_name(symbol, &bstr).ThrowIfFailed();
        return bstr.ToString();
    }
    
    protected string GetUndecoratedName(IDiaSymbol* symbol)
    {
        using BSTR bstr = default;
        symbol->get_undecoratedName(symbol, &bstr).ThrowIfFailed();
        return bstr.ToString();
    }

    protected IDiaSymbol* GetPublicSymbolByRelativeVirtualAddress(int rva)
    {
        IDiaSymbol* publicSymbol = null;
        Session->findSymbolByRVA(Session, rva, SymTag.SymTagPublicSymbol, &publicSymbol).ThrowIfFailed();
        if (publicSymbol == null) throw new NotImplementedException();
        return publicSymbol;
    }

    protected BasicType GetBaseType(IDiaSymbol* symbol)
    {
        BasicType baseType;
        symbol->get_baseType(symbol, &baseType).ThrowIfFailed();
        if (baseType == BasicType.btNoType) throw new NotImplementedException();
        return baseType;
    }
    
    protected IDiaEnumSymbols* GetExports()
    {
        IDiaEnumSymbols* enumSymbol = null;
        Session->getExports(Session, &enumSymbol).ThrowIfFailed();
        if (enumSymbol == null) throw new NotImplementedException();
        return enumSymbol;
    }
    
    protected IDiaSymbol* GetGlobal()
    {
        IDiaSymbol* global = null;
        Session->get_globalScope(Session, &global).ThrowIfFailed();
        if (global == null) throw new NotImplementedException();
        return global;
    }
    
    protected virtual string GetTypeName(IDiaSymbol* symbol, in string argName = "")
    {
        return GetName(symbol);
    }
    
    protected delegate bool dCallback(IDiaSymbol* symbol);
    
    protected bool EnumChildren(IDiaSymbol* symbol, SymTag symTag, char* name, int dwFlags, dCallback callback)
    {
        IDiaEnumSymbols* pEnumSymTagData = null;
        if (symbol->findChildren(symbol, symTag, name, dwFlags, &pEnumSymTagData) && pEnumSymTagData != null)
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
    
    protected bool EnumChildren(IDiaSymbol* symbol, SymTag symTag, int dwFlags, dCallback callback)
    {
        IDiaEnumSymbols* pEnumSymTagData = null;
        if (symbol->findChildren(symbol, symTag, null, dwFlags, &pEnumSymTagData) && pEnumSymTagData != null)
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
    
    protected bool EnumChildren(IDiaEnumSymbols* enumSymbols, dCallback callback)
    {
        IDiaSymbol* symbol = null;
        uint fetched = 0;
        while (enumSymbols->Next(enumSymbols, 1, &symbol, &fetched) && fetched == 1)
        {
            if (!callback(symbol))
            {
                symbol->Release(symbol);
                return false;
            }
            symbol->Release(symbol);
            symbol = null;
        }
        return true;
    }
    
    protected bool EnumChildren(IDiaSymbol* symbol, SymTag symTag, dCallback callback)
    {
        IDiaEnumSymbols* pEnumSymTagData = null;
        if (symbol->findChildren(symbol, symTag, null, 0, &pEnumSymTagData) && pEnumSymTagData != null)
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

    protected virtual string GetBaseTypeName(IDiaSymbol* symbol)
    {
        BasicType baseType = GetBaseType(symbol);
        ulong length = GetLength(symbol);
        return $"{baseType}_{length}";
    }
    
    protected virtual string GetCallingConvention(IDiaSymbol* symbol)
    {
        CallConv callConv;
        symbol->get_callingConvention(symbol, &callConv).ThrowIfFailed();
        switch (callConv)
        {
            case CallConv.CV_CALL_NEAR_STD:
                return "__stdlcall";
            case CallConv.CV_CALL_NEAR_FAST:
                return "__fastcall";
            case CallConv.CV_CALL_THISCALL:
                return "__thiscall";
            case CallConv.CV_CALL_NEAR_C:
                return "__cdecl";
            case CallConv.CV_CALL_SWIFT:
                throw new NotImplementedException();
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
}