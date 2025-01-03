using System;
using TMPro;
using UnityEngine;

namespace YgomSystem.YGomTMPro
{
	[Obsolete]
	public class TextMeshProFontCache : MonoBehaviour
	{
		private TMP_FontAsset m_CachedFontAsset;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
