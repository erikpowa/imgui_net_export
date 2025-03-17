using System.Numerics;

namespace imgui_net_export;

public static class Ext
{
    public static string ToHex(this byte value) => $"0x{value:X2}";
    public static string ToHex(this sbyte value) => $"0x{value:X2}";
    public static string ToHex(this ushort value) => $"0x{value:X4}";
    public static string ToHex(this short value) => $"0x{value:X4}";
    public static string ToHex(this int value) => $"0x{value:X8}";
    public static string ToHex(this uint value) => $"0x{value:X8}";
    public static string ToHex(this float value) => $"0x{value:X8}";
    public static string ToHex(this long value) => $"0x{value:X16}";
    public static string ToHex(this ulong value) => $"0x{value:X16}";
    public static string ToHex(this double value) => $"0x{value:X16}";
    
    public static string ToBitShiftExpression<T>(this T value) where T : struct, IConvertible
    {
        try
        {
            ulong num = value.ToUInt64(null);
            if ((num & (num - 1)) != 0 || num <= 0)
                return num.ToString();
            return $"1 << {BitOperations.Log2(num)}";
        }
        catch
        {
            return $"{value}";
        }
    }

}