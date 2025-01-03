using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.GemShop
{
	public class GemShopIconSetting : ScriptableObject
	{
		[Serializable]
		public class IconData
		{
			public int iconId;

			public string thumbFxpId;

			public int effectId;
		}

		[SerializeField]
		private string m_ThumbPathFormat;

		[SerializeField]
		private IconData[] m_IconDatas;

		private Dictionary<int, IconData> m_IconDataMap;

		public bool ValidIconId(int iconId)
		{
			return false;
		}

		private IconData GetIconData(int iconId)
		{
			return null;
		}

		public string GetIconPath(int iconId)
		{
			return null;
		}

		public int GetEffectId(int iconId)
		{
			return 0;
		}
	}
}
