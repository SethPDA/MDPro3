using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class ShopShortcutKeyFooter : ElementWidgetBase
	{
		private readonly string k_ELabelPlayButton;

		private readonly string k_ELabelPlayIcon;

		private readonly string k_ELabelPlayText;

		public readonly SelectionButton playButton;

		public readonly GameObject playIcon;

		public readonly TMP_Text playText;

		public ShopShortcutKeyFooter(ElementObjectManager eom)
			: base(null)
		{
		}
	}
}
