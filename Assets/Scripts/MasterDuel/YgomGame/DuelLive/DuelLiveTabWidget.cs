using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive
{
	public class DuelLiveTabWidget : ElementWidgetBase
	{
		private readonly string k_ELabelButton;

		private readonly string k_ELabelOn;

		private readonly string k_ELabelOff;

		private const string k_ELabelOnText = "OnText";

		private const string k_ELabelOffText = "OffText";

		private const string k_ELabelBadge = "Badge";

		private const string k_ELabelExIconRoot = "EXIconRoot";

		public readonly SelectionButton button;

		public readonly GameObject onImage;

		public readonly GameObject offImage;

		public readonly GameObject badge;

		public readonly GameObject ExIconRoot;

		public DuelLiveTabWidget(ElementObjectManager eom, bool isOn = false)
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
