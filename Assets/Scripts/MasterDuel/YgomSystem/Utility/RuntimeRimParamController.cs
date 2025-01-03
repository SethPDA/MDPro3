using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class RuntimeRimParamController : MonoBehaviour
	{
		private int shaderID_SpecParams;

		private int shaderID_BackLightDirIntensity;

		private int shaderID_BackLightColor;

		private int shaderID_CubeTex;

		private bool initialized;

		private bool initializedMaterials;

		private HashSet<Material> mtrls;

		private Vector4 prevSrcSpecParams;

		private Vector3 prevF;

		private float prevIntensity;

		private Color prevColor;

		private Texture prevCubeTex;

		private static readonly Vector3 forward;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void InitializeMaterials()
		{
		}

		private void UpdateMaterialParams()
		{
		}

		private bool GetMaterialParams(out Vector4 specParams, out float intensity, out Color color, out Texture cubeTex)
		{
			specParams = default(Vector4);
			intensity = default(float);
			color = default(Color);
			cubeTex = null;
			return false;
		}
	}
}
