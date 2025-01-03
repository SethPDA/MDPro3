using System;
using System.Collections;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.DuelLive
{
	public class DuelLiveViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string k_ELabelHelpButton = "ButtonHelp";

		private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

		private const string k_ELabelShortcutButtonBack = "ShortcutButtonBack";

		private const string k_ELabelShortcutButtonCancel = "ShortcutButtonCancel";

		private const string k_ELabelShortcutButtonL1 = "ShortcutButtonL1";

		private const string k_ELabelShortcutButtonR1 = "ShortcutButtonR1";

		public const string k_ArgsLaunchMenuID = "menuId";

		public const string k_ArgsLaunchSectionID = "sectionId";

		private DuelLiveSettings m_DuelLiveSettings;

		private DuelLiveRootWidget m_RootWidget;

		private bool m_IsStarted;

		private bool m_IsHighEnd;

		private int m_PreSubTabIdx;

		private int m_PreSubTabSectionIdx;

		private bool m_OnChangedSubTabIdxFocusBlocker;

		private bool m_ProductListScrollCheckBlocker;

		protected override bool setProgressOnInitialize => false;

		protected override bool setSurfaceActiveOnInitialize => false;

		protected override Type[] textIds => null;

		public static void Open(int menuId = 0, int sectionId = 0)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private IEnumerator yInitialize()
		{
			return null;
		}

		protected override void OnCreatedView()
		{
		}

		private void InitializeData()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void OnHelpButton()
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		private void OnInputShortcutL1()
		{
		}

		private void OnInputShortcutR1()
		{
		}

		private bool TrySelectCurrentItem()
		{
			return false;
		}

		private void OnPrechangeSubTabIdx(int preSubTabIdx, int preSubTabSectionIdx, int newSubTabIdx, int newSubTabSectionIdx)
		{
		}

		private void OnChangedSubTabIdx(int idx, int sectionIdx)
		{
		}

		private void OnClickSubCategory(int dataIdx)
		{
		}

		private void OnClickSubCategoryGroup(int dataIdx)
		{
		}

		private void OnClickSubCategorySection(int dataIdx, int sectionIdx)
		{
		}

		private void OnProductListScrolled(Vector2 value)
		{
		}

		private void OnClickProduct(ProductWidget productWidget)
		{
		}
	}
}
