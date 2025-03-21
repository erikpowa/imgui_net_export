using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace imgui_net_export;

[Guid("79F1BB5F-B66E-48e5-B6A9-1545C323CA3D")]
[StructLayout(LayoutKind.Sequential, Pack = 8)] // Ensure correct alignment
public unsafe struct IDiaDataSource
{
    public VFT* lpVtbl;
    
    public HRESULT OpenSession(IDiaDataSource* _this, IDiaSession** ppSession)
    {
        return _this->lpVtbl->openSession(_this, ppSession);
    }

    public HRESULT LoadDataFromPdb(IDiaDataSource* _this, ReadOnlySpan<char> pdbPath)
    {
        return _this->lpVtbl->loadDataFromPdb(_this, (char*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(pdbPath)));
    }
    
    public uint Release(IDiaDataSource* _this)
    {
        return _this->lpVtbl->Release(_this);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VFT
    {
        public delegate* unmanaged[Stdcall]<IDiaDataSource*, Guid*, void**, HRESULT> QueryInterface;
        public delegate* unmanaged[Stdcall]<IDiaDataSource*, uint> AddRef;
        public delegate* unmanaged[Stdcall]<IDiaDataSource*, uint> Release;
        public delegate* unmanaged[Stdcall]<void> get_lastError;
        public delegate* unmanaged[Stdcall]<IDiaDataSource*, char*, HRESULT> loadDataFromPdb;
        public delegate* unmanaged[Stdcall]<void> loadAndValidateDataFromPdb;
        public delegate* unmanaged[Stdcall]<void> loadDataForExe;
        public delegate* unmanaged[Stdcall]<IDiaDataSource*, IntPtr, HRESULT> loadDataFromIStream; // IStream*
        public delegate* unmanaged[Stdcall]<IDiaDataSource*, IDiaSession**, HRESULT> openSession;
        public delegate* unmanaged[Stdcall]<void> loadDataFromCodeViewInfo;
        public delegate* unmanaged[Stdcall]<void> loadDataFromMiscInfo;
    }
}