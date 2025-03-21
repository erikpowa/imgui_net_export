[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImBitVector {
	[FieldOffset(0x0000)] public ImVector<uint> Storage;
}
[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImVector<T> where T : unmanaged {
	public int Size;
	public int Capacity;
	public T* Data;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x00A8)]
public unsafe partial struct ImDrawList {
	[FieldOffset(0x0000)] public ImVector<ImDrawCmd> CmdBuffer;
	[FieldOffset(0x000C)] public ImVector<ushort> IdxBuffer;
	[FieldOffset(0x0018)] public ImVector<ImDrawVert> VtxBuffer;
	[FieldOffset(0x0024)] public int Flags;
	[FieldOffset(0x0028)] public uint _VtxCurrentIdx;
	[FieldOffset(0x002C)] public ImDrawListSharedData* _Data;
	[FieldOffset(0x0030)] public ImDrawVert* _VtxWritePtr;
	[FieldOffset(0x0034)] public ushort* _IdxWritePtr;
	[FieldOffset(0x0038)] public ImVector<Vector2> _Path;
	[FieldOffset(0x0048)] public ImDrawCmdHeader _CmdHeader;
	[FieldOffset(0x0068)] public ImDrawListSplitter _Splitter;
	[FieldOffset(0x007C)] public ImVector<Vector4> _ClipRectStack;
	[FieldOffset(0x0088)] public ImVector<ulong> _TextureIdStack;
	[FieldOffset(0x0094)] public ImVector<byte> _CallbacksDataBuf;
	[FieldOffset(0x00A0)] public float _FringeScale;
	[FieldOffset(0x00A4)] public byte* _OwnerName;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0038)]
public unsafe partial struct ImDrawCmd {
	[FieldOffset(0x0000)] public Vector4 ClipRect;
	[FieldOffset(0x0010)] public ulong TextureId;
	[FieldOffset(0x0018)] public uint VtxOffset;
	[FieldOffset(0x001C)] public uint IdxOffset;
	[FieldOffset(0x0020)] public uint ElemCount;
	[FieldOffset(0x0024)] public void** UserCallback;
	[FieldOffset(0x0028)] public void* UserCallbackData;
	[FieldOffset(0x002C)] public int UserCallbackDataSize;
	[FieldOffset(0x0030)] public int UserCallbackDataOffset;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0014)]
public unsafe partial struct ImDrawVert {
	[FieldOffset(0x0000)] public Vector2 pos;
	[FieldOffset(0x0008)] public Vector2 uv;
	[FieldOffset(0x0010)] public uint col;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0208)]
public unsafe partial struct ImDrawListSharedData {
	[FieldOffset(0x0000)] public Vector2 TexUvWhitePixel;
	[FieldOffset(0x0008)] public Vector4* TexUvLines;
	[FieldOffset(0x000C)] public ImFont* Font;
	[FieldOffset(0x0010)] public float FontSize;
	[FieldOffset(0x0014)] public float FontScale;
	[FieldOffset(0x0018)] public float CurveTessellationTol;
	[FieldOffset(0x001C)] public float CircleSegmentMaxError;
	[FieldOffset(0x0020)] public float InitialFringeScale;
	[FieldOffset(0x0024)] public int InitialFlags;
	[FieldOffset(0x0028)] public Vector4 ClipRectFullscreen;
	[FieldOffset(0x0038)] public ImVector<Vector2> TempBuffer;
	[FieldOffset(0x0044)] public byte /* Vector2 [48] */ ArcFastVtx;
	[FieldOffset(0x01C4)] public float ArcFastRadiusCutoff;
	[FieldOffset(0x01C8)] public byte /* byte [64] */ CircleSegmentCounts;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x005C)]
public unsafe partial struct ImFont {
	[FieldOffset(0x0000)] public ImVector<float> IndexAdvanceX;
	[FieldOffset(0x000C)] public float FallbackAdvanceX;
	[FieldOffset(0x0010)] public float FontSize;
	[FieldOffset(0x0014)] public ImVector<ushort> IndexLookup;
	[FieldOffset(0x0020)] public ImVector<ImFontGlyph> Glyphs;
	[FieldOffset(0x002C)] public ImFontGlyph* FallbackGlyph;
	[FieldOffset(0x0030)] public ImFontAtlas* ContainerAtlas;
	[FieldOffset(0x0034)] public ImFontConfig* Sources;
	[FieldOffset(0x0038)] public short SourcesCount;
	[FieldOffset(0x003A)] public short EllipsisCharCount;
	[FieldOffset(0x003C)] public ushort EllipsisChar;
	[FieldOffset(0x003E)] public ushort FallbackChar;
	[FieldOffset(0x0040)] public float EllipsisWidth;
	[FieldOffset(0x0044)] public float EllipsisCharStep;
	[FieldOffset(0x0048)] public float Scale;
	[FieldOffset(0x004C)] public float Ascent;
	[FieldOffset(0x0050)] public float Descent;
	[FieldOffset(0x0054)] public int MetricsTotalSurface;
	[FieldOffset(0x0058)] public byte DirtyLookupTables;
	[FieldOffset(0x0059)] public byte /* byte [1] */ Used8kPagesMap;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0028)]
public unsafe partial struct ImFontGlyph {
	[FieldOffset(0x0000)] public uint Colored;
	[FieldOffset(0x0000)] public uint Visible;
	[FieldOffset(0x0000)] public uint Codepoint;
	[FieldOffset(0x0004)] public float AdvanceX;
	[FieldOffset(0x0008)] public float X0;
	[FieldOffset(0x000C)] public float Y0;
	[FieldOffset(0x0010)] public float X1;
	[FieldOffset(0x0014)] public float Y1;
	[FieldOffset(0x0018)] public float U0;
	[FieldOffset(0x001C)] public float V0;
	[FieldOffset(0x0020)] public float U1;
	[FieldOffset(0x0024)] public float V1;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0288)]
public unsafe partial struct ImFontAtlas {
	[FieldOffset(0x0000)] public int Flags;
	[FieldOffset(0x0008)] public ulong TexID;
	[FieldOffset(0x0010)] public int TexDesiredWidth;
	[FieldOffset(0x0014)] public int TexGlyphPadding;
	[FieldOffset(0x0018)] public void* UserData;
	[FieldOffset(0x001C)] public byte Locked;
	[FieldOffset(0x001D)] public byte TexReady;
	[FieldOffset(0x001E)] public byte TexPixelsUseColors;
	[FieldOffset(0x0020)] public byte* TexPixelsAlpha8;
	[FieldOffset(0x0024)] public uint* TexPixelsRGBA32;
	[FieldOffset(0x0028)] public int TexWidth;
	[FieldOffset(0x002C)] public int TexHeight;
	[FieldOffset(0x0030)] public Vector2 TexUvScale;
	[FieldOffset(0x0038)] public Vector2 TexUvWhitePixel;
	[FieldOffset(0x0040)] public ImVector<ImFont> Fonts;
	[FieldOffset(0x004C)] public ImVector<ImFontAtlasCustomRect> CustomRects;
	[FieldOffset(0x0058)] public ImVector<ImFontConfig> Sources;
	[FieldOffset(0x0064)] public byte /* Vector4 [33] */ TexUvLines;
	[FieldOffset(0x0274)] public ImFontBuilderIO* FontBuilderIO;
	[FieldOffset(0x0278)] public uint FontBuilderFlags;
	[FieldOffset(0x027C)] public int PackIdMouseCursors;
	[FieldOffset(0x0280)] public int PackIdLines;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x001C)]
public unsafe partial struct ImFontAtlasCustomRect {
	[FieldOffset(0x0000)] public ushort X;
	[FieldOffset(0x0002)] public ushort Y;
	[FieldOffset(0x0004)] public ushort Width;
	[FieldOffset(0x0006)] public ushort Height;
	[FieldOffset(0x0008)] public uint GlyphID;
	[FieldOffset(0x0008)] public uint GlyphColored;
	[FieldOffset(0x000C)] public float GlyphAdvanceX;
	[FieldOffset(0x0010)] public Vector2 GlyphOffset;
	[FieldOffset(0x0018)] public ImFont* Font;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0070)]
public unsafe partial struct ImFontConfig {
	[FieldOffset(0x0000)] public void* FontData;
	[FieldOffset(0x0004)] public int FontDataSize;
	[FieldOffset(0x0008)] public byte FontDataOwnedByAtlas;
	[FieldOffset(0x0009)] public byte MergeMode;
	[FieldOffset(0x000A)] public byte PixelSnapH;
	[FieldOffset(0x000C)] public int FontNo;
	[FieldOffset(0x0010)] public int OversampleH;
	[FieldOffset(0x0014)] public int OversampleV;
	[FieldOffset(0x0018)] public float SizePixels;
	[FieldOffset(0x001C)] public Vector2 GlyphOffset;
	[FieldOffset(0x0024)] public ushort* GlyphRanges;
	[FieldOffset(0x0028)] public float GlyphMinAdvanceX;
	[FieldOffset(0x002C)] public float GlyphMaxAdvanceX;
	[FieldOffset(0x0030)] public float GlyphExtraAdvanceX;
	[FieldOffset(0x0034)] public uint FontBuilderFlags;
	[FieldOffset(0x0038)] public float RasterizerMultiply;
	[FieldOffset(0x003C)] public float RasterizerDensity;
	[FieldOffset(0x0040)] public ushort EllipsisChar;
	[FieldOffset(0x0042)] public byte /* byte [40] */ Name;
	[FieldOffset(0x006C)] public ImFont* DstFont;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct ImFontBuilderIO {
	[FieldOffset(0x0000)] public void** FontBuilder_Build;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0020)]
public unsafe partial struct ImDrawCmdHeader {
	[FieldOffset(0x0000)] public Vector4 ClipRect;
	[FieldOffset(0x0010)] public ulong TextureId;
	[FieldOffset(0x0018)] public uint VtxOffset;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0014)]
public unsafe partial struct ImDrawListSplitter {
	[FieldOffset(0x0000)] public int _Current;
	[FieldOffset(0x0004)] public int _Count;
	[FieldOffset(0x0008)] public ImVector<ImDrawChannel> _Channels;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0018)]
public unsafe partial struct ImDrawChannel {
	[FieldOffset(0x0000)] public ImVector<ImDrawCmd> _CmdBuffer;
	[FieldOffset(0x000C)] public ImVector<ushort> _IdxBuffer;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0030)]
public unsafe partial struct ImGuiComboPreviewData {
	[FieldOffset(0x0000)] public ImRect PreviewRect;
	[FieldOffset(0x0010)] public Vector2 BackupCursorPos;
	[FieldOffset(0x0018)] public Vector2 BackupCursorMaxPos;
	[FieldOffset(0x0020)] public Vector2 BackupCursorPosPrevLine;
	[FieldOffset(0x0028)] public float BackupPrevLineTextBaseOffset;
	[FieldOffset(0x002C)] public int BackupLayout;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImRect {
	[FieldOffset(0x0000)] public Vector2 Min;
	[FieldOffset(0x0008)] public Vector2 Max;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x00AC)]
public unsafe partial struct ImGuiDockNode {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int SharedFlags;
	[FieldOffset(0x0008)] public int LocalFlags;
	[FieldOffset(0x000C)] public int LocalFlagsInWindows;
	[FieldOffset(0x0010)] public int MergedFlags;
	[FieldOffset(0x0014)] public ImGuiDockNodeState State;
	[FieldOffset(0x0018)] public ImGuiDockNode* ParentNode;
	[FieldOffset(0x001C)] public byte /* ImGuiDockNode* [2] */ ChildNodes;
	[FieldOffset(0x0024)] public ImVector<ImGuiWindow> Windows;
	[FieldOffset(0x0030)] public ImGuiTabBar* TabBar;
	[FieldOffset(0x0034)] public Vector2 Pos;
	[FieldOffset(0x003C)] public Vector2 Size;
	[FieldOffset(0x0044)] public Vector2 SizeRef;
	[FieldOffset(0x004C)] public ImGuiAxis SplitAxis;
	[FieldOffset(0x0050)] public ImGuiWindowClass WindowClass;
	[FieldOffset(0x0070)] public uint LastBgColor;
	[FieldOffset(0x0074)] public ImGuiWindow* HostWindow;
	[FieldOffset(0x0078)] public ImGuiWindow* VisibleWindow;
	[FieldOffset(0x007C)] public ImGuiDockNode* CentralNode;
	[FieldOffset(0x0080)] public ImGuiDockNode* OnlyNodeWithWindows;
	[FieldOffset(0x0084)] public int CountNodeWithWindows;
	[FieldOffset(0x0088)] public int LastFrameAlive;
	[FieldOffset(0x008C)] public int LastFrameActive;
	[FieldOffset(0x0090)] public int LastFrameFocused;
	[FieldOffset(0x0094)] public uint LastFocusedNodeId;
	[FieldOffset(0x0098)] public uint SelectedTabId;
	[FieldOffset(0x009C)] public uint WantCloseTabId;
	[FieldOffset(0x00A0)] public uint RefViewportId;
	[FieldOffset(0x00A4)] public int AuthorityForPos;
	[FieldOffset(0x00A4)] public int AuthorityForSize;
	[FieldOffset(0x00A4)] public int AuthorityForViewport;
	[FieldOffset(0x00A8)] public byte IsVisible;
	[FieldOffset(0x00A8)] public byte IsFocused;
	[FieldOffset(0x00A8)] public byte IsBgDrawnThisFrame;
	[FieldOffset(0x00A8)] public byte HasCloseButton;
	[FieldOffset(0x00A8)] public byte HasWindowMenuButton;
	[FieldOffset(0x00A8)] public byte HasCentralNodeChild;
	[FieldOffset(0x00A8)] public byte WantCloseAll;
	[FieldOffset(0x00A8)] public byte WantLockSizeOnce;
	[FieldOffset(0x00A9)] public byte WantMouseMove;
	[FieldOffset(0x00A9)] public byte WantHiddenTabBarUpdate;
	[FieldOffset(0x00A9)] public byte WantHiddenTabBarToggle;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0428)]
public unsafe partial struct ImGuiWindow {
	[FieldOffset(0x0000)] public ImGuiContext* Ctx;
	[FieldOffset(0x0004)] public byte* Name;
	[FieldOffset(0x0008)] public uint ID;
	[FieldOffset(0x000C)] public int Flags;
	[FieldOffset(0x0010)] public int FlagsPreviousFrame;
	[FieldOffset(0x0014)] public int ChildFlags;
	[FieldOffset(0x0018)] public ImGuiWindowClass WindowClass;
	[FieldOffset(0x0038)] public ImGuiViewportP* Viewport;
	[FieldOffset(0x003C)] public uint ViewportId;
	[FieldOffset(0x0040)] public Vector2 ViewportPos;
	[FieldOffset(0x0048)] public int ViewportAllowPlatformMonitorExtend;
	[FieldOffset(0x004C)] public Vector2 Pos;
	[FieldOffset(0x0054)] public Vector2 Size;
	[FieldOffset(0x005C)] public Vector2 SizeFull;
	[FieldOffset(0x0064)] public Vector2 ContentSize;
	[FieldOffset(0x006C)] public Vector2 ContentSizeIdeal;
	[FieldOffset(0x0074)] public Vector2 ContentSizeExplicit;
	[FieldOffset(0x007C)] public Vector2 WindowPadding;
	[FieldOffset(0x0084)] public float WindowRounding;
	[FieldOffset(0x0088)] public float WindowBorderSize;
	[FieldOffset(0x008C)] public float TitleBarHeight;
	[FieldOffset(0x0090)] public float MenuBarHeight;
	[FieldOffset(0x0094)] public float DecoOuterSizeX1;
	[FieldOffset(0x0098)] public float DecoOuterSizeY1;
	[FieldOffset(0x009C)] public float DecoOuterSizeX2;
	[FieldOffset(0x00A0)] public float DecoOuterSizeY2;
	[FieldOffset(0x00A4)] public float DecoInnerSizeX1;
	[FieldOffset(0x00A8)] public float DecoInnerSizeY1;
	[FieldOffset(0x00AC)] public int NameBufLen;
	[FieldOffset(0x00B0)] public uint MoveId;
	[FieldOffset(0x00B4)] public uint TabId;
	[FieldOffset(0x00B8)] public uint ChildId;
	[FieldOffset(0x00BC)] public uint PopupId;
	[FieldOffset(0x00C0)] public Vector2 Scroll;
	[FieldOffset(0x00C8)] public Vector2 ScrollMax;
	[FieldOffset(0x00D0)] public Vector2 ScrollTarget;
	[FieldOffset(0x00D8)] public Vector2 ScrollTargetCenterRatio;
	[FieldOffset(0x00E0)] public Vector2 ScrollTargetEdgeSnapDist;
	[FieldOffset(0x00E8)] public Vector2 ScrollbarSizes;
	[FieldOffset(0x00F0)] public byte ScrollbarX;
	[FieldOffset(0x00F1)] public byte ScrollbarY;
	[FieldOffset(0x00F2)] public byte ScrollbarXStabilizeEnabled;
	[FieldOffset(0x00F3)] public byte ScrollbarXStabilizeToggledHistory;
	[FieldOffset(0x00F4)] public byte ViewportOwned;
	[FieldOffset(0x00F5)] public byte Active;
	[FieldOffset(0x00F6)] public byte WasActive;
	[FieldOffset(0x00F7)] public byte WriteAccessed;
	[FieldOffset(0x00F8)] public byte Collapsed;
	[FieldOffset(0x00F9)] public byte WantCollapseToggle;
	[FieldOffset(0x00FA)] public byte SkipItems;
	[FieldOffset(0x00FB)] public byte SkipRefresh;
	[FieldOffset(0x00FC)] public byte Appearing;
	[FieldOffset(0x00FD)] public byte Hidden;
	[FieldOffset(0x00FE)] public byte IsFallbackWindow;
	[FieldOffset(0x00FF)] public byte IsExplicitChild;
	[FieldOffset(0x0100)] public byte HasCloseButton;
	[FieldOffset(0x0101)] public sbyte ResizeBorderHovered;
	[FieldOffset(0x0102)] public sbyte ResizeBorderHeld;
	[FieldOffset(0x0104)] public short BeginCount;
	[FieldOffset(0x0106)] public short BeginCountPreviousFrame;
	[FieldOffset(0x0108)] public short BeginOrderWithinParent;
	[FieldOffset(0x010A)] public short BeginOrderWithinContext;
	[FieldOffset(0x010C)] public short FocusOrder;
	[FieldOffset(0x010E)] public sbyte AutoFitFramesX;
	[FieldOffset(0x010F)] public sbyte AutoFitFramesY;
	[FieldOffset(0x0110)] public byte AutoFitOnlyGrows;
	[FieldOffset(0x0114)] public ImGuiDir AutoPosLastDirection;
	[FieldOffset(0x0118)] public sbyte HiddenFramesCanSkipItems;
	[FieldOffset(0x0119)] public sbyte HiddenFramesCannotSkipItems;
	[FieldOffset(0x011A)] public sbyte HiddenFramesForRenderOnly;
	[FieldOffset(0x011B)] public sbyte DisableInputsFrames;
	[FieldOffset(0x011C)] public int SetWindowPosAllowFlags;
	[FieldOffset(0x011C)] public int SetWindowSizeAllowFlags;
	[FieldOffset(0x011C)] public int SetWindowCollapsedAllowFlags;
	[FieldOffset(0x011C)] public int SetWindowDockAllowFlags;
	[FieldOffset(0x0120)] public Vector2 SetWindowPosVal;
	[FieldOffset(0x0128)] public Vector2 SetWindowPosPivot;
	[FieldOffset(0x0130)] public ImVector<uint> IDStack;
	[FieldOffset(0x013C)] public byte DC;
	[FieldOffset(0x022C)] public ImRect OuterRectClipped;
	[FieldOffset(0x023C)] public ImRect InnerRect;
	[FieldOffset(0x024C)] public ImRect InnerClipRect;
	[FieldOffset(0x025C)] public ImRect WorkRect;
	[FieldOffset(0x026C)] public ImRect ParentWorkRect;
	[FieldOffset(0x027C)] public ImRect ClipRect;
	[FieldOffset(0x028C)] public ImRect ContentRegionRect;
	[FieldOffset(0x029C)] public ImVec2ih HitTestHoleSize;
	[FieldOffset(0x02A0)] public ImVec2ih HitTestHoleOffset;
	[FieldOffset(0x02A4)] public int LastFrameActive;
	[FieldOffset(0x02A8)] public int LastFrameJustFocused;
	[FieldOffset(0x02AC)] public float LastTimeActive;
	[FieldOffset(0x02B0)] public float ItemWidthDefault;
	[FieldOffset(0x02B4)] public ImGuiStorage StateStorage;
	[FieldOffset(0x02C0)] public ImVector<ImGuiOldColumns> ColumnsStorage;
	[FieldOffset(0x02CC)] public float FontWindowScale;
	[FieldOffset(0x02D0)] public float FontWindowScaleParents;
	[FieldOffset(0x02D4)] public float FontDpiScale;
	[FieldOffset(0x02D8)] public float FontRefSize;
	[FieldOffset(0x02DC)] public int SettingsOffset;
	[FieldOffset(0x02E0)] public ImDrawList* DrawList;
	[FieldOffset(0x02E8)] public ImDrawList DrawListInst;
	[FieldOffset(0x0390)] public ImGuiWindow* ParentWindow;
	[FieldOffset(0x0394)] public ImGuiWindow* ParentWindowInBeginStack;
	[FieldOffset(0x0398)] public ImGuiWindow* RootWindow;
	[FieldOffset(0x039C)] public ImGuiWindow* RootWindowPopupTree;
	[FieldOffset(0x03A0)] public ImGuiWindow* RootWindowDockTree;
	[FieldOffset(0x03A4)] public ImGuiWindow* RootWindowForTitleBarHighlight;
	[FieldOffset(0x03A8)] public ImGuiWindow* RootWindowForNav;
	[FieldOffset(0x03AC)] public ImGuiWindow* ParentWindowForFocusRoute;
	[FieldOffset(0x03B0)] public ImGuiWindow* NavLastChildNavWindow;
	[FieldOffset(0x03B4)] public byte /* uint [2] */ NavLastIds;
	[FieldOffset(0x03BC)] public byte /* ImRect [2] */ NavRectRel;
	[FieldOffset(0x03DC)] public byte /* Vector2 [2] */ NavPreferredScoringPosRel;
	[FieldOffset(0x03EC)] public uint NavRootFocusScopeId;
	[FieldOffset(0x03F0)] public int MemoryDrawListIdxCapacity;
	[FieldOffset(0x03F4)] public int MemoryDrawListVtxCapacity;
	[FieldOffset(0x03F8)] public byte MemoryCompacted;
	[FieldOffset(0x03F9)] public byte DockIsActive;
	[FieldOffset(0x03F9)] public byte DockNodeIsVisible;
	[FieldOffset(0x03F9)] public byte DockTabIsVisible;
	[FieldOffset(0x03F9)] public byte DockTabWantClose;
	[FieldOffset(0x03FA)] public short DockOrder;
	[FieldOffset(0x03FC)] public ImGuiWindowDockStyle DockStyle;
	[FieldOffset(0x041C)] public ImGuiDockNode* DockNode;
	[FieldOffset(0x0420)] public ImGuiDockNode* DockNodeAsHost;
	[FieldOffset(0x0424)] public uint DockId;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x28A0)]
public unsafe partial struct ImGuiContext {
	[FieldOffset(0x0000)] public byte Initialized;
	[FieldOffset(0x0001)] public byte FontAtlasOwnedByContext;
	[FieldOffset(0x0008)] public ImGuiIO IO;
	[FieldOffset(0x0BD0)] public ImGuiPlatformIO PlatformIO;
	[FieldOffset(0x0C6C)] public ImGuiStyle Style;
	[FieldOffset(0x1130)] public int ConfigFlagsCurrFrame;
	[FieldOffset(0x1134)] public int ConfigFlagsLastFrame;
	[FieldOffset(0x1138)] public ImFont* Font;
	[FieldOffset(0x113C)] public float FontSize;
	[FieldOffset(0x1140)] public float FontBaseSize;
	[FieldOffset(0x1144)] public float FontScale;
	[FieldOffset(0x1148)] public float CurrentDpiScale;
	[FieldOffset(0x114C)] public ImDrawListSharedData DrawListSharedData;
	[FieldOffset(0x1358)] public double Time;
	[FieldOffset(0x1360)] public int FrameCount;
	[FieldOffset(0x1364)] public int FrameCountEnded;
	[FieldOffset(0x1368)] public int FrameCountPlatformEnded;
	[FieldOffset(0x136C)] public int FrameCountRendered;
	[FieldOffset(0x1370)] public uint WithinEndChildID;
	[FieldOffset(0x1374)] public byte WithinFrameScope;
	[FieldOffset(0x1375)] public byte WithinFrameScopeWithImplicitWindow;
	[FieldOffset(0x1376)] public byte GcCompactAll;
	[FieldOffset(0x1377)] public byte TestEngineHookItems;
	[FieldOffset(0x1378)] public void* TestEngine;
	[FieldOffset(0x137C)] public byte /* byte [16] */ ContextName;
	[FieldOffset(0x138C)] public ImVector<ImGuiInputEvent> InputEventsQueue;
	[FieldOffset(0x1398)] public ImVector<ImGuiInputEvent> InputEventsTrail;
	[FieldOffset(0x13A4)] public ImGuiMouseSource InputEventsNextMouseSource;
	[FieldOffset(0x13A8)] public uint InputEventsNextEventId;
	[FieldOffset(0x13AC)] public ImVector<ImGuiWindow> Windows;
	[FieldOffset(0x13B8)] public ImVector<ImGuiWindow> WindowsFocusOrder;
	[FieldOffset(0x13C4)] public ImVector<ImGuiWindow> WindowsTempSortBuffer;
	[FieldOffset(0x13D0)] public ImVector<ImGuiWindowStackData> CurrentWindowStack;
	[FieldOffset(0x13DC)] public ImGuiStorage WindowsById;
	[FieldOffset(0x13E8)] public int WindowsActiveCount;
	[FieldOffset(0x13EC)] public float WindowsBorderHoverPadding;
	[FieldOffset(0x13F0)] public uint DebugBreakInWindow;
	[FieldOffset(0x13F4)] public ImGuiWindow* CurrentWindow;
	[FieldOffset(0x13F8)] public ImGuiWindow* HoveredWindow;
	[FieldOffset(0x13FC)] public ImGuiWindow* HoveredWindowUnderMovingWindow;
	[FieldOffset(0x1400)] public ImGuiWindow* HoveredWindowBeforeClear;
	[FieldOffset(0x1404)] public ImGuiWindow* MovingWindow;
	[FieldOffset(0x1408)] public ImGuiWindow* WheelingWindow;
	[FieldOffset(0x140C)] public Vector2 WheelingWindowRefMousePos;
	[FieldOffset(0x1414)] public int WheelingWindowStartFrame;
	[FieldOffset(0x1418)] public int WheelingWindowScrolledFrame;
	[FieldOffset(0x141C)] public float WheelingWindowReleaseTimer;
	[FieldOffset(0x1420)] public Vector2 WheelingWindowWheelRemainder;
	[FieldOffset(0x1428)] public Vector2 WheelingAxisAvg;
	[FieldOffset(0x1430)] public uint DebugDrawIdConflicts;
	[FieldOffset(0x1434)] public uint DebugHookIdInfo;
	[FieldOffset(0x1438)] public uint HoveredId;
	[FieldOffset(0x143C)] public uint HoveredIdPreviousFrame;
	[FieldOffset(0x1440)] public int HoveredIdPreviousFrameItemCount;
	[FieldOffset(0x1444)] public float HoveredIdTimer;
	[FieldOffset(0x1448)] public float HoveredIdNotActiveTimer;
	[FieldOffset(0x144C)] public byte HoveredIdAllowOverlap;
	[FieldOffset(0x144D)] public byte HoveredIdIsDisabled;
	[FieldOffset(0x144E)] public byte ItemUnclipByLog;
	[FieldOffset(0x1450)] public uint ActiveId;
	[FieldOffset(0x1454)] public uint ActiveIdIsAlive;
	[FieldOffset(0x1458)] public float ActiveIdTimer;
	[FieldOffset(0x145C)] public byte ActiveIdIsJustActivated;
	[FieldOffset(0x145D)] public byte ActiveIdAllowOverlap;
	[FieldOffset(0x145E)] public byte ActiveIdNoClearOnFocusLoss;
	[FieldOffset(0x145F)] public byte ActiveIdHasBeenPressedBefore;
	[FieldOffset(0x1460)] public byte ActiveIdHasBeenEditedBefore;
	[FieldOffset(0x1461)] public byte ActiveIdHasBeenEditedThisFrame;
	[FieldOffset(0x1462)] public byte ActiveIdFromShortcut;
	[FieldOffset(0x1464)] public int ActiveIdMouseButton;
	[FieldOffset(0x1468)] public Vector2 ActiveIdClickOffset;
	[FieldOffset(0x1470)] public ImGuiWindow* ActiveIdWindow;
	[FieldOffset(0x1474)] public ImGuiInputSource ActiveIdSource;
	[FieldOffset(0x1478)] public uint ActiveIdPreviousFrame;
	[FieldOffset(0x147C)] public ImGuiDeactivatedItemData DeactivatedItemData;
	[FieldOffset(0x1488)] public ImGuiDataTypeStorage ActiveIdValueOnActivation;
	[FieldOffset(0x1490)] public uint LastActiveId;
	[FieldOffset(0x1494)] public float LastActiveIdTimer;
	[FieldOffset(0x1498)] public double LastKeyModsChangeTime;
	[FieldOffset(0x14A0)] public double LastKeyModsChangeFromNoneTime;
	[FieldOffset(0x14A8)] public double LastKeyboardKeyPressTime;
	[FieldOffset(0x14B0)] public ImBitArray_155__512_ KeysMayBeCharInput;
	[FieldOffset(0x14C4)] public byte /* ImGuiKeyOwnerData [155] */ KeysOwnerData;
	[FieldOffset(0x1C08)] public ImGuiKeyRoutingTable KeysRoutingTable;
	[FieldOffset(0x1D58)] public uint ActiveIdUsingNavDirMask;
	[FieldOffset(0x1D5C)] public byte ActiveIdUsingAllKeyboardKeys;
	[FieldOffset(0x1D60)] public int DebugBreakInShortcutRouting;
	[FieldOffset(0x1D64)] public uint CurrentFocusScopeId;
	[FieldOffset(0x1D68)] public int CurrentItemFlags;
	[FieldOffset(0x1D6C)] public uint DebugLocateId;
	[FieldOffset(0x1D70)] public ImGuiNextItemData NextItemData;
	[FieldOffset(0x1DA8)] public ImGuiLastItemData LastItemData;
	[FieldOffset(0x1DF8)] public ImGuiNextWindowData NextWindowData;
	[FieldOffset(0x1E90)] public byte DebugShowGroupRects;
	[FieldOffset(0x1E94)] public int DebugFlashStyleColorIdx;
	[FieldOffset(0x1E98)] public ImVector<ImGuiColorMod> ColorStack;
	[FieldOffset(0x1EA4)] public ImVector<ImGuiStyleMod> StyleVarStack;
	[FieldOffset(0x1EB0)] public ImVector<ImFont> FontStack;
	[FieldOffset(0x1EBC)] public ImVector<ImGuiFocusScopeData> FocusScopeStack;
	[FieldOffset(0x1EC8)] public ImVector<int> ItemFlagsStack;
	[FieldOffset(0x1ED4)] public ImVector<ImGuiGroupData> GroupStack;
	[FieldOffset(0x1EE0)] public ImVector<ImGuiPopupData> OpenPopupStack;
	[FieldOffset(0x1EEC)] public ImVector<ImGuiPopupData> BeginPopupStack;
	[FieldOffset(0x1EF8)] public ImVector<ImGuiTreeNodeStackData> TreeNodeStack;
	[FieldOffset(0x1F04)] public ImVector<ImGuiViewportP> Viewports;
	[FieldOffset(0x1F10)] public ImGuiViewportP* CurrentViewport;
	[FieldOffset(0x1F14)] public ImGuiViewportP* MouseViewport;
	[FieldOffset(0x1F18)] public ImGuiViewportP* MouseLastHoveredViewport;
	[FieldOffset(0x1F1C)] public uint PlatformLastFocusedViewportId;
	[FieldOffset(0x1F20)] public ImGuiPlatformMonitor FallbackMonitor;
	[FieldOffset(0x1F48)] public ImRect PlatformMonitorsFullWorkRect;
	[FieldOffset(0x1F58)] public int ViewportCreatedCount;
	[FieldOffset(0x1F5C)] public int PlatformWindowsCreatedCount;
	[FieldOffset(0x1F60)] public int ViewportFocusedStampCount;
	[FieldOffset(0x1F64)] public byte NavCursorVisible;
	[FieldOffset(0x1F65)] public byte NavHighlightItemUnderNav;
	[FieldOffset(0x1F66)] public byte NavMousePosDirty;
	[FieldOffset(0x1F67)] public byte NavIdIsAlive;
	[FieldOffset(0x1F68)] public uint NavId;
	[FieldOffset(0x1F6C)] public ImGuiWindow* NavWindow;
	[FieldOffset(0x1F70)] public uint NavFocusScopeId;
	[FieldOffset(0x1F74)] public ImGuiNavLayer NavLayer;
	[FieldOffset(0x1F78)] public uint NavActivateId;
	[FieldOffset(0x1F7C)] public uint NavActivateDownId;
	[FieldOffset(0x1F80)] public uint NavActivatePressedId;
	[FieldOffset(0x1F84)] public int NavActivateFlags;
	[FieldOffset(0x1F88)] public ImVector<ImGuiFocusScopeData> NavFocusRoute;
	[FieldOffset(0x1F94)] public uint NavHighlightActivatedId;
	[FieldOffset(0x1F98)] public float NavHighlightActivatedTimer;
	[FieldOffset(0x1F9C)] public uint NavNextActivateId;
	[FieldOffset(0x1FA0)] public int NavNextActivateFlags;
	[FieldOffset(0x1FA4)] public ImGuiInputSource NavInputSource;
	[FieldOffset(0x1FA8)] public long NavLastValidSelectionUserData;
	[FieldOffset(0x1FB0)] public sbyte NavCursorHideFrames;
	[FieldOffset(0x1FB1)] public byte NavAnyRequest;
	[FieldOffset(0x1FB2)] public byte NavInitRequest;
	[FieldOffset(0x1FB3)] public byte NavInitRequestFromMove;
	[FieldOffset(0x1FB8)] public ImGuiNavItemData NavInitResult;
	[FieldOffset(0x1FF0)] public byte NavMoveSubmitted;
	[FieldOffset(0x1FF1)] public byte NavMoveScoringItems;
	[FieldOffset(0x1FF2)] public byte NavMoveForwardToNextFrame;
	[FieldOffset(0x1FF4)] public int NavMoveFlags;
	[FieldOffset(0x1FF8)] public int NavMoveScrollFlags;
	[FieldOffset(0x1FFC)] public int NavMoveKeyMods;
	[FieldOffset(0x2000)] public ImGuiDir NavMoveDir;
	[FieldOffset(0x2004)] public ImGuiDir NavMoveDirForDebug;
	[FieldOffset(0x2008)] public ImGuiDir NavMoveClipDir;
	[FieldOffset(0x200C)] public ImRect NavScoringRect;
	[FieldOffset(0x201C)] public ImRect NavScoringNoClipRect;
	[FieldOffset(0x202C)] public int NavScoringDebugCount;
	[FieldOffset(0x2030)] public int NavTabbingDir;
	[FieldOffset(0x2034)] public int NavTabbingCounter;
	[FieldOffset(0x2038)] public ImGuiNavItemData NavMoveResultLocal;
	[FieldOffset(0x2070)] public ImGuiNavItemData NavMoveResultLocalVisible;
	[FieldOffset(0x20A8)] public ImGuiNavItemData NavMoveResultOther;
	[FieldOffset(0x20E0)] public ImGuiNavItemData NavTabbingResultFirst;
	[FieldOffset(0x2118)] public uint NavJustMovedFromFocusScopeId;
	[FieldOffset(0x211C)] public uint NavJustMovedToId;
	[FieldOffset(0x2120)] public uint NavJustMovedToFocusScopeId;
	[FieldOffset(0x2124)] public int NavJustMovedToKeyMods;
	[FieldOffset(0x2128)] public byte NavJustMovedToIsTabbing;
	[FieldOffset(0x2129)] public byte NavJustMovedToHasSelectionData;
	[FieldOffset(0x212C)] public int ConfigNavWindowingKeyNext;
	[FieldOffset(0x2130)] public int ConfigNavWindowingKeyPrev;
	[FieldOffset(0x2134)] public ImGuiWindow* NavWindowingTarget;
	[FieldOffset(0x2138)] public ImGuiWindow* NavWindowingTargetAnim;
	[FieldOffset(0x213C)] public ImGuiWindow* NavWindowingListWindow;
	[FieldOffset(0x2140)] public float NavWindowingTimer;
	[FieldOffset(0x2144)] public float NavWindowingHighlightAlpha;
	[FieldOffset(0x2148)] public byte NavWindowingToggleLayer;
	[FieldOffset(0x214C)] public ImGuiKey NavWindowingToggleKey;
	[FieldOffset(0x2150)] public Vector2 NavWindowingAccumDeltaPos;
	[FieldOffset(0x2158)] public Vector2 NavWindowingAccumDeltaSize;
	[FieldOffset(0x2160)] public float DimBgRatio;
	[FieldOffset(0x2164)] public byte DragDropActive;
	[FieldOffset(0x2165)] public byte DragDropWithinSource;
	[FieldOffset(0x2166)] public byte DragDropWithinTarget;
	[FieldOffset(0x2168)] public int DragDropSourceFlags;
	[FieldOffset(0x216C)] public int DragDropSourceFrameCount;
	[FieldOffset(0x2170)] public int DragDropMouseButton;
	[FieldOffset(0x2174)] public ImGuiPayload DragDropPayload;
	[FieldOffset(0x21AC)] public ImRect DragDropTargetRect;
	[FieldOffset(0x21BC)] public ImRect DragDropTargetClipRect;
	[FieldOffset(0x21CC)] public uint DragDropTargetId;
	[FieldOffset(0x21D0)] public int DragDropAcceptFlags;
	[FieldOffset(0x21D4)] public float DragDropAcceptIdCurrRectSurface;
	[FieldOffset(0x21D8)] public uint DragDropAcceptIdCurr;
	[FieldOffset(0x21DC)] public uint DragDropAcceptIdPrev;
	[FieldOffset(0x21E0)] public int DragDropAcceptFrameCount;
	[FieldOffset(0x21E4)] public uint DragDropHoldJustPressedId;
	[FieldOffset(0x21E8)] public ImVector<byte> DragDropPayloadBufHeap;
	[FieldOffset(0x21F4)] public byte /* byte [16] */ DragDropPayloadBufLocal;
	[FieldOffset(0x2204)] public int ClipperTempDataStacked;
	[FieldOffset(0x2208)] public ImVector<ImGuiListClipperData> ClipperTempData;
	[FieldOffset(0x2214)] public ImGuiTable* CurrentTable;
	[FieldOffset(0x2218)] public uint DebugBreakInTable;
	[FieldOffset(0x221C)] public int TablesTempDataStacked;
	[FieldOffset(0x2220)] public ImVector<ImGuiTableTempData> TablesTempData;
	[FieldOffset(0x222C)] public ImPool<ImGuiTable> Tables;
	[FieldOffset(0x224C)] public ImVector<float> TablesLastTimeActive;
	[FieldOffset(0x2258)] public ImVector<ImDrawChannel> DrawChannelsTempMergeBuffer;
	[FieldOffset(0x2264)] public ImGuiTabBar* CurrentTabBar;
	[FieldOffset(0x2268)] public ImPool<ImGuiTabBar> TabBars;
	[FieldOffset(0x2288)] public ImVector<ImGuiPtrOrIndex> CurrentTabBarStack;
	[FieldOffset(0x2294)] public ImVector<ImGuiShrinkWidthItem> ShrinkWidthBuffer;
	[FieldOffset(0x22A0)] public ImGuiBoxSelectState BoxSelectState;
	[FieldOffset(0x2300)] public ImGuiMultiSelectTempData* CurrentMultiSelect;
	[FieldOffset(0x2304)] public int MultiSelectTempDataStacked;
	[FieldOffset(0x2308)] public ImVector<ImGuiMultiSelectTempData> MultiSelectTempData;
	[FieldOffset(0x2314)] public ImPool<ImGuiMultiSelectState> MultiSelectStorage;
	[FieldOffset(0x2334)] public uint HoverItemDelayId;
	[FieldOffset(0x2338)] public uint HoverItemDelayIdPreviousFrame;
	[FieldOffset(0x233C)] public float HoverItemDelayTimer;
	[FieldOffset(0x2340)] public float HoverItemDelayClearTimer;
	[FieldOffset(0x2344)] public uint HoverItemUnlockedStationaryId;
	[FieldOffset(0x2348)] public uint HoverWindowUnlockedStationaryId;
	[FieldOffset(0x234C)] public int MouseCursor;
	[FieldOffset(0x2350)] public float MouseStationaryTimer;
	[FieldOffset(0x2354)] public Vector2 MouseLastValidPos;
	[FieldOffset(0x235C)] public ImGuiInputTextState InputTextState;
	[FieldOffset(0x23B4)] public ImGuiInputTextDeactivatedState InputTextDeactivatedState;
	[FieldOffset(0x23C4)] public ImFont InputTextPasswordFont;
	[FieldOffset(0x2420)] public uint TempInputId;
	[FieldOffset(0x2424)] public ImGuiDataTypeStorage DataTypeZeroValue;
	[FieldOffset(0x242C)] public int BeginMenuDepth;
	[FieldOffset(0x2430)] public int BeginComboDepth;
	[FieldOffset(0x2434)] public int ColorEditOptions;
	[FieldOffset(0x2438)] public uint ColorEditCurrentID;
	[FieldOffset(0x243C)] public uint ColorEditSavedID;
	[FieldOffset(0x2440)] public float ColorEditSavedHue;
	[FieldOffset(0x2444)] public float ColorEditSavedSat;
	[FieldOffset(0x2448)] public uint ColorEditSavedColor;
	[FieldOffset(0x244C)] public Vector4 ColorPickerRef;
	[FieldOffset(0x245C)] public ImGuiComboPreviewData ComboPreviewData;
	[FieldOffset(0x248C)] public ImRect WindowResizeBorderExpectedRect;
	[FieldOffset(0x249C)] public byte WindowResizeRelativeMode;
	[FieldOffset(0x249E)] public short ScrollbarSeekMode;
	[FieldOffset(0x24A0)] public float ScrollbarClickDeltaToGrabCenter;
	[FieldOffset(0x24A4)] public float SliderGrabClickOffset;
	[FieldOffset(0x24A8)] public float SliderCurrentAccum;
	[FieldOffset(0x24AC)] public byte SliderCurrentAccumDirty;
	[FieldOffset(0x24AD)] public byte DragCurrentAccumDirty;
	[FieldOffset(0x24B0)] public float DragCurrentAccum;
	[FieldOffset(0x24B4)] public float DragSpeedDefaultRatio;
	[FieldOffset(0x24B8)] public float DisabledAlphaBackup;
	[FieldOffset(0x24BC)] public short DisabledStackSize;
	[FieldOffset(0x24BE)] public short TooltipOverrideCount;
	[FieldOffset(0x24C0)] public ImGuiWindow* TooltipPreviousWindow;
	[FieldOffset(0x24C4)] public ImVector<char> ClipboardHandlerData;
	[FieldOffset(0x24D0)] public ImVector<uint> MenusIdSubmittedThisFrame;
	[FieldOffset(0x24DC)] public ImGuiTypingSelectState TypingSelectState;
	[FieldOffset(0x253C)] public ImGuiPlatformImeData PlatformImeData;
	[FieldOffset(0x254C)] public ImGuiPlatformImeData PlatformImeDataPrev;
	[FieldOffset(0x255C)] public uint PlatformImeViewport;
	[FieldOffset(0x2560)] public ImGuiDockContext DockContext;
	[FieldOffset(0x2588)] public void** DockNodeWindowMenuHandler;
	[FieldOffset(0x258C)] public byte SettingsLoaded;
	[FieldOffset(0x2590)] public float SettingsDirtyTimer;
	[FieldOffset(0x2594)] public ImGuiTextBuffer SettingsIniData;
	[FieldOffset(0x25A0)] public ImVector<ImGuiSettingsHandler> SettingsHandlers;
	[FieldOffset(0x25AC)] public ImChunkStream<ImGuiWindowSettings> SettingsWindows;
	[FieldOffset(0x25B8)] public ImChunkStream<ImGuiTableSettings> SettingsTables;
	[FieldOffset(0x25C4)] public ImVector<ImGuiContextHook> Hooks;
	[FieldOffset(0x25D0)] public uint HookIdNext;
	[FieldOffset(0x25D4)] public byte /* byte* [13] */ LocalizationTable;
	[FieldOffset(0x2608)] public byte LogEnabled;
	[FieldOffset(0x260C)] public int LogFlags;
	[FieldOffset(0x2610)] public ImGuiWindow* LogWindow;
	[FieldOffset(0x2614)] public _iobuf* LogFile;
	[FieldOffset(0x2618)] public ImGuiTextBuffer LogBuffer;
	[FieldOffset(0x2624)] public byte* LogNextPrefix;
	[FieldOffset(0x2628)] public byte* LogNextSuffix;
	[FieldOffset(0x262C)] public float LogLinePosY;
	[FieldOffset(0x2630)] public byte LogLineFirstItem;
	[FieldOffset(0x2634)] public int LogDepthRef;
	[FieldOffset(0x2638)] public int LogDepthToExpand;
	[FieldOffset(0x263C)] public int LogDepthToExpandDefault;
	[FieldOffset(0x2640)] public void** ErrorCallback;
	[FieldOffset(0x2644)] public void* ErrorCallbackUserData;
	[FieldOffset(0x2648)] public Vector2 ErrorTooltipLockedPos;
	[FieldOffset(0x2650)] public byte ErrorFirst;
	[FieldOffset(0x2654)] public int ErrorCountCurrentFrame;
	[FieldOffset(0x2658)] public ImGuiErrorRecoveryState StackSizesInNewFrame;
	[FieldOffset(0x2670)] public ImGuiErrorRecoveryState* StackSizesInBeginForCurrentWindow;
	[FieldOffset(0x2674)] public int DebugDrawIdConflictsCount;
	[FieldOffset(0x2678)] public int DebugLogFlags;
	[FieldOffset(0x267C)] public ImGuiTextBuffer DebugLogBuf;
	[FieldOffset(0x2688)] public ImGuiTextIndex DebugLogIndex;
	[FieldOffset(0x2698)] public int DebugLogSkippedErrors;
	[FieldOffset(0x269C)] public int DebugLogAutoDisableFlags;
	[FieldOffset(0x26A0)] public byte DebugLogAutoDisableFrames;
	[FieldOffset(0x26A1)] public byte DebugLocateFrames;
	[FieldOffset(0x26A2)] public byte DebugBreakInLocateId;
	[FieldOffset(0x26A4)] public int DebugBreakKeyChord;
	[FieldOffset(0x26A8)] public sbyte DebugBeginReturnValueCullDepth;
	[FieldOffset(0x26A9)] public byte DebugItemPickerActive;
	[FieldOffset(0x26AA)] public byte DebugItemPickerMouseButton;
	[FieldOffset(0x26AC)] public uint DebugItemPickerBreakId;
	[FieldOffset(0x26B0)] public float DebugFlashStyleColorTime;
	[FieldOffset(0x26B4)] public Vector4 DebugFlashStyleColorBackup;
	[FieldOffset(0x26C4)] public ImGuiMetricsConfig DebugMetricsConfig;
	[FieldOffset(0x26E0)] public ImGuiIDStackTool DebugIDStackTool;
	[FieldOffset(0x270C)] public ImGuiDebugAllocInfo DebugAllocInfo;
	[FieldOffset(0x2748)] public ImGuiDockNode* DebugHoveredDockNode;
	[FieldOffset(0x274C)] public byte /* float [60] */ FramerateSecPerFrame;
	[FieldOffset(0x283C)] public int FramerateSecPerFrameIdx;
	[FieldOffset(0x2840)] public int FramerateSecPerFrameCount;
	[FieldOffset(0x2844)] public float FramerateSecPerFrameAccum;
	[FieldOffset(0x2848)] public int WantCaptureMouseNextFrame;
	[FieldOffset(0x284C)] public int WantCaptureKeyboardNextFrame;
	[FieldOffset(0x2850)] public int WantTextInputNextFrame;
	[FieldOffset(0x2854)] public ImVector<char> TempBuffer;
	[FieldOffset(0x2860)] public byte /* byte [64] */ TempKeychordName;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0BC8)]
public unsafe partial struct ImGuiIO {
	[FieldOffset(0x0000)] public int ConfigFlags;
	[FieldOffset(0x0004)] public int BackendFlags;
	[FieldOffset(0x0008)] public Vector2 DisplaySize;
	[FieldOffset(0x0010)] public float DeltaTime;
	[FieldOffset(0x0014)] public float IniSavingRate;
	[FieldOffset(0x0018)] public byte* IniFilename;
	[FieldOffset(0x001C)] public byte* LogFilename;
	[FieldOffset(0x0020)] public void* UserData;
	[FieldOffset(0x0024)] public ImFontAtlas* Fonts;
	[FieldOffset(0x0028)] public float FontGlobalScale;
	[FieldOffset(0x002C)] public byte FontAllowUserScaling;
	[FieldOffset(0x0030)] public ImFont* FontDefault;
	[FieldOffset(0x0034)] public Vector2 DisplayFramebufferScale;
	[FieldOffset(0x003C)] public byte ConfigNavSwapGamepadButtons;
	[FieldOffset(0x003D)] public byte ConfigNavMoveSetMousePos;
	[FieldOffset(0x003E)] public byte ConfigNavCaptureKeyboard;
	[FieldOffset(0x003F)] public byte ConfigNavEscapeClearFocusItem;
	[FieldOffset(0x0040)] public byte ConfigNavEscapeClearFocusWindow;
	[FieldOffset(0x0041)] public byte ConfigNavCursorVisibleAuto;
	[FieldOffset(0x0042)] public byte ConfigNavCursorVisibleAlways;
	[FieldOffset(0x0043)] public byte ConfigDockingNoSplit;
	[FieldOffset(0x0044)] public byte ConfigDockingWithShift;
	[FieldOffset(0x0045)] public byte ConfigDockingAlwaysTabBar;
	[FieldOffset(0x0046)] public byte ConfigDockingTransparentPayload;
	[FieldOffset(0x0047)] public byte ConfigViewportsNoAutoMerge;
	[FieldOffset(0x0048)] public byte ConfigViewportsNoTaskBarIcon;
	[FieldOffset(0x0049)] public byte ConfigViewportsNoDecoration;
	[FieldOffset(0x004A)] public byte ConfigViewportsNoDefaultParent;
	[FieldOffset(0x004B)] public byte MouseDrawCursor;
	[FieldOffset(0x004C)] public byte ConfigMacOSXBehaviors;
	[FieldOffset(0x004D)] public byte ConfigInputTrickleEventQueue;
	[FieldOffset(0x004E)] public byte ConfigInputTextCursorBlink;
	[FieldOffset(0x004F)] public byte ConfigInputTextEnterKeepActive;
	[FieldOffset(0x0050)] public byte ConfigDragClickToInputText;
	[FieldOffset(0x0051)] public byte ConfigWindowsResizeFromEdges;
	[FieldOffset(0x0052)] public byte ConfigWindowsMoveFromTitleBarOnly;
	[FieldOffset(0x0053)] public byte ConfigWindowsCopyContentsWithCtrlC;
	[FieldOffset(0x0054)] public byte ConfigScrollbarScrollByPage;
	[FieldOffset(0x0058)] public float ConfigMemoryCompactTimer;
	[FieldOffset(0x005C)] public float MouseDoubleClickTime;
	[FieldOffset(0x0060)] public float MouseDoubleClickMaxDist;
	[FieldOffset(0x0064)] public float MouseDragThreshold;
	[FieldOffset(0x0068)] public float KeyRepeatDelay;
	[FieldOffset(0x006C)] public float KeyRepeatRate;
	[FieldOffset(0x0070)] public byte ConfigErrorRecovery;
	[FieldOffset(0x0071)] public byte ConfigErrorRecoveryEnableAssert;
	[FieldOffset(0x0072)] public byte ConfigErrorRecoveryEnableDebugLog;
	[FieldOffset(0x0073)] public byte ConfigErrorRecoveryEnableTooltip;
	[FieldOffset(0x0074)] public byte ConfigDebugIsDebuggerPresent;
	[FieldOffset(0x0075)] public byte ConfigDebugHighlightIdConflicts;
	[FieldOffset(0x0076)] public byte ConfigDebugHighlightIdConflictsShowItemPicker;
	[FieldOffset(0x0077)] public byte ConfigDebugBeginReturnValueOnce;
	[FieldOffset(0x0078)] public byte ConfigDebugBeginReturnValueLoop;
	[FieldOffset(0x0079)] public byte ConfigDebugIgnoreFocusLoss;
	[FieldOffset(0x007A)] public byte ConfigDebugIniSettings;
	[FieldOffset(0x007C)] public byte* BackendPlatformName;
	[FieldOffset(0x0080)] public byte* BackendRendererName;
	[FieldOffset(0x0084)] public void* BackendPlatformUserData;
	[FieldOffset(0x0088)] public void* BackendRendererUserData;
	[FieldOffset(0x008C)] public void* BackendLanguageUserData;
	[FieldOffset(0x0090)] public byte WantCaptureMouse;
	[FieldOffset(0x0091)] public byte WantCaptureKeyboard;
	[FieldOffset(0x0092)] public byte WantTextInput;
	[FieldOffset(0x0093)] public byte WantSetMousePos;
	[FieldOffset(0x0094)] public byte WantSaveIniSettings;
	[FieldOffset(0x0095)] public byte NavActive;
	[FieldOffset(0x0096)] public byte NavVisible;
	[FieldOffset(0x0098)] public float Framerate;
	[FieldOffset(0x009C)] public int MetricsRenderVertices;
	[FieldOffset(0x00A0)] public int MetricsRenderIndices;
	[FieldOffset(0x00A4)] public int MetricsRenderWindows;
	[FieldOffset(0x00A8)] public int MetricsActiveWindows;
	[FieldOffset(0x00AC)] public Vector2 MouseDelta;
	[FieldOffset(0x00B4)] public ImGuiContext* Ctx;
	[FieldOffset(0x00B8)] public Vector2 MousePos;
	[FieldOffset(0x00C0)] public byte /* byte [5] */ MouseDown;
	[FieldOffset(0x00C8)] public float MouseWheel;
	[FieldOffset(0x00CC)] public float MouseWheelH;
	[FieldOffset(0x00D0)] public ImGuiMouseSource MouseSource;
	[FieldOffset(0x00D4)] public uint MouseHoveredViewport;
	[FieldOffset(0x00D8)] public byte KeyCtrl;
	[FieldOffset(0x00D9)] public byte KeyShift;
	[FieldOffset(0x00DA)] public byte KeyAlt;
	[FieldOffset(0x00DB)] public byte KeySuper;
	[FieldOffset(0x00DC)] public int KeyMods;
	[FieldOffset(0x00E0)] public byte /* ImGuiKeyData [155] */ KeysData;
	[FieldOffset(0x0A90)] public byte WantCaptureMouseUnlessPopupClose;
	[FieldOffset(0x0A94)] public Vector2 MousePosPrev;
	[FieldOffset(0x0A9C)] public byte /* Vector2 [5] */ MouseClickedPos;
	[FieldOffset(0x0AC8)] public byte /* double [5] */ MouseClickedTime;
	[FieldOffset(0x0AF0)] public byte /* byte [5] */ MouseClicked;
	[FieldOffset(0x0AF5)] public byte /* byte [5] */ MouseDoubleClicked;
	[FieldOffset(0x0AFA)] public byte /* ushort [5] */ MouseClickedCount;
	[FieldOffset(0x0B04)] public byte /* ushort [5] */ MouseClickedLastCount;
	[FieldOffset(0x0B0E)] public byte /* byte [5] */ MouseReleased;
	[FieldOffset(0x0B18)] public byte /* double [5] */ MouseReleasedTime;
	[FieldOffset(0x0B40)] public byte /* byte [5] */ MouseDownOwned;
	[FieldOffset(0x0B45)] public byte /* byte [5] */ MouseDownOwnedUnlessPopupClose;
	[FieldOffset(0x0B4A)] public byte MouseWheelRequestAxisSwap;
	[FieldOffset(0x0B4B)] public byte MouseCtrlLeftAsRightClick;
	[FieldOffset(0x0B4C)] public byte /* float [5] */ MouseDownDuration;
	[FieldOffset(0x0B60)] public byte /* float [5] */ MouseDownDurationPrev;
	[FieldOffset(0x0B74)] public byte /* Vector2 [5] */ MouseDragMaxDistanceAbs;
	[FieldOffset(0x0B9C)] public byte /* float [5] */ MouseDragMaxDistanceSqr;
	[FieldOffset(0x0BB0)] public float PenPressure;
	[FieldOffset(0x0BB4)] public byte AppFocusLost;
	[FieldOffset(0x0BB5)] public byte AppAcceptingEvents;
	[FieldOffset(0x0BB6)] public ushort InputQueueSurrogate;
	[FieldOffset(0x0BB8)] public ImVector<ushort> InputQueueCharacters;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiKeyData {
	[FieldOffset(0x0000)] public byte Down;
	[FieldOffset(0x0004)] public float DownDuration;
	[FieldOffset(0x0008)] public float DownDurationPrev;
	[FieldOffset(0x000C)] public float AnalogValue;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x009C)]
public unsafe partial struct ImGuiPlatformIO {
	[FieldOffset(0x0000)] public void** Platform_GetClipboardTextFn;
	[FieldOffset(0x0004)] public void** Platform_SetClipboardTextFn;
	[FieldOffset(0x0008)] public void* Platform_ClipboardUserData;
	[FieldOffset(0x000C)] public void** Platform_OpenInShellFn;
	[FieldOffset(0x0010)] public void* Platform_OpenInShellUserData;
	[FieldOffset(0x0014)] public void** Platform_SetImeDataFn;
	[FieldOffset(0x0018)] public void* Platform_ImeUserData;
	[FieldOffset(0x001C)] public ushort Platform_LocaleDecimalPoint;
	[FieldOffset(0x0020)] public void* Renderer_RenderState;
	[FieldOffset(0x0024)] public void** Platform_CreateWindow;
	[FieldOffset(0x0028)] public void** Platform_DestroyWindow;
	[FieldOffset(0x002C)] public void** Platform_ShowWindow;
	[FieldOffset(0x0030)] public void** Platform_SetWindowPos;
	[FieldOffset(0x0034)] public void** Platform_GetWindowPos;
	[FieldOffset(0x0038)] public void** Platform_SetWindowSize;
	[FieldOffset(0x003C)] public void** Platform_GetWindowSize;
	[FieldOffset(0x0040)] public void** Platform_SetWindowFocus;
	[FieldOffset(0x0044)] public void** Platform_GetWindowFocus;
	[FieldOffset(0x0048)] public void** Platform_GetWindowMinimized;
	[FieldOffset(0x004C)] public void** Platform_SetWindowTitle;
	[FieldOffset(0x0050)] public void** Platform_SetWindowAlpha;
	[FieldOffset(0x0054)] public void** Platform_UpdateWindow;
	[FieldOffset(0x0058)] public void** Platform_RenderWindow;
	[FieldOffset(0x005C)] public void** Platform_SwapBuffers;
	[FieldOffset(0x0060)] public void** Platform_GetWindowDpiScale;
	[FieldOffset(0x0064)] public void** Platform_OnChangedViewport;
	[FieldOffset(0x0068)] public void** Platform_GetWindowWorkAreaInsets;
	[FieldOffset(0x006C)] public void** Platform_CreateVkSurface;
	[FieldOffset(0x0070)] public void** Renderer_CreateWindow;
	[FieldOffset(0x0074)] public void** Renderer_DestroyWindow;
	[FieldOffset(0x0078)] public void** Renderer_SetWindowSize;
	[FieldOffset(0x007C)] public void** Renderer_RenderWindow;
	[FieldOffset(0x0080)] public void** Renderer_SwapBuffers;
	[FieldOffset(0x0084)] public ImVector<ImGuiPlatformMonitor> Monitors;
	[FieldOffset(0x0090)] public ImVector<ImGuiViewport> Viewports;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0028)]
public unsafe partial struct ImGuiPlatformMonitor {
	[FieldOffset(0x0000)] public Vector2 MainPos;
	[FieldOffset(0x0008)] public Vector2 MainSize;
	[FieldOffset(0x0010)] public Vector2 WorkPos;
	[FieldOffset(0x0018)] public Vector2 WorkSize;
	[FieldOffset(0x0020)] public float DpiScale;
	[FieldOffset(0x0024)] public void* PlatformHandle;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0048)]
public unsafe partial struct ImGuiViewport {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int Flags;
	[FieldOffset(0x0008)] public Vector2 Pos;
	[FieldOffset(0x0010)] public Vector2 Size;
	[FieldOffset(0x0018)] public Vector2 WorkPos;
	[FieldOffset(0x0020)] public Vector2 WorkSize;
	[FieldOffset(0x0028)] public float DpiScale;
	[FieldOffset(0x002C)] public uint ParentViewportId;
	[FieldOffset(0x0030)] public ImDrawData* DrawData;
	[FieldOffset(0x0034)] public void* RendererUserData;
	[FieldOffset(0x0038)] public void* PlatformUserData;
	[FieldOffset(0x003C)] public void* PlatformHandle;
	[FieldOffset(0x0040)] public void* PlatformHandleRaw;
	[FieldOffset(0x0044)] public byte PlatformWindowCreated;
	[FieldOffset(0x0045)] public byte PlatformRequestMove;
	[FieldOffset(0x0046)] public byte PlatformRequestResize;
	[FieldOffset(0x0047)] public byte PlatformRequestClose;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0038)]
public unsafe partial struct ImDrawData {
	[FieldOffset(0x0000)] public byte Valid;
	[FieldOffset(0x0004)] public int CmdListsCount;
	[FieldOffset(0x0008)] public int TotalIdxCount;
	[FieldOffset(0x000C)] public int TotalVtxCount;
	[FieldOffset(0x0010)] public ImVector<ImDrawList> CmdLists;
	[FieldOffset(0x001C)] public Vector2 DisplayPos;
	[FieldOffset(0x0024)] public Vector2 DisplaySize;
	[FieldOffset(0x002C)] public Vector2 FramebufferScale;
	[FieldOffset(0x0034)] public ImGuiViewport* OwnerViewport;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x04C4)]
public unsafe partial struct ImGuiStyle {
	[FieldOffset(0x0000)] public float Alpha;
	[FieldOffset(0x0004)] public float DisabledAlpha;
	[FieldOffset(0x0008)] public Vector2 WindowPadding;
	[FieldOffset(0x0010)] public float WindowRounding;
	[FieldOffset(0x0014)] public float WindowBorderSize;
	[FieldOffset(0x0018)] public float WindowBorderHoverPadding;
	[FieldOffset(0x001C)] public Vector2 WindowMinSize;
	[FieldOffset(0x0024)] public Vector2 WindowTitleAlign;
	[FieldOffset(0x002C)] public ImGuiDir WindowMenuButtonPosition;
	[FieldOffset(0x0030)] public float ChildRounding;
	[FieldOffset(0x0034)] public float ChildBorderSize;
	[FieldOffset(0x0038)] public float PopupRounding;
	[FieldOffset(0x003C)] public float PopupBorderSize;
	[FieldOffset(0x0040)] public Vector2 FramePadding;
	[FieldOffset(0x0048)] public float FrameRounding;
	[FieldOffset(0x004C)] public float FrameBorderSize;
	[FieldOffset(0x0050)] public Vector2 ItemSpacing;
	[FieldOffset(0x0058)] public Vector2 ItemInnerSpacing;
	[FieldOffset(0x0060)] public Vector2 CellPadding;
	[FieldOffset(0x0068)] public Vector2 TouchExtraPadding;
	[FieldOffset(0x0070)] public float IndentSpacing;
	[FieldOffset(0x0074)] public float ColumnsMinSpacing;
	[FieldOffset(0x0078)] public float ScrollbarSize;
	[FieldOffset(0x007C)] public float ScrollbarRounding;
	[FieldOffset(0x0080)] public float GrabMinSize;
	[FieldOffset(0x0084)] public float GrabRounding;
	[FieldOffset(0x0088)] public float LogSliderDeadzone;
	[FieldOffset(0x008C)] public float ImageBorderSize;
	[FieldOffset(0x0090)] public float TabRounding;
	[FieldOffset(0x0094)] public float TabBorderSize;
	[FieldOffset(0x0098)] public float TabCloseButtonMinWidthSelected;
	[FieldOffset(0x009C)] public float TabCloseButtonMinWidthUnselected;
	[FieldOffset(0x00A0)] public float TabBarBorderSize;
	[FieldOffset(0x00A4)] public float TabBarOverlineSize;
	[FieldOffset(0x00A8)] public float TableAngledHeadersAngle;
	[FieldOffset(0x00AC)] public Vector2 TableAngledHeadersTextAlign;
	[FieldOffset(0x00B4)] public ImGuiDir ColorButtonPosition;
	[FieldOffset(0x00B8)] public Vector2 ButtonTextAlign;
	[FieldOffset(0x00C0)] public Vector2 SelectableTextAlign;
	[FieldOffset(0x00C8)] public float SeparatorTextBorderSize;
	[FieldOffset(0x00CC)] public Vector2 SeparatorTextAlign;
	[FieldOffset(0x00D4)] public Vector2 SeparatorTextPadding;
	[FieldOffset(0x00DC)] public Vector2 DisplayWindowPadding;
	[FieldOffset(0x00E4)] public Vector2 DisplaySafeAreaPadding;
	[FieldOffset(0x00EC)] public float DockingSeparatorSize;
	[FieldOffset(0x00F0)] public float MouseCursorScale;
	[FieldOffset(0x00F4)] public byte AntiAliasedLines;
	[FieldOffset(0x00F5)] public byte AntiAliasedLinesUseTex;
	[FieldOffset(0x00F6)] public byte AntiAliasedFill;
	[FieldOffset(0x00F8)] public float CurveTessellationTol;
	[FieldOffset(0x00FC)] public float CircleTessellationMaxError;
	[FieldOffset(0x0100)] public byte /* Vector4 [59] */ Colors;
	[FieldOffset(0x04B0)] public float HoverStationaryDelay;
	[FieldOffset(0x04B4)] public float HoverDelayShort;
	[FieldOffset(0x04B8)] public float HoverDelayNormal;
	[FieldOffset(0x04BC)] public int HoverFlagsForTooltipMouse;
	[FieldOffset(0x04C0)] public int HoverFlagsForTooltipNav;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x001C)]
public unsafe partial struct ImGuiInputEvent {
	[FieldOffset(0x0000)] public ImGuiInputEventType Type;
	[FieldOffset(0x0004)] public ImGuiInputSource Source;
	[FieldOffset(0x0008)] public uint EventId;
	[FieldOffset(0x000C)] public ImGuiInputEventMousePos MousePos;
	[FieldOffset(0x000C)] public ImGuiInputEventMouseWheel MouseWheel;
	[FieldOffset(0x000C)] public ImGuiInputEventMouseButton MouseButton;
	[FieldOffset(0x000C)] public ImGuiInputEventMouseViewport MouseViewport;
	[FieldOffset(0x000C)] public ImGuiInputEventKey Key;
	[FieldOffset(0x000C)] public ImGuiInputEventText Text;
	[FieldOffset(0x000C)] public ImGuiInputEventAppFocused AppFocused;
	[FieldOffset(0x0018)] public byte AddedByTestEngine;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiInputEventMousePos {
	[FieldOffset(0x0000)] public float PosX;
	[FieldOffset(0x0004)] public float PosY;
	[FieldOffset(0x0008)] public ImGuiMouseSource MouseSource;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiInputEventMouseWheel {
	[FieldOffset(0x0000)] public float WheelX;
	[FieldOffset(0x0004)] public float WheelY;
	[FieldOffset(0x0008)] public ImGuiMouseSource MouseSource;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiInputEventMouseButton {
	[FieldOffset(0x0000)] public int Button;
	[FieldOffset(0x0004)] public byte Down;
	[FieldOffset(0x0008)] public ImGuiMouseSource MouseSource;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct ImGuiInputEventMouseViewport {
	[FieldOffset(0x0000)] public uint HoveredViewportID;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiInputEventKey {
	[FieldOffset(0x0000)] public ImGuiKey Key;
	[FieldOffset(0x0004)] public byte Down;
	[FieldOffset(0x0008)] public float AnalogValue;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct ImGuiInputEventText {
	[FieldOffset(0x0000)] public uint Char;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0001)]
public unsafe partial struct ImGuiInputEventAppFocused {
	[FieldOffset(0x0000)] public byte Focused;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0070)]
public unsafe partial struct ImGuiWindowStackData {
	[FieldOffset(0x0000)] public ImGuiWindow* Window;
	[FieldOffset(0x0004)] public ImGuiLastItemData ParentLastItemDataBackup;
	[FieldOffset(0x0054)] public ImGuiErrorRecoveryState StackSizesInBegin;
	[FieldOffset(0x006A)] public byte DisabledOverrideReenable;
	[FieldOffset(0x006C)] public float DisabledOverrideReenableAlphaBackup;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0050)]
public unsafe partial struct ImGuiLastItemData {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int ItemFlags;
	[FieldOffset(0x0008)] public int StatusFlags;
	[FieldOffset(0x000C)] public ImRect Rect;
	[FieldOffset(0x001C)] public ImRect NavRect;
	[FieldOffset(0x002C)] public ImRect DisplayRect;
	[FieldOffset(0x003C)] public ImRect ClipRect;
	[FieldOffset(0x004C)] public int Shortcut;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0016)]
public unsafe partial struct ImGuiErrorRecoveryState {
	[FieldOffset(0x0000)] public short SizeOfWindowStack;
	[FieldOffset(0x0002)] public short SizeOfIDStack;
	[FieldOffset(0x0004)] public short SizeOfTreeStack;
	[FieldOffset(0x0006)] public short SizeOfColorStack;
	[FieldOffset(0x0008)] public short SizeOfStyleVarStack;
	[FieldOffset(0x000A)] public short SizeOfFontStack;
	[FieldOffset(0x000C)] public short SizeOfFocusScopeStack;
	[FieldOffset(0x000E)] public short SizeOfGroupStack;
	[FieldOffset(0x0010)] public short SizeOfItemFlagsStack;
	[FieldOffset(0x0012)] public short SizeOfBeginPopupStack;
	[FieldOffset(0x0014)] public short SizeOfDisabledStack;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiStorage {
	[FieldOffset(0x0000)] public ImVector<ImGuiStoragePair> Data;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiStoragePair {
	[FieldOffset(0x0000)] public uint key;
	[FieldOffset(0x0004)] public int val_i;
	[FieldOffset(0x0004)] public float val_f;
	[FieldOffset(0x0004)] public void* val_p;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiDeactivatedItemData {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int ElapseFrame;
	[FieldOffset(0x0008)] public byte HasBeenEditedBefore;
	[FieldOffset(0x0009)] public byte IsAlive;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiDataTypeStorage {
	[FieldOffset(0x0000)] public byte /* byte [8] */ Data;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0014)]
public unsafe partial struct ImBitArray_155__512_ {
	[FieldOffset(0x0000)] public byte /* uint [5] */ Storage;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiKeyOwnerData {
	[FieldOffset(0x0000)] public uint OwnerCurr;
	[FieldOffset(0x0004)] public uint OwnerNext;
	[FieldOffset(0x0008)] public byte LockThisFrame;
	[FieldOffset(0x0009)] public byte LockUntilRelease;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0150)]
public unsafe partial struct ImGuiKeyRoutingTable {
	[FieldOffset(0x0000)] public byte /* short [155] */ Index;
	[FieldOffset(0x0138)] public ImVector<ImGuiKeyRoutingData> Entries;
	[FieldOffset(0x0144)] public ImVector<ImGuiKeyRoutingData> EntriesNext;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiKeyRoutingData {
	[FieldOffset(0x0000)] public short NextEntryIndex;
	[FieldOffset(0x0002)] public ushort Mods;
	[FieldOffset(0x0004)] public byte RoutingCurrScore;
	[FieldOffset(0x0005)] public byte RoutingNextScore;
	[FieldOffset(0x0008)] public uint RoutingCurr;
	[FieldOffset(0x000C)] public uint RoutingNext;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0038)]
public unsafe partial struct ImGuiNextItemData {
	[FieldOffset(0x0000)] public int HasFlags;
	[FieldOffset(0x0004)] public int ItemFlags;
	[FieldOffset(0x0008)] public uint FocusScopeId;
	[FieldOffset(0x0010)] public long SelectionUserData;
	[FieldOffset(0x0018)] public float Width;
	[FieldOffset(0x001C)] public int Shortcut;
	[FieldOffset(0x0020)] public int ShortcutFlags;
	[FieldOffset(0x0024)] public byte OpenVal;
	[FieldOffset(0x0025)] public byte OpenCond;
	[FieldOffset(0x0026)] public ImGuiDataTypeStorage RefVal;
	[FieldOffset(0x0030)] public uint StorageId;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0098)]
public unsafe partial struct ImGuiNextWindowData {
	[FieldOffset(0x0000)] public int HasFlags;
	[FieldOffset(0x0004)] public int PosCond;
	[FieldOffset(0x0008)] public int SizeCond;
	[FieldOffset(0x000C)] public int CollapsedCond;
	[FieldOffset(0x0010)] public int DockCond;
	[FieldOffset(0x0014)] public Vector2 PosVal;
	[FieldOffset(0x001C)] public Vector2 PosPivotVal;
	[FieldOffset(0x0024)] public Vector2 SizeVal;
	[FieldOffset(0x002C)] public Vector2 ContentSizeVal;
	[FieldOffset(0x0034)] public Vector2 ScrollVal;
	[FieldOffset(0x003C)] public int WindowFlags;
	[FieldOffset(0x0040)] public int ChildFlags;
	[FieldOffset(0x0044)] public byte PosUndock;
	[FieldOffset(0x0045)] public byte CollapsedVal;
	[FieldOffset(0x0048)] public ImRect SizeConstraintRect;
	[FieldOffset(0x0058)] public void** SizeCallback;
	[FieldOffset(0x005C)] public void* SizeCallbackUserData;
	[FieldOffset(0x0060)] public float BgAlphaVal;
	[FieldOffset(0x0064)] public uint ViewportId;
	[FieldOffset(0x0068)] public uint DockId;
	[FieldOffset(0x006C)] public ImGuiWindowClass WindowClass;
	[FieldOffset(0x008C)] public Vector2 MenuBarOffsetMinVal;
	[FieldOffset(0x0094)] public int RefreshFlagsVal;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0020)]
public unsafe partial struct ImGuiWindowClass {
	[FieldOffset(0x0000)] public uint ClassId;
	[FieldOffset(0x0004)] public uint ParentViewportId;
	[FieldOffset(0x0008)] public uint FocusRouteParentWindowId;
	[FieldOffset(0x000C)] public int ViewportFlagsOverrideSet;
	[FieldOffset(0x0010)] public int ViewportFlagsOverrideClear;
	[FieldOffset(0x0014)] public int TabItemFlagsOverrideSet;
	[FieldOffset(0x0018)] public int DockNodeFlagsOverrideSet;
	[FieldOffset(0x001C)] public byte DockingAlwaysTabBar;
	[FieldOffset(0x001D)] public byte DockingAllowUnclassed;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0014)]
public unsafe partial struct ImGuiColorMod {
	[FieldOffset(0x0000)] public int Col;
	[FieldOffset(0x0004)] public Vector4 BackupValue;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiStyleMod {
	[FieldOffset(0x0000)] public int VarIdx;
	[FieldOffset(0x0004)] public byte /* int [2] */ BackupInt;
	[FieldOffset(0x0004)] public byte /* float [2] */ BackupFloat;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiFocusScopeData {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public uint WindowID;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0038)]
public unsafe partial struct ImGuiGroupData {
	[FieldOffset(0x0000)] public uint WindowID;
	[FieldOffset(0x0004)] public Vector2 BackupCursorPos;
	[FieldOffset(0x000C)] public Vector2 BackupCursorMaxPos;
	[FieldOffset(0x0014)] public Vector2 BackupCursorPosPrevLine;
	[FieldOffset(0x001C)] public ImVec1 BackupIndent;
	[FieldOffset(0x0020)] public ImVec1 BackupGroupOffset;
	[FieldOffset(0x0024)] public Vector2 BackupCurrLineSize;
	[FieldOffset(0x002C)] public float BackupCurrLineTextBaseOffset;
	[FieldOffset(0x0030)] public uint BackupActiveIdIsAlive;
	[FieldOffset(0x0034)] public byte BackupDeactivatedIdIsAlive;
	[FieldOffset(0x0035)] public byte BackupHoveredIdIsAlive;
	[FieldOffset(0x0036)] public byte BackupIsSameLine;
	[FieldOffset(0x0037)] public byte EmitItem;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct ImVec1 {
	[FieldOffset(0x0000)] public float x;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0028)]
public unsafe partial struct ImGuiPopupData {
	[FieldOffset(0x0000)] public uint PopupId;
	[FieldOffset(0x0004)] public ImGuiWindow* Window;
	[FieldOffset(0x0008)] public ImGuiWindow* RestoreNavWindow;
	[FieldOffset(0x000C)] public int ParentNavLayer;
	[FieldOffset(0x0010)] public int OpenFrameCount;
	[FieldOffset(0x0014)] public uint OpenParentId;
	[FieldOffset(0x0018)] public Vector2 OpenPopupPos;
	[FieldOffset(0x0020)] public Vector2 OpenMousePos;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x001C)]
public unsafe partial struct ImGuiTreeNodeStackData {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int TreeFlags;
	[FieldOffset(0x0008)] public int ItemFlags;
	[FieldOffset(0x000C)] public ImRect NavRect;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x010C)]
public unsafe partial struct ImGuiViewportP {
	[FieldOffset(0x0048)] public ImGuiWindow* Window;
	[FieldOffset(0x004C)] public int Idx;
	[FieldOffset(0x0050)] public int LastFrameActive;
	[FieldOffset(0x0054)] public int LastFocusedStampCount;
	[FieldOffset(0x0058)] public uint LastNameHash;
	[FieldOffset(0x005C)] public Vector2 LastPos;
	[FieldOffset(0x0064)] public Vector2 LastSize;
	[FieldOffset(0x006C)] public float Alpha;
	[FieldOffset(0x0070)] public float LastAlpha;
	[FieldOffset(0x0074)] public byte LastFocusedHadNavWindow;
	[FieldOffset(0x0076)] public short PlatformMonitor;
	[FieldOffset(0x0078)] public byte /* int [2] */ BgFgDrawListsLastFrame;
	[FieldOffset(0x0080)] public byte /* ImDrawList* [2] */ BgFgDrawLists;
	[FieldOffset(0x0088)] public ImDrawData DrawDataP;
	[FieldOffset(0x00C0)] public ImDrawDataBuilder DrawDataBuilder;
	[FieldOffset(0x00D4)] public Vector2 LastPlatformPos;
	[FieldOffset(0x00DC)] public Vector2 LastPlatformSize;
	[FieldOffset(0x00E4)] public Vector2 LastRendererSize;
	[FieldOffset(0x00EC)] public Vector2 WorkInsetMin;
	[FieldOffset(0x00F4)] public Vector2 WorkInsetMax;
	[FieldOffset(0x00FC)] public Vector2 BuildWorkInsetMin;
	[FieldOffset(0x0104)] public Vector2 BuildWorkInsetMax;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0014)]
public unsafe partial struct ImDrawDataBuilder {
	[FieldOffset(0x0000)] public byte /* ImVector<ImDrawList>* [2] */ Layers;
	[FieldOffset(0x0008)] public ImVector<ImDrawList> LayerData1;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0038)]
public unsafe partial struct ImGuiNavItemData {
	[FieldOffset(0x0000)] public ImGuiWindow* Window;
	[FieldOffset(0x0004)] public uint ID;
	[FieldOffset(0x0008)] public uint FocusScopeId;
	[FieldOffset(0x000C)] public ImRect RectRel;
	[FieldOffset(0x001C)] public int ItemFlags;
	[FieldOffset(0x0020)] public float DistBox;
	[FieldOffset(0x0024)] public float DistCenter;
	[FieldOffset(0x0028)] public float DistAxial;
	[FieldOffset(0x0030)] public long SelectionUserData;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0038)]
public unsafe partial struct ImGuiPayload {
	[FieldOffset(0x0000)] public void* Data;
	[FieldOffset(0x0004)] public int DataSize;
	[FieldOffset(0x0008)] public uint SourceId;
	[FieldOffset(0x000C)] public uint SourceParentId;
	[FieldOffset(0x0010)] public int DataFrameCount;
	[FieldOffset(0x0014)] public byte /* byte [33] */ DataType;
	[FieldOffset(0x0035)] public byte Preview;
	[FieldOffset(0x0036)] public byte Delivery;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x001C)]
public unsafe partial struct ImGuiListClipperData {
	[FieldOffset(0x0000)] public ImGuiListClipper* ListClipper;
	[FieldOffset(0x0004)] public float LossynessOffset;
	[FieldOffset(0x0008)] public int StepNo;
	[FieldOffset(0x000C)] public int ItemsFrozen;
	[FieldOffset(0x0010)] public ImVector<ImGuiListClipperRange> Ranges;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0028)]
public unsafe partial struct ImGuiListClipper {
	[FieldOffset(0x0000)] public ImGuiContext* Ctx;
	[FieldOffset(0x0004)] public int DisplayStart;
	[FieldOffset(0x0008)] public int DisplayEnd;
	[FieldOffset(0x000C)] public int ItemsCount;
	[FieldOffset(0x0010)] public float ItemsHeight;
	[FieldOffset(0x0014)] public float StartPosY;
	[FieldOffset(0x0018)] public double StartSeekOffsetY;
	[FieldOffset(0x0020)] public void* TempData;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiListClipperRange {
	[FieldOffset(0x0000)] public int Min;
	[FieldOffset(0x0004)] public int Max;
	[FieldOffset(0x0008)] public byte PosToIndexConvert;
	[FieldOffset(0x0009)] public sbyte PosToIndexOffsetMin;
	[FieldOffset(0x000A)] public sbyte PosToIndexOffsetMax;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0200)]
public unsafe partial struct ImGuiTable {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int Flags;
	[FieldOffset(0x0008)] public void* RawData;
	[FieldOffset(0x000C)] public ImGuiTableTempData* TempData;
	[FieldOffset(0x0010)] public ImSpan<ImGuiTableColumn> Columns;
	[FieldOffset(0x0018)] public ImSpan<short> DisplayOrderToIndex;
	[FieldOffset(0x0020)] public ImSpan<ImGuiTableCellData> RowCellData;
	[FieldOffset(0x0028)] public uint* EnabledMaskByDisplayOrder;
	[FieldOffset(0x002C)] public uint* EnabledMaskByIndex;
	[FieldOffset(0x0030)] public uint* VisibleMaskByIndex;
	[FieldOffset(0x0034)] public int SettingsLoadedFlags;
	[FieldOffset(0x0038)] public int SettingsOffset;
	[FieldOffset(0x003C)] public int LastFrameActive;
	[FieldOffset(0x0040)] public int ColumnsCount;
	[FieldOffset(0x0044)] public int CurrentRow;
	[FieldOffset(0x0048)] public int CurrentColumn;
	[FieldOffset(0x004C)] public short InstanceCurrent;
	[FieldOffset(0x004E)] public short InstanceInteracted;
	[FieldOffset(0x0050)] public float RowPosY1;
	[FieldOffset(0x0054)] public float RowPosY2;
	[FieldOffset(0x0058)] public float RowMinHeight;
	[FieldOffset(0x005C)] public float RowCellPaddingY;
	[FieldOffset(0x0060)] public float RowTextBaseline;
	[FieldOffset(0x0064)] public float RowIndentOffsetX;
	[FieldOffset(0x0068)] public int RowFlags;
	[FieldOffset(0x0068)] public int LastRowFlags;
	[FieldOffset(0x006C)] public int RowBgColorCounter;
	[FieldOffset(0x0070)] public byte /* uint [2] */ RowBgColor;
	[FieldOffset(0x0078)] public uint BorderColorStrong;
	[FieldOffset(0x007C)] public uint BorderColorLight;
	[FieldOffset(0x0080)] public float BorderX1;
	[FieldOffset(0x0084)] public float BorderX2;
	[FieldOffset(0x0088)] public float HostIndentX;
	[FieldOffset(0x008C)] public float MinColumnWidth;
	[FieldOffset(0x0090)] public float OuterPaddingX;
	[FieldOffset(0x0094)] public float CellPaddingX;
	[FieldOffset(0x0098)] public float CellSpacingX1;
	[FieldOffset(0x009C)] public float CellSpacingX2;
	[FieldOffset(0x00A0)] public float InnerWidth;
	[FieldOffset(0x00A4)] public float ColumnsGivenWidth;
	[FieldOffset(0x00A8)] public float ColumnsAutoFitWidth;
	[FieldOffset(0x00AC)] public float ColumnsStretchSumWeights;
	[FieldOffset(0x00B0)] public float ResizedColumnNextWidth;
	[FieldOffset(0x00B4)] public float ResizeLockMinContentsX2;
	[FieldOffset(0x00B8)] public float RefScale;
	[FieldOffset(0x00BC)] public float AngledHeadersHeight;
	[FieldOffset(0x00C0)] public float AngledHeadersSlope;
	[FieldOffset(0x00C4)] public ImRect OuterRect;
	[FieldOffset(0x00D4)] public ImRect InnerRect;
	[FieldOffset(0x00E4)] public ImRect WorkRect;
	[FieldOffset(0x00F4)] public ImRect InnerClipRect;
	[FieldOffset(0x0104)] public ImRect BgClipRect;
	[FieldOffset(0x0114)] public ImRect Bg0ClipRectForDrawCmd;
	[FieldOffset(0x0124)] public ImRect Bg2ClipRectForDrawCmd;
	[FieldOffset(0x0134)] public ImRect HostClipRect;
	[FieldOffset(0x0144)] public ImRect HostBackupInnerClipRect;
	[FieldOffset(0x0154)] public ImGuiWindow* OuterWindow;
	[FieldOffset(0x0158)] public ImGuiWindow* InnerWindow;
	[FieldOffset(0x015C)] public ImGuiTextBuffer ColumnsNames;
	[FieldOffset(0x0168)] public ImDrawListSplitter* DrawSplitter;
	[FieldOffset(0x016C)] public ImGuiTableInstanceData InstanceDataFirst;
	[FieldOffset(0x0184)] public ImVector<ImGuiTableInstanceData> InstanceDataExtra;
	[FieldOffset(0x0190)] public ImGuiTableColumnSortSpecs SortSpecsSingle;
	[FieldOffset(0x019C)] public ImVector<ImGuiTableColumnSortSpecs> SortSpecsMulti;
	[FieldOffset(0x01A8)] public ImGuiTableSortSpecs SortSpecs;
	[FieldOffset(0x01B4)] public short SortSpecsCount;
	[FieldOffset(0x01B6)] public short ColumnsEnabledCount;
	[FieldOffset(0x01B8)] public short ColumnsEnabledFixedCount;
	[FieldOffset(0x01BA)] public short DeclColumnsCount;
	[FieldOffset(0x01BC)] public short AngledHeadersCount;
	[FieldOffset(0x01BE)] public short HoveredColumnBody;
	[FieldOffset(0x01C0)] public short HoveredColumnBorder;
	[FieldOffset(0x01C2)] public short HighlightColumnHeader;
	[FieldOffset(0x01C4)] public short AutoFitSingleColumn;
	[FieldOffset(0x01C6)] public short ResizedColumn;
	[FieldOffset(0x01C8)] public short LastResizedColumn;
	[FieldOffset(0x01CA)] public short HeldHeaderColumn;
	[FieldOffset(0x01CC)] public short ReorderColumn;
	[FieldOffset(0x01CE)] public short ReorderColumnDir;
	[FieldOffset(0x01D0)] public short LeftMostEnabledColumn;
	[FieldOffset(0x01D2)] public short RightMostEnabledColumn;
	[FieldOffset(0x01D4)] public short LeftMostStretchedColumn;
	[FieldOffset(0x01D6)] public short RightMostStretchedColumn;
	[FieldOffset(0x01D8)] public short ContextPopupColumn;
	[FieldOffset(0x01DA)] public short FreezeRowsRequest;
	[FieldOffset(0x01DC)] public short FreezeRowsCount;
	[FieldOffset(0x01DE)] public short FreezeColumnsRequest;
	[FieldOffset(0x01E0)] public short FreezeColumnsCount;
	[FieldOffset(0x01E2)] public short RowCellDataCurrent;
	[FieldOffset(0x01E4)] public ushort DummyDrawChannel;
	[FieldOffset(0x01E6)] public ushort Bg2DrawChannelCurrent;
	[FieldOffset(0x01E8)] public ushort Bg2DrawChannelUnfrozen;
	[FieldOffset(0x01EA)] public sbyte NavLayer;
	[FieldOffset(0x01EB)] public byte IsLayoutLocked;
	[FieldOffset(0x01EC)] public byte IsInsideRow;
	[FieldOffset(0x01ED)] public byte IsInitializing;
	[FieldOffset(0x01EE)] public byte IsSortSpecsDirty;
	[FieldOffset(0x01EF)] public byte IsUsingHeaders;
	[FieldOffset(0x01F0)] public byte IsContextPopupOpen;
	[FieldOffset(0x01F1)] public byte DisableDefaultContextMenu;
	[FieldOffset(0x01F2)] public byte IsSettingsRequestLoad;
	[FieldOffset(0x01F3)] public byte IsSettingsDirty;
	[FieldOffset(0x01F4)] public byte IsDefaultDisplayOrder;
	[FieldOffset(0x01F5)] public byte IsResetAllRequest;
	[FieldOffset(0x01F6)] public byte IsResetDisplayOrderRequest;
	[FieldOffset(0x01F7)] public byte IsUnfrozenRows;
	[FieldOffset(0x01F8)] public byte IsDefaultSizingPolicy;
	[FieldOffset(0x01F9)] public byte IsActiveIdAliveBeforeTable;
	[FieldOffset(0x01FA)] public byte IsActiveIdInTable;
	[FieldOffset(0x01FB)] public byte HasScrollbarYCurr;
	[FieldOffset(0x01FC)] public byte HasScrollbarYPrev;
	[FieldOffset(0x01FD)] public byte MemoryCompacted;
	[FieldOffset(0x01FE)] public byte HostSkipItems;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0078)]
public unsafe partial struct ImGuiTableTempData {
	[FieldOffset(0x0000)] public int TableIndex;
	[FieldOffset(0x0004)] public float LastTimeActive;
	[FieldOffset(0x0008)] public float AngledHeadersExtraWidth;
	[FieldOffset(0x000C)] public ImVector<ImGuiTableHeaderData> AngledHeadersRequests;
	[FieldOffset(0x0018)] public Vector2 UserOuterSize;
	[FieldOffset(0x0020)] public ImDrawListSplitter DrawSplitter;
	[FieldOffset(0x0034)] public ImRect HostBackupWorkRect;
	[FieldOffset(0x0044)] public ImRect HostBackupParentWorkRect;
	[FieldOffset(0x0054)] public Vector2 HostBackupPrevLineSize;
	[FieldOffset(0x005C)] public Vector2 HostBackupCurrLineSize;
	[FieldOffset(0x0064)] public Vector2 HostBackupCursorMaxPos;
	[FieldOffset(0x006C)] public ImVec1 HostBackupColumnsOffset;
	[FieldOffset(0x0070)] public float HostBackupItemWidth;
	[FieldOffset(0x0074)] public int HostBackupItemWidthStackSize;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiTableHeaderData {
	[FieldOffset(0x0000)] public short Index;
	[FieldOffset(0x0004)] public uint TextColor;
	[FieldOffset(0x0008)] public uint BgColor0;
	[FieldOffset(0x000C)] public uint BgColor1;
}
[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImSpan<T> where T : unmanaged {
	public T* Data;
	public T* DataEnd;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0074)]
public unsafe partial struct ImGuiTableColumn {
	[FieldOffset(0x0000)] public int Flags;
	[FieldOffset(0x0004)] public float WidthGiven;
	[FieldOffset(0x0008)] public float MinX;
	[FieldOffset(0x000C)] public float MaxX;
	[FieldOffset(0x0010)] public float WidthRequest;
	[FieldOffset(0x0014)] public float WidthAuto;
	[FieldOffset(0x0018)] public float WidthMax;
	[FieldOffset(0x001C)] public float StretchWeight;
	[FieldOffset(0x0020)] public float InitStretchWeightOrWidth;
	[FieldOffset(0x0024)] public ImRect ClipRect;
	[FieldOffset(0x0034)] public uint UserID;
	[FieldOffset(0x0038)] public float WorkMinX;
	[FieldOffset(0x003C)] public float WorkMaxX;
	[FieldOffset(0x0040)] public float ItemWidth;
	[FieldOffset(0x0044)] public float ContentMaxXFrozen;
	[FieldOffset(0x0048)] public float ContentMaxXUnfrozen;
	[FieldOffset(0x004C)] public float ContentMaxXHeadersUsed;
	[FieldOffset(0x0050)] public float ContentMaxXHeadersIdeal;
	[FieldOffset(0x0054)] public short NameOffset;
	[FieldOffset(0x0056)] public short DisplayOrder;
	[FieldOffset(0x0058)] public short IndexWithinEnabledSet;
	[FieldOffset(0x005A)] public short PrevEnabledColumn;
	[FieldOffset(0x005C)] public short NextEnabledColumn;
	[FieldOffset(0x005E)] public short SortOrder;
	[FieldOffset(0x0060)] public ushort DrawChannelCurrent;
	[FieldOffset(0x0062)] public ushort DrawChannelFrozen;
	[FieldOffset(0x0064)] public ushort DrawChannelUnfrozen;
	[FieldOffset(0x0066)] public byte IsEnabled;
	[FieldOffset(0x0067)] public byte IsUserEnabled;
	[FieldOffset(0x0068)] public byte IsUserEnabledNextFrame;
	[FieldOffset(0x0069)] public byte IsVisibleX;
	[FieldOffset(0x006A)] public byte IsVisibleY;
	[FieldOffset(0x006B)] public byte IsRequestOutput;
	[FieldOffset(0x006C)] public byte IsSkipItems;
	[FieldOffset(0x006D)] public byte IsPreserveWidthAuto;
	[FieldOffset(0x006E)] public sbyte NavLayerCurrent;
	[FieldOffset(0x006F)] public byte AutoFitQueue;
	[FieldOffset(0x0070)] public byte CannotSkipItemsQueue;
	[FieldOffset(0x0071)] public byte SortDirection;
	[FieldOffset(0x0071)] public byte SortDirectionsAvailCount;
	[FieldOffset(0x0071)] public byte SortDirectionsAvailMask;
	[FieldOffset(0x0072)] public byte SortDirectionsAvailList;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiTableCellData {
	[FieldOffset(0x0000)] public uint BgColor;
	[FieldOffset(0x0004)] public short Column;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiTextBuffer {
	[FieldOffset(0x0000)] public ImVector<char> Buf;
	[FieldOffset(0x0000)] public byte /* byte [1] */ EmptyString;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0018)]
public unsafe partial struct ImGuiTableInstanceData {
	[FieldOffset(0x0000)] public uint TableInstanceID;
	[FieldOffset(0x0004)] public float LastOuterHeight;
	[FieldOffset(0x0008)] public float LastTopHeadersRowHeight;
	[FieldOffset(0x000C)] public float LastFrozenHeight;
	[FieldOffset(0x0010)] public int HoveredRowLast;
	[FieldOffset(0x0014)] public int HoveredRowNext;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiTableColumnSortSpecs {
	[FieldOffset(0x0000)] public uint ColumnUserID;
	[FieldOffset(0x0004)] public short ColumnIndex;
	[FieldOffset(0x0006)] public short SortOrder;
	[FieldOffset(0x0008)] public ImGuiSortDirection SortDirection;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiTableSortSpecs {
	[FieldOffset(0x0000)] public ImGuiTableColumnSortSpecs* Specs;
	[FieldOffset(0x0004)] public int SpecsCount;
	[FieldOffset(0x0008)] public byte SpecsDirty;
}
[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 0x0020)]
public unsafe partial struct ImPool<T> where T : unmanaged {
	public ImVector<T> Buf;
	public ImGuiStorage Map;
	public int FreeIdx;
	public int AliveCount;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x009C)]
public unsafe partial struct ImGuiTabBar {
	[FieldOffset(0x0000)] public ImGuiWindow* Window;
	[FieldOffset(0x0004)] public ImVector<ImGuiTabItem> Tabs;
	[FieldOffset(0x0010)] public int Flags;
	[FieldOffset(0x0014)] public uint ID;
	[FieldOffset(0x0018)] public uint SelectedTabId;
	[FieldOffset(0x001C)] public uint NextSelectedTabId;
	[FieldOffset(0x0020)] public uint VisibleTabId;
	[FieldOffset(0x0024)] public int CurrFrameVisible;
	[FieldOffset(0x0028)] public int PrevFrameVisible;
	[FieldOffset(0x002C)] public ImRect BarRect;
	[FieldOffset(0x003C)] public float CurrTabsContentsHeight;
	[FieldOffset(0x0040)] public float PrevTabsContentsHeight;
	[FieldOffset(0x0044)] public float WidthAllTabs;
	[FieldOffset(0x0048)] public float WidthAllTabsIdeal;
	[FieldOffset(0x004C)] public float ScrollingAnim;
	[FieldOffset(0x0050)] public float ScrollingTarget;
	[FieldOffset(0x0054)] public float ScrollingTargetDistToVisibility;
	[FieldOffset(0x0058)] public float ScrollingSpeed;
	[FieldOffset(0x005C)] public float ScrollingRectMinX;
	[FieldOffset(0x0060)] public float ScrollingRectMaxX;
	[FieldOffset(0x0064)] public float SeparatorMinX;
	[FieldOffset(0x0068)] public float SeparatorMaxX;
	[FieldOffset(0x006C)] public uint ReorderRequestTabId;
	[FieldOffset(0x0070)] public short ReorderRequestOffset;
	[FieldOffset(0x0072)] public sbyte BeginCount;
	[FieldOffset(0x0073)] public byte WantLayout;
	[FieldOffset(0x0074)] public byte VisibleTabWasSubmitted;
	[FieldOffset(0x0075)] public byte TabsAddedNew;
	[FieldOffset(0x0076)] public short TabsActiveCount;
	[FieldOffset(0x0078)] public short LastTabItemIdx;
	[FieldOffset(0x007C)] public float ItemSpacingY;
	[FieldOffset(0x0080)] public Vector2 FramePadding;
	[FieldOffset(0x0088)] public Vector2 BackupCursorPos;
	[FieldOffset(0x0090)] public ImGuiTextBuffer TabsNames;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0030)]
public unsafe partial struct ImGuiTabItem {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int Flags;
	[FieldOffset(0x0008)] public ImGuiWindow* Window;
	[FieldOffset(0x000C)] public int LastFrameVisible;
	[FieldOffset(0x0010)] public int LastFrameSelected;
	[FieldOffset(0x0014)] public float Offset;
	[FieldOffset(0x0018)] public float Width;
	[FieldOffset(0x001C)] public float ContentWidth;
	[FieldOffset(0x0020)] public float RequestedWidth;
	[FieldOffset(0x0024)] public int NameOffset;
	[FieldOffset(0x0028)] public short BeginOrder;
	[FieldOffset(0x002A)] public short IndexDuringLayout;
	[FieldOffset(0x002C)] public byte WantClose;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiPtrOrIndex {
	[FieldOffset(0x0000)] public void* Ptr;
	[FieldOffset(0x0004)] public int Index;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImGuiShrinkWidthItem {
	[FieldOffset(0x0000)] public int Index;
	[FieldOffset(0x0004)] public float Width;
	[FieldOffset(0x0008)] public float InitialWidth;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0060)]
public unsafe partial struct ImGuiBoxSelectState {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public byte IsActive;
	[FieldOffset(0x0005)] public byte IsStarting;
	[FieldOffset(0x0006)] public byte IsStartedFromVoid;
	[FieldOffset(0x0007)] public byte IsStartedSetNavIdOnce;
	[FieldOffset(0x0008)] public byte RequestClear;
	[FieldOffset(0x000C)] public int KeyMods;
	[FieldOffset(0x0010)] public Vector2 StartPosRel;
	[FieldOffset(0x0018)] public Vector2 EndPosRel;
	[FieldOffset(0x0020)] public Vector2 ScrollAccum;
	[FieldOffset(0x0028)] public ImGuiWindow* Window;
	[FieldOffset(0x002C)] public byte UnclipMode;
	[FieldOffset(0x0030)] public ImRect UnclipRect;
	[FieldOffset(0x0040)] public ImRect BoxSelectRectPrev;
	[FieldOffset(0x0050)] public ImRect BoxSelectRectCurr;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0060)]
public unsafe partial struct ImGuiMultiSelectTempData {
	[FieldOffset(0x0000)] public ImGuiMultiSelectIO IO;
	[FieldOffset(0x0028)] public ImGuiMultiSelectState* Storage;
	[FieldOffset(0x002C)] public uint FocusScopeId;
	[FieldOffset(0x0030)] public int Flags;
	[FieldOffset(0x0034)] public Vector2 ScopeRectMin;
	[FieldOffset(0x003C)] public Vector2 BackupCursorMaxPos;
	[FieldOffset(0x0048)] public long LastSubmittedItem;
	[FieldOffset(0x0050)] public uint BoxSelectId;
	[FieldOffset(0x0054)] public int KeyMods;
	[FieldOffset(0x0058)] public sbyte LoopRequestSetAll;
	[FieldOffset(0x0059)] public byte IsEndIO;
	[FieldOffset(0x005A)] public byte IsFocused;
	[FieldOffset(0x005B)] public byte IsKeyboardSetRange;
	[FieldOffset(0x005C)] public byte NavIdPassedBy;
	[FieldOffset(0x005D)] public byte RangeSrcPassedBy;
	[FieldOffset(0x005E)] public byte RangeDstPassedBy;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0028)]
public unsafe partial struct ImGuiMultiSelectIO {
	[FieldOffset(0x0000)] public ImVector<ImGuiSelectionRequest> Requests;
	[FieldOffset(0x0010)] public long RangeSrcItem;
	[FieldOffset(0x0018)] public long NavIdItem;
	[FieldOffset(0x0020)] public byte NavIdSelected;
	[FieldOffset(0x0021)] public byte RangeSrcReset;
	[FieldOffset(0x0024)] public int ItemsCount;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0018)]
public unsafe partial struct ImGuiSelectionRequest {
	[FieldOffset(0x0000)] public ImGuiSelectionRequestType Type;
	[FieldOffset(0x0004)] public byte Selected;
	[FieldOffset(0x0005)] public sbyte RangeDirection;
	[FieldOffset(0x0008)] public long RangeFirstItem;
	[FieldOffset(0x0010)] public long RangeLastItem;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0028)]
public unsafe partial struct ImGuiMultiSelectState {
	[FieldOffset(0x0000)] public ImGuiWindow* Window;
	[FieldOffset(0x0004)] public uint ID;
	[FieldOffset(0x0008)] public int LastFrameActive;
	[FieldOffset(0x000C)] public int LastSelectionSize;
	[FieldOffset(0x0010)] public sbyte RangeSelected;
	[FieldOffset(0x0011)] public sbyte NavIdSelected;
	[FieldOffset(0x0018)] public long RangeSrcItem;
	[FieldOffset(0x0020)] public long NavIdItem;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0058)]
public unsafe partial struct ImGuiInputTextState {
	[FieldOffset(0x0000)] public ImGuiContext* Ctx;
	[FieldOffset(0x0004)] public ImStb__STB_TexteditState* Stb;
	[FieldOffset(0x0008)] public int Flags;
	[FieldOffset(0x000C)] public uint ID;
	[FieldOffset(0x0010)] public int TextLen;
	[FieldOffset(0x0014)] public byte* TextSrc;
	[FieldOffset(0x0018)] public ImVector<char> TextA;
	[FieldOffset(0x0024)] public ImVector<char> TextToRevertTo;
	[FieldOffset(0x0030)] public ImVector<char> CallbackTextBackup;
	[FieldOffset(0x003C)] public int BufCapacity;
	[FieldOffset(0x0040)] public Vector2 Scroll;
	[FieldOffset(0x0048)] public float CursorAnim;
	[FieldOffset(0x004C)] public byte CursorFollow;
	[FieldOffset(0x004D)] public byte SelectedAllMouseLock;
	[FieldOffset(0x004E)] public byte Edited;
	[FieldOffset(0x004F)] public byte WantReloadUserBuf;
	[FieldOffset(0x0050)] public int ReloadSelectionStart;
	[FieldOffset(0x0054)] public int ReloadSelectionEnd;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0A44)]
public unsafe partial struct ImStb__STB_TexteditState {
	[FieldOffset(0x0000)] public int cursor;
	[FieldOffset(0x0004)] public int select_start;
	[FieldOffset(0x0008)] public int select_end;
	[FieldOffset(0x000C)] public byte insert_mode;
	[FieldOffset(0x0010)] public int row_count_per_page;
	[FieldOffset(0x0014)] public byte cursor_at_end_of_line;
	[FieldOffset(0x0015)] public byte initialized;
	[FieldOffset(0x0016)] public byte has_preferred_x;
	[FieldOffset(0x0017)] public byte single_line;
	[FieldOffset(0x0018)] public byte padding1;
	[FieldOffset(0x0019)] public byte padding2;
	[FieldOffset(0x001A)] public byte padding3;
	[FieldOffset(0x001C)] public float preferred_x;
	[FieldOffset(0x0020)] public ImStb__StbUndoState undostate;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0A24)]
public unsafe partial struct ImStb__StbUndoState {
	[FieldOffset(0x0000)] public byte /* ImStb__StbUndoRecord [99] */ undo_rec;
	[FieldOffset(0x0630)] public byte /* byte [999] */ undo_char;
	[FieldOffset(0x0A18)] public short undo_point;
	[FieldOffset(0x0A1A)] public short redo_point;
	[FieldOffset(0x0A1C)] public int undo_char_point;
	[FieldOffset(0x0A20)] public int redo_char_point;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImStb__StbUndoRecord {
	[FieldOffset(0x0000)] public int where;
	[FieldOffset(0x0004)] public int insert_length;
	[FieldOffset(0x0008)] public int delete_length;
	[FieldOffset(0x000C)] public int char_storage;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiInputTextDeactivatedState {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public ImVector<char> TextA;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0060)]
public unsafe partial struct ImGuiTypingSelectState {
	[FieldOffset(0x0000)] public ImGuiTypingSelectRequest Request;
	[FieldOffset(0x0010)] public byte /* byte [64] */ SearchBuffer;
	[FieldOffset(0x0050)] public uint FocusScope;
	[FieldOffset(0x0054)] public int LastRequestFrame;
	[FieldOffset(0x0058)] public float LastRequestTime;
	[FieldOffset(0x005C)] public byte SingleCharModeLock;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiTypingSelectRequest {
	[FieldOffset(0x0000)] public int Flags;
	[FieldOffset(0x0004)] public int SearchBufferLen;
	[FieldOffset(0x0008)] public byte* SearchBuffer;
	[FieldOffset(0x000C)] public byte SelectRequest;
	[FieldOffset(0x000D)] public byte SingleCharMode;
	[FieldOffset(0x000E)] public sbyte SingleCharSize;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiPlatformImeData {
	[FieldOffset(0x0000)] public byte WantVisible;
	[FieldOffset(0x0004)] public Vector2 InputPos;
	[FieldOffset(0x000C)] public float InputLineHeight;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0028)]
public unsafe partial struct ImGuiDockContext {
	[FieldOffset(0x0000)] public ImGuiStorage Nodes;
	[FieldOffset(0x000C)] public ImVector<ImGuiDockRequest> Requests;
	[FieldOffset(0x0018)] public ImVector<ImGuiDockNodeSettings> NodesSettings;
	[FieldOffset(0x0024)] public byte WantFullRebuild;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0024)]
public unsafe partial struct ImGuiDockRequest {
	[FieldOffset(0x0000)] public ImGuiDockRequestType Type;
	[FieldOffset(0x0004)] public ImGuiWindow* DockTargetWindow;
	[FieldOffset(0x0008)] public ImGuiDockNode* DockTargetNode;
	[FieldOffset(0x000C)] public ImGuiWindow* DockPayload;
	[FieldOffset(0x0010)] public ImGuiDir DockSplitDir;
	[FieldOffset(0x0014)] public float DockSplitRatio;
	[FieldOffset(0x0018)] public byte DockSplitOuter;
	[FieldOffset(0x001C)] public ImGuiWindow* UndockTargetWindow;
	[FieldOffset(0x0020)] public ImGuiDockNode* UndockTargetNode;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0024)]
public unsafe partial struct ImGuiDockNodeSettings {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public uint ParentNodeId;
	[FieldOffset(0x0008)] public uint ParentWindowId;
	[FieldOffset(0x000C)] public uint SelectedTabId;
	[FieldOffset(0x0010)] public sbyte SplitAxis;
	[FieldOffset(0x0011)] public byte Depth;
	[FieldOffset(0x0014)] public int Flags;
	[FieldOffset(0x0018)] public ImVec2ih Pos;
	[FieldOffset(0x001C)] public ImVec2ih Size;
	[FieldOffset(0x0020)] public ImVec2ih SizeRef;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct ImVec2ih {
	[FieldOffset(0x0000)] public short x;
	[FieldOffset(0x0002)] public short y;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0024)]
public unsafe partial struct ImGuiSettingsHandler {
	[FieldOffset(0x0000)] public byte* TypeName;
	[FieldOffset(0x0004)] public uint TypeHash;
	[FieldOffset(0x0008)] public void** ClearAllFn;
	[FieldOffset(0x000C)] public void** ReadInitFn;
	[FieldOffset(0x0010)] public void** ReadOpenFn;
	[FieldOffset(0x0014)] public void** ReadLineFn;
	[FieldOffset(0x0018)] public void** ApplyAllFn;
	[FieldOffset(0x001C)] public void** WriteAllFn;
	[FieldOffset(0x0020)] public void* UserData;
}
[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImChunkStream<T> where T : unmanaged {
	public ImVector<char> Buf;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0014)]
public unsafe partial struct ImGuiContextHook {
	[FieldOffset(0x0000)] public uint HookId;
	[FieldOffset(0x0004)] public ImGuiContextHookType Type;
	[FieldOffset(0x0008)] public uint Owner;
	[FieldOffset(0x000C)] public void** Callback;
	[FieldOffset(0x0010)] public void* UserData;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct _iobuf {
	[FieldOffset(0x0000)] public void* _Placeholder;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiTextIndex {
	[FieldOffset(0x0000)] public ImVector<int> LineOffsets;
	[FieldOffset(0x000C)] public int EndOffset;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x001C)]
public unsafe partial struct ImGuiMetricsConfig {
	[FieldOffset(0x0000)] public byte ShowDebugLog;
	[FieldOffset(0x0001)] public byte ShowIDStackTool;
	[FieldOffset(0x0002)] public byte ShowWindowsRects;
	[FieldOffset(0x0003)] public byte ShowWindowsBeginOrder;
	[FieldOffset(0x0004)] public byte ShowTablesRects;
	[FieldOffset(0x0005)] public byte ShowDrawCmdMesh;
	[FieldOffset(0x0006)] public byte ShowDrawCmdBoundingBoxes;
	[FieldOffset(0x0007)] public byte ShowTextEncodingViewer;
	[FieldOffset(0x0008)] public byte ShowDockingNodes;
	[FieldOffset(0x000C)] public int ShowWindowsRectsType;
	[FieldOffset(0x0010)] public int ShowTablesRectsType;
	[FieldOffset(0x0014)] public int HighlightMonitorIdx;
	[FieldOffset(0x0018)] public uint HighlightViewportID;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x002C)]
public unsafe partial struct ImGuiIDStackTool {
	[FieldOffset(0x0000)] public int LastActiveFrame;
	[FieldOffset(0x0004)] public int StackLevel;
	[FieldOffset(0x0008)] public uint QueryId;
	[FieldOffset(0x000C)] public ImVector<ImGuiStackLevelInfo> Results;
	[FieldOffset(0x0018)] public byte CopyToClipboardOnCtrlC;
	[FieldOffset(0x001C)] public float CopyToClipboardLastTime;
	[FieldOffset(0x0020)] public ImGuiTextBuffer ResultPathBuf;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0048)]
public unsafe partial struct ImGuiStackLevelInfo {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public sbyte QueryFrameCount;
	[FieldOffset(0x0005)] public byte QuerySuccess;
	[FieldOffset(0x0008)] public int DataType;
	[FieldOffset(0x000C)] public byte /* byte [57] */ Desc;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x003C)]
public unsafe partial struct ImGuiDebugAllocInfo {
	[FieldOffset(0x0000)] public int TotalAllocCount;
	[FieldOffset(0x0004)] public int TotalFreeCount;
	[FieldOffset(0x0008)] public short LastEntriesIdx;
	[FieldOffset(0x000C)] public byte /* ImGuiDebugAllocEntry [6] */ LastEntriesBuf;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiDebugAllocEntry {
	[FieldOffset(0x0000)] public int FrameCount;
	[FieldOffset(0x0004)] public short AllocCount;
	[FieldOffset(0x0006)] public short FreeCount;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x00F0)]
public unsafe partial struct ImGuiWindowTempData {
	[FieldOffset(0x0000)] public Vector2 CursorPos;
	[FieldOffset(0x0008)] public Vector2 CursorPosPrevLine;
	[FieldOffset(0x0010)] public Vector2 CursorStartPos;
	[FieldOffset(0x0018)] public Vector2 CursorMaxPos;
	[FieldOffset(0x0020)] public Vector2 IdealMaxPos;
	[FieldOffset(0x0028)] public Vector2 CurrLineSize;
	[FieldOffset(0x0030)] public Vector2 PrevLineSize;
	[FieldOffset(0x0038)] public float CurrLineTextBaseOffset;
	[FieldOffset(0x003C)] public float PrevLineTextBaseOffset;
	[FieldOffset(0x0040)] public byte IsSameLine;
	[FieldOffset(0x0041)] public byte IsSetPos;
	[FieldOffset(0x0044)] public ImVec1 Indent;
	[FieldOffset(0x0048)] public ImVec1 ColumnsOffset;
	[FieldOffset(0x004C)] public ImVec1 GroupOffset;
	[FieldOffset(0x0050)] public Vector2 CursorStartPosLossyness;
	[FieldOffset(0x0058)] public ImGuiNavLayer NavLayerCurrent;
	[FieldOffset(0x005C)] public short NavLayersActiveMask;
	[FieldOffset(0x005E)] public short NavLayersActiveMaskNext;
	[FieldOffset(0x0060)] public byte NavIsScrollPushableX;
	[FieldOffset(0x0061)] public byte NavHideHighlightOneFrame;
	[FieldOffset(0x0062)] public byte NavWindowHasScrollY;
	[FieldOffset(0x0063)] public byte MenuBarAppending;
	[FieldOffset(0x0064)] public Vector2 MenuBarOffset;
	[FieldOffset(0x006C)] public ImGuiMenuColumns MenuColumns;
	[FieldOffset(0x0088)] public int TreeDepth;
	[FieldOffset(0x008C)] public uint TreeHasStackDataDepthMask;
	[FieldOffset(0x0090)] public ImVector<ImGuiWindow> ChildWindows;
	[FieldOffset(0x009C)] public ImGuiStorage* StateStorage;
	[FieldOffset(0x00A0)] public ImGuiOldColumns* CurrentColumns;
	[FieldOffset(0x00A4)] public int CurrentTableIdx;
	[FieldOffset(0x00A8)] public int LayoutType;
	[FieldOffset(0x00AC)] public int ParentLayoutType;
	[FieldOffset(0x00B0)] public uint ModalDimBgColor;
	[FieldOffset(0x00B4)] public int WindowItemStatusFlags;
	[FieldOffset(0x00B8)] public int ChildItemStatusFlags;
	[FieldOffset(0x00BC)] public int DockTabItemStatusFlags;
	[FieldOffset(0x00C0)] public ImRect DockTabItemRect;
	[FieldOffset(0x00D0)] public float ItemWidth;
	[FieldOffset(0x00D4)] public float TextWrapPos;
	[FieldOffset(0x00D8)] public ImVector<float> ItemWidthStack;
	[FieldOffset(0x00E4)] public ImVector<float> TextWrapPosStack;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x001C)]
public unsafe partial struct ImGuiMenuColumns {
	[FieldOffset(0x0000)] public uint TotalWidth;
	[FieldOffset(0x0004)] public uint NextTotalWidth;
	[FieldOffset(0x0008)] public ushort Spacing;
	[FieldOffset(0x000A)] public ushort OffsetIcon;
	[FieldOffset(0x000C)] public ushort OffsetLabel;
	[FieldOffset(0x000E)] public ushort OffsetShortcut;
	[FieldOffset(0x0010)] public ushort OffsetMark;
	[FieldOffset(0x0012)] public byte /* ushort [4] */ Widths;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x007C)]
public unsafe partial struct ImGuiOldColumns {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int Flags;
	[FieldOffset(0x0008)] public byte IsFirstFrame;
	[FieldOffset(0x0009)] public byte IsBeingResized;
	[FieldOffset(0x000C)] public int Current;
	[FieldOffset(0x0010)] public int Count;
	[FieldOffset(0x0014)] public float OffMinX;
	[FieldOffset(0x0018)] public float OffMaxX;
	[FieldOffset(0x001C)] public float LineMinY;
	[FieldOffset(0x0020)] public float LineMaxY;
	[FieldOffset(0x0024)] public float HostCursorPosY;
	[FieldOffset(0x0028)] public float HostCursorMaxPosX;
	[FieldOffset(0x002C)] public ImRect HostInitialClipRect;
	[FieldOffset(0x003C)] public ImRect HostBackupClipRect;
	[FieldOffset(0x004C)] public ImRect HostBackupParentWorkRect;
	[FieldOffset(0x005C)] public ImVector<ImGuiOldColumnData> Columns;
	[FieldOffset(0x0068)] public ImDrawListSplitter Splitter;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x001C)]
public unsafe partial struct ImGuiOldColumnData {
	[FieldOffset(0x0000)] public float OffsetNorm;
	[FieldOffset(0x0004)] public float OffsetNormBeforeResize;
	[FieldOffset(0x0008)] public int Flags;
	[FieldOffset(0x000C)] public ImRect ClipRect;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0020)]
public unsafe partial struct ImGuiWindowDockStyle {
	[FieldOffset(0x0000)] public byte /* uint [8] */ Colors;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0034)]
public unsafe partial struct ImGuiInputTextCallbackData {
	[FieldOffset(0x0000)] public ImGuiContext* Ctx;
	[FieldOffset(0x0004)] public int EventFlag;
	[FieldOffset(0x0008)] public int Flags;
	[FieldOffset(0x000C)] public void* UserData;
	[FieldOffset(0x0010)] public ushort EventChar;
	[FieldOffset(0x0014)] public ImGuiKey EventKey;
	[FieldOffset(0x0018)] public byte* Buf;
	[FieldOffset(0x001C)] public int BufTextLen;
	[FieldOffset(0x0020)] public int BufSize;
	[FieldOffset(0x0024)] public byte BufDirty;
	[FieldOffset(0x0028)] public int CursorPos;
	[FieldOffset(0x002C)] public int SelectionStart;
	[FieldOffset(0x0030)] public int SelectionEnd;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0020)]
public unsafe partial struct ImGuiSelectionBasicStorage {
	[FieldOffset(0x0000)] public int Size;
	[FieldOffset(0x0004)] public byte PreserveOrder;
	[FieldOffset(0x0008)] public void* UserData;
	[FieldOffset(0x000C)] public void** AdapterIndexToStorageId;
	[FieldOffset(0x0010)] public int _SelectionOrder;
	[FieldOffset(0x0014)] public ImGuiStorage _Storage;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiSelectionExternalStorage {
	[FieldOffset(0x0000)] public void* UserData;
	[FieldOffset(0x0004)] public void** AdapterSetItemSelected;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0110)]
public unsafe partial struct ImGuiTextFilter {
	[FieldOffset(0x0000)] public byte /* byte [256] */ InputBuf;
	[FieldOffset(0x0100)] public ImVector<ImGuiTextFilter__ImGuiTextRange> Filters;
	[FieldOffset(0x010C)] public int CountGrep;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiTextFilter__ImGuiTextRange {
	[FieldOffset(0x0000)] public byte* b;
	[FieldOffset(0x0004)] public byte* e;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x000C)]
public unsafe partial struct ImFontGlyphRangesBuilder {
	[FieldOffset(0x0000)] public ImVector<uint> UsedChars;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0024)]
public unsafe partial struct ImGuiWindowSettings {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public ImVec2ih Pos;
	[FieldOffset(0x0008)] public ImVec2ih Size;
	[FieldOffset(0x000C)] public ImVec2ih ViewportPos;
	[FieldOffset(0x0010)] public uint ViewportId;
	[FieldOffset(0x0014)] public uint DockId;
	[FieldOffset(0x0018)] public uint ClassId;
	[FieldOffset(0x001C)] public short DockOrder;
	[FieldOffset(0x001E)] public byte Collapsed;
	[FieldOffset(0x001F)] public byte IsChild;
	[FieldOffset(0x0020)] public byte WantApply;
	[FieldOffset(0x0021)] public byte WantDelete;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0010)]
public unsafe partial struct ImGuiDataTypeInfo {
	[FieldOffset(0x0000)] public uint Size;
	[FieldOffset(0x0004)] public byte* Name;
	[FieldOffset(0x0008)] public byte* PrintFmt;
	[FieldOffset(0x000C)] public byte* ScanFmt;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0014)]
public unsafe partial struct ImGuiTableSettings {
	[FieldOffset(0x0000)] public uint ID;
	[FieldOffset(0x0004)] public int SaveFlags;
	[FieldOffset(0x0008)] public float RefScale;
	[FieldOffset(0x000C)] public short ColumnsCount;
	[FieldOffset(0x000E)] public short ColumnsCountMax;
	[FieldOffset(0x0010)] public byte WantApply;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct ImGuiStyleVarInfo {
	[FieldOffset(0x0000)] public uint Count;
	[FieldOffset(0x0000)] public int DataType;
	[FieldOffset(0x0000)] public uint Offset;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct IDirect3DDevice9 {
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0004)]
public unsafe partial struct HWND__ {
	[FieldOffset(0x0000)] public int unused;
}
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x0008)]
public unsafe partial struct ImGuiLocEntry {
	[FieldOffset(0x0000)] public ImGuiLocKey Key;
	[FieldOffset(0x0004)] public byte* Text;
}
