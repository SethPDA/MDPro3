using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.DuelLive
{
	public class ProductWidget : ElementWidgetBase
	{
		private const string k_TLabelStyleNormal = "Style_Normal";

		private const string k_TLabelStyleHighlight = "Style_Highlight";

		private const string k_TLabelLimitAlert_OFF = "LimitAlert_OFF";

		private const string k_TLabelLimitAlert_ON = "LimitAlert_ON";

		private const string k_TLabelProductRandom = "templateDuelLive";

		private const string k_TLabelProductVS = "templateVS";

		private const string k_TLabelProductEvent = "templateEvent";

		private const string k_TLabelProductOfficialAccount = "templateSpecialAccount";

		private const string k_TLabelProductCommingSoon = "templateComingSoon";

		private const string k_TLabelCard_0_0 = "Card_0_0";

		private const string k_TLabelCard_0_1 = "Card_0_1";

		private const string k_TLabelCard_0_2 = "Card_0_2";

		private const string k_TLabelCard_1_0 = "Card_1_0";

		private const string k_TLabelCard_1_1 = "Card_1_1";

		private const string k_TLabelCard_1_2 = "Card_1_2";

		public int index;

		public int menuId;

		public int replayIdx;

		public long duelLiveId;

		public int widgetType;

		public SelectionButton button;

		private List<ElementObjectManager> widgets;

		public List<SelectionButton> widgetButtons;

		public readonly GameObject badge;

		public readonly GameObject newGroup;

		public readonly GameObject baseLower;

		public readonly TMP_Text nameText;

		public readonly GameObject priceGroup;

		public readonly GameObject priceBGDefault;

		public readonly GameObject priceBGHighlight;

		public readonly Image priceButtonIcon;

		public readonly TMP_Text priceText;

		public readonly TMP_Text priceLabelText;

		public readonly TMP_Text priceFreeText;

		public readonly TMP_Text priceFreeLabelText;

		public readonly GameObject priceIcon;

		public readonly GameObject priceTimeLimitIcon;

		public readonly GameObject ownedGroup;

		public readonly RectTransform thumbHolder;

		public readonly Image deckCaseImage;

		public readonly GameObject soldOutCover;

		public readonly GameObject limitGroup;

		public readonly TMP_Text limitRemainText;

		public readonly TMP_Text limitDateText;

		public readonly GameObject numGroup;

		public readonly TMP_Text numText;

		public readonly TMP_Text descText;

		public readonly GameObject packPickupMessageGroup;

		public readonly TMP_Text packPickupMessage;

		public readonly GameObject thumbRoot;

		public readonly PlatformOverriderGroup platFormOverriderGroup;

		public Action<ProductWidget> onClickCallback;

		public Action<ProductWidget> onSelectedCallback;

		public ProductWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetAll(IProductContext productCtx)
		{
		}

		private void SetLimitAlertStyle(bool isAlertOn)
		{
		}

		protected void OnClick()
		{
		}

		protected void OnSelected()
		{
		}
	}
}
