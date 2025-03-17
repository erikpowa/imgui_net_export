
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// ReSharper disable All

namespace imgui_net_export;

public unsafe partial class Program
{
    [LibraryImport("imgui", EntryPoint = "#1128"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [Description("void __cdecl ImGui::TextV(char const *,char *)")]
    private static partial void ImGui_TextV2(byte* a1, in byte* a2);
    
    [LibraryImport("imgui", EntryPoint = "#1128"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [Description("void __cdecl ImGui::TextV(char const *,char *)")]
    private static partial void ImGui_TextV2(byte* a1,  byte* a2);
    
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
        var fileName = Path.GetFileName(filePath);
        var fileNameGen = fileName.Replace(".pdb", ".g.cs");
        var fileNameDll = fileName.Replace(".pdb", ".dll");

        Console.WriteLine();
        Console.WriteLine(path);
        Console.WriteLine(fileName);
        Console.WriteLine(fileNameGen);
        
        var clsid = typeof(IDiaSource).GUID;
        var iid = typeof(IDiaDataSource).GUID;
        
        IDiaDataSource* pDiaDataSource = null;
        CoCreateInstance(&clsid, null, CLSCTX_INPROC_SERVER, &iid, (void**)&pDiaDataSource).ThrowIfFailed();
        
        pDiaDataSource->LoadDataFromPdb(pDiaDataSource, filePath).ThrowIfFailed();
        
        IDiaSession* pDiaSession = null;
        pDiaDataSource->OpenSession(pDiaDataSource, &pDiaSession).ThrowIfFailed();

        IDiaSymbol* pDiaSymbolGlobal = null;
        pDiaSession->get_globalScope(pDiaSession, &pDiaSymbolGlobal).ThrowIfFailed();

        var descriptor = new Descriptor(fileNameDll, pDiaSession, true);
        
        //   descriptor.Test();
        // descriptor.ToString();
        
        File.WriteAllText(Path.Combine(path, fileNameGen), descriptor.ToString());

        pDiaSymbolGlobal->Release(pDiaSymbolGlobal);
        pDiaDataSource->Release(pDiaDataSource);
    }
   
    static void Main(string[] args)
    {
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