using UnityEngine;
using YgomGame.Shop;

namespace YgomGame.Menu.Common
{
	public class ShopResourceBinder : ResourceBinderBase
	{
		public readonly string cardThumbSettingPath;

		private readonly string m_HighlightThumbImagePath;

		private readonly string m_HighlightThumbPrefPath;

		public ShopResourceBinder(string cardThumbSettingPath, string highlightThumbImagePath, string highlightThumbPrefPath)
		{
		}

		public BindingShopProductThumb BindPackThumb(RectTransform target, int thumbType, string thumbData, ShopCardThumbSettings.Format thumbFormat)
		{
			return null;
		}

		public string GetHighlightThumbImagePath(string name)
		{
			return null;
		}

		public string GetHighlightThumbPrefPath(string name)
		{
			return null;
		}
	}
}
