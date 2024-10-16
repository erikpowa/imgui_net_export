#pragma once
#include <iomanip>
#include <string>
#include <atlbase.h>
#include <dia2.h>
#include <sstream>

#include "utils.h"
#include <Windows.h>
#include <iostream>
#include <string>
#include <sstream>
#include <limits>

using namespace std;

wstring wstring_replace(wstring str, const wstring& from, const wstring& to);
wstring wstring_from(unsigned long value);
bool wstring_startswith(const wstring& str, const wstring& prefix);

template<typename T>
wstring wstring_tohex(const T &value, DWORD size) {
    wstringstream wss;
    wss << L"0x" << setw(size) << setfill(L'0') << hex << uppercase << value;
    return wss.str();
}

template<typename T>
wstring wstring_tobitshiftexpression(T value) {

    std::wstringstream wss;

    if ((value & (value - 1)) != 0 || value <= 0) {
        wss << value;
        return wss.str();
    }

    int bitPosition = 0;
    while (value >>= 1) {
        ++bitPosition;
    }

    wss << L"1 << " << bitPosition;
    return wss.str();
}

bool wstring_contains(const wstring& str, const wchar_t &value);
bool wstring_contains(const wstring &str, const wstring &value);

wstring GetDataKindName(DWORD dwDataKind);
const wchar_t* GetSymTagName(DWORD symTag);
wstring GetTypeNameByBaseType(const DWORD &baseType, const ULONGLONG &bytes);
bool GetSymbolName(IDiaSymbol* pSymbol, wstring& result);
wstring GetTypeName(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol);
bool GetFunctionName(IDiaSymbol* pSymbol, wstring& result);
const wchar_t* GetCallingConvention(IDiaSymbol* pDiaSymbol);

typedef bool (*tEnumCallback)(IDiaSession*,IDiaSymbol*);

bool EnumChildren(IDiaSession* pDiaSession, IDiaSymbol* pDiaSymbol,enum SymTagEnum symTagEnum = SymTagUDT, const wchar_t *name = nullptr, int compareFlags = nsCaseInRegularExpression || nsfUndecoratedName, tEnumCallback callback = nullptr);
bool EnumExports(IDiaSession* pDiaSession, tEnumCallback callback = nullptr);

void PrintProperties(IDiaSymbol* diaSymbol);
