using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class ShopTabWidget : ElementWidgetBase
	{
		private readonly string k_ELabelButton;

		private readonly string k_ELabelOn;

		private readonly string k_ELabelOff;

		private const string k_ELabelOnText = "OnText";

		private const string k_ELabelOffText = "OffText";

		private const string k_ELabelBadge = "Badge";

		private const string k_TLabelToOn = "ToOn";

		public readonly SelectionButton button;

		public readonly GameObject onImage;

		public readonly GameObject offImage;

		public readonly GameObject badge;

		private bool m_ToOnDirty;

		private List<Tween> m_TCache_ToOn;

		public ShopTabWidget(ElementObjectManager eom, bool isOn = false)
			: base(null)
		{
		}

		public void SetLabel(string label)
		{
		}

		public void SetIsOn(bool isOn)
		{
		}
	}
}
