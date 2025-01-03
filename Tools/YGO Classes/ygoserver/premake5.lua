include "lzma/."
include "spmemvfs/."

project "ygoserver"
    kind "SharedLib"

    files { "**.cpp", "**.cc", "**.c", "**.h" }
    includedirs { "spmemvfs", "../ocgcore", "../event/include", "../event/windows", "../sqlite3", "../Irrlicht/source/Irrlicht", "../Irrlicht/include" }
    links { "ocgcore", "clzma", "sqlite3", "lua" , "event", "irrlicht", "cspmemvfs", "ws2_32"}
    defines { "YGOPRO_SERVER_MODE", "SERVER_ZIP_SUPPORT", "SERVER_PRO2_SUPPORT", "SERVER_PRO3_SUPPORT", "_IRR_WCHAR_FILESYSTEM", "SERVER_TAG_SURRENDER_CONFIRM" }
