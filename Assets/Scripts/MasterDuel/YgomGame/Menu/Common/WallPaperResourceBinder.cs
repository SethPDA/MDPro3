using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common
{
	public class WallPaperResourceBinder : ResourceBinderBase//, IItemWallpaperBinder
	{
		[Serializable]
		public class WallPaperResourcePathData
		{
			public string m_WallPaperResourcePath;

			public string topicsThumbPath;
		}

		private WallPaperResourcePathData m_WallPaperPath;

		public void Initialize(WallPaperResourcePathData iconPath)
		{
		}

		public string GetIconPath(int itemId)
		{
			return null;
		}

		public string GetTopicsThumbPath(int itemId)
		{
			return null;
		}

		public BindingImageEx BindIcon(Image target, int itemId, bool async = true)
		{
			return null;
		}

		public BindingImageEx BindThumb(Image target, int itemId, bool async = true)
		{
			return null;
		}

		public BindingImageEx BindTopicsThumb(Image target, int itemId, bool async = true)
		{
			return null;
		}

		private Component YgomGame_002EMenu_002ECommon_002EIItemWallpaperBinder_002EBindItem(GameObject target, int itemID)
		{
			return null;
		}
	}
}
