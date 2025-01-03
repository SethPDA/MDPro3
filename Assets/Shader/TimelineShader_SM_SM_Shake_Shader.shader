Shader "TimelineShader/SM/SM_Shake_Shader" {
	Properties {
		[NoScaleOffset] _MainTex ("_MainTex", 2D) = "white" {}
		Vector1_5cc3d821a68e4acb9ac135067244a058 ("Transparent", Range(0, 1)) = 1
		_ShakeRolling ("ShakeRolling", Range(-0.3, 0.1)) = 0.03
		[ToggleUI] _Shake_X ("Shake_X", Float) = 1
		_Shakeparticle ("Shakeparticle", Range(0, 1000)) = 100
		[ToggleUI] _Shake_Y ("Shake_Y", Float) = 0
		_ShakeSpeed ("ShakeSpeed", Range(0, 5)) = 0.3
		[NoScaleOffset] _ShaderNoize ("ShaderNoize", 2D) = "white" {}
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