using System.Runtime.InteropServices;

namespace imgui_net_export;

public readonly struct HRESULT
{
    private readonly int _value;
    
    public HRESULT()
    {
        
    }

    public HRESULT ThrowIfFailed()
    {
        if (_value < 0) Marshal.ThrowExceptionForHR(_value);
        return this;
    }

    public static implicit operator bool(HRESULT hr) => hr._value >= 0;
}