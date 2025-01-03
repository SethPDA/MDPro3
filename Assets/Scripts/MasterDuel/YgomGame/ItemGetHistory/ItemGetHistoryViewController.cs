using System;
using System.Collections.Generic;
using YgomGame.GetHistory;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomGame.ItemGetHistory
{
	public class ItemGetHistoryViewController : GetHistoryViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string TEXT_GETDATE_LABEL;

		private readonly string TEXT_ITEMNAME_LABEL;

		private readonly string TEXT_GETREASON_LABEL;

		private readonly string TEXT_LIMITDATE_LABEL;

		private readonly string KEY_ITEM_ID;

		private readonly string KEY_REASON;

		private readonly string KEY_CATEGORY;

		private readonly string KEY_GETDATE;

		private readonly string KEY_LIMITDATE;

		private readonly string KEY_NUM;

		private readonly string KEY_PERIODITEMFLAG;

		private List<object> m_itemGetHistory;

		private List<ElementObjectManager> m_templateEOMList;

		protected override Type[] textIds => null;

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public void SetTemplate(Dictionary<string, object> dict)
		{
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

		private string GetGetReasonText(int getreason)
		{
			return null;
		}

		private string GetItemNameWithCategory(bool isPeriod, int category, int itemId)
		{
			return null;
		}
	}
}
