using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace YgomSystem.YGomTMPro
{
	public class TextMeshProFontCacheManager : MonoBehaviour
	{
		private static TextMeshProFontCacheManager s_Instance;

		private List<TMP_FontAsset> m_SearchList;

		private Dictionary<TMP_FontAsset, List<GameObject>> m_FontReferenceMap;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static TMP_FontAsset GetCache(GameObject owner, TMP_FontAsset fontAssetRef)
		{
			return null;
		}

		public static void ReleaseCache(GameObject owner, TMP_FontAsset fontAssetRef)
		{
		}

		public static void ReleaseAllCache()
		{
		}
	}
}
