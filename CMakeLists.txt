cmake_minimum_required (VERSION 3.22)
project (imgui_next_export)

option(IMGUI_IMPL_WIN32 "Build the Win32 implementation (only if supported)" ${WIN32})
option(IMGUI_IMPL_DX9 "Build the DirectX 9 implementation (only if supported)" ${WIN32})
option(IMGUI_IMPL_DX11 "Build the DirectX 11 implementation (only if supported)" ${WIN32})

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

set(IMGUI_API "__declspec(dllexport)" CACHE STRING "IMGUI_API")
set(IMGUI_IMPL_API "__declspec(dllexport)" CACHE STRING "IMGUI_IMPL_API")

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
set (IMGUI_EXAMPLES_DIR ${IMGUI_ROOT_DIR}/examples)
set (IMGUI_BACKENDS_DIR ${IMGUI_ROOT_DIR}/backends)
set (IMGUI_MISC_DIR ${IMGUI_ROOT_DIR}/misc)

set(CMAKE_REQUIRED_QUIET ON)
include(CheckIncludeFile)
find_package(PkgConfig QUIET)

file(GLOB IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/*.h ${IMGUI_ROOT_DIR}/*.cpp)
#list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imgui_demo.h)
#list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imgui_demo.cpp)
#list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imconfig.h)
#list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imstb_rectpack.h)
#list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imstb_textedit.h)
#list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imstb_truetype.h)

set(IMGUI_USER_CONFIG "${IMGUI_ROOT_DIR}/imconfig.h" CACHE FILEPATH "User config")

if(NOT IMGUI_USER_CONFIG)
    set(IMGUI_USER_CONFIG "${IMGUI_ROOT_DIR}/imconfig.h")
endif()

add_library(imgui SHARED ${IMGUI_SOURCE_FILES})
target_include_directories(imgui PUBLIC ${IMGUI_ROOT_DIR})
if (IMGUI_ENABLE_STDLIB_SUPPORT)
    target_include_directories(imgui PUBLIC misc/cpp)
    target_sources(imgui PRIVATE misc/cpp/imgui_stdlib.h misc/cpp/imgui_stdlib.cpp)
endif ()

if(IMGUI_IMPL_WIN32)
	add_library(imgui_win32 SHARED)
	target_link_libraries(imgui_win32 imgui)
	target_sources(imgui_win32 PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_win32.h ${IMGUI_BACKENDS_DIR}/imgui_impl_win32.cpp)
endif()

if (IMGUI_IMPL_DX9)
	add_library(imgui_win32_dx9 SHARED)
	target_link_libraries(imgui_win32_dx9 imgui)
    check_include_file(d3d9.h HAS_D3D9)
    if (HAS_D3D9)
		target_sources(imgui_win32_dx9 PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_dx9.h ${IMGUI_BACKENDS_DIR}/imgui_impl_dx9.cpp)
    else ()
        message (STATUS "IMGUI_IMPL_DX9 set to ON but DirectX 9 could not be found.")
    endif ()
endif ()

if (IMGUI_IMPL_DX11)
	add_library(imgui_win32_dx11 SHARED)
	target_link_libraries(imgui_win32_dx11 imgui)
    check_include_file(d3d11.h HAS_D3D11)
    if (HAS_D3D11)
		target_sources(imgui_win32_dx11 PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_dx11.h ${IMGUI_BACKENDS_DIR}/imgui_impl_dx11.cpp)
    else ()
        message (STATUS "IMGUI_IMPL_DX11 set to ON but DirectX 11 could not be found.")
    endif ()
endif ()

add_library(imgui_options INTERFACE)
target_compile_definitions(imgui_options INTERFACE -DIMGUI_API=${IMGUI_API})
target_compile_definitions(imgui_options INTERFACE -DIMGUI_IMPL_API=${IMGUI_IMPL_API})

if(IMGUI_USER_CONFIG)
	target_compile_definitions(imgui_options INTERFACE "-DIMGUI_USER_CONFIG=<${IMGUI_USER_CONFIG}>")
endif()

set_property(TARGET imgui APPEND PROPERTY LINK_LIBRARIES imgui_options)
if(IMGUI_IMPL_WIN32)
	set_property(TARGET imgui_win32 APPEND PROPERTY LINK_LIBRARIES imgui_options)
endif()
if(IMGUI_IMPL_DX9)
	set_property(TARGET imgui_win32_dx9 APPEND PROPERTY LINK_LIBRARIES imgui_options)
endif()
if(IMGUI_IMPL_DX11)
	set_property(TARGET imgui_win32_dx11 APPEND PROPERTY LINK_LIBRARIES imgui_options)
endif()