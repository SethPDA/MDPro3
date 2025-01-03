using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.GemShop
{
	public class ProductWidget : ElementWidgetBase
	{
		public class ItemWidget : ElementWidgetBase
		{
			private readonly string k_ELabelItemNumText;

			public TMP_Text itemNumText => null;

			public ItemWidget(ElementObjectManager eom)
				: base(null)
			{
			}
		}

		private readonly string k_ELabelProductName;

		private readonly string k_ELabelPriceLabel;

		private readonly string k_ELabelDoubleNotationPriceGroup;

		private readonly string k_ELabelDoubleNotationPriceLabel;

		private readonly string k_ELabelGemShopIcon;

		private readonly string k_ELabelPaidGemItem;

		private readonly string k_ELabelFreeGemItem;

		private readonly string k_ELabelLimitRoot;

		private readonly string k_ELabelLimitText;

		private readonly string k_ELabelLimitDateRoot;

		private readonly string k_ELabelLimitDateText;

		private readonly string k_ELabelButton;

		private readonly string k_ELabelTweenDefault;

		private readonly string k_ELabelTweenHighlight;

		private Dictionary<int, ItemWidget> m_ItemWidgetMap;

		public int idx;

		public Action<ProductWidget> onClickCallback;

		public TMP_Text productName => null;

		public TMP_Text priceLabel => null;

		public GameObject doubleNotationPriceGroup => null;

		public TMP_Text doubleNotationPriceLabel => null;

		public BindingGemShopIcon gemShopIcon => null;

		public GameObject limitCountRoot => null;

		public TMP_Text limitCountText => null;

		public GameObject limitDateRoot => null;

		public TMP_Text limitDateText => null;

		public SelectionButton button => null;

		public IReadOnlyDictionary<int, ItemWidget> itemWidgetMap => null;

		public ProductWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetStyle(ProductStyle productStyle)
		{
		}

		private void OnClick()
		{
		}
	}
}
