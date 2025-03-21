namespace imgui_net_export;

public unsafe partial class CSharpDescriptor : Descriptor
{
    public CSharpDescriptor(IDiaSession* session) : base(session)
    {
    }

    protected override bool IsTypeForwarded(string typeName)
    {
        if (typeName == "Vector2") return true;
        if (typeName == "Vector4") return true;
        return false;
    }

    protected string GetTypeNameUserDefined(IDiaSymbol* pSymbol)
    {
        string result = GetName(pSymbol);

        if (string.IsNullOrEmpty(result))
            throw new NotImplementedException();

        if (result == "ImVec2") result = "Vector2";
        if (result == "ImVec4") result = "Vector4";
        if (result.Contains("<ImVec2>")) result =result.Replace("<ImVec2>", "<Vector2>");
        if (result.Contains("<ImVec4>")) result= result.Replace("<ImVec4>", "<Vector4>");

        if (result.StartsWith("ImBitArray<"))  // TODO: constant value templates, also multiple type,,,
            return Sanitize(result);

        // TODO manually reconstruct names instead of replace
        result = result.Replace("::", "__");

        result = result.Replace("<char const *>", "<byte>");

        result = result.Replace("<unsigned char>", "<byte>");
        result = result.Replace("<signed char>", "<sbyte>");
        result = result.Replace("<unsigned short>", "<ushort>");
        result = result.Replace("<signed short>", "<short>");
        result = result.Replace("<unsigned int>", "<uint>");
        result = result.Replace("<signed int>", "<int>");
        result = result.Replace("<unsigned __int64>", "<ulong>");
        result = result.Replace("<signed __int64>", "<long>");

        /*result = result.Replace("<char const", "<byte");
        result = result.Replace("<char>", "<byte>");
        result = result.Replace("__int64", "long");
        result = result.Replace("<unsigned ", "<u");
        result = result.Replace("<signed ", "<s");
        result = result.Replace(" ", "");
        result = result.Replace("*", "");*/
        // result = result.Replace(" ", string.Empty);
        result = result.Replace(" *>", ">");
        return result;
    }
    
    protected override string GetBaseTypeName(IDiaSymbol* symbol)
    {
        BasicType baseType = GetBaseType(symbol);
        ulong bytes = GetLength(symbol);
        
        if (baseType == BasicType.btNoType) return "void";
        if (bytes == 0 && baseType == BasicType.btVoid) return "void";

        if (bytes == 1 && baseType == BasicType.btChar) return "byte"; // ? make "char" signed since its unspecified in c++ whenever its signed or not
        if (bytes == 1 && baseType == BasicType.btBool) return "byte";
        if (bytes == 1 && baseType == BasicType.btInt) return "sbyte";
        if (bytes == 1 && baseType == BasicType.btUInt) return "byte";

        if (bytes == 2 && baseType == BasicType.btWChar) return "char";
        if (bytes == 2 && baseType == BasicType.btInt) return "short";
        if (bytes == 2 && baseType == BasicType.btUInt) return "ushort";

        if (bytes == 4 && baseType == BasicType.btInt) return "int";
        if (bytes == 4 && baseType == BasicType.btLong) return "int";
        if (bytes == 4 && baseType == BasicType.btUInt) return "uint";
        if (bytes == 4 && baseType == BasicType.btULong) return "uint";
        if (bytes == 4 && baseType == BasicType.btFloat) return "float";
        
        if (bytes == 8 && baseType == BasicType.btInt) return "long";
        if (bytes == 8 && baseType == BasicType.btUInt) return "ulong";
        //if(bytes == 8 && baseType == btULong) return "ulong";
        if (bytes == 8 && baseType == BasicType.btFloat) return "double";

        throw new NotImplementedException();

        return $"void /* {baseType} / {bytes} */";
    }

    protected override string GetTypeName(IDiaSymbol* pDiaSymbol, in string argName = "")
    {
        SymTag symTag;
        if (!pDiaSymbol->get_symTag(pDiaSymbol, &symTag))
            return "void*";

        switch (symTag)
        {
            case SymTag.SymTagUDT:
                return GetTypeNameUserDefined(pDiaSymbol);
            case SymTag.SymTagBaseType:
                return GetBaseTypeName(pDiaSymbol);
            case SymTag.SymTagPointerType:
                IDiaSymbol* pointerType;
                if (pDiaSymbol->get_type(pDiaSymbol, &pointerType) && pointerType != null)
                {
                    return $"{GetTypeName(pointerType)}*"; // Append '*' for pointer types
                }
                return "void*";
            case SymTag.SymTagFunctionType:
                return "void*"; // TODO: break-down typedef parts and reconstruct as delegate*<>
            case SymTag.SymTagArrayType:
                // char Name[40];
                // byte /*char[40]*/ Name;
                // TODO: generate InlineArray types "Array_char_40" or "Array_ImGuiKeyOwnerData_154"
                int arraySize;
                IDiaSymbol* arrayType;
                if (pDiaSymbol->get_count(pDiaSymbol, &arraySize) && pDiaSymbol->get_type(pDiaSymbol, &arrayType) && arrayType != null)
                {
                    BasicType baseType2;
                    if (arrayType->get_baseType(arrayType, &baseType2))
                    {
                        string arrayTypeName = GetTypeName(arrayType);
                        return $"byte /* {arrayTypeName} [{arraySize}] */";
                    }
                }

                return "byte /* array, unknown length */";
            case SymTag.SymTagEnum:
                return GetName(pDiaSymbol);
            default:
                // unhandled
                return "void*";
        }
    }
    
}