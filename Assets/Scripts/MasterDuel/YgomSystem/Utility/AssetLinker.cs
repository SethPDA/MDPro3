using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class AssetLinker : MonoBehaviour
	{
		[Serializable]
		public class LinkInfo
		{
			public string label;

			public string assetPath;

			public LinkInfo Copy()
			{
				return null;
			}
		}

		public List<LinkInfo> infoList;

		private const string dirNameResources = "/Resources/";

		private const int dirNameResourcesLength = 11;

		private const string dirNameResourcesAB = "/ResourcesAssetBundle/";

		private const int dirNameResourcesABLength = 22;

		public void Instantiate(string label, Transform parent, Action<GameObject> onFinished)
		{
		}

		public string GetAssetPath(string label)
		{
			return null;
		}

		public void GetAsset(string label, Action<UnityEngine.Object> onFinished, Type systemTypeInstance = null)
		{
		}

		private LinkInfo FindLinkInfo(string label)
		{
			return null;
		}

		public static string GetResourcePath(string fullPath)
		{
			return null;
		}
	}
}
