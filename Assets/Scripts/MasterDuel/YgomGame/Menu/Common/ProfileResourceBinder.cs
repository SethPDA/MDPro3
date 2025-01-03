using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class ProfileResourceBinder : ResourceBinderBase//, IItemProfileTagBinder
	{
		[Serializable]
		public class ProfileResource
		{
			public ResourceBindingPathSetting.ItemPathData m_ProfileTagIconPath;
		}

		private ProfileResource m_PathData;

		public void Initialize(ProfileResource path)
		{
		}

		public string GetProfileTagIconPath(bool isLarge = false)
		{
			return null;
		}

		public BindingImageEx BindIcon(Image target, bool async = true, bool isLarge = false)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemProfileTagBinder_002EBindItem(GameObject target, int consumeId)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemProfileTagBinder_002EBindItemLarge(GameObject target, int consumeId)
		{
			return null;
		}
	}
}
