using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem
{
	public class ShaderResourceCache
	{
		public Material[] preloadMaterials;

		private Dictionary<string, Shader> shaders;

		public const string shaderSetResPath = "BundleMaterials/MaterialPack.Unity2018_4_2f1";

		private static ShaderResourceCache m_instance;

		public static ShaderResourceCache instance => null;

		public bool busy
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize()
		{
		}

		private IEnumerator InitializeImpl()
		{
			return null;
		}

		public void Terminate()
		{
		}

		public Shader GetShader(string shaderLabel)
		{
			return null;
		}

		private Shader GetShaderImpl(string shaderLabel)
		{
			return null;
		}
	}
}
