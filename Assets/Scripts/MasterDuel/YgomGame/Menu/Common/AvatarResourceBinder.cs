using System;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	public class AvatarResourceBinder : ResourceBinderBase//, IItemAvatarBinder
	{
		[Serializable]
		public class AvatarResourcePathData
		{
			public string m_AvatarResourcePath;
		}

		private AvatarResourcePathData m_AvaterPath;

		public void Initialize(AvatarResourcePathData iconPath)
		{
		}

		public string GetIconPath(int itemId)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemAvatarBinder_002EBindItem(GameObject target, int itemId)
		{
			return null;
		}
	}
}
