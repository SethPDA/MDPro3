Shader "ShaderGraph_CloseUp"
{
    Properties
    {
        [NoScaleOffset]_MainTex("BaseMap", 2D) = "white" {}
        [HDR]_Color("Color", Color) = (1.498039, 1.498039, 1.498039, 0)
        outlineOffest("OutlineOffest", Float) = 0.005
        GlowFrequency("GlowFrequency", Float) = 1.6
        GlowRange("GlowRange", Vector) = (0, 1, 0, 0)
        GlowControl("GlowControl", Float) = 1
        EdgeControl("EdgeControl", Float) = 0.8
        RGBA("RGBA", Vector) = (1, 1, 1, 1)
        Mono("Mono", Float) = 0
        [HideInInspector][NoScaleOffset]unity_Lightmaps("unity_Lightmaps", 2DArray) = "" {}
        [HideInInspector][NoScaleOffset]unity_LightmapsInd("unity_LightmapsInd", 2DArray) = "" {}
        [HideInInspector][NoScaleOffset]unity_ShadowMasks("unity_ShadowMasks", 2DArray) = "" {}
    }
    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "UniversalMaterialType" = "Unlit"
            "Queue"="Transparent"
        }
        AlphaToMask On
        Pass
        {
            Name "Pass"
            Tags
            {
                // LightMode: <None>
            }

            // Render State
            Cull Back
        Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
        ZTest LEqual
        ZWrite Off

            // Debug
            // <None>

            // --------------------------------------------------
            // Pass

            HLSLPROGRAM

            // Pragmas
            #pragma target 2.0
        #pragma only_renderers gles gles3 glcore d3d11
        #pragma multi_compile_instancing
        #pragma multi_compile_fog
        #pragma vertex vert
        #pragma fragment frag

            // DotsInstancingOptions: <None>
            // HybridV1InjectedBuiltinProperties: <None>

            // Keywords
            #pragma multi_compile _ LIGHTMAP_ON
        #pragma multi_compile _ DIRLIGHTMAP_COMBINED
        #pragma shader_feature _ _SAMPLE_GI
            // GraphKeywords: <None>

            // Defines
            #define _SURFACE_TYPE_TRANSPARENT 1
            #define _AlphaClip 1
            #define ATTRIBUTES_NEED_NORMAL
            #define ATTRIBUTES_NEED_TANGENT
            #define ATTRIBUTES_NEED_TEXCOORD0
            #define VARYINGS_NEED_TEXCOORD0
            #define FEATURES_GRAPH_VERTEX
            /* WARNING: $splice Could not find named fragment 'PassInstancing' */
            #define SHADERPASS SHADERPASS_UNLIT
            /* WARNING: $splice Could not find named fragment 'DotsInstancingVars' */

            // Includes
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Texture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/TextureStack.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

            // --------------------------------------------------
            // Structs and Packing

            struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS : NORMAL;
            float4 tangentOS : TANGENT;
            float4 uv0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : INSTANCEID_SEMANTIC;
            #endif
        };
        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float4 texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };
        struct SurfaceDescriptionInputs
        {
            float4 uv0;
        };
        struct VertexDescriptionInputs
        {
            float3 ObjectSpaceNormal;
            float3 ObjectSpaceTangent;
            float3 ObjectSpacePosition;
        };
        struct PackedVaryings
        {
            float4 positionCS : SV_POSITION;
            float4 interp0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };

            PackedVaryings PackVaryings (Varyings input)
        {
            PackedVaryings output;
            output.positionCS = input.positionCS;
            output.interp0.xyzw =  input.texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }
        Varyings UnpackVaryings (PackedVaryings input)
        {
            Varyings output;
            output.positionCS = input.positionCS;
            output.texCoord0 = input.interp0.xyzw;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }

            // --------------------------------------------------
            // Graph

            // Graph Properties
            CBUFFER_START(UnityPerMaterial)
        float4 _MainTex_TexelSize;
        float4 _Color;
        float outlineOffest;
        float GlowFrequency;
        float2 GlowRange;
        float GlowControl;
        float EdgeControl;
        float4 RGBA;
        float Mono;
        CBUFFER_END

        // Object and Global properties
        SAMPLER(SamplerState_Linear_Repeat);
        TEXTURE2D(_MainTex);
        SAMPLER(sampler_MainTex);

            // Graph Functions
            
        void Unity_DotProduct_float4(float4 A, float4 B, out float Out)
        {
            Out = dot(A, B);
        }

        void Unity_Multiply_float(float A, float B, out float Out)
        {
            Out = A * B;
        }

        void Unity_Multiply_float(float4 A, float4 B, out float4 Out)
        {
            Out = A * B;
        }

        void Unity_Add_float3(float3 A, float3 B, out float3 Out)
        {
            Out = A + B;
        }

        void Unity_Combine_float(float R, float G, float B, float A, out float4 RGBA, out float3 RGB, out float2 RG)
        {
            RGBA = float4(R, G, B, A);
            RGB = float3(R, G, B);
            RG = float2(R, G);
        }

        void Unity_TilingAndOffset_float(float2 UV, float2 Tiling, float2 Offset, out float2 Out)
        {
            Out = UV * Tiling + Offset;
        }

        void Unity_Add_float(float A, float B, out float Out)
        {
            Out = A + B;
        }

        void Unity_Clamp_float(float In, float Min, float Max, out float Out)
        {
            Out = clamp(In, Min, Max);
        }

        void Unity_Subtract_float(float A, float B, out float Out)
        {
            Out = A - B;
        }

        void Unity_Remap_float(float In, float2 InMinMax, float2 OutMinMax, out float Out)
        {
            Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
        }

        void Unity_Rotate_Degrees_float(float2 UV, float2 Center, float Rotation, out float2 Out)
        {
            //rotation matrix
            Rotation = Rotation * (3.1415926f/180.0f);
            UV -= Center;
            float s = sin(Rotation);
            float c = cos(Rotation);

            //center rotation matrix
            float2x2 rMatrix = float2x2(c, -s, s, c);
            rMatrix *= 0.5;
            rMatrix += 0.5;
            rMatrix = rMatrix*2 - 1;

            //multiply the UVs by the rotation matrix
            UV.xy = mul(UV.xy, rMatrix);
            UV += Center;

            Out = UV;
        }

        void Unity_Minimum_float(float A, float B, out float Out)
        {
            Out = min(A, B);
        };

            // Graph Vertex
            struct VertexDescription
        {
            float3 Position;
            float3 Normal;
            float3 Tangent;
        };

        VertexDescription VertexDescriptionFunction(VertexDescriptionInputs IN)
        {
            VertexDescription description = (VertexDescription)0;
            description.Position = IN.ObjectSpacePosition;
            description.Normal = IN.ObjectSpaceNormal;
            description.Tangent = IN.ObjectSpaceTangent;
            return description;
        }

            // Graph Pixel
            struct SurfaceDescription
        {
            float3 BaseColor;
            float Alpha;
            float AlphaClipThreshold;
        };

        SurfaceDescription SurfaceDescriptionFunction(SurfaceDescriptionInputs IN)
        {
            SurfaceDescription surface = (SurfaceDescription)0;
            UnityTexture2D _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float4 _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0 = SAMPLE_TEXTURE2D(_Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.tex, _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.samplerstate, IN.uv0.xy);
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_R_4 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.r;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_G_5 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.g;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_B_6 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.b;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.a;
            float _DotProduct_c13f317210be4433a971e33406d8b7cd_Out_2;
            Unity_DotProduct_float4(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0, float4(0.299, 0.587, 0.114, 0), _DotProduct_c13f317210be4433a971e33406d8b7cd_Out_2);
            float _Property_1beddd7212ee42dba29de520dfa38e78_Out_0 = Mono;
            float _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2;
            Unity_Multiply_float(_DotProduct_c13f317210be4433a971e33406d8b7cd_Out_2, _Property_1beddd7212ee42dba29de520dfa38e78_Out_0, _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2);
            float3 _Vector3_f970e30adc314ca39f6f997db146df5e_Out_0 = float3(_Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2, _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2, _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2);
            float4 _Property_bd131a3d764d4a399c48b1d9e28c2a71_Out_0 = RGBA;
            float4 _Multiply_400ee0bb75104249a0a4e827ab8752cd_Out_2;
            Unity_Multiply_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0, _Property_bd131a3d764d4a399c48b1d9e28c2a71_Out_0, _Multiply_400ee0bb75104249a0a4e827ab8752cd_Out_2);
            float3 _Add_42538c6a296840a99a703976b366ddfb_Out_2;
            Unity_Add_float3(_Vector3_f970e30adc314ca39f6f997db146df5e_Out_0, (_Multiply_400ee0bb75104249a0a4e827ab8752cd_Out_2.xyz), _Add_42538c6a296840a99a703976b366ddfb_Out_2);
            UnityTexture2D _Property_74f03fcb472647d2a59b580228c9d3da_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0 = outlineOffest;
            float _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2);
            float _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2);
            float4 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4;
            float3 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5;
            float2 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6;
            Unity_Combine_float(_Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2, 0, 0, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6);
            float2 _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float4 _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0 = SAMPLE_TEXTURE2D(_Property_74f03fcb472647d2a59b580228c9d3da_Out_0.tex, _Property_74f03fcb472647d2a59b580228c9d3da_Out_0.samplerstate, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_R_4 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.r;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_G_5 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.g;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_B_6 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.b;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.a;
            UnityTexture2D _Property_9ac06dcb411b45269374b16af55381bd_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c0c279b23b6d467a923d28be4f49b59f_Out_0 = outlineOffest;
            float _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, 1, _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2);
            float _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, -1, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2);
            float4 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4;
            float3 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5;
            float2 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6;
            Unity_Combine_float(_Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2, 0, 0, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6);
            float2 _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float4 _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9ac06dcb411b45269374b16af55381bd_Out_0.tex, _Property_9ac06dcb411b45269374b16af55381bd_Out_0.samplerstate, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_R_4 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.r;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_G_5 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.g;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_B_6 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.b;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.a;
            float _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2;
            Unity_Add_float(_SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7, _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7, _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2);
            UnityTexture2D _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_3cba5715217f4d94a2fec04740212ae8_Out_0 = outlineOffest;
            float _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, -1, _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2);
            float _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, 1, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2);
            float4 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4;
            float3 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5;
            float2 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6;
            Unity_Combine_float(_Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2, 0, 0, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6);
            float2 _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float4 _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.tex, _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.samplerstate, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_R_4 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.r;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_G_5 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.g;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_B_6 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.b;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.a;
            float _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2;
            Unity_Add_float(_Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2, _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7, _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2);
            UnityTexture2D _Property_4638da389d3f4f7187642a1df36cafc4_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_329a15e14a5f437bbe8147e054d43789_Out_0 = outlineOffest;
            float _Multiply_0322358642d34ca4be034be7037fc103_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 1, _Multiply_0322358642d34ca4be034be7037fc103_Out_2);
            float _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 0, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2);
            float4 _Combine_3610726a63324800845304206f3644ab_RGBA_4;
            float3 _Combine_3610726a63324800845304206f3644ab_RGB_5;
            float2 _Combine_3610726a63324800845304206f3644ab_RG_6;
            Unity_Combine_float(_Multiply_0322358642d34ca4be034be7037fc103_Out_2, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2, 0, 0, _Combine_3610726a63324800845304206f3644ab_RGBA_4, _Combine_3610726a63324800845304206f3644ab_RGB_5, _Combine_3610726a63324800845304206f3644ab_RG_6);
            float2 _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_3610726a63324800845304206f3644ab_RG_6, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float4 _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0 = SAMPLE_TEXTURE2D(_Property_4638da389d3f4f7187642a1df36cafc4_Out_0.tex, _Property_4638da389d3f4f7187642a1df36cafc4_Out_0.samplerstate, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_R_4 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.r;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_G_5 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.g;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_B_6 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.b;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.a;
            float _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2;
            Unity_Add_float(_Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2, _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7, _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2);
            UnityTexture2D _Property_9df39bcda2e242f29ad651b884e519a9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_45befcea4fb14766a59ddd103a6956b3_Out_0 = outlineOffest;
            float _Multiply_207e9916a207418090c84761d147d8ad_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 0, _Multiply_207e9916a207418090c84761d147d8ad_Out_2);
            float _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 1, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2);
            float4 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4;
            float3 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5;
            float2 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6;
            Unity_Combine_float(_Multiply_207e9916a207418090c84761d147d8ad_Out_2, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2, 0, 0, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6);
            float2 _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float4 _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9df39bcda2e242f29ad651b884e519a9_Out_0.tex, _Property_9df39bcda2e242f29ad651b884e519a9_Out_0.samplerstate, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float _SampleTexture2D_590aed00e942488597319811e606040b_R_4 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.r;
            float _SampleTexture2D_590aed00e942488597319811e606040b_G_5 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.g;
            float _SampleTexture2D_590aed00e942488597319811e606040b_B_6 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.b;
            float _SampleTexture2D_590aed00e942488597319811e606040b_A_7 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.a;
            float _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2;
            Unity_Add_float(_Add_bfffff96902e4e71aeaebb5d102086e9_Out_2, _SampleTexture2D_590aed00e942488597319811e606040b_A_7, _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2);
            UnityTexture2D _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0 = outlineOffest;
            float _Multiply_4984902a786a419da073164c825444d5_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, -1, _Multiply_4984902a786a419da073164c825444d5_Out_2);
            float _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, 0, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2);
            float4 _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4;
            float3 _Combine_c8db3debe77247e49c877efa92887a88_RGB_5;
            float2 _Combine_c8db3debe77247e49c877efa92887a88_RG_6;
            Unity_Combine_float(_Multiply_4984902a786a419da073164c825444d5_Out_2, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2, 0, 0, _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4, _Combine_c8db3debe77247e49c877efa92887a88_RGB_5, _Combine_c8db3debe77247e49c877efa92887a88_RG_6);
            float2 _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_c8db3debe77247e49c877efa92887a88_RG_6, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float4 _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0 = SAMPLE_TEXTURE2D(_Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.tex, _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.samplerstate, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_R_4 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.r;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_G_5 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.g;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_B_6 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.b;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.a;
            float _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2;
            Unity_Add_float(_Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2, _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7, _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2);
            UnityTexture2D _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_09dbd287d4844fa7a0a8861450959faf_Out_0 = outlineOffest;
            float _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, 0, _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2);
            float _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, -1, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2);
            float4 _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4;
            float3 _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5;
            float2 _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6;
            Unity_Combine_float(_Multiply_6716f420867641aebd0dd231a2eb0144_Out_2, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2, 0, 0, _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4, _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5, _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6);
            float2 _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float4 _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0 = SAMPLE_TEXTURE2D(_Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.tex, _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.samplerstate, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_R_4 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.r;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_G_5 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.g;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_B_6 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.b;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.a;
            float _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2;
            Unity_Add_float(_Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2, _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7, _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2);
            UnityTexture2D _Property_012c711507b645519f73babdd1f63180_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0 = outlineOffest;
            float _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2);
            float _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2);
            float4 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4;
            float3 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5;
            float2 _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6;
            Unity_Combine_float(_Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2, 0, 0, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5, _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6);
            float2 _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float4 _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0 = SAMPLE_TEXTURE2D(_Property_012c711507b645519f73babdd1f63180_Out_0.tex, _Property_012c711507b645519f73babdd1f63180_Out_0.samplerstate, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_R_4 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.r;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_G_5 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.g;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_B_6 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.b;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.a;
            float _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2;
            Unity_Add_float(_Add_ff805e671d494ebfab34a0eeb33682a7_Out_2, _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7, _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2);
            float _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3;
            Unity_Clamp_float(_Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2, 0, 1, _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3);
            float _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2;
            Unity_Subtract_float(_Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3, _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2);
            float4 _Property_18135612bda74a989de60b55ada14671_Out_0 = IsGammaSpace() ? LinearToSRGB(_Color) : _Color;
            float4 _Multiply_9294d125dff442ccab040f84bf967c38_Out_2;
            Unity_Multiply_float((_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2.xxxx), _Property_18135612bda74a989de60b55ada14671_Out_0, _Multiply_9294d125dff442ccab040f84bf967c38_Out_2);
            float3 _Add_9007fab011814dbcb8fd5c1be2e9aff0_Out_2;
            Unity_Add_float3(_Add_42538c6a296840a99a703976b366ddfb_Out_2, (_Multiply_9294d125dff442ccab040f84bf967c38_Out_2.xyz), _Add_9007fab011814dbcb8fd5c1be2e9aff0_Out_2);
            float _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0 = GlowControl;
            float _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2;
            Unity_Multiply_float(_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2, _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2);
            float _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2;
            Unity_Add_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2, _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2);
            float4 _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0 = IN.uv0;
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_R_1 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[0];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_G_2 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[1];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_B_3 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[2];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_A_4 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[3];
            float _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2;
            Unity_Multiply_float(_Split_e4faf5047a3745dd8484b3c2df1cae11_R_1, 10, _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2);
            float _Remap_b90a61292457452781ce5a0de4613230_Out_3;
            Unity_Remap_float(_Multiply_ee53730afa6346148000cf9afa7374a2_Out_2, float2 (0, 1), float2 (0, 1), _Remap_b90a61292457452781ce5a0de4613230_Out_3);
            float4 _UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0 = IN.uv0;
            float2 _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3;
            Unity_Rotate_Degrees_float((_UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3);
            float _Split_da81384144364fd1b73145399a5a93aa_R_1 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[0];
            float _Split_da81384144364fd1b73145399a5a93aa_G_2 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[1];
            float _Split_da81384144364fd1b73145399a5a93aa_B_3 = 0;
            float _Split_da81384144364fd1b73145399a5a93aa_A_4 = 0;
            float _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2;
            Unity_Multiply_float(_Split_da81384144364fd1b73145399a5a93aa_R_1, 10, _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2);
            float _Remap_421606ae375b41f198468213f05d2cec_Out_3;
            Unity_Remap_float(_Multiply_fc988eefcba94788a083bef41143e4aa_Out_2, float2 (0, 1), float2 (0, 1), _Remap_421606ae375b41f198468213f05d2cec_Out_3);
            float _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2;
            Unity_Minimum_float(_Remap_b90a61292457452781ce5a0de4613230_Out_3, _Remap_421606ae375b41f198468213f05d2cec_Out_3, _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2);
            float4 _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0 = IN.uv0;
            float _Split_c9223221d7574c9481a691cae4eb0097_R_1 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[0];
            float _Split_c9223221d7574c9481a691cae4eb0097_G_2 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[1];
            float _Split_c9223221d7574c9481a691cae4eb0097_B_3 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[2];
            float _Split_c9223221d7574c9481a691cae4eb0097_A_4 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[3];
            float _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2;
            Unity_Multiply_float(_Split_c9223221d7574c9481a691cae4eb0097_G_2, 10, _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2);
            float _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3;
            Unity_Remap_float(_Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2, float2 (0, 1), float2 (0, 1), _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3);
            float4 _UV_3fc62428a61744eda513ee5daa808905_Out_0 = IN.uv0;
            float2 _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3;
            Unity_Rotate_Degrees_float((_UV_3fc62428a61744eda513ee5daa808905_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3);
            float _Split_a037cc6e4b214ea88217c67d2a591114_R_1 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[0];
            float _Split_a037cc6e4b214ea88217c67d2a591114_G_2 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[1];
            float _Split_a037cc6e4b214ea88217c67d2a591114_B_3 = 0;
            float _Split_a037cc6e4b214ea88217c67d2a591114_A_4 = 0;
            float _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2;
            Unity_Multiply_float(_Split_a037cc6e4b214ea88217c67d2a591114_G_2, 10, _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2);
            float _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3;
            Unity_Remap_float(_Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2, float2 (0, 1), float2 (0, 1), _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3);
            float _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2;
            Unity_Minimum_float(_Remap_1388710757cc4cdd8db65720222ae5d9_Out_3, _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2);
            float _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2;
            Unity_Multiply_float(_Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2);
            float _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            Unity_Minimum_float(_Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2, _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2);
            surface.BaseColor = _Add_9007fab011814dbcb8fd5c1be2e9aff0_Out_2;
            surface.Alpha = _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            surface.AlphaClipThreshold = 0.5;
            return surface;
        }

            // --------------------------------------------------
            // Build Graph Inputs

            VertexDescriptionInputs BuildVertexDescriptionInputs(Attributes input)
        {
            VertexDescriptionInputs output;
            ZERO_INITIALIZE(VertexDescriptionInputs, output);

            output.ObjectSpaceNormal =           input.normalOS;
            output.ObjectSpaceTangent =          input.tangentOS.xyz;
            output.ObjectSpacePosition =         input.positionOS;

            return output;
        }
            SurfaceDescriptionInputs BuildSurfaceDescriptionInputs(Varyings input)
        {
            SurfaceDescriptionInputs output;
            ZERO_INITIALIZE(SurfaceDescriptionInputs, output);





            output.uv0 =                         input.texCoord0;
        #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN output.FaceSign =                    IS_FRONT_VFACE(input.cullFace, true, false);
        #else
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN
        #endif
        #undef BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN

            return output;
        }

            // --------------------------------------------------
            // Main

            #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShaderPass.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/Varyings.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/UnlitPass.hlsl"

            ENDHLSL
        }
        Pass
        {
            Name "ShadowCaster"
            Tags
            {
                "LightMode" = "ShadowCaster"
            }

            // Render State
            Cull Back
        Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
        ZTest LEqual
        ZWrite On
        ColorMask 0

            // Debug
            // <None>

            // --------------------------------------------------
            // Pass

            HLSLPROGRAM

            // Pragmas
            #pragma target 2.0
        #pragma only_renderers gles gles3 glcore d3d11
        #pragma multi_compile_instancing
        #pragma vertex vert
        #pragma fragment frag

            // DotsInstancingOptions: <None>
            // HybridV1InjectedBuiltinProperties: <None>

            // Keywords
            #pragma multi_compile _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            // GraphKeywords: <None>

            // Defines
            #define _SURFACE_TYPE_TRANSPARENT 1
            #define _AlphaClip 1
            #define ATTRIBUTES_NEED_NORMAL
            #define ATTRIBUTES_NEED_TANGENT
            #define ATTRIBUTES_NEED_TEXCOORD0
            #define VARYINGS_NEED_TEXCOORD0
            #define FEATURES_GRAPH_VERTEX
            /* WARNING: $splice Could not find named fragment 'PassInstancing' */
            #define SHADERPASS SHADERPASS_SHADOWCASTER
            /* WARNING: $splice Could not find named fragment 'DotsInstancingVars' */

            // Includes
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Texture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/TextureStack.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

            // --------------------------------------------------
            // Structs and Packing

            struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS : NORMAL;
            float4 tangentOS : TANGENT;
            float4 uv0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : INSTANCEID_SEMANTIC;
            #endif
        };
        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float4 texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };
        struct SurfaceDescriptionInputs
        {
            float4 uv0;
        };
        struct VertexDescriptionInputs
        {
            float3 ObjectSpaceNormal;
            float3 ObjectSpaceTangent;
            float3 ObjectSpacePosition;
        };
        struct PackedVaryings
        {
            float4 positionCS : SV_POSITION;
            float4 interp0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };

            PackedVaryings PackVaryings (Varyings input)
        {
            PackedVaryings output;
            output.positionCS = input.positionCS;
            output.interp0.xyzw =  input.texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }
        Varyings UnpackVaryings (PackedVaryings input)
        {
            Varyings output;
            output.positionCS = input.positionCS;
            output.texCoord0 = input.interp0.xyzw;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }

            // --------------------------------------------------
            // Graph

            // Graph Properties
            CBUFFER_START(UnityPerMaterial)
        float4 _MainTex_TexelSize;
        float4 _Color;
        float outlineOffest;
        float GlowFrequency;
        float2 GlowRange;
        float GlowControl;
        float EdgeControl;
        float4 RGBA;
        float Mono;
        CBUFFER_END

        // Object and Global properties
        SAMPLER(SamplerState_Linear_Repeat);
        TEXTURE2D(_MainTex);
        SAMPLER(sampler_MainTex);

            // Graph Functions
            
        void Unity_Multiply_float(float A, float B, out float Out)
        {
            Out = A * B;
        }

        void Unity_Combine_float(float R, float G, float B, float A, out float4 RGBA, out float3 RGB, out float2 RG)
        {
            RGBA = float4(R, G, B, A);
            RGB = float3(R, G, B);
            RG = float2(R, G);
        }

        void Unity_TilingAndOffset_float(float2 UV, float2 Tiling, float2 Offset, out float2 Out)
        {
            Out = UV * Tiling + Offset;
        }

        void Unity_Add_float(float A, float B, out float Out)
        {
            Out = A + B;
        }

        void Unity_Clamp_float(float In, float Min, float Max, out float Out)
        {
            Out = clamp(In, Min, Max);
        }

        void Unity_Subtract_float(float A, float B, out float Out)
        {
            Out = A - B;
        }

        void Unity_Remap_float(float In, float2 InMinMax, float2 OutMinMax, out float Out)
        {
            Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
        }

        void Unity_Rotate_Degrees_float(float2 UV, float2 Center, float Rotation, out float2 Out)
        {
            //rotation matrix
            Rotation = Rotation * (3.1415926f/180.0f);
            UV -= Center;
            float s = sin(Rotation);
            float c = cos(Rotation);

            //center rotation matrix
            float2x2 rMatrix = float2x2(c, -s, s, c);
            rMatrix *= 0.5;
            rMatrix += 0.5;
            rMatrix = rMatrix*2 - 1;

            //multiply the UVs by the rotation matrix
            UV.xy = mul(UV.xy, rMatrix);
            UV += Center;

            Out = UV;
        }

        void Unity_Minimum_float(float A, float B, out float Out)
        {
            Out = min(A, B);
        };

            // Graph Vertex
            struct VertexDescription
        {
            float3 Position;
            float3 Normal;
            float3 Tangent;
        };

        VertexDescription VertexDescriptionFunction(VertexDescriptionInputs IN)
        {
            VertexDescription description = (VertexDescription)0;
            description.Position = IN.ObjectSpacePosition;
            description.Normal = IN.ObjectSpaceNormal;
            description.Tangent = IN.ObjectSpaceTangent;
            return description;
        }

            // Graph Pixel
            struct SurfaceDescription
        {
            float Alpha;
            float AlphaClipThreshold;
        };

        SurfaceDescription SurfaceDescriptionFunction(SurfaceDescriptionInputs IN)
        {
            SurfaceDescription surface = (SurfaceDescription)0;
            UnityTexture2D _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float4 _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0 = SAMPLE_TEXTURE2D(_Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.tex, _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.samplerstate, IN.uv0.xy);
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_R_4 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.r;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_G_5 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.g;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_B_6 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.b;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.a;
            UnityTexture2D _Property_74f03fcb472647d2a59b580228c9d3da_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0 = outlineOffest;
            float _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2);
            float _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2);
            float4 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4;
            float3 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5;
            float2 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6;
            Unity_Combine_float(_Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2, 0, 0, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6);
            float2 _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float4 _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0 = SAMPLE_TEXTURE2D(_Property_74f03fcb472647d2a59b580228c9d3da_Out_0.tex, _Property_74f03fcb472647d2a59b580228c9d3da_Out_0.samplerstate, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_R_4 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.r;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_G_5 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.g;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_B_6 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.b;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.a;
            UnityTexture2D _Property_9ac06dcb411b45269374b16af55381bd_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c0c279b23b6d467a923d28be4f49b59f_Out_0 = outlineOffest;
            float _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, 1, _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2);
            float _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, -1, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2);
            float4 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4;
            float3 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5;
            float2 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6;
            Unity_Combine_float(_Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2, 0, 0, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6);
            float2 _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float4 _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9ac06dcb411b45269374b16af55381bd_Out_0.tex, _Property_9ac06dcb411b45269374b16af55381bd_Out_0.samplerstate, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_R_4 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.r;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_G_5 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.g;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_B_6 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.b;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.a;
            float _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2;
            Unity_Add_float(_SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7, _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7, _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2);
            UnityTexture2D _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_3cba5715217f4d94a2fec04740212ae8_Out_0 = outlineOffest;
            float _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, -1, _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2);
            float _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, 1, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2);
            float4 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4;
            float3 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5;
            float2 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6;
            Unity_Combine_float(_Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2, 0, 0, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6);
            float2 _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float4 _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.tex, _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.samplerstate, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_R_4 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.r;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_G_5 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.g;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_B_6 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.b;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.a;
            float _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2;
            Unity_Add_float(_Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2, _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7, _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2);
            UnityTexture2D _Property_4638da389d3f4f7187642a1df36cafc4_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_329a15e14a5f437bbe8147e054d43789_Out_0 = outlineOffest;
            float _Multiply_0322358642d34ca4be034be7037fc103_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 1, _Multiply_0322358642d34ca4be034be7037fc103_Out_2);
            float _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 0, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2);
            float4 _Combine_3610726a63324800845304206f3644ab_RGBA_4;
            float3 _Combine_3610726a63324800845304206f3644ab_RGB_5;
            float2 _Combine_3610726a63324800845304206f3644ab_RG_6;
            Unity_Combine_float(_Multiply_0322358642d34ca4be034be7037fc103_Out_2, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2, 0, 0, _Combine_3610726a63324800845304206f3644ab_RGBA_4, _Combine_3610726a63324800845304206f3644ab_RGB_5, _Combine_3610726a63324800845304206f3644ab_RG_6);
            float2 _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_3610726a63324800845304206f3644ab_RG_6, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float4 _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0 = SAMPLE_TEXTURE2D(_Property_4638da389d3f4f7187642a1df36cafc4_Out_0.tex, _Property_4638da389d3f4f7187642a1df36cafc4_Out_0.samplerstate, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_R_4 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.r;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_G_5 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.g;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_B_6 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.b;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.a;
            float _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2;
            Unity_Add_float(_Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2, _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7, _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2);
            UnityTexture2D _Property_9df39bcda2e242f29ad651b884e519a9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_45befcea4fb14766a59ddd103a6956b3_Out_0 = outlineOffest;
            float _Multiply_207e9916a207418090c84761d147d8ad_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 0, _Multiply_207e9916a207418090c84761d147d8ad_Out_2);
            float _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 1, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2);
            float4 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4;
            float3 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5;
            float2 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6;
            Unity_Combine_float(_Multiply_207e9916a207418090c84761d147d8ad_Out_2, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2, 0, 0, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6);
            float2 _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float4 _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9df39bcda2e242f29ad651b884e519a9_Out_0.tex, _Property_9df39bcda2e242f29ad651b884e519a9_Out_0.samplerstate, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float _SampleTexture2D_590aed00e942488597319811e606040b_R_4 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.r;
            float _SampleTexture2D_590aed00e942488597319811e606040b_G_5 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.g;
            float _SampleTexture2D_590aed00e942488597319811e606040b_B_6 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.b;
            float _SampleTexture2D_590aed00e942488597319811e606040b_A_7 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.a;
            float _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2;
            Unity_Add_float(_Add_bfffff96902e4e71aeaebb5d102086e9_Out_2, _SampleTexture2D_590aed00e942488597319811e606040b_A_7, _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2);
            UnityTexture2D _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0 = outlineOffest;
            float _Multiply_4984902a786a419da073164c825444d5_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, -1, _Multiply_4984902a786a419da073164c825444d5_Out_2);
            float _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, 0, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2);
            float4 _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4;
            float3 _Combine_c8db3debe77247e49c877efa92887a88_RGB_5;
            float2 _Combine_c8db3debe77247e49c877efa92887a88_RG_6;
            Unity_Combine_float(_Multiply_4984902a786a419da073164c825444d5_Out_2, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2, 0, 0, _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4, _Combine_c8db3debe77247e49c877efa92887a88_RGB_5, _Combine_c8db3debe77247e49c877efa92887a88_RG_6);
            float2 _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_c8db3debe77247e49c877efa92887a88_RG_6, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float4 _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0 = SAMPLE_TEXTURE2D(_Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.tex, _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.samplerstate, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_R_4 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.r;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_G_5 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.g;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_B_6 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.b;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.a;
            float _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2;
            Unity_Add_float(_Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2, _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7, _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2);
            UnityTexture2D _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_09dbd287d4844fa7a0a8861450959faf_Out_0 = outlineOffest;
            float _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, 0, _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2);
            float _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, -1, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2);
            float4 _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4;
            float3 _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5;
            float2 _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6;
            Unity_Combine_float(_Multiply_6716f420867641aebd0dd231a2eb0144_Out_2, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2, 0, 0, _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4, _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5, _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6);
            float2 _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float4 _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0 = SAMPLE_TEXTURE2D(_Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.tex, _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.samplerstate, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_R_4 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.r;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_G_5 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.g;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_B_6 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.b;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.a;
            float _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2;
            Unity_Add_float(_Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2, _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7, _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2);
            UnityTexture2D _Property_012c711507b645519f73babdd1f63180_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0 = outlineOffest;
            float _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2);
            float _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2);
            float4 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4;
            float3 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5;
            float2 _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6;
            Unity_Combine_float(_Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2, 0, 0, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5, _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6);
            float2 _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float4 _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0 = SAMPLE_TEXTURE2D(_Property_012c711507b645519f73babdd1f63180_Out_0.tex, _Property_012c711507b645519f73babdd1f63180_Out_0.samplerstate, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_R_4 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.r;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_G_5 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.g;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_B_6 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.b;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.a;
            float _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2;
            Unity_Add_float(_Add_ff805e671d494ebfab34a0eeb33682a7_Out_2, _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7, _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2);
            float _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3;
            Unity_Clamp_float(_Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2, 0, 1, _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3);
            float _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2;
            Unity_Subtract_float(_Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3, _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2);
            float _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0 = GlowControl;
            float _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2;
            Unity_Multiply_float(_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2, _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2);
            float _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2;
            Unity_Add_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2, _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2);
            float4 _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0 = IN.uv0;
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_R_1 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[0];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_G_2 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[1];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_B_3 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[2];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_A_4 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[3];
            float _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2;
            Unity_Multiply_float(_Split_e4faf5047a3745dd8484b3c2df1cae11_R_1, 10, _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2);
            float _Remap_b90a61292457452781ce5a0de4613230_Out_3;
            Unity_Remap_float(_Multiply_ee53730afa6346148000cf9afa7374a2_Out_2, float2 (0, 1), float2 (0, 1), _Remap_b90a61292457452781ce5a0de4613230_Out_3);
            float4 _UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0 = IN.uv0;
            float2 _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3;
            Unity_Rotate_Degrees_float((_UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3);
            float _Split_da81384144364fd1b73145399a5a93aa_R_1 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[0];
            float _Split_da81384144364fd1b73145399a5a93aa_G_2 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[1];
            float _Split_da81384144364fd1b73145399a5a93aa_B_3 = 0;
            float _Split_da81384144364fd1b73145399a5a93aa_A_4 = 0;
            float _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2;
            Unity_Multiply_float(_Split_da81384144364fd1b73145399a5a93aa_R_1, 10, _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2);
            float _Remap_421606ae375b41f198468213f05d2cec_Out_3;
            Unity_Remap_float(_Multiply_fc988eefcba94788a083bef41143e4aa_Out_2, float2 (0, 1), float2 (0, 1), _Remap_421606ae375b41f198468213f05d2cec_Out_3);
            float _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2;
            Unity_Minimum_float(_Remap_b90a61292457452781ce5a0de4613230_Out_3, _Remap_421606ae375b41f198468213f05d2cec_Out_3, _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2);
            float4 _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0 = IN.uv0;
            float _Split_c9223221d7574c9481a691cae4eb0097_R_1 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[0];
            float _Split_c9223221d7574c9481a691cae4eb0097_G_2 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[1];
            float _Split_c9223221d7574c9481a691cae4eb0097_B_3 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[2];
            float _Split_c9223221d7574c9481a691cae4eb0097_A_4 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[3];
            float _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2;
            Unity_Multiply_float(_Split_c9223221d7574c9481a691cae4eb0097_G_2, 10, _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2);
            float _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3;
            Unity_Remap_float(_Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2, float2 (0, 1), float2 (0, 1), _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3);
            float4 _UV_3fc62428a61744eda513ee5daa808905_Out_0 = IN.uv0;
            float2 _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3;
            Unity_Rotate_Degrees_float((_UV_3fc62428a61744eda513ee5daa808905_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3);
            float _Split_a037cc6e4b214ea88217c67d2a591114_R_1 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[0];
            float _Split_a037cc6e4b214ea88217c67d2a591114_G_2 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[1];
            float _Split_a037cc6e4b214ea88217c67d2a591114_B_3 = 0;
            float _Split_a037cc6e4b214ea88217c67d2a591114_A_4 = 0;
            float _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2;
            Unity_Multiply_float(_Split_a037cc6e4b214ea88217c67d2a591114_G_2, 10, _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2);
            float _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3;
            Unity_Remap_float(_Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2, float2 (0, 1), float2 (0, 1), _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3);
            float _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2;
            Unity_Minimum_float(_Remap_1388710757cc4cdd8db65720222ae5d9_Out_3, _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2);
            float _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2;
            Unity_Multiply_float(_Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2);
            float _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            Unity_Minimum_float(_Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2, _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2);
            surface.Alpha = _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            surface.AlphaClipThreshold = 0.5;
            return surface;
        }

            // --------------------------------------------------
            // Build Graph Inputs

            VertexDescriptionInputs BuildVertexDescriptionInputs(Attributes input)
        {
            VertexDescriptionInputs output;
            ZERO_INITIALIZE(VertexDescriptionInputs, output);

            output.ObjectSpaceNormal =           input.normalOS;
            output.ObjectSpaceTangent =          input.tangentOS.xyz;
            output.ObjectSpacePosition =         input.positionOS;

            return output;
        }
            SurfaceDescriptionInputs BuildSurfaceDescriptionInputs(Varyings input)
        {
            SurfaceDescriptionInputs output;
            ZERO_INITIALIZE(SurfaceDescriptionInputs, output);





            output.uv0 =                         input.texCoord0;
        #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN output.FaceSign =                    IS_FRONT_VFACE(input.cullFace, true, false);
        #else
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN
        #endif
        #undef BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN

            return output;
        }

            // --------------------------------------------------
            // Main

            #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShaderPass.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/Varyings.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShadowCasterPass.hlsl"

            ENDHLSL
        }
        Pass
        {
            Name "DepthOnly"
            Tags
            {
                "LightMode" = "DepthOnly"
            }

            // Render State
            Cull Back
        Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
        ZTest LEqual
        ZWrite On
        ColorMask 0

            // Debug
            // <None>

            // --------------------------------------------------
            // Pass

            HLSLPROGRAM

            // Pragmas
            #pragma target 2.0
        #pragma only_renderers gles gles3 glcore d3d11
        #pragma multi_compile_instancing
        #pragma vertex vert
        #pragma fragment frag

            // DotsInstancingOptions: <None>
            // HybridV1InjectedBuiltinProperties: <None>

            // Keywords
            // PassKeywords: <None>
            // GraphKeywords: <None>

            // Defines
            #define _SURFACE_TYPE_TRANSPARENT 1
            #define _AlphaClip 1
            #define ATTRIBUTES_NEED_NORMAL
            #define ATTRIBUTES_NEED_TANGENT
            #define ATTRIBUTES_NEED_TEXCOORD0
            #define VARYINGS_NEED_TEXCOORD0
            #define FEATURES_GRAPH_VERTEX
            /* WARNING: $splice Could not find named fragment 'PassInstancing' */
            #define SHADERPASS SHADERPASS_DEPTHONLY
            /* WARNING: $splice Could not find named fragment 'DotsInstancingVars' */

            // Includes
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Texture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/TextureStack.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

            // --------------------------------------------------
            // Structs and Packing

            struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS : NORMAL;
            float4 tangentOS : TANGENT;
            float4 uv0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : INSTANCEID_SEMANTIC;
            #endif
        };
        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float4 texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };
        struct SurfaceDescriptionInputs
        {
            float4 uv0;
        };
        struct VertexDescriptionInputs
        {
            float3 ObjectSpaceNormal;
            float3 ObjectSpaceTangent;
            float3 ObjectSpacePosition;
        };
        struct PackedVaryings
        {
            float4 positionCS : SV_POSITION;
            float4 interp0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };

            PackedVaryings PackVaryings (Varyings input)
        {
            PackedVaryings output;
            output.positionCS = input.positionCS;
            output.interp0.xyzw =  input.texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }
        Varyings UnpackVaryings (PackedVaryings input)
        {
            Varyings output;
            output.positionCS = input.positionCS;
            output.texCoord0 = input.interp0.xyzw;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }

            // --------------------------------------------------
            // Graph

            // Graph Properties
            CBUFFER_START(UnityPerMaterial)
        float4 _MainTex_TexelSize;
        float4 _Color;
        float outlineOffest;
        float GlowFrequency;
        float2 GlowRange;
        float GlowControl;
        float EdgeControl;
        float4 RGBA;
        float Mono;
        CBUFFER_END

        // Object and Global properties
        SAMPLER(SamplerState_Linear_Repeat);
        TEXTURE2D(_MainTex);
        SAMPLER(sampler_MainTex);

            // Graph Functions
            
        void Unity_Multiply_float(float A, float B, out float Out)
        {
            Out = A * B;
        }

        void Unity_Combine_float(float R, float G, float B, float A, out float4 RGBA, out float3 RGB, out float2 RG)
        {
            RGBA = float4(R, G, B, A);
            RGB = float3(R, G, B);
            RG = float2(R, G);
        }

        void Unity_TilingAndOffset_float(float2 UV, float2 Tiling, float2 Offset, out float2 Out)
        {
            Out = UV * Tiling + Offset;
        }

        void Unity_Add_float(float A, float B, out float Out)
        {
            Out = A + B;
        }

        void Unity_Clamp_float(float In, float Min, float Max, out float Out)
        {
            Out = clamp(In, Min, Max);
        }

        void Unity_Subtract_float(float A, float B, out float Out)
        {
            Out = A - B;
        }

        void Unity_Remap_float(float In, float2 InMinMax, float2 OutMinMax, out float Out)
        {
            Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
        }

        void Unity_Rotate_Degrees_float(float2 UV, float2 Center, float Rotation, out float2 Out)
        {
            //rotation matrix
            Rotation = Rotation * (3.1415926f/180.0f);
            UV -= Center;
            float s = sin(Rotation);
            float c = cos(Rotation);

            //center rotation matrix
            float2x2 rMatrix = float2x2(c, -s, s, c);
            rMatrix *= 0.5;
            rMatrix += 0.5;
            rMatrix = rMatrix*2 - 1;

            //multiply the UVs by the rotation matrix
            UV.xy = mul(UV.xy, rMatrix);
            UV += Center;

            Out = UV;
        }

        void Unity_Minimum_float(float A, float B, out float Out)
        {
            Out = min(A, B);
        };

            // Graph Vertex
            struct VertexDescription
        {
            float3 Position;
            float3 Normal;
            float3 Tangent;
        };

        VertexDescription VertexDescriptionFunction(VertexDescriptionInputs IN)
        {
            VertexDescription description = (VertexDescription)0;
            description.Position = IN.ObjectSpacePosition;
            description.Normal = IN.ObjectSpaceNormal;
            description.Tangent = IN.ObjectSpaceTangent;
            return description;
        }

            // Graph Pixel
            struct SurfaceDescription
        {
            float Alpha;
            float AlphaClipThreshold;
        };

        SurfaceDescription SurfaceDescriptionFunction(SurfaceDescriptionInputs IN)
        {
            SurfaceDescription surface = (SurfaceDescription)0;
            UnityTexture2D _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float4 _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0 = SAMPLE_TEXTURE2D(_Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.tex, _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.samplerstate, IN.uv0.xy);
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_R_4 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.r;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_G_5 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.g;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_B_6 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.b;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.a;
            UnityTexture2D _Property_74f03fcb472647d2a59b580228c9d3da_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0 = outlineOffest;
            float _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2);
            float _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2);
            float4 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4;
            float3 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5;
            float2 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6;
            Unity_Combine_float(_Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2, 0, 0, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6);
            float2 _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float4 _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0 = SAMPLE_TEXTURE2D(_Property_74f03fcb472647d2a59b580228c9d3da_Out_0.tex, _Property_74f03fcb472647d2a59b580228c9d3da_Out_0.samplerstate, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_R_4 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.r;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_G_5 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.g;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_B_6 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.b;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.a;
            UnityTexture2D _Property_9ac06dcb411b45269374b16af55381bd_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c0c279b23b6d467a923d28be4f49b59f_Out_0 = outlineOffest;
            float _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, 1, _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2);
            float _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, -1, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2);
            float4 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4;
            float3 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5;
            float2 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6;
            Unity_Combine_float(_Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2, 0, 0, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6);
            float2 _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float4 _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9ac06dcb411b45269374b16af55381bd_Out_0.tex, _Property_9ac06dcb411b45269374b16af55381bd_Out_0.samplerstate, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_R_4 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.r;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_G_5 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.g;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_B_6 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.b;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.a;
            float _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2;
            Unity_Add_float(_SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7, _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7, _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2);
            UnityTexture2D _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_3cba5715217f4d94a2fec04740212ae8_Out_0 = outlineOffest;
            float _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, -1, _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2);
            float _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, 1, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2);
            float4 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4;
            float3 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5;
            float2 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6;
            Unity_Combine_float(_Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2, 0, 0, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6);
            float2 _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float4 _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.tex, _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.samplerstate, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_R_4 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.r;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_G_5 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.g;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_B_6 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.b;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.a;
            float _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2;
            Unity_Add_float(_Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2, _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7, _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2);
            UnityTexture2D _Property_4638da389d3f4f7187642a1df36cafc4_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_329a15e14a5f437bbe8147e054d43789_Out_0 = outlineOffest;
            float _Multiply_0322358642d34ca4be034be7037fc103_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 1, _Multiply_0322358642d34ca4be034be7037fc103_Out_2);
            float _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 0, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2);
            float4 _Combine_3610726a63324800845304206f3644ab_RGBA_4;
            float3 _Combine_3610726a63324800845304206f3644ab_RGB_5;
            float2 _Combine_3610726a63324800845304206f3644ab_RG_6;
            Unity_Combine_float(_Multiply_0322358642d34ca4be034be7037fc103_Out_2, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2, 0, 0, _Combine_3610726a63324800845304206f3644ab_RGBA_4, _Combine_3610726a63324800845304206f3644ab_RGB_5, _Combine_3610726a63324800845304206f3644ab_RG_6);
            float2 _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_3610726a63324800845304206f3644ab_RG_6, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float4 _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0 = SAMPLE_TEXTURE2D(_Property_4638da389d3f4f7187642a1df36cafc4_Out_0.tex, _Property_4638da389d3f4f7187642a1df36cafc4_Out_0.samplerstate, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_R_4 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.r;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_G_5 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.g;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_B_6 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.b;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.a;
            float _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2;
            Unity_Add_float(_Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2, _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7, _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2);
            UnityTexture2D _Property_9df39bcda2e242f29ad651b884e519a9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_45befcea4fb14766a59ddd103a6956b3_Out_0 = outlineOffest;
            float _Multiply_207e9916a207418090c84761d147d8ad_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 0, _Multiply_207e9916a207418090c84761d147d8ad_Out_2);
            float _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 1, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2);
            float4 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4;
            float3 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5;
            float2 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6;
            Unity_Combine_float(_Multiply_207e9916a207418090c84761d147d8ad_Out_2, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2, 0, 0, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6);
            float2 _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float4 _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9df39bcda2e242f29ad651b884e519a9_Out_0.tex, _Property_9df39bcda2e242f29ad651b884e519a9_Out_0.samplerstate, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float _SampleTexture2D_590aed00e942488597319811e606040b_R_4 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.r;
            float _SampleTexture2D_590aed00e942488597319811e606040b_G_5 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.g;
            float _SampleTexture2D_590aed00e942488597319811e606040b_B_6 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.b;
            float _SampleTexture2D_590aed00e942488597319811e606040b_A_7 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.a;
            float _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2;
            Unity_Add_float(_Add_bfffff96902e4e71aeaebb5d102086e9_Out_2, _SampleTexture2D_590aed00e942488597319811e606040b_A_7, _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2);
            UnityTexture2D _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0 = outlineOffest;
            float _Multiply_4984902a786a419da073164c825444d5_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, -1, _Multiply_4984902a786a419da073164c825444d5_Out_2);
            float _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, 0, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2);
            float4 _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4;
            float3 _Combine_c8db3debe77247e49c877efa92887a88_RGB_5;
            float2 _Combine_c8db3debe77247e49c877efa92887a88_RG_6;
            Unity_Combine_float(_Multiply_4984902a786a419da073164c825444d5_Out_2, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2, 0, 0, _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4, _Combine_c8db3debe77247e49c877efa92887a88_RGB_5, _Combine_c8db3debe77247e49c877efa92887a88_RG_6);
            float2 _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_c8db3debe77247e49c877efa92887a88_RG_6, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float4 _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0 = SAMPLE_TEXTURE2D(_Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.tex, _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.samplerstate, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_R_4 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.r;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_G_5 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.g;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_B_6 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.b;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.a;
            float _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2;
            Unity_Add_float(_Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2, _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7, _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2);
            UnityTexture2D _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_09dbd287d4844fa7a0a8861450959faf_Out_0 = outlineOffest;
            float _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, 0, _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2);
            float _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, -1, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2);
            float4 _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4;
            float3 _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5;
            float2 _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6;
            Unity_Combine_float(_Multiply_6716f420867641aebd0dd231a2eb0144_Out_2, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2, 0, 0, _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4, _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5, _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6);
            float2 _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float4 _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0 = SAMPLE_TEXTURE2D(_Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.tex, _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.samplerstate, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_R_4 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.r;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_G_5 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.g;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_B_6 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.b;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.a;
            float _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2;
            Unity_Add_float(_Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2, _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7, _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2);
            UnityTexture2D _Property_012c711507b645519f73babdd1f63180_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0 = outlineOffest;
            float _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2);
            float _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2);
            float4 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4;
            float3 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5;
            float2 _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6;
            Unity_Combine_float(_Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2, 0, 0, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5, _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6);
            float2 _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float4 _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0 = SAMPLE_TEXTURE2D(_Property_012c711507b645519f73babdd1f63180_Out_0.tex, _Property_012c711507b645519f73babdd1f63180_Out_0.samplerstate, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_R_4 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.r;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_G_5 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.g;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_B_6 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.b;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.a;
            float _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2;
            Unity_Add_float(_Add_ff805e671d494ebfab34a0eeb33682a7_Out_2, _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7, _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2);
            float _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3;
            Unity_Clamp_float(_Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2, 0, 1, _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3);
            float _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2;
            Unity_Subtract_float(_Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3, _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2);
            float _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0 = GlowControl;
            float _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2;
            Unity_Multiply_float(_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2, _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2);
            float _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2;
            Unity_Add_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2, _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2);
            float4 _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0 = IN.uv0;
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_R_1 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[0];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_G_2 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[1];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_B_3 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[2];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_A_4 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[3];
            float _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2;
            Unity_Multiply_float(_Split_e4faf5047a3745dd8484b3c2df1cae11_R_1, 10, _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2);
            float _Remap_b90a61292457452781ce5a0de4613230_Out_3;
            Unity_Remap_float(_Multiply_ee53730afa6346148000cf9afa7374a2_Out_2, float2 (0, 1), float2 (0, 1), _Remap_b90a61292457452781ce5a0de4613230_Out_3);
            float4 _UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0 = IN.uv0;
            float2 _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3;
            Unity_Rotate_Degrees_float((_UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3);
            float _Split_da81384144364fd1b73145399a5a93aa_R_1 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[0];
            float _Split_da81384144364fd1b73145399a5a93aa_G_2 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[1];
            float _Split_da81384144364fd1b73145399a5a93aa_B_3 = 0;
            float _Split_da81384144364fd1b73145399a5a93aa_A_4 = 0;
            float _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2;
            Unity_Multiply_float(_Split_da81384144364fd1b73145399a5a93aa_R_1, 10, _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2);
            float _Remap_421606ae375b41f198468213f05d2cec_Out_3;
            Unity_Remap_float(_Multiply_fc988eefcba94788a083bef41143e4aa_Out_2, float2 (0, 1), float2 (0, 1), _Remap_421606ae375b41f198468213f05d2cec_Out_3);
            float _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2;
            Unity_Minimum_float(_Remap_b90a61292457452781ce5a0de4613230_Out_3, _Remap_421606ae375b41f198468213f05d2cec_Out_3, _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2);
            float4 _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0 = IN.uv0;
            float _Split_c9223221d7574c9481a691cae4eb0097_R_1 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[0];
            float _Split_c9223221d7574c9481a691cae4eb0097_G_2 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[1];
            float _Split_c9223221d7574c9481a691cae4eb0097_B_3 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[2];
            float _Split_c9223221d7574c9481a691cae4eb0097_A_4 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[3];
            float _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2;
            Unity_Multiply_float(_Split_c9223221d7574c9481a691cae4eb0097_G_2, 10, _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2);
            float _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3;
            Unity_Remap_float(_Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2, float2 (0, 1), float2 (0, 1), _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3);
            float4 _UV_3fc62428a61744eda513ee5daa808905_Out_0 = IN.uv0;
            float2 _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3;
            Unity_Rotate_Degrees_float((_UV_3fc62428a61744eda513ee5daa808905_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3);
            float _Split_a037cc6e4b214ea88217c67d2a591114_R_1 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[0];
            float _Split_a037cc6e4b214ea88217c67d2a591114_G_2 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[1];
            float _Split_a037cc6e4b214ea88217c67d2a591114_B_3 = 0;
            float _Split_a037cc6e4b214ea88217c67d2a591114_A_4 = 0;
            float _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2;
            Unity_Multiply_float(_Split_a037cc6e4b214ea88217c67d2a591114_G_2, 10, _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2);
            float _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3;
            Unity_Remap_float(_Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2, float2 (0, 1), float2 (0, 1), _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3);
            float _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2;
            Unity_Minimum_float(_Remap_1388710757cc4cdd8db65720222ae5d9_Out_3, _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2);
            float _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2;
            Unity_Multiply_float(_Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2);
            float _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            Unity_Minimum_float(_Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2, _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2);
            surface.Alpha = _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            surface.AlphaClipThreshold = 0.5;
            return surface;
        }

            // --------------------------------------------------
            // Build Graph Inputs

            VertexDescriptionInputs BuildVertexDescriptionInputs(Attributes input)
        {
            VertexDescriptionInputs output;
            ZERO_INITIALIZE(VertexDescriptionInputs, output);

            output.ObjectSpaceNormal =           input.normalOS;
            output.ObjectSpaceTangent =          input.tangentOS.xyz;
            output.ObjectSpacePosition =         input.positionOS;

            return output;
        }
            SurfaceDescriptionInputs BuildSurfaceDescriptionInputs(Varyings input)
        {
            SurfaceDescriptionInputs output;
            ZERO_INITIALIZE(SurfaceDescriptionInputs, output);





            output.uv0 =                         input.texCoord0;
        #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN output.FaceSign =                    IS_FRONT_VFACE(input.cullFace, true, false);
        #else
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN
        #endif
        #undef BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN

            return output;
        }

            // --------------------------------------------------
            // Main

            #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShaderPass.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/Varyings.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/DepthOnlyPass.hlsl"

            ENDHLSL
        }
    }
    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "UniversalMaterialType" = "Unlit"
            "Queue"="Transparent"
        }
        Pass
        {
            Name "Pass"
            Tags
            {
                // LightMode: <None>
            }

            // Render State
            Cull Back
        Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
        ZTest LEqual
        ZWrite Off

            // Debug
            // <None>

            // --------------------------------------------------
            // Pass

            HLSLPROGRAM

            // Pragmas
            #pragma target 4.5
        #pragma exclude_renderers gles gles3 glcore
        #pragma multi_compile_instancing
        #pragma multi_compile_fog
        #pragma multi_compile _ DOTS_INSTANCING_ON
        #pragma vertex vert
        #pragma fragment frag

            // DotsInstancingOptions: <None>
            // HybridV1InjectedBuiltinProperties: <None>

            // Keywords
            #pragma multi_compile _ LIGHTMAP_ON
        #pragma multi_compile _ DIRLIGHTMAP_COMBINED
        #pragma shader_feature _ _SAMPLE_GI
            // GraphKeywords: <None>

            // Defines
            #define _SURFACE_TYPE_TRANSPARENT 1
            #define _AlphaClip 1
            #define ATTRIBUTES_NEED_NORMAL
            #define ATTRIBUTES_NEED_TANGENT
            #define ATTRIBUTES_NEED_TEXCOORD0
            #define VARYINGS_NEED_TEXCOORD0
            #define FEATURES_GRAPH_VERTEX
            /* WARNING: $splice Could not find named fragment 'PassInstancing' */
            #define SHADERPASS SHADERPASS_UNLIT
            /* WARNING: $splice Could not find named fragment 'DotsInstancingVars' */

            // Includes
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Texture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/TextureStack.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

            // --------------------------------------------------
            // Structs and Packing

            struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS : NORMAL;
            float4 tangentOS : TANGENT;
            float4 uv0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : INSTANCEID_SEMANTIC;
            #endif
        };
        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float4 texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };
        struct SurfaceDescriptionInputs
        {
            float4 uv0;
        };
        struct VertexDescriptionInputs
        {
            float3 ObjectSpaceNormal;
            float3 ObjectSpaceTangent;
            float3 ObjectSpacePosition;
        };
        struct PackedVaryings
        {
            float4 positionCS : SV_POSITION;
            float4 interp0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };

            PackedVaryings PackVaryings (Varyings input)
        {
            PackedVaryings output;
            output.positionCS = input.positionCS;
            output.interp0.xyzw =  input.texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }
        Varyings UnpackVaryings (PackedVaryings input)
        {
            Varyings output;
            output.positionCS = input.positionCS;
            output.texCoord0 = input.interp0.xyzw;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }

            // --------------------------------------------------
            // Graph

            // Graph Properties
            CBUFFER_START(UnityPerMaterial)
        float4 _MainTex_TexelSize;
        float4 _Color;
        float outlineOffest;
        float GlowFrequency;
        float2 GlowRange;
        float GlowControl;
        float EdgeControl;
        float4 RGBA;
        float Mono;
        CBUFFER_END

        // Object and Global properties
        SAMPLER(SamplerState_Linear_Repeat);
        TEXTURE2D(_MainTex);
        SAMPLER(sampler_MainTex);

            // Graph Functions
            
        void Unity_DotProduct_float4(float4 A, float4 B, out float Out)
        {
            Out = dot(A, B);
        }

        void Unity_Multiply_float(float A, float B, out float Out)
        {
            Out = A * B;
        }

        void Unity_Multiply_float(float4 A, float4 B, out float4 Out)
        {
            Out = A * B;
        }

        void Unity_Add_float3(float3 A, float3 B, out float3 Out)
        {
            Out = A + B;
        }

        void Unity_Combine_float(float R, float G, float B, float A, out float4 RGBA, out float3 RGB, out float2 RG)
        {
            RGBA = float4(R, G, B, A);
            RGB = float3(R, G, B);
            RG = float2(R, G);
        }

        void Unity_TilingAndOffset_float(float2 UV, float2 Tiling, float2 Offset, out float2 Out)
        {
            Out = UV * Tiling + Offset;
        }

        void Unity_Add_float(float A, float B, out float Out)
        {
            Out = A + B;
        }

        void Unity_Clamp_float(float In, float Min, float Max, out float Out)
        {
            Out = clamp(In, Min, Max);
        }

        void Unity_Subtract_float(float A, float B, out float Out)
        {
            Out = A - B;
        }

        void Unity_Remap_float(float In, float2 InMinMax, float2 OutMinMax, out float Out)
        {
            Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
        }

        void Unity_Rotate_Degrees_float(float2 UV, float2 Center, float Rotation, out float2 Out)
        {
            //rotation matrix
            Rotation = Rotation * (3.1415926f/180.0f);
            UV -= Center;
            float s = sin(Rotation);
            float c = cos(Rotation);

            //center rotation matrix
            float2x2 rMatrix = float2x2(c, -s, s, c);
            rMatrix *= 0.5;
            rMatrix += 0.5;
            rMatrix = rMatrix*2 - 1;

            //multiply the UVs by the rotation matrix
            UV.xy = mul(UV.xy, rMatrix);
            UV += Center;

            Out = UV;
        }

        void Unity_Minimum_float(float A, float B, out float Out)
        {
            Out = min(A, B);
        };

            // Graph Vertex
            struct VertexDescription
        {
            float3 Position;
            float3 Normal;
            float3 Tangent;
        };

        VertexDescription VertexDescriptionFunction(VertexDescriptionInputs IN)
        {
            VertexDescription description = (VertexDescription)0;
            description.Position = IN.ObjectSpacePosition;
            description.Normal = IN.ObjectSpaceNormal;
            description.Tangent = IN.ObjectSpaceTangent;
            return description;
        }

            // Graph Pixel
            struct SurfaceDescription
        {
            float3 BaseColor;
            float Alpha;
            float AlphaClipThreshold;
        };

        SurfaceDescription SurfaceDescriptionFunction(SurfaceDescriptionInputs IN)
        {
            SurfaceDescription surface = (SurfaceDescription)0;
            UnityTexture2D _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float4 _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0 = SAMPLE_TEXTURE2D(_Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.tex, _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.samplerstate, IN.uv0.xy);
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_R_4 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.r;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_G_5 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.g;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_B_6 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.b;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.a;
            float _DotProduct_c13f317210be4433a971e33406d8b7cd_Out_2;
            Unity_DotProduct_float4(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0, float4(0.299, 0.587, 0.114, 0), _DotProduct_c13f317210be4433a971e33406d8b7cd_Out_2);
            float _Property_1beddd7212ee42dba29de520dfa38e78_Out_0 = Mono;
            float _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2;
            Unity_Multiply_float(_DotProduct_c13f317210be4433a971e33406d8b7cd_Out_2, _Property_1beddd7212ee42dba29de520dfa38e78_Out_0, _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2);
            float3 _Vector3_f970e30adc314ca39f6f997db146df5e_Out_0 = float3(_Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2, _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2, _Multiply_18950b8f6eb94a5e81e427073cb33199_Out_2);
            float4 _Property_bd131a3d764d4a399c48b1d9e28c2a71_Out_0 = RGBA;
            float4 _Multiply_400ee0bb75104249a0a4e827ab8752cd_Out_2;
            Unity_Multiply_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0, _Property_bd131a3d764d4a399c48b1d9e28c2a71_Out_0, _Multiply_400ee0bb75104249a0a4e827ab8752cd_Out_2);
            float3 _Add_42538c6a296840a99a703976b366ddfb_Out_2;
            Unity_Add_float3(_Vector3_f970e30adc314ca39f6f997db146df5e_Out_0, (_Multiply_400ee0bb75104249a0a4e827ab8752cd_Out_2.xyz), _Add_42538c6a296840a99a703976b366ddfb_Out_2);
            UnityTexture2D _Property_74f03fcb472647d2a59b580228c9d3da_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0 = outlineOffest;
            float _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2);
            float _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2);
            float4 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4;
            float3 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5;
            float2 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6;
            Unity_Combine_float(_Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2, 0, 0, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6);
            float2 _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float4 _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0 = SAMPLE_TEXTURE2D(_Property_74f03fcb472647d2a59b580228c9d3da_Out_0.tex, _Property_74f03fcb472647d2a59b580228c9d3da_Out_0.samplerstate, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_R_4 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.r;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_G_5 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.g;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_B_6 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.b;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.a;
            UnityTexture2D _Property_9ac06dcb411b45269374b16af55381bd_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c0c279b23b6d467a923d28be4f49b59f_Out_0 = outlineOffest;
            float _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, 1, _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2);
            float _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, -1, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2);
            float4 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4;
            float3 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5;
            float2 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6;
            Unity_Combine_float(_Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2, 0, 0, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6);
            float2 _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float4 _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9ac06dcb411b45269374b16af55381bd_Out_0.tex, _Property_9ac06dcb411b45269374b16af55381bd_Out_0.samplerstate, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_R_4 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.r;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_G_5 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.g;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_B_6 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.b;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.a;
            float _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2;
            Unity_Add_float(_SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7, _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7, _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2);
            UnityTexture2D _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_3cba5715217f4d94a2fec04740212ae8_Out_0 = outlineOffest;
            float _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, -1, _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2);
            float _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, 1, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2);
            float4 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4;
            float3 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5;
            float2 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6;
            Unity_Combine_float(_Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2, 0, 0, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6);
            float2 _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float4 _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.tex, _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.samplerstate, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_R_4 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.r;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_G_5 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.g;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_B_6 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.b;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.a;
            float _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2;
            Unity_Add_float(_Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2, _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7, _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2);
            UnityTexture2D _Property_4638da389d3f4f7187642a1df36cafc4_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_329a15e14a5f437bbe8147e054d43789_Out_0 = outlineOffest;
            float _Multiply_0322358642d34ca4be034be7037fc103_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 1, _Multiply_0322358642d34ca4be034be7037fc103_Out_2);
            float _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 0, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2);
            float4 _Combine_3610726a63324800845304206f3644ab_RGBA_4;
            float3 _Combine_3610726a63324800845304206f3644ab_RGB_5;
            float2 _Combine_3610726a63324800845304206f3644ab_RG_6;
            Unity_Combine_float(_Multiply_0322358642d34ca4be034be7037fc103_Out_2, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2, 0, 0, _Combine_3610726a63324800845304206f3644ab_RGBA_4, _Combine_3610726a63324800845304206f3644ab_RGB_5, _Combine_3610726a63324800845304206f3644ab_RG_6);
            float2 _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_3610726a63324800845304206f3644ab_RG_6, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float4 _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0 = SAMPLE_TEXTURE2D(_Property_4638da389d3f4f7187642a1df36cafc4_Out_0.tex, _Property_4638da389d3f4f7187642a1df36cafc4_Out_0.samplerstate, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_R_4 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.r;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_G_5 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.g;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_B_6 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.b;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.a;
            float _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2;
            Unity_Add_float(_Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2, _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7, _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2);
            UnityTexture2D _Property_9df39bcda2e242f29ad651b884e519a9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_45befcea4fb14766a59ddd103a6956b3_Out_0 = outlineOffest;
            float _Multiply_207e9916a207418090c84761d147d8ad_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 0, _Multiply_207e9916a207418090c84761d147d8ad_Out_2);
            float _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 1, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2);
            float4 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4;
            float3 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5;
            float2 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6;
            Unity_Combine_float(_Multiply_207e9916a207418090c84761d147d8ad_Out_2, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2, 0, 0, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6);
            float2 _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float4 _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9df39bcda2e242f29ad651b884e519a9_Out_0.tex, _Property_9df39bcda2e242f29ad651b884e519a9_Out_0.samplerstate, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float _SampleTexture2D_590aed00e942488597319811e606040b_R_4 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.r;
            float _SampleTexture2D_590aed00e942488597319811e606040b_G_5 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.g;
            float _SampleTexture2D_590aed00e942488597319811e606040b_B_6 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.b;
            float _SampleTexture2D_590aed00e942488597319811e606040b_A_7 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.a;
            float _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2;
            Unity_Add_float(_Add_bfffff96902e4e71aeaebb5d102086e9_Out_2, _SampleTexture2D_590aed00e942488597319811e606040b_A_7, _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2);
            UnityTexture2D _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0 = outlineOffest;
            float _Multiply_4984902a786a419da073164c825444d5_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, -1, _Multiply_4984902a786a419da073164c825444d5_Out_2);
            float _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, 0, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2);
            float4 _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4;
            float3 _Combine_c8db3debe77247e49c877efa92887a88_RGB_5;
            float2 _Combine_c8db3debe77247e49c877efa92887a88_RG_6;
            Unity_Combine_float(_Multiply_4984902a786a419da073164c825444d5_Out_2, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2, 0, 0, _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4, _Combine_c8db3debe77247e49c877efa92887a88_RGB_5, _Combine_c8db3debe77247e49c877efa92887a88_RG_6);
            float2 _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_c8db3debe77247e49c877efa92887a88_RG_6, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float4 _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0 = SAMPLE_TEXTURE2D(_Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.tex, _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.samplerstate, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_R_4 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.r;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_G_5 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.g;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_B_6 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.b;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.a;
            float _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2;
            Unity_Add_float(_Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2, _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7, _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2);
            UnityTexture2D _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_09dbd287d4844fa7a0a8861450959faf_Out_0 = outlineOffest;
            float _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, 0, _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2);
            float _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, -1, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2);
            float4 _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4;
            float3 _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5;
            float2 _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6;
            Unity_Combine_float(_Multiply_6716f420867641aebd0dd231a2eb0144_Out_2, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2, 0, 0, _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4, _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5, _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6);
            float2 _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float4 _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0 = SAMPLE_TEXTURE2D(_Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.tex, _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.samplerstate, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_R_4 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.r;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_G_5 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.g;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_B_6 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.b;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.a;
            float _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2;
            Unity_Add_float(_Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2, _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7, _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2);
            UnityTexture2D _Property_012c711507b645519f73babdd1f63180_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0 = outlineOffest;
            float _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2);
            float _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2);
            float4 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4;
            float3 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5;
            float2 _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6;
            Unity_Combine_float(_Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2, 0, 0, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5, _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6);
            float2 _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float4 _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0 = SAMPLE_TEXTURE2D(_Property_012c711507b645519f73babdd1f63180_Out_0.tex, _Property_012c711507b645519f73babdd1f63180_Out_0.samplerstate, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_R_4 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.r;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_G_5 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.g;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_B_6 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.b;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.a;
            float _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2;
            Unity_Add_float(_Add_ff805e671d494ebfab34a0eeb33682a7_Out_2, _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7, _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2);
            float _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3;
            Unity_Clamp_float(_Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2, 0, 1, _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3);
            float _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2;
            Unity_Subtract_float(_Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3, _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2);
            float4 _Property_18135612bda74a989de60b55ada14671_Out_0 = IsGammaSpace() ? LinearToSRGB(_Color) : _Color;
            float4 _Multiply_9294d125dff442ccab040f84bf967c38_Out_2;
            Unity_Multiply_float((_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2.xxxx), _Property_18135612bda74a989de60b55ada14671_Out_0, _Multiply_9294d125dff442ccab040f84bf967c38_Out_2);
            float3 _Add_9007fab011814dbcb8fd5c1be2e9aff0_Out_2;
            Unity_Add_float3(_Add_42538c6a296840a99a703976b366ddfb_Out_2, (_Multiply_9294d125dff442ccab040f84bf967c38_Out_2.xyz), _Add_9007fab011814dbcb8fd5c1be2e9aff0_Out_2);
            float _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0 = GlowControl;
            float _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2;
            Unity_Multiply_float(_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2, _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2);
            float _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2;
            Unity_Add_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2, _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2);
            float4 _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0 = IN.uv0;
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_R_1 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[0];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_G_2 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[1];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_B_3 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[2];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_A_4 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[3];
            float _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2;
            Unity_Multiply_float(_Split_e4faf5047a3745dd8484b3c2df1cae11_R_1, 10, _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2);
            float _Remap_b90a61292457452781ce5a0de4613230_Out_3;
            Unity_Remap_float(_Multiply_ee53730afa6346148000cf9afa7374a2_Out_2, float2 (0, 1), float2 (0, 1), _Remap_b90a61292457452781ce5a0de4613230_Out_3);
            float4 _UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0 = IN.uv0;
            float2 _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3;
            Unity_Rotate_Degrees_float((_UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3);
            float _Split_da81384144364fd1b73145399a5a93aa_R_1 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[0];
            float _Split_da81384144364fd1b73145399a5a93aa_G_2 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[1];
            float _Split_da81384144364fd1b73145399a5a93aa_B_3 = 0;
            float _Split_da81384144364fd1b73145399a5a93aa_A_4 = 0;
            float _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2;
            Unity_Multiply_float(_Split_da81384144364fd1b73145399a5a93aa_R_1, 10, _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2);
            float _Remap_421606ae375b41f198468213f05d2cec_Out_3;
            Unity_Remap_float(_Multiply_fc988eefcba94788a083bef41143e4aa_Out_2, float2 (0, 1), float2 (0, 1), _Remap_421606ae375b41f198468213f05d2cec_Out_3);
            float _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2;
            Unity_Minimum_float(_Remap_b90a61292457452781ce5a0de4613230_Out_3, _Remap_421606ae375b41f198468213f05d2cec_Out_3, _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2);
            float4 _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0 = IN.uv0;
            float _Split_c9223221d7574c9481a691cae4eb0097_R_1 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[0];
            float _Split_c9223221d7574c9481a691cae4eb0097_G_2 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[1];
            float _Split_c9223221d7574c9481a691cae4eb0097_B_3 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[2];
            float _Split_c9223221d7574c9481a691cae4eb0097_A_4 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[3];
            float _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2;
            Unity_Multiply_float(_Split_c9223221d7574c9481a691cae4eb0097_G_2, 10, _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2);
            float _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3;
            Unity_Remap_float(_Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2, float2 (0, 1), float2 (0, 1), _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3);
            float4 _UV_3fc62428a61744eda513ee5daa808905_Out_0 = IN.uv0;
            float2 _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3;
            Unity_Rotate_Degrees_float((_UV_3fc62428a61744eda513ee5daa808905_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3);
            float _Split_a037cc6e4b214ea88217c67d2a591114_R_1 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[0];
            float _Split_a037cc6e4b214ea88217c67d2a591114_G_2 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[1];
            float _Split_a037cc6e4b214ea88217c67d2a591114_B_3 = 0;
            float _Split_a037cc6e4b214ea88217c67d2a591114_A_4 = 0;
            float _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2;
            Unity_Multiply_float(_Split_a037cc6e4b214ea88217c67d2a591114_G_2, 10, _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2);
            float _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3;
            Unity_Remap_float(_Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2, float2 (0, 1), float2 (0, 1), _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3);
            float _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2;
            Unity_Minimum_float(_Remap_1388710757cc4cdd8db65720222ae5d9_Out_3, _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2);
            float _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2;
            Unity_Multiply_float(_Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2);
            float _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            Unity_Minimum_float(_Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2, _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2);
            surface.BaseColor = _Add_9007fab011814dbcb8fd5c1be2e9aff0_Out_2;
            surface.Alpha = _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            surface.AlphaClipThreshold = 0.5;
            return surface;
        }

            // --------------------------------------------------
            // Build Graph Inputs

            VertexDescriptionInputs BuildVertexDescriptionInputs(Attributes input)
        {
            VertexDescriptionInputs output;
            ZERO_INITIALIZE(VertexDescriptionInputs, output);

            output.ObjectSpaceNormal =           input.normalOS;
            output.ObjectSpaceTangent =          input.tangentOS.xyz;
            output.ObjectSpacePosition =         input.positionOS;

            return output;
        }
            SurfaceDescriptionInputs BuildSurfaceDescriptionInputs(Varyings input)
        {
            SurfaceDescriptionInputs output;
            ZERO_INITIALIZE(SurfaceDescriptionInputs, output);





            output.uv0 =                         input.texCoord0;
        #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN output.FaceSign =                    IS_FRONT_VFACE(input.cullFace, true, false);
        #else
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN
        #endif
        #undef BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN

            return output;
        }

            // --------------------------------------------------
            // Main

            #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShaderPass.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/Varyings.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/UnlitPass.hlsl"

            ENDHLSL
        }
        Pass
        {
            Name "ShadowCaster"
            Tags
            {
                "LightMode" = "ShadowCaster"
            }

            // Render State
            Cull Back
        Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
        ZTest LEqual
        ZWrite On
        ColorMask 0

            // Debug
            // <None>

            // --------------------------------------------------
            // Pass

            HLSLPROGRAM

            // Pragmas
            #pragma target 4.5
        #pragma exclude_renderers gles gles3 glcore
        #pragma multi_compile_instancing
        #pragma multi_compile _ DOTS_INSTANCING_ON
        #pragma vertex vert
        #pragma fragment frag

            // DotsInstancingOptions: <None>
            // HybridV1InjectedBuiltinProperties: <None>

            // Keywords
            #pragma multi_compile _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            // GraphKeywords: <None>

            // Defines
            #define _SURFACE_TYPE_TRANSPARENT 1
            #define _AlphaClip 1
            #define ATTRIBUTES_NEED_NORMAL
            #define ATTRIBUTES_NEED_TANGENT
            #define ATTRIBUTES_NEED_TEXCOORD0
            #define VARYINGS_NEED_TEXCOORD0
            #define FEATURES_GRAPH_VERTEX
            /* WARNING: $splice Could not find named fragment 'PassInstancing' */
            #define SHADERPASS SHADERPASS_SHADOWCASTER
            /* WARNING: $splice Could not find named fragment 'DotsInstancingVars' */

            // Includes
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Texture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/TextureStack.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

            // --------------------------------------------------
            // Structs and Packing

            struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS : NORMAL;
            float4 tangentOS : TANGENT;
            float4 uv0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : INSTANCEID_SEMANTIC;
            #endif
        };
        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float4 texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };
        struct SurfaceDescriptionInputs
        {
            float4 uv0;
        };
        struct VertexDescriptionInputs
        {
            float3 ObjectSpaceNormal;
            float3 ObjectSpaceTangent;
            float3 ObjectSpacePosition;
        };
        struct PackedVaryings
        {
            float4 positionCS : SV_POSITION;
            float4 interp0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };

            PackedVaryings PackVaryings (Varyings input)
        {
            PackedVaryings output;
            output.positionCS = input.positionCS;
            output.interp0.xyzw =  input.texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }
        Varyings UnpackVaryings (PackedVaryings input)
        {
            Varyings output;
            output.positionCS = input.positionCS;
            output.texCoord0 = input.interp0.xyzw;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }

            // --------------------------------------------------
            // Graph

            // Graph Properties
            CBUFFER_START(UnityPerMaterial)
        float4 _MainTex_TexelSize;
        float4 _Color;
        float outlineOffest;
        float GlowFrequency;
        float2 GlowRange;
        float GlowControl;
        float EdgeControl;
        float4 RGBA;
        float Mono;
        CBUFFER_END

        // Object and Global properties
        SAMPLER(SamplerState_Linear_Repeat);
        TEXTURE2D(_MainTex);
        SAMPLER(sampler_MainTex);

            // Graph Functions
            
        void Unity_Multiply_float(float A, float B, out float Out)
        {
            Out = A * B;
        }

        void Unity_Combine_float(float R, float G, float B, float A, out float4 RGBA, out float3 RGB, out float2 RG)
        {
            RGBA = float4(R, G, B, A);
            RGB = float3(R, G, B);
            RG = float2(R, G);
        }

        void Unity_TilingAndOffset_float(float2 UV, float2 Tiling, float2 Offset, out float2 Out)
        {
            Out = UV * Tiling + Offset;
        }

        void Unity_Add_float(float A, float B, out float Out)
        {
            Out = A + B;
        }

        void Unity_Clamp_float(float In, float Min, float Max, out float Out)
        {
            Out = clamp(In, Min, Max);
        }

        void Unity_Subtract_float(float A, float B, out float Out)
        {
            Out = A - B;
        }

        void Unity_Remap_float(float In, float2 InMinMax, float2 OutMinMax, out float Out)
        {
            Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
        }

        void Unity_Rotate_Degrees_float(float2 UV, float2 Center, float Rotation, out float2 Out)
        {
            //rotation matrix
            Rotation = Rotation * (3.1415926f/180.0f);
            UV -= Center;
            float s = sin(Rotation);
            float c = cos(Rotation);

            //center rotation matrix
            float2x2 rMatrix = float2x2(c, -s, s, c);
            rMatrix *= 0.5;
            rMatrix += 0.5;
            rMatrix = rMatrix*2 - 1;

            //multiply the UVs by the rotation matrix
            UV.xy = mul(UV.xy, rMatrix);
            UV += Center;

            Out = UV;
        }

        void Unity_Minimum_float(float A, float B, out float Out)
        {
            Out = min(A, B);
        };

            // Graph Vertex
            struct VertexDescription
        {
            float3 Position;
            float3 Normal;
            float3 Tangent;
        };

        VertexDescription VertexDescriptionFunction(VertexDescriptionInputs IN)
        {
            VertexDescription description = (VertexDescription)0;
            description.Position = IN.ObjectSpacePosition;
            description.Normal = IN.ObjectSpaceNormal;
            description.Tangent = IN.ObjectSpaceTangent;
            return description;
        }

            // Graph Pixel
            struct SurfaceDescription
        {
            float Alpha;
            float AlphaClipThreshold;
        };

        SurfaceDescription SurfaceDescriptionFunction(SurfaceDescriptionInputs IN)
        {
            SurfaceDescription surface = (SurfaceDescription)0;
            UnityTexture2D _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float4 _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0 = SAMPLE_TEXTURE2D(_Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.tex, _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.samplerstate, IN.uv0.xy);
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_R_4 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.r;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_G_5 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.g;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_B_6 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.b;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.a;
            UnityTexture2D _Property_74f03fcb472647d2a59b580228c9d3da_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0 = outlineOffest;
            float _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2);
            float _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2);
            float4 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4;
            float3 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5;
            float2 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6;
            Unity_Combine_float(_Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2, 0, 0, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6);
            float2 _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float4 _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0 = SAMPLE_TEXTURE2D(_Property_74f03fcb472647d2a59b580228c9d3da_Out_0.tex, _Property_74f03fcb472647d2a59b580228c9d3da_Out_0.samplerstate, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_R_4 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.r;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_G_5 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.g;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_B_6 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.b;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.a;
            UnityTexture2D _Property_9ac06dcb411b45269374b16af55381bd_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c0c279b23b6d467a923d28be4f49b59f_Out_0 = outlineOffest;
            float _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, 1, _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2);
            float _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, -1, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2);
            float4 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4;
            float3 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5;
            float2 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6;
            Unity_Combine_float(_Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2, 0, 0, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6);
            float2 _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float4 _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9ac06dcb411b45269374b16af55381bd_Out_0.tex, _Property_9ac06dcb411b45269374b16af55381bd_Out_0.samplerstate, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_R_4 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.r;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_G_5 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.g;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_B_6 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.b;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.a;
            float _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2;
            Unity_Add_float(_SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7, _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7, _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2);
            UnityTexture2D _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_3cba5715217f4d94a2fec04740212ae8_Out_0 = outlineOffest;
            float _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, -1, _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2);
            float _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, 1, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2);
            float4 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4;
            float3 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5;
            float2 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6;
            Unity_Combine_float(_Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2, 0, 0, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6);
            float2 _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float4 _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.tex, _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.samplerstate, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_R_4 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.r;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_G_5 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.g;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_B_6 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.b;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.a;
            float _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2;
            Unity_Add_float(_Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2, _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7, _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2);
            UnityTexture2D _Property_4638da389d3f4f7187642a1df36cafc4_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_329a15e14a5f437bbe8147e054d43789_Out_0 = outlineOffest;
            float _Multiply_0322358642d34ca4be034be7037fc103_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 1, _Multiply_0322358642d34ca4be034be7037fc103_Out_2);
            float _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 0, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2);
            float4 _Combine_3610726a63324800845304206f3644ab_RGBA_4;
            float3 _Combine_3610726a63324800845304206f3644ab_RGB_5;
            float2 _Combine_3610726a63324800845304206f3644ab_RG_6;
            Unity_Combine_float(_Multiply_0322358642d34ca4be034be7037fc103_Out_2, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2, 0, 0, _Combine_3610726a63324800845304206f3644ab_RGBA_4, _Combine_3610726a63324800845304206f3644ab_RGB_5, _Combine_3610726a63324800845304206f3644ab_RG_6);
            float2 _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_3610726a63324800845304206f3644ab_RG_6, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float4 _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0 = SAMPLE_TEXTURE2D(_Property_4638da389d3f4f7187642a1df36cafc4_Out_0.tex, _Property_4638da389d3f4f7187642a1df36cafc4_Out_0.samplerstate, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_R_4 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.r;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_G_5 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.g;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_B_6 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.b;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.a;
            float _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2;
            Unity_Add_float(_Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2, _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7, _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2);
            UnityTexture2D _Property_9df39bcda2e242f29ad651b884e519a9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_45befcea4fb14766a59ddd103a6956b3_Out_0 = outlineOffest;
            float _Multiply_207e9916a207418090c84761d147d8ad_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 0, _Multiply_207e9916a207418090c84761d147d8ad_Out_2);
            float _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 1, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2);
            float4 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4;
            float3 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5;
            float2 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6;
            Unity_Combine_float(_Multiply_207e9916a207418090c84761d147d8ad_Out_2, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2, 0, 0, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6);
            float2 _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float4 _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9df39bcda2e242f29ad651b884e519a9_Out_0.tex, _Property_9df39bcda2e242f29ad651b884e519a9_Out_0.samplerstate, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float _SampleTexture2D_590aed00e942488597319811e606040b_R_4 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.r;
            float _SampleTexture2D_590aed00e942488597319811e606040b_G_5 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.g;
            float _SampleTexture2D_590aed00e942488597319811e606040b_B_6 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.b;
            float _SampleTexture2D_590aed00e942488597319811e606040b_A_7 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.a;
            float _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2;
            Unity_Add_float(_Add_bfffff96902e4e71aeaebb5d102086e9_Out_2, _SampleTexture2D_590aed00e942488597319811e606040b_A_7, _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2);
            UnityTexture2D _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0 = outlineOffest;
            float _Multiply_4984902a786a419da073164c825444d5_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, -1, _Multiply_4984902a786a419da073164c825444d5_Out_2);
            float _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, 0, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2);
            float4 _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4;
            float3 _Combine_c8db3debe77247e49c877efa92887a88_RGB_5;
            float2 _Combine_c8db3debe77247e49c877efa92887a88_RG_6;
            Unity_Combine_float(_Multiply_4984902a786a419da073164c825444d5_Out_2, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2, 0, 0, _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4, _Combine_c8db3debe77247e49c877efa92887a88_RGB_5, _Combine_c8db3debe77247e49c877efa92887a88_RG_6);
            float2 _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_c8db3debe77247e49c877efa92887a88_RG_6, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float4 _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0 = SAMPLE_TEXTURE2D(_Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.tex, _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.samplerstate, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_R_4 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.r;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_G_5 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.g;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_B_6 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.b;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.a;
            float _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2;
            Unity_Add_float(_Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2, _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7, _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2);
            UnityTexture2D _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_09dbd287d4844fa7a0a8861450959faf_Out_0 = outlineOffest;
            float _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, 0, _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2);
            float _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, -1, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2);
            float4 _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4;
            float3 _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5;
            float2 _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6;
            Unity_Combine_float(_Multiply_6716f420867641aebd0dd231a2eb0144_Out_2, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2, 0, 0, _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4, _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5, _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6);
            float2 _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float4 _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0 = SAMPLE_TEXTURE2D(_Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.tex, _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.samplerstate, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_R_4 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.r;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_G_5 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.g;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_B_6 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.b;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.a;
            float _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2;
            Unity_Add_float(_Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2, _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7, _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2);
            UnityTexture2D _Property_012c711507b645519f73babdd1f63180_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0 = outlineOffest;
            float _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2);
            float _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2);
            float4 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4;
            float3 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5;
            float2 _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6;
            Unity_Combine_float(_Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2, 0, 0, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5, _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6);
            float2 _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float4 _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0 = SAMPLE_TEXTURE2D(_Property_012c711507b645519f73babdd1f63180_Out_0.tex, _Property_012c711507b645519f73babdd1f63180_Out_0.samplerstate, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_R_4 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.r;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_G_5 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.g;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_B_6 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.b;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.a;
            float _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2;
            Unity_Add_float(_Add_ff805e671d494ebfab34a0eeb33682a7_Out_2, _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7, _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2);
            float _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3;
            Unity_Clamp_float(_Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2, 0, 1, _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3);
            float _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2;
            Unity_Subtract_float(_Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3, _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2);
            float _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0 = GlowControl;
            float _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2;
            Unity_Multiply_float(_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2, _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2);
            float _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2;
            Unity_Add_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2, _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2);
            float4 _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0 = IN.uv0;
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_R_1 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[0];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_G_2 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[1];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_B_3 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[2];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_A_4 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[3];
            float _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2;
            Unity_Multiply_float(_Split_e4faf5047a3745dd8484b3c2df1cae11_R_1, 10, _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2);
            float _Remap_b90a61292457452781ce5a0de4613230_Out_3;
            Unity_Remap_float(_Multiply_ee53730afa6346148000cf9afa7374a2_Out_2, float2 (0, 1), float2 (0, 1), _Remap_b90a61292457452781ce5a0de4613230_Out_3);
            float4 _UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0 = IN.uv0;
            float2 _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3;
            Unity_Rotate_Degrees_float((_UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3);
            float _Split_da81384144364fd1b73145399a5a93aa_R_1 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[0];
            float _Split_da81384144364fd1b73145399a5a93aa_G_2 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[1];
            float _Split_da81384144364fd1b73145399a5a93aa_B_3 = 0;
            float _Split_da81384144364fd1b73145399a5a93aa_A_4 = 0;
            float _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2;
            Unity_Multiply_float(_Split_da81384144364fd1b73145399a5a93aa_R_1, 10, _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2);
            float _Remap_421606ae375b41f198468213f05d2cec_Out_3;
            Unity_Remap_float(_Multiply_fc988eefcba94788a083bef41143e4aa_Out_2, float2 (0, 1), float2 (0, 1), _Remap_421606ae375b41f198468213f05d2cec_Out_3);
            float _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2;
            Unity_Minimum_float(_Remap_b90a61292457452781ce5a0de4613230_Out_3, _Remap_421606ae375b41f198468213f05d2cec_Out_3, _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2);
            float4 _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0 = IN.uv0;
            float _Split_c9223221d7574c9481a691cae4eb0097_R_1 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[0];
            float _Split_c9223221d7574c9481a691cae4eb0097_G_2 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[1];
            float _Split_c9223221d7574c9481a691cae4eb0097_B_3 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[2];
            float _Split_c9223221d7574c9481a691cae4eb0097_A_4 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[3];
            float _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2;
            Unity_Multiply_float(_Split_c9223221d7574c9481a691cae4eb0097_G_2, 10, _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2);
            float _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3;
            Unity_Remap_float(_Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2, float2 (0, 1), float2 (0, 1), _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3);
            float4 _UV_3fc62428a61744eda513ee5daa808905_Out_0 = IN.uv0;
            float2 _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3;
            Unity_Rotate_Degrees_float((_UV_3fc62428a61744eda513ee5daa808905_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3);
            float _Split_a037cc6e4b214ea88217c67d2a591114_R_1 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[0];
            float _Split_a037cc6e4b214ea88217c67d2a591114_G_2 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[1];
            float _Split_a037cc6e4b214ea88217c67d2a591114_B_3 = 0;
            float _Split_a037cc6e4b214ea88217c67d2a591114_A_4 = 0;
            float _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2;
            Unity_Multiply_float(_Split_a037cc6e4b214ea88217c67d2a591114_G_2, 10, _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2);
            float _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3;
            Unity_Remap_float(_Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2, float2 (0, 1), float2 (0, 1), _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3);
            float _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2;
            Unity_Minimum_float(_Remap_1388710757cc4cdd8db65720222ae5d9_Out_3, _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2);
            float _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2;
            Unity_Multiply_float(_Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2);
            float _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            Unity_Minimum_float(_Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2, _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2);
            surface.Alpha = _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            surface.AlphaClipThreshold = 0.5;
            return surface;
        }

            // --------------------------------------------------
            // Build Graph Inputs

            VertexDescriptionInputs BuildVertexDescriptionInputs(Attributes input)
        {
            VertexDescriptionInputs output;
            ZERO_INITIALIZE(VertexDescriptionInputs, output);

            output.ObjectSpaceNormal =           input.normalOS;
            output.ObjectSpaceTangent =          input.tangentOS.xyz;
            output.ObjectSpacePosition =         input.positionOS;

            return output;
        }
            SurfaceDescriptionInputs BuildSurfaceDescriptionInputs(Varyings input)
        {
            SurfaceDescriptionInputs output;
            ZERO_INITIALIZE(SurfaceDescriptionInputs, output);





            output.uv0 =                         input.texCoord0;
        #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN output.FaceSign =                    IS_FRONT_VFACE(input.cullFace, true, false);
        #else
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN
        #endif
        #undef BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN

            return output;
        }

            // --------------------------------------------------
            // Main

            #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShaderPass.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/Varyings.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShadowCasterPass.hlsl"

            ENDHLSL
        }
        Pass
        {
            Name "DepthOnly"
            Tags
            {
                "LightMode" = "DepthOnly"
            }

            // Render State
            Cull Back
        Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
        ZTest LEqual
        ZWrite On
        ColorMask 0

            // Debug
            // <None>

            // --------------------------------------------------
            // Pass

            HLSLPROGRAM

            // Pragmas
            #pragma target 4.5
        #pragma exclude_renderers gles gles3 glcore
        #pragma multi_compile_instancing
        #pragma multi_compile _ DOTS_INSTANCING_ON
        #pragma vertex vert
        #pragma fragment frag

            // DotsInstancingOptions: <None>
            // HybridV1InjectedBuiltinProperties: <None>

            // Keywords
            // PassKeywords: <None>
            // GraphKeywords: <None>

            // Defines
            #define _SURFACE_TYPE_TRANSPARENT 1
            #define _AlphaClip 1
            #define ATTRIBUTES_NEED_NORMAL
            #define ATTRIBUTES_NEED_TANGENT
            #define ATTRIBUTES_NEED_TEXCOORD0
            #define VARYINGS_NEED_TEXCOORD0
            #define FEATURES_GRAPH_VERTEX
            /* WARNING: $splice Could not find named fragment 'PassInstancing' */
            #define SHADERPASS SHADERPASS_DEPTHONLY
            /* WARNING: $splice Could not find named fragment 'DotsInstancingVars' */

            // Includes
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Texture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/TextureStack.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

            // --------------------------------------------------
            // Structs and Packing

            struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS : NORMAL;
            float4 tangentOS : TANGENT;
            float4 uv0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : INSTANCEID_SEMANTIC;
            #endif
        };
        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float4 texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };
        struct SurfaceDescriptionInputs
        {
            float4 uv0;
        };
        struct VertexDescriptionInputs
        {
            float3 ObjectSpaceNormal;
            float3 ObjectSpaceTangent;
            float3 ObjectSpacePosition;
        };
        struct PackedVaryings
        {
            float4 positionCS : SV_POSITION;
            float4 interp0 : TEXCOORD0;
            #if UNITY_ANY_INSTANCING_ENABLED
            uint instanceID : CUSTOM_INSTANCE_ID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            uint stereoTargetEyeIndexAsBlendIdx0 : BLENDINDICES0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            uint stereoTargetEyeIndexAsRTArrayIdx : SV_RenderTargetArrayIndex;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            FRONT_FACE_TYPE cullFace : FRONT_FACE_SEMANTIC;
            #endif
        };

            PackedVaryings PackVaryings (Varyings input)
        {
            PackedVaryings output;
            output.positionCS = input.positionCS;
            output.interp0.xyzw =  input.texCoord0;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }
        Varyings UnpackVaryings (PackedVaryings input)
        {
            Varyings output;
            output.positionCS = input.positionCS;
            output.texCoord0 = input.interp0.xyzw;
            #if UNITY_ANY_INSTANCING_ENABLED
            output.instanceID = input.instanceID;
            #endif
            #if (defined(UNITY_STEREO_MULTIVIEW_ENABLED)) || (defined(UNITY_STEREO_INSTANCING_ENABLED) && (defined(SHADER_API_GLES3) || defined(SHADER_API_GLCORE)))
            output.stereoTargetEyeIndexAsBlendIdx0 = input.stereoTargetEyeIndexAsBlendIdx0;
            #endif
            #if (defined(UNITY_STEREO_INSTANCING_ENABLED))
            output.stereoTargetEyeIndexAsRTArrayIdx = input.stereoTargetEyeIndexAsRTArrayIdx;
            #endif
            #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
            output.cullFace = input.cullFace;
            #endif
            return output;
        }

            // --------------------------------------------------
            // Graph

            // Graph Properties
            CBUFFER_START(UnityPerMaterial)
        float4 _MainTex_TexelSize;
        float4 _Color;
        float outlineOffest;
        float GlowFrequency;
        float2 GlowRange;
        float GlowControl;
        float EdgeControl;
        float4 RGBA;
        float Mono;
        CBUFFER_END

        // Object and Global properties
        SAMPLER(SamplerState_Linear_Repeat);
        TEXTURE2D(_MainTex);
        SAMPLER(sampler_MainTex);

            // Graph Functions
            
        void Unity_Multiply_float(float A, float B, out float Out)
        {
            Out = A * B;
        }

        void Unity_Combine_float(float R, float G, float B, float A, out float4 RGBA, out float3 RGB, out float2 RG)
        {
            RGBA = float4(R, G, B, A);
            RGB = float3(R, G, B);
            RG = float2(R, G);
        }

        void Unity_TilingAndOffset_float(float2 UV, float2 Tiling, float2 Offset, out float2 Out)
        {
            Out = UV * Tiling + Offset;
        }

        void Unity_Add_float(float A, float B, out float Out)
        {
            Out = A + B;
        }

        void Unity_Clamp_float(float In, float Min, float Max, out float Out)
        {
            Out = clamp(In, Min, Max);
        }

        void Unity_Subtract_float(float A, float B, out float Out)
        {
            Out = A - B;
        }

        void Unity_Remap_float(float In, float2 InMinMax, float2 OutMinMax, out float Out)
        {
            Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
        }

        void Unity_Rotate_Degrees_float(float2 UV, float2 Center, float Rotation, out float2 Out)
        {
            //rotation matrix
            Rotation = Rotation * (3.1415926f/180.0f);
            UV -= Center;
            float s = sin(Rotation);
            float c = cos(Rotation);

            //center rotation matrix
            float2x2 rMatrix = float2x2(c, -s, s, c);
            rMatrix *= 0.5;
            rMatrix += 0.5;
            rMatrix = rMatrix*2 - 1;

            //multiply the UVs by the rotation matrix
            UV.xy = mul(UV.xy, rMatrix);
            UV += Center;

            Out = UV;
        }

        void Unity_Minimum_float(float A, float B, out float Out)
        {
            Out = min(A, B);
        };

            // Graph Vertex
            struct VertexDescription
        {
            float3 Position;
            float3 Normal;
            float3 Tangent;
        };

        VertexDescription VertexDescriptionFunction(VertexDescriptionInputs IN)
        {
            VertexDescription description = (VertexDescription)0;
            description.Position = IN.ObjectSpacePosition;
            description.Normal = IN.ObjectSpaceNormal;
            description.Tangent = IN.ObjectSpaceTangent;
            return description;
        }

            // Graph Pixel
            struct SurfaceDescription
        {
            float Alpha;
            float AlphaClipThreshold;
        };

        SurfaceDescription SurfaceDescriptionFunction(SurfaceDescriptionInputs IN)
        {
            SurfaceDescription surface = (SurfaceDescription)0;
            UnityTexture2D _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float4 _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0 = SAMPLE_TEXTURE2D(_Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.tex, _Property_86dec9a49d6a4c6796261f4a2d12ba13_Out_0.samplerstate, IN.uv0.xy);
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_R_4 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.r;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_G_5 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.g;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_B_6 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.b;
            float _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7 = _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_RGBA_0.a;
            UnityTexture2D _Property_74f03fcb472647d2a59b580228c9d3da_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0 = outlineOffest;
            float _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2);
            float _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2;
            Unity_Multiply_float(_Property_c83293a1de1e47f6ba1ea1b16f7a8680_Out_0, 1, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2);
            float4 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4;
            float3 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5;
            float2 _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6;
            Unity_Combine_float(_Multiply_f9c5cc1c6d5541f0984d1066cf4bbe14_Out_2, _Multiply_b8eb81afdea544bf852c1447037b497a_Out_2, 0, 0, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGBA_4, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RGB_5, _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6);
            float2 _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_9ce61e25bda04ccfa017f1c6b01bd5ba_RG_6, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float4 _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0 = SAMPLE_TEXTURE2D(_Property_74f03fcb472647d2a59b580228c9d3da_Out_0.tex, _Property_74f03fcb472647d2a59b580228c9d3da_Out_0.samplerstate, _TilingAndOffset_641d964c68134d7280bde94f603543b8_Out_3);
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_R_4 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.r;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_G_5 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.g;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_B_6 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.b;
            float _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7 = _SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_RGBA_0.a;
            UnityTexture2D _Property_9ac06dcb411b45269374b16af55381bd_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_c0c279b23b6d467a923d28be4f49b59f_Out_0 = outlineOffest;
            float _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, 1, _Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2);
            float _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2;
            Unity_Multiply_float(_Property_c0c279b23b6d467a923d28be4f49b59f_Out_0, -1, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2);
            float4 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4;
            float3 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5;
            float2 _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6;
            Unity_Combine_float(_Multiply_c49c32c5cc04462c90cad2d2f3fd5f26_Out_2, _Multiply_90eae8c5fbd04160bfaee39d04ec5090_Out_2, 0, 0, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGBA_4, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RGB_5, _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6);
            float2 _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_0f0e9f04a04d41648bf1e39e04f7cb12_RG_6, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float4 _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9ac06dcb411b45269374b16af55381bd_Out_0.tex, _Property_9ac06dcb411b45269374b16af55381bd_Out_0.samplerstate, _TilingAndOffset_c936290f12934bd3a86886c23070329e_Out_3);
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_R_4 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.r;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_G_5 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.g;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_B_6 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.b;
            float _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7 = _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_RGBA_0.a;
            float _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2;
            Unity_Add_float(_SampleTexture2D_65bee042371d44c2ba02c1ce89f3e409_A_7, _SampleTexture2D_c0bbeb93bd7446ef922a776d988795ad_A_7, _Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2);
            UnityTexture2D _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_3cba5715217f4d94a2fec04740212ae8_Out_0 = outlineOffest;
            float _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, -1, _Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2);
            float _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2;
            Unity_Multiply_float(_Property_3cba5715217f4d94a2fec04740212ae8_Out_0, 1, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2);
            float4 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4;
            float3 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5;
            float2 _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6;
            Unity_Combine_float(_Multiply_7ff442ee0a0e428dad69b36acdc34a95_Out_2, _Multiply_4088694cc6864e9d84426c8255e6ebf6_Out_2, 0, 0, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGBA_4, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RGB_5, _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6);
            float2 _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_d8dc9e9cf8d543b182c1f886c18ce154_RG_6, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float4 _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.tex, _Property_9572f0591feb4a0dbf183da93a32b0ec_Out_0.samplerstate, _TilingAndOffset_703147947b2d4edebc47121d96bb3a09_Out_3);
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_R_4 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.r;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_G_5 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.g;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_B_6 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.b;
            float _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7 = _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_RGBA_0.a;
            float _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2;
            Unity_Add_float(_Add_d09d7b30d37a4973a0e0540af314a3cd_Out_2, _SampleTexture2D_8f6512d1df9b4172853b99f2737bf5d4_A_7, _Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2);
            UnityTexture2D _Property_4638da389d3f4f7187642a1df36cafc4_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_329a15e14a5f437bbe8147e054d43789_Out_0 = outlineOffest;
            float _Multiply_0322358642d34ca4be034be7037fc103_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 1, _Multiply_0322358642d34ca4be034be7037fc103_Out_2);
            float _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2;
            Unity_Multiply_float(_Property_329a15e14a5f437bbe8147e054d43789_Out_0, 0, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2);
            float4 _Combine_3610726a63324800845304206f3644ab_RGBA_4;
            float3 _Combine_3610726a63324800845304206f3644ab_RGB_5;
            float2 _Combine_3610726a63324800845304206f3644ab_RG_6;
            Unity_Combine_float(_Multiply_0322358642d34ca4be034be7037fc103_Out_2, _Multiply_ac3aa0f515b64147aa095458f60663b6_Out_2, 0, 0, _Combine_3610726a63324800845304206f3644ab_RGBA_4, _Combine_3610726a63324800845304206f3644ab_RGB_5, _Combine_3610726a63324800845304206f3644ab_RG_6);
            float2 _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_3610726a63324800845304206f3644ab_RG_6, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float4 _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0 = SAMPLE_TEXTURE2D(_Property_4638da389d3f4f7187642a1df36cafc4_Out_0.tex, _Property_4638da389d3f4f7187642a1df36cafc4_Out_0.samplerstate, _TilingAndOffset_33e86fcc00974d4892fd654dd3be3905_Out_3);
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_R_4 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.r;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_G_5 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.g;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_B_6 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.b;
            float _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7 = _SampleTexture2D_912d835c93b7486b927d73368774e309_RGBA_0.a;
            float _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2;
            Unity_Add_float(_Add_eb887a3288104ad3a7870cdf605c1dfd_Out_2, _SampleTexture2D_912d835c93b7486b927d73368774e309_A_7, _Add_bfffff96902e4e71aeaebb5d102086e9_Out_2);
            UnityTexture2D _Property_9df39bcda2e242f29ad651b884e519a9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_45befcea4fb14766a59ddd103a6956b3_Out_0 = outlineOffest;
            float _Multiply_207e9916a207418090c84761d147d8ad_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 0, _Multiply_207e9916a207418090c84761d147d8ad_Out_2);
            float _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2;
            Unity_Multiply_float(_Property_45befcea4fb14766a59ddd103a6956b3_Out_0, 1, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2);
            float4 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4;
            float3 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5;
            float2 _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6;
            Unity_Combine_float(_Multiply_207e9916a207418090c84761d147d8ad_Out_2, _Multiply_56fb66c235144a9999a29b42f88df3ca_Out_2, 0, 0, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGBA_4, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RGB_5, _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6);
            float2 _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_34bc46dd24c64451891dbcd25b84c8e4_RG_6, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float4 _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0 = SAMPLE_TEXTURE2D(_Property_9df39bcda2e242f29ad651b884e519a9_Out_0.tex, _Property_9df39bcda2e242f29ad651b884e519a9_Out_0.samplerstate, _TilingAndOffset_a29e866fa9af47d185a85ed6bc1f250d_Out_3);
            float _SampleTexture2D_590aed00e942488597319811e606040b_R_4 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.r;
            float _SampleTexture2D_590aed00e942488597319811e606040b_G_5 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.g;
            float _SampleTexture2D_590aed00e942488597319811e606040b_B_6 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.b;
            float _SampleTexture2D_590aed00e942488597319811e606040b_A_7 = _SampleTexture2D_590aed00e942488597319811e606040b_RGBA_0.a;
            float _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2;
            Unity_Add_float(_Add_bfffff96902e4e71aeaebb5d102086e9_Out_2, _SampleTexture2D_590aed00e942488597319811e606040b_A_7, _Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2);
            UnityTexture2D _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0 = outlineOffest;
            float _Multiply_4984902a786a419da073164c825444d5_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, -1, _Multiply_4984902a786a419da073164c825444d5_Out_2);
            float _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2;
            Unity_Multiply_float(_Property_dbf5527294eb42a79cd6d2d340c5eb5d_Out_0, 0, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2);
            float4 _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4;
            float3 _Combine_c8db3debe77247e49c877efa92887a88_RGB_5;
            float2 _Combine_c8db3debe77247e49c877efa92887a88_RG_6;
            Unity_Combine_float(_Multiply_4984902a786a419da073164c825444d5_Out_2, _Multiply_940c2a85de314b299014bcc6f72d58f4_Out_2, 0, 0, _Combine_c8db3debe77247e49c877efa92887a88_RGBA_4, _Combine_c8db3debe77247e49c877efa92887a88_RGB_5, _Combine_c8db3debe77247e49c877efa92887a88_RG_6);
            float2 _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_c8db3debe77247e49c877efa92887a88_RG_6, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float4 _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0 = SAMPLE_TEXTURE2D(_Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.tex, _Property_b9f0e7781924459baf3eb5653c4fcaef_Out_0.samplerstate, _TilingAndOffset_685d8bbfcdd042cc9e568ed775eb11e9_Out_3);
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_R_4 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.r;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_G_5 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.g;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_B_6 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.b;
            float _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7 = _SampleTexture2D_873cd43def90404ba7dc157cf0877105_RGBA_0.a;
            float _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2;
            Unity_Add_float(_Add_e7a5d01f49d145eca6424aabcb8bdc23_Out_2, _SampleTexture2D_873cd43def90404ba7dc157cf0877105_A_7, _Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2);
            UnityTexture2D _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_09dbd287d4844fa7a0a8861450959faf_Out_0 = outlineOffest;
            float _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, 0, _Multiply_6716f420867641aebd0dd231a2eb0144_Out_2);
            float _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2;
            Unity_Multiply_float(_Property_09dbd287d4844fa7a0a8861450959faf_Out_0, -1, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2);
            float4 _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4;
            float3 _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5;
            float2 _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6;
            Unity_Combine_float(_Multiply_6716f420867641aebd0dd231a2eb0144_Out_2, _Multiply_ea67adda0f08481f9e9b759411c6e3e6_Out_2, 0, 0, _Combine_a12a8349cf5d4de1967172b723851e9e_RGBA_4, _Combine_a12a8349cf5d4de1967172b723851e9e_RGB_5, _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6);
            float2 _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_a12a8349cf5d4de1967172b723851e9e_RG_6, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float4 _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0 = SAMPLE_TEXTURE2D(_Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.tex, _Property_db3200c4e9a34630ad1a49afa84160c9_Out_0.samplerstate, _TilingAndOffset_739f552e6ae846a49f06bac2c4c9c33e_Out_3);
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_R_4 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.r;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_G_5 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.g;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_B_6 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.b;
            float _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7 = _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_RGBA_0.a;
            float _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2;
            Unity_Add_float(_Add_377f4304183d4a1ea0eaf5ff0dad0938_Out_2, _SampleTexture2D_f537105893664f59b8ccdf627af2ca15_A_7, _Add_ff805e671d494ebfab34a0eeb33682a7_Out_2);
            UnityTexture2D _Property_012c711507b645519f73babdd1f63180_Out_0 = UnityBuildTexture2DStructNoScale(_MainTex);
            float _Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0 = outlineOffest;
            float _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2);
            float _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2;
            Unity_Multiply_float(_Property_9e9f5e0949a041d2b1212f5db6de4f5b_Out_0, -1, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2);
            float4 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4;
            float3 _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5;
            float2 _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6;
            Unity_Combine_float(_Multiply_7ec0a9808d6c463090481b25f599ebf3_Out_2, _Multiply_8c798ad4c9984eca9354f6b7d4452c9b_Out_2, 0, 0, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGBA_4, _Combine_6f0627836d28437f8dc237dc15d7eae7_RGB_5, _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6);
            float2 _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3;
            Unity_TilingAndOffset_float(IN.uv0.xy, float2 (1, 1), _Combine_6f0627836d28437f8dc237dc15d7eae7_RG_6, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float4 _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0 = SAMPLE_TEXTURE2D(_Property_012c711507b645519f73babdd1f63180_Out_0.tex, _Property_012c711507b645519f73babdd1f63180_Out_0.samplerstate, _TilingAndOffset_a03a2d6c1e0c467392358d8ce9ae5238_Out_3);
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_R_4 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.r;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_G_5 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.g;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_B_6 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.b;
            float _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7 = _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_RGBA_0.a;
            float _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2;
            Unity_Add_float(_Add_ff805e671d494ebfab34a0eeb33682a7_Out_2, _SampleTexture2D_7226d3dc8872451cadacc0f5785c18c6_A_7, _Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2);
            float _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3;
            Unity_Clamp_float(_Add_193bc6d1fd6b489bbbfb9160a26d40f7_Out_2, 0, 1, _Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3);
            float _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2;
            Unity_Subtract_float(_Clamp_e5758615db524a10b0bcfbbfa33cbd84_Out_3, _SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Subtract_258302e078894f0090f1d7373da3bb1d_Out_2);
            float _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0 = GlowControl;
            float _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2;
            Unity_Multiply_float(_Subtract_258302e078894f0090f1d7373da3bb1d_Out_2, _Property_ff2b31f9da214d34937b6d38a87337e2_Out_0, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2);
            float _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2;
            Unity_Add_float(_SampleTexture2D_7f6a5f61bbe248dc82040bd87bd8036e_A_7, _Multiply_b6642c0844b14f07bf59d685c3214ac9_Out_2, _Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2);
            float4 _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0 = IN.uv0;
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_R_1 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[0];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_G_2 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[1];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_B_3 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[2];
            float _Split_e4faf5047a3745dd8484b3c2df1cae11_A_4 = _UV_d140a575fa1d48ef9f3cc8ceb032949f_Out_0[3];
            float _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2;
            Unity_Multiply_float(_Split_e4faf5047a3745dd8484b3c2df1cae11_R_1, 10, _Multiply_ee53730afa6346148000cf9afa7374a2_Out_2);
            float _Remap_b90a61292457452781ce5a0de4613230_Out_3;
            Unity_Remap_float(_Multiply_ee53730afa6346148000cf9afa7374a2_Out_2, float2 (0, 1), float2 (0, 1), _Remap_b90a61292457452781ce5a0de4613230_Out_3);
            float4 _UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0 = IN.uv0;
            float2 _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3;
            Unity_Rotate_Degrees_float((_UV_a1e4def343fd42d1ba1fffac4c5e2d87_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3);
            float _Split_da81384144364fd1b73145399a5a93aa_R_1 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[0];
            float _Split_da81384144364fd1b73145399a5a93aa_G_2 = _Rotate_5d9d1847a61943a8ae42f436a667919d_Out_3[1];
            float _Split_da81384144364fd1b73145399a5a93aa_B_3 = 0;
            float _Split_da81384144364fd1b73145399a5a93aa_A_4 = 0;
            float _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2;
            Unity_Multiply_float(_Split_da81384144364fd1b73145399a5a93aa_R_1, 10, _Multiply_fc988eefcba94788a083bef41143e4aa_Out_2);
            float _Remap_421606ae375b41f198468213f05d2cec_Out_3;
            Unity_Remap_float(_Multiply_fc988eefcba94788a083bef41143e4aa_Out_2, float2 (0, 1), float2 (0, 1), _Remap_421606ae375b41f198468213f05d2cec_Out_3);
            float _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2;
            Unity_Minimum_float(_Remap_b90a61292457452781ce5a0de4613230_Out_3, _Remap_421606ae375b41f198468213f05d2cec_Out_3, _Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2);
            float4 _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0 = IN.uv0;
            float _Split_c9223221d7574c9481a691cae4eb0097_R_1 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[0];
            float _Split_c9223221d7574c9481a691cae4eb0097_G_2 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[1];
            float _Split_c9223221d7574c9481a691cae4eb0097_B_3 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[2];
            float _Split_c9223221d7574c9481a691cae4eb0097_A_4 = _UV_1a5c5b9a392243b19a4a3420364bde1f_Out_0[3];
            float _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2;
            Unity_Multiply_float(_Split_c9223221d7574c9481a691cae4eb0097_G_2, 10, _Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2);
            float _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3;
            Unity_Remap_float(_Multiply_e6cc2089e9d544c2bee8f19599224c03_Out_2, float2 (0, 1), float2 (0, 1), _Remap_1388710757cc4cdd8db65720222ae5d9_Out_3);
            float4 _UV_3fc62428a61744eda513ee5daa808905_Out_0 = IN.uv0;
            float2 _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3;
            Unity_Rotate_Degrees_float((_UV_3fc62428a61744eda513ee5daa808905_Out_0.xy), float2 (0.5, 0.5), 180, _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3);
            float _Split_a037cc6e4b214ea88217c67d2a591114_R_1 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[0];
            float _Split_a037cc6e4b214ea88217c67d2a591114_G_2 = _Rotate_0a68361db02a4eca880ee09d5b945f54_Out_3[1];
            float _Split_a037cc6e4b214ea88217c67d2a591114_B_3 = 0;
            float _Split_a037cc6e4b214ea88217c67d2a591114_A_4 = 0;
            float _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2;
            Unity_Multiply_float(_Split_a037cc6e4b214ea88217c67d2a591114_G_2, 10, _Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2);
            float _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3;
            Unity_Remap_float(_Multiply_55926dcfa99048a2b420e31a3b652df3_Out_2, float2 (0, 1), float2 (0, 1), _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3);
            float _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2;
            Unity_Minimum_float(_Remap_1388710757cc4cdd8db65720222ae5d9_Out_3, _Remap_abfc5fac293648489f62e0c8416b3bee_Out_3, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2);
            float _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2;
            Unity_Multiply_float(_Minimum_9293fc8d55dd420ebacff8d93d5a479e_Out_2, _Minimum_38a39ae58aad40f2a2b6856ce7a886fa_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2);
            float _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            Unity_Minimum_float(_Add_9f7d0e24b1fb49e395296066e16ca87d_Out_2, _Multiply_a81cd6fa0efd40038acd34fa03e6f0be_Out_2, _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2);
            surface.Alpha = _Minimum_a54b2c4318784ffa866fd63438b9b606_Out_2;
            surface.AlphaClipThreshold = 0.5;
            return surface;
        }

            // --------------------------------------------------
            // Build Graph Inputs

            VertexDescriptionInputs BuildVertexDescriptionInputs(Attributes input)
        {
            VertexDescriptionInputs output;
            ZERO_INITIALIZE(VertexDescriptionInputs, output);

            output.ObjectSpaceNormal =           input.normalOS;
            output.ObjectSpaceTangent =          input.tangentOS.xyz;
            output.ObjectSpacePosition =         input.positionOS;

            return output;
        }
            SurfaceDescriptionInputs BuildSurfaceDescriptionInputs(Varyings input)
        {
            SurfaceDescriptionInputs output;
            ZERO_INITIALIZE(SurfaceDescriptionInputs, output);





            output.uv0 =                         input.texCoord0;
        #if defined(SHADER_STAGE_FRAGMENT) && defined(VARYINGS_NEED_CULLFACE)
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN output.FaceSign =                    IS_FRONT_VFACE(input.cullFace, true, false);
        #else
        #define BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN
        #endif
        #undef BUILD_SURFACE_DESCRIPTION_INPUTS_OUTPUT_FACESIGN

            return output;
        }

            // --------------------------------------------------
            // Main

            #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShaderPass.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/Varyings.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/DepthOnlyPass.hlsl"

            ENDHLSL
        }
    }
    FallBack "Hidden/Shader Graph/FallbackError"
}