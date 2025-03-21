cmake_minimum_required (VERSION 3.22)
project (imgui_net_export)

option(IMGUI_IMPL_WIN32 "Build the Win32 implementation (only if supported)" ${WIN32})
option(IMGUI_IMPL_DX9 "Build the DirectX 9 implementation (only if supported)" ${WIN32})
option(IMGUI_IMPL_DX11 "Build the DirectX 11 implementation (only if supported)" OFF)
option(IMGUI_INTERNAL "imgui_internal.h" OFF)
option(IMGUI_DEMO "imgui_demo.cpp" OFF)
option(IMGUI_DRAW "imgui_draw.cpp" ON)
option(IMGUI_TABLES "imgui_tables.cpp" ON)
option(IMGUI_WIDGETS "imgui_widgets.cpp" ON)
option(IMSTB_RECTPACK "imstb_rectpack.h" OFF)
option(IMSTB_TEXTEDIT "imstb_textedit.h" OFF)
option(IMSTB_TRUETYPE "imstb_truetype.h" OFF)

option(STATIC_LIBRARY "Static Library" ON)

if(NOT CMAKE_BUILD_TYPE)
    set(CMAKE_BUILD_TYPE "RelWithDebInfo")
endif()

if (NOT DEFINED CMAKE_RUNTIME_OUTPUT_DIRECTORY)
    set (CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)
endif ()
if (NOT DEFINED CMAKE_LIBRARY_OUTPUT_DIRECTORY)
    set (CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)
endif ()
if (NOT DEFINED CMAKE_ARCHIVE_OUTPUT_DIRECTORY)
    set (CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
endif ()

if (NOT DEFINED CMAKE_CXX_STANDARD)
    set (CMAKE_CXX_STANDARD 98)
endif ()

if (CMAKE_CXX_COMPILER_ID MATCHES "MSVC")
	add_compile_options(
        /d2cgsummary      # Improve cross-module optimizations
        /Gw               # Enable function-level linking (removes unused functions)
        /Gy               # Enable function-level optimizations (separate COMDATs)
        /GS-              # Disable stack security checks
        /sdl-             # Disable additional security checks
        /guard:cf-        # Disable Control Flow Guard (CFG)
        /Oy               # Enable frame pointer omission (smaller code)
        /Zc:inline        # Remove unreferenced COMDATs (inline function optimizations)
        /Zc:throwingNew   # Optimize `new` operator to assume it never returns nullptr
        /Zc:strictStrings # Store string literals in read-only memory
        /fp:fast          # Enable fast floating-point optimizations
        /GF               # Enable string pooling (deduplicates string literals)
        /Ob3              # Aggressive inlining (maximizes inline expansion)
        /GL               # Enable whole program optimization (LTCG)
		/Oy-			  # Forces frame pointers to be omitted in some cases where /Oy alone doesn't work.
		)
endif ()

if (CMAKE_CXX_COMPILER_ID MATCHES "Clang")
	add_compile_options(-Wall -Wextra -Wunused-parameter -Wformat $<$<COMPILE_LANGUAGE:CXX>:-pedantic> -Wnarrowing)
    add_compile_options(-Wsign-conversion -Wshadow)
endif ()

set (IMGUI_ROOT_DIR ${CMAKE_CURRENT_LIST_DIR}/imgui)
set (IMGUI_BACKENDS_DIR ${IMGUI_ROOT_DIR}/backends)
set (IMGUI_MISC_DIR ${IMGUI_ROOT_DIR}/misc)

set(CMAKE_REQUIRED_QUIET ON)
include(CheckIncludeFile)
find_package(PkgConfig QUIET)

set(LIB_TYPE STATIC)
if(NOT STATIC_LIBRARY)
    set(LIB_TYPE SHARED)
endif()

add_library(imgui_options INTERFACE)

add_library(imgui ${LIB_TYPE} ${IMGUI_ROOT_DIR}/imgui.h ${IMGUI_ROOT_DIR}/imgui.cpp)
target_include_directories(imgui PUBLIC ${IMGUI_ROOT_DIR})
target_include_directories(imgui PUBLIC ${IMGUI_BACKENDS_DIR})

if(IMGUI_INTERNAL)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imgui_internal.h)
endif()

if(IMGUI_DEMO)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imgui_demo.cpp)
endif()

if(IMGUI_DRAW)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imgui_draw.cpp)
endif()

if(IMGUI_TABLES)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imgui_tables.cpp)
endif()

if(IMGUI_WIDGETS)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imgui_widgets.cpp)
endif()

if(IMSTB_RECTPACK)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imstb_rectpack.h)
endif()

if(IMSTB_TEXTEDIT)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imstb_textedit.h)
endif()

if(IMSTB_TRUETYPE)
	target_sources(imgui PUBLIC ${IMGUI_ROOT_DIR}/imstb_truetype.h)
endif()

if(IMGUI_IMPL_WIN32)
	target_sources(imgui PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_win32.h ${IMGUI_BACKENDS_DIR}/imgui_impl_win32.cpp)
endif()

if(IMGUI_IMPL_DX9)
    check_include_file(d3d9.h HAS_D3D9)
    if(HAS_D3D9)
		target_sources(imgui PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_dx9.h ${IMGUI_BACKENDS_DIR}/imgui_impl_dx9.cpp)
    else()
        message(STATUS "IMGUI_IMPL_DX9 set to ON but DirectX 9 could not be found.")
    endif()
endif()

if(IMGUI_IMPL_DX11)
    check_include_file(d3d11.h HAS_D3D11)
    if(HAS_D3D11)
		target_sources(imgui PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_dx11.h ${IMGUI_BACKENDS_DIR}/imgui_impl_dx11.cpp)
    else()
        message(STATUS "IMGUI_IMPL_DX11 set to ON but DirectX 11 could not be found.")
    endif()
endif()

target_sources(imgui PUBLIC imgui_export.h imgui_export.cpp)


set(IMGUI_USER_CONFIG "${IMGUI_ROOT_DIR}/imconfig.h" CACHE FILEPATH "User config")
if(IMGUI_USER_CONFIG)
	target_compile_definitions(imgui_options INTERFACE "-DIMGUI_USER_CONFIG=<${IMGUI_USER_CONFIG}>")
endif()

set_property(TARGET imgui APPEND PROPERTY LINK_LIBRARIES imgui_options)