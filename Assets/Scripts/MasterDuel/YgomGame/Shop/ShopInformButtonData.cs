using System;
using UnityEngine;

namespace YgomGame.Shop
{
	[Serializable]
	public class ShopInformButtonData
	{
		public enum Behaviour
		{
			OpenHelp = 0,
			OpenCardPackRateList = 1,
			OpenCardPoolList = 2,
			OpenCardPickupList = 3,
			OpenStructureDeckBrowser = 4,
			OpenItemViewer = 5,
			OpenDuelPassRewardList = 6,
			OpenHelpSwitchDx = 7,
			OpenHelpSwitchPackType = 8,
			OpenItemPreview = 9,
			OpenPrizeList = 10,
			OpenPrizeResult = 11,
			OpenCardStandardPackRateList = 12
		}

		public enum BehaviourParamFormtData
		{
			ShopId = 10,
			PackId = 11
		}

		public enum ButtonStyle
		{
			Normal = 0,
			Small = 1,
			Highlight = 2
		}

		public enum FormatData
		{
			ProductName = 1,
			ProductSubLabel = 2
		}

		[SerializeField]
		private Behaviour m_Behaviour;

		[SerializeField]
		private string[] m_BehaviourParams;

		[SerializeField]
		private BehaviourParamFormtData[] m_BehaviourFormatDatas;

		[SerializeField]
		private ButtonStyle m_ButtonStyle;

		[SerializeField]
		private string m_LabelTextId;

		[SerializeField]
		private FormatData[] m_LabelFormatDatas;

		[SerializeField]
		private bool m_SkipOnBlockPurchase;

		public Behaviour behaviour => default(Behaviour);

		public string[] behaviourParams => null;

		public BehaviourParamFormtData[] behaviourFormatDatas => null;

		public ButtonStyle buttonStyle => default(ButtonStyle);

		public string labelTextId => null;

		public FormatData[] labelFormatDatas => null;

		public bool skipOnBlockPurchase => false;
	}
}
