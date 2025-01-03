using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class AssetReferer : MonoBehaviour
	{
		[Serializable]
		public class ReferenceInfo
		{
			public string label;

			public UnityEngine.Object assetRef;

			public ReferenceInfo Copy()
			{
				return null;
			}
		}

		public List<ReferenceInfo> infoList;

		public GameObject Instantiate(string label, Transform parent)
		{
			return null;
		}

		public UnityEngine.Object GetAsset(string label)
		{
			return null;
		}

		public T GetAsset<T>(string label) where T : UnityEngine.Object
		{
			return null;
		}

		private ReferenceInfo FindReferenceInfo(string label)
		{
			return null;
		}
	}
}
