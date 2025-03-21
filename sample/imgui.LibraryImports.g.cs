[LibraryImport("imgui.dll", EntryPoint = "ImGui_AcceptDragDropPayload"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiPayload* ImGui_AcceptDragDropPayload(byte* type, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ActivateItemByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ActivateItemByID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Add"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_Add(ImRect* _this, ImRect* r);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Add0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_Add(ImRect* _this, Vector2* p);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddBezierCubic"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddBezierCubic(ImDrawList* _this, Vector2* p1, Vector2* p2, Vector2* p3, Vector2* p4, uint col, float thickness, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddBezierQuadratic"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddBezierQuadratic(ImDrawList* _this, Vector2* p1, Vector2* p2, Vector2* p3, uint col, float thickness, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddCallback"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddCallback(ImDrawList* _this, void** callback, void* userdata, uint userdata_size);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddCircle"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddCircle(ImDrawList* _this, Vector2* center, float radius, uint col, int num_segments, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddCircleFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddCircleFilled(ImDrawList* _this, Vector2* center, float radius, uint col, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddConcavePolyFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddConcavePolyFilled(ImDrawList* _this, Vector2* points, int points_count, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_AddContextHook"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_AddContextHook(ImGuiContext* ctx, ImGuiContextHook* hook);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddConvexPolyFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddConvexPolyFilled(ImDrawList* _this, Vector2* points, int points_count, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddCustomRectFontGlyph"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* _this, ImFont* font, ushort id, int width, int height, float advance_x, Vector2* offset);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddCustomRectRegular"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* _this, int width, int height);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddDrawCmd"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddDrawCmd(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawData_AddDrawList"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawData_AddDrawList(ImDrawData* _this, ImDrawList* draw_list);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_AddDrawListToDrawDataEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_AddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector<ImDrawList>* out_list, ImDrawList* draw_list);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddEllipse"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddEllipse(ImDrawList* _this, Vector2* center, Vector2* radius, uint col, float rot, int num_segments, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddEllipseFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddEllipseFilled(ImDrawList* _this, Vector2* center, Vector2* radius, uint col, float rot, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddFocusEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddFocusEvent(ImGuiIO* _this, byte focused);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddFont"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFont* ImFontAtlas_AddFont(ImFontAtlas* _this, ImFontConfig* font_cfg);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddFontDefault"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* _this, ImFontConfig* font_cfg_template);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddFontFromFileTTF"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* _this, byte* filename, float size_pixels, ImFontConfig* font_cfg_template, ushort* glyph_ranges);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedBase85TTF"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* _this, byte* compressed_ttf_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedTTF"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* _this, void* compressed_ttf_data, int compressed_ttf_size, float size_pixels, ImFontConfig* font_cfg_template, ushort* glyph_ranges);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_AddFontFromMemoryTTF"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* _this, void* font_data, int font_data_size, float size_pixels, ImFontConfig* font_cfg_template, ushort* glyph_ranges);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_AddGlyph"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFont_AddGlyph(ImFont* _this, ImFontConfig* src, ushort codepoint, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddImage"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddImage(ImDrawList* _this, ulong user_texture_id, Vector2* p_min, Vector2* p_max, Vector2* uv_min, Vector2* uv_max, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddImageQuad"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddImageQuad(ImDrawList* _this, ulong user_texture_id, Vector2* p1, Vector2* p2, Vector2* p3, Vector2* p4, Vector2* uv1, Vector2* uv2, Vector2* uv3, Vector2* uv4, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddImageRounded"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddImageRounded(ImDrawList* _this, ulong user_texture_id, Vector2* p_min, Vector2* p_max, Vector2* uv_min, Vector2* uv_max, uint col, float rounding, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddInputCharacter"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddInputCharacter(ImGuiIO* _this, uint c);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddInputCharacterUTF16"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* _this, ushort c);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddInputCharactersUTF8"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* _this, byte* utf8_chars);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddKeyAnalogEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* _this, ImGuiKey key, byte down, float analog_value);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddKeyEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddKeyEvent(ImGuiIO* _this, ImGuiKey key, byte down);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddLine"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddLine(ImDrawList* _this, Vector2* p1, Vector2* p2, uint col, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddMouseButtonEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddMouseButtonEvent(ImGuiIO* _this, int mouse_button, byte down);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddMousePosEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddMousePosEvent(ImGuiIO* _this, float x, float y);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddMouseSourceEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddMouseSourceEvent(ImGuiIO* _this, ImGuiMouseSource source);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddMouseViewportEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddMouseViewportEvent(ImGuiIO* _this, uint viewport_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_AddMouseWheelEvent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_AddMouseWheelEvent(ImGuiIO* _this, float wheel_x, float wheel_y);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddNgon"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddNgon(ImDrawList* _this, Vector2* center, float radius, uint col, int num_segments, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddNgonFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddNgonFilled(ImDrawList* _this, Vector2* center, float radius, uint col, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddPolyline"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddPolyline(ImDrawList* _this, Vector2* points, int points_count, uint col, int flags, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddQuad"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddQuad(ImDrawList* _this, Vector2* p1, Vector2* p2, Vector2* p3, Vector2* p4, uint col, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddQuadFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddQuadFilled(ImDrawList* _this, Vector2* p1, Vector2* p2, Vector2* p3, Vector2* p4, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImFontGlyphRangesBuilder_AddRanges"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* _this, ushort* ranges);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddRect(ImDrawList* _this, Vector2* p_min, Vector2* p_max, uint col, float rounding, int flags, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddRectFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddRectFilled(ImDrawList* _this, Vector2* p_min, Vector2* p_max, uint col, float rounding, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddRectFilledMultiColor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddRectFilledMultiColor(ImDrawList* _this, Vector2* p_min, Vector2* p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_AddRemapChar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFont_AddRemapChar(ImFont* _this, ushort dst, ushort src, byte overwrite_dst);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_AddSettingsHandler"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_AddSettingsHandler(ImGuiSettingsHandler* handler);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddText(ImDrawList* _this, Vector2* pos, uint col, byte* text_begin, byte* text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddText0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddText(ImDrawList* _this, ImFont* font, float font_size, Vector2* pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImFontGlyphRangesBuilder_AddText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* _this, byte* text, byte* text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddTriangle"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddTriangle(ImDrawList* _this, Vector2* p1, Vector2* p2, Vector2* p3, uint col, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_AddTriangleFilled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_AddTriangleFilled(ImDrawList* _this, Vector2* p1, Vector2* p2, Vector2* p3, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_AlignTextToFramePadding"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_AlignTextToFramePadding();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiSelectionBasicStorage_ApplyRequests"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* _this, ImGuiMultiSelectIO* ms_io);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiSelectionExternalStorage_ApplyRequests"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* _this, ImGuiMultiSelectIO* ms_io);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ArrowButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ArrowButton(byte* str_id, ImGuiDir dir);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ArrowButtonEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Begin"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Begin(byte* name, byte* p_open, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiListClipper_Begin"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiListClipper_Begin(ImGuiListClipper* _this, int items_count, float items_height);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginBoxSelect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginBoxSelect(ImRect* scope_rect, ImGuiWindow* window, uint box_select_id, int ms_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginChild"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginChild(uint id, Vector2* size_arg, int child_flags, int window_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginChild0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginChild(byte* str_id, Vector2* size_arg, int child_flags, int window_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginChildEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginChildEx(byte* name, uint id, Vector2* size_arg, int child_flags, int window_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginColumns"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BeginColumns(byte* str_id, int columns_count, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginCombo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginCombo(byte* label, byte* preview_value, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginComboPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginComboPopup(uint popup_id, ImRect* bb, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginComboPreview"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginComboPreview();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDisabled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BeginDisabled(byte disabled);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDisabledOverrideReenable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BeginDisabledOverrideReenable();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDockableDragDropSource"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BeginDockableDragDropSource(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDockableDragDropTarget"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BeginDockableDragDropTarget(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDocked"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BeginDocked(ImGuiWindow* window, byte* p_open);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDragDropSource"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginDragDropSource(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDragDropTarget"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginDragDropTarget();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginDragDropTargetCustom"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginDragDropTargetCustom(ImRect* bb, uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginErrorTooltip"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginErrorTooltip();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginGroup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BeginGroup();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginItemTooltip"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginItemTooltip();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginListBox"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginListBox(byte* label, Vector2* size_arg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginMainMenuBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginMainMenuBar();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginMenu"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginMenu(byte* label, byte enabled);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginMenuBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginMenuBar();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginMenuEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginMenuEx(byte* label, byte* icon, byte enabled);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginMultiSelect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiMultiSelectIO* ImGui_BeginMultiSelect(int flags, int selection_size, int items_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginPopup(byte* str_id, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginPopupContextItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginPopupContextItem(byte* str_id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginPopupContextVoid"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginPopupContextVoid(byte* str_id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginPopupContextWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginPopupContextWindow(byte* str_id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginPopupEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginPopupEx(uint id, int extra_window_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginPopupMenuEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginPopupMenuEx(uint id, byte* label, int extra_window_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginPopupModal"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginPopupModal(byte* name, byte* p_open, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTabBar(byte* str_id, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTabBarEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTabBarEx(ImGuiTabBar* tab_bar, ImRect* tab_bar_bb, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTabItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTabItem(byte* label, byte* p_open, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTable(byte* str_id, int columns_count, int flags, Vector2* outer_size, float inner_width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTableEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTableEx(byte* name, uint id, int columns_count, int flags, Vector2* outer_size, float inner_width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTooltip"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTooltip();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTooltipEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTooltipEx(int tooltip_flags, int extra_window_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginTooltipHidden"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginTooltipHidden();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BeginViewportSideBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_BeginViewportSideBar(byte* name, ImGuiViewport* viewport_p, ImGuiDir dir, float axis_size, int window_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BringWindowToDisplayBack"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BringWindowToDisplayBack(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BringWindowToDisplayBehind"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* behind_window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BringWindowToDisplayFront"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BringWindowToDisplayFront(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BringWindowToFocusFront"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BringWindowToFocusFront(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_Build"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImFontAtlas_Build(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiTextFilter_Build"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiTextFilter_Build(ImGuiTextFilter* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_BuildLookupTable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFont_BuildLookupTable(ImFont* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontGlyphRangesBuilder_BuildRanges"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* _this, ImVector<ushort>* out_ranges);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_BuildSortByKey"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiStorage_BuildSortByKey(ImGuiStorage* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Bullet"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Bullet();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_BulletTextV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_BulletTextV(byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Button"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Button(byte* label, Vector2* size_arg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ButtonBehavior"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ButtonBehavior(ImRect* bb, uint id, byte* out_hovered, byte* out_held, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ButtonEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ButtonEx(byte* label, Vector2* size_arg, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_CalcCustomRectUV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* _this, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_CalcFontSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGuiWindow_CalcFontSize(ImGuiWindow* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CalcItemSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_CalcItemSize(Vector2* pRetVal, Vector2 size, float default_w, float default_h);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CalcItemWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_CalcItemWidth();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiMenuColumns_CalcNextTotalWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* _this, byte update_offsets);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CalcRoundingFlagsForRectInRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_CalcRoundingFlagsForRectInRect(ImRect* r_in, ImRect* r_outer, float threshold);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CalcTextSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_CalcTextSize(Vector2* pRetVal, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_CalcTextSizeA"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImFont_CalcTextSizeA(Vector2* pRetVal, ImFont* _this, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CalcTypematicRepeatAmount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CalcWindowNextAutoFitSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_CalcWindowNextAutoFitSize(Vector2* pRetVal, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_CalcWordWrapPositionA"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImFont_CalcWordWrapPositionA(ImFont* _this, float scale, byte* text, byte* text_end, float wrap_width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CalcWrapWidthForPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_CalcWrapWidthForPos(Vector2* pos, float wrap_pos_x);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CallContextHooks"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_CallContextHooks(ImGuiContext* ctx, ImGuiContextHookType hook_type);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Checkbox"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Checkbox(byte* label, byte* v);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CheckboxFlags"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CheckboxFlags(byte* label, int* flags, int flags_value);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CheckboxFlags0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CheckboxFlags(byte* label, uint* flags, uint flags_value);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CheckboxFlags1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CheckboxFlags(byte* label, long* flags, long flags_value);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CheckboxFlags2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CheckboxFlags(byte* label, ulong* flags, ulong flags_value);
[LibraryImport("imgui.dll", EntryPoint = "ImBitVector_Clear"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImBitVector_Clear(ImBitVector* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawData_Clear"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawData_Clear(ImDrawData* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_Clear"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlas_Clear(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiMultiSelectTempData_Clear"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiMultiSelectTempData_Clear(ImGuiMultiSelectTempData* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiSelectionBasicStorage_Clear"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiTypingSelectState_Clear"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiTypingSelectState_Clear(ImGuiTypingSelectState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ClearActiveID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ClearActiveID();
[LibraryImport("imgui.dll", EntryPoint = "ImBitVector_ClearBit"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImBitVector_ClearBit(ImBitVector* _this, int n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ClearDragDrop"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ClearDragDrop();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_ClearEventsQueue"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_ClearEventsQueue(ImGuiIO* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_ClearFonts"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlas_ClearFonts(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawListSplitter_ClearFreeMemory"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextDeactivatedState_ClearFreeMemory"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_ClearFreeMemory"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiMultiSelectTempData_ClearIO"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiMultiSelectTempData_ClearIO(ImGuiMultiSelectTempData* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ClearIniSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ClearIniSettings();
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_ClearInputData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlas_ClearInputData(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_ClearInputKeys"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_ClearInputKeys(ImGuiIO* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_ClearInputMouse"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_ClearInputMouse(ImGuiIO* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_ClearOutputData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFont_ClearOutputData(ImFont* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_ClearSelection"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_ClearTexData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlas_ClearTexData(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_ClearText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_ClearText(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ClearWindowSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ClearWindowSettings(byte* name);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_ClipWith"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_ClipWith(ImRect* _this, ImRect* r);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_ClipWithFull"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_ClipWithFull(ImRect* _this, ImRect* r);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_CloneOutput"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImDrawList* ImDrawList_CloneOutput(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CloseButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CloseButton(uint id, Vector2* pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CloseCurrentPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_CloseCurrentPopup();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ClosePopupToLevel"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ClosePopupsExceptModals"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ClosePopupsExceptModals();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ClosePopupsOverWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CollapseButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CollapseButton(uint id, Vector2* pos, ImGuiDockNode* dock_node);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CollapsingHeader"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CollapsingHeader(byte* label, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CollapsingHeader0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_CollapsingHeader(byte* label, byte* p_visible, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ColorButton(byte* desc_id, Vector4* col, int flags, Vector2* size_arg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorConvertFloat4ToU32"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_ColorConvertFloat4ToU32(Vector4* _in);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorConvertHSVtoRGB"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorConvertRGBtoHSV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorConvertU32ToFloat4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector4* ImGui_ColorConvertU32ToFloat4(Vector4* pRetVal, uint _in);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorEdit3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ColorEdit3(byte* label, float* col, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorEdit4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ColorEdit4(byte* label, float* col, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorEditOptionsPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ColorEditOptionsPopup(float* col, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorPicker3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ColorPicker3(byte* label, float* col, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorPicker4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ColorPicker4(byte* label, float* col, int flags, float* ref_col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorPickerOptionsPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ColorPickerOptionsPopup(float* ref_col, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ColorTooltip"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ColorTooltip(byte* text, float* col, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Columns"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Columns(int columns_count, byte* id, byte borders);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Combo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Combo(byte* label, int* current_item, byte* items_separated_by_zeros, int height_in_items);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Combo0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Combo(byte* label, int* current_item, void** getter, void* user_data, int items_count, int popup_max_height_in_items);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Combo1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Combo(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiSelectionBasicStorage_Contains"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiSelectionBasicStorage_Contains(ImGuiSelectionBasicStorage* _this, uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Contains"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImRect_Contains(ImRect* _this, ImRect* r);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Contains0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImRect_Contains(ImRect* _this, Vector2* p);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_ContainsWithPad"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImRect_ContainsWithPad(ImRect* _this, Vector2* p, Vector2* pad);
[LibraryImport("imgui.dll", EntryPoint = "ImBitVector_Create"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImBitVector_Create(ImBitVector* _this, int sz);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CreateContext"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiContext* ImGui_CreateContext(ImFontAtlas* shared_font_atlas);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_CreateNewWindowSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindowSettings* ImGui_CreateNewWindowSettings(byte* name);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_CursorAnimReset"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_CursorClamp"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DataTypeApplyFromText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DataTypeApplyFromText(byte* buf, int data_type, void* p_data, byte* format, void* p_data_when_empty);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DataTypeApplyOp"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DataTypeApplyOp(int data_type, int op, void* output, void* arg1, void* arg2);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DataTypeClamp"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DataTypeClamp(int data_type, void* p_data, void* p_min, void* p_max);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DataTypeCompare"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_DataTypeCompare(int data_type, void* arg_1, void* arg_2);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DataTypeFormatString"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_DataTypeFormatString(byte* buf, int buf_size, int data_type, void* p_data, byte* format);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DataTypeGetInfo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiDataTypeInfo* ImGui_DataTypeGetInfo(int data_type);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DataTypeIsZero"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DataTypeIsZero(int data_type, void* p_data);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawData_DeIndexAllBuffers"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawData_DeIndexAllBuffers(ImDrawData* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugAllocHook"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, uint size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugCheckVersionAndDataLayout"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DebugCheckVersionAndDataLayout(byte* version, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_vert, uint sz_idx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugHookIdInfo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugHookIdInfo(uint __formal, int __formal0, void* __formal1, void* __formal2);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeColumns"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeColumns(ImGuiOldColumns* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeDrawCmdShowMeshAndBoundingBox"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* __formal, ImDrawList* __formal0, ImDrawCmd* __formal1, byte __formal2, byte __formal3);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeDrawList"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeDrawList(ImGuiWindow* __formal, ImGuiViewportP* __formal0, ImDrawList* __formal1, byte* __formal2);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeFont"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeFont(ImFont* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeInputTextState"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeInputTextState(ImGuiInputTextState* state);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeMultiSelectState"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeMultiSelectState(ImGuiMultiSelectState* storage);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeStorage"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeStorage(ImGuiStorage* __formal, byte* __formal0);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeTabBar(ImGuiTabBar* __formal, byte* __formal0);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeTable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeTable(ImGuiTable* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeTableSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeTableSettings(ImGuiTableSettings* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeTypingSelectState"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeTypingSelectState(ImGuiTypingSelectState* data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeViewport(ImGuiViewportP* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeWindow(ImGuiWindow* __formal, byte* __formal0);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeWindowSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeWindowSettings(ImGuiWindowSettings* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugNodeWindowsList"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugNodeWindowsList(ImVector<ImGuiWindow>* __formal, byte* __formal0);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DebugStartItemPicker"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DebugStartItemPicker();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiMenuColumns_DeclColumns"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* _this, float w_icon, float w_label, float w_shortcut, float w_mark);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextCallbackData_DeleteChars"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* _this, int pos, int bytes_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DestroyContext"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DestroyContext(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DestroyPlatformWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DestroyPlatformWindow(ImGuiViewportP* viewport);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DestroyPlatformWindows"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DestroyPlatformWindows();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderAddNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_DockBuilderAddNode(uint node_id, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderCopyDockSpace"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector<byte>* in_window_remap_pairs);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderCopyNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector<uint>* out_node_remap_pairs);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderCopyWindowSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderCopyWindowSettings(byte* src_name, byte* dst_name);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderDockWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderDockWindow(byte* window_name, uint node_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderFinish"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderFinish(uint root_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderGetNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiDockNode* ImGui_DockBuilderGetNode(uint node_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderRemoveNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderRemoveNode(uint node_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderRemoveNodeChildNodes"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderRemoveNodeChildNodes(uint root_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderRemoveNodeDockedWindows"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderRemoveNodeDockedWindows(uint root_id, byte clear_settings_refs);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderSetNodePos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderSetNodePos(uint node_id, Vector2 pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderSetNodeSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockBuilderSetNodeSize(uint node_id, Vector2 size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockBuilderSplitNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_DockBuilderSplitNode(uint id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, uint* out_id_at_dir, uint* out_id_at_opposite_dir);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextCalcDropPosForDocking"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, byte split_outer, Vector2* out_pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextClearNodes"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextClearNodes(ImGuiContext* ctx, uint root_id, byte clear_settings_refs);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextEndFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextEndFrame(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextFindNodeByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiDockNode* ImGui_DockContextFindNodeByID(ImGuiContext* ctx, uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextGenNodeID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_DockContextGenNodeID(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextInitialize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextInitialize(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextNewFrameUpdateDocking"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextNewFrameUpdateDocking(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextNewFrameUpdateUndocking"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextNewFrameUpdateUndocking(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextProcessUndockNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextProcessUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextProcessUndockWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextProcessUndockWindow(ImGuiContext* ctx, ImGuiWindow* window, byte clear_persistent_docking_ref);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextQueueDock"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextQueueDock(ImGuiContext* ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, byte split_outer);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextQueueUndockNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextQueueUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextQueueUndockWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextQueueUndockWindow(ImGuiContext* ctx, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextRebuildNodes"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextRebuildNodes(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockContextShutdown"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockContextShutdown(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockNodeBeginAmendTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DockNodeBeginAmendTabBar(ImGuiDockNode* node);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockNodeEndAmendTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockNodeEndAmendTabBar();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockNodeWindowMenuHandler_Default"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_DockNodeWindowMenuHandler_Default(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockSpace"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_DockSpace(uint dockspace_id, Vector2* size_arg, int flags, ImGuiWindowClass* window_class);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DockSpaceOverViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_DockSpaceOverViewport(uint dockspace_id, ImGuiViewport* viewport, int dockspace_flags, ImGuiWindowClass* window_class);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragBehavior"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragBehavior(uint id, int data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragFloat2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragFloat2(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragFloat3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragFloat3(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragFloat4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragFloat4(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragFloat"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragFloatRange2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragInt2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragInt3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragInt4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragInt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragIntRange2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragScalar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragScalar(byte* label, int data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_DragScalarN"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_DragScalarN(byte* label, int data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiTextFilter_Draw"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiTextFilter_Draw(ImGuiTextFilter* _this, byte* label, float width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Dummy"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Dummy(Vector2* size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_End"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_End();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiListClipper_End"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiListClipper_End(ImGuiListClipper* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndBoxSelect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndBoxSelect(ImRect* scope_rect, int ms_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndChild"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndChild();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndColumns"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndColumns();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndCombo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndCombo();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndComboPreview"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndComboPreview();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndDisabled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndDisabled();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndDisabledOverrideReenable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndDisabledOverrideReenable();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndDragDropSource"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndDragDropSource();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndDragDropTarget"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndDragDropTarget();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndErrorTooltip"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndErrorTooltip();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndFrame();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndGroup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndGroup();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndListBox"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndListBox();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndMainMenuBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndMainMenuBar();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndMenu"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndMenu();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndMenuBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndMenuBar();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndMultiSelect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiMultiSelectIO* ImGui_EndMultiSelect();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndPopup();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndTabBar();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndTabItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndTabItem();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndTable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndTable();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_EndTooltip"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_EndTooltip();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ErrorCheckEndFrameFinalizeErrorTooltip"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ErrorCheckEndFrameFinalizeErrorTooltip();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ErrorCheckUsingSetCursorPosToExtendParentBoundaries"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ErrorCheckUsingSetCursorPosToExtendParentBoundaries();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ErrorLog"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ErrorLog(byte* msg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ErrorRecoveryStoreState"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ErrorRecoveryTryToRecoverState"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryState* state_in);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ErrorRecoveryTryToRecoverWindowState"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryState* state_in);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Expand"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_Expand(ImRect* _this, Vector2* amount);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Expand0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_Expand(ImRect* _this, float amount);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindBestWindowPosForPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_FindBestWindowPosForPopup(Vector2* pRetVal, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindBestWindowPosForPopupEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_FindBestWindowPosForPopupEx(Vector2* pRetVal, Vector2* ref_pos, Vector2* size, ImGuiDir* last_dir, ImRect* r_outer, ImRect* r_avoid, ImGuiPopupPositionPolicy policy);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindBlockingModal"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindow* ImGui_FindBlockingModal(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindBottomMostVisibleWindowWithinBeginStack"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindow* ImGui_FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* parent_window);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_FindGlyph"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFontGlyph* ImFont_FindGlyph(ImFont* _this, ushort c);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_FindGlyphNoFallback"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* _this, ushort c);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindHoveredViewportFromPlatformWindowStack"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiViewportP* ImGui_FindHoveredViewportFromPlatformWindowStack(Vector2* mouse_platform_pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindHoveredWindowEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_FindHoveredWindowEx(Vector2* pos, byte find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindOrCreateColumns"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiOldColumns* ImGui_FindOrCreateColumns(ImGuiWindow* window, uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindRenderedTextEnd"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_FindRenderedTextEnd(byte* text, byte* text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindSettingsHandler"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiSettingsHandler* ImGui_FindSettingsHandler(byte* type_name);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindViewportByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiViewport* ImGui_FindViewportByID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindViewportByPlatformHandle"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiViewport* ImGui_FindViewportByPlatformHandle(void* platform_handle);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindWindowByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindow* ImGui_FindWindowByID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindWindowByName"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindow* ImGui_FindWindowByName(byte* name);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindWindowDisplayIndex"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_FindWindowDisplayIndex(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindWindowSettingsByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindowSettings* ImGui_FindWindowSettingsByID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FindWindowSettingsByWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindowSettings* ImGui_FindWindowSettingsByWindow(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Floor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_Floor(ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FocusItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_FocusItem();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FocusTopMostWindowUnderOne"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_FocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_FocusWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_FocusWindow(ImGuiWindow* window, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GcAwakeTransientWindowBuffers"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_GcAwakeTransientWindowBuffers(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GcCompactTransientMiscBuffers"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_GcCompactTransientMiscBuffers();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GcCompactTransientWindowBuffers"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_GcCompactTransientWindowBuffers(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetAllocatorFunctions"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_GetAllocatorFunctions(void*** p_alloc_func, void*** p_free_func, void** p_user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetArea"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImRect_GetArea(ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetBL"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImRect_GetBL(Vector2* pRetVal, ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetBR"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImRect_GetBR(Vector2* pRetVal, ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetBackgroundDrawList"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImDrawList* ImGui_GetBackgroundDrawList(ImGuiViewport* viewport);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetBool"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiStorage_GetBool(ImGuiStorage* _this, uint key, byte default_val);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetBoolRef"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGuiStorage_GetBoolRef(ImGuiStorage* _this, uint key, byte default_val);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetCenter"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImRect_GetCenter(Vector2* pRetVal, ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetClipboardText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_GetClipboardText();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColorU32"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetColorU32(Vector4* col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColorU320"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetColorU32(int idx, float alpha_mul);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColorU321"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetColorU32(uint col, float alpha_mul);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColumnIndex"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_GetColumnIndex();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColumnNormFromOffset"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColumnOffset"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetColumnOffset(int column_index);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColumnOffsetFromNorm"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColumnWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetColumnWidth(int column_index);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColumnsCount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_GetColumnsCount();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetColumnsID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetColumnsID(byte* str_id, int columns_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetContentRegionAvail"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetContentRegionAvail(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetCurrentContext"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiContext* ImGui_GetCurrentContext();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetCursorPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetCursorPos(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_GetCursorPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetCursorPosX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetCursorPosX();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetCursorPosY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetCursorPosY();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetCursorScreenPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetCursorScreenPos(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetCursorStartPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetCursorStartPos(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetDragDropPayload"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiPayload* ImGui_GetDragDropPayload();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetDrawData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImDrawData* ImGui_GetDrawData();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetDrawListSharedData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImDrawListSharedData* ImGui_GetDrawListSharedData();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetFloat"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGuiStorage_GetFloat(ImGuiStorage* _this, uint key, float default_val);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetFloatRef"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float* ImGuiStorage_GetFloatRef(ImGuiStorage* _this, uint key, float default_val);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetFont"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFont* ImGui_GetFont();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetFontSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetFontSize();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetFontTexUvWhitePixel"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetFontTexUvWhitePixel(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetForegroundDrawList"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImDrawList* ImGui_GetForegroundDrawList(ImGuiViewport* viewport);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetFrameCount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_GetFrameCount();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetFrameHeight"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetFrameHeight();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetFrameHeightWithSpacing"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetFrameHeightWithSpacing();
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesChineseFull"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesCyrillic"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesDefault"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesGreek"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesJapanese"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesKorean"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesThai"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetGlyphRangesVietnamese"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetHeight"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImRect_GetHeight(ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetHoveredID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetHoveredID();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetID(int int_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetID0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetID(byte* str_id_begin, byte* str_id_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetID1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetID(byte* str_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetID2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetID(void* ptr_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_GetID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGuiWindow_GetID(ImGuiWindow* _this, int n);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_GetID0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGuiWindow_GetID(ImGuiWindow* _this, byte* str, byte* str_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_GetID1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGuiWindow_GetID(ImGuiWindow* _this, void* ptr);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_GetIDFromPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGuiWindow_GetIDFromPos(ImGuiWindow* _this, Vector2* p_abs);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_GetIDFromRectangle"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* _this, ImRect* r_abs);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetIDWithSeed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetIDWithSeed(int n, uint seed);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetIDWithSeed0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetIDWithSeed(byte* str, byte* str_end, uint seed);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetIO"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiIO* ImGui_GetIO(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetIO0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiIO* ImGui_GetIO();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetInt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGuiStorage_GetInt(ImGuiStorage* _this, uint key, int default_val);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetIntRef"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int* ImGuiStorage_GetIntRef(ImGuiStorage* _this, uint key, int default_val);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetItemID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetItemID();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetItemRectMax"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetItemRectMax(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetItemRectMin"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetItemRectMin(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetItemRectSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetItemRectSize(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetKeyChordName"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_GetKeyChordName(int key_chord);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetKeyData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiKeyData* ImGui_GetKeyData(ImGuiContext* ctx, ImGuiKey key);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetKeyMagnitude2d"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetKeyMagnitude2d(Vector2* pRetVal, ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetKeyName"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_GetKeyName(ImGuiKey key);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetKeyOwner"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetKeyOwner(ImGuiKey key);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetKeyPressedAmount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float repeat_rate);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetMainViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiViewport* ImGui_GetMainViewport();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetMouseClickedCount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_GetMouseClickedCount(int button);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetMouseCursor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_GetMouseCursor();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetMouseDragDelta"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetMouseDragDelta(Vector2* pRetVal, int button, float lock_threshold);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetMousePos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetMousePos(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetMousePosOnOpeningCurrentPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetMousePosOnOpeningCurrentPopup(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetNavTweakPressedAmount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetNavTweakPressedAmount(ImGuiAxis axis);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiSelectionBasicStorage_GetNextSelectedItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* _this, void** opaque_it, uint* out_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetPlatformIO"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiPlatformIO* ImGui_GetPlatformIO(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetPlatformIO0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiPlatformIO* ImGui_GetPlatformIO();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetPopupAllowedExtentRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImRect* ImGui_GetPopupAllowedExtentRect(ImRect* pRetVal, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetScrollMaxX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetScrollMaxX();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetScrollMaxY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetScrollMaxY();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetScrollX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetScrollX();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetScrollY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetScrollY();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_GetSelectionEnd"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_GetSelectionStart"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetShortcutRoutingData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiKeyRoutingData* ImGui_GetShortcutRoutingData(int key_chord);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImRect_GetSize(Vector2* pRetVal, ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetStateStorage"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiStorage* ImGui_GetStateStorage();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetStyle"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiStyle* ImGui_GetStyle();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetStyleColorName"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_GetStyleColorName(int idx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetStyleColorVec4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector4* ImGui_GetStyleColorVec4(int idx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetStyleVarInfo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiStyleVarInfo* ImGui_GetStyleVarInfo(int idx);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetTL"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImRect_GetTL(Vector2* pRetVal, ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetTR"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImRect_GetTR(Vector2* pRetVal, ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetTexDataAsAlpha8"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* _this, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlas_GetTexDataAsRGBA32"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* _this, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTextLineHeight"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetTextLineHeight();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTextLineHeightWithSpacing"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetTextLineHeightWithSpacing();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTime"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial double ImGui_GetTime();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTopMostAndVisiblePopupModal"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindow* ImGui_GetTopMostAndVisiblePopupModal();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTopMostPopupModal"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiWindow* ImGui_GetTopMostPopupModal();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTreeNodeToLabelSpacing"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetTreeNodeToLabelSpacing();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTypematicRepeatRate"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_GetTypematicRepeatRate(int flags, float* repeat_delay, float* repeat_rate);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetTypingSelectRequest"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTypingSelectRequest* ImGui_GetTypingSelectRequest(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetVersion"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_GetVersion();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetViewportPlatformMonitor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiPlatformMonitor* ImGui_GetViewportPlatformMonitor(ImGuiViewport* viewport_p);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetVoidPtr"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void* ImGuiStorage_GetVoidPtr(ImGuiStorage* _this, uint key);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_GetVoidPtrRef"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* _this, uint key, void* default_val);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_GetWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImRect_GetWidth(ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowAlwaysWantOwnTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_GetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowDockID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetWindowDockID();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowDpiScale"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetWindowDpiScale();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowDrawList"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImDrawList* ImGui_GetWindowDrawList();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowHeight"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetWindowHeight();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetWindowPos(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowResizeBorderID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowResizeCornerID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetWindowResizeCornerID(ImGuiWindow* window, int n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowScrollbarID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_GetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowScrollbarRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImRect* ImGui_GetWindowScrollbarRect(ImRect* pRetVal, ImGuiWindow* window, ImGuiAxis axis);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_GetWindowSize(Vector2* pRetVal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiViewport* ImGui_GetWindowViewport();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_GetWindowWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_GetWindowWidth();
[LibraryImport("imgui.dll", EntryPoint = "ImFont_GrowIndex"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFont_GrowIndex(ImFont* _this, int new_size);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_HasSelection"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImAlphaBlendColorsX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImAlphaBlendColors(uint col_a, uint col_b);
[LibraryImport("imgui.dll", EntryPoint = "ImBezierCubicCalcX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImBezierCubicCalc(Vector2* pRetVal, Vector2* p1, Vector2* p2, Vector2* p3, Vector2* p4, float t);
[LibraryImport("imgui.dll", EntryPoint = "ImBezierCubicClosestPointX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImBezierCubicClosestPoint(Vector2* pRetVal, Vector2* p1, Vector2* p2, Vector2* p3, Vector2* p4, Vector2* p, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImBezierCubicClosestPointCasteljauX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImBezierCubicClosestPointCasteljau(Vector2* pRetVal, Vector2* p1, Vector2* p2, Vector2* p3, Vector2* p4, Vector2* p, float tess_tol);
[LibraryImport("imgui.dll", EntryPoint = "ImBezierQuadraticCalcX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImBezierQuadraticCalc(Vector2* pRetVal, Vector2* p1, Vector2* p2, Vector2* p3, float t);
[LibraryImport("imgui.dll", EntryPoint = "ImFileCloseX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImFileClose(_iobuf* f);
[LibraryImport("imgui.dll", EntryPoint = "ImFileGetSizeX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ulong ImFileGetSize(_iobuf* f);
[LibraryImport("imgui.dll", EntryPoint = "ImFileLoadToMemoryX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void* ImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
[LibraryImport("imgui.dll", EntryPoint = "ImFileOpenX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial _iobuf* ImFileOpen(byte* filename, byte* mode);
[LibraryImport("imgui.dll", EntryPoint = "ImFileReadX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ulong ImFileRead(void* data, ulong sz, ulong count, _iobuf* f);
[LibraryImport("imgui.dll", EntryPoint = "ImFileWriteX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ulong ImFileWrite(void* data, ulong sz, ulong count, _iobuf* f);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildFinishX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildFinish(ImFontAtlas* atlas);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildGetOversampleFactorsX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildGetOversampleFactors(ImFontConfig* src, int* out_oversample_h, int* out_oversample_v);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildInitX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildInit(ImFontAtlas* atlas);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildMultiplyCalcLookupTableX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_brighten_factor);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildMultiplyRectAlpha8X"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildPackCustomRectsX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildRender32bppRectFromStringX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildRender8bppRectFromStringX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasBuildSetupFontX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasGetBuilderForStbTruetypeX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImFontBuilderIO* ImFontAtlasGetBuilderForStbTruetype();
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasGetMouseCursorTexDataX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImFontAtlasGetMouseCursorTexData(ImFontAtlas* atlas, int cursor_type, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
[LibraryImport("imgui.dll", EntryPoint = "ImFontAtlasUpdateSourcesPointersX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFontAtlasUpdateSourcesPointers(ImFontAtlas* atlas);
[LibraryImport("imgui.dll", EntryPoint = "ImFormatStringToTempBufferVX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFormatStringToTempBufferV(byte** out_buf, byte** out_buf_end, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImFormatStringVX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImFormatStringV(byte* buf, uint buf_size, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplDX9_CreateDeviceObjectsX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ImplDX9_CreateDeviceObjects();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplDX9_InitX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ImplDX9_Init(IDirect3DDevice9* device);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplDX9_InvalidateDeviceObjectsX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplDX9_InvalidateDeviceObjects();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplDX9_NewFrameX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplDX9_NewFrame();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplDX9_RenderDrawDataX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplDX9_RenderDrawData(ImDrawData* draw_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplDX9_ShutdownX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplDX9_Shutdown();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_EnableAlphaCompositingX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplWin32_EnableAlphaCompositing(void* hwnd);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_EnableDpiAwarenessX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplWin32_EnableDpiAwareness();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_GetDpiScaleForHwndX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_ImplWin32_GetDpiScaleForHwnd(void* hwnd);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_GetDpiScaleForMonitorX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_ImplWin32_GetDpiScaleForMonitor(void* monitor);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_InitX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ImplWin32_Init(void* hwnd);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_InitForOpenGLX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ImplWin32_InitForOpenGL(void* hwnd);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_NewFrameX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplWin32_NewFrame();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_ShutdownX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImplWin32_Shutdown();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_WndProcHandlerX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_ImplWin32_WndProcHandler(HWND__* hwnd, uint msg, uint wParam, int lParam);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImplWin32_WndProcHandlerExX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_ImplWin32_WndProcHandlerEx(HWND__* hwnd, uint msg, uint wParam, int lParam, ImGuiIO* io);
[LibraryImport("imgui.dll", EntryPoint = "ImHashDataX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImHashData(void* data_p, uint data_size, uint seed);
[LibraryImport("imgui.dll", EntryPoint = "ImHashStrX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImHashStr(byte* data_p, uint data_size, uint seed);
[LibraryImport("imgui.dll", EntryPoint = "ImLineClosestPointX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImLineClosestPoint(Vector2* pRetVal, Vector2* a, Vector2* b, Vector2* p);
[LibraryImport("imgui.dll", EntryPoint = "ImLowerBoundX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiStoragePair* ImLowerBound(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, uint key);
[LibraryImport("imgui.dll", EntryPoint = "ImParseFormatFindEndX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImParseFormatFindEnd(byte* fmt);
[LibraryImport("imgui.dll", EntryPoint = "ImParseFormatFindStartX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImParseFormatFindStart(byte* fmt);
[LibraryImport("imgui.dll", EntryPoint = "ImParseFormatPrecisionX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImParseFormatPrecision(byte* fmt, int default_precision);
[LibraryImport("imgui.dll", EntryPoint = "ImParseFormatSanitizeForPrintingX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImParseFormatSanitizeForPrinting(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
[LibraryImport("imgui.dll", EntryPoint = "ImParseFormatSanitizeForScanningX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImParseFormatSanitizeForScanning(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
[LibraryImport("imgui.dll", EntryPoint = "ImParseFormatTrimDecorationsX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImParseFormatTrimDecorations(byte* fmt, byte* buf, uint buf_size);
[LibraryImport("imgui.dll", EntryPoint = "ImStrSkipBlankX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImStrSkipBlank(byte* str);
[LibraryImport("imgui.dll", EntryPoint = "ImStrTrimBlanksX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImStrTrimBlanks(byte* buf);
[LibraryImport("imgui.dll", EntryPoint = "ImStrbolX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImStrbol(byte* buf_mid_line, byte* buf_begin);
[LibraryImport("imgui.dll", EntryPoint = "ImStrchrRangeX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImStrchrRange(byte* str, byte* str_end, byte c);
[LibraryImport("imgui.dll", EntryPoint = "ImStrdupX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImStrdup(byte* str);
[LibraryImport("imgui.dll", EntryPoint = "ImStrdupcpyX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImStrdupcpy(byte* dst, uint* p_dst_size, byte* src);
[LibraryImport("imgui.dll", EntryPoint = "ImStreolRangeX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImStreolRange(byte* str, byte* str_end);
[LibraryImport("imgui.dll", EntryPoint = "ImStricmpX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImStricmp(byte* str1, byte* str2);
[LibraryImport("imgui.dll", EntryPoint = "ImStristrX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
[LibraryImport("imgui.dll", EntryPoint = "ImStrlenWX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImStrlenW(ushort* str);
[LibraryImport("imgui.dll", EntryPoint = "ImStrncpyX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImStrncpy(byte* dst, byte* src, uint count);
[LibraryImport("imgui.dll", EntryPoint = "ImStrnicmpX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImStrnicmp(byte* str1, byte* str2, uint count);
[LibraryImport("imgui.dll", EntryPoint = "ImTextCharFromUtf8X"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImTextCharToUtf8X"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImTextCharToUtf8(byte* out_buf, uint c);
[LibraryImport("imgui.dll", EntryPoint = "ImTextCountCharsFromUtf8X"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImTextCountLinesX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImTextCountLines(byte* in_text, byte* in_text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImTextCountUtf8BytesFromCharX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImTextCountUtf8BytesFromStrX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImTextFindPreviousUtf8CodepointX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImTextFindPreviousUtf8Codepoint(byte* in_text_start, byte* in_text_curr);
[LibraryImport("imgui.dll", EntryPoint = "ImTextStrFromUtf8X"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImTextStrFromUtf8(ushort* buf, int buf_size, byte* in_text, byte* in_text_end, byte** in_text_remaining);
[LibraryImport("imgui.dll", EntryPoint = "ImTextStrToUtf8X"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImTextStrToUtf8(byte* out_buf, int out_buf_size, ushort* in_text, ushort* in_text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImTriangleBarycentricCoordsX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImTriangleBarycentricCoords(Vector2* a, Vector2* b, Vector2* c, Vector2* p, float* out_u, float* out_v, float* out_w);
[LibraryImport("imgui.dll", EntryPoint = "ImTriangleClosestPointX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImTriangleClosestPoint(Vector2* pRetVal, Vector2* a, Vector2* b, Vector2* c, Vector2* p);
[LibraryImport("imgui.dll", EntryPoint = "ImTriangleContainsPointX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImTriangleContainsPoint(Vector2* a, Vector2* b, Vector2* c, Vector2* p);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Image"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Image(ulong user_texture_id, Vector2* image_size, Vector2* uv0, Vector2* uv1);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImageButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ImageButton(byte* str_id, ulong user_texture_id, Vector2* image_size, Vector2* uv0, Vector2* uv1, Vector4* bg_col, Vector4* tint_col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImageButtonEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ImageButtonEx(uint id, ulong user_texture_id, Vector2* image_size, Vector2* uv0, Vector2* uv1, Vector4* bg_col, Vector4* tint_col, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ImageWithBg"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ImageWithBg(ulong user_texture_id, Vector2* image_size, Vector2* uv0, Vector2* uv1, Vector4* bg_col, Vector4* tint_col);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiListClipper_IncludeItemsByIndex"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* _this, int item_begin, int item_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Indent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Indent(float indent_w);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Initialize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Initialize();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputDouble"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputDouble(byte* label, double* v, double step, double step_fast, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputFloat2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputFloat2(byte* label, float* v, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputFloat3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputFloat3(byte* label, float* v, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputFloat4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputFloat4(byte* label, float* v, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputFloat"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputFloat(byte* label, float* v, float step, float step_fast, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputInt2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputInt2(byte* label, int* v, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputInt3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputInt3(byte* label, int* v, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputInt4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputInt4(byte* label, int* v, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputInt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputInt(byte* label, int* v, int step, int step_fast, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputScalar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputScalar(byte* label, int data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputScalarN"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputScalarN(byte* label, int data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputText(byte* label, byte* buf, uint buf_size, int flags, void** callback, void* user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputTextDeactivateHook"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_InputTextDeactivateHook(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputTextEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2* size_arg, int flags, void** callback, void* callback_user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputTextMultiline"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2* size, int flags, void** callback, void* user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InputTextWithHint"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, int flags, void** callback, void* user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextCallbackData_InsertChars"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* _this, int pos, byte* new_text, byte* new_text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_InvisibleButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_InvisibleButton(byte* str_id, Vector2* size_arg, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsAnyItemActive"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsAnyItemActive();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsAnyItemFocused"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsAnyItemFocused();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsAnyItemHovered"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsAnyItemHovered();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsAnyMouseDown"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsAnyMouseDown();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsCentralNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsCentralNode(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsClippedEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsClippedEx(ImRect* bb, uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsDockSpace"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsDockSpace(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsDragDropActive"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsDragDropActive();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsDragDropPayloadBeingAccepted"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsDragDropPayloadBeingAccepted();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsEmpty"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsEmpty(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsFloatingNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsFloatingNode(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_IsGlyphRangeUnused"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImFont_IsGlyphRangeUnused(ImFont* _this, uint c_begin, uint c_last);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsHiddenTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsHiddenTabBar(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_IsInverted"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImRect_IsInverted(ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemActivated"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemActivated();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemActive"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemActive();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemClicked"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemClicked(int mouse_button);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemDeactivated"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemDeactivated();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemDeactivatedAfterEdit"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemDeactivatedAfterEdit();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemEdited"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemEdited();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemFocused"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemFocused();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemHovered"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemHovered(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemToggledOpen"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemToggledOpen();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemToggledSelection"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemToggledSelection();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsItemVisible"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsItemVisible();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyChordPressed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyChordPressed(int key_chord);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyChordPressed0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyChordPressed(int key_chord, int flags, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyDown"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyDown(ImGuiKey key);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyDown0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyDown(ImGuiKey key, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyPressed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyPressed(ImGuiKey key, int flags, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyPressed0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyPressed(ImGuiKey key, byte repeat);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyReleased"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyReleased(ImGuiKey key);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsKeyReleased0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsKeyReleased(ImGuiKey key, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsLeafNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsLeafNode(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseClicked"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseClicked(int button, int flags, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseClicked0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseClicked(int button, byte repeat);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseDoubleClicked"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseDoubleClicked(int button);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseDoubleClicked0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseDoubleClicked(int button, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseDown"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseDown(int button);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseDown0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseDown(int button, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseDragPastThreshold"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseDragPastThreshold(int button, float lock_threshold);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseDragging"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseDragging(int button, float lock_threshold);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseHoveringRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseHoveringRect(Vector2* r_min, Vector2* r_max, byte clip);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMousePosValid"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMousePosValid(Vector2* mouse_pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseReleased"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseReleased(int button);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseReleased0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseReleased(int button, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsMouseReleasedWithDelay"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsMouseReleasedWithDelay(int button, float delay);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsNoTabBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsNoTabBar(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsPopupOpen"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsPopupOpen(uint id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsPopupOpen0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsPopupOpen(byte* str_id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsRectVisible"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsRectVisible(Vector2* rect_min, Vector2* rect_max);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsRectVisible0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsRectVisible(Vector2* size);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsRootNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsRootNode(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_IsSplitNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiDockNode_IsSplitNode(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowAbove"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowAppearing"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowAppearing();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowChildOf"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy, byte dock_hierarchy);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowCollapsed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowCollapsed();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowContentHoverable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowContentHoverable(ImGuiWindow* window, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowDocked"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowDocked();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowFocused"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowFocused(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowHovered"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowHovered(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowNavFocusable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowNavFocusable(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_IsWindowWithinBeginStackOf"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_IsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ItemAdd"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ItemAdd(ImRect* bb, uint id, ImRect* nav_bb_arg, int extra_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ItemHoverable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ItemHoverable(ImRect* bb, uint id, int item_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ItemSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ItemSize(Vector2* size, float text_baseline_y);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_KeepAliveID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_KeepAliveID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LabelTextV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LabelTextV(byte* label, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ListBox"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ListBox(byte* label, int* current_item, void** getter, void* user_data, int items_count, int height_in_items);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ListBox0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ListBox(byte* label, int* current_item, byte** items, int items_count, int height_items);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LoadIniSettingsFromDisk"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LoadIniSettingsFromDisk(byte* ini_filename);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LoadIniSettingsFromMemory"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LocalizeRegisterEntries"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LocalizeRegisterEntries(ImGuiLocEntry* entries, int count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogBegin"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogBegin(int flags, int auto_open_depth);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogButtons"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogButtons();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogFinish"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogFinish();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogRenderedText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogSetNextTextDecoration"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogSetNextTextDecoration(byte* prefix, byte* suffix);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogTextV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogTextV(byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogToBuffer"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogToBuffer(int auto_open_depth);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogToClipboard"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogToClipboard(int auto_open_depth);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogToFile"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogToFile(int auto_open_depth, byte* filename);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_LogToTTY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_LogToTTY(int auto_open_depth);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MarkIniSettingsDirty"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MarkIniSettingsDirty(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MarkIniSettingsDirty0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MarkIniSettingsDirty();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MarkItemEdited"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MarkItemEdited(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MemAlloc"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void* ImGui_MemAlloc(uint size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MemFree"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MemFree(void* ptr);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_MenuBarRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImRect* ImGuiWindow_MenuBarRect(ImRect* pRetVal, ImGuiWindow* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MenuItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_MenuItem(byte* label, byte* shortcut, byte* p_selected, byte enabled);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MenuItem0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_MenuItem(byte* label, byte* shortcut, byte selected, byte enabled);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MenuItemEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_MenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawListSplitter_Merge"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawListSplitter_Merge(ImDrawListSplitter* _this, ImDrawList* draw_list);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MultiSelectAddSetAll"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, byte selected);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MultiSelectAddSetRange"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, byte selected, int range_dir, long first_item, long last_item);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MultiSelectItemFooter"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MultiSelectItemFooter(uint id, byte* p_selected, byte* p_pressed);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_MultiSelectItemHeader"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_MultiSelectItemHeader(uint id, byte* p_selected, int* p_button_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavClearPreferredPosForAxis"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavClearPreferredPosForAxis(ImGuiAxis axis);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavHighlightActivated"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavHighlightActivated(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavInitRequestApplyResult"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavInitRequestApplyResult();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavInitWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavInitWindow(ImGuiWindow* window, byte force_reinit);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestApplyResult"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavMoveRequestApplyResult();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestButNoResultYet"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_NavMoveRequestButNoResultYet();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestCancel"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavMoveRequestCancel();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestForward"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, int move_flags, int scroll_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestResolveWithLastItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestResolveWithPastTreeNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestSubmit"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, int move_flags, int scroll_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavMoveRequestTryWrapping"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavMoveRequestTryWrapping(ImGuiWindow* window, int wrap_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NavUpdateCurrentWindowIsScrollPushableX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NavUpdateCurrentWindowIsScrollPushableX();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NewFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NewFrame();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NewLine"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NewLine();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_NextColumn"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_NextColumn();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_OnCharPressed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_OnCharPressed(ImGuiInputTextState* _this, uint c);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_OnKeyPressed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* _this, int key);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_OpenPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_OpenPopup(uint id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_OpenPopup0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_OpenPopup(byte* str_id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_OpenPopupEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_OpenPopupEx(uint id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_OpenPopupOnItemClick"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_OpenPopupOnItemClick(byte* str_id, int popup_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Overlaps"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImRect_Overlaps(ImRect* _this, ImRect* r);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiTextFilter_PassFilter"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* _this, byte* text, byte* text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PathArcTo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PathArcTo(ImDrawList* _this, Vector2* center, float radius, float a_min, float a_max, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PathArcToFast"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PathArcToFast(ImDrawList* _this, Vector2* center, float radius, int a_min_of_12, int a_max_of_12);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PathBezierCubicCurveTo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PathBezierCubicCurveTo(ImDrawList* _this, Vector2* p2, Vector2* p3, Vector2* p4, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PathBezierQuadraticCurveTo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* _this, Vector2* p2, Vector2* p3, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PathEllipticalArcTo"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PathEllipticalArcTo(ImDrawList* _this, Vector2* center, Vector2* radius, float rot, float a_min, float a_max, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PathRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PathRect(ImDrawList* _this, Vector2* a, Vector2* b, float rounding, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PlotEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_PlotEx(ImGuiPlotType plot_type, byte* label, void** values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2* size_arg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PlotHistogram"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PlotHistogram(byte* label, void** values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PlotHistogram0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PlotHistogram(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PlotLines"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PlotLines(byte* label, void** values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PlotLines0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PlotLines(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PopClipRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PopClipRect(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopClipRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopClipRect();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopColumnsBackground"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopColumnsBackground();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopFocusScope"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopFocusScope();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopFont"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopFont();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopID();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopItemFlag"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopItemFlag();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopItemWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopItemWidth();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopStyleColor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopStyleColor(int count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopStyleVar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopStyleVar(int count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PopTextWrapPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PopTextWrapPos();
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PopTextureID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PopTextureID(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PrimQuadUV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PrimQuadUV(ImDrawList* _this, Vector2* a, Vector2* b, Vector2* c, Vector2* d, Vector2* uv_a, Vector2* uv_b, Vector2* uv_c, Vector2* uv_d, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PrimRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PrimRect(ImDrawList* _this, Vector2* a, Vector2* c, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PrimRectUV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PrimRectUV(ImDrawList* _this, Vector2* a, Vector2* c, Vector2* uv_a, Vector2* uv_c, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PrimReserve"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PrimReserve(ImDrawList* _this, int idx_count, int vtx_count);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PrimUnreserve"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PrimUnreserve(ImDrawList* _this, int idx_count, int vtx_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ProgressBar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ProgressBar(float fraction, Vector2* size_arg, byte* overlay);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PushClipRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PushClipRect(ImDrawList* _this, Vector2* cr_min, Vector2* cr_max, byte intersect_with_current_clip_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushClipRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushClipRect(Vector2* clip_rect_min, Vector2* clip_rect_max, byte intersect_with_current_clip_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PushClipRectFullScreen"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PushClipRectFullScreen(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushColumnClipRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushColumnClipRect(int column_index);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushColumnsBackground"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushColumnsBackground();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushFocusScope"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushFocusScope(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushFont"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushFont(ImFont* font);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushID(int int_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushID0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushID(byte* str_id_begin, byte* str_id_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushID1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushID(byte* str_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushID2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushID(void* ptr_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushItemFlag"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushItemFlag(int option, byte enabled);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushItemWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushItemWidth(float item_width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushMultiItemsWidths"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushMultiItemsWidths(int components, float w_full);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushOverrideID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushOverrideID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushPasswordFont"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushPasswordFont();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushStyleColor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushStyleColor(int idx, Vector4* col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushStyleColor0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushStyleColor(int idx, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushStyleVar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushStyleVar(int idx, Vector2* val);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushStyleVar0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushStyleVar(int idx, float val);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushStyleVarX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushStyleVarX(int idx, float val_x);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushStyleVarY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushStyleVarY(int idx, float val_y);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_PushTextWrapPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_PushTextWrapPos(float wrap_pos_x);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList_PushTextureID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList_PushTextureID(ImDrawList* _this, ulong texture_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RadioButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_RadioButton(byte* label, int* v, int v_button);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RadioButton0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_RadioButton(byte* label, byte active);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_Rect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImRect* ImGuiDockNode_Rect(ImRect* pRetVal, ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_Rect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImRect* ImGuiWindow_Rect(ImRect* pRetVal, ImGuiWindow* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_ReloadUserBufAndKeepSelection"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_ReloadUserBufAndKeepSelection(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_ReloadUserBufAndMoveToEnd"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_ReloadUserBufAndMoveToEnd(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_ReloadUserBufAndSelectAll"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_ReloadUserBufAndSelectAll(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RemoveContextHook"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RemoveContextHook(ImGuiContext* ctx, uint hook_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RemoveSettingsHandler"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RemoveSettingsHandler(byte* type_name);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Render"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Render();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderArrow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderArrowDockMenu"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderArrowDockMenu(ImDrawList* draw_list, Vector2 p_min, float sz, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderArrowPointingAt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderBullet"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_RenderChar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFont_RenderChar(ImFont* _this, ImDrawList* draw_list, float size, Vector2* pos, uint col, ushort c);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderCheckMark"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderColorRectWithAlphaCheckerboard"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint col, float grid_step, Vector2 grid_off, float rounding, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderDragDropTargetRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderDragDropTargetRect(ImRect* bb, ImRect* item_clip_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte borders, float rounding);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderFrameBorder"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderMouseCursor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderMouseCursor(Vector2 base_pos, float base_scale, int mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderNavCursor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderNavCursor(ImRect* bb, uint id, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderPlatformWindowsDefault"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderRectFilledRangeH"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderRectFilledRangeH(ImDrawList* draw_list, ImRect* rect, uint col, float x_start_norm, float x_end_norm, float rounding);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderRectFilledWithHole"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderRectFilledWithHole(ImDrawList* draw_list, ImRect* outer, ImRect* inner, uint col, float rounding);
[LibraryImport("imgui.dll", EntryPoint = "ImFont_RenderText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImFont_RenderText(ImFont* _this, ImDrawList* draw_list, float size, Vector2* pos, uint col, Vector4* clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderTextClipped"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderTextClipped(Vector2* pos_min, Vector2* pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2* align, ImRect* clip_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderTextClippedEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderTextClippedEx(ImDrawList* draw_list, Vector2* pos_min, Vector2* pos_max, byte* text, byte* text_display_end, Vector2* text_size_if_known, Vector2* align, ImRect* clip_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderTextEllipsis"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderTextEllipsis(ImDrawList* draw_list, Vector2* pos_min, Vector2* pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end_full, Vector2* text_size_if_known);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_RenderTextWrapped"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_RenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ResetMouseDragDelta"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ResetMouseDragDelta(int button);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SameLine"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SameLine(float offset_from_start_x, float spacing_w);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SaveIniSettingsToDisk"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SaveIniSettingsToDisk(byte* ini_filename);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SaveIniSettingsToMemory"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_SaveIniSettingsToMemory(uint* out_size);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStyle_ScaleAllSizes"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiStyle_ScaleAllSizes(ImGuiStyle* _this, float scale_factor);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawData_ScaleClipRects"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawData_ScaleClipRects(ImDrawData* _this, Vector2* fb_scale);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ScaleWindowsInViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ScrollToItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ScrollToItem(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ScrollToRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ScrollToRect(ImGuiWindow* window, ImRect* item_rect, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ScrollToRectEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_ScrollToRectEx(Vector2* pRetVal, ImGuiWindow* window, ImRect* item_rect, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Scrollbar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Scrollbar(ImGuiAxis axis);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ScrollbarEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_ScrollbarEx(ImRect* bb_frame, uint id, ImGuiAxis axis, long* p_scroll_v, long size_visible_v, long size_contents_v, int draw_rounding_flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiListClipper_SeekCursorForItem"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* _this, int item_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiInputTextState_SelectAll"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiInputTextState_SelectAll(ImGuiInputTextState* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Selectable"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Selectable(byte* label, byte* p_selected, int flags, Vector2* size_arg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Selectable0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Selectable(byte* label, byte selected, int flags, Vector2* size_arg);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Separator"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Separator();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SeparatorEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SeparatorEx(int flags, float thickness);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SeparatorText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SeparatorText(byte* label);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SeparatorTextEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SeparatorTextEx(uint id, byte* label, byte* label_end, float extra_w);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetActiveID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetActiveID(uint id, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetActiveIdUsingAllKeyboardKeys"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetActiveIdUsingAllKeyboardKeys();
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_SetAllInt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiStorage_SetAllInt(ImGuiStorage* _this, int v);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetAllocatorFunctions"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetAllocatorFunctions(void** alloc_func, void** free_func, void* user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_SetAppAcceptingEvents"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* _this, byte accepting_events);
[LibraryImport("imgui.dll", EntryPoint = "ImBitVector_SetBit"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImBitVector_SetBit(ImBitVector* _this, int n);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_SetBool"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiStorage_SetBool(ImGuiStorage* _this, uint key, byte val);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawListSharedData_SetCircleTessellationMaxError"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* _this, float max_error);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetClipboardText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetClipboardText(byte* text);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetColorEditOptions"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetColorEditOptions(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetColumnOffset"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetColumnOffset(int column_index, float offset);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetColumnWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetColumnWidth(int column_index, float width);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawListSplitter_SetCurrentChannel"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* _this, ImDrawList* draw_list, int idx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetCurrentContext"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetCurrentContext(ImGuiContext* ctx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetCurrentFont"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetCurrentFont(ImFont* font);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetCurrentViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetCurrentViewport(ImGuiWindow* current_window, ImGuiViewportP* viewport);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetCursorPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetCursorPos(Vector2* local_pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetCursorPosX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetCursorPosX(float x);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetCursorPosY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetCursorPosY(float y);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetCursorScreenPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetCursorScreenPos(Vector2* pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetDragDropPayload"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SetDragDropPayload(byte* type, void* data, uint data_size, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_SetFloat"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiStorage_SetFloat(ImGuiStorage* _this, uint key, float val);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetFocusID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetFocusID(uint id, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetHoveredID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetHoveredID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_SetInt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiStorage_SetInt(ImGuiStorage* _this, uint key, int val);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetItemDefaultFocus"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetItemDefaultFocus();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetItemKeyOwner"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetItemKeyOwner(ImGuiKey key);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetItemKeyOwner0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetItemKeyOwner(ImGuiKey key, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiSelectionBasicStorage_SetItemSelected"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* _this, uint id, byte selected);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetItemTooltipV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetItemTooltipV(byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiIO_SetKeyEventNativeData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiIO_SetKeyEventNativeData(ImGuiIO* _this, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetKeyOwner"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetKeyOwner(ImGuiKey key, uint owner_id, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetKeyOwnersForKeyChord"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetKeyOwnersForKeyChord(int key_chord, uint owner_id, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetKeyboardFocusHere"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetKeyboardFocusHere(int offset);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetLastItemData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetLastItemData(uint item_id, int item_flags, int status_flags, ImRect* item_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_SetLocalFlags"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiDockNode_SetLocalFlags(ImGuiDockNode* _this, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetMouseCursor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetMouseCursor(int cursor_type);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNavCursorVisible"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNavCursorVisible(byte visible);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNavCursorVisibleAfterMove"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNavCursorVisibleAfterMove();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNavFocusScope"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNavFocusScope(uint focus_scope_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNavID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect* rect_rel);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNavWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNavWindow(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextFrameWantCaptureKeyboard"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextFrameWantCaptureKeyboard(byte want_capture_keyboard);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextFrameWantCaptureMouse"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextFrameWantCaptureMouse(byte want_capture_mouse);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextItemAllowOverlap"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextItemAllowOverlap();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextItemOpen"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextItemOpen(byte is_open, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextItemRefVal"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextItemRefVal(int data_type, void* p_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextItemSelectionUserData"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextItemSelectionUserData(long selection_user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextItemShortcut"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextItemShortcut(int key_chord, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextItemStorageID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextItemStorageID(uint storage_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextItemWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextItemWidth(float item_width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowBgAlpha"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowBgAlpha(float alpha);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowClass"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowClass(ImGuiWindowClass* window_class);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowCollapsed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowCollapsed(byte collapsed, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowContentSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowContentSize(Vector2* size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowDockID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowDockID(uint id, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowFocus"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowFocus();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowPos(Vector2* pos, int cond, Vector2* pivot);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowRefreshPolicy"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowRefreshPolicy(int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowScroll"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowScroll(Vector2* scroll);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowSize(Vector2* size, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowSizeConstraints"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowSizeConstraints(Vector2* size_min, Vector2* size_max, void** custom_callback, void* custom_callback_user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetNextWindowViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetNextWindowViewport(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollFromPosX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollFromPosX(float local_x, float center_x_ratio);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollFromPosX0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollFromPosX(ImGuiWindow* window, float local_x, float center_x_ratio);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollFromPosY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollFromPosY(float local_y, float center_y_ratio);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollFromPosY0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollFromPosY(ImGuiWindow* window, float local_y, float center_y_ratio);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollHereX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollHereX(float center_x_ratio);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollHereY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollHereY(float center_y_ratio);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollX(float scroll_x);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollX0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollX(ImGuiWindow* window, float scroll_x);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollY(float scroll_y);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetScrollY0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetScrollY(ImGuiWindow* window, float scroll_y);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetShortcutRouting"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SetShortcutRouting(int key_chord, int flags, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetStateStorage"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetStateStorage(ImGuiStorage* tree);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetTabItemClosed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetTabItemClosed(byte* label);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetTooltipV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetTooltipV(byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiStorage_SetVoidPtr"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiStorage_SetVoidPtr(ImGuiStorage* _this, uint key, void* val);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowClipRectBeforeSetChannel"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect* clip_rect);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowCollapsed"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowCollapsed(ImGuiWindow* window, byte collapsed, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowCollapsed0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowCollapsed(byte* name, byte collapsed, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowCollapsed1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowCollapsed(byte collapsed, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowDock"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowDock(ImGuiWindow* window, uint dock_id, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowFocus"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowFocus(byte* name);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowFocus0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowFocus();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowFontScale"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowFontScale(float scale);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowHiddenAndSkipItemsForCurrentFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowHitTestHole"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowHitTestHole(ImGuiWindow* window, Vector2* pos, Vector2* size);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowPos(Vector2* pos, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowPos0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowPos(ImGuiWindow* window, Vector2* pos, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowPos1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowPos(byte* name, Vector2* pos, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowSize(Vector2* size, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowSize0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowSize(ImGuiWindow* window, Vector2* size, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowSize1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowSize(byte* name, Vector2* size, int cond);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SetWindowViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_SetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShadeVertsLinearColorGradientKeepAlpha"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShadeVertsLinearUV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2* a, Vector2* b, Vector2* uv_a, Vector2* uv_b, byte clamp);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShadeVertsTransformPos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2* pivot_in, float cos_a, float sin_a, Vector2* pivot_out);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Shortcut"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Shortcut(int key_chord, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Shortcut0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_Shortcut(int key_chord, int flags, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShowDebugLogWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShowDebugLogWindow(byte* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShowFontAtlas"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShowFontAtlas(ImFontAtlas* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShowIDStackToolWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShowIDStackToolWindow(byte* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShowMetricsWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShowMetricsWindow(byte* __formal);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_ShrinkWidths"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_ShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Shutdown"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Shutdown();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderAngle"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderBehavior"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderBehavior(ImRect* bb, uint id, int data_type, void* p_v, void* p_min, void* p_max, byte* format, int flags, ImRect* out_grab_bb);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderFloat2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderFloat2(byte* label, float* v, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderFloat3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderFloat3(byte* label, float* v, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderFloat4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderFloat4(byte* label, float* v, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderFloat"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderInt2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderInt3"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderInt4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderInt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderInt(byte* label, int* v, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderScalar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderScalar(byte* label, int data_type, void* p_data, void* p_min, void* p_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SliderScalarN"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SliderScalarN(byte* label, int data_type, void* v, int components, void* v_min, void* v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SmallButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SmallButton(byte* label);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Spacing"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Spacing();
[LibraryImport("imgui.dll", EntryPoint = "ImDrawListSplitter_Split"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawListSplitter_Split(ImDrawListSplitter* _this, ImDrawList* draw_list, int channels_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_SplitterBehavior"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_SplitterBehavior(ImRect* bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_StartMouseMovingWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_StartMouseMovingWindow(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_StartMouseMovingWindowOrNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_StartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiListClipper_Step"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGuiListClipper_Step(ImGuiListClipper* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_StyleColorsClassic"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_StyleColorsClassic(ImGuiStyle* dst);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_StyleColorsDark"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_StyleColorsDark(ImGuiStyle* dst);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_StyleColorsLight"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_StyleColorsLight(ImGuiStyle* dst);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiSelectionBasicStorage_Swap"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* _this, ImGuiSelectionBasicStorage* r);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarAddTab"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabBarAddTab(ImGuiTabBar* tab_bar, int tab_flags, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarCloseTab"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarFindMostRecentlySelectedTabForActiveWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTabItem* ImGui_TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarFindTabByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTabItem* ImGui_TabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarFindTabByOrder"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTabItem* ImGui_TabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarGetCurrentTab"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTabItem* ImGui_TabBarGetCurrentTab(ImGuiTabBar* tab_bar);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarGetTabName"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_TabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarProcessReorder"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TabBarProcessReorder(ImGuiTabBar* tab_bar);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarQueueFocus"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabBarQueueFocus(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarQueueFocus0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabBarQueueFocus(ImGuiTabBar* tab_bar, byte* tab_name);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarQueueReorder"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarQueueReorderFromMousePos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* src_tab, Vector2 mouse_pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabBarRemoveTab"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabItemBackground"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabItemBackground(ImDrawList* draw_list, ImRect* bb, int flags, uint col);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabItemButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TabItemButton(byte* label, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabItemCalcSize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_TabItemCalcSize(Vector2* pRetVal, ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabItemCalcSize0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector2* ImGui_TabItemCalcSize(Vector2* pRetVal, byte* label, byte has_close_button_or_unsaved_marker);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabItemEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, int flags, ImGuiWindow* docked_window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabItemLabelAndCloseButton"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect* bb, int flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TabItemSpacing"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TabItemSpacing(byte* str_id, int flags, float width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableAngledHeadersRow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableAngledHeadersRow();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableAngledHeadersRowEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableAngledHeadersRowEx(uint row_id, float angle, float max_label_width, ImGuiTableHeaderData* data, int data_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableBeginApplyRequests"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableBeginApplyRequests(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableBeginCell"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableBeginCell(ImGuiTable* table, int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableBeginContextMenuPopup"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TableBeginContextMenuPopup(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableBeginInitMemory"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableBeginInitMemory(ImGuiTable* table, int columns_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableBeginRow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableBeginRow(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableCalcMaxColumnWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_TableCalcMaxColumnWidth(ImGuiTable* table, int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableDrawBorders"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableDrawBorders(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableDrawDefaultContextMenu"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableDrawDefaultContextMenu(ImGuiTable* table, int flags_for_section_to_display);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableEndCell"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableEndCell(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableEndRow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableEndRow(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableFindByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTable* ImGui_TableFindByID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableFixColumnSortDirection"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGcCompactSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableGcCompactSettings();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGcCompactTransientBuffers"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableGcCompactTransientBuffers(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGcCompactTransientBuffers0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableGcCompactTransientBuffers(ImGuiTableTempData* temp_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetBoundSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTableSettings* ImGui_TableGetBoundSettings(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetCellBgRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImRect* ImGui_TableGetCellBgRect(ImRect* pRetVal, ImGuiTable* table, int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnCount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TableGetColumnCount();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnFlags"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TableGetColumnFlags(int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnIndex"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TableGetColumnIndex();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnName"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_TableGetColumnName(int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnName0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte* ImGui_TableGetColumnName(ImGuiTable* table, int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnNextSortDirection"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiSortDirection ImGui_TableGetColumnNextSortDirection(ImGuiTableColumn* column);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnResizeID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial uint ImGui_TableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetColumnWidthAuto"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_TableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetHeaderAngledMaxLabelWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_TableGetHeaderAngledMaxLabelWidth();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetHeaderRowHeight"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial float ImGui_TableGetHeaderRowHeight();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetHoveredColumn"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TableGetHoveredColumn();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetHoveredRow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TableGetHoveredRow();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetRowIndex"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TableGetRowIndex();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableGetSortSpecs"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTableSortSpecs* ImGui_TableGetSortSpecs();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableHeader"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableHeader(byte* label);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableHeadersRow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableHeadersRow();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableLoadSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableLoadSettings(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableMergeDrawChannels"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableMergeDrawChannels(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableNextColumn"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TableNextColumn();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableNextRow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableNextRow(int row_flags, float row_min_height);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableOpenContextMenu"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableOpenContextMenu(int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TablePopBackgroundChannel"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TablePopBackgroundChannel();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TablePushBackgroundChannel"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TablePushBackgroundChannel();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableRemove"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableRemove(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableResetSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableResetSettings(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSaveSettings"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSaveSettings(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetBgColor"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetBgColor(int target, uint color, int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetColumnEnabled"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetColumnEnabled(int column_n, byte enabled);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetColumnIndex"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TableSetColumnIndex(int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetColumnSortDirection"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetColumnWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetColumnWidth(int column_n, float width);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetColumnWidthAutoAll"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetColumnWidthAutoAll(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetColumnWidthAutoSingle"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSettingsAddSettingsHandler"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSettingsAddSettingsHandler();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSettingsCreate"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTableSettings* ImGui_TableSettingsCreate(uint id, int columns_count);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSettingsFindByID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImGuiTableSettings* ImGui_TableSettingsFindByID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetupColumn"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetupColumn(byte* label, int flags, float init_width_or_weight, uint user_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetupDrawChannels"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetupDrawChannels(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSetupScrollFreeze"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSetupScrollFreeze(int columns, int rows);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSortSpecsBuild"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSortSpecsBuild(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableSortSpecsSanitize"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableSortSpecsSanitize(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableUpdateBorders"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableUpdateBorders(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableUpdateColumnsWeightFromWidth"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableUpdateColumnsWeightFromWidth(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TableUpdateLayout"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TableUpdateLayout(ImGuiTable* table);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TeleportMousePos"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TeleportMousePos(Vector2* pos);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TempInputScalar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TempInputScalar(ImRect* bb, uint id, byte* label, int data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TempInputText"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TempInputText(ImRect* bb, uint id, byte* label, byte* buf, int buf_size, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImBitVector_TestBit"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImBitVector_TestBit(ImBitVector* _this, int n);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TestKeyOwner"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TestKeyOwner(ImGuiKey key, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TestShortcutRouting"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TestShortcutRouting(int key_chord, uint owner_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextColoredV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TextColoredV(Vector4* col, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextDisabledV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TextDisabledV(byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TextEx(byte* text, byte* text_end, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextLink"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TextLink(byte* label);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextLinkOpenURL"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TextLinkOpenURL(byte* label, byte* url);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextUnformatted"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TextUnformatted(byte* text, byte* text_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TextV(byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TextWrappedV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TextWrappedV(byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiWindow_TitleBarRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial ImRect* ImGuiWindow_TitleBarRect(ImRect* pRetVal, ImGuiWindow* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_ToVec4"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial Vector4* ImRect_ToVec4(Vector4* pRetVal, ImRect* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_Translate"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_Translate(ImRect* _this, Vector2* d);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TranslateWindowsInViewport"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2* old_pos, Vector2* new_pos, Vector2* old_size, Vector2* new_size);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_TranslateX"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_TranslateX(ImRect* _this, float dx);
[LibraryImport("imgui.dll", EntryPoint = "ImRect_TranslateY"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImRect_TranslateY(ImRect* _this, float dy);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNode"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNode(byte* label);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeBehavior"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeBehavior(uint id, int flags, byte* label, byte* label_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeEx(byte* label, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeExV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeExV(byte* str_id, int flags, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeExV0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeExV(void* ptr_id, int flags, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeGetOpen"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeGetOpen(uint storage_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeSetOpen"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TreeNodeSetOpen(uint storage_id, byte open);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeUpdateNextOpen"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeUpdateNextOpen(uint storage_id, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeV"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeV(byte* str_id, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreeNodeV0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_TreeNodeV(void* ptr_id, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreePop"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TreePop();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreePush"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TreePush(byte* str_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreePush0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TreePush(void* ptr_id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TreePushOverrideID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_TreePushOverrideID(uint id);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TypingSelectFindBestLeadingMatch"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int items_count, void** get_item_name_func, void* user_data);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TypingSelectFindMatch"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TypingSelectFindMatch(ImGuiTypingSelectRequest* req, int items_count, void** get_item_name_func, void* user_data, int nav_item_idx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_TypingSelectFindNextSingleCharMatch"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImGui_TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int items_count, void** get_item_name_func, void* user_data, int nav_item_idx);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Unindent"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Unindent(float indent_w);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiMenuColumns_Update"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiMenuColumns_Update(ImGuiMenuColumns* _this, float spacing, byte window_reappearing);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_UpdateHoveredWindowAndCaptureFlags"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_UpdateHoveredWindowAndCaptureFlags();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_UpdateInputEvents"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_UpdateInputEvents(byte trickle_fast_inputs);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiDockNode_UpdateMergedFlags"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiDockNode_UpdateMergedFlags(ImGuiDockNode* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_UpdateMouseMovingWindowEndFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_UpdateMouseMovingWindowEndFrame();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_UpdateMouseMovingWindowNewFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_UpdateMouseMovingWindowNewFrame();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_UpdatePlatformWindows"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_UpdatePlatformWindows();
[LibraryImport("imgui.dll", EntryPoint = "ImGui_UpdateWindowParentAndRootLinks"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_UpdateWindowParentAndRootLinks(ImGuiWindow* window, int flags, ImGuiWindow* parent_window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_UpdateWindowSkipRefresh"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_UpdateWindowSkipRefresh(ImGuiWindow* window);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_VSliderFloat"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_VSliderFloat(byte* label, Vector2* size, float* v, float v_min, float v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_VSliderInt"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_VSliderInt(byte* label, Vector2* size, int* v, int v_min, int v_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_VSliderScalar"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial byte ImGui_VSliderScalar(byte* label, Vector2* size, int data_type, void* p_data, void* p_min, void* p_max, byte* format, int flags);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Value"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Value(byte* prefix, int v);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Value0"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Value(byte* prefix, uint v);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Value1"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Value(byte* prefix, float v, byte* float_format);
[LibraryImport("imgui.dll", EntryPoint = "ImGui_Value2"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGui_Value(byte* prefix, byte b);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__CalcCircleAutoSegmentCount"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* _this, float radius);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__ClearFreeMemory"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__ClearFreeMemory(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__OnChangedClipRect"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__OnChangedClipRect(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__OnChangedTextureID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__OnChangedTextureID(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__OnChangedVtxOffset"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__OnChangedVtxOffset(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__PathArcToFastEx"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__PathArcToFastEx(ImDrawList* _this, Vector2* center, float radius, int a_min_sample, int a_max_sample, int a_step);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__PathArcToN"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__PathArcToN(ImDrawList* _this, Vector2* center, float radius, float a_min, float a_max, int num_segments);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__PopUnusedDrawCmd"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__PopUnusedDrawCmd(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__ResetForNewFrame"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__ResetForNewFrame(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__SetTextureID"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__SetTextureID(ImDrawList* _this, ulong texture_id);
[LibraryImport("imgui.dll", EntryPoint = "ImDrawList__TryMergeDrawCmds"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImDrawList__TryMergeDrawCmds(ImDrawList* _this);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiTextBuffer_append"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiTextBuffer_append(ImGuiTextBuffer* _this, byte* str, byte* str_end);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiTextBuffer_appendfv"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiTextBuffer_appendfv(ImGuiTextBuffer* _this, byte* fmt, byte* args);
[LibraryImport("imgui.dll", EntryPoint = "ImGuiTextFilter_ImGuiTextRange_split"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
internal static partial void ImGuiTextFilter_ImGuiTextRange_split(ImGuiTextFilter__ImGuiTextRange* _this, byte separator, ImVector<ImGuiTextFilter__ImGuiTextRange>* _out);
