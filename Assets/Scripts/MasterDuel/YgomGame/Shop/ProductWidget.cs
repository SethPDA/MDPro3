using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.CardPack;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class ProductWidget : ElementWidgetBase
	{
		private readonly string k_ELabelHeadIconText;

		internal const string k_TLabelStyleNormal = "Style_Normal";

		internal const string k_TLabelStyleHighlight = "Style_Highlight";

		private const string k_TLabelLimitAlert_OFF = "LimitAlert_OFF";

		private const string k_TLabelLimitAlert_ON = "LimitAlert_ON";

		public int index;

		public int shopId;

		public readonly string widgetLabel;

		public readonly SelectionButton button;

		public readonly GameObject badge;

		public readonly GameObject newGroup;

		public readonly GameObject baseLower;

		public readonly TMP_Text pickupNameText;

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

		public readonly ParticleAlphaGroup thumbHolderParticleAlphaGroup;

		public readonly GameObject soldOutCover;

		public readonly GameObject limitGroup;

		public readonly TMP_Text limitRemainText;

		public readonly TMP_Text limitDateText;

		public readonly GameObject numGroup;

		public readonly TMP_Text numText;

		public readonly CardPackChartWidget pickupChartWidget;

		public readonly TMP_Text descText;

		public readonly GameObject packPickupMessageGroup;

		public readonly TMP_Text packPickupMessage;

		private List<Tween> tweens;

		public Action<ProductWidget> onClickCallback;

		public Action<ProductWidget> onSelectedCallback;

		public TMP_Text newLabel => null;

		public ProductWidget(string widgetLabel, ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetLimitAlertStyle(bool isAlertOn)
		{
		}

		public void PlayStyleTween(string label)
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
