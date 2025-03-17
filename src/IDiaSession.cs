using System.Runtime.InteropServices;

namespace imgui_net_export;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public unsafe struct IDiaSession
{
    public VirtualFunctionTable* lpVtbl;

    public HRESULT findSymbolByRVA(IDiaSession* _this, uint rva, SymTagEnum symTagEnum, IDiaSymbol **ppSymbol) => _this->lpVtbl->findSymbolByRVA(_this, rva, symTagEnum, ppSymbol);
    public HRESULT symbolById(IDiaSession* _this, int id, IDiaSymbol** pRetVal) => _this->lpVtbl->symbolById(_this, id, pRetVal);

    public HRESULT get_globalScope(IDiaSession* _this, IDiaSymbol** pRetVal)
    {
        return _this->lpVtbl->get_globalScope(_this, pRetVal);
    }
    
    public HRESULT getExports(IDiaSession* _this, IDiaEnumSymbols** ppResult)
    {
        return _this->lpVtbl->getExports(_this, ppResult);
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VirtualFunctionTable
    {
        public delegate* unmanaged[Stdcall]<IDiaSession*, Guid*, void**, HRESULT> QueryInterface;
        public delegate* unmanaged[Stdcall]<IDiaSession*, uint> AddRef;
        public delegate* unmanaged[Stdcall]<IDiaSession*, uint> Release;
        
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> get_loadAddress;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> put_loadAddress;
        public delegate* unmanaged[Stdcall]<IDiaSession*, IDiaSymbol**, HRESULT> get_globalScope;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> getEnumTables;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> getSymbolsByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findChildren;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findChildrenEx;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findChildrenExByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findChildrenExByVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findChildrenExByRVA; // 10
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findSymbolByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSession*, uint, SymTagEnum, IDiaSymbol**, HRESULT> findSymbolByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findSymbolByVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findSymbolByToken;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> symsAreEquiv;
        public delegate* unmanaged[Stdcall]<IDiaSession*, int, IDiaSymbol**, HRESULT> symbolById;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findSymbolByRVAEx;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findSymbolByVAEx;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findFile;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findFileById; // 20
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findLines;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findLinesByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findLinesByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findLinesByVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findLinesByLinenum;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInjectedSource;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> getEnumDebugStreams;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineFramesByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineFramesByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineFramesByVA; // 30
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineeLines;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineeLinesByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineeLinesByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineeLinesByVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineeLinesByLinenum;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInlineesByName;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findAcceleratorInlineeLinesByLinenum;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findSymbolsForAcceleratorPointerTag;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findSymbolsByRVAForAcceleratorPointerTag;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findAcceleratorInlineesByName; // 40
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> addressForVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> addressForRVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findILOffsetsByAddr;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findILOffsetsByRVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findILOffsetsByVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInputAssemblyFiles;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInputAssembly;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> findInputAssemblyById;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> getFuncMDTokenMapSize;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> getFuncMDTokenMap; // 50
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> getTypeMDTokenMapSize;
        public delegate* unmanaged[Stdcall]<IDiaSession*, void> getTypeMDTokenMap;
        public delegate* unmanaged[Stdcall]<IDiaSession*, HRESULT> getNumberOfFunctionFragments_VA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, HRESULT> getNumberOfFunctionFragments_RVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, HRESULT> getFunctionFragments_VA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, HRESULT> getFunctionFragments_RVA;
        public delegate* unmanaged[Stdcall]<IDiaSession*, IDiaEnumSymbols **, HRESULT> getExports;
        public delegate* unmanaged[Stdcall]<IDiaSession*, HRESULT> getHeapAllocationSites;
        public delegate* unmanaged[Stdcall]<IDiaSession*, HRESULT> findInputAssemblyFile;
    }
}