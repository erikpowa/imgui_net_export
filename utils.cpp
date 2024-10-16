#include "utils.h"

#include <dbghelp.h>
#include <iostream>
#include <sstream>

wstring wstring_replace(wstring str, const wstring& from, const wstring& to) {
    size_t pos = str.find(from);
    while (pos != wstring::npos) {
        str.replace(pos, from.length(), to);
        pos = str.find(from, pos + to.length());
    }
    return str;
}

wstring wstring_from(unsigned long value)
{
    wchar_t buffer[32];
    swprintf(buffer, 32, L"%d", value);
    return wstring{buffer};
}

bool wstring_startswith(const wstring& str, const wstring& prefix) {
    if (str.size() < prefix.size()) {
        return false;
    }
    return str.compare(0, prefix.size(), prefix) == 0;
}

bool wstring_contains(const wstring& str, const wchar_t &value) {
    return str.find(value) != wstring::npos;
}

bool wstring_contains(const wstring &str, const wstring &value) {
    return (str.find(value) != wstring::npos);
}

wstring GetDataKindName(const DWORD dwDataKind)
{
    switch (dwDataKind) {
    case DataIsLocal: return L"Local";
    case DataIsStaticLocal: return L"StaticLocal";
    case DataIsParam: return L"Param";
    case DataIsObjectPtr: return L"ObjectPtr";
    case DataIsFileStatic: return L"FileStatic";
    case DataIsGlobal: return L"Global";
    case DataIsMember: return L"Member";
    case DataIsStaticMember: return L"StaticMember";
    case DataIsConstant: return L"Constant";
    case DataIsUnknown:
    default:
        break;
    }

    return L"Unknown";
}

const wchar_t* GetSymTagName(const DWORD symTag) {
    switch (symTag) {
    case SymTagNull: return L"SymTagNull";
    case SymTagExe: return L"SymTagExe";
    case SymTagCompiland: return L"SymTagCompiland";
    case SymTagCompilandDetails: return L"SymTagCompilandDetails";
    case SymTagCompilandEnv: return L"SymTagCompilandEnv";
    case SymTagFunction: return L"SymTagFunction";
    case SymTagBlock: return L"SymTagBlock";
    case SymTagData: return L"SymTagData";
    case SymTagAnnotation: return L"SymTagAnnotation";
    case SymTagLabel: return L"SymTagLabel";
    case SymTagPublicSymbol: return L"SymTagPublicSymbol";
    case SymTagUDT: return L"SymTagUDT";
    case SymTagEnum: return L"SymTagEnum";
    case SymTagFunctionType: return L"SymTagFunctionType";
    case SymTagPointerType: return L"SymTagPointerType";
    case SymTagArrayType: return L"SymTagArrayType";
    case SymTagBaseType: return L"SymTagBaseType";
    case SymTagTypedef: return L"SymTagTypedef";
    case SymTagBaseClass: return L"SymTagBaseClass";
    case SymTagFriend: return L"SymTagFriend";
    case SymTagFunctionArgType: return L"SymTagFunctionArgType";
    case SymTagFuncDebugStart: return L"SymTagFuncDebugStart";
    case SymTagFuncDebugEnd: return L"SymTagFuncDebugEnd";
    case SymTagUsingNamespace: return L"SymTagUsingNamespace";
    case SymTagVTableShape: return L"SymTagVTableShape";
    case SymTagVTable: return L"SymTagVTable";
    case SymTagCustom: return L"SymTagCustom";
    case SymTagThunk: return L"SymTagThunk";
    case SymTagCustomType: return L"SymTagCustomType";
    case SymTagManagedType: return L"SymTagManagedType";
    case SymTagDimension: return L"SymTagDimension";
    case SymTagCallSite: return L"SymTagCallSite";
    case SymTagInlineSite: return L"SymTagInlineSite";
    case SymTagBaseInterface: return L"SymTagBaseInterface";
    case SymTagVectorType: return L"SymTagVectorType";
    case SymTagMatrixType: return L"SymTagMatrixType";
    case SymTagHLSLType: return L"SymTagHLSLType";
    case SymTagCaller: return L"SymTagCaller";
    case SymTagCallee: return L"SymTagCallee";
    case SymTagExport: return L"SymTagExport";
    case SymTagHeapAllocationSite: return L"SymTagHeapAllocationSite";
    case SymTagCoffGroup: return L"SymTagCoffGroup";
    case SymTagInlinee: return L"SymTagInlinee";
    case SymTagTaggedUnionCase: return L"SymTagTaggedUnionCase";
    case SymTagMax: return L"SymTagMax";
    default:
        return L"Unknown SymTag";
    }
}

wstring BaseTypeToString(const DWORD &baseType)
{
    switch (baseType) {
        case btNoType: return L"btNoType";
        case btVoid: return L"btVoid";
        case btChar: return L"btChar";
        case btWChar: return L"btWChar";
        case btInt: return L"btInt";
        case btUInt: return L"btUInt";
        case btFloat: return L"btFloat";
        case btBCD: return L"btBCD";
        case btBool: return L"btBool";
        case btLong: return L"btLong";
        case btULong: return L"btULong";
        case btCurrency: return L"btCurrency";
        case btDate: return L"btDate";
        case btVariant: return L"btVariant";
        case btComplex: return L"btComplex";
        case btBit: return L"btBit";
        case btBSTR: return L"btBSTR";
        case btHresult: return L"btHresult";
        case btChar16: return L"btChar16";
        case btChar32: return L"btChar32";
        case btChar8: return L"btChar8";
        default: return L"Unknown";
    }
}

wstring GetTypeNameByBaseType(const DWORD &baseType, const ULONGLONG &bytes)
{
    if(baseType == btNoType) return L"void";
    if(bytes == 0 && baseType == btVoid) return L"void";

    if(bytes == 1 && baseType == btChar) return L"byte"; // make "char" signed since its unspecified in c++ whenever its signed or not
    if(bytes == 1 && baseType == btBool) return L"byte";
    if(bytes == 1 && baseType == btInt) return L"sbyte";
    if(bytes == 1 && baseType == btUInt) return L"byte";

    if(bytes == 2 && baseType == btInt) return L"short";
    if(bytes == 2 && baseType == btUInt) return L"ushort";

    if(bytes == 4 && baseType == btInt) return L"int";
    if(bytes == 4 && baseType == btUInt) return L"uint";
    if(bytes == 4 && baseType == btFloat) return L"float";

    if(bytes == 8 && baseType == btInt) return L"long";
    if(bytes == 8 && baseType == btUInt) return L"ulong";
    //if(bytes == 8 && baseType == btULong) return L"ulong";
    if(bytes == 8 && baseType == btFloat) return L"double";

    wcout << L"Unhandled base type conversion: " << bytes << "bytes = " << BaseTypeToString(baseType) << endl;

    return L"void";
}



wstring LocationTypeToString(const DWORD &locationType)
{
    switch (locationType) {
        case LocationType::LocIsNull: return L"LocIsNull";
        case LocIsStatic: return L"LocIsStatic";
        case LocIsTLS: return L"LocIsTLS";
        case LocIsRegRel: return L"LocIsRegRel";
        case LocIsThisRel: return L"LocIsThisRel";
        case LocIsEnregistered: return L"LocIsEnregistered";
        case LocIsBitField: return L"LocIsBitField";
        case LocIsSlot: return L"LocIsSlot";
        case LocIsIlRel: return L"LocIsIlRel";
        case LocInMetaData: return L"LocInMetaData";
        case LocIsConstant: return L"LocIsConstant";
        case LocIsRegRelAliasIndir: return L"LocIsRegRelAliasIndir";
        case LocTypeMax: return L"LocTypeMax";
        default: return L"Unknown";
    }
}

bool GetSymbolName(IDiaSymbol* pSymbol, wstring& result)
{
    wchar_t *name = nullptr;
    if (SUCCEEDED(pSymbol->get_name(&name)) && name != nullptr) {
        result = name;
        SysFreeString(name);
    }
    if (result.empty()) {
        return false;
    }

    if (wstring_startswith(name, L"ImBitArray<")) { // TODO: break down generic and reconstruct manually
        result = L"ImBitArray";
        return true;
    }

    // TODO manually reconstruct names instead of replace
    result = wstring_replace(result, L"<unsigned char>", L"<uint>");
    result = wstring_replace(result, L"__int64", L"long");
    result = wstring_replace(result, L"<unsigned ", L"<u");
    result = wstring_replace(result, L"<signed ", L"<s");
    result = wstring_replace(result, L" ", L"");
    result = wstring_replace(result, L"*", L"");
    result = wstring_replace(result, L"::", L"__");
    return true;
}

wstring GetTypeName(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol) {
    DWORD symTag;
    if (FAILED(pDiaSymbol->get_symTag(&symTag))) {
        return L"void*";
    }

    wstring typeName;

    switch (symTag) {
        case SymTagUDT:
            if (GetSymbolName(pDiaSymbol, typeName)) {
                return typeName;
            }
        break;
        case SymTagBaseType:
            DWORD baseType;
        if (SUCCEEDED(pDiaSymbol->get_baseType(&baseType))) {
            ULONGLONG length;
            if (SUCCEEDED(pDiaSymbol->get_length(&length))) {
                return GetTypeNameByBaseType(baseType, length);
            }
            return L"void*";
        }
        break;
        case SymTagPointerType:
            IDiaSymbol* pointerType;
        if (SUCCEEDED(pDiaSymbol->get_type(&pointerType)) && pointerType != nullptr) {
            wstring baseTypeStr = GetTypeName(pDiaSession, pointerType);
            return baseTypeStr + L"*";  // Append '*' for pointer types
        }
        break;
        case SymTagFunctionType:
            return L"void"; // TODO: break-down typedef parts and reconstruct as delegate*<>
        case SymTagArrayType:
        // char Name[40];
        // byte /*char[40]*/ Name;
        // TODO: generate InlineArray types "Array_char_40" or "Array_ImGuiKeyOwnerData_154"
        typeName = L"byte /*";
        DWORD arraySize;
        if (SUCCEEDED(pDiaSymbol->get_count(&arraySize))) { // get_length()
            IDiaSymbol* arrayType;
            if (SUCCEEDED(pDiaSymbol->get_type(&arrayType)) && arrayType != nullptr) {
                DWORD baseType2;
                if (SUCCEEDED(arrayType->get_baseType(&baseType2))) {
                    wstring arrayTypeName = GetTypeName(pDiaSession, arrayType);
                    typeName = typeName + arrayTypeName + L"[" + wstring_from(arraySize) + L"]*/";
                }
            }
        }

        return typeName;
        case SymTagEnum:
            if (GetSymbolName(pDiaSymbol, typeName)) {
                return typeName;
            }
        break;
        default:
            // unhandled
                return L"void*";
    }

    return L"void*";
}

bool GetFunctionName(IDiaSymbol* pSymbol, wstring& result)
{
    BSTR name = nullptr;
    if (SUCCEEDED(pSymbol->get_undecoratedNameEx(UNDNAME_NAME_ONLY, &name)) && name != nullptr) {
        result = name;
        SysFreeString(name);
    }

    if (result.empty()) {
        if (SUCCEEDED(pSymbol->get_name(&name)) && name != nullptr) {
            result = name;
            SysFreeString(name);
        }
    }

    if (result.empty()) {
        return false;
    }

    return true;
}

const wchar_t* GetCallingConvention(IDiaSymbol* pDiaSymbol) {
    DWORD callConv = 0;
    if (SUCCEEDED(pDiaSymbol->get_callingConvention(&callConv))) {
        switch (callConv) {
        case CV_call_e::CV_CALL_NEAR_STD:
            return L"Stdcall";
        case CV_call_e::CV_CALL_NEAR_FAST:
            return L"Fastcall";
        case CV_call_e::CV_CALL_THISCALL:
            return L"Thiscall";
        case CV_call_e::CV_CALL_NEAR_C:
            return L"Cdecl";
        default:
            // unhandled callconv
            return L"Cdecl";
        }
    }
    return L"Cdecl";
}


bool EnumChildren(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol, const enum SymTagEnum symTagEnum, const wchar_t *name, const int compareFlags, const tEnumCallback callback) {
    IDiaEnumSymbols* pDiaEnumSymbols = nullptr;
    IDiaSymbol* pDiaSymbolChild = nullptr;
    ULONG fetched;
    if (FAILED(pDiaSymbol->findChildren(symTagEnum, name, compareFlags, &pDiaEnumSymbols))) {
        return false;
    }
    while (SUCCEEDED(pDiaEnumSymbols->Next(1, &pDiaSymbolChild, &fetched)) && fetched == 1) {
        if (!callback(pDiaSession, pDiaSymbolChild)) {
            pDiaSymbolChild->Release();
            return false;
        }
        pDiaSymbolChild->Release();
    }
    pDiaEnumSymbols->Release();
    return true;
}

bool EnumExports(IDiaSession* pDiaSession, tEnumCallback callback) {
    IDiaEnumSymbols* pDiaEnumSymbols = nullptr;
    if (FAILED(pDiaSession->getExports(&pDiaEnumSymbols))) {
        return false;
    }
    IDiaSymbol* pDiaSymbolChild = nullptr;
    ULONG fetched;
    while (SUCCEEDED(pDiaEnumSymbols->Next(1, &pDiaSymbolChild, &fetched)) && fetched == 1) {
        if (!callback(pDiaSession, pDiaSymbolChild)) {
            pDiaSymbolChild->Release();
            pDiaEnumSymbols->Release();
            return false;
        }
        pDiaSymbolChild->Release();
    }
    pDiaEnumSymbols->Release();
    return true;
}







template <typename D, typename T>
void PrintProperty(D* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall D::* getter)(T*))
{
    T value;
    const HRESULT hr = (pSymbol->*getter)(&value);
    if (hr == S_OK) {
        if (is_same<T, BOOL>::value) {
            const wchar_t *value2 = value == 1 ? L"TRUE" : L"FALSE";
            wcout << propertyName << L" = " << value2 << endl;
            return;
        }
        wcout << propertyName << L" = " << value << endl;
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

void PrintPropertyDataKind(IDiaSymbol* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall IDiaSymbol::* getter)(DWORD*))
{
    DWORD value;
    const HRESULT hr = (pSymbol->*getter)(&value);
    if (hr == S_OK) {
        wcout << propertyName << L" = " << GetDataKindName(value) << endl;
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

void PrintPropertySymTag(IDiaSymbol* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall IDiaSymbol::* getter)(DWORD*))
{
    DWORD value;
    const HRESULT hr = (pSymbol->*getter)(&value);
    if (hr == S_OK) {
        wcout << propertyName << L" = " << GetSymTagName(value) << endl;
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

void PrintPropertyBaseType(IDiaSymbol* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall IDiaSymbol::* getter)(DWORD*))
{
    DWORD value;
    const HRESULT hr = (pSymbol->*getter)(&value);
    if (hr == S_OK) {
        wcout << propertyName << L" = " << BaseTypeToString(value) << endl;
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

void PrintPropertyLocationType(IDiaSymbol* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall IDiaSymbol::* getter)(DWORD*))
{
    DWORD value;
    const HRESULT hr = (pSymbol->*getter)(&value);
    if (hr == S_OK) {
        wcout << propertyName << L" = " << LocationTypeToString(value) << endl;
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

void PrintPropertyUndecoratedNameEx(IDiaSymbol* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall IDiaSymbol::* getter)(DWORD,BSTR*))
{
    BSTR name = nullptr;
    const HRESULT hr = (pSymbol->*getter)(0, &name);
    if (hr == S_OK && name != nullptr) {
        wcout << propertyName << L" = " << name << endl;
        SysFreeString(name);
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

template <typename D>
void PrintProperty(D* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall D::* getter)(IDiaSymbol**))
{
    IDiaSymbol* value = nullptr;
    const HRESULT hr = (pSymbol->*getter)(&value);
    if (hr == S_OK && value != nullptr) {
        BSTR name = nullptr;
        if (SUCCEEDED(value->get_name(&name)) && name != nullptr) {
            wcout << propertyName << L" = " << name << endl;
            SysFreeString(name);
        }
        else {
            wcout << propertyName << L" = noname" << endl;
        }
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

template <typename D>
void PrintProperty(D* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall D::* getter)(GUID*))
{
    GUID value;
    const HRESULT hr = (pSymbol->*getter)(&value);
    OLECHAR* guidString;
    if (hr == S_OK) {
        StringFromCLSID(value, &guidString);
        wcout << propertyName << L" = " << guidString << endl;
        CoTaskMemFree(guidString);
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

template <typename D>
void PrintProperty(D* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall D::* getter)(BSTR*))
{
    BSTR value;
    const HRESULT hr = (pSymbol->*getter)(&value);
    if (hr == S_OK) {
        wcout << propertyName << L" = " << value << endl;
        SysFreeString(value);
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

template <typename D>
void PrintProperty(D* pSymbol, const wchar_t* propertyName, HRESULT(__stdcall D::* getter)(VARIANT*))
{
    VARIANT value;
    VariantInit(&value);
    const HRESULT hr = (pSymbol->*getter)(&value);

    if (hr == S_OK) {
        switch (value.vt) {
        case VT_I4: // 32-bit integer
            wcout << propertyName << L" = " << value.lVal << endl;
            break;
        case VT_UI4: // 32-bit unsigned integer
            wcout << propertyName << L" = " << value.ulVal << endl;
            break;
        case VT_BSTR: // String value
            wcout << propertyName << L" = " << (value.bstrVal ? value.bstrVal : L"") << endl;
            break;
        default:
            wcout << propertyName << L" = [Unrecognized VARIANT type]" << endl;
            break;
        }
        VariantClear(&value);  // Clean up VARIANT after use
        return;
    }
    if (hr != S_FALSE) {
        wcout << propertyName << L" = Error retrieving value " << hr << endl;
    }
}

void PrintProperties(IDiaSymbol* diaSymbol)
{
    wchar_t* name = nullptr;
    if (SUCCEEDED(diaSymbol->get_name(&name)) && name) {
        wcout << L"[ Properties ] " << name << endl;
        SysFreeString(name);
    }
    else {
        DWORD symIndexId;
        if (SUCCEEDED(diaSymbol->get_symIndexId(&symIndexId)) && symIndexId) {
            wcout << L"[ Properties ] " << symIndexId << endl;
        }
    }

    PrintProperty(diaSymbol, L"get_symIndexId", &IDiaSymbol::get_symIndexId);
    PrintPropertySymTag(diaSymbol, L"get_symTag", &IDiaSymbol::get_symTag);
    PrintProperty(diaSymbol, L"get_name", &IDiaSymbol::get_name);
    PrintProperty(diaSymbol, L"get_lexicalParent", &IDiaSymbol::get_lexicalParent);
    PrintProperty(diaSymbol, L"get_classParent", &IDiaSymbol::get_classParent);
    PrintProperty(diaSymbol, L"get_type", &IDiaSymbol::get_type);
    PrintPropertyDataKind(diaSymbol, L"get_dataKind", &IDiaSymbol::get_dataKind);
    PrintPropertyLocationType(diaSymbol, L"get_locationType", &IDiaSymbol::get_locationType); // LocationType,  static or local
    PrintProperty(diaSymbol, L"get_addressSection", &IDiaSymbol::get_addressSection);
    PrintProperty(diaSymbol, L"get_addressOffset", &IDiaSymbol::get_addressOffset);
    PrintProperty(diaSymbol, L"get_relativeVirtualAddress", &IDiaSymbol::get_relativeVirtualAddress);
    PrintProperty(diaSymbol, L"get_virtualAddress", &IDiaSymbol::get_virtualAddress);
    PrintProperty(diaSymbol, L"get_registerId", &IDiaSymbol::get_registerId);
    PrintProperty(diaSymbol, L"get_offset", &IDiaSymbol::get_offset);
    PrintProperty(diaSymbol, L"get_length", &IDiaSymbol::get_length);
    PrintProperty(diaSymbol, L"get_slot", &IDiaSymbol::get_slot);
    PrintProperty(diaSymbol, L"get_volatileType", &IDiaSymbol::get_volatileType);
    PrintProperty(diaSymbol, L"get_constType", &IDiaSymbol::get_constType);
    PrintProperty(diaSymbol, L"get_unalignedType", &IDiaSymbol::get_unalignedType);
    PrintProperty(diaSymbol, L"get_access", &IDiaSymbol::get_access);
    PrintProperty(diaSymbol, L"get_libraryName", &IDiaSymbol::get_libraryName);
    PrintProperty(diaSymbol, L"get_platform", &IDiaSymbol::get_platform);
    PrintProperty(diaSymbol, L"get_language", &IDiaSymbol::get_language);
    PrintProperty(diaSymbol, L"get_editAndContinueEnabled", &IDiaSymbol::get_editAndContinueEnabled);
    PrintProperty(diaSymbol, L"get_frontEndMajor", &IDiaSymbol::get_frontEndMajor);
    PrintProperty(diaSymbol, L"get_frontEndMinor", &IDiaSymbol::get_frontEndMinor);
    PrintProperty(diaSymbol, L"get_frontEndBuild", &IDiaSymbol::get_frontEndBuild);
    PrintProperty(diaSymbol, L"get_backEndMajor", &IDiaSymbol::get_backEndMajor);
    PrintProperty(diaSymbol, L"get_backEndMinor", &IDiaSymbol::get_backEndMinor);
    PrintProperty(diaSymbol, L"get_backEndBuild", &IDiaSymbol::get_backEndBuild);
    PrintProperty(diaSymbol, L"get_sourceFileName", &IDiaSymbol::get_sourceFileName);
    // PrintProperty(diaSymbol, L"get_unused", &IDiaSymbol::get_unused);
    PrintProperty(diaSymbol, L"get_thunkOrdinal", &IDiaSymbol::get_thunkOrdinal);
    PrintProperty(diaSymbol, L"get_thisAdjust", &IDiaSymbol::get_thisAdjust);
    PrintProperty(diaSymbol, L"get_virtualBaseOffset", &IDiaSymbol::get_virtualBaseOffset);
    PrintProperty(diaSymbol, L"get_virtual", &IDiaSymbol::get_virtual);
    PrintProperty(diaSymbol, L"get_intro", &IDiaSymbol::get_intro);
    PrintProperty(diaSymbol, L"get_pure", &IDiaSymbol::get_pure);
    PrintProperty(diaSymbol, L"get_callingConvention", &IDiaSymbol::get_callingConvention);
    PrintProperty(diaSymbol, L"get_value", &IDiaSymbol::get_value);
    PrintPropertyBaseType(diaSymbol, L"get_baseType", &IDiaSymbol::get_baseType);
    PrintProperty(diaSymbol, L"get_token", &IDiaSymbol::get_token);
    PrintProperty(diaSymbol, L"get_timeStamp", &IDiaSymbol::get_timeStamp);
    PrintProperty(diaSymbol, L"get_guid", &IDiaSymbol::get_guid);
    PrintProperty(diaSymbol, L"get_symbolsFileName", &IDiaSymbol::get_symbolsFileName);
    PrintProperty(diaSymbol, L"get_reference", &IDiaSymbol::get_reference);
    PrintProperty(diaSymbol, L"get_count", &IDiaSymbol::get_count);
    PrintProperty(diaSymbol, L"get_bitPosition", &IDiaSymbol::get_bitPosition);
    PrintProperty(diaSymbol, L"get_arrayIndexType", &IDiaSymbol::get_arrayIndexType);
    PrintProperty(diaSymbol, L"get_packed", &IDiaSymbol::get_packed);
    PrintProperty(diaSymbol, L"get_constructor", &IDiaSymbol::get_constructor);
    PrintProperty(diaSymbol, L"get_overloadedOperator", &IDiaSymbol::get_overloadedOperator);
    PrintProperty(diaSymbol, L"get_nested", &IDiaSymbol::get_nested);
    PrintProperty(diaSymbol, L"get_hasNestedTypes", &IDiaSymbol::get_hasNestedTypes);
    PrintProperty(diaSymbol, L"get_hasAssignmentOperator", &IDiaSymbol::get_hasAssignmentOperator);
    PrintProperty(diaSymbol, L"get_hasCastOperator", &IDiaSymbol::get_hasCastOperator);
    PrintProperty(diaSymbol, L"get_scoped", &IDiaSymbol::get_scoped);
    PrintProperty(diaSymbol, L"get_virtualBaseClass", &IDiaSymbol::get_virtualBaseClass);
    PrintProperty(diaSymbol, L"get_indirectVirtualBaseClass", &IDiaSymbol::get_indirectVirtualBaseClass);
    PrintProperty(diaSymbol, L"get_virtualBasePointerOffset", &IDiaSymbol::get_virtualBasePointerOffset);
    PrintProperty(diaSymbol, L"get_virtualTableShape", &IDiaSymbol::get_virtualTableShape);
    PrintProperty(diaSymbol, L"get_lexicalParentId", &IDiaSymbol::get_lexicalParentId);
    PrintProperty(diaSymbol, L"get_classParentId", &IDiaSymbol::get_classParentId);
    PrintProperty(diaSymbol, L"get_typeId", &IDiaSymbol::get_typeId);
    PrintProperty(diaSymbol, L"get_arrayIndexTypeId", &IDiaSymbol::get_arrayIndexTypeId);
    PrintProperty(diaSymbol, L"get_virtualTableShapeId", &IDiaSymbol::get_virtualTableShapeId);
    PrintProperty(diaSymbol, L"get_code", &IDiaSymbol::get_code);
    PrintProperty(diaSymbol, L"get_function", &IDiaSymbol::get_function);
    PrintProperty(diaSymbol, L"get_managed", &IDiaSymbol::get_managed);
    PrintProperty(diaSymbol, L"get_msil", &IDiaSymbol::get_msil);
    PrintProperty(diaSymbol, L"get_virtualBaseDispIndex", &IDiaSymbol::get_virtualBaseDispIndex);
    PrintProperty(diaSymbol, L"get_undecoratedName", &IDiaSymbol::get_undecoratedName);
    PrintProperty(diaSymbol, L"get_age", &IDiaSymbol::get_age);
    PrintProperty(diaSymbol, L"get_signature", &IDiaSymbol::get_signature);
    PrintProperty(diaSymbol, L"get_compilerGenerated", &IDiaSymbol::get_compilerGenerated);
    PrintProperty(diaSymbol, L"get_addressTaken", &IDiaSymbol::get_addressTaken);
    PrintProperty(diaSymbol, L"get_rank", &IDiaSymbol::get_rank);
    PrintProperty(diaSymbol, L"get_lowerBound", &IDiaSymbol::get_lowerBound);
    PrintProperty(diaSymbol, L"get_upperBound", &IDiaSymbol::get_upperBound);
    PrintProperty(diaSymbol, L"get_lowerBoundId", &IDiaSymbol::get_lowerBoundId);
    PrintProperty(diaSymbol, L"get_upperBoundId", &IDiaSymbol::get_upperBoundId);
    // get_dataBytes
    // findChildren
    // findChildrenEx
    // findChildrenExByAddr
    // findChildrenExByVA
    // findChildrenExByRVA
    PrintProperty(diaSymbol, L"get_targetSection", &IDiaSymbol::get_targetSection);
    PrintProperty(diaSymbol, L"get_targetOffset", &IDiaSymbol::get_targetOffset);
    PrintProperty(diaSymbol, L"get_targetRelativeVirtualAddress", &IDiaSymbol::get_targetRelativeVirtualAddress);
    PrintProperty(diaSymbol, L"get_targetVirtualAddress", &IDiaSymbol::get_targetVirtualAddress);
    PrintProperty(diaSymbol, L"get_machineType", &IDiaSymbol::get_machineType);
    PrintProperty(diaSymbol, L"get_oemId", &IDiaSymbol::get_oemId);
    PrintProperty(diaSymbol, L"get_oemSymbolId", &IDiaSymbol::get_oemSymbolId);
    // get_types
    // get_typeIds
    PrintProperty(diaSymbol, L"get_objectPointerType", &IDiaSymbol::get_objectPointerType);
    PrintProperty(diaSymbol, L"get_udtKind", &IDiaSymbol::get_udtKind);
    PrintPropertyUndecoratedNameEx(diaSymbol, L"get_undecoratedNameEx", &IDiaSymbol::get_undecoratedNameEx);
    PrintProperty(diaSymbol, L"get_noReturn", &IDiaSymbol::get_noReturn);
    PrintProperty(diaSymbol, L"get_customCallingConvention", &IDiaSymbol::get_customCallingConvention);
    PrintProperty(diaSymbol, L"get_noInline", &IDiaSymbol::get_noInline);
    PrintProperty(diaSymbol, L"get_optimizedCodeDebugInfo", &IDiaSymbol::get_optimizedCodeDebugInfo);
    PrintProperty(diaSymbol, L"get_notReached", &IDiaSymbol::get_notReached);
    PrintProperty(diaSymbol, L"get_interruptReturn", &IDiaSymbol::get_interruptReturn);
    PrintProperty(diaSymbol, L"get_farReturn", &IDiaSymbol::get_farReturn);
    PrintProperty(diaSymbol, L"get_isStatic", &IDiaSymbol::get_isStatic);
    PrintProperty(diaSymbol, L"get_hasDebugInfo", &IDiaSymbol::get_hasDebugInfo);
    PrintProperty(diaSymbol, L"get_isLTCG", &IDiaSymbol::get_isLTCG);
    PrintProperty(diaSymbol, L"get_isDataAligned", &IDiaSymbol::get_isDataAligned);
    PrintProperty(diaSymbol, L"get_hasSecurityChecks", &IDiaSymbol::get_hasSecurityChecks);
    PrintProperty(diaSymbol, L"get_compilerName", &IDiaSymbol::get_compilerName);
    PrintProperty(diaSymbol, L"get_hasAlloca", &IDiaSymbol::get_hasAlloca);
    PrintProperty(diaSymbol, L"get_hasSetJump", &IDiaSymbol::get_hasSetJump);
    PrintProperty(diaSymbol, L"get_hasLongJump", &IDiaSymbol::get_hasLongJump);
    PrintProperty(diaSymbol, L"get_hasInlAsm", &IDiaSymbol::get_hasInlAsm);
    PrintProperty(diaSymbol, L"get_hasEH", &IDiaSymbol::get_hasEH);
    PrintProperty(diaSymbol, L"get_hasSEH", &IDiaSymbol::get_hasSEH);
    PrintProperty(diaSymbol, L"get_hasEHa", &IDiaSymbol::get_hasEHa);
    PrintProperty(diaSymbol, L"get_isNaked", &IDiaSymbol::get_isNaked);
    PrintProperty(diaSymbol, L"get_isAggregated", &IDiaSymbol::get_isAggregated);
    PrintProperty(diaSymbol, L"get_isSplitted", &IDiaSymbol::get_isSplitted);
    PrintProperty(diaSymbol, L"get_container", &IDiaSymbol::get_container);
    PrintProperty(diaSymbol, L"get_inlSpec", &IDiaSymbol::get_inlSpec);
    PrintProperty(diaSymbol, L"get_noStackOrdering", &IDiaSymbol::get_noStackOrdering);
    PrintProperty(diaSymbol, L"get_virtualBaseTableType", &IDiaSymbol::get_virtualBaseTableType);
    PrintProperty(diaSymbol, L"get_hasManagedCode", &IDiaSymbol::get_hasManagedCode);
    PrintProperty(diaSymbol, L"get_isHotpatchable", &IDiaSymbol::get_isHotpatchable);
    PrintProperty(diaSymbol, L"get_isCVTCIL", &IDiaSymbol::get_isCVTCIL);
    PrintProperty(diaSymbol, L"get_isMSILNetmodule", &IDiaSymbol::get_isMSILNetmodule);
    PrintProperty(diaSymbol, L"get_isCTypes", &IDiaSymbol::get_isCTypes);
    PrintProperty(diaSymbol, L"get_isStripped", &IDiaSymbol::get_isStripped);
    PrintProperty(diaSymbol, L"get_frontEndQFE", &IDiaSymbol::get_frontEndQFE);
    PrintProperty(diaSymbol, L"get_backEndQFE", &IDiaSymbol::get_backEndQFE);
    PrintProperty(diaSymbol, L"get_wasInlined", &IDiaSymbol::get_wasInlined);
    PrintProperty(diaSymbol, L"get_strictGSCheck", &IDiaSymbol::get_strictGSCheck);
    PrintProperty(diaSymbol, L"get_isCxxReturnUdt", &IDiaSymbol::get_isCxxReturnUdt);
    PrintProperty(diaSymbol, L"get_isConstructorVirtualBase", &IDiaSymbol::get_isConstructorVirtualBase);
    PrintProperty(diaSymbol, L"get_RValueReference", &IDiaSymbol::get_RValueReference);
    PrintProperty(diaSymbol, L"get_unmodifiedType", &IDiaSymbol::get_unmodifiedType);
    PrintProperty(diaSymbol, L"get_framePointerPresent", &IDiaSymbol::get_framePointerPresent);
    PrintProperty(diaSymbol, L"get_isSafeBuffers", &IDiaSymbol::get_isSafeBuffers);
    PrintProperty(diaSymbol, L"get_intrinsic", &IDiaSymbol::get_intrinsic);
    PrintProperty(diaSymbol, L"get_sealed", &IDiaSymbol::get_sealed);
    PrintProperty(diaSymbol, L"get_hfaFloat", &IDiaSymbol::get_hfaFloat);
    PrintProperty(diaSymbol, L"get_hfaDouble", &IDiaSymbol::get_hfaDouble);
    PrintProperty(diaSymbol, L"get_liveRangeStartAddressSection", &IDiaSymbol::get_liveRangeStartAddressSection);
    PrintProperty(diaSymbol, L"get_liveRangeStartAddressOffset", &IDiaSymbol::get_liveRangeStartAddressOffset);
    PrintProperty(diaSymbol, L"get_liveRangeStartRelativeVirtualAddress", &IDiaSymbol::get_liveRangeStartRelativeVirtualAddress);
    PrintProperty(diaSymbol, L"get_countLiveRanges", &IDiaSymbol::get_countLiveRanges);
    PrintProperty(diaSymbol, L"get_liveRangeLength", &IDiaSymbol::get_liveRangeLength);
    PrintProperty(diaSymbol, L"get_offsetInUdt", &IDiaSymbol::get_offsetInUdt);
    PrintProperty(diaSymbol, L"get_paramBasePointerRegisterId", &IDiaSymbol::get_paramBasePointerRegisterId);
    PrintProperty(diaSymbol, L"get_localBasePointerRegisterId", &IDiaSymbol::get_localBasePointerRegisterId);
    PrintProperty(diaSymbol, L"get_isLocationControlFlowDependent", &IDiaSymbol::get_isLocationControlFlowDependent);
    PrintProperty(diaSymbol, L"get_stride", &IDiaSymbol::get_stride);
    PrintProperty(diaSymbol, L"get_numberOfRows", &IDiaSymbol::get_numberOfRows);
    PrintProperty(diaSymbol, L"get_numberOfColumns", &IDiaSymbol::get_numberOfColumns);
    PrintProperty(diaSymbol, L"get_isMatrixRowMajor", &IDiaSymbol::get_isMatrixRowMajor);
    // get_numericProperties
    // get_modifierValues
    PrintProperty(diaSymbol, L"get_isReturnValue", &IDiaSymbol::get_isReturnValue);
    PrintProperty(diaSymbol, L"get_isOptimizedAway", &IDiaSymbol::get_isOptimizedAway);
    PrintProperty(diaSymbol, L"get_builtInKind", &IDiaSymbol::get_builtInKind);
    PrintProperty(diaSymbol, L"get_registerType", &IDiaSymbol::get_registerType);
    PrintProperty(diaSymbol, L"get_baseDataSlot", &IDiaSymbol::get_baseDataSlot);
    PrintProperty(diaSymbol, L"get_baseDataOffset", &IDiaSymbol::get_baseDataOffset);
    PrintProperty(diaSymbol, L"get_textureSlot", &IDiaSymbol::get_textureSlot);
    PrintProperty(diaSymbol, L"get_samplerSlot", &IDiaSymbol::get_samplerSlot);
    PrintProperty(diaSymbol, L"get_uavSlot", &IDiaSymbol::get_uavSlot);
    PrintProperty(diaSymbol, L"get_sizeInUdt", &IDiaSymbol::get_sizeInUdt);
    PrintProperty(diaSymbol, L"get_memorySpaceKind", &IDiaSymbol::get_memorySpaceKind);
    PrintProperty(diaSymbol, L"get_unmodifiedTypeId", &IDiaSymbol::get_unmodifiedTypeId);
    PrintProperty(diaSymbol, L"get_subTypeId", &IDiaSymbol::get_subTypeId);
    PrintProperty(diaSymbol, L"get_subType", &IDiaSymbol::get_subType);
    PrintProperty(diaSymbol, L"get_numberOfModifiers", &IDiaSymbol::get_numberOfModifiers);
    PrintProperty(diaSymbol, L"get_numberOfRegisterIndices", &IDiaSymbol::get_numberOfRegisterIndices);
    PrintProperty(diaSymbol, L"get_isHLSLData", &IDiaSymbol::get_isHLSLData);
    PrintProperty(diaSymbol, L"get_isPointerToDataMember", &IDiaSymbol::get_isPointerToDataMember);
    PrintProperty(diaSymbol, L"get_isPointerToMemberFunction", &IDiaSymbol::get_isPointerToMemberFunction);
    PrintProperty(diaSymbol, L"get_isSingleInheritance", &IDiaSymbol::get_isSingleInheritance);
    PrintProperty(diaSymbol, L"get_isMultipleInheritance", &IDiaSymbol::get_isMultipleInheritance);
    PrintProperty(diaSymbol, L"get_isVirtualInheritance", &IDiaSymbol::get_isVirtualInheritance);
    PrintProperty(diaSymbol, L"get_restrictedType", &IDiaSymbol::get_restrictedType);
    PrintProperty(diaSymbol, L"get_isPointerBasedOnSymbolValue", &IDiaSymbol::get_isPointerBasedOnSymbolValue);
    PrintProperty(diaSymbol, L"get_baseSymbol", &IDiaSymbol::get_baseSymbol);
    PrintProperty(diaSymbol, L"get_objectFileName", &IDiaSymbol::get_objectFileName);
    PrintProperty(diaSymbol, L"get_isAcceleratorGroupSharedLocal", &IDiaSymbol::get_isAcceleratorGroupSharedLocal);
    PrintProperty(diaSymbol, L"get_isAcceleratorPointerTagLiveRange", &IDiaSymbol::get_isAcceleratorPointerTagLiveRange);
    PrintProperty(diaSymbol, L"get_isAcceleratorStubFunction", &IDiaSymbol::get_isAcceleratorStubFunction);
    PrintProperty(diaSymbol, L"get_numberOfAcceleratorPointerTags", &IDiaSymbol::get_numberOfAcceleratorPointerTags);
    PrintProperty(diaSymbol, L"get_isSdl", &IDiaSymbol::get_isSdl);
    PrintProperty(diaSymbol, L"get_isWinRTPointer", &IDiaSymbol::get_isWinRTPointer);
    PrintProperty(diaSymbol, L"get_isRefUdt", &IDiaSymbol::get_isRefUdt);
    PrintProperty(diaSymbol, L"get_isValueUdt", &IDiaSymbol::get_isValueUdt);
    PrintProperty(diaSymbol, L"get_isInterfaceUdt", &IDiaSymbol::get_isInterfaceUdt);
    // findInlineFramesByAddr
    // findInlineFramesByRVA
    // findInlineFramesByVA
    // findInlineeLines
    // findInlineeLinesByAddr
    // findInlineeLinesByRVA
    // findInlineeLinesByVA
    // findSymbolsForAcceleratorPointerTag
    // findSymbolsByRVAForAcceleratorPointerTag
    // get_acceleratorPointerTags
    // getSrcLineOnTypeDefn !!!
    PrintProperty(diaSymbol, L"get_isPGO", &IDiaSymbol::get_isPGO);
    PrintProperty(diaSymbol, L"get_hasValidPGOCounts", &IDiaSymbol::get_hasValidPGOCounts);
    PrintProperty(diaSymbol, L"get_isOptimizedForSpeed", &IDiaSymbol::get_isOptimizedForSpeed);
    PrintProperty(diaSymbol, L"get_PGOEntryCount", &IDiaSymbol::get_PGOEntryCount);
    PrintProperty(diaSymbol, L"get_PGOEdgeCount", &IDiaSymbol::get_PGOEdgeCount);
    PrintProperty(diaSymbol, L"get_PGODynamicInstructionCount", &IDiaSymbol::get_PGODynamicInstructionCount);
    PrintProperty(diaSymbol, L"get_staticSize", &IDiaSymbol::get_staticSize);
    PrintProperty(diaSymbol, L"get_finalLiveStaticSize", &IDiaSymbol::get_finalLiveStaticSize);
    PrintProperty(diaSymbol, L"get_phaseName", &IDiaSymbol::get_phaseName);
    PrintProperty(diaSymbol, L"get_hasControlFlowCheck", &IDiaSymbol::get_hasControlFlowCheck);
    PrintProperty(diaSymbol, L"get_constantExport", &IDiaSymbol::get_constantExport);
    PrintProperty(diaSymbol, L"get_dataExport", &IDiaSymbol::get_dataExport);
    PrintProperty(diaSymbol, L"get_privateExport", &IDiaSymbol::get_privateExport);
    PrintProperty(diaSymbol, L"get_noNameExport", &IDiaSymbol::get_noNameExport);
    PrintProperty(diaSymbol, L"get_exportHasExplicitlyAssignedOrdinal", &IDiaSymbol::get_exportHasExplicitlyAssignedOrdinal);
    PrintProperty(diaSymbol, L"get_exportIsForwarder", &IDiaSymbol::get_exportIsForwarder);
    PrintProperty(diaSymbol, L"get_ordinal", &IDiaSymbol::get_ordinal);
    PrintProperty(diaSymbol, L"get_frameSize", &IDiaSymbol::get_frameSize);
    PrintProperty(diaSymbol, L"get_exceptionHandlerAddressSection", &IDiaSymbol::get_exceptionHandlerAddressSection);
    PrintProperty(diaSymbol, L"get_exceptionHandlerAddressOffset", &IDiaSymbol::get_exceptionHandlerAddressOffset);
    PrintProperty(diaSymbol, L"get_exceptionHandlerRelativeVirtualAddress", &IDiaSymbol::get_exceptionHandlerRelativeVirtualAddress);
    PrintProperty(diaSymbol, L"get_exceptionHandlerVirtualAddress", &IDiaSymbol::get_exceptionHandlerVirtualAddress);
    // findInputAssemblyFile
    PrintProperty(diaSymbol, L"get_characteristics", &IDiaSymbol::get_characteristics);
    PrintProperty(diaSymbol, L"get_coffGroup", &IDiaSymbol::get_coffGroup);
    PrintProperty(diaSymbol, L"get_bindID", &IDiaSymbol::get_bindID);
    PrintProperty(diaSymbol, L"get_bindSpace", &IDiaSymbol::get_bindSpace);
    PrintProperty(diaSymbol, L"get_bindSlot", &IDiaSymbol::get_bindSlot);

    IDiaSymbol2* diaSymbol2;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol2), reinterpret_cast<void **>(&diaSymbol2)))) {
        PrintProperty(diaSymbol2, L"get_isObjCClass", &IDiaSymbol2::get_isObjCClass);
        PrintProperty(diaSymbol2, L"get_isObjCCategory", &IDiaSymbol2::get_isObjCCategory);
        PrintProperty(diaSymbol2, L"get_isObjCProtocol", &IDiaSymbol2::get_isObjCProtocol);
    }

    IDiaSymbol3* diaSymbol3;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol3), reinterpret_cast<void **>(&diaSymbol3)))) {
        PrintProperty(diaSymbol3, L"get_inlinee", &IDiaSymbol3::get_inlinee);
        PrintProperty(diaSymbol3, L"get_inlineeId", &IDiaSymbol3::get_inlineeId);
    }

    IDiaSymbol4* diaSymbol4;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol4), reinterpret_cast<void **>(&diaSymbol4)))) {
        PrintProperty(diaSymbol4, L"get_noexcept", &IDiaSymbol4::get_noexcept);
    }

    IDiaSymbol5* diaSymbol5;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol5), reinterpret_cast<void **>(&diaSymbol5)))) {
        PrintProperty(diaSymbol5, L"get_hasAbsoluteAddress", &IDiaSymbol5::get_hasAbsoluteAddress);
    }

    IDiaSymbol6* diaSymbol6;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol6), reinterpret_cast<void **>(&diaSymbol6)))) {
        PrintProperty(diaSymbol6, L"get_isStaticMemberFunc", &IDiaSymbol6::get_isStaticMemberFunc);
    }

    IDiaSymbol7* diaSymbol7;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol7), reinterpret_cast<void **>(&diaSymbol7)))) {
        PrintProperty(diaSymbol7, L"get_isSignRet", &IDiaSymbol7::get_isSignRet);
    }

    IDiaSymbol8* diaSymbol8;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol8), reinterpret_cast<void **>(&diaSymbol8)))) {
        PrintProperty(diaSymbol8, L"get_coroutineKind", &IDiaSymbol8::get_coroutineKind);
        PrintProperty(diaSymbol8, L"get_associatedSymbolKind", &IDiaSymbol8::get_associatedSymbolKind);
        PrintProperty(diaSymbol8, L"get_associatedSymbolSection", &IDiaSymbol8::get_associatedSymbolSection);
        PrintProperty(diaSymbol8, L"get_associatedSymbolOffset", &IDiaSymbol8::get_associatedSymbolOffset);
        PrintProperty(diaSymbol8, L"get_associatedSymbolRva", &IDiaSymbol8::get_associatedSymbolRva);
        PrintProperty(diaSymbol8, L"get_associatedSymbolAddr", &IDiaSymbol8::get_associatedSymbolAddr);
    }

    IDiaSymbol9* diaSymbol9;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol9), reinterpret_cast<void **>(&diaSymbol9)))) {
        PrintProperty(diaSymbol9, L"get_framePadSize", &IDiaSymbol9::get_framePadSize);
        PrintProperty(diaSymbol9, L"get_framePadOffset", &IDiaSymbol9::get_framePadOffset);
        PrintProperty(diaSymbol9, L"get_isRTCs", &IDiaSymbol9::get_isRTCs);
    }

    IDiaSymbol10* diaSymbol10;
    if (SUCCEEDED(diaSymbol->QueryInterface(__uuidof(IDiaSymbol10), reinterpret_cast<void **>(&diaSymbol10)))) {
        // get_sourceLink
        //PrintProperty(diaSymbol10, L"get_sourceLink", &IDiaSymbol10::get_sourceLink);
    }

    wcout << endl;
}
