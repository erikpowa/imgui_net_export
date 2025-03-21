using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace imgui_net_export;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public unsafe struct IDiaSymbol
{
    public Vft* lpVtbl;

    private string GetName(IDiaSymbol* _this)
    {
        using BSTR name = default;
        _this->get_name(_this, &name).ThrowIfFailed();
        return name.ToString();
    }
       
    public HRESULT get_constType(IDiaSymbol* _this, byte* pRetVal) => _this->lpVtbl->get_constType(_this, pRetVal);
    public HRESULT get_hasNestedTypes(IDiaSymbol* _this, byte* pRetVal) => _this->lpVtbl->get_hasNestedTypes(_this, pRetVal);
    public HRESULT get_offset(IDiaSymbol* _this, int* pRetVal) => _this->lpVtbl->get_offset(_this, pRetVal);
    public HRESULT get_udtKind(IDiaSymbol* _this, UdtKind* pRetVal) => _this->lpVtbl->get_udtKind(_this, pRetVal);
    public HRESULT get_access(IDiaSymbol* _this, CV_access_e* pRetVal) => _this->lpVtbl->get_access(_this, pRetVal);
    public HRESULT get_value(IDiaSymbol* _this, ComVariant* pRetVal) => _this->lpVtbl->get_value(_this, pRetVal);
    public HRESULT get_unmodifiedTypeId(IDiaSymbol* _this, int* pRetVal) => _this->lpVtbl->get_unmodifiedTypeId(_this, pRetVal);
    public HRESULT get_scoped(IDiaSymbol* _this, byte* pRetVal) => _this->lpVtbl->get_scoped(_this, pRetVal);
    public HRESULT get_function(IDiaSymbol* _this, byte* pRetVal) => _this->lpVtbl->get_function(_this, pRetVal);
    public HRESULT get_callingConvention(IDiaSymbol* _this, CallConv* pRetVal) => _this->lpVtbl->get_callingConvention(_this, pRetVal);
    public HRESULT get_count(IDiaSymbol* _this, int* pRetVal) => _this->lpVtbl->get_count(_this, pRetVal);
    public HRESULT get_length(IDiaSymbol* _this, ulong* pRetVal) => _this->lpVtbl->get_length(_this, pRetVal);
    public HRESULT get_baseType(IDiaSymbol* _this, BasicType* pRetVal) => _this->lpVtbl->get_baseType(_this, pRetVal);
    public HRESULT get_symTag(IDiaSymbol* _this, SymTag* pRetVal) => _this->lpVtbl->get_symTag(_this, pRetVal);
    public HRESULT get_ordinal(IDiaSymbol* _this, int* pRetVal) => _this->lpVtbl->get_ordinal(_this, pRetVal);
    public HRESULT findChildren(IDiaSymbol* _this, SymTag symTag, char* name, int compareFlags, IDiaEnumSymbols **ppResult) => _this->lpVtbl->findChildren(_this, symTag, name, compareFlags, ppResult);
    public HRESULT get_dataKind(IDiaSymbol* _this, DataKind* pRetVal) => _this->lpVtbl->get_dataKind(_this, pRetVal);
    public HRESULT get_relativeVirtualAddress(IDiaSymbol* _this, int* pRetVal) => _this->lpVtbl->get_relativeVirtualAddress(_this, pRetVal);
    public HRESULT get_objectPointerType(IDiaSymbol* _this, IDiaSymbol **pRetVal) => _this->lpVtbl->get_objectPointerType(_this, pRetVal);
    public HRESULT get_arrayIndexType(IDiaSymbol* _this, IDiaSymbol **pRetVal) => _this->lpVtbl->get_arrayIndexType(_this, pRetVal);
    public HRESULT get_type(IDiaSymbol* _this, IDiaSymbol **pRetVal) => _this->lpVtbl->get_type(_this, pRetVal);
    public HRESULT get_lexicalParent(IDiaSymbol* _this, IDiaSymbol **pRetVal) => _this->lpVtbl->get_lexicalParent(_this, pRetVal);
    public HRESULT get_classParent(IDiaSymbol* _this, IDiaSymbol **pRetVal) => _this->lpVtbl->get_classParent(_this, pRetVal);
    public HRESULT get_symIndexId(IDiaSymbol* _this, int* pRetVal) => _this->lpVtbl->get_symIndexId(_this, pRetVal);
    public HRESULT get_undecoratedName(IDiaSymbol* _this, BSTR* pRetVal) => _this->lpVtbl->get_undecoratedName(_this, pRetVal);
    public HRESULT get_name(IDiaSymbol* _this, BSTR* pRetVal) => _this->lpVtbl->get_name(_this, pRetVal);
    public uint Release(IDiaSymbol* _this)
    {
        if (_this == null) return 0;
        return _this->lpVtbl->Release(_this);
    }

    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> func)
    {
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, ComVariant*, HRESULT> func)
    {
        ComVariant value = default;
        if (!func(_this, &value)) return;

        switch (value.VarType)
        {
            case VarEnum.VT_EMPTY:
                return;
            case VarEnum.VT_NULL:
                return;
            case VarEnum.VT_I2:
                sb.AppendLine($"{funcName} = {value.As<short>()}");
                break;
            case VarEnum.VT_I4:
                sb.AppendLine($"{funcName} = {value.As<int>()}");
                break;
            case VarEnum.VT_R4:
            case VarEnum.VT_R8:
            case VarEnum.VT_CY:
            case VarEnum.VT_DATE:
            case VarEnum.VT_BSTR:
            case VarEnum.VT_DISPATCH:
            case VarEnum.VT_ERROR:
            case VarEnum.VT_BOOL:
            case VarEnum.VT_VARIANT:
            case VarEnum.VT_UNKNOWN:
            case VarEnum.VT_DECIMAL:
                throw new NotImplementedException();                
                break;
            case VarEnum.VT_I1:
                sb.AppendLine($"{funcName} = {value.As<sbyte>()}");
                break;
            case VarEnum.VT_UI1:
                sb.AppendLine($"{funcName} = {value.As<byte>()}");
                break;
            case VarEnum.VT_UI2:
                sb.AppendLine($"{funcName} = {value.As<ushort>()}");
                break;
            case VarEnum.VT_UI4:
                sb.AppendLine($"{funcName} = {value.As<uint>()}");
                break;
            case VarEnum.VT_I8:
                sb.AppendLine($"{funcName} = {value.As<byte>()}");
                break;
            case VarEnum.VT_UI8:
            case VarEnum.VT_INT:
            case VarEnum.VT_UINT:
            case VarEnum.VT_VOID:
            case VarEnum.VT_HRESULT:
            case VarEnum.VT_PTR:
            case VarEnum.VT_SAFEARRAY:
            case VarEnum.VT_CARRAY:
            case VarEnum.VT_USERDEFINED:
            case VarEnum.VT_LPSTR:
            case VarEnum.VT_LPWSTR:
            case VarEnum.VT_RECORD:
            case VarEnum.VT_FILETIME:
            case VarEnum.VT_BLOB:
            case VarEnum.VT_STREAM:
            case VarEnum.VT_STORAGE:
            case VarEnum.VT_STREAMED_OBJECT:
            case VarEnum.VT_STORED_OBJECT:
            case VarEnum.VT_BLOB_OBJECT:
            case VarEnum.VT_CF:
            case VarEnum.VT_CLSID:
            case VarEnum.VT_VECTOR:
            case VarEnum.VT_ARRAY:
            case VarEnum.VT_BYREF:
            default:
                throw new NotImplementedException();
        }
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, IDiaSymbol**, HRESULT> func)
    {
        int length = 0;
        if (!func(_this, 0, &length, null)) return;
        if (length == 0) return;
        IDiaSymbol* buffer = stackalloc IDiaSymbol[length];
        if (!func(_this, length, &length, &buffer)) return;
        var s = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            var symbol = buffer+i;
            s.Append($"{symbol->GetName(symbol)}, ");
            symbol->Release(symbol);
        }
        if(s.Length >= 2) s.Length -= 2;
        sb.AppendLine($"{funcName} = [{s.ToString()}]");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, int**, HRESULT> func)
    {
        int length = 0;
        if (!func(_this, 0, &length, null)) return;
        if (length == 0) return;
        int* buffer = stackalloc int[length];
        if (!func(_this, length, &length, &buffer)) return;
        var s = new StringBuilder();
        for (int i = 0; i < length; i++)
            s.Append($"{buffer[i]}, ");
        if(s.Length >= 2) s.Length -= 2;
        sb.AppendLine($"{funcName} = [{s.ToString()}]");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, byte**, HRESULT> func)
    {
        int length = 0;
        if (!func(_this, 0, &length, null)) return;
        if (length == 0) return;
        byte* buffer = stackalloc byte[length];
        if (!func(_this, length, &length, &buffer)) return;
        var s = new StringBuilder();
        for (int i = 0; i < length; i++)
            s.Append($"{buffer[i]}, ");
        if(s.Length >= 2) s.Length -= 2;
        sb.AppendLine($"{funcName} = [{s.ToString()}]");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, BasicType*, HRESULT> func)
    {
        BasicType value = 0;
        if (!func(_this, &value)) return;
        if (value == 0) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, Guid*, HRESULT> func)
    {
        Guid value = Guid.Empty;
        if (!func(_this, &value)) return;
        if (value == Guid.Empty) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, SymTag*, HRESULT> func)
    {
        SymTag value = 0;
        if (!func(_this, &value)) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, CV_access_e*, HRESULT> func)
    {
        CV_access_e value = 0;
        if (!func(_this, &value)) return;
        if (value == 0) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, DataKind*, HRESULT> func)
    {
        DataKind value = 0;
        if (!func(_this, &value)) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, ulong*, HRESULT> func)
    {
        ulong value = 0;
        if (!func(_this, &value)) return;
        if (value == 0) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> func)
    {
        int value = 0;
        if (!func(_this, &value)) return;
        if (value == 0) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, UdtKind*, HRESULT> func)
    {
        UdtKind value = 0;
        if (!func(_this, &value)) return;
        sb.AppendLine($"{funcName} = {value}");
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, CallConv*, HRESULT> func)
    {
        CallConv value = (CallConv)50;
        if (!func(_this, &value)) return;
        sb.AppendLine($"{funcName} = {value}");
    }

    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> func)
    {
        byte value = 0;
        if (!func(_this, &value)) return;
        if (value == 0) return;
        sb.AppendLine($"{funcName} = {(value == 1 ? "TRUE" : "FALSE")}");
    }

    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> func)
    {
        IDiaSymbol* value = null;
        if (!func(_this, &value) || value == null) return;
        sb.AppendLine($"{funcName} = `{value->GetName(value)}`");
        value->Release(value);
    }
    
    void Call(IDiaSymbol* _this, StringBuilder sb, string funcName, delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> func)
    {
        using BSTR bstr = default;
        func(_this, &bstr).ThrowIfFailed();
        var result = bstr.ToString();
        if (string.IsNullOrEmpty(result)) return;
        sb.AppendLine($"{funcName} = `{bstr.ToString()}`");
    }

    public string GetDebugString(IDiaSymbol* _this)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"[Symbol] {_this->GetName(_this)}");

        Call(_this, sb, nameof(Vft.get_symTag), _this->lpVtbl->get_symTag);
        Call(_this, sb, nameof(Vft.get_udtKind), _this->lpVtbl->get_udtKind);
        Call(_this, sb, nameof(Vft.get_dataKind), _this->lpVtbl->get_dataKind);
        Call(_this, sb, nameof(Vft.get_baseType), _this->lpVtbl->get_baseType);

        Call(_this, sb, nameof(Vft.get_symIndexId), _this->lpVtbl->get_symIndexId);
        Call(_this, sb, nameof(Vft.get_name), _this->lpVtbl->get_name);
        Call(_this, sb, nameof(Vft.get_lexicalParent), _this->lpVtbl->get_lexicalParent);
        Call(_this, sb, nameof(Vft.get_classParent), _this->lpVtbl->get_classParent);
        Call(_this, sb, nameof(Vft.get_type), _this->lpVtbl->get_type);
        Call(_this, sb, nameof(Vft.get_locationType), _this->lpVtbl->get_locationType);
        Call(_this, sb, nameof(Vft.get_addressSection), _this->lpVtbl->get_addressSection);
        Call(_this, sb, nameof(Vft.get_addressOffset), _this->lpVtbl->get_addressOffset);
        Call(_this, sb, nameof(Vft.get_relativeVirtualAddress), _this->lpVtbl->get_relativeVirtualAddress);
        Call(_this, sb, nameof(Vft.get_virtualAddress), _this->lpVtbl->get_virtualAddress);
        Call(_this, sb, nameof(Vft.get_registerId), _this->lpVtbl->get_registerId);
        Call(_this, sb, nameof(Vft.get_offset), _this->lpVtbl->get_offset);
        Call(_this, sb, nameof(Vft.get_length), _this->lpVtbl->get_length);
        Call(_this, sb, nameof(Vft.get_slot), _this->lpVtbl->get_slot);
        Call(_this, sb, nameof(Vft.get_volatileType), _this->lpVtbl->get_volatileType);
        Call(_this, sb, nameof(Vft.get_constType), _this->lpVtbl->get_constType);
        Call(_this, sb, nameof(Vft.get_unalignedType), _this->lpVtbl->get_unalignedType);
        Call(_this, sb, nameof(Vft.get_access), _this->lpVtbl->get_access);
        Call(_this, sb, nameof(Vft.get_libraryName), _this->lpVtbl->get_libraryName);
        Call(_this, sb, nameof(Vft.get_platform), _this->lpVtbl->get_platform);
        Call(_this, sb, nameof(Vft.get_language), _this->lpVtbl->get_language);
        Call(_this, sb, nameof(Vft.get_editAndContinueEnabled), _this->lpVtbl->get_editAndContinueEnabled);
        Call(_this, sb, nameof(Vft.get_frontEndMajor), _this->lpVtbl->get_frontEndMajor);
        Call(_this, sb, nameof(Vft.get_frontEndMinor), _this->lpVtbl->get_frontEndMinor);
        Call(_this, sb, nameof(Vft.get_frontEndBuild), _this->lpVtbl->get_frontEndBuild);
        Call(_this, sb, nameof(Vft.get_backEndMajor), _this->lpVtbl->get_backEndMajor);
        Call(_this, sb, nameof(Vft.get_backEndMinor), _this->lpVtbl->get_backEndMinor);
        Call(_this, sb, nameof(Vft.get_backEndBuild), _this->lpVtbl->get_backEndBuild);
        Call(_this, sb, nameof(Vft.get_sourceFileName), _this->lpVtbl->get_sourceFileName);
        //Call(_this, sb, nameof(Vft.get_unused), _this->lpVtbl->get_unused);
        Call(_this, sb, nameof(Vft.get_thunkOrdinal), _this->lpVtbl->get_thunkOrdinal);
        Call(_this, sb, nameof(Vft.get_thisAdjust), _this->lpVtbl->get_thisAdjust);
        Call(_this, sb, nameof(Vft.get_virtualBaseOffset), _this->lpVtbl->get_virtualBaseOffset);
        Call(_this, sb, nameof(Vft.get_virtual), _this->lpVtbl->get_virtual);
        Call(_this, sb, nameof(Vft.get_intro), _this->lpVtbl->get_intro);
        Call(_this, sb, nameof(Vft.get_pure), _this->lpVtbl->get_pure);
        Call(_this, sb, nameof(Vft.get_callingConvention), _this->lpVtbl->get_callingConvention);
        Call(_this, sb, nameof(Vft.get_value), _this->lpVtbl->get_value);
        Call(_this, sb, nameof(Vft.get_token), _this->lpVtbl->get_token);
        Call(_this, sb, nameof(Vft.get_timeStamp), _this->lpVtbl->get_timeStamp);
        Call(_this, sb, nameof(Vft.get_guid), _this->lpVtbl->get_guid);
        Call(_this, sb, nameof(Vft.get_symbolsFileName), _this->lpVtbl->get_symbolsFileName);
        Call(_this, sb, nameof(Vft.get_reference), _this->lpVtbl->get_reference);
        Call(_this, sb, nameof(Vft.get_count), _this->lpVtbl->get_count);
        Call(_this, sb, nameof(Vft.get_bitPosition), _this->lpVtbl->get_bitPosition);
        Call(_this, sb, nameof(Vft.get_arrayIndexType), _this->lpVtbl->get_arrayIndexType);
        Call(_this, sb, nameof(Vft.get_packed), _this->lpVtbl->get_packed);
        Call(_this, sb, nameof(Vft.get_constructor), _this->lpVtbl->get_constructor);
        Call(_this, sb, nameof(Vft.get_overloadedOperator), _this->lpVtbl->get_overloadedOperator);
        Call(_this, sb, nameof(Vft.get_nested), _this->lpVtbl->get_nested);
        Call(_this, sb, nameof(Vft.get_hasNestedTypes), _this->lpVtbl->get_hasNestedTypes);
        Call(_this, sb, nameof(Vft.get_hasAssignmentOperator), _this->lpVtbl->get_hasAssignmentOperator);
        Call(_this, sb, nameof(Vft.get_hasCastOperator), _this->lpVtbl->get_hasCastOperator);
        Call(_this, sb, nameof(Vft.get_scoped), _this->lpVtbl->get_scoped);
        Call(_this, sb, nameof(Vft.get_virtualBaseClass), _this->lpVtbl->get_virtualBaseClass);
        Call(_this, sb, nameof(Vft.get_indirectVirtualBaseClass), _this->lpVtbl->get_indirectVirtualBaseClass);
        Call(_this, sb, nameof(Vft.get_virtualBasePointerOffset), _this->lpVtbl->get_virtualBasePointerOffset);
        Call(_this, sb, nameof(Vft.get_virtualTableShape), _this->lpVtbl->get_virtualTableShape);
        Call(_this, sb, nameof(Vft.get_lexicalParentId), _this->lpVtbl->get_lexicalParentId);
        Call(_this, sb, nameof(Vft.get_classParentId), _this->lpVtbl->get_classParentId);
        Call(_this, sb, nameof(Vft.get_typeId), _this->lpVtbl->get_typeId);
        Call(_this, sb, nameof(Vft.get_arrayIndexTypeId), _this->lpVtbl->get_arrayIndexTypeId);
        Call(_this, sb, nameof(Vft.get_virtualTableShapeId), _this->lpVtbl->get_virtualTableShapeId);
        Call(_this, sb, nameof(Vft.get_code), _this->lpVtbl->get_code);
        Call(_this, sb, nameof(Vft.get_function), _this->lpVtbl->get_function);
        Call(_this, sb, nameof(Vft.get_managed), _this->lpVtbl->get_managed);
        Call(_this, sb, nameof(Vft.get_msil), _this->lpVtbl->get_msil);
        Call(_this, sb, nameof(Vft.get_virtualBaseDispIndex), _this->lpVtbl->get_virtualBaseDispIndex);
        Call(_this, sb, nameof(Vft.get_undecoratedName), _this->lpVtbl->get_undecoratedName);
        Call(_this, sb, nameof(Vft.get_age), _this->lpVtbl->get_age);
        Call(_this, sb, nameof(Vft.get_signature), _this->lpVtbl->get_signature);
        Call(_this, sb, nameof(Vft.get_compilerGenerated), _this->lpVtbl->get_compilerGenerated);
        Call(_this, sb, nameof(Vft.get_addressTaken), _this->lpVtbl->get_addressTaken);
        Call(_this, sb, nameof(Vft.get_rank), _this->lpVtbl->get_rank);
        Call(_this, sb, nameof(Vft.get_lowerBound), _this->lpVtbl->get_lowerBound);
        Call(_this, sb, nameof(Vft.get_upperBound), _this->lpVtbl->get_upperBound);
        Call(_this, sb, nameof(Vft.get_lowerBoundId), _this->lpVtbl->get_lowerBoundId);
        Call(_this, sb, nameof(Vft.get_upperBoundId), _this->lpVtbl->get_upperBoundId);
        Call(_this, sb, nameof(Vft.get_dataBytes), _this->lpVtbl->get_dataBytes);
        //Call(_this, sb, nameof(Vft.findChildren), _this->lpVtbl->findChildren);
        //Call(_this, sb, nameof(Vft.findChildrenEx), _this->lpVtbl->findChildrenEx);
        //Call(_this, sb, nameof(Vft.findChildrenExByAddr), _this->lpVtbl->findChildrenExByAddr);
        //Call(_this, sb, nameof(Vft.findChildrenExByVA), _this->lpVtbl->findChildrenExByVA);
        //Call(_this, sb, nameof(Vft.findChildrenExByRVA), _this->lpVtbl->findChildrenExByRVA);
        Call(_this, sb, nameof(Vft.get_targetSection), _this->lpVtbl->get_targetSection);
        Call(_this, sb, nameof(Vft.get_targetOffset), _this->lpVtbl->get_targetOffset);
        Call(_this, sb, nameof(Vft.get_targetRelativeVirtualAddress), _this->lpVtbl->get_targetRelativeVirtualAddress);
        Call(_this, sb, nameof(Vft.get_targetVirtualAddress), _this->lpVtbl->get_targetVirtualAddress);
        Call(_this, sb, nameof(Vft.get_machineType), _this->lpVtbl->get_machineType);
        Call(_this, sb, nameof(Vft.get_oemId), _this->lpVtbl->get_oemId);
        Call(_this, sb, nameof(Vft.get_oemSymbolId), _this->lpVtbl->get_oemSymbolId);
        Call(_this, sb, nameof(Vft.get_types), _this->lpVtbl->get_types);
        Call(_this, sb, nameof(Vft.get_typeIds), _this->lpVtbl->get_typeIds);
        Call(_this, sb, nameof(Vft.get_objectPointerType), _this->lpVtbl->get_objectPointerType);
        //Call(_this, sb, nameof(Vft.get_undecoratedNameEx), _this->lpVtbl->get_undecoratedNameEx);
        Call(_this, sb, nameof(Vft.get_noReturn), _this->lpVtbl->get_noReturn);
        Call(_this, sb, nameof(Vft.get_customCallingConvention), _this->lpVtbl->get_customCallingConvention);
        Call(_this, sb, nameof(Vft.get_noInline), _this->lpVtbl->get_noInline);
        Call(_this, sb, nameof(Vft.get_optimizedCodeDebugInfo), _this->lpVtbl->get_optimizedCodeDebugInfo);
        Call(_this, sb, nameof(Vft.get_notReached), _this->lpVtbl->get_notReached);
        Call(_this, sb, nameof(Vft.get_interruptReturn), _this->lpVtbl->get_interruptReturn);
        Call(_this, sb, nameof(Vft.get_farReturn), _this->lpVtbl->get_farReturn);
        Call(_this, sb, nameof(Vft.get_isStatic), _this->lpVtbl->get_isStatic);
        Call(_this, sb, nameof(Vft.get_hasDebugInfo), _this->lpVtbl->get_hasDebugInfo);
        Call(_this, sb, nameof(Vft.get_isLTCG), _this->lpVtbl->get_isLTCG);
        Call(_this, sb, nameof(Vft.get_isDataAligned), _this->lpVtbl->get_isDataAligned);
        Call(_this, sb, nameof(Vft.get_hasSecurityChecks), _this->lpVtbl->get_hasSecurityChecks);
        Call(_this, sb, nameof(Vft.get_compilerName), _this->lpVtbl->get_compilerName);
        Call(_this, sb, nameof(Vft.get_hasAlloca), _this->lpVtbl->get_hasAlloca);
        Call(_this, sb, nameof(Vft.get_hasSetJump), _this->lpVtbl->get_hasSetJump);
        Call(_this, sb, nameof(Vft.get_hasLongJump), _this->lpVtbl->get_hasLongJump);
        Call(_this, sb, nameof(Vft.get_hasInlAsm), _this->lpVtbl->get_hasInlAsm);
        Call(_this, sb, nameof(Vft.get_hasEH), _this->lpVtbl->get_hasEH);
        Call(_this, sb, nameof(Vft.get_hasSEH), _this->lpVtbl->get_hasSEH);
        Call(_this, sb, nameof(Vft.get_hasEHa), _this->lpVtbl->get_hasEHa);
        Call(_this, sb, nameof(Vft.get_isNaked), _this->lpVtbl->get_isNaked);
        Call(_this, sb, nameof(Vft.get_isAggregated), _this->lpVtbl->get_isAggregated);
        Call(_this, sb, nameof(Vft.get_isSplitted), _this->lpVtbl->get_isSplitted);
        Call(_this, sb, nameof(Vft.get_container), _this->lpVtbl->get_container);
        Call(_this, sb, nameof(Vft.get_inlSpec), _this->lpVtbl->get_inlSpec);
        Call(_this, sb, nameof(Vft.get_noStackOrdering), _this->lpVtbl->get_noStackOrdering);
        Call(_this, sb, nameof(Vft.get_virtualBaseTableType), _this->lpVtbl->get_virtualBaseTableType);
        Call(_this, sb, nameof(Vft.get_hasManagedCode), _this->lpVtbl->get_hasManagedCode);
        Call(_this, sb, nameof(Vft.get_isHotpatchable), _this->lpVtbl->get_isHotpatchable);
        Call(_this, sb, nameof(Vft.get_isCVTCIL), _this->lpVtbl->get_isCVTCIL);
        Call(_this, sb, nameof(Vft.get_isMSILNetmodule), _this->lpVtbl->get_isMSILNetmodule);
        Call(_this, sb, nameof(Vft.get_isCTypes), _this->lpVtbl->get_isCTypes);
        Call(_this, sb, nameof(Vft.get_isStripped), _this->lpVtbl->get_isStripped);
        Call(_this, sb, nameof(Vft.get_frontEndQFE), _this->lpVtbl->get_frontEndQFE);
        Call(_this, sb, nameof(Vft.get_backEndQFE), _this->lpVtbl->get_backEndQFE);
        Call(_this, sb, nameof(Vft.get_wasInlined), _this->lpVtbl->get_wasInlined);
        Call(_this, sb, nameof(Vft.get_strictGSCheck), _this->lpVtbl->get_strictGSCheck);
        Call(_this, sb, nameof(Vft.get_isCxxReturnUdt), _this->lpVtbl->get_isCxxReturnUdt);
        Call(_this, sb, nameof(Vft.get_isConstructorVirtualBase), _this->lpVtbl->get_isConstructorVirtualBase);
        Call(_this, sb, nameof(Vft.get_RValueReference), _this->lpVtbl->get_RValueReference);
        Call(_this, sb, nameof(Vft.get_unmodifiedType), _this->lpVtbl->get_unmodifiedType);
        Call(_this, sb, nameof(Vft.get_framePointerPresent), _this->lpVtbl->get_framePointerPresent);
        Call(_this, sb, nameof(Vft.get_isSafeBuffers), _this->lpVtbl->get_isSafeBuffers);
        Call(_this, sb, nameof(Vft.get_intrinsic), _this->lpVtbl->get_intrinsic);
        Call(_this, sb, nameof(Vft.get_sealed), _this->lpVtbl->get_sealed);
        Call(_this, sb, nameof(Vft.get_hfaFloat), _this->lpVtbl->get_hfaFloat);
        Call(_this, sb, nameof(Vft.get_hfaDouble), _this->lpVtbl->get_hfaDouble);
        Call(_this, sb, nameof(Vft.get_liveRangeStartAddressSection), _this->lpVtbl->get_liveRangeStartAddressSection);
        Call(_this, sb, nameof(Vft.get_liveRangeStartAddressOffset), _this->lpVtbl->get_liveRangeStartAddressOffset);
        Call(_this, sb, nameof(Vft.get_liveRangeStartRelativeVirtualAddress), _this->lpVtbl->get_liveRangeStartRelativeVirtualAddress);
        Call(_this, sb, nameof(Vft.get_countLiveRanges), _this->lpVtbl->get_countLiveRanges);
        Call(_this, sb, nameof(Vft.get_liveRangeLength), _this->lpVtbl->get_liveRangeLength);
        Call(_this, sb, nameof(Vft.get_offsetInUdt), _this->lpVtbl->get_offsetInUdt);
        Call(_this, sb, nameof(Vft.get_paramBasePointerRegisterId), _this->lpVtbl->get_paramBasePointerRegisterId);
        Call(_this, sb, nameof(Vft.get_localBasePointerRegisterId), _this->lpVtbl->get_localBasePointerRegisterId);
        Call(_this, sb, nameof(Vft.get_isLocationControlFlowDependent), _this->lpVtbl->get_isLocationControlFlowDependent);
        Call(_this, sb, nameof(Vft.get_stride), _this->lpVtbl->get_stride);
        Call(_this, sb, nameof(Vft.get_numberOfRows), _this->lpVtbl->get_numberOfRows);
        Call(_this, sb, nameof(Vft.get_numberOfColumns), _this->lpVtbl->get_numberOfColumns);
        Call(_this, sb, nameof(Vft.get_isMatrixRowMajor), _this->lpVtbl->get_isMatrixRowMajor);
        Call(_this, sb, nameof(Vft.get_numericProperties), _this->lpVtbl->get_numericProperties);
        Call(_this, sb, nameof(Vft.get_modifierValues), _this->lpVtbl->get_modifierValues);
        Call(_this, sb, nameof(Vft.get_isReturnValue), _this->lpVtbl->get_isReturnValue);
        Call(_this, sb, nameof(Vft.get_isOptimizedAway), _this->lpVtbl->get_isOptimizedAway);
        Call(_this, sb, nameof(Vft.get_builtInKind), _this->lpVtbl->get_builtInKind);
        Call(_this, sb, nameof(Vft.get_registerType), _this->lpVtbl->get_registerType);
        Call(_this, sb, nameof(Vft.get_baseDataSlot), _this->lpVtbl->get_baseDataSlot);
        Call(_this, sb, nameof(Vft.get_baseDataOffset), _this->lpVtbl->get_baseDataOffset);
        Call(_this, sb, nameof(Vft.get_textureSlot), _this->lpVtbl->get_textureSlot);
        Call(_this, sb, nameof(Vft.get_samplerSlot), _this->lpVtbl->get_samplerSlot);
        Call(_this, sb, nameof(Vft.get_uavSlot), _this->lpVtbl->get_uavSlot);
        Call(_this, sb, nameof(Vft.get_sizeInUdt), _this->lpVtbl->get_sizeInUdt);
        Call(_this, sb, nameof(Vft.get_memorySpaceKind), _this->lpVtbl->get_memorySpaceKind);
        Call(_this, sb, nameof(Vft.get_unmodifiedTypeId), _this->lpVtbl->get_unmodifiedTypeId);
        Call(_this, sb, nameof(Vft.get_subTypeId), _this->lpVtbl->get_subTypeId);
        Call(_this, sb, nameof(Vft.get_subType), _this->lpVtbl->get_subType);
        Call(_this, sb, nameof(Vft.get_numberOfModifiers), _this->lpVtbl->get_numberOfModifiers);
        Call(_this, sb, nameof(Vft.get_numberOfRegisterIndices), _this->lpVtbl->get_numberOfRegisterIndices);
        Call(_this, sb, nameof(Vft.get_isHLSLData), _this->lpVtbl->get_isHLSLData);
        Call(_this, sb, nameof(Vft.get_isPointerToDataMember), _this->lpVtbl->get_isPointerToDataMember);
        Call(_this, sb, nameof(Vft.get_isPointerToMemberFunction), _this->lpVtbl->get_isPointerToMemberFunction);
        Call(_this, sb, nameof(Vft.get_isSingleInheritance), _this->lpVtbl->get_isSingleInheritance);
        Call(_this, sb, nameof(Vft.get_isMultipleInheritance), _this->lpVtbl->get_isMultipleInheritance);
        Call(_this, sb, nameof(Vft.get_isVirtualInheritance), _this->lpVtbl->get_isVirtualInheritance);
        Call(_this, sb, nameof(Vft.get_restrictedType), _this->lpVtbl->get_restrictedType);
        Call(_this, sb, nameof(Vft.get_isPointerBasedOnSymbolValue), _this->lpVtbl->get_isPointerBasedOnSymbolValue);
        Call(_this, sb, nameof(Vft.get_baseSymbol), _this->lpVtbl->get_baseSymbol);
        Call(_this, sb, nameof(Vft.get_baseSymbolId), _this->lpVtbl->get_baseSymbolId);
        Call(_this, sb, nameof(Vft.get_objectFileName), _this->lpVtbl->get_objectFileName);
        Call(_this, sb, nameof(Vft.get_isAcceleratorGroupSharedLocal), _this->lpVtbl->get_isAcceleratorGroupSharedLocal);
        Call(_this, sb, nameof(Vft.get_isAcceleratorPointerTagLiveRange), _this->lpVtbl->get_isAcceleratorPointerTagLiveRange);
        Call(_this, sb, nameof(Vft.get_isAcceleratorStubFunction), _this->lpVtbl->get_isAcceleratorStubFunction);
        Call(_this, sb, nameof(Vft.get_numberOfAcceleratorPointerTags), _this->lpVtbl->get_numberOfAcceleratorPointerTags);
        Call(_this, sb, nameof(Vft.get_isSdl), _this->lpVtbl->get_isSdl);
        Call(_this, sb, nameof(Vft.get_isWinRTPointer), _this->lpVtbl->get_isWinRTPointer);
        Call(_this, sb, nameof(Vft.get_isRefUdt), _this->lpVtbl->get_isRefUdt);
        Call(_this, sb, nameof(Vft.get_isValueUdt), _this->lpVtbl->get_isValueUdt);
        Call(_this, sb, nameof(Vft.get_isInterfaceUdt), _this->lpVtbl->get_isInterfaceUdt);
        Call(_this, sb, nameof(Vft.findInlineFramesByAddr), _this->lpVtbl->findInlineFramesByAddr);
        Call(_this, sb, nameof(Vft.findInlineFramesByRVA), _this->lpVtbl->findInlineFramesByRVA);
        Call(_this, sb, nameof(Vft.findInlineFramesByVA), _this->lpVtbl->findInlineFramesByVA);
        Call(_this, sb, nameof(Vft.findInlineeLines), _this->lpVtbl->findInlineeLines);
        Call(_this, sb, nameof(Vft.findInlineeLinesByAddr), _this->lpVtbl->findInlineeLinesByAddr);
        Call(_this, sb, nameof(Vft.findInlineeLinesByRVA), _this->lpVtbl->findInlineeLinesByRVA);
        Call(_this, sb, nameof(Vft.findInlineeLinesByVA), _this->lpVtbl->findInlineeLinesByVA);
        //Call(_this, sb, nameof(Vft.findSymbolsForAcceleratorPointerTag), _this->lpVtbl->findSymbolsForAcceleratorPointerTag);
        //Call(_this, sb, nameof(Vft.findSymbolsByRVAForAcceleratorPointerTag), _this->lpVtbl->findSymbolsByRVAForAcceleratorPointerTag);
        Call(_this, sb, nameof(Vft.get_acceleratorPointerTags), _this->lpVtbl->get_acceleratorPointerTags);
        //Call(_this, sb, nameof(Vft.getSrcLineOnTypeDefn), _this->lpVtbl->getSrcLineOnTypeDefn);
        Call(_this, sb, nameof(Vft.get_isPGO), _this->lpVtbl->get_isPGO);
        Call(_this, sb, nameof(Vft.get_hasValidPGOCounts), _this->lpVtbl->get_hasValidPGOCounts);
        Call(_this, sb, nameof(Vft.get_isOptimizedForSpeed), _this->lpVtbl->get_isOptimizedForSpeed);
        Call(_this, sb, nameof(Vft.get_PGOEntryCount), _this->lpVtbl->get_PGOEntryCount);
        Call(_this, sb, nameof(Vft.get_PGOEdgeCount), _this->lpVtbl->get_PGOEdgeCount);
        Call(_this, sb, nameof(Vft.get_PGODynamicInstructionCount), _this->lpVtbl->get_PGODynamicInstructionCount);
        Call(_this, sb, nameof(Vft.get_staticSize), _this->lpVtbl->get_staticSize);
        Call(_this, sb, nameof(Vft.get_finalLiveStaticSize), _this->lpVtbl->get_finalLiveStaticSize);
        Call(_this, sb, nameof(Vft.get_phaseName), _this->lpVtbl->get_phaseName);
        Call(_this, sb, nameof(Vft.get_hasControlFlowCheck), _this->lpVtbl->get_hasControlFlowCheck);
        Call(_this, sb, nameof(Vft.get_constantExport), _this->lpVtbl->get_constantExport);
        Call(_this, sb, nameof(Vft.get_dataExport), _this->lpVtbl->get_dataExport);
        Call(_this, sb, nameof(Vft.get_privateExport), _this->lpVtbl->get_privateExport);
        Call(_this, sb, nameof(Vft.get_noNameExport), _this->lpVtbl->get_noNameExport);
        Call(_this, sb, nameof(Vft.get_exportHasExplicitlyAssignedOrdinal), _this->lpVtbl->get_exportHasExplicitlyAssignedOrdinal);
        Call(_this, sb, nameof(Vft.get_exportIsForwarder), _this->lpVtbl->get_exportIsForwarder);
        Call(_this, sb, nameof(Vft.get_ordinal), _this->lpVtbl->get_ordinal);
        Call(_this, sb, nameof(Vft.get_frameSize), _this->lpVtbl->get_frameSize);
        Call(_this, sb, nameof(Vft.get_exceptionHandlerAddressSection), _this->lpVtbl->get_exceptionHandlerAddressSection);
        Call(_this, sb, nameof(Vft.get_exceptionHandlerAddressOffset), _this->lpVtbl->get_exceptionHandlerAddressOffset);
        Call(_this, sb, nameof(Vft.get_exceptionHandlerRelativeVirtualAddress), _this->lpVtbl->get_exceptionHandlerRelativeVirtualAddress);
        Call(_this, sb, nameof(Vft.get_exceptionHandlerVirtualAddress), _this->lpVtbl->get_exceptionHandlerVirtualAddress);
        Call(_this, sb, nameof(Vft.findInputAssemblyFile), _this->lpVtbl->findInputAssemblyFile);
        Call(_this, sb, nameof(Vft.get_characteristics), _this->lpVtbl->get_characteristics);
        Call(_this, sb, nameof(Vft.get_coffGroup), _this->lpVtbl->get_coffGroup);
        Call(_this, sb, nameof(Vft.get_bindID), _this->lpVtbl->get_bindID);
        Call(_this, sb, nameof(Vft.get_bindSpace), _this->lpVtbl->get_bindSpace);
        Call(_this, sb, nameof(Vft.get_bindSlot), _this->lpVtbl->get_bindSlot);


        return sb.ToString();
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Vft
    {
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, Guid*, void**, int> QueryInterface;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, uint> AddRef;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, uint> Release;

        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_symIndexId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, SymTag*, HRESULT> get_symTag;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_name;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol **, HRESULT> get_lexicalParent;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol **, HRESULT> get_classParent;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol **, HRESULT> get_type;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, DataKind*, HRESULT> get_dataKind;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_locationType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_addressSection;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_addressOffset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_relativeVirtualAddress;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, ulong*, HRESULT> get_virtualAddress;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_registerId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_offset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, ulong*, HRESULT> get_length;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_slot;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_volatileType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_constType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_unalignedType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, CV_access_e*, HRESULT> get_access;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_libraryName;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_platform;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_language;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_editAndContinueEnabled;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_frontEndMajor;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_frontEndMinor;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_frontEndBuild;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_backEndMajor;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_backEndMinor;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_backEndBuild;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_sourceFileName;
        [Obsolete] public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_unused;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_thunkOrdinal;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_thisAdjust;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_virtualBaseOffset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_virtual;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_intro;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_pure;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, CallConv*, HRESULT> get_callingConvention;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, ComVariant*, HRESULT> get_value;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BasicType*, HRESULT> get_baseType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_token;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_timeStamp;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, Guid*, HRESULT> get_guid;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_symbolsFileName;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_reference;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_count;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_bitPosition;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol **, HRESULT> get_arrayIndexType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_packed;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_constructor;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_overloadedOperator;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_nested;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasNestedTypes;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasAssignmentOperator;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasCastOperator;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_scoped;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_virtualBaseClass;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_indirectVirtualBaseClass;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_virtualBasePointerOffset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_virtualTableShape;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_lexicalParentId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_classParentId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_typeId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_arrayIndexTypeId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_virtualTableShapeId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_code;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_function;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_managed;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_msil;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_virtualBaseDispIndex;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_undecoratedName;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_age;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_signature;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_compilerGenerated;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_addressTaken;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_rank;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_lowerBound;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_upperBound;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_lowerBoundId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_upperBoundId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, byte**, HRESULT> get_dataBytes;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, SymTag, char*, int, IDiaEnumSymbols**, HRESULT> findChildren;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, SymTag, char*, int, IDiaEnumSymbols**, HRESULT> findChildrenEx;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, SymTag, char*, int, int, IDiaEnumSymbols**, HRESULT> findChildrenExByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, SymTag, char*, int, int, IDiaEnumSymbols**, HRESULT> findChildrenExByVA;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, SymTag, char*, int, int, IDiaEnumSymbols**, HRESULT> findChildrenExByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_targetSection;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_targetOffset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_targetRelativeVirtualAddress;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_targetVirtualAddress;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_machineType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_oemId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_oemSymbolId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, IDiaSymbol**, HRESULT> get_types;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, int**, HRESULT> get_typeIds;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol **, HRESULT> get_objectPointerType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, UdtKind*, HRESULT> get_udtKind;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, BSTR*, HRESULT> get_undecoratedNameEx;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_noReturn;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_customCallingConvention;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_noInline;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_optimizedCodeDebugInfo;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_notReached;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_interruptReturn;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_farReturn;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isStatic;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasDebugInfo;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isLTCG;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isDataAligned;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasSecurityChecks;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_compilerName;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*,HRESULT> get_hasAlloca;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*,HRESULT> get_hasSetJump;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*,HRESULT> get_hasLongJump;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*,HRESULT> get_hasInlAsm;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*,HRESULT> get_hasEH;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*,HRESULT> get_hasSEH;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*,HRESULT> get_hasEHa;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isNaked;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isAggregated;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isSplitted;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_container;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_inlSpec;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_noStackOrdering;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_virtualBaseTableType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasManagedCode;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isHotpatchable;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isCVTCIL;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isMSILNetmodule;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isCTypes;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isStripped;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_frontEndQFE;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_backEndQFE;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_wasInlined;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_strictGSCheck;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isCxxReturnUdt;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isConstructorVirtualBase;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_RValueReference;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_unmodifiedType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_framePointerPresent;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isSafeBuffers;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_intrinsic;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_sealed;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hfaFloat;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hfaDouble;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_liveRangeStartAddressSection;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_liveRangeStartAddressOffset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_liveRangeStartRelativeVirtualAddress;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_countLiveRanges;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, ulong*, HRESULT> get_liveRangeLength;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_offsetInUdt;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_paramBasePointerRegisterId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_localBasePointerRegisterId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isLocationControlFlowDependent;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_stride;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_numberOfRows;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_numberOfColumns;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isMatrixRowMajor;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, int**, HRESULT> get_numericProperties;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, int**, HRESULT> get_modifierValues;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isReturnValue;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isOptimizedAway;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_builtInKind;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_registerType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_baseDataSlot;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_baseDataOffset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_textureSlot;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_samplerSlot;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_uavSlot;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_sizeInUdt;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_memorySpaceKind;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_unmodifiedTypeId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_subTypeId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_subType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_numberOfModifiers;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_numberOfRegisterIndices;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isHLSLData;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isPointerToDataMember;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isPointerToMemberFunction;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isSingleInheritance;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isMultipleInheritance;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isVirtualInheritance;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_restrictedType;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isPointerBasedOnSymbolValue;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_baseSymbol;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_baseSymbolId;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_objectFileName;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isAcceleratorGroupSharedLocal;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isAcceleratorPointerTagLiveRange;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isAcceleratorStubFunction;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_numberOfAcceleratorPointerTags;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isSdl;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isWinRTPointer;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isRefUdt;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isValueUdt;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isInterfaceUdt;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInlineFramesByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInlineFramesByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInlineFramesByVA;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInlineeLines;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInlineeLinesByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInlineeLinesByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInlineeLinesByVA;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, IDiaEnumSymbols**, HRESULT> findSymbolsForAcceleratorPointerTag;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int, IDiaEnumSymbols**, HRESULT> findSymbolsByRVAForAcceleratorPointerTag;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int, int*, int**, HRESULT> get_acceleratorPointerTags;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, void**, HRESULT> getSrcLineOnTypeDefn;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isPGO;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasValidPGOCounts;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_isOptimizedForSpeed;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_PGOEntryCount;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_PGOEdgeCount;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, ulong*, HRESULT> get_PGODynamicInstructionCount;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_staticSize;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_finalLiveStaticSize;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, BSTR*, HRESULT> get_phaseName;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_hasControlFlowCheck;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_constantExport;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_dataExport;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_privateExport;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_noNameExport;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_exportHasExplicitlyAssignedOrdinal;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, byte*, HRESULT> get_exportIsForwarder;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_ordinal;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_frameSize;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> get_exceptionHandlerAddressSection;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> get_exceptionHandlerAddressOffset;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> get_exceptionHandlerRelativeVirtualAddress;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> get_exceptionHandlerVirtualAddress;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> findInputAssemblyFile; // Retrieves the .NET Native input assembly file that is the parent of the symbol.
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, int*, HRESULT> get_characteristics;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, IDiaSymbol**, HRESULT> get_coffGroup;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> get_bindID;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> get_bindSpace;
        public delegate* unmanaged[Stdcall]<IDiaSymbol*, HRESULT> get_bindSlot;
    }
}