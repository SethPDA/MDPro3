project "ocgcore"
    kind "SharedLib"

    files { "*.cpp", "*.h" }
    links { "lua" }
    includedirs { "../lua/src" }
