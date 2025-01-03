using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu
{
	public class LoginBonusSlotWidget : ElementWidgetBase
	{
		public enum Mode
		{
			None = 0,
			Recieved = 1,
			RecieveFocus = 2
		}

		private struct Reward
		{
			internal int day;

			internal int num;

			internal int category;

			internal int itemId;

			internal bool is_period;
		}

		private const string k_ELabelLabelText = "LabelText";

		private const string k_ELabelRewardThumb = "RewardThumb";

		private const string k_ELabelRewardNum = "RewardNum";

		private const string k_ELabelRecievedCover = "RecievedCover";

		private const string k_ELabelRecieveFocusCover = "RecieveFocusCover";

		internal const string k_ELabelLabelTextImage = "LabelTextImage";

		private Mode _mode;

		private List<Reward> _rewards;

		public SelectionButton button => null;

		public TMP_Text labelText => null;

		public GameObject rewardThumb => null;

		public TMP_Text rewardNum => null;

		public GameObject recievedCover => null;

		public GameObject recieveFocusCover => null;

		public int rewardCount => 0;

		public LoginBonusSlotWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void BindImage(string label, Sprite image)
		{
		}

		public void SetMode(Mode mode)
		{
		}

		public void Ready()
		{
		}

		public void AddData(Dictionary<string, object> source, int slotNumber)
		{
		}

		public void ShowItem()
		{
		}

		public void ShowObtainedItem(EntryItemListData itemList, Action callback, bool isPresentBoxSent = false)
		{
		}
	}
}
