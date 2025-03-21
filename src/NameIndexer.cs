using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace imgui_net_export;

public class NameIndexer
{
    private Dictionary<string, int> _names = [];

    public NameIndexer()
    {
        
    }
    
    public string Get(string name)
    {
        var key = $"{name}_";
        ref var value = ref CollectionsMarshal.GetValueRefOrNullRef(_names, key);
        if (!Unsafe.IsNullRef(ref value))
            return $"{name}{value++}";
        _names[key] = 0;
        return name;
    }
    
    public string Get(string name, int groupIndex)
    {
        var key = $"{name}_{groupIndex}";
        ref var value = ref CollectionsMarshal.GetValueRefOrNullRef(_names, key);
        if (!Unsafe.IsNullRef(ref value))
            return $"{name}{value++}";
        _names[key] = 0;
        return name;
    }
}