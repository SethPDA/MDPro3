using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenShaderFloat : Tween
	{
		[SerializeField]
		public float from;

		[SerializeField]
		public float to;

		[SerializeField]
		public string paramName;

		[SerializeField]
		public Material[] materials;

		private Dictionary<int, Material> materialList;

		public bool isRecusive;

		public bool isShared;

		public void InitializeMaterials(Dictionary<int, Material> initMaterialList = null)
		{
		}

		public Dictionary<int, Material> GetMaterials()
		{
			return null;
		}

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
