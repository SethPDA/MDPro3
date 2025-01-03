workspace "YGO Classes"
    location "build"
    objdir "build/obj"
    language "C++"
    platforms { "x64" }
    configurations { "Debug", "Release" }

    defines { "WIN32", "_WIN32", "BUILD_LUA"}
    include "../../lua"
    include "../../event"
    include "../../sqlite3"
    include "../../irrlicht/premake5-only-zipreader.lua"
    include "../../ocgcore"
    include "../../ygoserver"

    vectorextensions "SSE2"
    buildoptions { "/utf-8" }
    defines { "_CRT_SECURE_NO_WARNINGS" }
    disablewarnings { "4244", "4267", "4838", "4577", "4819", "4018", "4996", "4477", "4091", "4828", "4800", "6011", "6031", "6054", "6262" }