using System;
using System.Collections.Generic;
using YgomGame.GetHistory;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomGame.GemGetHistory
{
	public class GemGetHistoryViewController : GetHistoryViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string TEXT_GETDATE_LABEL;

		private readonly string TEXT_NUM_LABEL;

		private readonly string TEXT_LIMITDATE_LABEL;

		private readonly string TEXT_UNUSEDGEM_LABEL;

		private readonly string TEXT_CONSDATE_LABEL;

		private readonly string TEXT_PAIDNUM_LABEL;

		private readonly string TEXT_FREENUM_LABEL;

		private readonly string TEXT_DESC_LABEL;

		private readonly string KEY_PAGEMAX;

		private readonly string KEY_ISJP;

		private readonly string KEY_NEXT_EXPIREDATE;

		private readonly string KEY_NEXT_EXPIREPOINT;

		private readonly string KEY_HISTORY;

		private readonly string KEY_FREE_POINT_LIMIT;

		private readonly string KEY_ORDERDATE;

		private readonly string KEY_EXPIREDATE;

		private readonly string KEY_ORDERTYPE_ID;

		private readonly string KEY_PAID_POINT;

		private readonly string KEY_FREE_POINT;

		private readonly string KEY_UNUSED_PAID_POINT;

		private readonly string KEY_ORDERTYPE_ADD;

		private readonly string KEY_ORDERTYPE_CONSUME;

		private readonly string KEY_ORDERTYPE_EXPIRE;

		private List<ElementObjectManager> m_templateEOMList;

		private List<object> m_historyList;

		private int m_haveFreeNum;

		private int m_havePaidNum;

		private int maxPosFreeNum;

		private const int maxPosPaidNum = 499999;

		private readonly string PATH_BILLINGHISTORY;

		protected override Type[] textIds => null;

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void SetFirstView()
		{
		}

		private void SetTemplateCons(Dictionary<string, object> dict)
		{
		}

		private void SetTemplateAdd(Dictionary<string, object> dict)
		{
		}

		private void SetTemplateExpire(Dictionary<string, object> dict)
		{
		}

		private string ToAlertStyle(string text)
		{
			return null;
		}

		private void ClearTemplates()
		{
		}

		private void UpdatePage()
		{
		}

		private void ButtonRCallBack()
		{
		}

		private void ButtonLCallBack()
		{
		}

		private void SetAllTemplates()
		{
		}
	}
}
