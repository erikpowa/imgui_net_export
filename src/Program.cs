using System.Runtime.InteropServices;

// ReSharper disable All

namespace imgui_net_export;

public unsafe partial class Program
{
    [LibraryImport("ole32.dll")]
    private static partial HRESULT CoCreateInstance(Guid* clsid, void* a2, int dwClsContext, Guid* riid, void** ppv);

    private const int CLSCTX_INPROC_SERVER = 1;

    static void Generate(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
            return;

        if (!filePath.EndsWith(".pdb"))
            return;

        var path = Path.GetDirectoryName(filePath);
        if (string.IsNullOrEmpty(path)) return;
        var fileName = Path.GetFileNameWithoutExtension(filePath);
        
        var clsid = typeof(IDiaSource).GUID;
        var iid = typeof(IDiaDataSource).GUID;
        
        IDiaDataSource* pDiaDataSource = null;
        CoCreateInstance(&clsid, null, CLSCTX_INPROC_SERVER, &iid, (void**)&pDiaDataSource).ThrowIfFailed();
        
        pDiaDataSource->LoadDataFromPdb(pDiaDataSource, filePath).ThrowIfFailed();
        
        IDiaSession* pDiaSession = null;
        pDiaDataSource->OpenSession(pDiaDataSource, &pDiaSession).ThrowIfFailed();

        // TODO move to FileStream, just lazy, no reason, F memory for this, not worth it
        
        var cLinkage = new ClinkageDescriptor(pDiaSession);
        File.WriteAllText(Path.Combine(path, $"{fileName}_export.g.cpp"), cLinkage.ToString());
        
        var libraryImport = new LibraryImportDescriptor($"{fileName}.dll", pDiaSession)
        {
            UseOrdinal = false,
            Description = false,
        };
        File.WriteAllText(Path.Combine(path, $"{fileName}.LibraryImports.g.cs"), libraryImport.ToString());
        
        var structs = new StructDescriptor( pDiaSession);
        File.WriteAllText(Path.Combine(path, $"{fileName}.Structs.g.cs"), structs.ToString());
        
        var enums = new EnumDescriptor(pDiaSession);
        File.WriteAllText(Path.Combine(path, $"{fileName}.Enums.g.cs"), enums.ToString());

        pDiaDataSource->Release(pDiaDataSource);
    }
   
    static void Main(string[] args)
    {
        #if DEBUG
        Generate("C:\\Users\\glitch\\Desktop\\Projects\\imgui_net_export\\.temp\\imgui.pdb");
        return;
        #endif
        
        List<string> filePaths = new List<string>();

        if (args.Length > 0)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if(File.Exists(args[i]))
                    Generate(args[i]);
            }
        }
        else
        {
            var dir = Directory.GetCurrentDirectory();
            foreach (var enumerateFile in Directory.EnumerateFiles(dir, "*.pdb"))
            {
                Generate(enumerateFile);
            }
        }
    }
}