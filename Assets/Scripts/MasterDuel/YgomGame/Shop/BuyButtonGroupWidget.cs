using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class BuyButtonGroupWidget : ElementWidgetBase
	{
		public class BuyButtonWidget : ElementWidgetBase
		{
			public class Context
			{
				public string buttonIconPath;

				public bool limitedIconVisible;

				public string numText;

				public bool paidIconVisible;

				public bool payItemIsPeriod;

				public int payItemCategory;

				public int payItemId;

				public string priceText;

				public string infoText;

				public void Clear()
				{
				}
			}

			private readonly string k_ELabel_IconGrp;

			private readonly string k_ELabel_IconGrp_PriceButtonIcon;

			private readonly string k_ELabel_NumGrp;

			private readonly string k_ELabel_NumGrp_PriceTimeLimitIcon;

			private readonly string k_ELabel_NumGrp_NumText;

			private readonly string k_ELabel_PriceGrp;

			private readonly string k_ELabel_PriceGrp_PaidIcon;

			private readonly string k_ELabel_PriceGrp_PriceIcon;

			private readonly string k_ELabel_PriceGrp_PriceIconTicket;

			private readonly string k_ELabel_PriceGrp_PriceText;

			private readonly string k_ELabelInfoText;

			public readonly int priceId;

			public SelectionButton button => null;

			public GameObject iconGrp => null;

			public Image priceButtonIcon => null;

			public GameObject numGrp => null;

			public GameObject limitPriceGroup => null;

			public TMP_Text numText => null;

			public GameObject priceGrp => null;

			public GameObject paidIcon => null;

			public GameObject priceIcon => null;

			public GameObject priceIconTicket => null;

			public TMP_Text priceText => null;

			public TMP_Text infoText => null;

			public BuyButtonWidget(ElementObjectManager eom, int priceId)
				: base(null)
			{
			}

			public void RefreshView(Context ctx)
			{
			}
		}

		private readonly string k_ELabelBuyButtonTemplate;

		private readonly string k_ELabelBuyButtonSRTemplate;

		private readonly string k_ELabelBuyButtonURTemplate;

		private const int k_ButtonStyleNormal = 1;

		private const int k_ButtonStyleSR = 2;

		private const int k_ButtonStyleUR = 3;

		private readonly ElementObjectManager m_BuyButtonTemplate;

		private readonly ElementObjectManager m_BuyButtonSRTemplate;

		private readonly ElementObjectManager m_BuyButtonURTemplate;

		private List<BuyButtonWidget> m_ButtonWidgets;

		private BuyButtonWidget.Context m_ButtonCtx;

		public Action<PriceContext> onClickedCallback;

		public List<BuyButtonWidget> buttonWidgets => null;

		public BuyButtonGroupWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Binding(ProductContext productData, TextGroupLoadHolder textGroupLoadHolder)
		{
		}

		private BuyButtonWidget InsertButton(int buttonType, int priceId)
		{
			return null;
		}
	}
}
