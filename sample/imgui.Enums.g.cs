public enum ImGuiKey {
	ImGuiKey_None = 0, // 0x0000
	ImGuiKey_NamedKey_BEGIN = 1 << 9, // 0x0200
	ImGuiKey_Tab = 1 << 9, // 0x0200
	ImGuiKey_LeftArrow = 513, // 0x0201
	ImGuiKey_RightArrow = 514, // 0x0202
	ImGuiKey_UpArrow = 515, // 0x0203
	ImGuiKey_DownArrow = 516, // 0x0204
	ImGuiKey_PageUp = 517, // 0x0205
	ImGuiKey_PageDown = 518, // 0x0206
	ImGuiKey_Home = 519, // 0x0207
	ImGuiKey_End = 520, // 0x0208
	ImGuiKey_Insert = 521, // 0x0209
	ImGuiKey_Delete = 522, // 0x020A
	ImGuiKey_Backspace = 523, // 0x020B
	ImGuiKey_Space = 524, // 0x020C
	ImGuiKey_Enter = 525, // 0x020D
	ImGuiKey_Escape = 526, // 0x020E
	ImGuiKey_LeftCtrl = 527, // 0x020F
	ImGuiKey_LeftShift = 528, // 0x0210
	ImGuiKey_LeftAlt = 529, // 0x0211
	ImGuiKey_LeftSuper = 530, // 0x0212
	ImGuiKey_RightCtrl = 531, // 0x0213
	ImGuiKey_RightShift = 532, // 0x0214
	ImGuiKey_RightAlt = 533, // 0x0215
	ImGuiKey_RightSuper = 534, // 0x0216
	ImGuiKey_Menu = 535, // 0x0217
	ImGuiKey_0 = 536, // 0x0218
	ImGuiKey_1 = 537, // 0x0219
	ImGuiKey_2 = 538, // 0x021A
	ImGuiKey_3 = 539, // 0x021B
	ImGuiKey_4 = 540, // 0x021C
	ImGuiKey_5 = 541, // 0x021D
	ImGuiKey_6 = 542, // 0x021E
	ImGuiKey_7 = 543, // 0x021F
	ImGuiKey_8 = 544, // 0x0220
	ImGuiKey_9 = 545, // 0x0221
	ImGuiKey_A = 546, // 0x0222
	ImGuiKey_B = 547, // 0x0223
	ImGuiKey_C = 548, // 0x0224
	ImGuiKey_D = 549, // 0x0225
	ImGuiKey_E = 550, // 0x0226
	ImGuiKey_F = 551, // 0x0227
	ImGuiKey_G = 552, // 0x0228
	ImGuiKey_H = 553, // 0x0229
	ImGuiKey_I = 554, // 0x022A
	ImGuiKey_J = 555, // 0x022B
	ImGuiKey_K = 556, // 0x022C
	ImGuiKey_L = 557, // 0x022D
	ImGuiKey_M = 558, // 0x022E
	ImGuiKey_N = 559, // 0x022F
	ImGuiKey_O = 560, // 0x0230
	ImGuiKey_P = 561, // 0x0231
	ImGuiKey_Q = 562, // 0x0232
	ImGuiKey_R = 563, // 0x0233
	ImGuiKey_S = 564, // 0x0234
	ImGuiKey_T = 565, // 0x0235
	ImGuiKey_U = 566, // 0x0236
	ImGuiKey_V = 567, // 0x0237
	ImGuiKey_W = 568, // 0x0238
	ImGuiKey_X = 569, // 0x0239
	ImGuiKey_Y = 570, // 0x023A
	ImGuiKey_Z = 571, // 0x023B
	ImGuiKey_F1 = 572, // 0x023C
	ImGuiKey_F2 = 573, // 0x023D
	ImGuiKey_F3 = 574, // 0x023E
	ImGuiKey_F4 = 575, // 0x023F
	ImGuiKey_F5 = 576, // 0x0240
	ImGuiKey_F6 = 577, // 0x0241
	ImGuiKey_F7 = 578, // 0x0242
	ImGuiKey_F8 = 579, // 0x0243
	ImGuiKey_F9 = 580, // 0x0244
	ImGuiKey_F10 = 581, // 0x0245
	ImGuiKey_F11 = 582, // 0x0246
	ImGuiKey_F12 = 583, // 0x0247
	ImGuiKey_F13 = 584, // 0x0248
	ImGuiKey_F14 = 585, // 0x0249
	ImGuiKey_F15 = 586, // 0x024A
	ImGuiKey_F16 = 587, // 0x024B
	ImGuiKey_F17 = 588, // 0x024C
	ImGuiKey_F18 = 589, // 0x024D
	ImGuiKey_F19 = 590, // 0x024E
	ImGuiKey_F20 = 591, // 0x024F
	ImGuiKey_F21 = 592, // 0x0250
	ImGuiKey_F22 = 593, // 0x0251
	ImGuiKey_F23 = 594, // 0x0252
	ImGuiKey_F24 = 595, // 0x0253
	ImGuiKey_Apostrophe = 596, // 0x0254
	ImGuiKey_Comma = 597, // 0x0255
	ImGuiKey_Minus = 598, // 0x0256
	ImGuiKey_Period = 599, // 0x0257
	ImGuiKey_Slash = 600, // 0x0258
	ImGuiKey_Semicolon = 601, // 0x0259
	ImGuiKey_Equal = 602, // 0x025A
	ImGuiKey_LeftBracket = 603, // 0x025B
	ImGuiKey_Backslash = 604, // 0x025C
	ImGuiKey_RightBracket = 605, // 0x025D
	ImGuiKey_GraveAccent = 606, // 0x025E
	ImGuiKey_CapsLock = 607, // 0x025F
	ImGuiKey_ScrollLock = 608, // 0x0260
	ImGuiKey_NumLock = 609, // 0x0261
	ImGuiKey_PrintScreen = 610, // 0x0262
	ImGuiKey_Pause = 611, // 0x0263
	ImGuiKey_Keypad0 = 612, // 0x0264
	ImGuiKey_Keypad1 = 613, // 0x0265
	ImGuiKey_Keypad2 = 614, // 0x0266
	ImGuiKey_Keypad3 = 615, // 0x0267
	ImGuiKey_Keypad4 = 616, // 0x0268
	ImGuiKey_Keypad5 = 617, // 0x0269
	ImGuiKey_Keypad6 = 618, // 0x026A
	ImGuiKey_Keypad7 = 619, // 0x026B
	ImGuiKey_Keypad8 = 620, // 0x026C
	ImGuiKey_Keypad9 = 621, // 0x026D
	ImGuiKey_KeypadDecimal = 622, // 0x026E
	ImGuiKey_KeypadDivide = 623, // 0x026F
	ImGuiKey_KeypadMultiply = 624, // 0x0270
	ImGuiKey_KeypadSubtract = 625, // 0x0271
	ImGuiKey_KeypadAdd = 626, // 0x0272
	ImGuiKey_KeypadEnter = 627, // 0x0273
	ImGuiKey_KeypadEqual = 628, // 0x0274
	ImGuiKey_AppBack = 629, // 0x0275
	ImGuiKey_AppForward = 630, // 0x0276
	ImGuiKey_Oem102 = 631, // 0x0277
	ImGuiKey_GamepadStart = 632, // 0x0278
	ImGuiKey_GamepadBack = 633, // 0x0279
	ImGuiKey_GamepadFaceLeft = 634, // 0x027A
	ImGuiKey_GamepadFaceRight = 635, // 0x027B
	ImGuiKey_GamepadFaceUp = 636, // 0x027C
	ImGuiKey_GamepadFaceDown = 637, // 0x027D
	ImGuiKey_GamepadDpadLeft = 638, // 0x027E
	ImGuiKey_GamepadDpadRight = 639, // 0x027F
	ImGuiKey_GamepadDpadUp = 640, // 0x0280
	ImGuiKey_GamepadDpadDown = 641, // 0x0281
	ImGuiKey_GamepadL1 = 642, // 0x0282
	ImGuiKey_GamepadR1 = 643, // 0x0283
	ImGuiKey_GamepadL2 = 644, // 0x0284
	ImGuiKey_GamepadR2 = 645, // 0x0285
	ImGuiKey_GamepadL3 = 646, // 0x0286
	ImGuiKey_GamepadR3 = 647, // 0x0287
	ImGuiKey_GamepadLStickLeft = 648, // 0x0288
	ImGuiKey_GamepadLStickRight = 649, // 0x0289
	ImGuiKey_GamepadLStickUp = 650, // 0x028A
	ImGuiKey_GamepadLStickDown = 651, // 0x028B
	ImGuiKey_GamepadRStickLeft = 652, // 0x028C
	ImGuiKey_GamepadRStickRight = 653, // 0x028D
	ImGuiKey_GamepadRStickUp = 654, // 0x028E
	ImGuiKey_GamepadRStickDown = 655, // 0x028F
	ImGuiKey_MouseLeft = 656, // 0x0290
	ImGuiKey_MouseRight = 657, // 0x0291
	ImGuiKey_MouseMiddle = 658, // 0x0292
	ImGuiKey_MouseX1 = 659, // 0x0293
	ImGuiKey_MouseX2 = 660, // 0x0294
	ImGuiKey_MouseWheelX = 661, // 0x0295
	ImGuiKey_MouseWheelY = 662, // 0x0296
	ImGuiKey_ReservedForModCtrl = 663, // 0x0297
	ImGuiKey_ReservedForModShift = 664, // 0x0298
	ImGuiKey_ReservedForModAlt = 665, // 0x0299
	ImGuiKey_ReservedForModSuper = 666, // 0x029A
	ImGuiKey_NamedKey_END = 667, // 0x029B
	ImGuiMod_None = 0, // 0x0000
	ImGuiMod_Ctrl = 1 << 12, // 0x1000
	ImGuiMod_Shift = 1 << 13, // 0x2000
	ImGuiMod_Alt = 1 << 14, // 0x4000
	ImGuiMod_Super = 1 << 15, // 0x8000
	ImGuiMod_Mask_ = 61440, // 0xF000
	ImGuiKey_NamedKey_COUNT = 155, // 0x009B
}
[Flags]
public enum ImGuiTableFlags {
	ImGuiTableFlags_None = 0, // 0x0000
	ImGuiTableFlags_Resizable = 1 << 0, // 0x0001
	ImGuiTableFlags_Reorderable = 1 << 1, // 0x0002
	ImGuiTableFlags_Hideable = 1 << 2, // 0x0004
	ImGuiTableFlags_Sortable = 1 << 3, // 0x0008
	ImGuiTableFlags_NoSavedSettings = 1 << 4, // 0x0010
	ImGuiTableFlags_ContextMenuInBody = 1 << 5, // 0x0020
	ImGuiTableFlags_RowBg = 1 << 6, // 0x0040
	ImGuiTableFlags_BordersInnerH = 1 << 7, // 0x0080
	ImGuiTableFlags_BordersOuterH = 1 << 8, // 0x0100
	ImGuiTableFlags_BordersInnerV = 1 << 9, // 0x0200
	ImGuiTableFlags_BordersOuterV = 1 << 10, // 0x0400
	ImGuiTableFlags_BordersH = 384, // 0x0180
	ImGuiTableFlags_BordersV = 1536, // 0x0600
	ImGuiTableFlags_BordersInner = 640, // 0x0280
	ImGuiTableFlags_BordersOuter = 1280, // 0x0500
	ImGuiTableFlags_Borders = 1920, // 0x0780
	ImGuiTableFlags_NoBordersInBody = 1 << 11, // 0x0800
	ImGuiTableFlags_NoBordersInBodyUntilResize = 1 << 12, // 0x1000
	ImGuiTableFlags_SizingFixedFit = 1 << 13, // 0x2000
	ImGuiTableFlags_SizingFixedSame = 1 << 14, // 0x4000
	ImGuiTableFlags_SizingStretchProp = 24576, // 0x6000
	ImGuiTableFlags_SizingStretchSame = 1 << 15, // 0x8000
	ImGuiTableFlags_NoHostExtendX = 1 << 16, // 0x00010000
	ImGuiTableFlags_NoHostExtendY = 1 << 17, // 0x00020000
	ImGuiTableFlags_NoKeepColumnsVisible = 1 << 18, // 0x00040000
	ImGuiTableFlags_PreciseWidths = 1 << 19, // 0x00080000
	ImGuiTableFlags_NoClip = 1 << 20, // 0x00100000
	ImGuiTableFlags_PadOuterX = 1 << 21, // 0x00200000
	ImGuiTableFlags_NoPadOuterX = 1 << 22, // 0x00400000
	ImGuiTableFlags_NoPadInnerX = 1 << 23, // 0x00800000
	ImGuiTableFlags_ScrollX = 1 << 24, // 0x01000000
	ImGuiTableFlags_ScrollY = 1 << 25, // 0x02000000
	ImGuiTableFlags_SortMulti = 1 << 26, // 0x04000000
	ImGuiTableFlags_SortTristate = 1 << 27, // 0x08000000
	ImGuiTableFlags_HighlightHoveredColumn = 1 << 28, // 0x10000000
	ImGuiTableFlags_SizingMask_ = 57344, // 0xE000
}
[Flags]
public enum ImGuiColorEditFlags {
	ImGuiColorEditFlags_None = 0, // 0x0000
	ImGuiColorEditFlags_NoAlpha = 1 << 1, // 0x0002
	ImGuiColorEditFlags_NoPicker = 1 << 2, // 0x0004
	ImGuiColorEditFlags_NoOptions = 1 << 3, // 0x0008
	ImGuiColorEditFlags_NoSmallPreview = 1 << 4, // 0x0010
	ImGuiColorEditFlags_NoInputs = 1 << 5, // 0x0020
	ImGuiColorEditFlags_NoTooltip = 1 << 6, // 0x0040
	ImGuiColorEditFlags_NoLabel = 1 << 7, // 0x0080
	ImGuiColorEditFlags_NoSidePreview = 1 << 8, // 0x0100
	ImGuiColorEditFlags_NoDragDrop = 1 << 9, // 0x0200
	ImGuiColorEditFlags_NoBorder = 1 << 10, // 0x0400
	ImGuiColorEditFlags_AlphaOpaque = 1 << 11, // 0x0800
	ImGuiColorEditFlags_AlphaNoBg = 1 << 12, // 0x1000
	ImGuiColorEditFlags_AlphaPreviewHalf = 1 << 13, // 0x2000
	ImGuiColorEditFlags_AlphaBar = 1 << 16, // 0x00010000
	ImGuiColorEditFlags_HDR = 1 << 19, // 0x00080000
	ImGuiColorEditFlags_DisplayRGB = 1 << 20, // 0x00100000
	ImGuiColorEditFlags_DisplayHSV = 1 << 21, // 0x00200000
	ImGuiColorEditFlags_DisplayHex = 1 << 22, // 0x00400000
	ImGuiColorEditFlags_Uint8 = 1 << 23, // 0x00800000
	ImGuiColorEditFlags_Float = 1 << 24, // 0x01000000
	ImGuiColorEditFlags_PickerHueBar = 1 << 25, // 0x02000000
	ImGuiColorEditFlags_PickerHueWheel = 1 << 26, // 0x04000000
	ImGuiColorEditFlags_InputRGB = 1 << 27, // 0x08000000
	ImGuiColorEditFlags_InputHSV = 1 << 28, // 0x10000000
	ImGuiColorEditFlags_DefaultOptions_ = 177209344, // 0x0A900000
	ImGuiColorEditFlags_AlphaMask_ = 14338, // 0x3802
	ImGuiColorEditFlags_DisplayMask_ = 7340032, // 0x00700000
	ImGuiColorEditFlags_DataTypeMask_ = 25165824, // 0x01800000
	ImGuiColorEditFlags_PickerMask_ = 100663296, // 0x06000000
	ImGuiColorEditFlags_InputMask_ = 402653184, // 0x18000000
}
public enum ImGuiStyleVar {
	ImGuiStyleVar_Alpha = 0, // 0x0000
	ImGuiStyleVar_DisabledAlpha = 1 << 0, // 0x0001
	ImGuiStyleVar_WindowPadding = 1 << 1, // 0x0002
	ImGuiStyleVar_WindowRounding = 3, // 0x0003
	ImGuiStyleVar_WindowBorderSize = 1 << 2, // 0x0004
	ImGuiStyleVar_WindowMinSize = 5, // 0x0005
	ImGuiStyleVar_WindowTitleAlign = 6, // 0x0006
	ImGuiStyleVar_ChildRounding = 7, // 0x0007
	ImGuiStyleVar_ChildBorderSize = 1 << 3, // 0x0008
	ImGuiStyleVar_PopupRounding = 9, // 0x0009
	ImGuiStyleVar_PopupBorderSize = 10, // 0x000A
	ImGuiStyleVar_FramePadding = 11, // 0x000B
	ImGuiStyleVar_FrameRounding = 12, // 0x000C
	ImGuiStyleVar_FrameBorderSize = 13, // 0x000D
	ImGuiStyleVar_ItemSpacing = 14, // 0x000E
	ImGuiStyleVar_ItemInnerSpacing = 15, // 0x000F
	ImGuiStyleVar_IndentSpacing = 1 << 4, // 0x0010
	ImGuiStyleVar_CellPadding = 17, // 0x0011
	ImGuiStyleVar_ScrollbarSize = 18, // 0x0012
	ImGuiStyleVar_ScrollbarRounding = 19, // 0x0013
	ImGuiStyleVar_GrabMinSize = 20, // 0x0014
	ImGuiStyleVar_GrabRounding = 21, // 0x0015
	ImGuiStyleVar_ImageBorderSize = 22, // 0x0016
	ImGuiStyleVar_TabRounding = 23, // 0x0017
	ImGuiStyleVar_TabBorderSize = 24, // 0x0018
	ImGuiStyleVar_TabBarBorderSize = 25, // 0x0019
	ImGuiStyleVar_TabBarOverlineSize = 26, // 0x001A
	ImGuiStyleVar_TableAngledHeadersAngle = 27, // 0x001B
	ImGuiStyleVar_TableAngledHeadersTextAlign = 28, // 0x001C
	ImGuiStyleVar_ButtonTextAlign = 29, // 0x001D
	ImGuiStyleVar_SelectableTextAlign = 30, // 0x001E
	ImGuiStyleVar_SeparatorTextBorderSize = 31, // 0x001F
	ImGuiStyleVar_SeparatorTextAlign = 1 << 5, // 0x0020
	ImGuiStyleVar_SeparatorTextPadding = 33, // 0x0021
	ImGuiStyleVar_DockingSeparatorSize = 34, // 0x0022
	ImGuiStyleVar_COUNT = 35, // 0x0023
}
public enum ImGuiTableBgTarget {
	ImGuiTableBgTarget_None = 0, // 0x0000
	ImGuiTableBgTarget_RowBg0 = 1 << 0, // 0x0001
	ImGuiTableBgTarget_RowBg1 = 1 << 1, // 0x0002
	ImGuiTableBgTarget_CellBg = 3, // 0x0003
}
[Flags]
public enum ImGuiTableColumnFlags {
	ImGuiTableColumnFlags_None = 0, // 0x0000
	ImGuiTableColumnFlags_Disabled = 1 << 0, // 0x0001
	ImGuiTableColumnFlags_DefaultHide = 1 << 1, // 0x0002
	ImGuiTableColumnFlags_DefaultSort = 1 << 2, // 0x0004
	ImGuiTableColumnFlags_WidthStretch = 1 << 3, // 0x0008
	ImGuiTableColumnFlags_WidthFixed = 1 << 4, // 0x0010
	ImGuiTableColumnFlags_NoResize = 1 << 5, // 0x0020
	ImGuiTableColumnFlags_NoReorder = 1 << 6, // 0x0040
	ImGuiTableColumnFlags_NoHide = 1 << 7, // 0x0080
	ImGuiTableColumnFlags_NoClip = 1 << 8, // 0x0100
	ImGuiTableColumnFlags_NoSort = 1 << 9, // 0x0200
	ImGuiTableColumnFlags_NoSortAscending = 1 << 10, // 0x0400
	ImGuiTableColumnFlags_NoSortDescending = 1 << 11, // 0x0800
	ImGuiTableColumnFlags_NoHeaderLabel = 1 << 12, // 0x1000
	ImGuiTableColumnFlags_NoHeaderWidth = 1 << 13, // 0x2000
	ImGuiTableColumnFlags_PreferSortAscending = 1 << 14, // 0x4000
	ImGuiTableColumnFlags_PreferSortDescending = 1 << 15, // 0x8000
	ImGuiTableColumnFlags_IndentEnable = 1 << 16, // 0x00010000
	ImGuiTableColumnFlags_IndentDisable = 1 << 17, // 0x00020000
	ImGuiTableColumnFlags_AngledHeader = 1 << 18, // 0x00040000
	ImGuiTableColumnFlags_IsEnabled = 1 << 24, // 0x01000000
	ImGuiTableColumnFlags_IsVisible = 1 << 25, // 0x02000000
	ImGuiTableColumnFlags_IsSorted = 1 << 26, // 0x04000000
	ImGuiTableColumnFlags_IsHovered = 1 << 27, // 0x08000000
	ImGuiTableColumnFlags_WidthMask_ = 24, // 0x0018
	ImGuiTableColumnFlags_IndentMask_ = 196608, // 0x00030000
	ImGuiTableColumnFlags_StatusMask_ = 251658240, // 0x0F000000
	ImGuiTableColumnFlags_NoDirectResize_ = 1 << 30, // 0x40000000
}
[Flags]
public enum ImGuiButtonFlags {
	ImGuiButtonFlags_None = 0, // 0x0000
	ImGuiButtonFlags_MouseButtonLeft = 1 << 0, // 0x0001
	ImGuiButtonFlags_MouseButtonRight = 1 << 1, // 0x0002
	ImGuiButtonFlags_MouseButtonMiddle = 1 << 2, // 0x0004
	ImGuiButtonFlags_MouseButtonMask_ = 7, // 0x0007
	ImGuiButtonFlags_EnableNav = 1 << 3, // 0x0008
}
[Flags]
public enum ImGuiOldColumnFlags {
	ImGuiOldColumnFlags_None = 0, // 0x0000
	ImGuiOldColumnFlags_NoBorder = 1 << 0, // 0x0001
	ImGuiOldColumnFlags_NoResize = 1 << 1, // 0x0002
	ImGuiOldColumnFlags_NoPreserveWidths = 1 << 2, // 0x0004
	ImGuiOldColumnFlags_NoForceWithinWindow = 1 << 3, // 0x0008
	ImGuiOldColumnFlags_GrowParentContentsSize = 1 << 4, // 0x0010
}
[Flags]
public enum ImFontAtlasFlags {
	ImFontAtlasFlags_None = 0, // 0x0000
	ImFontAtlasFlags_NoPowerOfTwoHeight = 1 << 0, // 0x0001
	ImFontAtlasFlags_NoMouseCursors = 1 << 1, // 0x0002
	ImFontAtlasFlags_NoBakedLines = 1 << 2, // 0x0004
}
[Flags]
public enum ImGuiWindowFlags {
	ImGuiWindowFlags_None = 0, // 0x0000
	ImGuiWindowFlags_NoTitleBar = 1 << 0, // 0x0001
	ImGuiWindowFlags_NoResize = 1 << 1, // 0x0002
	ImGuiWindowFlags_NoMove = 1 << 2, // 0x0004
	ImGuiWindowFlags_NoScrollbar = 1 << 3, // 0x0008
	ImGuiWindowFlags_NoScrollWithMouse = 1 << 4, // 0x0010
	ImGuiWindowFlags_NoCollapse = 1 << 5, // 0x0020
	ImGuiWindowFlags_AlwaysAutoResize = 1 << 6, // 0x0040
	ImGuiWindowFlags_NoBackground = 1 << 7, // 0x0080
	ImGuiWindowFlags_NoSavedSettings = 1 << 8, // 0x0100
	ImGuiWindowFlags_NoMouseInputs = 1 << 9, // 0x0200
	ImGuiWindowFlags_MenuBar = 1 << 10, // 0x0400
	ImGuiWindowFlags_HorizontalScrollbar = 1 << 11, // 0x0800
	ImGuiWindowFlags_NoFocusOnAppearing = 1 << 12, // 0x1000
	ImGuiWindowFlags_NoBringToFrontOnFocus = 1 << 13, // 0x2000
	ImGuiWindowFlags_AlwaysVerticalScrollbar = 1 << 14, // 0x4000
	ImGuiWindowFlags_AlwaysHorizontalScrollbar = 1 << 15, // 0x8000
	ImGuiWindowFlags_NoNavInputs = 1 << 16, // 0x00010000
	ImGuiWindowFlags_NoNavFocus = 1 << 17, // 0x00020000
	ImGuiWindowFlags_UnsavedDocument = 1 << 18, // 0x00040000
	ImGuiWindowFlags_NoDocking = 1 << 19, // 0x00080000
	ImGuiWindowFlags_NoNav = 196608, // 0x00030000
	ImGuiWindowFlags_NoDecoration = 43, // 0x002B
	ImGuiWindowFlags_NoInputs = 197120, // 0x00030200
	ImGuiWindowFlags_DockNodeHost = 1 << 23, // 0x00800000
	ImGuiWindowFlags_ChildWindow = 1 << 24, // 0x01000000
	ImGuiWindowFlags_Tooltip = 1 << 25, // 0x02000000
	ImGuiWindowFlags_Popup = 1 << 26, // 0x04000000
	ImGuiWindowFlags_Modal = 1 << 27, // 0x08000000
	ImGuiWindowFlags_ChildMenu = 1 << 28, // 0x10000000
}
[Flags]
public enum ImGuiSelectableFlags {
	ImGuiSelectableFlags_None = 0, // 0x0000
	ImGuiSelectableFlags_NoAutoClosePopups = 1 << 0, // 0x0001
	ImGuiSelectableFlags_SpanAllColumns = 1 << 1, // 0x0002
	ImGuiSelectableFlags_AllowDoubleClick = 1 << 2, // 0x0004
	ImGuiSelectableFlags_Disabled = 1 << 3, // 0x0008
	ImGuiSelectableFlags_AllowOverlap = 1 << 4, // 0x0010
	ImGuiSelectableFlags_Highlight = 1 << 5, // 0x0020
}
public enum ImGuiContextHookType {
	ImGuiContextHookType_NewFramePre = 0, // 0x0000
	ImGuiContextHookType_NewFramePost = 1 << 0, // 0x0001
	ImGuiContextHookType_EndFramePre = 1 << 1, // 0x0002
	ImGuiContextHookType_EndFramePost = 3, // 0x0003
	ImGuiContextHookType_RenderPre = 1 << 2, // 0x0004
	ImGuiContextHookType_RenderPost = 5, // 0x0005
	ImGuiContextHookType_Shutdown = 6, // 0x0006
	ImGuiContextHookType_PendingRemoval_ = 7, // 0x0007
}
[Flags]
public enum ImGuiNextWindowDataFlags {
	ImGuiNextWindowDataFlags_None = 0, // 0x0000
	ImGuiNextWindowDataFlags_HasPos = 1 << 0, // 0x0001
	ImGuiNextWindowDataFlags_HasSize = 1 << 1, // 0x0002
	ImGuiNextWindowDataFlags_HasContentSize = 1 << 2, // 0x0004
	ImGuiNextWindowDataFlags_HasCollapsed = 1 << 3, // 0x0008
	ImGuiNextWindowDataFlags_HasSizeConstraint = 1 << 4, // 0x0010
	ImGuiNextWindowDataFlags_HasFocus = 1 << 5, // 0x0020
	ImGuiNextWindowDataFlags_HasBgAlpha = 1 << 6, // 0x0040
	ImGuiNextWindowDataFlags_HasScroll = 1 << 7, // 0x0080
	ImGuiNextWindowDataFlags_HasWindowFlags = 1 << 8, // 0x0100
	ImGuiNextWindowDataFlags_HasChildFlags = 1 << 9, // 0x0200
	ImGuiNextWindowDataFlags_HasRefreshPolicy = 1 << 10, // 0x0400
	ImGuiNextWindowDataFlags_HasViewport = 1 << 11, // 0x0800
	ImGuiNextWindowDataFlags_HasDock = 1 << 12, // 0x1000
	ImGuiNextWindowDataFlags_HasWindowClass = 1 << 13, // 0x2000
}
[Flags]
public enum ImGuiInputTextFlags {
	ImGuiInputTextFlags_None = 0, // 0x0000
	ImGuiInputTextFlags_CharsDecimal = 1 << 0, // 0x0001
	ImGuiInputTextFlags_CharsHexadecimal = 1 << 1, // 0x0002
	ImGuiInputTextFlags_CharsScientific = 1 << 2, // 0x0004
	ImGuiInputTextFlags_CharsUppercase = 1 << 3, // 0x0008
	ImGuiInputTextFlags_CharsNoBlank = 1 << 4, // 0x0010
	ImGuiInputTextFlags_AllowTabInput = 1 << 5, // 0x0020
	ImGuiInputTextFlags_EnterReturnsTrue = 1 << 6, // 0x0040
	ImGuiInputTextFlags_EscapeClearsAll = 1 << 7, // 0x0080
	ImGuiInputTextFlags_CtrlEnterForNewLine = 1 << 8, // 0x0100
	ImGuiInputTextFlags_ReadOnly = 1 << 9, // 0x0200
	ImGuiInputTextFlags_Password = 1 << 10, // 0x0400
	ImGuiInputTextFlags_AlwaysOverwrite = 1 << 11, // 0x0800
	ImGuiInputTextFlags_AutoSelectAll = 1 << 12, // 0x1000
	ImGuiInputTextFlags_ParseEmptyRefVal = 1 << 13, // 0x2000
	ImGuiInputTextFlags_DisplayEmptyRefVal = 1 << 14, // 0x4000
	ImGuiInputTextFlags_NoHorizontalScroll = 1 << 15, // 0x8000
	ImGuiInputTextFlags_NoUndoRedo = 1 << 16, // 0x00010000
	ImGuiInputTextFlags_ElideLeft = 1 << 17, // 0x00020000
	ImGuiInputTextFlags_CallbackCompletion = 1 << 18, // 0x00040000
	ImGuiInputTextFlags_CallbackHistory = 1 << 19, // 0x00080000
	ImGuiInputTextFlags_CallbackAlways = 1 << 20, // 0x00100000
	ImGuiInputTextFlags_CallbackCharFilter = 1 << 21, // 0x00200000
	ImGuiInputTextFlags_CallbackResize = 1 << 22, // 0x00400000
	ImGuiInputTextFlags_CallbackEdit = 1 << 23, // 0x00800000
}
public enum ImTriangulatorNodeType {
	ImTriangulatorNodeType_Convex = 0, // 0x0000
	ImTriangulatorNodeType_Ear = 1 << 0, // 0x0001
	ImTriangulatorNodeType_Reflex = 1 << 1, // 0x0002
}
public enum ImGuiCond {
	ImGuiCond_None = 0, // 0x0000
	ImGuiCond_Always = 1 << 0, // 0x0001
	ImGuiCond_Once = 1 << 1, // 0x0002
	ImGuiCond_FirstUseEver = 1 << 2, // 0x0004
	ImGuiCond_Appearing = 1 << 3, // 0x0008
}
public enum ImGuiMouseButton {
	ImGuiMouseButton_Left = 0, // 0x0000
	ImGuiMouseButton_Right = 1 << 0, // 0x0001
	ImGuiMouseButton_Middle = 1 << 1, // 0x0002
	ImGuiMouseButton_COUNT = 5, // 0x0005
}
[Flags]
public enum ImGuiTabItemFlags {
	ImGuiTabItemFlags_None = 0, // 0x0000
	ImGuiTabItemFlags_UnsavedDocument = 1 << 0, // 0x0001
	ImGuiTabItemFlags_SetSelected = 1 << 1, // 0x0002
	ImGuiTabItemFlags_NoCloseWithMiddleMouseButton = 1 << 2, // 0x0004
	ImGuiTabItemFlags_NoPushId = 1 << 3, // 0x0008
	ImGuiTabItemFlags_NoTooltip = 1 << 4, // 0x0010
	ImGuiTabItemFlags_NoReorder = 1 << 5, // 0x0020
	ImGuiTabItemFlags_Leading = 1 << 6, // 0x0040
	ImGuiTabItemFlags_Trailing = 1 << 7, // 0x0080
	ImGuiTabItemFlags_NoAssumedClosure = 1 << 8, // 0x0100
}
[Flags]
public enum ImGuiChildFlags {
	ImGuiChildFlags_None = 0, // 0x0000
	ImGuiChildFlags_Borders = 1 << 0, // 0x0001
	ImGuiChildFlags_AlwaysUseWindowPadding = 1 << 1, // 0x0002
	ImGuiChildFlags_ResizeX = 1 << 2, // 0x0004
	ImGuiChildFlags_ResizeY = 1 << 3, // 0x0008
	ImGuiChildFlags_AutoResizeX = 1 << 4, // 0x0010
	ImGuiChildFlags_AutoResizeY = 1 << 5, // 0x0020
	ImGuiChildFlags_AlwaysAutoResize = 1 << 6, // 0x0040
	ImGuiChildFlags_FrameStyle = 1 << 7, // 0x0080
	ImGuiChildFlags_NavFlattened = 1 << 8, // 0x0100
}
public enum ImGuiMouseCursor {
	ImGuiMouseCursor_None = -1, // 0xFF
	ImGuiMouseCursor_Arrow = 0, // 0x0000
	ImGuiMouseCursor_TextInput = 1 << 0, // 0x0001
	ImGuiMouseCursor_ResizeAll = 1 << 1, // 0x0002
	ImGuiMouseCursor_ResizeNS = 3, // 0x0003
	ImGuiMouseCursor_ResizeEW = 1 << 2, // 0x0004
	ImGuiMouseCursor_ResizeNESW = 5, // 0x0005
	ImGuiMouseCursor_ResizeNWSE = 6, // 0x0006
	ImGuiMouseCursor_Hand = 7, // 0x0007
	ImGuiMouseCursor_Wait = 1 << 3, // 0x0008
	ImGuiMouseCursor_Progress = 9, // 0x0009
	ImGuiMouseCursor_NotAllowed = 10, // 0x000A
	ImGuiMouseCursor_COUNT = 11, // 0x000B
}
[Flags]
public enum ImGuiDragDropFlags {
	ImGuiDragDropFlags_None = 0, // 0x0000
	ImGuiDragDropFlags_SourceNoPreviewTooltip = 1 << 0, // 0x0001
	ImGuiDragDropFlags_SourceNoDisableHover = 1 << 1, // 0x0002
	ImGuiDragDropFlags_SourceNoHoldToOpenOthers = 1 << 2, // 0x0004
	ImGuiDragDropFlags_SourceAllowNullID = 1 << 3, // 0x0008
	ImGuiDragDropFlags_SourceExtern = 1 << 4, // 0x0010
	ImGuiDragDropFlags_PayloadAutoExpire = 1 << 5, // 0x0020
	ImGuiDragDropFlags_PayloadNoCrossContext = 1 << 6, // 0x0040
	ImGuiDragDropFlags_PayloadNoCrossProcess = 1 << 7, // 0x0080
	ImGuiDragDropFlags_AcceptBeforeDelivery = 1 << 10, // 0x0400
	ImGuiDragDropFlags_AcceptNoDrawDefaultRect = 1 << 11, // 0x0800
	ImGuiDragDropFlags_AcceptNoPreviewTooltip = 1 << 12, // 0x1000
	ImGuiDragDropFlags_AcceptPeekOnly = 3072, // 0x0C00
}
[Flags]
public enum ImGuiSliderFlags {
	ImGuiSliderFlags_None = 0, // 0x0000
	ImGuiSliderFlags_Logarithmic = 1 << 5, // 0x0020
	ImGuiSliderFlags_NoRoundToFormat = 1 << 6, // 0x0040
	ImGuiSliderFlags_NoInput = 1 << 7, // 0x0080
	ImGuiSliderFlags_WrapAround = 1 << 8, // 0x0100
	ImGuiSliderFlags_ClampOnInput = 1 << 9, // 0x0200
	ImGuiSliderFlags_ClampZeroRange = 1 << 10, // 0x0400
	ImGuiSliderFlags_NoSpeedTweaks = 1 << 11, // 0x0800
	ImGuiSliderFlags_AlwaysClamp = 1536, // 0x0600
	ImGuiSliderFlags_InvalidMask_ = 1879048207, // 0x7000000F
}
[Flags]
public enum ImGuiTableRowFlags {
	ImGuiTableRowFlags_None = 0, // 0x0000
	ImGuiTableRowFlags_Headers = 1 << 0, // 0x0001
}
[Flags]
public enum ImDrawFlags {
	ImDrawFlags_None = 0, // 0x0000
	ImDrawFlags_Closed = 1 << 0, // 0x0001
	ImDrawFlags_RoundCornersTopLeft = 1 << 4, // 0x0010
	ImDrawFlags_RoundCornersTopRight = 1 << 5, // 0x0020
	ImDrawFlags_RoundCornersBottomLeft = 1 << 6, // 0x0040
	ImDrawFlags_RoundCornersBottomRight = 1 << 7, // 0x0080
	ImDrawFlags_RoundCornersNone = 1 << 8, // 0x0100
	ImDrawFlags_RoundCornersTop = 48, // 0x0030
	ImDrawFlags_RoundCornersBottom = 192, // 0x00C0
	ImDrawFlags_RoundCornersLeft = 80, // 0x0050
	ImDrawFlags_RoundCornersRight = 160, // 0x00A0
	ImDrawFlags_RoundCornersAll = 240, // 0x00F0
	ImDrawFlags_RoundCornersDefault_ = 240, // 0x00F0
	ImDrawFlags_RoundCornersMask_ = 496, // 0x01F0
}
[Flags]
public enum ImGuiBackendFlags {
	ImGuiBackendFlags_None = 0, // 0x0000
	ImGuiBackendFlags_HasGamepad = 1 << 0, // 0x0001
	ImGuiBackendFlags_HasMouseCursors = 1 << 1, // 0x0002
	ImGuiBackendFlags_HasSetMousePos = 1 << 2, // 0x0004
	ImGuiBackendFlags_RendererHasVtxOffset = 1 << 3, // 0x0008
	ImGuiBackendFlags_PlatformHasViewports = 1 << 10, // 0x0400
	ImGuiBackendFlags_HasMouseHoveredViewport = 1 << 11, // 0x0800
	ImGuiBackendFlags_RendererHasViewports = 1 << 12, // 0x1000
}
public enum ImGuiSortDirection {
	ImGuiSortDirection_None = 0, // 0x0000
	ImGuiSortDirection_Ascending = 1 << 0, // 0x0001
	ImGuiSortDirection_Descending = 1 << 1, // 0x0002
}
[Flags]
public enum ImGuiTreeNodeFlags {
	ImGuiTreeNodeFlags_None = 0, // 0x0000
	ImGuiTreeNodeFlags_Selected = 1 << 0, // 0x0001
	ImGuiTreeNodeFlags_Framed = 1 << 1, // 0x0002
	ImGuiTreeNodeFlags_AllowOverlap = 1 << 2, // 0x0004
	ImGuiTreeNodeFlags_NoTreePushOnOpen = 1 << 3, // 0x0008
	ImGuiTreeNodeFlags_NoAutoOpenOnLog = 1 << 4, // 0x0010
	ImGuiTreeNodeFlags_DefaultOpen = 1 << 5, // 0x0020
	ImGuiTreeNodeFlags_OpenOnDoubleClick = 1 << 6, // 0x0040
	ImGuiTreeNodeFlags_OpenOnArrow = 1 << 7, // 0x0080
	ImGuiTreeNodeFlags_Leaf = 1 << 8, // 0x0100
	ImGuiTreeNodeFlags_Bullet = 1 << 9, // 0x0200
	ImGuiTreeNodeFlags_FramePadding = 1 << 10, // 0x0400
	ImGuiTreeNodeFlags_SpanAvailWidth = 1 << 11, // 0x0800
	ImGuiTreeNodeFlags_SpanFullWidth = 1 << 12, // 0x1000
	ImGuiTreeNodeFlags_SpanLabelWidth = 1 << 13, // 0x2000
	ImGuiTreeNodeFlags_SpanAllColumns = 1 << 14, // 0x4000
	ImGuiTreeNodeFlags_LabelSpanAllColumns = 1 << 15, // 0x8000
	ImGuiTreeNodeFlags_NavLeftJumpsBackHere = 1 << 17, // 0x00020000
	ImGuiTreeNodeFlags_CollapsingHeader = 26, // 0x001A
}
public enum ImGuiMouseSource {
	ImGuiMouseSource_Mouse = 0, // 0x0000
	ImGuiMouseSource_TouchScreen = 1 << 0, // 0x0001
	ImGuiMouseSource_Pen = 1 << 1, // 0x0002
	ImGuiMouseSource_COUNT = 3, // 0x0003
}
[Flags]
public enum ImGuiDebugLogFlags {
	ImGuiDebugLogFlags_None = 0, // 0x0000
	ImGuiDebugLogFlags_EventError = 1 << 0, // 0x0001
	ImGuiDebugLogFlags_EventActiveId = 1 << 1, // 0x0002
	ImGuiDebugLogFlags_EventFocus = 1 << 2, // 0x0004
	ImGuiDebugLogFlags_EventPopup = 1 << 3, // 0x0008
	ImGuiDebugLogFlags_EventNav = 1 << 4, // 0x0010
	ImGuiDebugLogFlags_EventClipper = 1 << 5, // 0x0020
	ImGuiDebugLogFlags_EventSelection = 1 << 6, // 0x0040
	ImGuiDebugLogFlags_EventIO = 1 << 7, // 0x0080
	ImGuiDebugLogFlags_EventFont = 1 << 8, // 0x0100
	ImGuiDebugLogFlags_EventInputRouting = 1 << 9, // 0x0200
	ImGuiDebugLogFlags_EventDocking = 1 << 10, // 0x0400
	ImGuiDebugLogFlags_EventViewport = 1 << 11, // 0x0800
	ImGuiDebugLogFlags_EventMask_ = 4095, // 0x0FFF
	ImGuiDebugLogFlags_OutputToTTY = 1 << 20, // 0x00100000
	ImGuiDebugLogFlags_OutputToTestEngine = 1 << 21, // 0x00200000
}
public enum ImGuiCol {
	ImGuiCol_Text = 0, // 0x0000
	ImGuiCol_TextDisabled = 1 << 0, // 0x0001
	ImGuiCol_WindowBg = 1 << 1, // 0x0002
	ImGuiCol_ChildBg = 3, // 0x0003
	ImGuiCol_PopupBg = 1 << 2, // 0x0004
	ImGuiCol_Border = 5, // 0x0005
	ImGuiCol_BorderShadow = 6, // 0x0006
	ImGuiCol_FrameBg = 7, // 0x0007
	ImGuiCol_FrameBgHovered = 1 << 3, // 0x0008
	ImGuiCol_FrameBgActive = 9, // 0x0009
	ImGuiCol_TitleBg = 10, // 0x000A
	ImGuiCol_TitleBgActive = 11, // 0x000B
	ImGuiCol_TitleBgCollapsed = 12, // 0x000C
	ImGuiCol_MenuBarBg = 13, // 0x000D
	ImGuiCol_ScrollbarBg = 14, // 0x000E
	ImGuiCol_ScrollbarGrab = 15, // 0x000F
	ImGuiCol_ScrollbarGrabHovered = 1 << 4, // 0x0010
	ImGuiCol_ScrollbarGrabActive = 17, // 0x0011
	ImGuiCol_CheckMark = 18, // 0x0012
	ImGuiCol_SliderGrab = 19, // 0x0013
	ImGuiCol_SliderGrabActive = 20, // 0x0014
	ImGuiCol_Button = 21, // 0x0015
	ImGuiCol_ButtonHovered = 22, // 0x0016
	ImGuiCol_ButtonActive = 23, // 0x0017
	ImGuiCol_Header = 24, // 0x0018
	ImGuiCol_HeaderHovered = 25, // 0x0019
	ImGuiCol_HeaderActive = 26, // 0x001A
	ImGuiCol_Separator = 27, // 0x001B
	ImGuiCol_SeparatorHovered = 28, // 0x001C
	ImGuiCol_SeparatorActive = 29, // 0x001D
	ImGuiCol_ResizeGrip = 30, // 0x001E
	ImGuiCol_ResizeGripHovered = 31, // 0x001F
	ImGuiCol_ResizeGripActive = 1 << 5, // 0x0020
	ImGuiCol_InputTextCursor = 33, // 0x0021
	ImGuiCol_TabHovered = 34, // 0x0022
	ImGuiCol_Tab = 35, // 0x0023
	ImGuiCol_TabSelected = 36, // 0x0024
	ImGuiCol_TabSelectedOverline = 37, // 0x0025
	ImGuiCol_TabDimmed = 38, // 0x0026
	ImGuiCol_TabDimmedSelected = 39, // 0x0027
	ImGuiCol_TabDimmedSelectedOverline = 40, // 0x0028
	ImGuiCol_DockingPreview = 41, // 0x0029
	ImGuiCol_DockingEmptyBg = 42, // 0x002A
	ImGuiCol_PlotLines = 43, // 0x002B
	ImGuiCol_PlotLinesHovered = 44, // 0x002C
	ImGuiCol_PlotHistogram = 45, // 0x002D
	ImGuiCol_PlotHistogramHovered = 46, // 0x002E
	ImGuiCol_TableHeaderBg = 47, // 0x002F
	ImGuiCol_TableBorderStrong = 48, // 0x0030
	ImGuiCol_TableBorderLight = 49, // 0x0031
	ImGuiCol_TableRowBg = 50, // 0x0032
	ImGuiCol_TableRowBgAlt = 51, // 0x0033
	ImGuiCol_TextLink = 52, // 0x0034
	ImGuiCol_TextSelectedBg = 53, // 0x0035
	ImGuiCol_DragDropTarget = 54, // 0x0036
	ImGuiCol_NavCursor = 55, // 0x0037
	ImGuiCol_NavWindowingHighlight = 56, // 0x0038
	ImGuiCol_NavWindowingDimBg = 57, // 0x0039
	ImGuiCol_ModalWindowDimBg = 58, // 0x003A
	ImGuiCol_COUNT = 59, // 0x003B
}
[Flags]
public enum ImGuiComboFlags {
	ImGuiComboFlags_None = 0, // 0x0000
	ImGuiComboFlags_PopupAlignLeft = 1 << 0, // 0x0001
	ImGuiComboFlags_HeightSmall = 1 << 1, // 0x0002
	ImGuiComboFlags_HeightRegular = 1 << 2, // 0x0004
	ImGuiComboFlags_HeightLarge = 1 << 3, // 0x0008
	ImGuiComboFlags_HeightLargest = 1 << 4, // 0x0010
	ImGuiComboFlags_NoArrowButton = 1 << 5, // 0x0020
	ImGuiComboFlags_NoPreview = 1 << 6, // 0x0040
	ImGuiComboFlags_WidthFitPreview = 1 << 7, // 0x0080
	ImGuiComboFlags_HeightMask_ = 30, // 0x001E
}
public enum ImGuiLocKey {
	ImGuiLocKey_VersionStr = 0, // 0x0000
	ImGuiLocKey_TableSizeOne = 1 << 0, // 0x0001
	ImGuiLocKey_TableSizeAllFit = 1 << 1, // 0x0002
	ImGuiLocKey_TableSizeAllDefault = 3, // 0x0003
	ImGuiLocKey_TableResetOrder = 1 << 2, // 0x0004
	ImGuiLocKey_WindowingMainMenuBar = 5, // 0x0005
	ImGuiLocKey_WindowingPopup = 6, // 0x0006
	ImGuiLocKey_WindowingUntitled = 7, // 0x0007
	ImGuiLocKey_OpenLink_s = 1 << 3, // 0x0008
	ImGuiLocKey_CopyLink = 9, // 0x0009
	ImGuiLocKey_DockingHideTabBar = 10, // 0x000A
	ImGuiLocKey_DockingHoldShiftToDock = 11, // 0x000B
	ImGuiLocKey_DockingDragToUndockOrMoveNode = 12, // 0x000C
	ImGuiLocKey_COUNT = 13, // 0x000D
}
[Flags]
public enum ImGuiConfigFlags {
	ImGuiConfigFlags_None = 0, // 0x0000
	ImGuiConfigFlags_NavEnableKeyboard = 1 << 0, // 0x0001
	ImGuiConfigFlags_NavEnableGamepad = 1 << 1, // 0x0002
	ImGuiConfigFlags_NoMouse = 1 << 4, // 0x0010
	ImGuiConfigFlags_NoMouseCursorChange = 1 << 5, // 0x0020
	ImGuiConfigFlags_NoKeyboard = 1 << 6, // 0x0040
	ImGuiConfigFlags_DockingEnable = 1 << 7, // 0x0080
	ImGuiConfigFlags_ViewportsEnable = 1 << 10, // 0x0400
	ImGuiConfigFlags_DpiEnableScaleViewports = 1 << 14, // 0x4000
	ImGuiConfigFlags_DpiEnableScaleFonts = 1 << 15, // 0x8000
	ImGuiConfigFlags_IsSRGB = 1 << 20, // 0x00100000
	ImGuiConfigFlags_IsTouchScreen = 1 << 21, // 0x00200000
}
[Flags]
public enum ImGuiNextItemDataFlags {
	ImGuiNextItemDataFlags_None = 0, // 0x0000
	ImGuiNextItemDataFlags_HasWidth = 1 << 0, // 0x0001
	ImGuiNextItemDataFlags_HasOpen = 1 << 1, // 0x0002
	ImGuiNextItemDataFlags_HasShortcut = 1 << 2, // 0x0004
	ImGuiNextItemDataFlags_HasRefVal = 1 << 3, // 0x0008
	ImGuiNextItemDataFlags_HasStorageID = 1 << 4, // 0x0010
}
public enum ImGuiInputSource {
	ImGuiInputSource_None = 0, // 0x0000
	ImGuiInputSource_Mouse = 1 << 0, // 0x0001
	ImGuiInputSource_Keyboard = 1 << 1, // 0x0002
	ImGuiInputSource_Gamepad = 3, // 0x0003
	ImGuiInputSource_COUNT = 1 << 2, // 0x0004
}
[Flags]
public enum ImGuiMultiSelectFlags {
	ImGuiMultiSelectFlags_None = 0, // 0x0000
	ImGuiMultiSelectFlags_SingleSelect = 1 << 0, // 0x0001
	ImGuiMultiSelectFlags_NoSelectAll = 1 << 1, // 0x0002
	ImGuiMultiSelectFlags_NoRangeSelect = 1 << 2, // 0x0004
	ImGuiMultiSelectFlags_NoAutoSelect = 1 << 3, // 0x0008
	ImGuiMultiSelectFlags_NoAutoClear = 1 << 4, // 0x0010
	ImGuiMultiSelectFlags_NoAutoClearOnReselect = 1 << 5, // 0x0020
	ImGuiMultiSelectFlags_BoxSelect1d = 1 << 6, // 0x0040
	ImGuiMultiSelectFlags_BoxSelect2d = 1 << 7, // 0x0080
	ImGuiMultiSelectFlags_BoxSelectNoScroll = 1 << 8, // 0x0100
	ImGuiMultiSelectFlags_ClearOnEscape = 1 << 9, // 0x0200
	ImGuiMultiSelectFlags_ClearOnClickVoid = 1 << 10, // 0x0400
	ImGuiMultiSelectFlags_ScopeWindow = 1 << 11, // 0x0800
	ImGuiMultiSelectFlags_ScopeRect = 1 << 12, // 0x1000
	ImGuiMultiSelectFlags_SelectOnClick = 1 << 13, // 0x2000
	ImGuiMultiSelectFlags_SelectOnClickRelease = 1 << 14, // 0x4000
	ImGuiMultiSelectFlags_NavWrapX = 1 << 16, // 0x00010000
}
public enum ImGuiDataType {
	ImGuiDataType_S8 = 0, // 0x0000
	ImGuiDataType_U8 = 1 << 0, // 0x0001
	ImGuiDataType_S16 = 1 << 1, // 0x0002
	ImGuiDataType_U16 = 3, // 0x0003
	ImGuiDataType_S32 = 1 << 2, // 0x0004
	ImGuiDataType_U32 = 5, // 0x0005
	ImGuiDataType_S64 = 6, // 0x0006
	ImGuiDataType_U64 = 7, // 0x0007
	ImGuiDataType_Float = 1 << 3, // 0x0008
	ImGuiDataType_Double = 9, // 0x0009
	ImGuiDataType_Bool = 10, // 0x000A
	ImGuiDataType_String = 11, // 0x000B
	ImGuiDataType_COUNT = 12, // 0x000C
}
[Flags]
public enum ImGuiScrollFlags {
	ImGuiScrollFlags_None = 0, // 0x0000
	ImGuiScrollFlags_KeepVisibleEdgeX = 1 << 0, // 0x0001
	ImGuiScrollFlags_KeepVisibleEdgeY = 1 << 1, // 0x0002
	ImGuiScrollFlags_KeepVisibleCenterX = 1 << 2, // 0x0004
	ImGuiScrollFlags_KeepVisibleCenterY = 1 << 3, // 0x0008
	ImGuiScrollFlags_AlwaysCenterX = 1 << 4, // 0x0010
	ImGuiScrollFlags_AlwaysCenterY = 1 << 5, // 0x0020
	ImGuiScrollFlags_NoScrollParent = 1 << 6, // 0x0040
	ImGuiScrollFlags_MaskX_ = 21, // 0x0015
	ImGuiScrollFlags_MaskY_ = 42, // 0x002A
}
public enum ImGuiDir {
	ImGuiDir_None = -1, // 0xFF
	ImGuiDir_Left = 0, // 0x0000
	ImGuiDir_Right = 1 << 0, // 0x0001
	ImGuiDir_Up = 1 << 1, // 0x0002
	ImGuiDir_Down = 3, // 0x0003
	ImGuiDir_COUNT = 1 << 2, // 0x0004
}
[Flags]
public enum ImGuiItemFlags {
	ImGuiItemFlags_None = 0, // 0x0000
	ImGuiItemFlags_NoTabStop = 1 << 0, // 0x0001
	ImGuiItemFlags_NoNav = 1 << 1, // 0x0002
	ImGuiItemFlags_NoNavDefaultFocus = 1 << 2, // 0x0004
	ImGuiItemFlags_ButtonRepeat = 1 << 3, // 0x0008
	ImGuiItemFlags_AutoClosePopups = 1 << 4, // 0x0010
	ImGuiItemFlags_AllowDuplicateId = 1 << 5, // 0x0020
}
public enum ImGuiPlotType {
	ImGuiPlotType_Lines = 0, // 0x0000
	ImGuiPlotType_Histogram = 1 << 0, // 0x0001
}
[Flags]
public enum ImGuiNavMoveFlags {
	ImGuiNavMoveFlags_None = 0, // 0x0000
	ImGuiNavMoveFlags_LoopX = 1 << 0, // 0x0001
	ImGuiNavMoveFlags_LoopY = 1 << 1, // 0x0002
	ImGuiNavMoveFlags_WrapX = 1 << 2, // 0x0004
	ImGuiNavMoveFlags_WrapY = 1 << 3, // 0x0008
	ImGuiNavMoveFlags_WrapMask_ = 15, // 0x000F
	ImGuiNavMoveFlags_AllowCurrentNavId = 1 << 4, // 0x0010
	ImGuiNavMoveFlags_AlsoScoreVisibleSet = 1 << 5, // 0x0020
	ImGuiNavMoveFlags_ScrollToEdgeY = 1 << 6, // 0x0040
	ImGuiNavMoveFlags_Forwarded = 1 << 7, // 0x0080
	ImGuiNavMoveFlags_DebugNoResult = 1 << 8, // 0x0100
	ImGuiNavMoveFlags_FocusApi = 1 << 9, // 0x0200
	ImGuiNavMoveFlags_IsTabbing = 1 << 10, // 0x0400
	ImGuiNavMoveFlags_IsPageMove = 1 << 11, // 0x0800
	ImGuiNavMoveFlags_Activate = 1 << 12, // 0x1000
	ImGuiNavMoveFlags_NoSelect = 1 << 13, // 0x2000
	ImGuiNavMoveFlags_NoSetNavCursorVisible = 1 << 14, // 0x4000
	ImGuiNavMoveFlags_NoClearActiveId = 1 << 15, // 0x8000
}
[Flags]
public enum ImGuiTypingSelectFlags {
	ImGuiTypingSelectFlags_None = 0, // 0x0000
	ImGuiTypingSelectFlags_AllowBackspace = 1 << 0, // 0x0001
	ImGuiTypingSelectFlags_AllowSingleCharMode = 1 << 1, // 0x0002
}
[Flags]
public enum ImGuiViewportFlags {
	ImGuiViewportFlags_None = 0, // 0x0000
	ImGuiViewportFlags_IsPlatformWindow = 1 << 0, // 0x0001
	ImGuiViewportFlags_IsPlatformMonitor = 1 << 1, // 0x0002
	ImGuiViewportFlags_OwnedByApp = 1 << 2, // 0x0004
	ImGuiViewportFlags_NoDecoration = 1 << 3, // 0x0008
	ImGuiViewportFlags_NoTaskBarIcon = 1 << 4, // 0x0010
	ImGuiViewportFlags_NoFocusOnAppearing = 1 << 5, // 0x0020
	ImGuiViewportFlags_NoFocusOnClick = 1 << 6, // 0x0040
	ImGuiViewportFlags_NoInputs = 1 << 7, // 0x0080
	ImGuiViewportFlags_NoRendererClear = 1 << 8, // 0x0100
	ImGuiViewportFlags_NoAutoMerge = 1 << 9, // 0x0200
	ImGuiViewportFlags_TopMost = 1 << 10, // 0x0400
	ImGuiViewportFlags_CanHostOtherWindows = 1 << 11, // 0x0800
	ImGuiViewportFlags_IsMinimized = 1 << 12, // 0x1000
	ImGuiViewportFlags_IsFocused = 1 << 13, // 0x2000
}
[Flags]
public enum ImGuiTabBarFlags {
	ImGuiTabBarFlags_None = 0, // 0x0000
	ImGuiTabBarFlags_Reorderable = 1 << 0, // 0x0001
	ImGuiTabBarFlags_AutoSelectNewTabs = 1 << 1, // 0x0002
	ImGuiTabBarFlags_TabListPopupButton = 1 << 2, // 0x0004
	ImGuiTabBarFlags_NoCloseWithMiddleMouseButton = 1 << 3, // 0x0008
	ImGuiTabBarFlags_NoTabListScrollingButtons = 1 << 4, // 0x0010
	ImGuiTabBarFlags_NoTooltip = 1 << 5, // 0x0020
	ImGuiTabBarFlags_DrawSelectedOverline = 1 << 6, // 0x0040
	ImGuiTabBarFlags_FittingPolicyResizeDown = 1 << 7, // 0x0080
	ImGuiTabBarFlags_FittingPolicyScroll = 1 << 8, // 0x0100
	ImGuiTabBarFlags_FittingPolicyMask_ = 384, // 0x0180
	ImGuiTabBarFlags_FittingPolicyDefault_ = 1 << 7, // 0x0080
}
[Flags]
public enum ImGuiSeparatorFlags {
	ImGuiSeparatorFlags_None = 0, // 0x0000
	ImGuiSeparatorFlags_Horizontal = 1 << 0, // 0x0001
	ImGuiSeparatorFlags_Vertical = 1 << 1, // 0x0002
	ImGuiSeparatorFlags_SpanAllColumns = 1 << 2, // 0x0004
}
[Flags]
public enum ImGuiPopupFlags {
	ImGuiPopupFlags_None = 0, // 0x0000
	ImGuiPopupFlags_MouseButtonLeft = 0, // 0x0000
	ImGuiPopupFlags_MouseButtonRight = 1 << 0, // 0x0001
	ImGuiPopupFlags_MouseButtonMiddle = 1 << 1, // 0x0002
	ImGuiPopupFlags_MouseButtonMask_ = 31, // 0x001F
	ImGuiPopupFlags_MouseButtonDefault_ = 1 << 0, // 0x0001
	ImGuiPopupFlags_NoReopen = 1 << 5, // 0x0020
	ImGuiPopupFlags_NoOpenOverExistingPopup = 1 << 7, // 0x0080
	ImGuiPopupFlags_NoOpenOverItems = 1 << 8, // 0x0100
	ImGuiPopupFlags_AnyPopupId = 1 << 10, // 0x0400
	ImGuiPopupFlags_AnyPopupLevel = 1 << 11, // 0x0800
	ImGuiPopupFlags_AnyPopup = 3072, // 0x0C00
}
public enum ImGuiAxis {
	ImGuiAxis_None = -1, // 0xFF
	ImGuiAxis_X = 0, // 0x0000
	ImGuiAxis_Y = 1 << 0, // 0x0001
}
[Flags]
public enum ImGuiTextFlags {
	ImGuiTextFlags_None = 0, // 0x0000
	ImGuiTextFlags_NoWidthForLargeClippedText = 1 << 0, // 0x0001
}
[Flags]
public enum ImGuiItemStatusFlags {
	ImGuiItemStatusFlags_None = 0, // 0x0000
	ImGuiItemStatusFlags_HoveredRect = 1 << 0, // 0x0001
	ImGuiItemStatusFlags_HasDisplayRect = 1 << 1, // 0x0002
	ImGuiItemStatusFlags_Edited = 1 << 2, // 0x0004
	ImGuiItemStatusFlags_ToggledSelection = 1 << 3, // 0x0008
	ImGuiItemStatusFlags_ToggledOpen = 1 << 4, // 0x0010
	ImGuiItemStatusFlags_HasDeactivated = 1 << 5, // 0x0020
	ImGuiItemStatusFlags_Deactivated = 1 << 6, // 0x0040
	ImGuiItemStatusFlags_HoveredWindow = 1 << 7, // 0x0080
	ImGuiItemStatusFlags_Visible = 1 << 8, // 0x0100
	ImGuiItemStatusFlags_HasClipRect = 1 << 9, // 0x0200
	ImGuiItemStatusFlags_HasShortcut = 1 << 10, // 0x0400
}
[Flags]
public enum ImDrawListFlags {
	ImDrawListFlags_None = 0, // 0x0000
	ImDrawListFlags_AntiAliasedLines = 1 << 0, // 0x0001
	ImDrawListFlags_AntiAliasedLinesUseTex = 1 << 1, // 0x0002
	ImDrawListFlags_AntiAliasedFill = 1 << 2, // 0x0004
	ImDrawListFlags_AllowVtxOffset = 1 << 3, // 0x0008
}
[Flags]
public enum ImGuiHoveredFlags {
	ImGuiHoveredFlags_None = 0, // 0x0000
	ImGuiHoveredFlags_ChildWindows = 1 << 0, // 0x0001
	ImGuiHoveredFlags_RootWindow = 1 << 1, // 0x0002
	ImGuiHoveredFlags_AnyWindow = 1 << 2, // 0x0004
	ImGuiHoveredFlags_NoPopupHierarchy = 1 << 3, // 0x0008
	ImGuiHoveredFlags_DockHierarchy = 1 << 4, // 0x0010
	ImGuiHoveredFlags_AllowWhenBlockedByPopup = 1 << 5, // 0x0020
	ImGuiHoveredFlags_AllowWhenBlockedByActiveItem = 1 << 7, // 0x0080
	ImGuiHoveredFlags_AllowWhenOverlappedByItem = 1 << 8, // 0x0100
	ImGuiHoveredFlags_AllowWhenOverlappedByWindow = 1 << 9, // 0x0200
	ImGuiHoveredFlags_AllowWhenDisabled = 1 << 10, // 0x0400
	ImGuiHoveredFlags_NoNavOverride = 1 << 11, // 0x0800
	ImGuiHoveredFlags_AllowWhenOverlapped = 768, // 0x0300
	ImGuiHoveredFlags_RectOnly = 928, // 0x03A0
	ImGuiHoveredFlags_RootAndChildWindows = 3, // 0x0003
	ImGuiHoveredFlags_ForTooltip = 1 << 12, // 0x1000
	ImGuiHoveredFlags_Stationary = 1 << 13, // 0x2000
	ImGuiHoveredFlags_DelayNone = 1 << 14, // 0x4000
	ImGuiHoveredFlags_DelayShort = 1 << 15, // 0x8000
	ImGuiHoveredFlags_DelayNormal = 1 << 16, // 0x00010000
	ImGuiHoveredFlags_NoSharedDelay = 1 << 17, // 0x00020000
}
public enum ImGuiSelectionRequestType {
	ImGuiSelectionRequestType_None = 0, // 0x0000
	ImGuiSelectionRequestType_SetAll = 1 << 0, // 0x0001
	ImGuiSelectionRequestType_SetRange = 1 << 1, // 0x0002
}
[Flags]
public enum ImGuiActivateFlags {
	ImGuiActivateFlags_None = 0, // 0x0000
	ImGuiActivateFlags_PreferInput = 1 << 0, // 0x0001
	ImGuiActivateFlags_PreferTweak = 1 << 1, // 0x0002
	ImGuiActivateFlags_TryToPreserveState = 1 << 2, // 0x0004
	ImGuiActivateFlags_FromTabbing = 1 << 3, // 0x0008
	ImGuiActivateFlags_FromShortcut = 1 << 4, // 0x0010
}
[Flags]
public enum ImGuiLogFlags {
	ImGuiLogFlags_None = 0, // 0x0000
	ImGuiLogFlags_OutputTTY = 1 << 0, // 0x0001
	ImGuiLogFlags_OutputFile = 1 << 1, // 0x0002
	ImGuiLogFlags_OutputBuffer = 1 << 2, // 0x0004
	ImGuiLogFlags_OutputClipboard = 1 << 3, // 0x0008
	ImGuiLogFlags_OutputMask_ = 15, // 0x000F
}
public enum ImGuiPopupPositionPolicy {
	ImGuiPopupPositionPolicy_Default = 0, // 0x0000
	ImGuiPopupPositionPolicy_ComboBox = 1 << 0, // 0x0001
	ImGuiPopupPositionPolicy_Tooltip = 1 << 1, // 0x0002
}
[Flags]
public enum ImGuiInputFlags {
	ImGuiInputFlags_None = 0, // 0x0000
	ImGuiInputFlags_Repeat = 1 << 0, // 0x0001
	ImGuiInputFlags_RouteActive = 1 << 10, // 0x0400
	ImGuiInputFlags_RouteFocused = 1 << 11, // 0x0800
	ImGuiInputFlags_RouteGlobal = 1 << 12, // 0x1000
	ImGuiInputFlags_RouteAlways = 1 << 13, // 0x2000
	ImGuiInputFlags_RouteOverFocused = 1 << 14, // 0x4000
	ImGuiInputFlags_RouteOverActive = 1 << 15, // 0x8000
	ImGuiInputFlags_RouteUnlessBgFocused = 1 << 16, // 0x00010000
	ImGuiInputFlags_RouteFromRootWindow = 1 << 17, // 0x00020000
	ImGuiInputFlags_Tooltip = 1 << 18, // 0x00040000
}
public enum ImGuiDockRequestType {
	ImGuiDockRequestType_None = 0, // 0x0000
	ImGuiDockRequestType_Dock = 1 << 0, // 0x0001
	ImGuiDockRequestType_Undock = 1 << 1, // 0x0002
	ImGuiDockRequestType_Split = 3, // 0x0003
}
[Flags]
public enum ImGuiDockNodeFlags {
	ImGuiDockNodeFlags_None = 0, // 0x0000
	ImGuiDockNodeFlags_KeepAliveOnly = 1 << 0, // 0x0001
	ImGuiDockNodeFlags_NoDockingOverCentralNode = 1 << 2, // 0x0004
	ImGuiDockNodeFlags_PassthruCentralNode = 1 << 3, // 0x0008
	ImGuiDockNodeFlags_NoDockingSplit = 1 << 4, // 0x0010
	ImGuiDockNodeFlags_NoResize = 1 << 5, // 0x0020
	ImGuiDockNodeFlags_AutoHideTabBar = 1 << 6, // 0x0040
	ImGuiDockNodeFlags_NoUndocking = 1 << 7, // 0x0080
}
[Flags]
public enum ImGuiFocusedFlags {
	ImGuiFocusedFlags_None = 0, // 0x0000
	ImGuiFocusedFlags_ChildWindows = 1 << 0, // 0x0001
	ImGuiFocusedFlags_RootWindow = 1 << 1, // 0x0002
	ImGuiFocusedFlags_AnyWindow = 1 << 2, // 0x0004
	ImGuiFocusedFlags_NoPopupHierarchy = 1 << 3, // 0x0008
	ImGuiFocusedFlags_DockHierarchy = 1 << 4, // 0x0010
	ImGuiFocusedFlags_RootAndChildWindows = 3, // 0x0003
}
public enum ImGuiDockNodeState {
	ImGuiDockNodeState_Unknown = 0, // 0x0000
	ImGuiDockNodeState_HostWindowHiddenBecauseSingleWindow = 1 << 0, // 0x0001
	ImGuiDockNodeState_HostWindowHiddenBecauseWindowsAreResizing = 1 << 1, // 0x0002
	ImGuiDockNodeState_HostWindowVisible = 3, // 0x0003
}
[Flags]
public enum ImGuiNavRenderCursorFlags {
	ImGuiNavRenderCursorFlags_None = 0, // 0x0000
	ImGuiNavRenderCursorFlags_Compact = 1 << 1, // 0x0002
	ImGuiNavRenderCursorFlags_AlwaysDraw = 1 << 2, // 0x0004
	ImGuiNavRenderCursorFlags_NoRounding = 1 << 3, // 0x0008
}
[Flags]
public enum ImGuiFocusRequestFlags {
	ImGuiFocusRequestFlags_None = 0, // 0x0000
	ImGuiFocusRequestFlags_RestoreFocusedChild = 1 << 0, // 0x0001
	ImGuiFocusRequestFlags_UnlessBelowModal = 1 << 1, // 0x0002
}
public enum ImGuiInputEventType {
	ImGuiInputEventType_None = 0, // 0x0000
	ImGuiInputEventType_MousePos = 1 << 0, // 0x0001
	ImGuiInputEventType_MouseWheel = 1 << 1, // 0x0002
	ImGuiInputEventType_MouseButton = 3, // 0x0003
	ImGuiInputEventType_MouseViewport = 1 << 2, // 0x0004
	ImGuiInputEventType_Key = 5, // 0x0005
	ImGuiInputEventType_Text = 6, // 0x0006
	ImGuiInputEventType_Focus = 7, // 0x0007
	ImGuiInputEventType_COUNT = 1 << 3, // 0x0008
}
public enum ImGuiNavLayer {
	ImGuiNavLayer_Main = 0, // 0x0000
	ImGuiNavLayer_Menu = 1 << 0, // 0x0001
	ImGuiNavLayer_COUNT = 1 << 1, // 0x0002
}
public enum ImGuiDataAuthority {
	ImGuiDataAuthority_Auto = 0, // 0x0000
	ImGuiDataAuthority_DockNode = 1 << 0, // 0x0001
	ImGuiDataAuthority_Window = 1 << 1, // 0x0002
}
public enum ImGuiLayoutType {
	ImGuiLayoutType_Horizontal = 0, // 0x0000
	ImGuiLayoutType_Vertical = 1 << 0, // 0x0001
}
[Flags]
public enum ImGuiTooltipFlags {
	ImGuiTooltipFlags_None = 0, // 0x0000
	ImGuiTooltipFlags_OverridePrevious = 1 << 1, // 0x0002
}
public enum ImGuiWindowDockStyleCol {
	ImGuiWindowDockStyleCol_Text = 0, // 0x0000
	ImGuiWindowDockStyleCol_TabHovered = 1 << 0, // 0x0001
	ImGuiWindowDockStyleCol_TabFocused = 1 << 1, // 0x0002
	ImGuiWindowDockStyleCol_TabSelected = 3, // 0x0003
	ImGuiWindowDockStyleCol_TabSelectedOverline = 1 << 2, // 0x0004
	ImGuiWindowDockStyleCol_TabDimmed = 5, // 0x0005
	ImGuiWindowDockStyleCol_TabDimmedSelected = 6, // 0x0006
	ImGuiWindowDockStyleCol_TabDimmedSelectedOverline = 7, // 0x0007
	ImGuiWindowDockStyleCol_COUNT = 1 << 3, // 0x0008
}
[Flags]
public enum ImGuiWindowRefreshFlags {
	ImGuiWindowRefreshFlags_None = 0, // 0x0000
	ImGuiWindowRefreshFlags_TryToAvoidRefresh = 1 << 0, // 0x0001
	ImGuiWindowRefreshFlags_RefreshOnHover = 1 << 1, // 0x0002
	ImGuiWindowRefreshFlags_RefreshOnFocus = 1 << 2, // 0x0004
}
