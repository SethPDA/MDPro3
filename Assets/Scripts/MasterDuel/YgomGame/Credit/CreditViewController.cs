using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomGame.Credit
{
	public class CreditViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string BTN_BACK_SHORTCUT_LABEL;

		private readonly string CREDIT_LIST_LABEL;

		private readonly string ENECONWIDGET_LABEL;

		private readonly string TEXT_GROUPNAME_LABEL;

		private readonly string TEXT_POSITIONNAME_LABEL;

		private readonly string TEXT_NAME_LABEL;

		private readonly string TEXT_NAMEFONTCHANGED_LABEL;

		private readonly string TEXT_NAMEFONTCHANGED2_LABEL;

		private readonly string TEXT_POSITIONNAMEFONTCHANGED_LABEL;

		private readonly string TEXT_GROUPNAMEFONTCHANGED_LABEL;

		private readonly string TEXT_NAME2_LABEL;

		private readonly string TEMPLATE_SPACERM_LABEL;

		private readonly string TEMPLATE_GROUP_LABEL;

		private readonly string TEMPLATE_NAMEONLY_LABEL;

		private readonly string CONTENT_LABEL;

		private readonly string OBJ_MATE_LABEL;

		private readonly string TLABEL_MATEIN;

		private readonly string TLABEL_FONTCHANGE;

		private InfinityScrollView m_infinityScrollView;

		private ExtendedScrollRect m_extendedScrollRect;

		private List<int> m_templates;

		private readonly int k_GroupTNo;

		private readonly int k_PositionAndNameTNo;

		private readonly int k_NameOnlyTNo;

		private readonly int k_Member2TNo;

		private readonly int k_SpacerSTNo;

		private readonly int k_SpacerMTNo;

		private readonly int k_SpacerLTNo;

		private float m_scrollSpeed;

		private bool m_mateIsActive;

		private bool isFontChanged;

		private CreditBGTimeline m_creditBGTimeline;

		private CreditEneconWidget m_eneconWidget;

		private bool isStarted;

		private bool isEnd;

		private List<CreditInfo> m_creditInfoList;

		private int presentedCounter;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		private void OnBackCommand()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		protected override void OnCreatedView()
		{
		}

		private void OnKonamiCommandResultCallback(KeyCommand.OnKeyResult result)
		{
		}

		private void OnEneconBreakResultCallback(KeyCommand.OnKeyResult result)
		{
		}

		private void OnEneconReleaseResultCallback(KeyCommand.OnKeyResult result)
		{
		}

		private void Update()
		{
		}

		public void OnCreditTemplateSetData(GameObject gob, int dataindex)
		{
		}

		private void LoadInfoFromScriptableObject(UnityAction callBack)
		{
		}
	}
}
