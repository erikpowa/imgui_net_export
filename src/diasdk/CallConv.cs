namespace imgui_net_export;

public enum CallConv
{
    CV_CALL_NEAR_C = 0x00, // near right to left push, caller pops stack
    CV_CALL_FAR_C = 0x01, // far right to left push, caller pops stack
    CV_CALL_NEAR_PASCAL = 0x02, // near left to right push, callee pops stack
    CV_CALL_FAR_PASCAL = 0x03, // far left to right push, callee pops stack
    CV_CALL_NEAR_FAST = 0x04, // near left to right push with regs, callee pops stack
    CV_CALL_FAR_FAST = 0x05, // far left to right push with regs, callee pops stack
    CV_CALL_SKIPPED = 0x06, // skipped (unused) call index
    CV_CALL_NEAR_STD = 0x07, // near standard call
    CV_CALL_FAR_STD = 0x08, // far standard call
    CV_CALL_NEAR_SYS = 0x09, // near sys call
    CV_CALL_FAR_SYS = 0x0a, // far sys call
    CV_CALL_THISCALL = 0x0b, // this call (this passed in register)
    CV_CALL_MIPSCALL = 0x0c, // Mips call
    CV_CALL_GENERIC = 0x0d, // Generic call sequence
    CV_CALL_ALPHACALL = 0x0e, // Alpha call
    CV_CALL_PPCCALL = 0x0f, // PPC call
    CV_CALL_SHCALL = 0x10, // Hitachi SuperH call
    CV_CALL_ARMCALL = 0x11, // ARM call
    CV_CALL_AM33CALL = 0x12, // AM33 call
    CV_CALL_TRICALL = 0x13, // TriCore Call
    CV_CALL_SH5CALL = 0x14, // Hitachi SuperH-5 call
    CV_CALL_M32RCALL = 0x15, // M32R Call
    CV_CALL_CLRCALL = 0x16, // clr call
    CV_CALL_INLINE = 0x17, // Marker for routines always inlined and thus lacking a convention
    CV_CALL_NEAR_VECTOR = 0x18, // near left to right push with regs, callee pops stack
    CV_CALL_SWIFT = 0x19, // Swift calling convention
    CV_CALL_RESERVED = 0x20 // first unused call enumeration

// Do NOT add any more machine specific conventions.  This is to be used for
// calling conventions in the source only (e.g. __cdecl, __stdcall).
}