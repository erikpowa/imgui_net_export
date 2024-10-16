#include "main.h"

#include <unordered_map>

#include "utils.h"

std::unordered_set<wstring> structs;
std::unordered_set<DWORD> usedSymbolIds;

bool HasSymbol(IDiaSymbol* pDiaSymbol) {
    DWORD symIndexId;
    if(SUCCEEDED(pDiaSymbol->get_symIndexId(&symIndexId))) {
        if (usedSymbolIds.find(symIndexId) != usedSymbolIds.end()) {
            return true;
        }
    }
    return false;
}

bool GetEnumTypeMemberCallback(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol)
{
    BSTR memberName = nullptr;

    if (SUCCEEDED(pDiaSymbol->get_name(&memberName)) && memberName) {
        VARIANT memberValue;
        VariantInit(&memberValue);

        if (SUCCEEDED(pDiaSymbol->get_value(&memberValue))) {

            switch (memberValue.vt) {
            case VT_I1:
            case VT_I2:
            case VT_UI2:
            case VT_I4:
            case VT_UI4:

                // wstring_tohex(memberValue.intVal, 8)

                wcout << L"\t" << memberName << L" = " << wstring_tobitshiftexpression(memberValue.intVal) << L", // " << wstring_tohex(memberValue.intVal, 8) << endl;
                // wcout << L"\t" << memberName << L" = " << memberValue.iVal << L", // 0x" << setw(8) << setfill('0') << hex << uppercase << memberValue.iVal << endl;
                break;
            default:
                wcout << L"\t" << memberName << L" = 0, // (vt = " << memberValue.vt << L")" << endl;
                break;
            }
        }
        else {
            wcout << memberName << L" = " << L"0, // invalid value" << endl;
        }

        VariantClear(&memberValue);
        SysFreeString(memberName);
    }

    return true;
}

bool GetEnumTypeCallback(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol)
{
    DWORD symTag = 0;
    if (FAILED(pDiaSymbol->get_symTag(&symTag)) || symTag != SymTagEnum) {
        return true;
    }

    BOOL scoped = false;
    pDiaSymbol->get_scoped(&scoped);
    if (scoped) {
        return true;
    }

    DWORD unmodifiedTypeId = false;
    if (SUCCEEDED(pDiaSymbol->get_unmodifiedTypeId(&unmodifiedTypeId)) && unmodifiedTypeId > 0) {
        IDiaSymbol* unmodifiedSymbol = nullptr;
        if (SUCCEEDED(pDiaSession->symbolById(unmodifiedTypeId, &unmodifiedSymbol)) && unmodifiedSymbol != nullptr) {
            return true;
        }
    }

    /*if(!HasSymbol(pDiaSymbol))
        return true;*/

    wstring typeName;
    if (!GetSymbolName(pDiaSymbol, typeName))
        return true;

    if (typeName.length() < 2 || typeName[0] != L'I' || typeName[1] != L'm') {
        return true;
    }

    if(wstring_contains(typeName, L"Private_"))
        return true;

    typeName = wstring_replace(typeName, L"_", L"");

    wcout << L"public enum " << typeName << L" {" << endl;
    EnumChildren(pDiaSession, pDiaSymbol, SymTagEnum::SymTagData, nullptr, nsfCaseInsensitive | nsfUndecoratedName, GetEnumTypeMemberCallback);
    wcout << L"}" << endl;
    return true;
}

bool GetStructTypeMemberCallback(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol)
{
    LONG offset = 0;
    if (FAILED(pDiaSymbol->get_offset(&offset))) {
        return false;
    }

    DWORD access = 0;
    if (FAILED(pDiaSymbol->get_access(&access))) {
        return false;
    }

    wstring accessString;
    switch (access) {
        case CV_private:
            accessString= L"private";
        case CV_protected:
            accessString= L"protected";
        case CV_public:
            default:
            accessString = L"public";
                break;
    }

    IDiaSymbol* fieldType = nullptr;
    if(FAILED(pDiaSymbol->get_type(&fieldType))) {
        return false;
    }

    wchar_t *fieldName = nullptr;
    if (FAILED(pDiaSymbol->get_name(&fieldName)) || fieldName == nullptr) {
        return false;
    }

    wstring fieldTypeName = GetTypeName(pDiaSession, fieldType);

    // [FieldOffset(0x0004)] public readonly int Hello;
    wcout << L"\t[FieldOffset(" << wstring_tohex(offset, 4) << L")] " << accessString << " " << fieldTypeName << " " << fieldName << L";" << endl;

    SysFreeString(fieldName);
    return true;
}

bool GetStructTypeCallback(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol)
{
    if(!HasSymbol(pDiaSymbol))
        return true;

    DWORD udtKind = 0;
    if (FAILED(pDiaSymbol->get_udtKind(&udtKind)) || udtKind != UdtStruct) {
        return true;
    }

    BOOL scoped = false;
    if(SUCCEEDED(pDiaSymbol->get_scoped(&scoped))) {
        if (scoped) {
            return true;
        }
    }

    DWORD unmodifiedTypeId = false;
    if (SUCCEEDED(pDiaSymbol->get_unmodifiedTypeId(&unmodifiedTypeId)) && unmodifiedTypeId > 0) {
        IDiaSymbol* unmodifiedSymbol = nullptr;
        if (SUCCEEDED(pDiaSession->symbolById(unmodifiedTypeId, &unmodifiedSymbol)) && unmodifiedSymbol != nullptr) {
            return true; // ignore modified type
        }
    }

    ULONGLONG length = 0;
    if (FAILED(pDiaSymbol->get_length(&length))) {
        return true;
    }

    wstring typeName;
    if (!GetSymbolName(pDiaSymbol, typeName))
        return true;

    const auto insert = structs.insert(typeName) ;
    if(!insert.second) {
        // wcout << typeName << L" already added" << endl;
        return true;
    }

    /*if (typeName.length() < 2 || typeName[0] != L'I' || typeName[1] != L'm') {
        return true;
    }*/

    if(typeName == L"ImVec4")
        return true;

    if(typeName == L"ImVec2")
        return true;

    if (wstring_contains(typeName, L'<') || wstring_contains(typeName, L':'))
        return true;

    wcout << L"[StructLayout(LayoutKind.Explicit, Pack = 1, Size = " << wstring_tohex(length, 4) << L")]" << endl; // [StructLayout(LayoutKind.Explicit, Size = 0x0000)]
    wcout << L"public unsafe partial struct " << typeName << L" {" << endl;
    EnumChildren(pDiaSession, pDiaSymbol, SymTagEnum::SymTagData, nullptr, nsNone, GetStructTypeMemberCallback);
    wcout << L"}" << endl;
    return true;
}

void MapType(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol) {
    if(pDiaSymbol == nullptr) return;

    DWORD symIndexId;
    if(SUCCEEDED(pDiaSymbol->get_symIndexId(&symIndexId))) {
        const auto insert = usedSymbolIds.insert(symIndexId);
        if(!insert.second) {
            return;
        }
    }

    IDiaSymbol* symbol = nullptr;
    //if(SUCCEEDED(pDiaSymbol->get_lexicalParent(&symbol))) { MapType(symbol); }
    if(SUCCEEDED(pDiaSymbol->get_classParent(&symbol))) { MapType(pDiaSession,symbol); }
    if(SUCCEEDED(pDiaSymbol->get_type(&symbol))) { MapType(pDiaSession,symbol); }
    if(SUCCEEDED(pDiaSymbol->get_arrayIndexType(&symbol))) { MapType(pDiaSession,symbol); }
    //if(SUCCEEDED(pDiaSymbol->get_virtualTableShape(&symbol))) { MapType(symbol); }
    if(SUCCEEDED(pDiaSymbol->get_objectPointerType(&symbol))) { MapType(pDiaSession,symbol); }

    unsigned long rva = 0;
    if (SUCCEEDED(pDiaSymbol->get_relativeVirtualAddress(&rva)) && rva != 0) {
        IDiaSymbol* pFuncDiaSymbol = nullptr;
        if (SUCCEEDED(pDiaSession->findSymbolByRVA(rva, SymTagFunction, &pFuncDiaSymbol)) && pFuncDiaSymbol != nullptr) {
            MapType(pDiaSession, pFuncDiaSymbol);
        }
    }

    if(symbol != nullptr) {
        symbol->Release();
        symbol = nullptr;
    }

    IDiaEnumSymbols* pDiaEnumSymbols = nullptr;
    /*if(SUCCEEDED(pDiaSymbol->findChildren(SymTagNull, nullptr, 0, &pDiaEnumSymbols)) && pDiaEnumSymbols != nullptr) {
        IDiaSymbol* pDiaSymbolChild = nullptr;
        ULONG fetched;
        while (SUCCEEDED(pDiaEnumSymbols->Next(1, &pDiaSymbolChild, &fetched)) && fetched == 1) {
            MapType(pDiaSession,pDiaSymbolChild);
            pDiaSymbolChild->Release();
            pDiaSymbolChild = nullptr;
        }
        pDiaEnumSymbols->Release();
    }
    */

    if (SUCCEEDED(pDiaSymbol->findChildren(SymTagData, nullptr, nsNone, &pDiaEnumSymbols)) && pDiaEnumSymbols != nullptr) {
        IDiaSymbol* pParamSymbol = nullptr;
        ULONG fetched = 0;
        while (SUCCEEDED(pDiaEnumSymbols->Next(1, &pParamSymbol, &fetched)) && fetched == 1) {
            DWORD dwDataKind;
            if (SUCCEEDED(pParamSymbol->get_dataKind(&dwDataKind)) && dwDataKind != DataIsUnknown) {
                IDiaSymbol* pParamTypeSymbol = nullptr;
                switch (dwDataKind) {
                    case DataIsObjectPtr: // this
                    case DataIsParam: // param arg
                    case DataIsMember: // param arg
                        MapType(pDiaSession,pParamSymbol);
                    if (SUCCEEDED(pParamSymbol->get_type(&pParamTypeSymbol)) && pParamTypeSymbol != nullptr) {
                        MapType(pDiaSession,pParamTypeSymbol);
                    }
                    break;
                    default:
                        break;
                }
            }
            pParamSymbol->Release();
            pParamSymbol = nullptr;
        }
        pDiaEnumSymbols->Release();
    }
}

bool MapTypesByExports(IDiaSession *pDiaSession) {
    IDiaEnumSymbols* pDiaEnumSymbols = nullptr;
    if (FAILED(pDiaSession->getExports(&pDiaEnumSymbols))) {
        return false;
    }
    IDiaSymbol* pDiaSymbolChild = nullptr;
    ULONG fetched;
    while (SUCCEEDED(pDiaEnumSymbols->Next(1, &pDiaSymbolChild, &fetched)) && fetched == 1) {
        MapType(pDiaSession,pDiaSymbolChild);
        pDiaSymbolChild->Release();
        pDiaSymbolChild = nullptr;
    }
    pDiaEnumSymbols->Release();
    return true;
}

wstring GetTrackedTypeDefName(const wstring &typeDefName) {
    static unordered_map<wstring, int> stringCount;

    if (stringCount.find(typeDefName) == stringCount.end()) {
        stringCount[typeDefName] = 0;
        return typeDefName;
    }
    const int count = ++stringCount[typeDefName];
    return typeDefName + std::to_wstring(count);
}

bool GetExportsCallback(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol)
{
    // internal static readonly delegate* unmanaged[Cdecl] <ImGuiWindow*, uint, ImGuiOldColumns*> _ImGui__FindOrCreateColumns_0 = (delegate* unmanaged[Cdecl] <ImGuiWindow*, uint, ImGuiOldColumns*>)_imgui[315];
    // internal static readonly delegate* unmanaged[Thiscall] <ImDrawList*, void*, ImVec2*, ImVec2*, ImVec2*, ImVec2*, uint, void> _ImDrawList__AddImage_0 =
    //                         (delegate* unmanaged[Thiscall] <ImDrawList*, void*, ImVec2*, ImVec2*, ImVec2*, ImVec2*, uint, void>)_imgui[94];
    unsigned long ordinal = 0;
    if (FAILED(pDiaSymbol->get_ordinal(&ordinal)) || ordinal == 0) {
        return true;
    }

    unsigned long rva = 0;
    if (FAILED(pDiaSymbol->get_relativeVirtualAddress(&rva)) || rva == 0) {
        return true;
    }

    IDiaSymbol* pFuncDiaSymbol = nullptr;
    if (FAILED(pDiaSession->findSymbolByRVA(rva, SymTagFunction, &pFuncDiaSymbol)) || pFuncDiaSymbol == nullptr) {
        return true;
    }

    IDiaSymbol* pFuncPublicSymbolDiaSymbol = nullptr;
    if (FAILED(pDiaSession->findSymbolByRVA(rva, SymTagPublicSymbol, &pFuncPublicSymbolDiaSymbol)) || pFuncPublicSymbolDiaSymbol == nullptr) {
        return true;
    }

    IDiaSymbol* pFuncTypeDiaSymbol = nullptr;
    if (FAILED(pFuncDiaSymbol->get_type(&pFuncTypeDiaSymbol)) || pFuncTypeDiaSymbol == nullptr) {
        return true;
    }

    IDiaSymbol* pFuncReturnTypeDiaSymbol = nullptr;
    if (FAILED(pFuncTypeDiaSymbol->get_type(&pFuncReturnTypeDiaSymbol)) || pFuncReturnTypeDiaSymbol == nullptr) {
        return true;
    }

    wstring returnTypeName = GetTypeName(pDiaSession, pFuncReturnTypeDiaSymbol);

    wchar_t* undecoratedName;
    if (FAILED(pFuncPublicSymbolDiaSymbol->get_undecoratedName(&undecoratedName)) || undecoratedName == nullptr) {
        return true;
    }

    wchar_t* functionName = nullptr;
    if (FAILED(pFuncDiaSymbol->get_name(&functionName)) || functionName == nullptr) {
        return true;
    }

    MapType(pDiaSession,pDiaSymbol);
    MapType(pDiaSession,pFuncDiaSymbol);
    MapType(pDiaSession,pFuncPublicSymbolDiaSymbol);
    MapType(pDiaSession,pFuncTypeDiaSymbol);
    MapType(pDiaSession,pFuncReturnTypeDiaSymbol);

    // BeginChild(const char* str_id, const ImVec2& size = ImVec2(0, 0), ImGuiChildFlags child_flags = 0, ImGuiWindowFlags window_flags = 0);

    /*if(!wstring_contains(functionName, L"BeginChild"))
        return true;*/

    wstring typeDefName(GetTrackedTypeDefName(functionName)); // ImGui_FindOrCreateColumns_1
    //typeDefName.append(L"_");
    //typeDefName.append(to_wstring(ordinal));
    typeDefName = wstring_replace(typeDefName, L"=", L"Equal");
    typeDefName = wstring_replace(typeDefName, L"::", L"_");
    typeDefName = wstring_replace(typeDefName, L"~", L"_Dtor_");
    typeDefName = wstring_replace(typeDefName, L"`default constructor closure'", L"_Ctor_");

    wstring typeDefArgs; // delegate* unmanaged[Cdecl] <uint, void>
    typeDefArgs.append(L"delegate* unmanaged[");
    typeDefArgs.append(GetCallingConvention(pFuncTypeDiaSymbol));
    typeDefArgs.append(L"] <");
    IDiaEnumSymbols* pEnumSymTagData = nullptr;

    if (SUCCEEDED(pFuncDiaSymbol->findChildren(SymTagData, nullptr, nsNone, &pEnumSymTagData)) && pEnumSymTagData != nullptr) {
        IDiaSymbol* pParamSymbol = nullptr;
        ULONG fetched = 0;
        while (SUCCEEDED(pEnumSymTagData->Next(1, &pParamSymbol, &fetched)) && fetched == 1) {
            DWORD dwDataKind;
            if (SUCCEEDED(pParamSymbol->get_dataKind(&dwDataKind)) && dwDataKind != DataIsUnknown) {
                IDiaSymbol* pParamTypeSymbol = nullptr;
                switch (dwDataKind) {
                case DataIsObjectPtr: // this
                case DataIsParam: // param arg
                    if (SUCCEEDED(pParamSymbol->get_type(&pParamTypeSymbol)) && pParamTypeSymbol != nullptr) {
                        //PrintProperties(pParamTypeSymbol);
                        typeDefArgs.append(GetTypeName(pDiaSession, pParamTypeSymbol));
                        typeDefArgs.append(L", ");
                    }
                    break;
                default:
                    break;
                }
            }
            pParamSymbol->Release();
            pParamSymbol = nullptr;
        }
        pEnumSymTagData->Release();
    }

    if (wstring_contains(undecoratedName, L"...")) // TODO check where to get vararg param info, Local argument is not enough
    {
        typeDefArgs.append(L"void*, "); // varargs
    }

    typeDefArgs.append(returnTypeName);
    typeDefArgs.append(L">");

    wstring typeDef; // internal static readonly {typeDefArgs} {typeDefName} = ({typeDefArgs})_imgui[1];
    typeDef.append(L"internal static readonly ");
    typeDef.append(typeDefArgs);
    typeDef.append(L" ");
    typeDef.append(typeDefName);
    typeDef.append(L" = (");
    typeDef.append(typeDefArgs);
    typeDef.append(L")GetProc(");
    typeDef.append(to_wstring(ordinal));
    typeDef.append(L");");

    wcout << "[Description(\"" << undecoratedName << "\")]" << endl;
    wcout << typeDef << endl;

    return true;
}

int main(int)
{
    if (FAILED(CoInitialize(nullptr))) {
        wcout << L"Failed to initialize COM library." << endl;
        return -1;
    }

    IDiaDataSource* pDiaDataSource = nullptr;
    HRESULT hr = CoCreateInstance(__uuidof(DiaSource), nullptr, CLSCTX_INPROC_SERVER, __uuidof(IDiaDataSource), reinterpret_cast<void **>(&pDiaDataSource));

    if (FAILED(hr)) {
        wcout << L"Failed to CoCreateInstance DiaSource." << endl;
        if (hr == REGDB_E_CLASSNOTREG) {
            wcout << L"Class not registered. Register msdia140.dll. (in 64bit environment, system32 regsvr32 for 64bit COM, SysWOW64 regsvr32 for 32bit COM)" << endl;
        }
        return -1;
    }

    wchar_t pdbFilePath[_MAX_PATH];
    GetModuleFileNameW(nullptr, pdbFilePath, _MAX_PATH);
    int index = 0;
    for (int i = 0; pdbFilePath[i] != '\0'; i++) {
        if (pdbFilePath[i] == '\\') {
            index = i;
        }
    }
    pdbFilePath[index] = '\0';
    wcscat_s(pdbFilePath, L"\\imgui.pdb");

    hr = pDiaDataSource->loadDataFromPdb(pdbFilePath);

    if (FAILED(hr)) {
        wcout << L"Failed to load .pdb file." << endl;
        return -1;
    }

    IDiaSession* pDiaSession = nullptr;
    if (FAILED(pDiaDataSource->openSession(&pDiaSession))) {
        wcout << L"Failed openSession." << endl;
        return -1;
    }

    MapTypesByExports(pDiaSession);

    IDiaSymbol* pDiaSymbolGlobal = nullptr;
    if (FAILED(pDiaSession->get_globalScope(&pDiaSymbolGlobal))) {
        wcout << L"Failed get_globalScope" << endl;
        return -1;
    }

    //TODO from args
    wstring nameSpace = L"x";
    BOOL addGetProc = FALSE;
    BOOL appendFuncTypeDefDescription = FALSE;

    wcout << L"using System.Runtime.InteropServices;" << endl;
    wcout << L"using System.ComponentModel;" << endl;
    /*wcout << L"global using ImVec2 = System.Numerics.Vector2;" << endl;
    wcout << L"global using ImVec4 = System.Numerics.Vector4;" << endl;
    wcout << L"global using ImDrawIdx = System.UInt16;" << endl;
    wcout << L"global using ImGuiID = System.UInt32;" << endl;
    wcout << L"global using ImU8 = System.Byte;" << endl;
    wcout << L"global using ImU32 = System.UInt32;" << endl;
    wcout << L"global using ImWchar = System.UInt16;" << endl;*/

    wcout << L"namespace " << nameSpace << L";" << endl;

    wcout << L"public unsafe partial struct ImGui {" << endl;
    if(addGetProc)
        wcout << L"[MethodImpl(MethodImplOptions.AggressiveInlining)] internal static IntPtr GetProc(uint ordinal) => throw new NotImplementedException();" << endl;
    EnumExports(pDiaSession, GetExportsCallback);
    wcout << L"}" << endl;

    wcout << L"public unsafe struct ImVector<T> where T : unmanaged { public int Size; public int Capacity; public T* Data; }" << endl;
    wcout << L"public unsafe struct ImChunkStream<T> where T : unmanaged { public ImVector<byte> Buff; }" << endl;
    wcout << L"public unsafe struct ImSpan<T> where T : unmanaged {  public T* Data; public T* DataEnd; }" << endl;
    wcout << L"public unsafe struct ImPool<T> where T : unmanaged { public ImVector<T> Map; public int FreeIdx; public int AliveCount;  }" << endl;

    //wcout << L"public unsafe struct stbtt_fontinfo { }" << endl;
    //wcout << L"public unsafe struct stbtt_pack_range { }" << endl;
    //wcout << L"public unsafe struct stbrp_rect { }" << endl;
    //wcout << L"public unsafe struct stbtt_packedchar { }" << endl;

    EnumChildren(pDiaSession, pDiaSymbolGlobal, SymTagEnum, nullptr, nsNone, GetEnumTypeCallback);
    EnumChildren(pDiaSession, pDiaSymbolGlobal, SymTagUDT, nullptr, nsNone, GetStructTypeCallback);

    return 0;
}