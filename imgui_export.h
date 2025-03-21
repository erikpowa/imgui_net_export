#pragma once

#include "imgui.h"
#include "imgui_impl_dx9.h"
#include "imgui_impl_win32.h"
#include "imgui_internal.h"
#include <wtypes.h>
#include <imgui_impl_win32.h>

extern IMGUI_IMPL_API LRESULT ImGui_ImplWin32_WndProcHandler(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam);                // Use ImGui::GetCurrentContext()
extern IMGUI_IMPL_API LRESULT ImGui_ImplWin32_WndProcHandlerEx(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam, ImGuiIO& io); // Doesn't use ImGui::GetCurrentContext()

extern "C" {
	__declspec(dllexport) const ImGuiPayload* ImGui_AcceptDragDropPayload(const char* type, int flags) { return ImGui::AcceptDragDropPayload(type, flags); }
	__declspec(dllexport) void ImGui_ActivateItemByID(unsigned int id) { ImGui::ActivateItemByID(id); }
	__declspec(dllexport) void ImRect_Add(ImRect* _this, const ImRect& r) { _this->Add(r); }
	__declspec(dllexport) void ImRect_Add0(ImRect* _this, const ImVec2& p) { _this->Add(p); }
	__declspec(dllexport) void ImDrawList_AddBezierCubic(ImDrawList* _this, const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, unsigned int col, float thickness, int num_segments) { _this->AddBezierCubic(p1, p2, p3, p4, col, thickness, num_segments); }
	__declspec(dllexport) void ImDrawList_AddBezierQuadratic(ImDrawList* _this, const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, unsigned int col, float thickness, int num_segments) { _this->AddBezierQuadratic(p1, p2, p3, col, thickness, num_segments); }
	__declspec(dllexport) void ImDrawList_AddCallback(ImDrawList* _this, void(__cdecl* callback)(const ImDrawList*, const ImDrawCmd*), void* userdata, unsigned int userdata_size) { _this->AddCallback(callback, userdata, userdata_size); }
	__declspec(dllexport) void ImDrawList_AddCircle(ImDrawList* _this, const ImVec2& center, float radius, unsigned int col, int num_segments, float thickness) { _this->AddCircle(center, radius, col, num_segments, thickness); }
	__declspec(dllexport) void ImDrawList_AddCircleFilled(ImDrawList* _this, const ImVec2& center, float radius, unsigned int col, int num_segments) { _this->AddCircleFilled(center, radius, col, num_segments); }
	__declspec(dllexport) void ImDrawList_AddConcavePolyFilled(ImDrawList* _this, const ImVec2* points, const int points_count, unsigned int col) { _this->AddConcavePolyFilled(points, points_count, col); }
	__declspec(dllexport) unsigned int ImGui_AddContextHook(ImGuiContext* ctx, const ImGuiContextHook* hook) { return ImGui::AddContextHook(ctx, hook); }
	__declspec(dllexport) void ImDrawList_AddConvexPolyFilled(ImDrawList* _this, const ImVec2* points, const int points_count, unsigned int col) { _this->AddConvexPolyFilled(points, points_count, col); }
	__declspec(dllexport) int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* _this, ImFont* font, unsigned short id, int width, int height, float advance_x, const ImVec2& offset) { return _this->AddCustomRectFontGlyph(font, id, width, height, advance_x, offset); }
	__declspec(dllexport) int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* _this, int width, int height) { return _this->AddCustomRectRegular(width, height); }
	__declspec(dllexport) void ImDrawList_AddDrawCmd(ImDrawList* _this) { _this->AddDrawCmd(); }
	__declspec(dllexport) void ImDrawData_AddDrawList(ImDrawData* _this, ImDrawList* draw_list) { _this->AddDrawList(draw_list); }
	__declspec(dllexport) void ImGui_AddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector<ImDrawList*>* out_list, ImDrawList* draw_list) { ImGui::AddDrawListToDrawDataEx(draw_data, out_list, draw_list); }
	__declspec(dllexport) void ImDrawList_AddEllipse(ImDrawList* _this, const ImVec2& center, const ImVec2& radius, unsigned int col, float rot, int num_segments, float thickness) { _this->AddEllipse(center, radius, col, rot, num_segments, thickness); }
	__declspec(dllexport) void ImDrawList_AddEllipseFilled(ImDrawList* _this, const ImVec2& center, const ImVec2& radius, unsigned int col, float rot, int num_segments) { _this->AddEllipseFilled(center, radius, col, rot, num_segments); }
	__declspec(dllexport) void ImGuiIO_AddFocusEvent(ImGuiIO* _this, bool focused) { _this->AddFocusEvent(focused); }
	__declspec(dllexport) ImFont* ImFontAtlas_AddFont(ImFontAtlas* _this, const ImFontConfig* font_cfg) { return _this->AddFont(font_cfg); }
	__declspec(dllexport) ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* _this, const ImFontConfig* font_cfg_template) { return _this->AddFontDefault(font_cfg_template); }
	__declspec(dllexport) ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* _this, const char* filename, float size_pixels, const ImFontConfig* font_cfg_template, const unsigned short* glyph_ranges) { return _this->AddFontFromFileTTF(filename, size_pixels, font_cfg_template, glyph_ranges); }
	__declspec(dllexport) ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* _this, const char* compressed_ttf_data_base85, float size_pixels, const ImFontConfig* font_cfg, const unsigned short* glyph_ranges) { return _this->AddFontFromMemoryCompressedBase85TTF(compressed_ttf_data_base85, size_pixels, font_cfg, glyph_ranges); }
	__declspec(dllexport) ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* _this, const void* compressed_ttf_data, int compressed_ttf_size, float size_pixels, const ImFontConfig* font_cfg_template, const unsigned short* glyph_ranges) { return _this->AddFontFromMemoryCompressedTTF(compressed_ttf_data, compressed_ttf_size, size_pixels, font_cfg_template, glyph_ranges); }
	__declspec(dllexport) ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* _this, void* font_data, int font_data_size, float size_pixels, const ImFontConfig* font_cfg_template, const unsigned short* glyph_ranges) { return _this->AddFontFromMemoryTTF(font_data, font_data_size, size_pixels, font_cfg_template, glyph_ranges); }
	__declspec(dllexport) void ImFont_AddGlyph(ImFont* _this, const ImFontConfig* src, unsigned short codepoint, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x) { _this->AddGlyph(src, codepoint, x0, y0, x1, y1, u0, v0, u1, v1, advance_x); }
	__declspec(dllexport) void ImDrawList_AddImage(ImDrawList* _this, unsigned long long user_texture_id, const ImVec2& p_min, const ImVec2& p_max, const ImVec2& uv_min, const ImVec2& uv_max, unsigned int col) { _this->AddImage(user_texture_id, p_min, p_max, uv_min, uv_max, col); }
	__declspec(dllexport) void ImDrawList_AddImageQuad(ImDrawList* _this, unsigned long long user_texture_id, const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, const ImVec2& uv1, const ImVec2& uv2, const ImVec2& uv3, const ImVec2& uv4, unsigned int col) { _this->AddImageQuad(user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col); }
	__declspec(dllexport) void ImDrawList_AddImageRounded(ImDrawList* _this, unsigned long long user_texture_id, const ImVec2& p_min, const ImVec2& p_max, const ImVec2& uv_min, const ImVec2& uv_max, unsigned int col, float rounding, int flags) { _this->AddImageRounded(user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, flags); }
	__declspec(dllexport) void ImGuiIO_AddInputCharacter(ImGuiIO* _this, unsigned int c) { _this->AddInputCharacter(c); }
	__declspec(dllexport) void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* _this, unsigned short c) { _this->AddInputCharacterUTF16(c); }
	__declspec(dllexport) void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* _this, const char* utf8_chars) { _this->AddInputCharactersUTF8(utf8_chars); }
	__declspec(dllexport) void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* _this, ImGuiKey key, bool down, float analog_value) { _this->AddKeyAnalogEvent(key, down, analog_value); }
	__declspec(dllexport) void ImGuiIO_AddKeyEvent(ImGuiIO* _this, ImGuiKey key, bool down) { _this->AddKeyEvent(key, down); }
	__declspec(dllexport) void ImDrawList_AddLine(ImDrawList* _this, const ImVec2& p1, const ImVec2& p2, unsigned int col, float thickness) { _this->AddLine(p1, p2, col, thickness); }
	__declspec(dllexport) void ImGuiIO_AddMouseButtonEvent(ImGuiIO* _this, int mouse_button, bool down) { _this->AddMouseButtonEvent(mouse_button, down); }
	__declspec(dllexport) void ImGuiIO_AddMousePosEvent(ImGuiIO* _this, float x, float y) { _this->AddMousePosEvent(x, y); }
	__declspec(dllexport) void ImGuiIO_AddMouseSourceEvent(ImGuiIO* _this, ImGuiMouseSource source) { _this->AddMouseSourceEvent(source); }
	__declspec(dllexport) void ImGuiIO_AddMouseViewportEvent(ImGuiIO* _this, unsigned int viewport_id) { _this->AddMouseViewportEvent(viewport_id); }
	__declspec(dllexport) void ImGuiIO_AddMouseWheelEvent(ImGuiIO* _this, float wheel_x, float wheel_y) { _this->AddMouseWheelEvent(wheel_x, wheel_y); }
	__declspec(dllexport) void ImDrawList_AddNgon(ImDrawList* _this, const ImVec2& center, float radius, unsigned int col, int num_segments, float thickness) { _this->AddNgon(center, radius, col, num_segments, thickness); }
	__declspec(dllexport) void ImDrawList_AddNgonFilled(ImDrawList* _this, const ImVec2& center, float radius, unsigned int col, int num_segments) { _this->AddNgonFilled(center, radius, col, num_segments); }
	__declspec(dllexport) void ImDrawList_AddPolyline(ImDrawList* _this, const ImVec2* points, const int points_count, unsigned int col, int flags, float thickness) { _this->AddPolyline(points, points_count, col, flags, thickness); }
	__declspec(dllexport) void ImDrawList_AddQuad(ImDrawList* _this, const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, unsigned int col, float thickness) { _this->AddQuad(p1, p2, p3, p4, col, thickness); }
	__declspec(dllexport) void ImDrawList_AddQuadFilled(ImDrawList* _this, const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, unsigned int col) { _this->AddQuadFilled(p1, p2, p3, p4, col); }
	__declspec(dllexport) void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* _this, const unsigned short* ranges) { _this->AddRanges(ranges); }
	__declspec(dllexport) void ImDrawList_AddRect(ImDrawList* _this, const ImVec2& p_min, const ImVec2& p_max, unsigned int col, float rounding, int flags, float thickness) { _this->AddRect(p_min, p_max, col, rounding, flags, thickness); }
	__declspec(dllexport) void ImDrawList_AddRectFilled(ImDrawList* _this, const ImVec2& p_min, const ImVec2& p_max, unsigned int col, float rounding, int flags) { _this->AddRectFilled(p_min, p_max, col, rounding, flags); }
	__declspec(dllexport) void ImDrawList_AddRectFilledMultiColor(ImDrawList* _this, const ImVec2& p_min, const ImVec2& p_max, unsigned int col_upr_left, unsigned int col_upr_right, unsigned int col_bot_right, unsigned int col_bot_left) { _this->AddRectFilledMultiColor(p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left); }
	__declspec(dllexport) void ImFont_AddRemapChar(ImFont* _this, unsigned short dst, unsigned short src, bool overwrite_dst) { _this->AddRemapChar(dst, src, overwrite_dst); }
	__declspec(dllexport) void ImGui_AddSettingsHandler(const ImGuiSettingsHandler* handler) { ImGui::AddSettingsHandler(handler); }
	__declspec(dllexport) void ImDrawList_AddText(ImDrawList* _this, const ImVec2& pos, unsigned int col, const char* text_begin, const char* text_end) { _this->AddText(pos, col, text_begin, text_end); }
	__declspec(dllexport) void ImDrawList_AddText0(ImDrawList* _this, ImFont* font, float font_size, const ImVec2& pos, unsigned int col, const char* text_begin, const char* text_end, float wrap_width, const ImVec4* cpu_fine_clip_rect) { _this->AddText(font, font_size, pos, col, text_begin, text_end, wrap_width, cpu_fine_clip_rect); }
	__declspec(dllexport) void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* _this, const char* text, const char* text_end) { _this->AddText(text, text_end); }
	__declspec(dllexport) void ImDrawList_AddTriangle(ImDrawList* _this, const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, unsigned int col, float thickness) { _this->AddTriangle(p1, p2, p3, col, thickness); }
	__declspec(dllexport) void ImDrawList_AddTriangleFilled(ImDrawList* _this, const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, unsigned int col) { _this->AddTriangleFilled(p1, p2, p3, col); }
	__declspec(dllexport) void ImGui_AlignTextToFramePadding() { ImGui::AlignTextToFramePadding(); }
	__declspec(dllexport) void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* _this, ImGuiMultiSelectIO* ms_io) { _this->ApplyRequests(ms_io); }
	__declspec(dllexport) void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* _this, ImGuiMultiSelectIO* ms_io) { _this->ApplyRequests(ms_io); }
	__declspec(dllexport) bool ImGui_ArrowButton(const char* str_id, ImGuiDir dir) { return ImGui::ArrowButton(str_id, dir); }
	__declspec(dllexport) bool ImGui_ArrowButtonEx(const char* str_id, ImGuiDir dir, ImVec2 size, int flags) { return ImGui::ArrowButtonEx(str_id, dir, size, flags); }
	__declspec(dllexport) bool ImGui_Begin(const char* name, bool* p_open, int flags) { return ImGui::Begin(name, p_open, flags); }
	__declspec(dllexport) void ImGuiListClipper_Begin(ImGuiListClipper* _this, int items_count, float items_height) { _this->Begin(items_count, items_height); }
	__declspec(dllexport) bool ImGui_BeginBoxSelect(const ImRect& scope_rect, ImGuiWindow* window, unsigned int box_select_id, int ms_flags) { return ImGui::BeginBoxSelect(scope_rect, window, box_select_id, ms_flags); }
	__declspec(dllexport) bool ImGui_BeginChild(unsigned int id, const ImVec2& size_arg, int child_flags, int window_flags) { return ImGui::BeginChild(id, size_arg, child_flags, window_flags); }
	__declspec(dllexport) bool ImGui_BeginChild0(const char* str_id, const ImVec2& size_arg, int child_flags, int window_flags) { return ImGui::BeginChild(str_id, size_arg, child_flags, window_flags); }
	__declspec(dllexport) bool ImGui_BeginChildEx(const char* name, unsigned int id, const ImVec2& size_arg, int child_flags, int window_flags) { return ImGui::BeginChildEx(name, id, size_arg, child_flags, window_flags); }
	__declspec(dllexport) void ImGui_BeginColumns(const char* str_id, int columns_count, int flags) { ImGui::BeginColumns(str_id, columns_count, flags); }
	__declspec(dllexport) bool ImGui_BeginCombo(const char* label, const char* preview_value, int flags) { return ImGui::BeginCombo(label, preview_value, flags); }
	__declspec(dllexport) bool ImGui_BeginComboPopup(unsigned int popup_id, const ImRect& bb, int flags) { return ImGui::BeginComboPopup(popup_id, bb, flags); }
	__declspec(dllexport) bool ImGui_BeginComboPreview() { return ImGui::BeginComboPreview(); }
	__declspec(dllexport) void ImGui_BeginDisabled(bool disabled) { ImGui::BeginDisabled(disabled); }
	__declspec(dllexport) void ImGui_BeginDisabledOverrideReenable() { ImGui::BeginDisabledOverrideReenable(); }
	__declspec(dllexport) void ImGui_BeginDockableDragDropSource(ImGuiWindow* window) { ImGui::BeginDockableDragDropSource(window); }
	__declspec(dllexport) void ImGui_BeginDockableDragDropTarget(ImGuiWindow* window) { ImGui::BeginDockableDragDropTarget(window); }
	__declspec(dllexport) void ImGui_BeginDocked(ImGuiWindow* window, bool* p_open) { ImGui::BeginDocked(window, p_open); }
	__declspec(dllexport) bool ImGui_BeginDragDropSource(int flags) { return ImGui::BeginDragDropSource(flags); }
	__declspec(dllexport) bool ImGui_BeginDragDropTarget() { return ImGui::BeginDragDropTarget(); }
	__declspec(dllexport) bool ImGui_BeginDragDropTargetCustom(const ImRect& bb, unsigned int id) { return ImGui::BeginDragDropTargetCustom(bb, id); }
	__declspec(dllexport) bool ImGui_BeginErrorTooltip() { return ImGui::BeginErrorTooltip(); }
	__declspec(dllexport) void ImGui_BeginGroup() { ImGui::BeginGroup(); }
	__declspec(dllexport) bool ImGui_BeginItemTooltip() { return ImGui::BeginItemTooltip(); }
	__declspec(dllexport) bool ImGui_BeginListBox(const char* label, const ImVec2& size_arg) { return ImGui::BeginListBox(label, size_arg); }
	__declspec(dllexport) bool ImGui_BeginMainMenuBar() { return ImGui::BeginMainMenuBar(); }
	__declspec(dllexport) bool ImGui_BeginMenu(const char* label, bool enabled) { return ImGui::BeginMenu(label, enabled); }
	__declspec(dllexport) bool ImGui_BeginMenuBar() { return ImGui::BeginMenuBar(); }
	__declspec(dllexport) bool ImGui_BeginMenuEx(const char* label, const char* icon, bool enabled) { return ImGui::BeginMenuEx(label, icon, enabled); }
	__declspec(dllexport) ImGuiMultiSelectIO* ImGui_BeginMultiSelect(int flags, int selection_size, int items_count) { return ImGui::BeginMultiSelect(flags, selection_size, items_count); }
	__declspec(dllexport) bool ImGui_BeginPopup(const char* str_id, int flags) { return ImGui::BeginPopup(str_id, flags); }
	__declspec(dllexport) bool ImGui_BeginPopupContextItem(const char* str_id, int popup_flags) { return ImGui::BeginPopupContextItem(str_id, popup_flags); }
	__declspec(dllexport) bool ImGui_BeginPopupContextVoid(const char* str_id, int popup_flags) { return ImGui::BeginPopupContextVoid(str_id, popup_flags); }
	__declspec(dllexport) bool ImGui_BeginPopupContextWindow(const char* str_id, int popup_flags) { return ImGui::BeginPopupContextWindow(str_id, popup_flags); }
	__declspec(dllexport) bool ImGui_BeginPopupEx(unsigned int id, int extra_window_flags) { return ImGui::BeginPopupEx(id, extra_window_flags); }
	__declspec(dllexport) bool ImGui_BeginPopupMenuEx(unsigned int id, const char* label, int extra_window_flags) { return ImGui::BeginPopupMenuEx(id, label, extra_window_flags); }
	__declspec(dllexport) bool ImGui_BeginPopupModal(const char* name, bool* p_open, int flags) { return ImGui::BeginPopupModal(name, p_open, flags); }
	__declspec(dllexport) bool ImGui_BeginTabBar(const char* str_id, int flags) { return ImGui::BeginTabBar(str_id, flags); }
	__declspec(dllexport) bool ImGui_BeginTabBarEx(ImGuiTabBar* tab_bar, const ImRect& tab_bar_bb, int flags) { return ImGui::BeginTabBarEx(tab_bar, tab_bar_bb, flags); }
	__declspec(dllexport) bool ImGui_BeginTabItem(const char* label, bool* p_open, int flags) { return ImGui::BeginTabItem(label, p_open, flags); }
	__declspec(dllexport) bool ImGui_BeginTable(const char* str_id, int columns_count, int flags, const ImVec2& outer_size, float inner_width) { return ImGui::BeginTable(str_id, columns_count, flags, outer_size, inner_width); }
	__declspec(dllexport) bool ImGui_BeginTableEx(const char* name, unsigned int id, int columns_count, int flags, const ImVec2& outer_size, float inner_width) { return ImGui::BeginTableEx(name, id, columns_count, flags, outer_size, inner_width); }
	__declspec(dllexport) bool ImGui_BeginTooltip() { return ImGui::BeginTooltip(); }
	__declspec(dllexport) bool ImGui_BeginTooltipEx(int tooltip_flags, int extra_window_flags) { return ImGui::BeginTooltipEx(tooltip_flags, extra_window_flags); }
	__declspec(dllexport) bool ImGui_BeginTooltipHidden() { return ImGui::BeginTooltipHidden(); }
	__declspec(dllexport) bool ImGui_BeginViewportSideBar(const char* name, ImGuiViewport* viewport_p, ImGuiDir dir, float axis_size, int window_flags) { return ImGui::BeginViewportSideBar(name, viewport_p, dir, axis_size, window_flags); }
	__declspec(dllexport) void ImGui_BringWindowToDisplayBack(ImGuiWindow* window) { ImGui::BringWindowToDisplayBack(window); }
	__declspec(dllexport) void ImGui_BringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* behind_window) { ImGui::BringWindowToDisplayBehind(window, behind_window); }
	__declspec(dllexport) void ImGui_BringWindowToDisplayFront(ImGuiWindow* window) { ImGui::BringWindowToDisplayFront(window); }
	__declspec(dllexport) void ImGui_BringWindowToFocusFront(ImGuiWindow* window) { ImGui::BringWindowToFocusFront(window); }
	__declspec(dllexport) bool ImFontAtlas_Build(ImFontAtlas* _this) { return _this->Build(); }
	__declspec(dllexport) void ImGuiTextFilter_Build(ImGuiTextFilter* _this) { _this->Build(); }
	__declspec(dllexport) void ImFont_BuildLookupTable(ImFont* _this) { _this->BuildLookupTable(); }
	__declspec(dllexport) void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* _this, ImVector<unsigned short>* out_ranges) { _this->BuildRanges(out_ranges); }
	__declspec(dllexport) void ImGuiStorage_BuildSortByKey(ImGuiStorage* _this) { _this->BuildSortByKey(); }
	__declspec(dllexport) void ImGui_Bullet() { ImGui::Bullet(); }
	__declspec(dllexport) void ImGui_BulletTextV(const char* fmt, char* args) { ImGui::BulletTextV(fmt, args); }
	__declspec(dllexport) bool ImGui_Button(const char* label, const ImVec2& size_arg) { return ImGui::Button(label, size_arg); }
	__declspec(dllexport) bool ImGui_ButtonBehavior(const ImRect& bb, unsigned int id, bool* out_hovered, bool* out_held, int flags) { return ImGui::ButtonBehavior(bb, id, out_hovered, out_held, flags); }
	__declspec(dllexport) bool ImGui_ButtonEx(const char* label, const ImVec2& size_arg, int flags) { return ImGui::ButtonEx(label, size_arg, flags); }
	__declspec(dllexport) void ImFontAtlas_CalcCustomRectUV(const ImFontAtlas* _this, const ImFontAtlasCustomRect* rect, ImVec2* out_uv_min, ImVec2* out_uv_max) { _this->CalcCustomRectUV(rect, out_uv_min, out_uv_max); }
	__declspec(dllexport) float ImGuiWindow_CalcFontSize(const ImGuiWindow* _this) { return _this->CalcFontSize(); }
	__declspec(dllexport) ImVec2 ImGui_CalcItemSize(ImVec2 size, float default_w, float default_h) { return ImGui::CalcItemSize(size, default_w, default_h); }
	__declspec(dllexport) float ImGui_CalcItemWidth() { return ImGui::CalcItemWidth(); }
	__declspec(dllexport) void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* _this, bool update_offsets) { _this->CalcNextTotalWidth(update_offsets); }
	__declspec(dllexport) int ImGui_CalcRoundingFlagsForRectInRect(const ImRect& r_in, const ImRect& r_outer, float threshold) { return ImGui::CalcRoundingFlagsForRectInRect(r_in, r_outer, threshold); }
	__declspec(dllexport) ImVec2 ImGui_CalcTextSize(const char* text, const char* text_end, bool hide_text_after_double_hash, float wrap_width) { return ImGui::CalcTextSize(text, text_end, hide_text_after_double_hash, wrap_width); }
	__declspec(dllexport) ImVec2 ImFont_CalcTextSizeA(ImFont* _this, float size, float max_width, float wrap_width, const char* text_begin, const char* text_end, const char** remaining) { return _this->CalcTextSizeA(size, max_width, wrap_width, text_begin, text_end, remaining); }
	__declspec(dllexport) int ImGui_CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate) { return ImGui::CalcTypematicRepeatAmount(t0, t1, repeat_delay, repeat_rate); }
	__declspec(dllexport) ImVec2 ImGui_CalcWindowNextAutoFitSize(ImGuiWindow* window) { return ImGui::CalcWindowNextAutoFitSize(window); }
	__declspec(dllexport) const char* ImFont_CalcWordWrapPositionA(ImFont* _this, float scale, const char* text, const char* text_end, float wrap_width) { return _this->CalcWordWrapPositionA(scale, text, text_end, wrap_width); }
	__declspec(dllexport) float ImGui_CalcWrapWidthForPos(const ImVec2& pos, float wrap_pos_x) { return ImGui::CalcWrapWidthForPos(pos, wrap_pos_x); }
	__declspec(dllexport) void ImGui_CallContextHooks(ImGuiContext* ctx, ImGuiContextHookType hook_type) { ImGui::CallContextHooks(ctx, hook_type); }
	__declspec(dllexport) bool ImGui_Checkbox(const char* label, bool* v) { return ImGui::Checkbox(label, v); }
	__declspec(dllexport) bool ImGui_CheckboxFlags(const char* label, int* flags, int flags_value) { return ImGui::CheckboxFlags(label, flags, flags_value); }
	__declspec(dllexport) bool ImGui_CheckboxFlags0(const char* label, unsigned int* flags, unsigned int flags_value) { return ImGui::CheckboxFlags(label, flags, flags_value); }
	__declspec(dllexport) bool ImGui_CheckboxFlags1(const char* label, long long* flags, long long flags_value) { return ImGui::CheckboxFlags(label, flags, flags_value); }
	__declspec(dllexport) bool ImGui_CheckboxFlags2(const char* label, unsigned long long* flags, unsigned long long flags_value) { return ImGui::CheckboxFlags(label, flags, flags_value); }
	__declspec(dllexport) void ImBitVector_Clear(ImBitVector* _this) { _this->Clear(); }
	__declspec(dllexport) void ImDrawData_Clear(ImDrawData* _this) { _this->Clear(); }
	__declspec(dllexport) void ImFontAtlas_Clear(ImFontAtlas* _this) { _this->Clear(); }
	__declspec(dllexport) void ImGuiMultiSelectTempData_Clear(ImGuiMultiSelectTempData* _this) { _this->Clear(); }
	__declspec(dllexport) void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* _this) { _this->Clear(); }
	__declspec(dllexport) void ImGuiTypingSelectState_Clear(ImGuiTypingSelectState* _this) { _this->Clear(); }
	__declspec(dllexport) void ImGui_ClearActiveID() { ImGui::ClearActiveID(); }
	__declspec(dllexport) void ImBitVector_ClearBit(ImBitVector* _this, int n) { _this->ClearBit(n); }
	__declspec(dllexport) void ImGui_ClearDragDrop() { ImGui::ClearDragDrop(); }
	__declspec(dllexport) void ImGuiIO_ClearEventsQueue(ImGuiIO* _this) { _this->ClearEventsQueue(); }
	__declspec(dllexport) void ImFontAtlas_ClearFonts(ImFontAtlas* _this) { _this->ClearFonts(); }
	__declspec(dllexport) void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* _this) { _this->ClearFreeMemory(); }
	__declspec(dllexport) void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* _this) { _this->ClearFreeMemory(); }
	__declspec(dllexport) void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* _this) { _this->ClearFreeMemory(); }
	__declspec(dllexport) void ImGuiMultiSelectTempData_ClearIO(ImGuiMultiSelectTempData* _this) { _this->ClearIO(); }
	__declspec(dllexport) void ImGui_ClearIniSettings() { ImGui::ClearIniSettings(); }
	__declspec(dllexport) void ImFontAtlas_ClearInputData(ImFontAtlas* _this) { _this->ClearInputData(); }
	__declspec(dllexport) void ImGuiIO_ClearInputKeys(ImGuiIO* _this) { _this->ClearInputKeys(); }
	__declspec(dllexport) void ImGuiIO_ClearInputMouse(ImGuiIO* _this) { _this->ClearInputMouse(); }
	__declspec(dllexport) void ImFont_ClearOutputData(ImFont* _this) { _this->ClearOutputData(); }
	__declspec(dllexport) void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* _this) { _this->ClearSelection(); }
	__declspec(dllexport) void ImFontAtlas_ClearTexData(ImFontAtlas* _this) { _this->ClearTexData(); }
	__declspec(dllexport) void ImGuiInputTextState_ClearText(ImGuiInputTextState* _this) { _this->ClearText(); }
	__declspec(dllexport) void ImGui_ClearWindowSettings(const char* name) { ImGui::ClearWindowSettings(name); }
	__declspec(dllexport) void ImRect_ClipWith(ImRect* _this, const ImRect& r) { _this->ClipWith(r); }
	__declspec(dllexport) void ImRect_ClipWithFull(ImRect* _this, const ImRect& r) { _this->ClipWithFull(r); }
	__declspec(dllexport) ImDrawList* ImDrawList_CloneOutput(const ImDrawList* _this) { return _this->CloneOutput(); }
	__declspec(dllexport) bool ImGui_CloseButton(unsigned int id, const ImVec2& pos) { return ImGui::CloseButton(id, pos); }
	__declspec(dllexport) void ImGui_CloseCurrentPopup() { ImGui::CloseCurrentPopup(); }
	__declspec(dllexport) void ImGui_ClosePopupToLevel(int remaining, bool restore_focus_to_window_under_popup) { ImGui::ClosePopupToLevel(remaining, restore_focus_to_window_under_popup); }
	__declspec(dllexport) void ImGui_ClosePopupsExceptModals() { ImGui::ClosePopupsExceptModals(); }
	__declspec(dllexport) void ImGui_ClosePopupsOverWindow(ImGuiWindow* ref_window, bool restore_focus_to_window_under_popup) { ImGui::ClosePopupsOverWindow(ref_window, restore_focus_to_window_under_popup); }
	__declspec(dllexport) bool ImGui_CollapseButton(unsigned int id, const ImVec2& pos, ImGuiDockNode* dock_node) { return ImGui::CollapseButton(id, pos, dock_node); }
	__declspec(dllexport) bool ImGui_CollapsingHeader(const char* label, int flags) { return ImGui::CollapsingHeader(label, flags); }
	__declspec(dllexport) bool ImGui_CollapsingHeader0(const char* label, bool* p_visible, int flags) { return ImGui::CollapsingHeader(label, p_visible, flags); }
	__declspec(dllexport) bool ImGui_ColorButton(const char* desc_id, const ImVec4& col, int flags, const ImVec2& size_arg) { return ImGui::ColorButton(desc_id, col, flags, size_arg); }
	__declspec(dllexport) unsigned int ImGui_ColorConvertFloat4ToU32(const ImVec4& in) { return ImGui::ColorConvertFloat4ToU32(in); }
	__declspec(dllexport) void ImGui_ColorConvertHSVtoRGB(float h, float s, float v, float& out_r, float& out_g, float& out_b) { ImGui::ColorConvertHSVtoRGB(h, s, v, out_r, out_g, out_b); }
	__declspec(dllexport) void ImGui_ColorConvertRGBtoHSV(float r, float g, float b, float& out_h, float& out_s, float& out_v) { ImGui::ColorConvertRGBtoHSV(r, g, b, out_h, out_s, out_v); }
	__declspec(dllexport) ImVec4 ImGui_ColorConvertU32ToFloat4(unsigned int in) { return ImGui::ColorConvertU32ToFloat4(in); }
	__declspec(dllexport) bool ImGui_ColorEdit3(const char* label, float* col, int flags) { return ImGui::ColorEdit3(label, col, flags); }
	__declspec(dllexport) bool ImGui_ColorEdit4(const char* label, float* col, int flags) { return ImGui::ColorEdit4(label, col, flags); }
	__declspec(dllexport) void ImGui_ColorEditOptionsPopup(const float* col, int flags) { ImGui::ColorEditOptionsPopup(col, flags); }
	__declspec(dllexport) bool ImGui_ColorPicker3(const char* label, float* col, int flags) { return ImGui::ColorPicker3(label, col, flags); }
	__declspec(dllexport) bool ImGui_ColorPicker4(const char* label, float* col, int flags, const float* ref_col) { return ImGui::ColorPicker4(label, col, flags, ref_col); }
	__declspec(dllexport) void ImGui_ColorPickerOptionsPopup(const float* ref_col, int flags) { ImGui::ColorPickerOptionsPopup(ref_col, flags); }
	__declspec(dllexport) void ImGui_ColorTooltip(const char* text, const float* col, int flags) { ImGui::ColorTooltip(text, col, flags); }
	__declspec(dllexport) void ImGui_Columns(int columns_count, const char* id, bool borders) { ImGui::Columns(columns_count, id, borders); }
	__declspec(dllexport) bool ImGui_Combo(const char* label, int* current_item, const char* items_separated_by_zeros, int height_in_items) { return ImGui::Combo(label, current_item, items_separated_by_zeros, height_in_items); }
	__declspec(dllexport) bool ImGui_Combo0(const char* label, int* current_item, const char* (__cdecl* getter)(void*, int), void* user_data, int items_count, int popup_max_height_in_items) { return ImGui::Combo(label, current_item, getter, user_data, items_count, popup_max_height_in_items); }
	__declspec(dllexport) bool ImGui_Combo1(const char* label, int* current_item, const char** items, int items_count, int height_in_items) { return ImGui::Combo(label, current_item, items, items_count, height_in_items); }
	__declspec(dllexport) bool ImGuiSelectionBasicStorage_Contains(const ImGuiSelectionBasicStorage* _this, unsigned int id) { return _this->Contains(id); }
	__declspec(dllexport) bool ImRect_Contains(const ImRect* _this, const ImRect& r) { return _this->Contains(r); }
	__declspec(dllexport) bool ImRect_Contains0(const ImRect* _this, const ImVec2& p) { return _this->Contains(p); }
	__declspec(dllexport) bool ImRect_ContainsWithPad(const ImRect* _this, const ImVec2& p, const ImVec2& pad) { return _this->ContainsWithPad(p, pad); }
	__declspec(dllexport) void ImBitVector_Create(ImBitVector* _this, int sz) { _this->Create(sz); }
	__declspec(dllexport) ImGuiContext* ImGui_CreateContext(ImFontAtlas* shared_font_atlas) { return ImGui::CreateContext(shared_font_atlas); }
	__declspec(dllexport) ImGuiWindowSettings* ImGui_CreateNewWindowSettings(const char* name) { return ImGui::CreateNewWindowSettings(name); }
	__declspec(dllexport) void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* _this) { _this->CursorAnimReset(); }
	__declspec(dllexport) void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* _this) { _this->CursorClamp(); }
	__declspec(dllexport) bool ImGui_DataTypeApplyFromText(const char* buf, int data_type, void* p_data, const char* format, void* p_data_when_empty) { return ImGui::DataTypeApplyFromText(buf, data_type, p_data, format, p_data_when_empty); }
	__declspec(dllexport) void ImGui_DataTypeApplyOp(int data_type, int op, void* output, const void* arg1, const void* arg2) { ImGui::DataTypeApplyOp(data_type, op, output, arg1, arg2); }
	__declspec(dllexport) bool ImGui_DataTypeClamp(int data_type, void* p_data, const void* p_min, const void* p_max) { return ImGui::DataTypeClamp(data_type, p_data, p_min, p_max); }
	__declspec(dllexport) int ImGui_DataTypeCompare(int data_type, const void* arg_1, const void* arg_2) { return ImGui::DataTypeCompare(data_type, arg_1, arg_2); }
	__declspec(dllexport) int ImGui_DataTypeFormatString(char* buf, int buf_size, int data_type, const void* p_data, const char* format) { return ImGui::DataTypeFormatString(buf, buf_size, data_type, p_data, format); }
	__declspec(dllexport) const ImGuiDataTypeInfo* ImGui_DataTypeGetInfo(int data_type) { return ImGui::DataTypeGetInfo(data_type); }
	__declspec(dllexport) bool ImGui_DataTypeIsZero(int data_type, const void* p_data) { return ImGui::DataTypeIsZero(data_type, p_data); }
	__declspec(dllexport) void ImDrawData_DeIndexAllBuffers(ImDrawData* _this) { _this->DeIndexAllBuffers(); }
	__declspec(dllexport) void ImGui_DebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, unsigned int size) { ImGui::DebugAllocHook(info, frame_count, ptr, size); }
	__declspec(dllexport) bool ImGui_DebugCheckVersionAndDataLayout(const char* version, unsigned int sz_io, unsigned int sz_style, unsigned int sz_vec2, unsigned int sz_vec4, unsigned int sz_vert, unsigned int sz_idx) { return ImGui::DebugCheckVersionAndDataLayout(version, sz_io, sz_style, sz_vec2, sz_vec4, sz_vert, sz_idx); }
	__declspec(dllexport) float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* _this, float w_icon, float w_label, float w_shortcut, float w_mark) { return _this->DeclColumns(w_icon, w_label, w_shortcut, w_mark); }
	__declspec(dllexport) void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* _this, int pos, int bytes_count) { _this->DeleteChars(pos, bytes_count); }
	__declspec(dllexport) void ImGui_DestroyContext(ImGuiContext* ctx) { ImGui::DestroyContext(ctx); }
	__declspec(dllexport) void ImGui_DestroyPlatformWindow(ImGuiViewportP* viewport) { ImGui::DestroyPlatformWindow(viewport); }
	__declspec(dllexport) void ImGui_DestroyPlatformWindows() { ImGui::DestroyPlatformWindows(); }
	__declspec(dllexport) unsigned int ImGui_DockBuilderAddNode(unsigned int node_id, int flags) { return ImGui::DockBuilderAddNode(node_id, flags); }
	__declspec(dllexport) void ImGui_DockBuilderCopyDockSpace(unsigned int src_dockspace_id, unsigned int dst_dockspace_id, ImVector<char const*>* in_window_remap_pairs) { ImGui::DockBuilderCopyDockSpace(src_dockspace_id, dst_dockspace_id, in_window_remap_pairs); }
	__declspec(dllexport) void ImGui_DockBuilderCopyNode(unsigned int src_node_id, unsigned int dst_node_id, ImVector<unsigned int>* out_node_remap_pairs) { ImGui::DockBuilderCopyNode(src_node_id, dst_node_id, out_node_remap_pairs); }
	__declspec(dllexport) void ImGui_DockBuilderCopyWindowSettings(const char* src_name, const char* dst_name) { ImGui::DockBuilderCopyWindowSettings(src_name, dst_name); }
	__declspec(dllexport) void ImGui_DockBuilderDockWindow(const char* window_name, unsigned int node_id) { ImGui::DockBuilderDockWindow(window_name, node_id); }
	__declspec(dllexport) void ImGui_DockBuilderFinish(unsigned int root_id) { ImGui::DockBuilderFinish(root_id); }
	__declspec(dllexport) ImGuiDockNode* ImGui_DockBuilderGetNode(unsigned int node_id) { return ImGui::DockBuilderGetNode(node_id); }
	__declspec(dllexport) void ImGui_DockBuilderRemoveNode(unsigned int node_id) { ImGui::DockBuilderRemoveNode(node_id); }
	__declspec(dllexport) void ImGui_DockBuilderRemoveNodeChildNodes(unsigned int root_id) { ImGui::DockBuilderRemoveNodeChildNodes(root_id); }
	__declspec(dllexport) void ImGui_DockBuilderRemoveNodeDockedWindows(unsigned int root_id, bool clear_settings_refs) { ImGui::DockBuilderRemoveNodeDockedWindows(root_id, clear_settings_refs); }
	__declspec(dllexport) void ImGui_DockBuilderSetNodePos(unsigned int node_id, ImVec2 pos) { ImGui::DockBuilderSetNodePos(node_id, pos); }
	__declspec(dllexport) void ImGui_DockBuilderSetNodeSize(unsigned int node_id, ImVec2 size) { ImGui::DockBuilderSetNodeSize(node_id, size); }
	__declspec(dllexport) unsigned int ImGui_DockBuilderSplitNode(unsigned int id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, unsigned int* out_id_at_dir, unsigned int* out_id_at_opposite_dir) { return ImGui::DockBuilderSplitNode(id, split_dir, size_ratio_for_node_at_dir, out_id_at_dir, out_id_at_opposite_dir); }
	__declspec(dllexport) bool ImGui_DockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, bool split_outer, ImVec2* out_pos) { return ImGui::DockContextCalcDropPosForDocking(target, target_node, payload_window, payload_node, split_dir, split_outer, out_pos); }
	__declspec(dllexport) void ImGui_DockContextClearNodes(ImGuiContext* ctx, unsigned int root_id, bool clear_settings_refs) { ImGui::DockContextClearNodes(ctx, root_id, clear_settings_refs); }
	__declspec(dllexport) void ImGui_DockContextEndFrame(ImGuiContext* ctx) { ImGui::DockContextEndFrame(ctx); }
	__declspec(dllexport) ImGuiDockNode* ImGui_DockContextFindNodeByID(ImGuiContext* ctx, unsigned int id) { return ImGui::DockContextFindNodeByID(ctx, id); }
	__declspec(dllexport) unsigned int ImGui_DockContextGenNodeID(ImGuiContext* ctx) { return ImGui::DockContextGenNodeID(ctx); }
	__declspec(dllexport) void ImGui_DockContextInitialize(ImGuiContext* ctx) { ImGui::DockContextInitialize(ctx); }
	__declspec(dllexport) void ImGui_DockContextNewFrameUpdateDocking(ImGuiContext* ctx) { ImGui::DockContextNewFrameUpdateDocking(ctx); }
	__declspec(dllexport) void ImGui_DockContextNewFrameUpdateUndocking(ImGuiContext* ctx) { ImGui::DockContextNewFrameUpdateUndocking(ctx); }
	__declspec(dllexport) void ImGui_DockContextProcessUndockNode(ImGuiContext* ctx, ImGuiDockNode* node) { ImGui::DockContextProcessUndockNode(ctx, node); }
	__declspec(dllexport) void ImGui_DockContextProcessUndockWindow(ImGuiContext* ctx, ImGuiWindow* window, bool clear_persistent_docking_ref) { ImGui::DockContextProcessUndockWindow(ctx, window, clear_persistent_docking_ref); }
	__declspec(dllexport) void ImGui_DockContextQueueDock(ImGuiContext* ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, bool split_outer) { ImGui::DockContextQueueDock(ctx, target, target_node, payload, split_dir, split_ratio, split_outer); }
	__declspec(dllexport) void ImGui_DockContextQueueUndockNode(ImGuiContext* ctx, ImGuiDockNode* node) { ImGui::DockContextQueueUndockNode(ctx, node); }
	__declspec(dllexport) void ImGui_DockContextQueueUndockWindow(ImGuiContext* ctx, ImGuiWindow* window) { ImGui::DockContextQueueUndockWindow(ctx, window); }
	__declspec(dllexport) void ImGui_DockContextRebuildNodes(ImGuiContext* ctx) { ImGui::DockContextRebuildNodes(ctx); }
	__declspec(dllexport) void ImGui_DockContextShutdown(ImGuiContext* ctx) { ImGui::DockContextShutdown(ctx); }
	__declspec(dllexport) bool ImGui_DockNodeBeginAmendTabBar(ImGuiDockNode* node) { return ImGui::DockNodeBeginAmendTabBar(node); }
	__declspec(dllexport) void ImGui_DockNodeEndAmendTabBar() { ImGui::DockNodeEndAmendTabBar(); }
	__declspec(dllexport) void ImGui_DockNodeWindowMenuHandler_Default(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar) { ImGui::DockNodeWindowMenuHandler_Default(ctx, node, tab_bar); }
	__declspec(dllexport) unsigned int ImGui_DockSpace(unsigned int dockspace_id, const ImVec2& size_arg, int flags, const ImGuiWindowClass* window_class) { return ImGui::DockSpace(dockspace_id, size_arg, flags, window_class); }
	__declspec(dllexport) unsigned int ImGui_DockSpaceOverViewport(unsigned int dockspace_id, const ImGuiViewport* viewport, int dockspace_flags, const ImGuiWindowClass* window_class) { return ImGui::DockSpaceOverViewport(dockspace_id, viewport, dockspace_flags, window_class); }
	__declspec(dllexport) bool ImGui_DragBehavior(unsigned int id, int data_type, void* p_v, float v_speed, const void* p_min, const void* p_max, const char* format, int flags) { return ImGui::DragBehavior(id, data_type, p_v, v_speed, p_min, p_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragFloat2(const char* label, float* v, float v_speed, float v_min, float v_max, const char* format, int flags) { return ImGui::DragFloat2(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragFloat3(const char* label, float* v, float v_speed, float v_min, float v_max, const char* format, int flags) { return ImGui::DragFloat3(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragFloat4(const char* label, float* v, float v_speed, float v_min, float v_max, const char* format, int flags) { return ImGui::DragFloat4(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragFloat(const char* label, float* v, float v_speed, float v_min, float v_max, const char* format, int flags) { return ImGui::DragFloat(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragFloatRange2(const char* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, const char* format, const char* format_max, int flags) { return ImGui::DragFloatRange2(label, v_current_min, v_current_max, v_speed, v_min, v_max, format, format_max, flags); }
	__declspec(dllexport) bool ImGui_DragInt2(const char* label, int* v, float v_speed, int v_min, int v_max, const char* format, int flags) { return ImGui::DragInt2(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragInt3(const char* label, int* v, float v_speed, int v_min, int v_max, const char* format, int flags) { return ImGui::DragInt3(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragInt4(const char* label, int* v, float v_speed, int v_min, int v_max, const char* format, int flags) { return ImGui::DragInt4(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragInt(const char* label, int* v, float v_speed, int v_min, int v_max, const char* format, int flags) { return ImGui::DragInt(label, v, v_speed, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragIntRange2(const char* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, const char* format, const char* format_max, int flags) { return ImGui::DragIntRange2(label, v_current_min, v_current_max, v_speed, v_min, v_max, format, format_max, flags); }
	__declspec(dllexport) bool ImGui_DragScalar(const char* label, int data_type, void* p_data, float v_speed, const void* p_min, const void* p_max, const char* format, int flags) { return ImGui::DragScalar(label, data_type, p_data, v_speed, p_min, p_max, format, flags); }
	__declspec(dllexport) bool ImGui_DragScalarN(const char* label, int data_type, void* p_data, int components, float v_speed, const void* p_min, const void* p_max, const char* format, int flags) { return ImGui::DragScalarN(label, data_type, p_data, components, v_speed, p_min, p_max, format, flags); }
	__declspec(dllexport) bool ImGuiTextFilter_Draw(ImGuiTextFilter* _this, const char* label, float width) { return _this->Draw(label, width); }
	__declspec(dllexport) void ImGui_Dummy(const ImVec2& size) { ImGui::Dummy(size); }
	__declspec(dllexport) void ImGui_End() { ImGui::End(); }
	__declspec(dllexport) void ImGuiListClipper_End(ImGuiListClipper* _this) { _this->End(); }
	__declspec(dllexport) void ImGui_EndBoxSelect(const ImRect& scope_rect, int ms_flags) { ImGui::EndBoxSelect(scope_rect, ms_flags); }
	__declspec(dllexport) void ImGui_EndChild() { ImGui::EndChild(); }
	__declspec(dllexport) void ImGui_EndColumns() { ImGui::EndColumns(); }
	__declspec(dllexport) void ImGui_EndCombo() { ImGui::EndCombo(); }
	__declspec(dllexport) void ImGui_EndComboPreview() { ImGui::EndComboPreview(); }
	__declspec(dllexport) void ImGui_EndDisabled() { ImGui::EndDisabled(); }
	__declspec(dllexport) void ImGui_EndDisabledOverrideReenable() { ImGui::EndDisabledOverrideReenable(); }
	__declspec(dllexport) void ImGui_EndDragDropSource() { ImGui::EndDragDropSource(); }
	__declspec(dllexport) void ImGui_EndDragDropTarget() { ImGui::EndDragDropTarget(); }
	__declspec(dllexport) void ImGui_EndErrorTooltip() { ImGui::EndErrorTooltip(); }
	__declspec(dllexport) void ImGui_EndFrame() { ImGui::EndFrame(); }
	__declspec(dllexport) void ImGui_EndGroup() { ImGui::EndGroup(); }
	__declspec(dllexport) void ImGui_EndListBox() { ImGui::EndListBox(); }
	__declspec(dllexport) void ImGui_EndMainMenuBar() { ImGui::EndMainMenuBar(); }
	__declspec(dllexport) void ImGui_EndMenu() { ImGui::EndMenu(); }
	__declspec(dllexport) void ImGui_EndMenuBar() { ImGui::EndMenuBar(); }
	__declspec(dllexport) ImGuiMultiSelectIO* ImGui_EndMultiSelect() { return ImGui::EndMultiSelect(); }
	__declspec(dllexport) void ImGui_EndPopup() { ImGui::EndPopup(); }
	__declspec(dllexport) void ImGui_EndTabBar() { ImGui::EndTabBar(); }
	__declspec(dllexport) void ImGui_EndTabItem() { ImGui::EndTabItem(); }
	__declspec(dllexport) void ImGui_EndTable() { ImGui::EndTable(); }
	__declspec(dllexport) void ImGui_EndTooltip() { ImGui::EndTooltip(); }
	__declspec(dllexport) void ImGui_ErrorCheckUsingSetCursorPosToExtendParentBoundaries() { ImGui::ErrorCheckUsingSetCursorPosToExtendParentBoundaries(); }
	__declspec(dllexport) bool ImGui_ErrorLog(const char* msg) { return ImGui::ErrorLog(msg); }
	__declspec(dllexport) void ImGui_ErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out) { ImGui::ErrorRecoveryStoreState(state_out); }
	__declspec(dllexport) void ImGui_ErrorRecoveryTryToRecoverState(const ImGuiErrorRecoveryState* state_in) { ImGui::ErrorRecoveryTryToRecoverState(state_in); }
	__declspec(dllexport) void ImGui_ErrorRecoveryTryToRecoverWindowState(const ImGuiErrorRecoveryState* state_in) { ImGui::ErrorRecoveryTryToRecoverWindowState(state_in); }
	__declspec(dllexport) void ImRect_Expand(ImRect* _this, const ImVec2& amount) { _this->Expand(amount); }
	__declspec(dllexport) void ImRect_Expand0(ImRect* _this, const float amount) { _this->Expand(amount); }
	__declspec(dllexport) ImVec2 ImGui_FindBestWindowPosForPopup(ImGuiWindow* window) { return ImGui::FindBestWindowPosForPopup(window); }
	__declspec(dllexport) ImVec2 ImGui_FindBestWindowPosForPopupEx(const ImVec2& ref_pos, const ImVec2& size, ImGuiDir* last_dir, const ImRect& r_outer, const ImRect& r_avoid, ImGuiPopupPositionPolicy policy) { return ImGui::FindBestWindowPosForPopupEx(ref_pos, size, last_dir, r_outer, r_avoid, policy); }
	__declspec(dllexport) ImGuiWindow* ImGui_FindBlockingModal(ImGuiWindow* window) { return ImGui::FindBlockingModal(window); }
	__declspec(dllexport) ImGuiWindow* ImGui_FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* parent_window) { return ImGui::FindBottomMostVisibleWindowWithinBeginStack(parent_window); }
	__declspec(dllexport) ImFontGlyph* ImFont_FindGlyph(ImFont* _this, unsigned short c) { return _this->FindGlyph(c); }
	__declspec(dllexport) ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* _this, unsigned short c) { return _this->FindGlyphNoFallback(c); }
	__declspec(dllexport) ImGuiViewportP* ImGui_FindHoveredViewportFromPlatformWindowStack(const ImVec2& mouse_platform_pos) { return ImGui::FindHoveredViewportFromPlatformWindowStack(mouse_platform_pos); }
	__declspec(dllexport) void ImGui_FindHoveredWindowEx(const ImVec2& pos, bool find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window) { ImGui::FindHoveredWindowEx(pos, find_first_and_in_any_viewport, out_hovered_window, out_hovered_window_under_moving_window); }
	__declspec(dllexport) ImGuiOldColumns* ImGui_FindOrCreateColumns(ImGuiWindow* window, unsigned int id) { return ImGui::FindOrCreateColumns(window, id); }
	__declspec(dllexport) const char* ImGui_FindRenderedTextEnd(const char* text, const char* text_end) { return ImGui::FindRenderedTextEnd(text, text_end); }
	__declspec(dllexport) ImGuiSettingsHandler* ImGui_FindSettingsHandler(const char* type_name) { return ImGui::FindSettingsHandler(type_name); }
	__declspec(dllexport) ImGuiViewport* ImGui_FindViewportByID(unsigned int id) { return ImGui::FindViewportByID(id); }
	__declspec(dllexport) ImGuiViewport* ImGui_FindViewportByPlatformHandle(void* platform_handle) { return ImGui::FindViewportByPlatformHandle(platform_handle); }
	__declspec(dllexport) ImGuiWindow* ImGui_FindWindowByID(unsigned int id) { return ImGui::FindWindowByID(id); }
	__declspec(dllexport) ImGuiWindow* ImGui_FindWindowByName(const char* name) { return ImGui::FindWindowByName(name); }
	__declspec(dllexport) int ImGui_FindWindowDisplayIndex(ImGuiWindow* window) { return ImGui::FindWindowDisplayIndex(window); }
	__declspec(dllexport) ImGuiWindowSettings* ImGui_FindWindowSettingsByID(unsigned int id) { return ImGui::FindWindowSettingsByID(id); }
	__declspec(dllexport) ImGuiWindowSettings* ImGui_FindWindowSettingsByWindow(ImGuiWindow* window) { return ImGui::FindWindowSettingsByWindow(window); }
	__declspec(dllexport) void ImRect_Floor(ImRect* _this) { _this->Floor(); }
	__declspec(dllexport) void ImGui_FocusItem() { ImGui::FocusItem(); }
	__declspec(dllexport) void ImGui_FocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, int flags) { ImGui::FocusTopMostWindowUnderOne(under_this_window, ignore_window, filter_viewport, flags); }
	__declspec(dllexport) void ImGui_FocusWindow(ImGuiWindow* window, int flags) { ImGui::FocusWindow(window, flags); }
	__declspec(dllexport) void ImGui_GcAwakeTransientWindowBuffers(ImGuiWindow* window) { ImGui::GcAwakeTransientWindowBuffers(window); }
	__declspec(dllexport) void ImGui_GcCompactTransientMiscBuffers() { ImGui::GcCompactTransientMiscBuffers(); }
	__declspec(dllexport) void ImGui_GcCompactTransientWindowBuffers(ImGuiWindow* window) { ImGui::GcCompactTransientWindowBuffers(window); }
	__declspec(dllexport) void ImGui_GetAllocatorFunctions(void* (__cdecl** p_alloc_func)(unsigned int, void*), void(__cdecl** p_free_func)(void*, void*), void** p_user_data) { ImGui::GetAllocatorFunctions(p_alloc_func, p_free_func, p_user_data); }
	__declspec(dllexport) float ImRect_GetArea(const ImRect* _this) { return _this->GetArea(); }
	__declspec(dllexport) ImVec2 ImRect_GetBL(const ImRect* _this) { return _this->GetBL(); }
	__declspec(dllexport) ImVec2 ImRect_GetBR(const ImRect* _this) { return _this->GetBR(); }
	__declspec(dllexport) ImDrawList* ImGui_GetBackgroundDrawList(ImGuiViewport* viewport) { return ImGui::GetBackgroundDrawList(viewport); }
	__declspec(dllexport) bool ImGuiStorage_GetBool(const ImGuiStorage* _this, unsigned int key, bool default_val) { return _this->GetBool(key, default_val); }
	__declspec(dllexport) bool* ImGuiStorage_GetBoolRef(ImGuiStorage* _this, unsigned int key, bool default_val) { return _this->GetBoolRef(key, default_val); }
	__declspec(dllexport) ImVec2 ImRect_GetCenter(const ImRect* _this) { return _this->GetCenter(); }
	__declspec(dllexport) const char* ImGui_GetClipboardText() { return ImGui::GetClipboardText(); }
	__declspec(dllexport) unsigned int ImGui_GetColorU32(const ImVec4& col) { return ImGui::GetColorU32(col); }
	__declspec(dllexport) unsigned int ImGui_GetColorU320(int idx, float alpha_mul) { return ImGui::GetColorU32(idx, alpha_mul); }
	__declspec(dllexport) unsigned int ImGui_GetColorU321(unsigned int col, float alpha_mul) { return ImGui::GetColorU32(col, alpha_mul); }
	__declspec(dllexport) int ImGui_GetColumnIndex() { return ImGui::GetColumnIndex(); }
	__declspec(dllexport) float ImGui_GetColumnNormFromOffset(const ImGuiOldColumns* columns, float offset) { return ImGui::GetColumnNormFromOffset(columns, offset); }
	__declspec(dllexport) float ImGui_GetColumnOffset(int column_index) { return ImGui::GetColumnOffset(column_index); }
	__declspec(dllexport) float ImGui_GetColumnOffsetFromNorm(const ImGuiOldColumns* columns, float offset_norm) { return ImGui::GetColumnOffsetFromNorm(columns, offset_norm); }
	__declspec(dllexport) float ImGui_GetColumnWidth(int column_index) { return ImGui::GetColumnWidth(column_index); }
	__declspec(dllexport) int ImGui_GetColumnsCount() { return ImGui::GetColumnsCount(); }
	__declspec(dllexport) unsigned int ImGui_GetColumnsID(const char* str_id, int columns_count) { return ImGui::GetColumnsID(str_id, columns_count); }
	__declspec(dllexport) ImVec2 ImGui_GetContentRegionAvail() { return ImGui::GetContentRegionAvail(); }
	__declspec(dllexport) ImGuiContext* ImGui_GetCurrentContext() { return ImGui::GetCurrentContext(); }
	__declspec(dllexport) ImVec2 ImGui_GetCursorPos() { return ImGui::GetCursorPos(); }
	__declspec(dllexport) int ImGuiInputTextState_GetCursorPos(const ImGuiInputTextState* _this) { return _this->GetCursorPos(); }
	__declspec(dllexport) float ImGui_GetCursorPosX() { return ImGui::GetCursorPosX(); }
	__declspec(dllexport) float ImGui_GetCursorPosY() { return ImGui::GetCursorPosY(); }
	__declspec(dllexport) ImVec2 ImGui_GetCursorScreenPos() { return ImGui::GetCursorScreenPos(); }
	__declspec(dllexport) ImVec2 ImGui_GetCursorStartPos() { return ImGui::GetCursorStartPos(); }
	__declspec(dllexport) const ImGuiPayload* ImGui_GetDragDropPayload() { return ImGui::GetDragDropPayload(); }
	__declspec(dllexport) ImDrawData* ImGui_GetDrawData() { return ImGui::GetDrawData(); }
	__declspec(dllexport) ImDrawListSharedData* ImGui_GetDrawListSharedData() { return ImGui::GetDrawListSharedData(); }
	__declspec(dllexport) float ImGuiStorage_GetFloat(const ImGuiStorage* _this, unsigned int key, float default_val) { return _this->GetFloat(key, default_val); }
	__declspec(dllexport) float* ImGuiStorage_GetFloatRef(ImGuiStorage* _this, unsigned int key, float default_val) { return _this->GetFloatRef(key, default_val); }
	__declspec(dllexport) ImFont* ImGui_GetFont() { return ImGui::GetFont(); }
	__declspec(dllexport) float ImGui_GetFontSize() { return ImGui::GetFontSize(); }
	__declspec(dllexport) ImVec2 ImGui_GetFontTexUvWhitePixel() { return ImGui::GetFontTexUvWhitePixel(); }
	__declspec(dllexport) ImDrawList* ImGui_GetForegroundDrawList(ImGuiViewport* viewport) { return ImGui::GetForegroundDrawList(viewport); }
	__declspec(dllexport) int ImGui_GetFrameCount() { return ImGui::GetFrameCount(); }
	__declspec(dllexport) float ImGui_GetFrameHeight() { return ImGui::GetFrameHeight(); }
	__declspec(dllexport) float ImGui_GetFrameHeightWithSpacing() { return ImGui::GetFrameHeightWithSpacing(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* _this) { return _this->GetGlyphRangesChineseFull(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* _this) { return _this->GetGlyphRangesChineseSimplifiedCommon(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* _this) { return _this->GetGlyphRangesCyrillic(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* _this) { return _this->GetGlyphRangesDefault(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* _this) { return _this->GetGlyphRangesGreek(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* _this) { return _this->GetGlyphRangesJapanese(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* _this) { return _this->GetGlyphRangesKorean(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* _this) { return _this->GetGlyphRangesThai(); }
	__declspec(dllexport) const unsigned short* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* _this) { return _this->GetGlyphRangesVietnamese(); }
	__declspec(dllexport) float ImRect_GetHeight(const ImRect* _this) { return _this->GetHeight(); }
	__declspec(dllexport) unsigned int ImGui_GetHoveredID() { return ImGui::GetHoveredID(); }
	__declspec(dllexport) unsigned int ImGui_GetID(int int_id) { return ImGui::GetID(int_id); }
	__declspec(dllexport) unsigned int ImGui_GetID0(const char* str_id_begin, const char* str_id_end) { return ImGui::GetID(str_id_begin, str_id_end); }
	__declspec(dllexport) unsigned int ImGui_GetID1(const char* str_id) { return ImGui::GetID(str_id); }
	__declspec(dllexport) unsigned int ImGui_GetID2(const void* ptr_id) { return ImGui::GetID(ptr_id); }
	__declspec(dllexport) unsigned int ImGuiWindow_GetID(ImGuiWindow* _this, int n) { return _this->GetID(n); }
	__declspec(dllexport) unsigned int ImGuiWindow_GetID0(ImGuiWindow* _this, const char* str, const char* str_end) { return _this->GetID(str, str_end); }
	__declspec(dllexport) unsigned int ImGuiWindow_GetID1(ImGuiWindow* _this, const void* ptr) { return _this->GetID(ptr); }
	__declspec(dllexport) unsigned int ImGuiWindow_GetIDFromPos(ImGuiWindow* _this, const ImVec2& p_abs) { return _this->GetIDFromPos(p_abs); }
	__declspec(dllexport) unsigned int ImGuiWindow_GetIDFromRectangle(ImGuiWindow* _this, const ImRect& r_abs) { return _this->GetIDFromRectangle(r_abs); }
	__declspec(dllexport) unsigned int ImGui_GetIDWithSeed(int n, unsigned int seed) { return ImGui::GetIDWithSeed(n, seed); }
	__declspec(dllexport) unsigned int ImGui_GetIDWithSeed0(const char* str, const char* str_end, unsigned int seed) { return ImGui::GetIDWithSeed(str, str_end, seed); }
	__declspec(dllexport) ImGuiIO& ImGui_GetIO(ImGuiContext* ctx) { return ImGui::GetIO(ctx); }
	__declspec(dllexport) ImGuiIO& ImGui_GetIO0() { return ImGui::GetIO(); }
	__declspec(dllexport) int ImGuiStorage_GetInt(const ImGuiStorage* _this, unsigned int key, int default_val) { return _this->GetInt(key, default_val); }
	__declspec(dllexport) int* ImGuiStorage_GetIntRef(ImGuiStorage* _this, unsigned int key, int default_val) { return _this->GetIntRef(key, default_val); }
	__declspec(dllexport) unsigned int ImGui_GetItemID() { return ImGui::GetItemID(); }
	__declspec(dllexport) ImVec2 ImGui_GetItemRectMax() { return ImGui::GetItemRectMax(); }
	__declspec(dllexport) ImVec2 ImGui_GetItemRectMin() { return ImGui::GetItemRectMin(); }
	__declspec(dllexport) ImVec2 ImGui_GetItemRectSize() { return ImGui::GetItemRectSize(); }
	__declspec(dllexport) const char* ImGui_GetKeyChordName(int key_chord) { return ImGui::GetKeyChordName(key_chord); }
	__declspec(dllexport) ImGuiKeyData* ImGui_GetKeyData(ImGuiContext* ctx, ImGuiKey key) { return ImGui::GetKeyData(ctx, key); }
	__declspec(dllexport) ImVec2 ImGui_GetKeyMagnitude2d(ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down) { return ImGui::GetKeyMagnitude2d(key_left, key_right, key_up, key_down); }
	__declspec(dllexport) const char* ImGui_GetKeyName(ImGuiKey key) { return ImGui::GetKeyName(key); }
	__declspec(dllexport) unsigned int ImGui_GetKeyOwner(ImGuiKey key) { return ImGui::GetKeyOwner(key); }
	__declspec(dllexport) int ImGui_GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float repeat_rate) { return ImGui::GetKeyPressedAmount(key, repeat_delay, repeat_rate); }
	__declspec(dllexport) ImGuiViewport* ImGui_GetMainViewport() { return ImGui::GetMainViewport(); }
	__declspec(dllexport) int ImGui_GetMouseClickedCount(int button) { return ImGui::GetMouseClickedCount(button); }
	__declspec(dllexport) int ImGui_GetMouseCursor() { return ImGui::GetMouseCursor(); }
	__declspec(dllexport) ImVec2 ImGui_GetMouseDragDelta(int button, float lock_threshold) { return ImGui::GetMouseDragDelta(button, lock_threshold); }
	__declspec(dllexport) ImVec2 ImGui_GetMousePos() { return ImGui::GetMousePos(); }
	__declspec(dllexport) ImVec2 ImGui_GetMousePosOnOpeningCurrentPopup() { return ImGui::GetMousePosOnOpeningCurrentPopup(); }
	__declspec(dllexport) float ImGui_GetNavTweakPressedAmount(ImGuiAxis axis) { return ImGui::GetNavTweakPressedAmount(axis); }
	__declspec(dllexport) bool ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* _this, void** opaque_it, unsigned int* out_id) { return _this->GetNextSelectedItem(opaque_it, out_id); }
	__declspec(dllexport) ImGuiPlatformIO& ImGui_GetPlatformIO(ImGuiContext* ctx) { return ImGui::GetPlatformIO(ctx); }
	__declspec(dllexport) ImGuiPlatformIO& ImGui_GetPlatformIO0() { return ImGui::GetPlatformIO(); }
	__declspec(dllexport) ImRect ImGui_GetPopupAllowedExtentRect(ImGuiWindow* window) { return ImGui::GetPopupAllowedExtentRect(window); }
	__declspec(dllexport) float ImGui_GetScrollMaxX() { return ImGui::GetScrollMaxX(); }
	__declspec(dllexport) float ImGui_GetScrollMaxY() { return ImGui::GetScrollMaxY(); }
	__declspec(dllexport) float ImGui_GetScrollX() { return ImGui::GetScrollX(); }
	__declspec(dllexport) float ImGui_GetScrollY() { return ImGui::GetScrollY(); }
	__declspec(dllexport) int ImGuiInputTextState_GetSelectionEnd(const ImGuiInputTextState* _this) { return _this->GetSelectionEnd(); }
	__declspec(dllexport) int ImGuiInputTextState_GetSelectionStart(const ImGuiInputTextState* _this) { return _this->GetSelectionStart(); }
	__declspec(dllexport) ImGuiKeyRoutingData* ImGui_GetShortcutRoutingData(int key_chord) { return ImGui::GetShortcutRoutingData(key_chord); }
	__declspec(dllexport) ImVec2 ImRect_GetSize(const ImRect* _this) { return _this->GetSize(); }
	__declspec(dllexport) ImGuiStorage* ImGui_GetStateStorage() { return ImGui::GetStateStorage(); }
	__declspec(dllexport) ImGuiStyle& ImGui_GetStyle() { return ImGui::GetStyle(); }
	__declspec(dllexport) const char* ImGui_GetStyleColorName(int idx) { return ImGui::GetStyleColorName(idx); }
	__declspec(dllexport) const ImVec4& ImGui_GetStyleColorVec4(int idx) { return ImGui::GetStyleColorVec4(idx); }
	__declspec(dllexport) const ImGuiStyleVarInfo* ImGui_GetStyleVarInfo(int idx) { return ImGui::GetStyleVarInfo(idx); }
	__declspec(dllexport) ImVec2 ImRect_GetTL(const ImRect* _this) { return _this->GetTL(); }
	__declspec(dllexport) ImVec2 ImRect_GetTR(const ImRect* _this) { return _this->GetTR(); }
	__declspec(dllexport) void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* _this, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel) { _this->GetTexDataAsAlpha8(out_pixels, out_width, out_height, out_bytes_per_pixel); }
	__declspec(dllexport) void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* _this, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel) { _this->GetTexDataAsRGBA32(out_pixels, out_width, out_height, out_bytes_per_pixel); }
	__declspec(dllexport) float ImGui_GetTextLineHeight() { return ImGui::GetTextLineHeight(); }
	__declspec(dllexport) float ImGui_GetTextLineHeightWithSpacing() { return ImGui::GetTextLineHeightWithSpacing(); }
	__declspec(dllexport) double ImGui_GetTime() { return ImGui::GetTime(); }
	__declspec(dllexport) ImGuiWindow* ImGui_GetTopMostAndVisiblePopupModal() { return ImGui::GetTopMostAndVisiblePopupModal(); }
	__declspec(dllexport) ImGuiWindow* ImGui_GetTopMostPopupModal() { return ImGui::GetTopMostPopupModal(); }
	__declspec(dllexport) float ImGui_GetTreeNodeToLabelSpacing() { return ImGui::GetTreeNodeToLabelSpacing(); }
	__declspec(dllexport) void ImGui_GetTypematicRepeatRate(int flags, float* repeat_delay, float* repeat_rate) { ImGui::GetTypematicRepeatRate(flags, repeat_delay, repeat_rate); }
	__declspec(dllexport) ImGuiTypingSelectRequest* ImGui_GetTypingSelectRequest(int flags) { return ImGui::GetTypingSelectRequest(flags); }
	__declspec(dllexport) const char* ImGui_GetVersion() { return ImGui::GetVersion(); }
	__declspec(dllexport) const ImGuiPlatformMonitor* ImGui_GetViewportPlatformMonitor(ImGuiViewport* viewport_p) { return ImGui::GetViewportPlatformMonitor(viewport_p); }
	__declspec(dllexport) void* ImGuiStorage_GetVoidPtr(const ImGuiStorage* _this, unsigned int key) { return _this->GetVoidPtr(key); }
	__declspec(dllexport) void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* _this, unsigned int key, void* default_val) { return _this->GetVoidPtrRef(key, default_val); }
	__declspec(dllexport) float ImRect_GetWidth(const ImRect* _this) { return _this->GetWidth(); }
	__declspec(dllexport) bool ImGui_GetWindowAlwaysWantOwnTabBar(ImGuiWindow* window) { return ImGui::GetWindowAlwaysWantOwnTabBar(window); }
	__declspec(dllexport) unsigned int ImGui_GetWindowDockID() { return ImGui::GetWindowDockID(); }
	__declspec(dllexport) float ImGui_GetWindowDpiScale() { return ImGui::GetWindowDpiScale(); }
	__declspec(dllexport) ImDrawList* ImGui_GetWindowDrawList() { return ImGui::GetWindowDrawList(); }
	__declspec(dllexport) float ImGui_GetWindowHeight() { return ImGui::GetWindowHeight(); }
	__declspec(dllexport) ImVec2 ImGui_GetWindowPos() { return ImGui::GetWindowPos(); }
	__declspec(dllexport) unsigned int ImGui_GetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir) { return ImGui::GetWindowResizeBorderID(window, dir); }
	__declspec(dllexport) unsigned int ImGui_GetWindowResizeCornerID(ImGuiWindow* window, int n) { return ImGui::GetWindowResizeCornerID(window, n); }
	__declspec(dllexport) unsigned int ImGui_GetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis) { return ImGui::GetWindowScrollbarID(window, axis); }
	__declspec(dllexport) ImRect ImGui_GetWindowScrollbarRect(ImGuiWindow* window, ImGuiAxis axis) { return ImGui::GetWindowScrollbarRect(window, axis); }
	__declspec(dllexport) ImVec2 ImGui_GetWindowSize() { return ImGui::GetWindowSize(); }
	__declspec(dllexport) ImGuiViewport* ImGui_GetWindowViewport() { return ImGui::GetWindowViewport(); }
	__declspec(dllexport) float ImGui_GetWindowWidth() { return ImGui::GetWindowWidth(); }
	__declspec(dllexport) void ImFont_GrowIndex(ImFont* _this, int new_size) { _this->GrowIndex(new_size); }
	__declspec(dllexport) bool ImGuiInputTextState_HasSelection(const ImGuiInputTextState* _this) { return _this->HasSelection(); }
	__declspec(dllexport) unsigned int ImAlphaBlendColorsExt(unsigned int col_a, unsigned int col_b) { return ImAlphaBlendColors(col_a, col_b); }
	__declspec(dllexport) ImVec2 ImBezierCubicCalcExt(const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, float t) { return ImBezierCubicCalc(p1, p2, p3, p4, t); }
	__declspec(dllexport) ImVec2 ImBezierCubicClosestPointExt(const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, const ImVec2& p, int num_segments) { return ImBezierCubicClosestPoint(p1, p2, p3, p4, p, num_segments); }
	__declspec(dllexport) ImVec2 ImBezierCubicClosestPointCasteljauExt(const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, const ImVec2& p, float tess_tol) { return ImBezierCubicClosestPointCasteljau(p1, p2, p3, p4, p, tess_tol); }
	__declspec(dllexport) ImVec2 ImBezierQuadraticCalcExt(const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, float t) { return ImBezierQuadraticCalc(p1, p2, p3, t); }
	__declspec(dllexport) bool ImFileCloseExt(_iobuf* f) { return ImFileClose(f); }
	__declspec(dllexport) unsigned long long ImFileGetSizeExt(_iobuf* f) { return ImFileGetSize(f); }
	__declspec(dllexport) void* ImFileLoadToMemoryExt(const char* filename, const char* mode, unsigned int* out_file_size, int padding_bytes) { return ImFileLoadToMemory(filename, mode, out_file_size, padding_bytes); }
	__declspec(dllexport) _iobuf* ImFileOpenExt(const char* filename, const char* mode) { return ImFileOpen(filename, mode); }
	__declspec(dllexport) unsigned long long ImFileReadExt(void* data, unsigned long long sz, unsigned long long count, _iobuf* f) { return ImFileRead(data, sz, count, f); }
	__declspec(dllexport) unsigned long long ImFileWriteExt(const void* data, unsigned long long sz, unsigned long long count, _iobuf* f) { return ImFileWrite(data, sz, count, f); }
	__declspec(dllexport) void ImFontAtlasBuildFinishExt(ImFontAtlas* atlas) { ImFontAtlasBuildFinish(atlas); }
	__declspec(dllexport) void ImFontAtlasBuildGetOversampleFactorsExt(const ImFontConfig* src, int* out_oversample_h, int* out_oversample_v) { ImFontAtlasBuildGetOversampleFactors(src, out_oversample_h, out_oversample_v); }
	__declspec(dllexport) void ImFontAtlasBuildInitExt(ImFontAtlas* atlas) { ImFontAtlasBuildInit(atlas); }
	__declspec(dllexport) void ImFontAtlasBuildMultiplyCalcLookupTableExt(byte* out_table, float in_brighten_factor) { ImFontAtlasBuildMultiplyCalcLookupTable(out_table, in_brighten_factor); }
	__declspec(dllexport) void ImFontAtlasBuildMultiplyRectAlpha8Ext(const byte* table, byte* pixels, int x, int y, int w, int h, int stride) { ImFontAtlasBuildMultiplyRectAlpha8(table, pixels, x, y, w, h, stride); }
	__declspec(dllexport) void ImFontAtlasBuildPackCustomRectsExt(ImFontAtlas* atlas, void* stbrp_context_opaque) { ImFontAtlasBuildPackCustomRects(atlas, stbrp_context_opaque); }
	__declspec(dllexport) void ImFontAtlasBuildRender32bppRectFromStringExt(ImFontAtlas* atlas, int x, int y, int w, int h, const char* in_str, char in_marker_char, unsigned int in_marker_pixel_value) { ImFontAtlasBuildRender32bppRectFromString(atlas, x, y, w, h, in_str, in_marker_char, in_marker_pixel_value); }
	__declspec(dllexport) void ImFontAtlasBuildRender8bppRectFromStringExt(ImFontAtlas* atlas, int x, int y, int w, int h, const char* in_str, char in_marker_char, byte in_marker_pixel_value) { ImFontAtlasBuildRender8bppRectFromString(atlas, x, y, w, h, in_str, in_marker_char, in_marker_pixel_value); }
	__declspec(dllexport) void ImFontAtlasBuildSetupFontExt(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent) { ImFontAtlasBuildSetupFont(atlas, font, font_config, ascent, descent); }
	__declspec(dllexport) const ImFontBuilderIO* ImFontAtlasGetBuilderForStbTruetypeExt() { return ImFontAtlasGetBuilderForStbTruetype(); }
	__declspec(dllexport) bool ImFontAtlasGetMouseCursorTexDataExt(ImFontAtlas* atlas, int cursor_type, ImVec2* out_offset, ImVec2* out_size, ImVec2* out_uv_border, ImVec2* out_uv_fill) { return ImFontAtlasGetMouseCursorTexData(atlas, cursor_type, out_offset, out_size, out_uv_border, out_uv_fill); }
	__declspec(dllexport) void ImFontAtlasUpdateSourcesPointersExt(ImFontAtlas* atlas) { ImFontAtlasUpdateSourcesPointers(atlas); }
	__declspec(dllexport) void ImFormatStringToTempBufferVExt(const char** out_buf, const char** out_buf_end, const char* fmt, char* args) { ImFormatStringToTempBufferV(out_buf, out_buf_end, fmt, args); }
	__declspec(dllexport) int ImFormatStringVExt(char* buf, unsigned int buf_size, const char* fmt, char* args) { return ImFormatStringV(buf, buf_size, fmt, args); }
	__declspec(dllexport) bool ImGui_ImplDX9_CreateDeviceObjectsExt() { return ImGui_ImplDX9_CreateDeviceObjects(); }
	__declspec(dllexport) bool ImGui_ImplDX9_InitExt(IDirect3DDevice9* device) { return ImGui_ImplDX9_Init(device); }
	__declspec(dllexport) void ImGui_ImplDX9_InvalidateDeviceObjectsExt() { ImGui_ImplDX9_InvalidateDeviceObjects(); }
	__declspec(dllexport) void ImGui_ImplDX9_NewFrameExt() { ImGui_ImplDX9_NewFrame(); }
	__declspec(dllexport) void ImGui_ImplDX9_RenderDrawDataExt(ImDrawData* draw_data) { ImGui_ImplDX9_RenderDrawData(draw_data); }
	__declspec(dllexport) void ImGui_ImplDX9_ShutdownExt() { ImGui_ImplDX9_Shutdown(); }
	__declspec(dllexport) void ImGui_ImplWin32_EnableAlphaCompositingExt(void* hwnd) { ImGui_ImplWin32_EnableAlphaCompositing(hwnd); }
	__declspec(dllexport) void ImGui_ImplWin32_EnableDpiAwarenessExt() { ImGui_ImplWin32_EnableDpiAwareness(); }
	__declspec(dllexport) float ImGui_ImplWin32_GetDpiScaleForHwndExt(void* hwnd) { return ImGui_ImplWin32_GetDpiScaleForHwnd(hwnd); }
	__declspec(dllexport) float ImGui_ImplWin32_GetDpiScaleForMonitorExt(void* monitor) { return ImGui_ImplWin32_GetDpiScaleForMonitor(monitor); }
	__declspec(dllexport) bool ImGui_ImplWin32_InitExt(void* hwnd) { return ImGui_ImplWin32_Init(hwnd); }
	__declspec(dllexport) bool ImGui_ImplWin32_InitForOpenGLExt(void* hwnd) { return ImGui_ImplWin32_InitForOpenGL(hwnd); }
	__declspec(dllexport) void ImGui_ImplWin32_NewFrameExt() { ImGui_ImplWin32_NewFrame(); }
	__declspec(dllexport) void ImGui_ImplWin32_ShutdownExt() { ImGui_ImplWin32_Shutdown(); }
	__declspec(dllexport) long ImGui_ImplWin32_WndProcHandlerExt(HWND__* hwnd, unsigned int msg, unsigned int wParam, long lParam) { return ImGui_ImplWin32_WndProcHandler(hwnd, msg, wParam, lParam); }
	__declspec(dllexport) long ImGui_ImplWin32_WndProcHandlerExExt(HWND__* hwnd, unsigned int msg, unsigned int wParam, long lParam, ImGuiIO& io) { return ImGui_ImplWin32_WndProcHandlerEx(hwnd, msg, wParam, lParam, io); }
	__declspec(dllexport) unsigned int ImHashDataExt(const void* data_p, unsigned int data_size, unsigned int seed) { return ImHashData(data_p, data_size, seed); }
	__declspec(dllexport) unsigned int ImHashStrExt(const char* data_p, unsigned int data_size, unsigned int seed) { return ImHashStr(data_p, data_size, seed); }
	__declspec(dllexport) ImVec2 ImLineClosestPointExt(const ImVec2& a, const ImVec2& b, const ImVec2& p) { return ImLineClosestPoint(a, b, p); }
	__declspec(dllexport) ImGuiStoragePair* ImLowerBoundExt(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, unsigned int key) { return ImLowerBound(in_begin, in_end, key); }
	__declspec(dllexport) const char* ImParseFormatFindEndExt(const char* fmt) { return ImParseFormatFindEnd(fmt); }
	__declspec(dllexport) const char* ImParseFormatFindStartExt(const char* fmt) { return ImParseFormatFindStart(fmt); }
	__declspec(dllexport) int ImParseFormatPrecisionExt(const char* fmt, int default_precision) { return ImParseFormatPrecision(fmt, default_precision); }
	__declspec(dllexport) void ImParseFormatSanitizeForPrintingExt(const char* fmt_in, char* fmt_out, unsigned int fmt_out_size) { ImParseFormatSanitizeForPrinting(fmt_in, fmt_out, fmt_out_size); }
	__declspec(dllexport) const char* ImParseFormatSanitizeForScanningExt(const char* fmt_in, char* fmt_out, unsigned int fmt_out_size) { return ImParseFormatSanitizeForScanning(fmt_in, fmt_out, fmt_out_size); }
	__declspec(dllexport) const char* ImParseFormatTrimDecorationsExt(const char* fmt, char* buf, unsigned int buf_size) { return ImParseFormatTrimDecorations(fmt, buf, buf_size); }
	__declspec(dllexport) const char* ImStrSkipBlankExt(const char* str) { return ImStrSkipBlank(str); }
	__declspec(dllexport) void ImStrTrimBlanksExt(char* buf) { ImStrTrimBlanks(buf); }
	__declspec(dllexport) const char* ImStrbolExt(const char* buf_mid_line, const char* buf_begin) { return ImStrbol(buf_mid_line, buf_begin); }
	__declspec(dllexport) const char* ImStrchrRangeExt(const char* str, const char* str_end, char c) { return ImStrchrRange(str, str_end, c); }
	__declspec(dllexport) char* ImStrdupExt(const char* str) { return ImStrdup(str); }
	__declspec(dllexport) char* ImStrdupcpyExt(char* dst, unsigned int* p_dst_size, const char* src) { return ImStrdupcpy(dst, p_dst_size, src); }
	__declspec(dllexport) const char* ImStreolRangeExt(const char* str, const char* str_end) { return ImStreolRange(str, str_end); }
	__declspec(dllexport) int ImStricmpExt(const char* str1, const char* str2) { return ImStricmp(str1, str2); }
	__declspec(dllexport) const char* ImStristrExt(const char* haystack, const char* haystack_end, const char* needle, const char* needle_end) { return ImStristr(haystack, haystack_end, needle, needle_end); }
	__declspec(dllexport) int ImStrlenWExt(const unsigned short* str) { return ImStrlenW(str); }
	__declspec(dllexport) void ImStrncpyExt(char* dst, const char* src, unsigned int count) { ImStrncpy(dst, src, count); }
	__declspec(dllexport) int ImStrnicmpExt(const char* str1, const char* str2, unsigned int count) { return ImStrnicmp(str1, str2, count); }
	__declspec(dllexport) int ImTextCharFromUtf8Ext(unsigned int* out_char, const char* in_text, const char* in_text_end) { return ImTextCharFromUtf8(out_char, in_text, in_text_end); }
	__declspec(dllexport) const char* ImTextCharToUtf8Ext(char* out_buf, unsigned int c) { return ImTextCharToUtf8(out_buf, c); }
	__declspec(dllexport) int ImTextCountCharsFromUtf8Ext(const char* in_text, const char* in_text_end) { return ImTextCountCharsFromUtf8(in_text, in_text_end); }
	__declspec(dllexport) int ImTextCountLinesExt(const char* in_text, const char* in_text_end) { return ImTextCountLines(in_text, in_text_end); }
	__declspec(dllexport) int ImTextCountUtf8BytesFromCharExt(const char* in_text, const char* in_text_end) { return ImTextCountUtf8BytesFromChar(in_text, in_text_end); }
	__declspec(dllexport) int ImTextCountUtf8BytesFromStrExt(const unsigned short* in_text, const unsigned short* in_text_end) { return ImTextCountUtf8BytesFromStr(in_text, in_text_end); }
	__declspec(dllexport) const char* ImTextFindPreviousUtf8CodepointExt(const char* in_text_start, const char* in_text_curr) { return ImTextFindPreviousUtf8Codepoint(in_text_start, in_text_curr); }
	__declspec(dllexport) int ImTextStrFromUtf8Ext(unsigned short* buf, int buf_size, const char* in_text, const char* in_text_end, const char** in_text_remaining) { return ImTextStrFromUtf8(buf, buf_size, in_text, in_text_end, in_text_remaining); }
	__declspec(dllexport) int ImTextStrToUtf8Ext(char* out_buf, int out_buf_size, const unsigned short* in_text, const unsigned short* in_text_end) { return ImTextStrToUtf8(out_buf, out_buf_size, in_text, in_text_end); }
	__declspec(dllexport) void ImTriangleBarycentricCoordsExt(const ImVec2& a, const ImVec2& b, const ImVec2& c, const ImVec2& p, float& out_u, float& out_v, float& out_w) { ImTriangleBarycentricCoords(a, b, c, p, out_u, out_v, out_w); }
	__declspec(dllexport) ImVec2 ImTriangleClosestPointExt(const ImVec2& a, const ImVec2& b, const ImVec2& c, const ImVec2& p) { return ImTriangleClosestPoint(a, b, c, p); }
	__declspec(dllexport) bool ImTriangleContainsPointExt(const ImVec2& a, const ImVec2& b, const ImVec2& c, const ImVec2& p) { return ImTriangleContainsPoint(a, b, c, p); }
	__declspec(dllexport) void ImGui_Image(unsigned long long user_texture_id, const ImVec2& image_size, const ImVec2& uv0, const ImVec2& uv1) { ImGui::Image(user_texture_id, image_size, uv0, uv1); }
	__declspec(dllexport) bool ImGui_ImageButton(const char* str_id, unsigned long long user_texture_id, const ImVec2& image_size, const ImVec2& uv0, const ImVec2& uv1, const ImVec4& bg_col, const ImVec4& tint_col) { return ImGui::ImageButton(str_id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col); }
	__declspec(dllexport) bool ImGui_ImageButtonEx(unsigned int id, unsigned long long user_texture_id, const ImVec2& image_size, const ImVec2& uv0, const ImVec2& uv1, const ImVec4& bg_col, const ImVec4& tint_col, int flags) { return ImGui::ImageButtonEx(id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col, flags); }
	__declspec(dllexport) void ImGui_ImageWithBg(unsigned long long user_texture_id, const ImVec2& image_size, const ImVec2& uv0, const ImVec2& uv1, const ImVec4& bg_col, const ImVec4& tint_col) { ImGui::ImageWithBg(user_texture_id, image_size, uv0, uv1, bg_col, tint_col); }
	__declspec(dllexport) void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* _this, int item_begin, int item_end) { _this->IncludeItemsByIndex(item_begin, item_end); }
	__declspec(dllexport) void ImGui_Indent(float indent_w) { ImGui::Indent(indent_w); }
	__declspec(dllexport) void ImGui_Initialize() { ImGui::Initialize(); }
	__declspec(dllexport) bool ImGui_InputDouble(const char* label, double* v, double step, double step_fast, const char* format, int flags) { return ImGui::InputDouble(label, v, step, step_fast, format, flags); }
	__declspec(dllexport) bool ImGui_InputFloat2(const char* label, float* v, const char* format, int flags) { return ImGui::InputFloat2(label, v, format, flags); }
	__declspec(dllexport) bool ImGui_InputFloat3(const char* label, float* v, const char* format, int flags) { return ImGui::InputFloat3(label, v, format, flags); }
	__declspec(dllexport) bool ImGui_InputFloat4(const char* label, float* v, const char* format, int flags) { return ImGui::InputFloat4(label, v, format, flags); }
	__declspec(dllexport) bool ImGui_InputFloat(const char* label, float* v, float step, float step_fast, const char* format, int flags) { return ImGui::InputFloat(label, v, step, step_fast, format, flags); }
	__declspec(dllexport) bool ImGui_InputInt2(const char* label, int* v, int flags) { return ImGui::InputInt2(label, v, flags); }
	__declspec(dllexport) bool ImGui_InputInt3(const char* label, int* v, int flags) { return ImGui::InputInt3(label, v, flags); }
	__declspec(dllexport) bool ImGui_InputInt4(const char* label, int* v, int flags) { return ImGui::InputInt4(label, v, flags); }
	__declspec(dllexport) bool ImGui_InputInt(const char* label, int* v, int step, int step_fast, int flags) { return ImGui::InputInt(label, v, step, step_fast, flags); }
	__declspec(dllexport) bool ImGui_InputScalar(const char* label, int data_type, void* p_data, const void* p_step, const void* p_step_fast, const char* format, int flags) { return ImGui::InputScalar(label, data_type, p_data, p_step, p_step_fast, format, flags); }
	__declspec(dllexport) bool ImGui_InputScalarN(const char* label, int data_type, void* p_data, int components, const void* p_step, const void* p_step_fast, const char* format, int flags) { return ImGui::InputScalarN(label, data_type, p_data, components, p_step, p_step_fast, format, flags); }
	__declspec(dllexport) bool ImGui_InputText(const char* label, char* buf, unsigned int buf_size, int flags, int(__cdecl* callback)(ImGuiInputTextCallbackData*), void* user_data) { return ImGui::InputText(label, buf, buf_size, flags, callback, user_data); }
	__declspec(dllexport) void ImGui_InputTextDeactivateHook(unsigned int id) { ImGui::InputTextDeactivateHook(id); }
	__declspec(dllexport) bool ImGui_InputTextEx(const char* label, const char* hint, char* buf, int buf_size, const ImVec2& size_arg, int flags, int(__cdecl* callback)(ImGuiInputTextCallbackData*), void* callback_user_data) { return ImGui::InputTextEx(label, hint, buf, buf_size, size_arg, flags, callback, callback_user_data); }
	__declspec(dllexport) bool ImGui_InputTextMultiline(const char* label, char* buf, unsigned int buf_size, const ImVec2& size, int flags, int(__cdecl* callback)(ImGuiInputTextCallbackData*), void* user_data) { return ImGui::InputTextMultiline(label, buf, buf_size, size, flags, callback, user_data); }
	__declspec(dllexport) bool ImGui_InputTextWithHint(const char* label, const char* hint, char* buf, unsigned int buf_size, int flags, int(__cdecl* callback)(ImGuiInputTextCallbackData*), void* user_data) { return ImGui::InputTextWithHint(label, hint, buf, buf_size, flags, callback, user_data); }
	__declspec(dllexport) void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* _this, int pos, const char* new_text, const char* new_text_end) { _this->InsertChars(pos, new_text, new_text_end); }
	__declspec(dllexport) bool ImGui_InvisibleButton(const char* str_id, const ImVec2& size_arg, int flags) { return ImGui::InvisibleButton(str_id, size_arg, flags); }
	__declspec(dllexport) bool ImGui_IsAnyItemActive() { return ImGui::IsAnyItemActive(); }
	__declspec(dllexport) bool ImGui_IsAnyItemFocused() { return ImGui::IsAnyItemFocused(); }
	__declspec(dllexport) bool ImGui_IsAnyItemHovered() { return ImGui::IsAnyItemHovered(); }
	__declspec(dllexport) bool ImGui_IsAnyMouseDown() { return ImGui::IsAnyMouseDown(); }
	__declspec(dllexport) bool ImGuiDockNode_IsCentralNode(const ImGuiDockNode* _this) { return _this->IsCentralNode(); }
	__declspec(dllexport) bool ImGui_IsClippedEx(const ImRect& bb, unsigned int id) { return ImGui::IsClippedEx(bb, id); }
	__declspec(dllexport) bool ImGuiDockNode_IsDockSpace(const ImGuiDockNode* _this) { return _this->IsDockSpace(); }
	__declspec(dllexport) bool ImGui_IsDragDropActive() { return ImGui::IsDragDropActive(); }
	__declspec(dllexport) bool ImGui_IsDragDropPayloadBeingAccepted() { return ImGui::IsDragDropPayloadBeingAccepted(); }
	__declspec(dllexport) bool ImGuiDockNode_IsEmpty(const ImGuiDockNode* _this) { return _this->IsEmpty(); }
	__declspec(dllexport) bool ImGuiDockNode_IsFloatingNode(const ImGuiDockNode* _this) { return _this->IsFloatingNode(); }
	__declspec(dllexport) bool ImFont_IsGlyphRangeUnused(ImFont* _this, unsigned int c_begin, unsigned int c_last) { return _this->IsGlyphRangeUnused(c_begin, c_last); }
	__declspec(dllexport) bool ImGuiDockNode_IsHiddenTabBar(const ImGuiDockNode* _this) { return _this->IsHiddenTabBar(); }
	__declspec(dllexport) bool ImRect_IsInverted(const ImRect* _this) { return _this->IsInverted(); }
	__declspec(dllexport) bool ImGui_IsItemActivated() { return ImGui::IsItemActivated(); }
	__declspec(dllexport) bool ImGui_IsItemActive() { return ImGui::IsItemActive(); }
	__declspec(dllexport) bool ImGui_IsItemClicked(int mouse_button) { return ImGui::IsItemClicked(mouse_button); }
	__declspec(dllexport) bool ImGui_IsItemDeactivated() { return ImGui::IsItemDeactivated(); }
	__declspec(dllexport) bool ImGui_IsItemDeactivatedAfterEdit() { return ImGui::IsItemDeactivatedAfterEdit(); }
	__declspec(dllexport) bool ImGui_IsItemEdited() { return ImGui::IsItemEdited(); }
	__declspec(dllexport) bool ImGui_IsItemFocused() { return ImGui::IsItemFocused(); }
	__declspec(dllexport) bool ImGui_IsItemHovered(int flags) { return ImGui::IsItemHovered(flags); }
	__declspec(dllexport) bool ImGui_IsItemToggledOpen() { return ImGui::IsItemToggledOpen(); }
	__declspec(dllexport) bool ImGui_IsItemToggledSelection() { return ImGui::IsItemToggledSelection(); }
	__declspec(dllexport) bool ImGui_IsItemVisible() { return ImGui::IsItemVisible(); }
	__declspec(dllexport) bool ImGui_IsKeyChordPressed(int key_chord) { return ImGui::IsKeyChordPressed(key_chord); }
	__declspec(dllexport) bool ImGui_IsKeyChordPressed0(int key_chord, int flags, unsigned int owner_id) { return ImGui::IsKeyChordPressed(key_chord, flags, owner_id); }
	__declspec(dllexport) bool ImGui_IsKeyDown(ImGuiKey key) { return ImGui::IsKeyDown(key); }
	__declspec(dllexport) bool ImGui_IsKeyDown0(ImGuiKey key, unsigned int owner_id) { return ImGui::IsKeyDown(key, owner_id); }
	__declspec(dllexport) bool ImGui_IsKeyPressed(ImGuiKey key, int flags, unsigned int owner_id) { return ImGui::IsKeyPressed(key, flags, owner_id); }
	__declspec(dllexport) bool ImGui_IsKeyPressed0(ImGuiKey key, bool repeat) { return ImGui::IsKeyPressed(key, repeat); }
	__declspec(dllexport) bool ImGui_IsKeyReleased(ImGuiKey key) { return ImGui::IsKeyReleased(key); }
	__declspec(dllexport) bool ImGui_IsKeyReleased0(ImGuiKey key, unsigned int owner_id) { return ImGui::IsKeyReleased(key, owner_id); }
	__declspec(dllexport) bool ImGuiDockNode_IsLeafNode(const ImGuiDockNode* _this) { return _this->IsLeafNode(); }
	__declspec(dllexport) bool ImGui_IsMouseClicked(int button, int flags, unsigned int owner_id) { return ImGui::IsMouseClicked(button, flags, owner_id); }
	__declspec(dllexport) bool ImGui_IsMouseClicked0(int button, bool repeat) { return ImGui::IsMouseClicked(button, repeat); }
	__declspec(dllexport) bool ImGui_IsMouseDoubleClicked(int button) { return ImGui::IsMouseDoubleClicked(button); }
	__declspec(dllexport) bool ImGui_IsMouseDoubleClicked0(int button, unsigned int owner_id) { return ImGui::IsMouseDoubleClicked(button, owner_id); }
	__declspec(dllexport) bool ImGui_IsMouseDown(int button) { return ImGui::IsMouseDown(button); }
	__declspec(dllexport) bool ImGui_IsMouseDown0(int button, unsigned int owner_id) { return ImGui::IsMouseDown(button, owner_id); }
	__declspec(dllexport) bool ImGui_IsMouseDragPastThreshold(int button, float lock_threshold) { return ImGui::IsMouseDragPastThreshold(button, lock_threshold); }
	__declspec(dllexport) bool ImGui_IsMouseDragging(int button, float lock_threshold) { return ImGui::IsMouseDragging(button, lock_threshold); }
	__declspec(dllexport) bool ImGui_IsMouseHoveringRect(const ImVec2& r_min, const ImVec2& r_max, bool clip) { return ImGui::IsMouseHoveringRect(r_min, r_max, clip); }
	__declspec(dllexport) bool ImGui_IsMousePosValid(const ImVec2* mouse_pos) { return ImGui::IsMousePosValid(mouse_pos); }
	__declspec(dllexport) bool ImGui_IsMouseReleased(int button) { return ImGui::IsMouseReleased(button); }
	__declspec(dllexport) bool ImGui_IsMouseReleased0(int button, unsigned int owner_id) { return ImGui::IsMouseReleased(button, owner_id); }
	__declspec(dllexport) bool ImGui_IsMouseReleasedWithDelay(int button, float delay) { return ImGui::IsMouseReleasedWithDelay(button, delay); }
	__declspec(dllexport) bool ImGuiDockNode_IsNoTabBar(const ImGuiDockNode* _this) { return _this->IsNoTabBar(); }
	__declspec(dllexport) bool ImGui_IsPopupOpen(unsigned int id, int popup_flags) { return ImGui::IsPopupOpen(id, popup_flags); }
	__declspec(dllexport) bool ImGui_IsPopupOpen0(const char* str_id, int popup_flags) { return ImGui::IsPopupOpen(str_id, popup_flags); }
	__declspec(dllexport) bool ImGui_IsRectVisible(const ImVec2& rect_min, const ImVec2& rect_max) { return ImGui::IsRectVisible(rect_min, rect_max); }
	__declspec(dllexport) bool ImGui_IsRectVisible0(const ImVec2& size) { return ImGui::IsRectVisible(size); }
	__declspec(dllexport) bool ImGuiDockNode_IsRootNode(const ImGuiDockNode* _this) { return _this->IsRootNode(); }
	__declspec(dllexport) bool ImGuiDockNode_IsSplitNode(const ImGuiDockNode* _this) { return _this->IsSplitNode(); }
	__declspec(dllexport) bool ImGui_IsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below) { return ImGui::IsWindowAbove(potential_above, potential_below); }
	__declspec(dllexport) bool ImGui_IsWindowAppearing() { return ImGui::IsWindowAppearing(); }
	__declspec(dllexport) bool ImGui_IsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, bool popup_hierarchy, bool dock_hierarchy) { return ImGui::IsWindowChildOf(window, potential_parent, popup_hierarchy, dock_hierarchy); }
	__declspec(dllexport) bool ImGui_IsWindowCollapsed() { return ImGui::IsWindowCollapsed(); }
	__declspec(dllexport) bool ImGui_IsWindowContentHoverable(ImGuiWindow* window, int flags) { return ImGui::IsWindowContentHoverable(window, flags); }
	__declspec(dllexport) bool ImGui_IsWindowDocked() { return ImGui::IsWindowDocked(); }
	__declspec(dllexport) bool ImGui_IsWindowFocused(int flags) { return ImGui::IsWindowFocused(flags); }
	__declspec(dllexport) bool ImGui_IsWindowHovered(int flags) { return ImGui::IsWindowHovered(flags); }
	__declspec(dllexport) bool ImGui_IsWindowNavFocusable(ImGuiWindow* window) { return ImGui::IsWindowNavFocusable(window); }
	__declspec(dllexport) bool ImGui_IsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent) { return ImGui::IsWindowWithinBeginStackOf(window, potential_parent); }
	__declspec(dllexport) bool ImGui_ItemAdd(const ImRect& bb, unsigned int id, const ImRect* nav_bb_arg, int extra_flags) { return ImGui::ItemAdd(bb, id, nav_bb_arg, extra_flags); }
	__declspec(dllexport) bool ImGui_ItemHoverable(const ImRect& bb, unsigned int id, int item_flags) { return ImGui::ItemHoverable(bb, id, item_flags); }
	__declspec(dllexport) void ImGui_ItemSize(const ImVec2& size, float text_baseline_y) { ImGui::ItemSize(size, text_baseline_y); }
	__declspec(dllexport) void ImGui_KeepAliveID(unsigned int id) { ImGui::KeepAliveID(id); }
	__declspec(dllexport) void ImGui_LabelTextV(const char* label, const char* fmt, char* args) { ImGui::LabelTextV(label, fmt, args); }
	__declspec(dllexport) bool ImGui_ListBox(const char* label, int* current_item, const char* (__cdecl* getter)(void*, int), void* user_data, int items_count, int height_in_items) { return ImGui::ListBox(label, current_item, getter, user_data, items_count, height_in_items); }
	__declspec(dllexport) bool ImGui_ListBox0(const char* label, int* current_item, const char** items, int items_count, int height_items) { return ImGui::ListBox(label, current_item, items, items_count, height_items); }
	__declspec(dllexport) void ImGui_LoadIniSettingsFromDisk(const char* ini_filename) { ImGui::LoadIniSettingsFromDisk(ini_filename); }
	__declspec(dllexport) void ImGui_LoadIniSettingsFromMemory(const char* ini_data, unsigned int ini_size) { ImGui::LoadIniSettingsFromMemory(ini_data, ini_size); }
	__declspec(dllexport) void ImGui_LocalizeRegisterEntries(const ImGuiLocEntry* entries, int count) { ImGui::LocalizeRegisterEntries(entries, count); }
	__declspec(dllexport) void ImGui_LogBegin(int flags, int auto_open_depth) { ImGui::LogBegin(flags, auto_open_depth); }
	__declspec(dllexport) void ImGui_LogButtons() { ImGui::LogButtons(); }
	__declspec(dllexport) void ImGui_LogFinish() { ImGui::LogFinish(); }
	__declspec(dllexport) void ImGui_LogRenderedText(const ImVec2* ref_pos, const char* text, const char* text_end) { ImGui::LogRenderedText(ref_pos, text, text_end); }
	__declspec(dllexport) void ImGui_LogSetNextTextDecoration(const char* prefix, const char* suffix) { ImGui::LogSetNextTextDecoration(prefix, suffix); }
	__declspec(dllexport) void ImGui_LogTextV(const char* fmt, char* args) { ImGui::LogTextV(fmt, args); }
	__declspec(dllexport) void ImGui_LogToBuffer(int auto_open_depth) { ImGui::LogToBuffer(auto_open_depth); }
	__declspec(dllexport) void ImGui_LogToClipboard(int auto_open_depth) { ImGui::LogToClipboard(auto_open_depth); }
	__declspec(dllexport) void ImGui_LogToFile(int auto_open_depth, const char* filename) { ImGui::LogToFile(auto_open_depth, filename); }
	__declspec(dllexport) void ImGui_LogToTTY(int auto_open_depth) { ImGui::LogToTTY(auto_open_depth); }
	__declspec(dllexport) void ImGui_MarkIniSettingsDirty(ImGuiWindow* window) { ImGui::MarkIniSettingsDirty(window); }
	__declspec(dllexport) void ImGui_MarkIniSettingsDirty0() { ImGui::MarkIniSettingsDirty(); }
	__declspec(dllexport) void ImGui_MarkItemEdited(unsigned int id) { ImGui::MarkItemEdited(id); }
	__declspec(dllexport) void* ImGui_MemAlloc(unsigned int size) { return ImGui::MemAlloc(size); }
	__declspec(dllexport) void ImGui_MemFree(void* ptr) { ImGui::MemFree(ptr); }
	__declspec(dllexport) ImRect ImGuiWindow_MenuBarRect(const ImGuiWindow* _this) { return _this->MenuBarRect(); }
	__declspec(dllexport) bool ImGui_MenuItem(const char* label, const char* shortcut, bool* p_selected, bool enabled) { return ImGui::MenuItem(label, shortcut, p_selected, enabled); }
	__declspec(dllexport) bool ImGui_MenuItem0(const char* label, const char* shortcut, bool selected, bool enabled) { return ImGui::MenuItem(label, shortcut, selected, enabled); }
	__declspec(dllexport) bool ImGui_MenuItemEx(const char* label, const char* icon, const char* shortcut, bool selected, bool enabled) { return ImGui::MenuItemEx(label, icon, shortcut, selected, enabled); }
	__declspec(dllexport) void ImDrawListSplitter_Merge(ImDrawListSplitter* _this, ImDrawList* draw_list) { _this->Merge(draw_list); }
	__declspec(dllexport) void ImGui_MultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, bool selected) { ImGui::MultiSelectAddSetAll(ms, selected); }
	__declspec(dllexport) void ImGui_MultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, bool selected, int range_dir, long long first_item, long long last_item) { ImGui::MultiSelectAddSetRange(ms, selected, range_dir, first_item, last_item); }
	__declspec(dllexport) void ImGui_MultiSelectItemFooter(unsigned int id, bool* p_selected, bool* p_pressed) { ImGui::MultiSelectItemFooter(id, p_selected, p_pressed); }
	__declspec(dllexport) void ImGui_MultiSelectItemHeader(unsigned int id, bool* p_selected, int* p_button_flags) { ImGui::MultiSelectItemHeader(id, p_selected, p_button_flags); }
	__declspec(dllexport) void ImGui_NavClearPreferredPosForAxis(ImGuiAxis axis) { ImGui::NavClearPreferredPosForAxis(axis); }
	__declspec(dllexport) void ImGui_NavHighlightActivated(unsigned int id) { ImGui::NavHighlightActivated(id); }
	__declspec(dllexport) void ImGui_NavInitRequestApplyResult() { ImGui::NavInitRequestApplyResult(); }
	__declspec(dllexport) void ImGui_NavInitWindow(ImGuiWindow* window, bool force_reinit) { ImGui::NavInitWindow(window, force_reinit); }
	__declspec(dllexport) void ImGui_NavMoveRequestApplyResult() { ImGui::NavMoveRequestApplyResult(); }
	__declspec(dllexport) bool ImGui_NavMoveRequestButNoResultYet() { return ImGui::NavMoveRequestButNoResultYet(); }
	__declspec(dllexport) void ImGui_NavMoveRequestCancel() { ImGui::NavMoveRequestCancel(); }
	__declspec(dllexport) void ImGui_NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, int move_flags, int scroll_flags) { ImGui::NavMoveRequestForward(move_dir, clip_dir, move_flags, scroll_flags); }
	__declspec(dllexport) void ImGui_NavMoveRequestResolveWithLastItem(ImGuiNavItemData* result) { ImGui::NavMoveRequestResolveWithLastItem(result); }
	__declspec(dllexport) void ImGui_NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data) { ImGui::NavMoveRequestResolveWithPastTreeNode(result, tree_node_data); }
	__declspec(dllexport) void ImGui_NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, int move_flags, int scroll_flags) { ImGui::NavMoveRequestSubmit(move_dir, clip_dir, move_flags, scroll_flags); }
	__declspec(dllexport) void ImGui_NavMoveRequestTryWrapping(ImGuiWindow* window, int wrap_flags) { ImGui::NavMoveRequestTryWrapping(window, wrap_flags); }
	__declspec(dllexport) void ImGui_NavUpdateCurrentWindowIsScrollPushableX() { ImGui::NavUpdateCurrentWindowIsScrollPushableX(); }
	__declspec(dllexport) void ImGui_NewFrame() { ImGui::NewFrame(); }
	__declspec(dllexport) void ImGui_NewLine() { ImGui::NewLine(); }
	__declspec(dllexport) void ImGui_NextColumn() { ImGui::NextColumn(); }
	__declspec(dllexport) void ImGuiInputTextState_OnCharPressed(ImGuiInputTextState* _this, unsigned int c) { _this->OnCharPressed(c); }
	__declspec(dllexport) void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* _this, int key) { _this->OnKeyPressed(key); }
	__declspec(dllexport) void ImGui_OpenPopup(unsigned int id, int popup_flags) { ImGui::OpenPopup(id, popup_flags); }
	__declspec(dllexport) void ImGui_OpenPopup0(const char* str_id, int popup_flags) { ImGui::OpenPopup(str_id, popup_flags); }
	__declspec(dllexport) void ImGui_OpenPopupEx(unsigned int id, int popup_flags) { ImGui::OpenPopupEx(id, popup_flags); }
	__declspec(dllexport) void ImGui_OpenPopupOnItemClick(const char* str_id, int popup_flags) { ImGui::OpenPopupOnItemClick(str_id, popup_flags); }
	__declspec(dllexport) bool ImRect_Overlaps(const ImRect* _this, const ImRect& r) { return _this->Overlaps(r); }
	__declspec(dllexport) bool ImGuiTextFilter_PassFilter(const ImGuiTextFilter* _this, const char* text, const char* text_end) { return _this->PassFilter(text, text_end); }
	__declspec(dllexport) void ImDrawList_PathArcTo(ImDrawList* _this, const ImVec2& center, float radius, float a_min, float a_max, int num_segments) { _this->PathArcTo(center, radius, a_min, a_max, num_segments); }
	__declspec(dllexport) void ImDrawList_PathArcToFast(ImDrawList* _this, const ImVec2& center, float radius, int a_min_of_12, int a_max_of_12) { _this->PathArcToFast(center, radius, a_min_of_12, a_max_of_12); }
	__declspec(dllexport) void ImDrawList_PathBezierCubicCurveTo(ImDrawList* _this, const ImVec2& p2, const ImVec2& p3, const ImVec2& p4, int num_segments) { _this->PathBezierCubicCurveTo(p2, p3, p4, num_segments); }
	__declspec(dllexport) void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* _this, const ImVec2& p2, const ImVec2& p3, int num_segments) { _this->PathBezierQuadraticCurveTo(p2, p3, num_segments); }
	__declspec(dllexport) void ImDrawList_PathEllipticalArcTo(ImDrawList* _this, const ImVec2& center, const ImVec2& radius, float rot, float a_min, float a_max, int num_segments) { _this->PathEllipticalArcTo(center, radius, rot, a_min, a_max, num_segments); }
	__declspec(dllexport) void ImDrawList_PathRect(ImDrawList* _this, const ImVec2& a, const ImVec2& b, float rounding, int flags) { _this->PathRect(a, b, rounding, flags); }
	__declspec(dllexport) int ImGui_PlotEx(ImGuiPlotType plot_type, const char* label, float(__cdecl* values_getter)(void*, int), void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, const ImVec2& size_arg) { return ImGui::PlotEx(plot_type, label, values_getter, data, values_count, values_offset, overlay_text, scale_min, scale_max, size_arg); }
	__declspec(dllexport) void ImGui_PlotHistogram(const char* label, float(__cdecl* values_getter)(void*, int), void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size) { ImGui::PlotHistogram(label, values_getter, data, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size); }
	__declspec(dllexport) void ImGui_PlotHistogram0(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride) { ImGui::PlotHistogram(label, values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size, stride); }
	__declspec(dllexport) void ImGui_PlotLines(const char* label, float(__cdecl* values_getter)(void*, int), void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size) { ImGui::PlotLines(label, values_getter, data, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size); }
	__declspec(dllexport) void ImGui_PlotLines0(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride) { ImGui::PlotLines(label, values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size, stride); }
	__declspec(dllexport) void ImDrawList_PopClipRect(ImDrawList* _this) { _this->PopClipRect(); }
	__declspec(dllexport) void ImGui_PopClipRect() { ImGui::PopClipRect(); }
	__declspec(dllexport) void ImGui_PopColumnsBackground() { ImGui::PopColumnsBackground(); }
	__declspec(dllexport) void ImGui_PopFocusScope() { ImGui::PopFocusScope(); }
	__declspec(dllexport) void ImGui_PopFont() { ImGui::PopFont(); }
	__declspec(dllexport) void ImGui_PopID() { ImGui::PopID(); }
	__declspec(dllexport) void ImGui_PopItemFlag() { ImGui::PopItemFlag(); }
	__declspec(dllexport) void ImGui_PopItemWidth() { ImGui::PopItemWidth(); }
	__declspec(dllexport) void ImGui_PopStyleColor(int count) { ImGui::PopStyleColor(count); }
	__declspec(dllexport) void ImGui_PopStyleVar(int count) { ImGui::PopStyleVar(count); }
	__declspec(dllexport) void ImGui_PopTextWrapPos() { ImGui::PopTextWrapPos(); }
	__declspec(dllexport) void ImDrawList_PopTextureID(ImDrawList* _this) { _this->PopTextureID(); }
	__declspec(dllexport) void ImDrawList_PrimQuadUV(ImDrawList* _this, const ImVec2& a, const ImVec2& b, const ImVec2& c, const ImVec2& d, const ImVec2& uv_a, const ImVec2& uv_b, const ImVec2& uv_c, const ImVec2& uv_d, unsigned int col) { _this->PrimQuadUV(a, b, c, d, uv_a, uv_b, uv_c, uv_d, col); }
	__declspec(dllexport) void ImDrawList_PrimRect(ImDrawList* _this, const ImVec2& a, const ImVec2& c, unsigned int col) { _this->PrimRect(a, c, col); }
	__declspec(dllexport) void ImDrawList_PrimRectUV(ImDrawList* _this, const ImVec2& a, const ImVec2& c, const ImVec2& uv_a, const ImVec2& uv_c, unsigned int col) { _this->PrimRectUV(a, c, uv_a, uv_c, col); }
	__declspec(dllexport) void ImDrawList_PrimReserve(ImDrawList* _this, int idx_count, int vtx_count) { _this->PrimReserve(idx_count, vtx_count); }
	__declspec(dllexport) void ImDrawList_PrimUnreserve(ImDrawList* _this, int idx_count, int vtx_count) { _this->PrimUnreserve(idx_count, vtx_count); }
	__declspec(dllexport) void ImGui_ProgressBar(float fraction, const ImVec2& size_arg, const char* overlay) { ImGui::ProgressBar(fraction, size_arg, overlay); }
	__declspec(dllexport) void ImDrawList_PushClipRect(ImDrawList* _this, const ImVec2& cr_min, const ImVec2& cr_max, bool intersect_with_current_clip_rect) { _this->PushClipRect(cr_min, cr_max, intersect_with_current_clip_rect); }
	__declspec(dllexport) void ImGui_PushClipRect(const ImVec2& clip_rect_min, const ImVec2& clip_rect_max, bool intersect_with_current_clip_rect) { ImGui::PushClipRect(clip_rect_min, clip_rect_max, intersect_with_current_clip_rect); }
	__declspec(dllexport) void ImDrawList_PushClipRectFullScreen(ImDrawList* _this) { _this->PushClipRectFullScreen(); }
	__declspec(dllexport) void ImGui_PushColumnClipRect(int column_index) { ImGui::PushColumnClipRect(column_index); }
	__declspec(dllexport) void ImGui_PushColumnsBackground() { ImGui::PushColumnsBackground(); }
	__declspec(dllexport) void ImGui_PushFocusScope(unsigned int id) { ImGui::PushFocusScope(id); }
	__declspec(dllexport) void ImGui_PushFont(ImFont* font) { ImGui::PushFont(font); }
	__declspec(dllexport) void ImGui_PushID(int int_id) { ImGui::PushID(int_id); }
	__declspec(dllexport) void ImGui_PushID0(const char* str_id_begin, const char* str_id_end) { ImGui::PushID(str_id_begin, str_id_end); }
	__declspec(dllexport) void ImGui_PushID1(const char* str_id) { ImGui::PushID(str_id); }
	__declspec(dllexport) void ImGui_PushID2(const void* ptr_id) { ImGui::PushID(ptr_id); }
	__declspec(dllexport) void ImGui_PushItemFlag(int option, bool enabled) { ImGui::PushItemFlag(option, enabled); }
	__declspec(dllexport) void ImGui_PushItemWidth(float item_width) { ImGui::PushItemWidth(item_width); }
	__declspec(dllexport) void ImGui_PushMultiItemsWidths(int components, float w_full) { ImGui::PushMultiItemsWidths(components, w_full); }
	__declspec(dllexport) void ImGui_PushOverrideID(unsigned int id) { ImGui::PushOverrideID(id); }
	__declspec(dllexport) void ImGui_PushPasswordFont() { ImGui::PushPasswordFont(); }
	__declspec(dllexport) void ImGui_PushStyleColor(int idx, const ImVec4& col) { ImGui::PushStyleColor(idx, col); }
	__declspec(dllexport) void ImGui_PushStyleColor0(int idx, unsigned int col) { ImGui::PushStyleColor(idx, col); }
	__declspec(dllexport) void ImGui_PushStyleVar(int idx, const ImVec2& val) { ImGui::PushStyleVar(idx, val); }
	__declspec(dllexport) void ImGui_PushStyleVar0(int idx, float val) { ImGui::PushStyleVar(idx, val); }
	__declspec(dllexport) void ImGui_PushStyleVarX(int idx, float val_x) { ImGui::PushStyleVarX(idx, val_x); }
	__declspec(dllexport) void ImGui_PushStyleVarY(int idx, float val_y) { ImGui::PushStyleVarY(idx, val_y); }
	__declspec(dllexport) void ImGui_PushTextWrapPos(float wrap_pos_x) { ImGui::PushTextWrapPos(wrap_pos_x); }
	__declspec(dllexport) void ImDrawList_PushTextureID(ImDrawList* _this, unsigned long long texture_id) { _this->PushTextureID(texture_id); }
	__declspec(dllexport) bool ImGui_RadioButton(const char* label, int* v, int v_button) { return ImGui::RadioButton(label, v, v_button); }
	__declspec(dllexport) bool ImGui_RadioButton0(const char* label, bool active) { return ImGui::RadioButton(label, active); }
	__declspec(dllexport) ImRect ImGuiDockNode_Rect(const ImGuiDockNode* _this) { return _this->Rect(); }
	__declspec(dllexport) ImRect ImGuiWindow_Rect(const ImGuiWindow* _this) { return _this->Rect(); }
	__declspec(dllexport) void ImGuiInputTextState_ReloadUserBufAndKeepSelection(ImGuiInputTextState* _this) { _this->ReloadUserBufAndKeepSelection(); }
	__declspec(dllexport) void ImGuiInputTextState_ReloadUserBufAndMoveToEnd(ImGuiInputTextState* _this) { _this->ReloadUserBufAndMoveToEnd(); }
	__declspec(dllexport) void ImGuiInputTextState_ReloadUserBufAndSelectAll(ImGuiInputTextState* _this) { _this->ReloadUserBufAndSelectAll(); }
	__declspec(dllexport) void ImGui_RemoveContextHook(ImGuiContext* ctx, unsigned int hook_id) { ImGui::RemoveContextHook(ctx, hook_id); }
	__declspec(dllexport) void ImGui_RemoveSettingsHandler(const char* type_name) { ImGui::RemoveSettingsHandler(type_name); }
	__declspec(dllexport) void ImGui_Render() { ImGui::Render(); }
	__declspec(dllexport) void ImGui_RenderArrow(ImDrawList* draw_list, ImVec2 pos, unsigned int col, ImGuiDir dir, float scale) { ImGui::RenderArrow(draw_list, pos, col, dir, scale); }
	__declspec(dllexport) void ImGui_RenderArrowDockMenu(ImDrawList* draw_list, ImVec2 p_min, float sz, unsigned int col) { ImGui::RenderArrowDockMenu(draw_list, p_min, sz, col); }
	__declspec(dllexport) void ImGui_RenderArrowPointingAt(ImDrawList* draw_list, ImVec2 pos, ImVec2 half_sz, ImGuiDir direction, unsigned int col) { ImGui::RenderArrowPointingAt(draw_list, pos, half_sz, direction, col); }
	__declspec(dllexport) void ImGui_RenderBullet(ImDrawList* draw_list, ImVec2 pos, unsigned int col) { ImGui::RenderBullet(draw_list, pos, col); }
	__declspec(dllexport) void ImFont_RenderChar(ImFont* _this, ImDrawList* draw_list, float size, const ImVec2& pos, unsigned int col, unsigned short c) { _this->RenderChar(draw_list, size, pos, col, c); }
	__declspec(dllexport) void ImGui_RenderCheckMark(ImDrawList* draw_list, ImVec2 pos, unsigned int col, float sz) { ImGui::RenderCheckMark(draw_list, pos, col, sz); }
	__declspec(dllexport) void ImGui_RenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, ImVec2 p_min, ImVec2 p_max, unsigned int col, float grid_step, ImVec2 grid_off, float rounding, int flags) { ImGui::RenderColorRectWithAlphaCheckerboard(draw_list, p_min, p_max, col, grid_step, grid_off, rounding, flags); }
	__declspec(dllexport) void ImGui_RenderDragDropTargetRect(const ImRect& bb, const ImRect& item_clip_rect) { ImGui::RenderDragDropTargetRect(bb, item_clip_rect); }
	__declspec(dllexport) void ImGui_RenderFrame(ImVec2 p_min, ImVec2 p_max, unsigned int fill_col, bool borders, float rounding) { ImGui::RenderFrame(p_min, p_max, fill_col, borders, rounding); }
	__declspec(dllexport) void ImGui_RenderFrameBorder(ImVec2 p_min, ImVec2 p_max, float rounding) { ImGui::RenderFrameBorder(p_min, p_max, rounding); }
	__declspec(dllexport) void ImGui_RenderMouseCursor(ImVec2 base_pos, float base_scale, int mouse_cursor, unsigned int col_fill, unsigned int col_border, unsigned int col_shadow) { ImGui::RenderMouseCursor(base_pos, base_scale, mouse_cursor, col_fill, col_border, col_shadow); }
	__declspec(dllexport) void ImGui_RenderNavCursor(const ImRect& bb, unsigned int id, int flags) { ImGui::RenderNavCursor(bb, id, flags); }
	__declspec(dllexport) void ImGui_RenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg) { ImGui::RenderPlatformWindowsDefault(platform_render_arg, renderer_render_arg); }
	__declspec(dllexport) void ImGui_RenderRectFilledRangeH(ImDrawList* draw_list, const ImRect& rect, unsigned int col, float x_start_norm, float x_end_norm, float rounding) { ImGui::RenderRectFilledRangeH(draw_list, rect, col, x_start_norm, x_end_norm, rounding); }
	__declspec(dllexport) void ImGui_RenderRectFilledWithHole(ImDrawList* draw_list, const ImRect& outer, const ImRect& inner, unsigned int col, float rounding) { ImGui::RenderRectFilledWithHole(draw_list, outer, inner, col, rounding); }
	__declspec(dllexport) void ImFont_RenderText(ImFont* _this, ImDrawList* draw_list, float size, const ImVec2& pos, unsigned int col, const ImVec4& clip_rect, const char* text_begin, const char* text_end, float wrap_width, bool cpu_fine_clip) { _this->RenderText(draw_list, size, pos, col, clip_rect, text_begin, text_end, wrap_width, cpu_fine_clip); }
	__declspec(dllexport) void ImGui_RenderText(ImVec2 pos, const char* text, const char* text_end, bool hide_text_after_hash) { ImGui::RenderText(pos, text, text_end, hide_text_after_hash); }
	__declspec(dllexport) void ImGui_RenderTextClipped(const ImVec2& pos_min, const ImVec2& pos_max, const char* text, const char* text_end, const ImVec2* text_size_if_known, const ImVec2& align, const ImRect* clip_rect) { ImGui::RenderTextClipped(pos_min, pos_max, text, text_end, text_size_if_known, align, clip_rect); }
	__declspec(dllexport) void ImGui_RenderTextClippedEx(ImDrawList* draw_list, const ImVec2& pos_min, const ImVec2& pos_max, const char* text, const char* text_display_end, const ImVec2* text_size_if_known, const ImVec2& align, const ImRect* clip_rect) { ImGui::RenderTextClippedEx(draw_list, pos_min, pos_max, text, text_display_end, text_size_if_known, align, clip_rect); }
	__declspec(dllexport) void ImGui_RenderTextEllipsis(ImDrawList* draw_list, const ImVec2& pos_min, const ImVec2& pos_max, float clip_max_x, float ellipsis_max_x, const char* text, const char* text_end_full, const ImVec2* text_size_if_known) { ImGui::RenderTextEllipsis(draw_list, pos_min, pos_max, clip_max_x, ellipsis_max_x, text, text_end_full, text_size_if_known); }
	__declspec(dllexport) void ImGui_RenderTextWrapped(ImVec2 pos, const char* text, const char* text_end, float wrap_width) { ImGui::RenderTextWrapped(pos, text, text_end, wrap_width); }
	__declspec(dllexport) void ImGui_ResetMouseDragDelta(int button) { ImGui::ResetMouseDragDelta(button); }
	__declspec(dllexport) void ImGui_SameLine(float offset_from_start_x, float spacing_w) { ImGui::SameLine(offset_from_start_x, spacing_w); }
	__declspec(dllexport) void ImGui_SaveIniSettingsToDisk(const char* ini_filename) { ImGui::SaveIniSettingsToDisk(ini_filename); }
	__declspec(dllexport) const char* ImGui_SaveIniSettingsToMemory(unsigned int* out_size) { return ImGui::SaveIniSettingsToMemory(out_size); }
	__declspec(dllexport) void ImGuiStyle_ScaleAllSizes(ImGuiStyle* _this, float scale_factor) { _this->ScaleAllSizes(scale_factor); }
	__declspec(dllexport) void ImDrawData_ScaleClipRects(ImDrawData* _this, const ImVec2& fb_scale) { _this->ScaleClipRects(fb_scale); }
	__declspec(dllexport) void ImGui_ScaleWindowsInViewport(ImGuiViewportP* viewport, float scale) { ImGui::ScaleWindowsInViewport(viewport, scale); }
	__declspec(dllexport) void ImGui_ScrollToItem(int flags) { ImGui::ScrollToItem(flags); }
	__declspec(dllexport) void ImGui_ScrollToRect(ImGuiWindow* window, const ImRect& item_rect, int flags) { ImGui::ScrollToRect(window, item_rect, flags); }
	__declspec(dllexport) ImVec2 ImGui_ScrollToRectEx(ImGuiWindow* window, const ImRect& item_rect, int flags) { return ImGui::ScrollToRectEx(window, item_rect, flags); }
	__declspec(dllexport) void ImGui_Scrollbar(ImGuiAxis axis) { ImGui::Scrollbar(axis); }
	__declspec(dllexport) bool ImGui_ScrollbarEx(const ImRect& bb_frame, unsigned int id, ImGuiAxis axis, long long* p_scroll_v, long long size_visible_v, long long size_contents_v, int draw_rounding_flags) { return ImGui::ScrollbarEx(bb_frame, id, axis, p_scroll_v, size_visible_v, size_contents_v, draw_rounding_flags); }
	__declspec(dllexport) void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* _this, int item_n) { _this->SeekCursorForItem(item_n); }
	__declspec(dllexport) void ImGuiInputTextState_SelectAll(ImGuiInputTextState* _this) { _this->SelectAll(); }
	__declspec(dllexport) bool ImGui_Selectable(const char* label, bool* p_selected, int flags, const ImVec2& size_arg) { return ImGui::Selectable(label, p_selected, flags, size_arg); }
	__declspec(dllexport) bool ImGui_Selectable0(const char* label, bool selected, int flags, const ImVec2& size_arg) { return ImGui::Selectable(label, selected, flags, size_arg); }
	__declspec(dllexport) void ImGui_Separator() { ImGui::Separator(); }
	__declspec(dllexport) void ImGui_SeparatorEx(int flags, float thickness) { ImGui::SeparatorEx(flags, thickness); }
	__declspec(dllexport) void ImGui_SeparatorText(const char* label) { ImGui::SeparatorText(label); }
	__declspec(dllexport) void ImGui_SeparatorTextEx(unsigned int id, const char* label, const char* label_end, float extra_w) { ImGui::SeparatorTextEx(id, label, label_end, extra_w); }
	__declspec(dllexport) void ImGui_SetActiveID(unsigned int id, ImGuiWindow* window) { ImGui::SetActiveID(id, window); }
	__declspec(dllexport) void ImGui_SetActiveIdUsingAllKeyboardKeys() { ImGui::SetActiveIdUsingAllKeyboardKeys(); }
	__declspec(dllexport) void ImGuiStorage_SetAllInt(ImGuiStorage* _this, int v) { _this->SetAllInt(v); }
	__declspec(dllexport) void ImGui_SetAllocatorFunctions(void* (__cdecl* alloc_func)(unsigned int, void*), void(__cdecl* free_func)(void*, void*), void* user_data) { ImGui::SetAllocatorFunctions(alloc_func, free_func, user_data); }
	__declspec(dllexport) void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* _this, bool accepting_events) { _this->SetAppAcceptingEvents(accepting_events); }
	__declspec(dllexport) void ImBitVector_SetBit(ImBitVector* _this, int n) { _this->SetBit(n); }
	__declspec(dllexport) void ImGuiStorage_SetBool(ImGuiStorage* _this, unsigned int key, bool val) { _this->SetBool(key, val); }
	__declspec(dllexport) void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* _this, float max_error) { _this->SetCircleTessellationMaxError(max_error); }
	__declspec(dllexport) void ImGui_SetClipboardText(const char* text) { ImGui::SetClipboardText(text); }
	__declspec(dllexport) void ImGui_SetColorEditOptions(int flags) { ImGui::SetColorEditOptions(flags); }
	__declspec(dllexport) void ImGui_SetColumnOffset(int column_index, float offset) { ImGui::SetColumnOffset(column_index, offset); }
	__declspec(dllexport) void ImGui_SetColumnWidth(int column_index, float width) { ImGui::SetColumnWidth(column_index, width); }
	__declspec(dllexport) void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* _this, ImDrawList* draw_list, int idx) { _this->SetCurrentChannel(draw_list, idx); }
	__declspec(dllexport) void ImGui_SetCurrentContext(ImGuiContext* ctx) { ImGui::SetCurrentContext(ctx); }
	__declspec(dllexport) void ImGui_SetCurrentFont(ImFont* font) { ImGui::SetCurrentFont(font); }
	__declspec(dllexport) void ImGui_SetCurrentViewport(ImGuiWindow* current_window, ImGuiViewportP* viewport) { ImGui::SetCurrentViewport(current_window, viewport); }
	__declspec(dllexport) void ImGui_SetCursorPos(const ImVec2& local_pos) { ImGui::SetCursorPos(local_pos); }
	__declspec(dllexport) void ImGui_SetCursorPosX(float x) { ImGui::SetCursorPosX(x); }
	__declspec(dllexport) void ImGui_SetCursorPosY(float y) { ImGui::SetCursorPosY(y); }
	__declspec(dllexport) void ImGui_SetCursorScreenPos(const ImVec2& pos) { ImGui::SetCursorScreenPos(pos); }
	__declspec(dllexport) bool ImGui_SetDragDropPayload(const char* type, const void* data, unsigned int data_size, int cond) { return ImGui::SetDragDropPayload(type, data, data_size, cond); }
	__declspec(dllexport) void ImGuiStorage_SetFloat(ImGuiStorage* _this, unsigned int key, float val) { _this->SetFloat(key, val); }
	__declspec(dllexport) void ImGui_SetFocusID(unsigned int id, ImGuiWindow* window) { ImGui::SetFocusID(id, window); }
	__declspec(dllexport) void ImGui_SetHoveredID(unsigned int id) { ImGui::SetHoveredID(id); }
	__declspec(dllexport) void ImGuiStorage_SetInt(ImGuiStorage* _this, unsigned int key, int val) { _this->SetInt(key, val); }
	__declspec(dllexport) void ImGui_SetItemDefaultFocus() { ImGui::SetItemDefaultFocus(); }
	__declspec(dllexport) void ImGui_SetItemKeyOwner(ImGuiKey key) { ImGui::SetItemKeyOwner(key); }
	__declspec(dllexport) void ImGui_SetItemKeyOwner0(ImGuiKey key, int flags) { ImGui::SetItemKeyOwner(key, flags); }
	__declspec(dllexport) void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* _this, unsigned int id, bool selected) { _this->SetItemSelected(id, selected); }
	__declspec(dllexport) void ImGui_SetItemTooltipV(const char* fmt, char* args) { ImGui::SetItemTooltipV(fmt, args); }
	__declspec(dllexport) void ImGui_SetKeyOwner(ImGuiKey key, unsigned int owner_id, int flags) { ImGui::SetKeyOwner(key, owner_id, flags); }
	__declspec(dllexport) void ImGui_SetKeyOwnersForKeyChord(int key_chord, unsigned int owner_id, int flags) { ImGui::SetKeyOwnersForKeyChord(key_chord, owner_id, flags); }
	__declspec(dllexport) void ImGui_SetKeyboardFocusHere(int offset) { ImGui::SetKeyboardFocusHere(offset); }
	__declspec(dllexport) void ImGui_SetLastItemData(unsigned int item_id, int item_flags, int status_flags, const ImRect& item_rect) { ImGui::SetLastItemData(item_id, item_flags, status_flags, item_rect); }
	__declspec(dllexport) void ImGuiDockNode_SetLocalFlags(ImGuiDockNode* _this, int flags) { _this->SetLocalFlags(flags); }
	__declspec(dllexport) void ImGui_SetMouseCursor(int cursor_type) { ImGui::SetMouseCursor(cursor_type); }
	__declspec(dllexport) void ImGui_SetNavCursorVisible(bool visible) { ImGui::SetNavCursorVisible(visible); }
	__declspec(dllexport) void ImGui_SetNavCursorVisibleAfterMove() { ImGui::SetNavCursorVisibleAfterMove(); }
	__declspec(dllexport) void ImGui_SetNavFocusScope(unsigned int focus_scope_id) { ImGui::SetNavFocusScope(focus_scope_id); }
	__declspec(dllexport) void ImGui_SetNavID(unsigned int id, ImGuiNavLayer nav_layer, unsigned int focus_scope_id, const ImRect& rect_rel) { ImGui::SetNavID(id, nav_layer, focus_scope_id, rect_rel); }
	__declspec(dllexport) void ImGui_SetNavWindow(ImGuiWindow* window) { ImGui::SetNavWindow(window); }
	__declspec(dllexport) void ImGui_SetNextFrameWantCaptureKeyboard(bool want_capture_keyboard) { ImGui::SetNextFrameWantCaptureKeyboard(want_capture_keyboard); }
	__declspec(dllexport) void ImGui_SetNextFrameWantCaptureMouse(bool want_capture_mouse) { ImGui::SetNextFrameWantCaptureMouse(want_capture_mouse); }
	__declspec(dllexport) void ImGui_SetNextItemAllowOverlap() { ImGui::SetNextItemAllowOverlap(); }
	__declspec(dllexport) void ImGui_SetNextItemOpen(bool is_open, int cond) { ImGui::SetNextItemOpen(is_open, cond); }
	__declspec(dllexport) void ImGui_SetNextItemRefVal(int data_type, void* p_data) { ImGui::SetNextItemRefVal(data_type, p_data); }
	__declspec(dllexport) void ImGui_SetNextItemSelectionUserData(long long selection_user_data) { ImGui::SetNextItemSelectionUserData(selection_user_data); }
	__declspec(dllexport) void ImGui_SetNextItemShortcut(int key_chord, int flags) { ImGui::SetNextItemShortcut(key_chord, flags); }
	__declspec(dllexport) void ImGui_SetNextItemStorageID(unsigned int storage_id) { ImGui::SetNextItemStorageID(storage_id); }
	__declspec(dllexport) void ImGui_SetNextItemWidth(float item_width) { ImGui::SetNextItemWidth(item_width); }
	__declspec(dllexport) void ImGui_SetNextWindowBgAlpha(float alpha) { ImGui::SetNextWindowBgAlpha(alpha); }
	__declspec(dllexport) void ImGui_SetNextWindowClass(const ImGuiWindowClass* window_class) { ImGui::SetNextWindowClass(window_class); }
	__declspec(dllexport) void ImGui_SetNextWindowCollapsed(bool collapsed, int cond) { ImGui::SetNextWindowCollapsed(collapsed, cond); }
	__declspec(dllexport) void ImGui_SetNextWindowContentSize(const ImVec2& size) { ImGui::SetNextWindowContentSize(size); }
	__declspec(dllexport) void ImGui_SetNextWindowDockID(unsigned int id, int cond) { ImGui::SetNextWindowDockID(id, cond); }
	__declspec(dllexport) void ImGui_SetNextWindowFocus() { ImGui::SetNextWindowFocus(); }
	__declspec(dllexport) void ImGui_SetNextWindowPos(const ImVec2& pos, int cond, const ImVec2& pivot) { ImGui::SetNextWindowPos(pos, cond, pivot); }
	__declspec(dllexport) void ImGui_SetNextWindowRefreshPolicy(int flags) { ImGui::SetNextWindowRefreshPolicy(flags); }
	__declspec(dllexport) void ImGui_SetNextWindowScroll(const ImVec2& scroll) { ImGui::SetNextWindowScroll(scroll); }
	__declspec(dllexport) void ImGui_SetNextWindowSize(const ImVec2& size, int cond) { ImGui::SetNextWindowSize(size, cond); }
	__declspec(dllexport) void ImGui_SetNextWindowSizeConstraints(const ImVec2& size_min, const ImVec2& size_max, void(__cdecl* custom_callback)(ImGuiSizeCallbackData*), void* custom_callback_user_data) { ImGui::SetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_user_data); }
	__declspec(dllexport) void ImGui_SetNextWindowViewport(unsigned int id) { ImGui::SetNextWindowViewport(id); }
	__declspec(dllexport) void ImGui_SetScrollFromPosX(float local_x, float center_x_ratio) { ImGui::SetScrollFromPosX(local_x, center_x_ratio); }
	__declspec(dllexport) void ImGui_SetScrollFromPosX0(ImGuiWindow* window, float local_x, float center_x_ratio) { ImGui::SetScrollFromPosX(window, local_x, center_x_ratio); }
	__declspec(dllexport) void ImGui_SetScrollFromPosY(float local_y, float center_y_ratio) { ImGui::SetScrollFromPosY(local_y, center_y_ratio); }
	__declspec(dllexport) void ImGui_SetScrollFromPosY0(ImGuiWindow* window, float local_y, float center_y_ratio) { ImGui::SetScrollFromPosY(window, local_y, center_y_ratio); }
	__declspec(dllexport) void ImGui_SetScrollHereX(float center_x_ratio) { ImGui::SetScrollHereX(center_x_ratio); }
	__declspec(dllexport) void ImGui_SetScrollHereY(float center_y_ratio) { ImGui::SetScrollHereY(center_y_ratio); }
	__declspec(dllexport) void ImGui_SetScrollX(float scroll_x) { ImGui::SetScrollX(scroll_x); }
	__declspec(dllexport) void ImGui_SetScrollX0(ImGuiWindow* window, float scroll_x) { ImGui::SetScrollX(window, scroll_x); }
	__declspec(dllexport) void ImGui_SetScrollY(float scroll_y) { ImGui::SetScrollY(scroll_y); }
	__declspec(dllexport) void ImGui_SetScrollY0(ImGuiWindow* window, float scroll_y) { ImGui::SetScrollY(window, scroll_y); }
	__declspec(dllexport) bool ImGui_SetShortcutRouting(int key_chord, int flags, unsigned int owner_id) { return ImGui::SetShortcutRouting(key_chord, flags, owner_id); }
	__declspec(dllexport) void ImGui_SetStateStorage(ImGuiStorage* tree) { ImGui::SetStateStorage(tree); }
	__declspec(dllexport) void ImGui_SetTabItemClosed(const char* label) { ImGui::SetTabItemClosed(label); }
	__declspec(dllexport) void ImGui_SetTooltipV(const char* fmt, char* args) { ImGui::SetTooltipV(fmt, args); }
	__declspec(dllexport) void ImGuiStorage_SetVoidPtr(ImGuiStorage* _this, unsigned int key, void* val) { _this->SetVoidPtr(key, val); }
	__declspec(dllexport) void ImGui_SetWindowClipRectBeforeSetChannel(ImGuiWindow* window, const ImRect& clip_rect) { ImGui::SetWindowClipRectBeforeSetChannel(window, clip_rect); }
	__declspec(dllexport) void ImGui_SetWindowCollapsed(ImGuiWindow* window, bool collapsed, int cond) { ImGui::SetWindowCollapsed(window, collapsed, cond); }
	__declspec(dllexport) void ImGui_SetWindowCollapsed0(const char* name, bool collapsed, int cond) { ImGui::SetWindowCollapsed(name, collapsed, cond); }
	__declspec(dllexport) void ImGui_SetWindowCollapsed1(bool collapsed, int cond) { ImGui::SetWindowCollapsed(collapsed, cond); }
	__declspec(dllexport) void ImGui_SetWindowDock(ImGuiWindow* window, unsigned int dock_id, int cond) { ImGui::SetWindowDock(window, dock_id, cond); }
	__declspec(dllexport) void ImGui_SetWindowFocus(const char* name) { ImGui::SetWindowFocus(name); }
	__declspec(dllexport) void ImGui_SetWindowFocus0() { ImGui::SetWindowFocus(); }
	__declspec(dllexport) void ImGui_SetWindowFontScale(float scale) { ImGui::SetWindowFontScale(scale); }
	__declspec(dllexport) void ImGui_SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window) { ImGui::SetWindowHiddenAndSkipItemsForCurrentFrame(window); }
	__declspec(dllexport) void ImGui_SetWindowHitTestHole(ImGuiWindow* window, const ImVec2& pos, const ImVec2& size) { ImGui::SetWindowHitTestHole(window, pos, size); }
	__declspec(dllexport) void ImGui_SetWindowPos(const ImVec2& pos, int cond) { ImGui::SetWindowPos(pos, cond); }
	__declspec(dllexport) void ImGui_SetWindowPos0(ImGuiWindow* window, const ImVec2& pos, int cond) { ImGui::SetWindowPos(window, pos, cond); }
	__declspec(dllexport) void ImGui_SetWindowPos1(const char* name, const ImVec2& pos, int cond) { ImGui::SetWindowPos(name, pos, cond); }
	__declspec(dllexport) void ImGui_SetWindowSize(const ImVec2& size, int cond) { ImGui::SetWindowSize(size, cond); }
	__declspec(dllexport) void ImGui_SetWindowSize0(ImGuiWindow* window, const ImVec2& size, int cond) { ImGui::SetWindowSize(window, size, cond); }
	__declspec(dllexport) void ImGui_SetWindowSize1(const char* name, const ImVec2& size, int cond) { ImGui::SetWindowSize(name, size, cond); }
	__declspec(dllexport) void ImGui_SetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport) { ImGui::SetWindowViewport(window, viewport); }
	__declspec(dllexport) void ImGui_ShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, ImVec2 gradient_p0, ImVec2 gradient_p1, unsigned int col0, unsigned int col1) { ImGui::ShadeVertsLinearColorGradientKeepAlpha(draw_list, vert_start_idx, vert_end_idx, gradient_p0, gradient_p1, col0, col1); }
	__declspec(dllexport) void ImGui_ShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, const ImVec2& a, const ImVec2& b, const ImVec2& uv_a, const ImVec2& uv_b, bool clamp) { ImGui::ShadeVertsLinearUV(draw_list, vert_start_idx, vert_end_idx, a, b, uv_a, uv_b, clamp); }
	__declspec(dllexport) void ImGui_ShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, const ImVec2& pivot_in, float cos_a, float sin_a, const ImVec2& pivot_out) { ImGui::ShadeVertsTransformPos(draw_list, vert_start_idx, vert_end_idx, pivot_in, cos_a, sin_a, pivot_out); }
	__declspec(dllexport) bool ImGui_Shortcut(int key_chord, int flags) { return ImGui::Shortcut(key_chord, flags); }
	__declspec(dllexport) bool ImGui_Shortcut0(int key_chord, int flags, unsigned int owner_id) { return ImGui::Shortcut(key_chord, flags, owner_id); }
	__declspec(dllexport) void ImGui_ShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess) { ImGui::ShrinkWidths(items, count, width_excess); }
	__declspec(dllexport) void ImGui_Shutdown() { ImGui::Shutdown(); }
	__declspec(dllexport) bool ImGui_SliderAngle(const char* label, float* v_rad, float v_degrees_min, float v_degrees_max, const char* format, int flags) { return ImGui::SliderAngle(label, v_rad, v_degrees_min, v_degrees_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderBehavior(const ImRect& bb, unsigned int id, int data_type, void* p_v, const void* p_min, const void* p_max, const char* format, int flags, ImRect* out_grab_bb) { return ImGui::SliderBehavior(bb, id, data_type, p_v, p_min, p_max, format, flags, out_grab_bb); }
	__declspec(dllexport) bool ImGui_SliderFloat2(const char* label, float* v, float v_min, float v_max, const char* format, int flags) { return ImGui::SliderFloat2(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderFloat3(const char* label, float* v, float v_min, float v_max, const char* format, int flags) { return ImGui::SliderFloat3(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderFloat4(const char* label, float* v, float v_min, float v_max, const char* format, int flags) { return ImGui::SliderFloat4(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderFloat(const char* label, float* v, float v_min, float v_max, const char* format, int flags) { return ImGui::SliderFloat(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderInt2(const char* label, int* v, int v_min, int v_max, const char* format, int flags) { return ImGui::SliderInt2(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderInt3(const char* label, int* v, int v_min, int v_max, const char* format, int flags) { return ImGui::SliderInt3(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderInt4(const char* label, int* v, int v_min, int v_max, const char* format, int flags) { return ImGui::SliderInt4(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderInt(const char* label, int* v, int v_min, int v_max, const char* format, int flags) { return ImGui::SliderInt(label, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderScalar(const char* label, int data_type, void* p_data, const void* p_min, const void* p_max, const char* format, int flags) { return ImGui::SliderScalar(label, data_type, p_data, p_min, p_max, format, flags); }
	__declspec(dllexport) bool ImGui_SliderScalarN(const char* label, int data_type, void* v, int components, const void* v_min, const void* v_max, const char* format, int flags) { return ImGui::SliderScalarN(label, data_type, v, components, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_SmallButton(const char* label) { return ImGui::SmallButton(label); }
	__declspec(dllexport) void ImGui_Spacing() { ImGui::Spacing(); }
	__declspec(dllexport) void ImDrawListSplitter_Split(ImDrawListSplitter* _this, ImDrawList* draw_list, int channels_count) { _this->Split(draw_list, channels_count); }
	__declspec(dllexport) bool ImGui_SplitterBehavior(const ImRect& bb, unsigned int id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, unsigned int bg_col) { return ImGui::SplitterBehavior(bb, id, axis, size1, size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col); }
	__declspec(dllexport) void ImGui_StartMouseMovingWindow(ImGuiWindow* window) { ImGui::StartMouseMovingWindow(window); }
	__declspec(dllexport) void ImGui_StartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, bool undock) { ImGui::StartMouseMovingWindowOrNode(window, node, undock); }
	__declspec(dllexport) bool ImGuiListClipper_Step(ImGuiListClipper* _this) { return _this->Step(); }
	__declspec(dllexport) void ImGui_StyleColorsClassic(ImGuiStyle* dst) { ImGui::StyleColorsClassic(dst); }
	__declspec(dllexport) void ImGui_StyleColorsDark(ImGuiStyle* dst) { ImGui::StyleColorsDark(dst); }
	__declspec(dllexport) void ImGui_StyleColorsLight(ImGuiStyle* dst) { ImGui::StyleColorsLight(dst); }
	__declspec(dllexport) void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* _this, ImGuiSelectionBasicStorage& r) { _this->Swap(r); }
	__declspec(dllexport) void ImGui_TabBarAddTab(ImGuiTabBar* tab_bar, int tab_flags, ImGuiWindow* window) { ImGui::TabBarAddTab(tab_bar, tab_flags, window); }
	__declspec(dllexport) void ImGui_TabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab) { ImGui::TabBarCloseTab(tab_bar, tab); }
	__declspec(dllexport) ImGuiTabItem* ImGui_TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar) { return ImGui::TabBarFindMostRecentlySelectedTabForActiveWindow(tab_bar); }
	__declspec(dllexport) ImGuiTabItem* ImGui_TabBarFindTabByID(ImGuiTabBar* tab_bar, unsigned int tab_id) { return ImGui::TabBarFindTabByID(tab_bar, tab_id); }
	__declspec(dllexport) ImGuiTabItem* ImGui_TabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order) { return ImGui::TabBarFindTabByOrder(tab_bar, order); }
	__declspec(dllexport) ImGuiTabItem* ImGui_TabBarGetCurrentTab(ImGuiTabBar* tab_bar) { return ImGui::TabBarGetCurrentTab(tab_bar); }
	__declspec(dllexport) const char* ImGui_TabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab) { return ImGui::TabBarGetTabName(tab_bar, tab); }
	__declspec(dllexport) bool ImGui_TabBarProcessReorder(ImGuiTabBar* tab_bar) { return ImGui::TabBarProcessReorder(tab_bar); }
	__declspec(dllexport) void ImGui_TabBarQueueFocus(ImGuiTabBar* tab_bar, ImGuiTabItem* tab) { ImGui::TabBarQueueFocus(tab_bar, tab); }
	__declspec(dllexport) void ImGui_TabBarQueueFocus0(ImGuiTabBar* tab_bar, const char* tab_name) { ImGui::TabBarQueueFocus(tab_bar, tab_name); }
	__declspec(dllexport) void ImGui_TabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset) { ImGui::TabBarQueueReorder(tab_bar, tab, offset); }
	__declspec(dllexport) void ImGui_TabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* src_tab, ImVec2 mouse_pos) { ImGui::TabBarQueueReorderFromMousePos(tab_bar, src_tab, mouse_pos); }
	__declspec(dllexport) void ImGui_TabBarRemoveTab(ImGuiTabBar* tab_bar, unsigned int tab_id) { ImGui::TabBarRemoveTab(tab_bar, tab_id); }
	__declspec(dllexport) void ImGui_TabItemBackground(ImDrawList* draw_list, const ImRect& bb, int flags, unsigned int col) { ImGui::TabItemBackground(draw_list, bb, flags, col); }
	__declspec(dllexport) bool ImGui_TabItemButton(const char* label, int flags) { return ImGui::TabItemButton(label, flags); }
	__declspec(dllexport) ImVec2 ImGui_TabItemCalcSize(ImGuiWindow* window) { return ImGui::TabItemCalcSize(window); }
	__declspec(dllexport) ImVec2 ImGui_TabItemCalcSize0(const char* label, bool has_close_button_or_unsaved_marker) { return ImGui::TabItemCalcSize(label, has_close_button_or_unsaved_marker); }
	__declspec(dllexport) bool ImGui_TabItemEx(ImGuiTabBar* tab_bar, const char* label, bool* p_open, int flags, ImGuiWindow* docked_window) { return ImGui::TabItemEx(tab_bar, label, p_open, flags, docked_window); }
	__declspec(dllexport) void ImGui_TabItemLabelAndCloseButton(ImDrawList* draw_list, const ImRect& bb, int flags, ImVec2 frame_padding, const char* label, unsigned int tab_id, unsigned int close_button_id, bool is_contents_visible, bool* out_just_closed, bool* out_text_clipped) { ImGui::TabItemLabelAndCloseButton(draw_list, bb, flags, frame_padding, label, tab_id, close_button_id, is_contents_visible, out_just_closed, out_text_clipped); }
	__declspec(dllexport) void ImGui_TabItemSpacing(const char* str_id, int flags, float width) { ImGui::TabItemSpacing(str_id, flags, width); }
	__declspec(dllexport) void ImGui_TableAngledHeadersRow() { ImGui::TableAngledHeadersRow(); }
	__declspec(dllexport) void ImGui_TableAngledHeadersRowEx(unsigned int row_id, float angle, float max_label_width, const ImGuiTableHeaderData* data, int data_count) { ImGui::TableAngledHeadersRowEx(row_id, angle, max_label_width, data, data_count); }
	__declspec(dllexport) void ImGui_TableBeginApplyRequests(ImGuiTable* table) { ImGui::TableBeginApplyRequests(table); }
	__declspec(dllexport) void ImGui_TableBeginCell(ImGuiTable* table, int column_n) { ImGui::TableBeginCell(table, column_n); }
	__declspec(dllexport) bool ImGui_TableBeginContextMenuPopup(ImGuiTable* table) { return ImGui::TableBeginContextMenuPopup(table); }
	__declspec(dllexport) void ImGui_TableBeginInitMemory(ImGuiTable* table, int columns_count) { ImGui::TableBeginInitMemory(table, columns_count); }
	__declspec(dllexport) void ImGui_TableBeginRow(ImGuiTable* table) { ImGui::TableBeginRow(table); }
	__declspec(dllexport) float ImGui_TableCalcMaxColumnWidth(const ImGuiTable* table, int column_n) { return ImGui::TableCalcMaxColumnWidth(table, column_n); }
	__declspec(dllexport) void ImGui_TableDrawBorders(ImGuiTable* table) { ImGui::TableDrawBorders(table); }
	__declspec(dllexport) void ImGui_TableDrawDefaultContextMenu(ImGuiTable* table, int flags_for_section_to_display) { ImGui::TableDrawDefaultContextMenu(table, flags_for_section_to_display); }
	__declspec(dllexport) void ImGui_TableEndCell(ImGuiTable* table) { ImGui::TableEndCell(table); }
	__declspec(dllexport) void ImGui_TableEndRow(ImGuiTable* table) { ImGui::TableEndRow(table); }
	__declspec(dllexport) ImGuiTable* ImGui_TableFindByID(unsigned int id) { return ImGui::TableFindByID(id); }
	__declspec(dllexport) void ImGui_TableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column) { ImGui::TableFixColumnSortDirection(table, column); }
	__declspec(dllexport) void ImGui_TableGcCompactSettings() { ImGui::TableGcCompactSettings(); }
	__declspec(dllexport) void ImGui_TableGcCompactTransientBuffers(ImGuiTable* table) { ImGui::TableGcCompactTransientBuffers(table); }
	__declspec(dllexport) void ImGui_TableGcCompactTransientBuffers0(ImGuiTableTempData* temp_data) { ImGui::TableGcCompactTransientBuffers(temp_data); }
	__declspec(dllexport) ImGuiTableSettings* ImGui_TableGetBoundSettings(ImGuiTable* table) { return ImGui::TableGetBoundSettings(table); }
	__declspec(dllexport) ImRect ImGui_TableGetCellBgRect(const ImGuiTable* table, int column_n) { return ImGui::TableGetCellBgRect(table, column_n); }
	__declspec(dllexport) int ImGui_TableGetColumnCount() { return ImGui::TableGetColumnCount(); }
	__declspec(dllexport) int ImGui_TableGetColumnFlags(int column_n) { return ImGui::TableGetColumnFlags(column_n); }
	__declspec(dllexport) int ImGui_TableGetColumnIndex() { return ImGui::TableGetColumnIndex(); }
	__declspec(dllexport) const char* ImGui_TableGetColumnName(int column_n) { return ImGui::TableGetColumnName(column_n); }
	__declspec(dllexport) const char* ImGui_TableGetColumnName0(const ImGuiTable* table, int column_n) { return ImGui::TableGetColumnName(table, column_n); }
	__declspec(dllexport) ImGuiSortDirection ImGui_TableGetColumnNextSortDirection(ImGuiTableColumn* column) { return ImGui::TableGetColumnNextSortDirection(column); }
	__declspec(dllexport) unsigned int ImGui_TableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no) { return ImGui::TableGetColumnResizeID(table, column_n, instance_no); }
	__declspec(dllexport) float ImGui_TableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column) { return ImGui::TableGetColumnWidthAuto(table, column); }
	__declspec(dllexport) float ImGui_TableGetHeaderAngledMaxLabelWidth() { return ImGui::TableGetHeaderAngledMaxLabelWidth(); }
	__declspec(dllexport) float ImGui_TableGetHeaderRowHeight() { return ImGui::TableGetHeaderRowHeight(); }
	__declspec(dllexport) int ImGui_TableGetHoveredColumn() { return ImGui::TableGetHoveredColumn(); }
	__declspec(dllexport) int ImGui_TableGetHoveredRow() { return ImGui::TableGetHoveredRow(); }
	__declspec(dllexport) int ImGui_TableGetRowIndex() { return ImGui::TableGetRowIndex(); }
	__declspec(dllexport) ImGuiTableSortSpecs* ImGui_TableGetSortSpecs() { return ImGui::TableGetSortSpecs(); }
	__declspec(dllexport) void ImGui_TableHeader(const char* label) { ImGui::TableHeader(label); }
	__declspec(dllexport) void ImGui_TableHeadersRow() { ImGui::TableHeadersRow(); }
	__declspec(dllexport) void ImGui_TableLoadSettings(ImGuiTable* table) { ImGui::TableLoadSettings(table); }
	__declspec(dllexport) void ImGui_TableMergeDrawChannels(ImGuiTable* table) { ImGui::TableMergeDrawChannels(table); }
	__declspec(dllexport) bool ImGui_TableNextColumn() { return ImGui::TableNextColumn(); }
	__declspec(dllexport) void ImGui_TableNextRow(int row_flags, float row_min_height) { ImGui::TableNextRow(row_flags, row_min_height); }
	__declspec(dllexport) void ImGui_TableOpenContextMenu(int column_n) { ImGui::TableOpenContextMenu(column_n); }
	__declspec(dllexport) void ImGui_TablePopBackgroundChannel() { ImGui::TablePopBackgroundChannel(); }
	__declspec(dllexport) void ImGui_TablePushBackgroundChannel() { ImGui::TablePushBackgroundChannel(); }
	__declspec(dllexport) void ImGui_TableRemove(ImGuiTable* table) { ImGui::TableRemove(table); }
	__declspec(dllexport) void ImGui_TableResetSettings(ImGuiTable* table) { ImGui::TableResetSettings(table); }
	__declspec(dllexport) void ImGui_TableSaveSettings(ImGuiTable* table) { ImGui::TableSaveSettings(table); }
	__declspec(dllexport) void ImGui_TableSetBgColor(int target, unsigned int color, int column_n) { ImGui::TableSetBgColor(target, color, column_n); }
	__declspec(dllexport) void ImGui_TableSetColumnEnabled(int column_n, bool enabled) { ImGui::TableSetColumnEnabled(column_n, enabled); }
	__declspec(dllexport) bool ImGui_TableSetColumnIndex(int column_n) { return ImGui::TableSetColumnIndex(column_n); }
	__declspec(dllexport) void ImGui_TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, bool append_to_sort_specs) { ImGui::TableSetColumnSortDirection(column_n, sort_direction, append_to_sort_specs); }
	__declspec(dllexport) void ImGui_TableSetColumnWidth(int column_n, float width) { ImGui::TableSetColumnWidth(column_n, width); }
	__declspec(dllexport) void ImGui_TableSetColumnWidthAutoAll(ImGuiTable* table) { ImGui::TableSetColumnWidthAutoAll(table); }
	__declspec(dllexport) void ImGui_TableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n) { ImGui::TableSetColumnWidthAutoSingle(table, column_n); }
	__declspec(dllexport) void ImGui_TableSettingsAddSettingsHandler() { ImGui::TableSettingsAddSettingsHandler(); }
	__declspec(dllexport) ImGuiTableSettings* ImGui_TableSettingsCreate(unsigned int id, int columns_count) { return ImGui::TableSettingsCreate(id, columns_count); }
	__declspec(dllexport) ImGuiTableSettings* ImGui_TableSettingsFindByID(unsigned int id) { return ImGui::TableSettingsFindByID(id); }
	__declspec(dllexport) void ImGui_TableSetupColumn(const char* label, int flags, float init_width_or_weight, unsigned int user_id) { ImGui::TableSetupColumn(label, flags, init_width_or_weight, user_id); }
	__declspec(dllexport) void ImGui_TableSetupDrawChannels(ImGuiTable* table) { ImGui::TableSetupDrawChannels(table); }
	__declspec(dllexport) void ImGui_TableSetupScrollFreeze(int columns, int rows) { ImGui::TableSetupScrollFreeze(columns, rows); }
	__declspec(dllexport) void ImGui_TableSortSpecsBuild(ImGuiTable* table) { ImGui::TableSortSpecsBuild(table); }
	__declspec(dllexport) void ImGui_TableSortSpecsSanitize(ImGuiTable* table) { ImGui::TableSortSpecsSanitize(table); }
	__declspec(dllexport) void ImGui_TableUpdateBorders(ImGuiTable* table) { ImGui::TableUpdateBorders(table); }
	__declspec(dllexport) void ImGui_TableUpdateColumnsWeightFromWidth(ImGuiTable* table) { ImGui::TableUpdateColumnsWeightFromWidth(table); }
	__declspec(dllexport) void ImGui_TableUpdateLayout(ImGuiTable* table) { ImGui::TableUpdateLayout(table); }
	__declspec(dllexport) void ImGui_TeleportMousePos(const ImVec2& pos) { ImGui::TeleportMousePos(pos); }
	__declspec(dllexport) bool ImGui_TempInputScalar(const ImRect& bb, unsigned int id, const char* label, int data_type, void* p_data, const char* format, const void* p_clamp_min, const void* p_clamp_max) { return ImGui::TempInputScalar(bb, id, label, data_type, p_data, format, p_clamp_min, p_clamp_max); }
	__declspec(dllexport) bool ImGui_TempInputText(const ImRect& bb, unsigned int id, const char* label, char* buf, int buf_size, int flags) { return ImGui::TempInputText(bb, id, label, buf, buf_size, flags); }
	__declspec(dllexport) bool ImBitVector_TestBit(const ImBitVector* _this, int n) { return _this->TestBit(n); }
	__declspec(dllexport) bool ImGui_TestKeyOwner(ImGuiKey key, unsigned int owner_id) { return ImGui::TestKeyOwner(key, owner_id); }
	__declspec(dllexport) bool ImGui_TestShortcutRouting(int key_chord, unsigned int owner_id) { return ImGui::TestShortcutRouting(key_chord, owner_id); }
	__declspec(dllexport) void ImGui_TextColoredV(const ImVec4& col, const char* fmt, char* args) { ImGui::TextColoredV(col, fmt, args); }
	__declspec(dllexport) void ImGui_TextDisabledV(const char* fmt, char* args) { ImGui::TextDisabledV(fmt, args); }
	__declspec(dllexport) void ImGui_TextEx(const char* text, const char* text_end, int flags) { ImGui::TextEx(text, text_end, flags); }
	__declspec(dllexport) bool ImGui_TextLink(const char* label) { return ImGui::TextLink(label); }
	__declspec(dllexport) void ImGui_TextLinkOpenURL(const char* label, const char* url) { ImGui::TextLinkOpenURL(label, url); }
	__declspec(dllexport) void ImGui_TextUnformatted(const char* text, const char* text_end) { ImGui::TextUnformatted(text, text_end); }
	__declspec(dllexport) void ImGui_TextV(const char* fmt, char* args) { ImGui::TextV(fmt, args); }
	__declspec(dllexport) void ImGui_TextWrappedV(const char* fmt, char* args) { ImGui::TextWrappedV(fmt, args); }
	__declspec(dllexport) ImRect ImGuiWindow_TitleBarRect(const ImGuiWindow* _this) { return _this->TitleBarRect(); }
	__declspec(dllexport) ImVec4 ImRect_ToVec4(const ImRect* _this) { return _this->ToVec4(); }
	__declspec(dllexport) void ImRect_Translate(ImRect* _this, const ImVec2& d) { _this->Translate(d); }
	__declspec(dllexport) void ImGui_TranslateWindowsInViewport(ImGuiViewportP* viewport, const ImVec2& old_pos, const ImVec2& new_pos, const ImVec2& old_size, const ImVec2& new_size) { ImGui::TranslateWindowsInViewport(viewport, old_pos, new_pos, old_size, new_size); }
	__declspec(dllexport) void ImRect_TranslateX(ImRect* _this, float dx) { _this->TranslateX(dx); }
	__declspec(dllexport) void ImRect_TranslateY(ImRect* _this, float dy) { _this->TranslateY(dy); }
	__declspec(dllexport) bool ImGui_TreeNode(const char* label) { return ImGui::TreeNode(label); }
	__declspec(dllexport) bool ImGui_TreeNodeBehavior(unsigned int id, int flags, const char* label, const char* label_end) { return ImGui::TreeNodeBehavior(id, flags, label, label_end); }
	__declspec(dllexport) bool ImGui_TreeNodeEx(const char* label, int flags) { return ImGui::TreeNodeEx(label, flags); }
	__declspec(dllexport) bool ImGui_TreeNodeExV(const char* str_id, int flags, const char* fmt, char* args) { return ImGui::TreeNodeExV(str_id, flags, fmt, args); }
	__declspec(dllexport) bool ImGui_TreeNodeExV0(const void* ptr_id, int flags, const char* fmt, char* args) { return ImGui::TreeNodeExV(ptr_id, flags, fmt, args); }
	__declspec(dllexport) bool ImGui_TreeNodeGetOpen(unsigned int storage_id) { return ImGui::TreeNodeGetOpen(storage_id); }
	__declspec(dllexport) void ImGui_TreeNodeSetOpen(unsigned int storage_id, bool open) { ImGui::TreeNodeSetOpen(storage_id, open); }
	__declspec(dllexport) bool ImGui_TreeNodeUpdateNextOpen(unsigned int storage_id, int flags) { return ImGui::TreeNodeUpdateNextOpen(storage_id, flags); }
	__declspec(dllexport) bool ImGui_TreeNodeV(const char* str_id, const char* fmt, char* args) { return ImGui::TreeNodeV(str_id, fmt, args); }
	__declspec(dllexport) bool ImGui_TreeNodeV0(const void* ptr_id, const char* fmt, char* args) { return ImGui::TreeNodeV(ptr_id, fmt, args); }
	__declspec(dllexport) void ImGui_TreePop() { ImGui::TreePop(); }
	__declspec(dllexport) void ImGui_TreePush(const char* str_id) { ImGui::TreePush(str_id); }
	__declspec(dllexport) void ImGui_TreePush0(const void* ptr_id) { ImGui::TreePush(ptr_id); }
	__declspec(dllexport) void ImGui_TreePushOverrideID(unsigned int id) { ImGui::TreePushOverrideID(id); }
	__declspec(dllexport) int ImGui_TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int items_count, const char* (__cdecl* get_item_name_func)(void*, int), void* user_data) { return ImGui::TypingSelectFindBestLeadingMatch(req, items_count, get_item_name_func, user_data); }
	__declspec(dllexport) int ImGui_TypingSelectFindMatch(ImGuiTypingSelectRequest* req, int items_count, const char* (__cdecl* get_item_name_func)(void*, int), void* user_data, int nav_item_idx) { return ImGui::TypingSelectFindMatch(req, items_count, get_item_name_func, user_data, nav_item_idx); }
	__declspec(dllexport) int ImGui_TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int items_count, const char* (__cdecl* get_item_name_func)(void*, int), void* user_data, int nav_item_idx) { return ImGui::TypingSelectFindNextSingleCharMatch(req, items_count, get_item_name_func, user_data, nav_item_idx); }
	__declspec(dllexport) void ImGui_Unindent(float indent_w) { ImGui::Unindent(indent_w); }
	__declspec(dllexport) void ImGuiMenuColumns_Update(ImGuiMenuColumns* _this, float spacing, bool window_reappearing) { _this->Update(spacing, window_reappearing); }
	__declspec(dllexport) void ImGui_UpdateHoveredWindowAndCaptureFlags() { ImGui::UpdateHoveredWindowAndCaptureFlags(); }
	__declspec(dllexport) void ImGui_UpdateInputEvents(bool trickle_fast_inputs) { ImGui::UpdateInputEvents(trickle_fast_inputs); }
	__declspec(dllexport) void ImGuiDockNode_UpdateMergedFlags(ImGuiDockNode* _this) { _this->UpdateMergedFlags(); }
	__declspec(dllexport) void ImGui_UpdateMouseMovingWindowEndFrame() { ImGui::UpdateMouseMovingWindowEndFrame(); }
	__declspec(dllexport) void ImGui_UpdateMouseMovingWindowNewFrame() { ImGui::UpdateMouseMovingWindowNewFrame(); }
	__declspec(dllexport) void ImGui_UpdatePlatformWindows() { ImGui::UpdatePlatformWindows(); }
	__declspec(dllexport) void ImGui_UpdateWindowParentAndRootLinks(ImGuiWindow* window, int flags, ImGuiWindow* parent_window) { ImGui::UpdateWindowParentAndRootLinks(window, flags, parent_window); }
	__declspec(dllexport) void ImGui_UpdateWindowSkipRefresh(ImGuiWindow* window) { ImGui::UpdateWindowSkipRefresh(window); }
	__declspec(dllexport) bool ImGui_VSliderFloat(const char* label, const ImVec2& size, float* v, float v_min, float v_max, const char* format, int flags) { return ImGui::VSliderFloat(label, size, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_VSliderInt(const char* label, const ImVec2& size, int* v, int v_min, int v_max, const char* format, int flags) { return ImGui::VSliderInt(label, size, v, v_min, v_max, format, flags); }
	__declspec(dllexport) bool ImGui_VSliderScalar(const char* label, const ImVec2& size, int data_type, void* p_data, const void* p_min, const void* p_max, const char* format, int flags) { return ImGui::VSliderScalar(label, size, data_type, p_data, p_min, p_max, format, flags); }
	__declspec(dllexport) void ImGui_Value(const char* prefix, int v) { ImGui::Value(prefix, v); }
	__declspec(dllexport) void ImGui_Value0(const char* prefix, unsigned int v) { ImGui::Value(prefix, v); }
	__declspec(dllexport) void ImGui_Value1(const char* prefix, float v, const char* float_format) { ImGui::Value(prefix, v, float_format); }
	__declspec(dllexport) void ImGui_Value2(const char* prefix, bool b) { ImGui::Value(prefix, b); }
	__declspec(dllexport) int ImDrawList__CalcCircleAutoSegmentCount(const ImDrawList* _this, float radius) { return _this->_CalcCircleAutoSegmentCount(radius); }
	__declspec(dllexport) void ImDrawList__ClearFreeMemory(ImDrawList* _this) { _this->_ClearFreeMemory(); }
	__declspec(dllexport) void ImDrawList__OnChangedClipRect(ImDrawList* _this) { _this->_OnChangedClipRect(); }
	__declspec(dllexport) void ImDrawList__OnChangedTextureID(ImDrawList* _this) { _this->_OnChangedTextureID(); }
	__declspec(dllexport) void ImDrawList__OnChangedVtxOffset(ImDrawList* _this) { _this->_OnChangedVtxOffset(); }
	__declspec(dllexport) void ImDrawList__PathArcToFastEx(ImDrawList* _this, const ImVec2& center, float radius, int a_min_sample, int a_max_sample, int a_step) { _this->_PathArcToFastEx(center, radius, a_min_sample, a_max_sample, a_step); }
	__declspec(dllexport) void ImDrawList__PathArcToN(ImDrawList* _this, const ImVec2& center, float radius, float a_min, float a_max, int num_segments) { _this->_PathArcToN(center, radius, a_min, a_max, num_segments); }
	__declspec(dllexport) void ImDrawList__PopUnusedDrawCmd(ImDrawList* _this) { _this->_PopUnusedDrawCmd(); }
	__declspec(dllexport) void ImDrawList__ResetForNewFrame(ImDrawList* _this) { _this->_ResetForNewFrame(); }
	__declspec(dllexport) void ImDrawList__SetTextureID(ImDrawList* _this, unsigned long long texture_id) { _this->_SetTextureID(texture_id); }
	__declspec(dllexport) void ImDrawList__TryMergeDrawCmds(ImDrawList* _this) { _this->_TryMergeDrawCmds(); }
	__declspec(dllexport) void ImGuiTextBuffer_append(ImGuiTextBuffer* _this, const char* str, const char* str_end) { _this->append(str, str_end); }
	__declspec(dllexport) void ImGuiTextBuffer_appendfv(ImGuiTextBuffer* _this, const char* fmt, char* args) { _this->appendfv(fmt, args); }
	__declspec(dllexport) void ImGuiTextFilter_ImGuiTextRange_split(const ImGuiTextFilter::ImGuiTextRange* _this, char separator, ImVector<ImGuiTextFilter::ImGuiTextRange>* out) { _this->split(separator, out); }

}
