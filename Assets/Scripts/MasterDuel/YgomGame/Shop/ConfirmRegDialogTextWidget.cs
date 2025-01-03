using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.Shop
{
	public class ConfirmRegDialogTextWidget : ContentWidgetBase<ConfirmRegDialogTextWidget, EntryInsertWidgetData>, IContentWidgetDirectionalInputListener
	{
		public const string k_FormatProductName = "product_name";

		public const string k_FormatProductNumPaidGem = "product_num_paid_gem";

		public const string k_FormatProductNumFreeGem = "product_num_free_gem";

		public const string k_FormatProductNum = "product_num";

		public const string k_FormatProductPrice = "price";

		public const string k_FormatProductDoubleNotationPrice = "doubleNotationPrice";

		public const string k_FormatProductPriceLabel = "price_label";

		public const string k_FormatProductLimitdateTs = "limitdate_ts";

		public const string k_FormatProductLimitdate = "limitdate";

		public const string k_FormatProductLimitBuyCount = "limit_buy_count";

		public const string k_FormatProductTypeName = "product_type_name";

		//private ScrollRect m_ScrollRect;

		private ElementObjectManager m_HeaderGroupTemplate;

		private ElementObjectManager m_TextTemplate;

		private List<object> m_FormatParamSearcher;

		public static ConfirmRegDialogTextWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void InsertContents(List<object> confirmRegDatas, TextGroupLoadHolder textGruopLoadHolder, Func<string, object> paramFormatFunc)
		{
		}

		protected override void InnerBinding(EntryInsertWidgetData entryData)
		{
		}

		private void InsertHeader(Dictionary<string, object> line)
		{
		}

		private void InsertBody(Dictionary<string, object> line, TextGroupLoadHolder textGruopLoadHolder, Func<string, object> paramFormatFunc)
		{
		}

		public void OnMainAnalogInput(Vector2 dir)
		{
		}

		public void OnSubAnalogInput(Vector2 dir)
		{
		}

		public void OnLeftInput()
		{
		}

		public void OnRightInput()
		{
		}

		public void OnUpInput()
		{
		}

		public void OnDownInput()
		{
		}

		public ConfirmRegDialogTextWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
