using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace imgui_net_export;

public unsafe partial class EnumDescriptor : CSharpDescriptor
{
    private readonly StringBuilder _enums;
    
    public EnumDescriptor(IDiaSession* session) : base(session)
    {
        _enums = new StringBuilder();
    }
    
    
    private bool EnumEnumMembers(IDiaSymbol* pDiaSymbol)
    {
        var name = GetName(pDiaSymbol);

        ComVariant variant = default;
        pDiaSymbol->get_value(pDiaSymbol, &variant).ThrowIfFailed();

        switch (variant.VarType)
        {
            case VarEnum.VT_I2:
                
                _enums.AppendLine($"\t{name} = {variant.As<short>().ToBitShiftExpression()}, // {variant.As<short>().ToHex()}");
                break;
            case VarEnum.VT_UI2:
                _enums.AppendLine($"\t{name} = {variant.As<ushort>().ToBitShiftExpression()}, // {variant.As<ushort>().ToHex()}");
                break;
            case VarEnum.VT_I1:
                _enums.AppendLine($"\t{name} = {variant.As<sbyte>().ToBitShiftExpression()}, // {variant.As<sbyte>().ToHex()}");
                break;
            case VarEnum.VT_UI4:
                _enums.AppendLine($"\t{name} = {variant.As<uint>().ToBitShiftExpression()}, // {variant.As<uint>().ToHex()}");
                break;
            case VarEnum.VT_I4:
                _enums.AppendLine($"\t{name} = {variant.As<int>().ToBitShiftExpression()}, // {variant.As<int>().ToHex()}");
                break;
            default:
                throw new NotImplementedException();
        }
        
        return true;
    }
    
    private bool EnumEnumTypes(IDiaSymbol* pDiaSymbol)
    {
        string name = GetTypeNameUserDefined(pDiaSymbol);

        if (name.StartsWith("<unnamed-enum-"))
            return true;

        // TODO remove if it ImGUI to use IMGUI_API correctly, not just randomly using it
        if (!name.StartsWith("Im")) return true; // cannot find a way to filter out in a nice way other enums

        if (name.EndsWith("Private_")) return true; // ImGui specific
        name = name.Trim('_');
        
        if (name.Contains("Flags")) 
            _enums.AppendLine("[Flags]");
        
        _enums.AppendLine($"public enum {name} {{");
        
        EnumChildren(pDiaSymbol, SymTag.SymTagData, (int)(NameSearchOptions.nsfCaseInsensitive | NameSearchOptions.nsfUndecoratedName), EnumEnumMembers);
        
        _enums.AppendLine("}");
        return true;
    }

    public override string ToString()
    {
        var global = GetGlobal();

        EnumChildren(global, SymTag.SymTagEnum, symbol =>
        {
            if (GetNested(symbol)) return true;
            if (GetKind(symbol) != UdtKind.UdtStruct) return true;
            if (GetConstantExport(symbol)) return true; // exporteds are duplicates

            //Console.WriteLine($"{symbol->GetDebugString(symbol)}");
            //Console.WriteLine($"{GetName(symbol)} : {GetScoped(symbol)} : {GetKind(symbol)}");
            
            //if (!GetConstantExport(symbol)) return true; // ENUMS are not exported, only some
            //if (GetScoped(@symbol)) return true; // TODO, handle on demand, not yet needed
            
            var unmodified = GetUnmodifiedType(symbol);
            if (unmodified != null)
            {
                if (GetLength(unmodified) != GetLength(@symbol)) throw new NotImplementedException(); // TODO, what to do on unmodified type doest not have the same impl
                EnumEnumTypes(unmodified);
                unmodified->Release(unmodified);
            }
            else
            {
                EnumEnumTypes(symbol);
            }
            

            return true;
        });
        
        global->Release(global);
        
        return _enums.ToString();
    }
}