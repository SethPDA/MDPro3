using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.SubMenu
{
	public abstract class SubMenuViewController : BaseBlurOverlayViewController
	{
		public enum Badge
		{
			DEFAULT = 0,
			WCS_CONFIRM = 1,
			WCS_DECK_REGIST = 2
		}

		private readonly string BTN_MASK_LABEL;

		private readonly string TITLE_TEXT_LABEL;

		private readonly string TITLE_TEMPLATE_LABEL;

		private readonly string ITEM_TEMPLATE_LABEL;

		private readonly string ITEM_TEXT_LABEL;

		private readonly string MENU_LIST_LABEL;

		private readonly string IMG_NUMBADGE_LABEL;

		private readonly string IMG_NEWBADGE_LABEL;

		private readonly string TXT_BADGE_LABEL;

		private Dictionary<Badge, int> badgeNumDic;

		private Dictionary<string, Badge> badgeTextDic;

		private Dictionary<int, string> menuMap;

		private InfinityScrollView m_InfinityScrollView;

		private List<int> m_Templates;

		private List<string> m_Texts;

		private readonly int k_TitleTNo;

		private readonly int k_ItemTNo;

		private readonly int k_SpacerNo;

		private List<string> m_SoundLabelsClick;

		private List<UnityAction> m_ClickCallBacks;

		private float delayFactor;

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected void SetBadgeData()
		{
		}

		protected void SetTitleText(string str)
		{
		}

		protected void AddTitleItem(string text)
		{
		}

		protected void AddMenuItem(string text, UnityAction clickCallback, string onclickSL = null, Badge badgeType = Badge.DEFAULT)
		{
		}

		private void OnMenuItemSetData(GameObject gob, int dataindex)
		{
		}

		public void SetBadge(GameObject gom, int count = 0)
		{
		}

		private bool IsSelectableDataIndex(int dataindex)
		{
			return false;
		}

		public static void OpenLicense()
		{
		}

		public void AddHelpButton()
		{
		}

		public void AddInquiryButton()
		{
		}

		private void OpenInquirySheet()
		{
		}

		public static void OpenUserRegulationSheet(string title, bool fromHome = false)
		{
		}
	}
}
