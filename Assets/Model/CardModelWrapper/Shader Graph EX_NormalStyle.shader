Shader "Shader Graph EX/NormalStyle" {
	Properties {
		[Enum(Off, 0, On, 1)] _ZWrite ("ZWrite", Float) = 0
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		[NoScaleOffset] _MainTex ("MainTex", 2D) = "white" {}
		[NoScaleOffset] _LoadingTex ("LoadingTex", 2D) = "white" {}
		_LoadingBlend ("LoadingBlend", Range(0, 1)) = 0
		_AmbientColor ("AmbientColor", Vector) = (0.1019608,0.1019608,0.1019608,1)
		_AddColor ("AddColor", Vector) = (0.5019608,0.5019608,0.5019608,1)
		_Monochrome ("Monochrome", Range(0, 1)) = 0
		_DirectionalLightAmp ("DirectionalLightAmp", Float) = 0.88
		_FakeLightColor ("FakeLightColor", Vector) = (1,0,0,1)
		_FakeLightDirection ("FakeLightDirection", Vector) = (0,0,0,0)
		_FakeViewDirection ("FakeViewDirection", Vector) = (0,0,0,0)
		_FakeNormalDirection ("FakeNormalDirection", Vector) = (0,0,0,0)
		_FakeBlend ("FakeBlend", Range(0, 1)) = 0
		_TintColor ("TintColor", Vector) = (1,1,1,1)
		[NoScaleOffset] _Texture2DAsset_90c6e35ef4304f289c279037152a03b7_Out_0 ("Texture2D", 2D) = "white" {}
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Hidden/Shader Graph/FallbackError"
}