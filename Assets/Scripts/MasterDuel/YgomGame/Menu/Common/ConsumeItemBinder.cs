using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class ConsumeItemBinder : ResourceBinderBase//, IItemConsumeBinder
	{
		[Serializable]
		public class ConsumeItemPathData
		{
			public ResourceBindingPathSetting.ItemPathData m_ConsumeItemPath;
		}

		private ConsumeItemPathData m_Data;

		public void Initialize(ConsumeItemPathData data)
		{
		}

		public string GetIconPath(int consumeId, bool isLarge = false)
		{
			return null;
		}

		public BindingImageEx BindIcon(Image target, int consumeId, bool async = true, bool isLarge = false)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemConsumeBinder_002EBindItem(GameObject target, int consumeId)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemConsumeBinder_002EBindItemLarge(GameObject target, int consumeId)
		{
			return null;
		}
	}
}
