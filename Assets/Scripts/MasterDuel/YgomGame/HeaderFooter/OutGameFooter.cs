using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.HeaderFooter
{
	public class OutGameFooter : MonoBehaviour
	{
		private readonly string ROOT_LABEL;

		private readonly string TMP_LABEL;

		private readonly string TXT_LABEL;

		private readonly string IMG_LABEL;

		private ElementObjectManager elementObjectManager;

		private Dictionary<SelectorManager.KeyType, GameObject> shortcutDic;

		private ElementObjectManager eom => null;

		public static void Create(Transform parent, Action<OutGameFooter> onComplete = null)
		{
		}

		public void SetShortcut(SelectorManager.KeyType keyType, string label, Action onComplete = null, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00)
		{
		}

		public void RemoveShortcut(SelectorManager.KeyType keyType)
		{
		}

		private GameObject CreateTemplate(SelectorManager.KeyType keyType, string label, Action onComplete = null, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00)
		{
			return null;
		}
	}
}
