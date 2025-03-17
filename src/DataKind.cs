namespace imgui_net_export;

public enum DataKind
{
    DataIsUnknown,
    DataIsLocal,
    DataIsStaticLocal,
    DataIsParam,
    DataIsObjectPtr,
    DataIsFileStatic,
    DataIsGlobal,
    DataIsMember,
    DataIsStaticMember,
    DataIsConstant
}

public enum UdtKind
{
    UdtStruct,
    UdtClass,
    UdtUnion,
    UdtInterface,
    UdtTaggedUnion
}