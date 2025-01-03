project "cspmemvfs"
    kind "StaticLib"
    files { "*.c", "*.h" }
    includedirs { "../../sqlite3" }
