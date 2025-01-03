using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.GetHistory
{
	public class GetHistoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string BTN_BTNL_LABEL;

		private readonly string BTN_BTNR_LABEL;

		private readonly string TEXT_TITLE_LABEL;

		private readonly string CONTENT_LABEL;

		private readonly string TEXT_PAGEINDEX_LABEL;

		private readonly string TEXT_CAUTION_LABEL;

		private readonly string TEMPLATE_LABEL;

		private readonly string TEMPLATE_CONS_LABEL;

		private readonly string TEMPLATE_ADD_LABEL;

		private readonly string TEMPLATE_EXPIRE_LABEL;

		private readonly string TEXTS_LIMITEDPAID_LABEL;

		private readonly string TEXTS_LIMITEDFREE_LABEL;

		private readonly string TEXTS_HAVEFREE_LABEL;

		private readonly string TEXTS_HAVEPAID_LABEL;

		private readonly string TEXT_EMPTYHISTORY_LABEL;

		protected ElementObjectManager m_templateEOM;

		protected ElementObjectManager m_templateConsEOM;

		protected ElementObjectManager m_templateAddEOM;

		protected ElementObjectManager m_templateExpireEOM;

		protected ElementObjectManager m_textsHaveFreeEOM;

		protected ElementObjectManager m_textsHavePaidEOM;

		protected ElementObjectManager m_textsLimitedFreeEOM;

		protected ElementObjectManager m_textsLimitedPaidEOM;

		private ExtendedTextMeshProUGUI m_titleText;

		private ExtendedTextMeshProUGUI m_cautionText;

		private ExtendedTextMeshProUGUI m_emptyText;

		private ExtendedTextMeshProUGUI m_pageText;

		protected SelectionButton m_buttonL;

		protected SelectionButton m_buttonR;

		protected int m_maxTemplatesInContent;

		protected GameObject m_contentGO;

		protected bool m_isMobile;

		protected int m_pageIndex;

		protected int m_maxPageIndex;

		protected override void OnCreatedView()
		{
		}

		protected void SetTitleText(string title)
		{
		}

		protected void SetEmptyText(string emptyText)
		{
		}

		protected void SetCautionText(string cautionText)
		{
		}

		protected void SetButtonRCallBack(UnityAction ButtonRCallBack)
		{
		}

		protected void SetButtonLCallBack(UnityAction ButtonLCallBack)
		{
		}

		protected void UpdateFooter()
		{
		}

		private void UpdateButtonStatus()
		{
		}

		protected void SetPageIndexText()
		{
		}

		private void CleanView()
		{
		}
	}
}
