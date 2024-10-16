cmake_minimum_required (VERSION 3.22)
project (imgui)

cmake_policy(SET CMP0005 NEW)

option(IMGUI_DISABLE_OBSOLETE_FUNCTIONS "Disable deprecated functions" ON)
option(IMGUI_DISABLE_FILE_FUNCTIONS "Disable use of file functions" OFF)
option(IMGUI_ENABLE_STDLIB_SUPPORT "Enable extra functions taking stdlib types" OFF)
option(IMGUI_ENABLE_COVERAGE "Enable coverage testing for supported compilers" OFF)
option(IMGUI_ENABLE_ASAN "Enable compiler-based sanitizers" OFF)
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

# Minimal supported C++ standard.
if (NOT DEFINED CMAKE_CXX_STANDARD)
    set (CMAKE_CXX_STANDARD 98)
endif ()

set(IMGUI_API "__declspec(dllexport)" CACHE STRING "IMGUI_API")
set(IMGUI_IMPL_API "__declspec(dllexport)" CACHE STRING "IMGUI_IMPL_API")

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
list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imgui_demo.h)
list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imgui_demo.cpp)
list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imconfig.h)
list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imstb_rectpack.h)
list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imstb_textedit.h)
list(REMOVE_ITEM IMGUI_SOURCE_FILES ${IMGUI_ROOT_DIR}/imstb_truetype.h)

add_library(imgui SHARED ${IMGUI_SOURCE_FILES})
target_include_directories(imgui PUBLIC ${IMGUI_ROOT_DIR})
if (IMGUI_ENABLE_STDLIB_SUPPORT)
    target_include_directories(imgui PUBLIC misc/cpp)
    target_sources(imgui PRIVATE misc/cpp/imgui_stdlib.h misc/cpp/imgui_stdlib.cpp)
endif ()



add_executable(imgui_net_export ${IMGUI_SOURCE_FILES} main.cpp
        main.h
        utils.h
        utils.cpp)
set_target_properties(imgui_net_export PROPERTIES LINK_FLAGS /SUBSYSTEM:CONSOLE)

set(DIA_SDK_PATH ${CMAKE_GENERATOR_INSTANCE}/DIA\ SDK)
if(CMAKE_VS_PLATFORM_NAME STREQUAL "x64")
	set(DIA_SDK_PLATFORM "amd64/") 
endif()
if(CMAKE_VS_PLATFORM_NAME STREQUAL "Win32")
	set(DIA_SDK_PLATFORM "")
endif()
if(CMAKE_VS_PLATFORM_NAME STREQUAL "ARM")
	set(DIA_SDK_PLATFORM "arm/")
endif()
if(CMAKE_VS_PLATFORM_NAME STREQUAL "ARM64")
	set(DIA_SDK_PLATFORM "arm64/")
endif()

set(DIA_SDK_INCLUDE ${DIA_SDK_PATH}/include/)
set(DIA_SDK_LIB ${DIA_SDK_PATH}/lib/${DIA_SDK_PLATFORM}diaguids.lib)
set(DIA_SDK_BINARY ${DIA_SDK_PATH}/bin/${DIA_SDK_PLATFORM}msdia140.dll)
target_link_libraries(imgui_net_export PRIVATE ${DIA_SDK_LIB})
target_include_directories(imgui_net_export PRIVATE ${DIA_SDK_INCLUDE})
target_include_directories(imgui_net_export PRIVATE ${IMGUI_ROOT_DIR})


set(CMAKE_VS_SDK_INCLUDE_DIRECTORIES "$(VC_IncludePath);$(WindowsSDK_IncludePath)" ${_NATIVE_DIRS})

set_property(DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR} PROPERTY VS_STARTUP_PROJECT imgui_net_export)


add_library(imgui_win32 SHARED)
target_link_libraries(imgui_win32 imgui)
target_sources(imgui_win32 PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_win32.h ${IMGUI_BACKENDS_DIR}/imgui_impl_win32.cpp)

add_library(imgui_win32_dx9 SHARED)
target_link_libraries(imgui_win32_dx9 imgui)
if (IMGUI_IMPL_DX9)
    check_include_file(d3d9.h HAS_D3D9)
    if (HAS_D3D9)
		target_sources(imgui_win32_dx9 PUBLIC ${IMGUI_BACKENDS_DIR}/imgui_impl_dx9.h ${IMGUI_BACKENDS_DIR}/imgui_impl_dx9.cpp)
    else ()
        message (STATUS "IMGUI_IMPL_DX9 set to ON but DirectX 9 could not be found.")
    endif ()
endif ()

add_library(imgui_win32_dx11 SHARED)
target_link_libraries(imgui_win32_dx11 imgui)
if (IMGUI_IMPL_DX11)
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
target_compile_definitions(imgui_options INTERFACE -DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)
# target_compile_definitions(imgui_options INTERFACE -DIMGUI_DISABLE_FILE_FUNCTIONS=1)
target_compile_definitions(imgui_options INTERFACE -DIMGUI_DISABLE_DEMO_WINDOWS=1)
if (IMGUI_USER_CONFIG) 
	target_compile_definitions(imgui_options INTERFACE "-DIMGUI_USER_CONFIG=<${IMGUI_USER_CONFIG}>") 
endif ()

set_property(
    TARGET imgui imgui_win32 imgui_win32_dx9 imgui_win32_dx11
    APPEND PROPERTY LINK_LIBRARIES imgui_options
)



