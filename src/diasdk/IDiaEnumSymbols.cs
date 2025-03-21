using System.Runtime.InteropServices;

namespace imgui_net_export;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public unsafe struct IDiaEnumSymbols
{
    public VirtualFunctionTable* lpVtbl;

    public HRESULT Next(IDiaEnumSymbols* _this, uint celt, IDiaSymbol** rgelt, uint* pceltFetched) => _this->lpVtbl->Next(_this, celt, rgelt, pceltFetched);
    public uint Release(IDiaEnumSymbols* _this) => _this->lpVtbl->Release(_this);

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VirtualFunctionTable
    {
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, Guid*, void**, HRESULT> QueryInterface;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, int> AddRef;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, uint> Release;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, HRESULT> get__NewEnum;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, HRESULT> get_Count;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, HRESULT> Item;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, uint, IDiaSymbol**, uint*, HRESULT> Next;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, HRESULT> Skip;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, HRESULT> Reset;
        public delegate* unmanaged[Stdcall]<IDiaEnumSymbols*, IDiaEnumSymbols **, HRESULT> Clone;
    }
}