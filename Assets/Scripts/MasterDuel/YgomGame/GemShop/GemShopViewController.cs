using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Billing;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.GemShop
{
	public class GemShopViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		private readonly string k_ELabelProductList;

		private readonly string k_ELabelDoubleNotationPriceRate;

		private readonly string k_ELabelServiceInfoButton;

		private readonly string k_ELabelGemGetHistoryButton;

		private readonly string k_ELabelCautionButton;

		private readonly string k_ELabelProductEmptyText;

		private readonly string k_ELabelServiceInfoText;

		private readonly string k_ALabelConfirmRegDialogTextWidget;

		private readonly string k_PLabelDoubleNotationLabel;

		private readonly string k_PLabelDoubleNotationConfirmFormat;

		private string m_DoubleNotationRateLabel;

		private string m_DoubleNotationRateFormatLabel;

		private Dictionary<GameObject, ProductWidget> m_EntityWidgetMap;

		private List<ProductContext> m_ProductContexts;

		private JsonGemShopAnalyzer m_JsonGemShopAnalyzer;

		private InfinityScrollView m_ScrollView;

		private TMP_Text m_ServiceInfo;

		private string m_CautionHelpPath;

		protected override Type[] textIds => null;

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		public static void Open()
		{
		}

		public static void OpenOnHome()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnCreatedEntity(GameObject entity)
		{
		}

		private void OnUpdateEntity(GameObject entity, int idx)
		{
		}

		private void ImportProducts()
		{
		}

		private void RefreshView(bool import = true)
		{
		}

		private void OnClickServiceInfo()
		{
		}

		private void OnClickGemHistory()
		{
		}

		private void OnClickCaution()
		{
		}

		private void OnClickProductWidget(ProductWidget productWidget)
		{
		}

		private void OpenConfirmRegDialog(int shopPaidId, ProductContext productContext, IReadOnlyDictionary<string, object> productData, List<object> confirmRegDatas)
		{
		}

		private void ProcessBuyItem(int shopPaidId, IReadOnlyDictionary<string, object> productData)
		{
		}

		private void BuyResultSequence(int step, ResultCode resultCode, string resultTitle, string resultMessage)
		{
		}
	}
}
