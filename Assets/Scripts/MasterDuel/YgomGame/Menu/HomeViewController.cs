using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Home;
using YgomGame.MDMarkup;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu
{
	public class HomeViewController : BaseMenuViewController, ICommonHeaderSupported, IGemSupported, IConfigButtonSupported, IFadeSupported, IHeaderFocusListener
	{
		private class TopicsContext
		{
			private List<MDMarkupBannerContext> m_MMABannerContexts;

			private List<string> m_MMAPageBodies;

			private MDMarkupPagerContainer m_MMAPagerContainer;

			private bool m_MMAPagerDirty;

			public List<MDMarkupBannerContext> mmaBannerContexts => null;

			public void Import(List<object> topicList)
			{
			}

			public MDMarkupPagerContainer CreateOrReuseMMAPagerContainer()
			{
				return null;
			}

			public string GetButtonUrl(int index)
			{
				return null;
			}
		}

		public const string PREFAB_PATH = "Home/Home";

		private readonly string BANNER_LABEL;

		private readonly string BTN_BANNER_LABEL;

		private readonly string BTN_NEXT_LABEL;

		private readonly string BTN_PREV_LABEL;

		private readonly string SCROLL_LABEL;

		private readonly string TEMPLATE_LABEL;

		private readonly string BTN_QUEST_LABEL;

		private readonly string BTN_SHOP_LABEL;

		private readonly string BTN_DECK_LABEL;

		private readonly string BTN_DUEL_LABEL;

		private readonly string BTN_PLAYER_LABEL;

		private readonly string BTN_DUELPASS_LABEL;

		private readonly string IMG_LEVEL_LABEL;

		private readonly string IMG_RANK_LABEL;

		private readonly string IMG_ICON_LABEL;

		private readonly string PLATFORM_NAME_LABEL;

		private readonly string TXT_LEVEL_LABEL;

		private readonly string ROOT_MENU_LABEL;

		private readonly string ROOT_MENU_MOBILE_LABEL;

		private readonly string ROOT_WALLPAPER_LABEL;

		private readonly string WALLPAPER_LABEL;

		private readonly string ROOT_PAGE_LABEL;

		private readonly string ROOT_INDICATOR_LABEL;

		private readonly string BTN_BACKKEYSHORTCUT_LABEL;

		private readonly string BTN_TOPICSLIST_LABEL;

		private readonly string E_SpecialBanner;

		private readonly string E_Image;

		private readonly string homeBGMLabel;

		private List<GameObject> topicPages;

		private float pastSecTopics;

		private float pastSecEventNotify;

		private int currentWallpaperID;

		private GameObject currentWallpaperGo;

		private bool isFirstFade;

		private bool shouldCallAPIHome;

		private bool calledPlayHomeAction;

		private HomeBadge homeBadge;

		private readonly HomePopIconWidget popIconWidget;

		private ElementObjectManager menuBtnEom;

		private SlidePagerWidget slidePagerWidget;

		private List<HomeAction> actionList;

		private TopicsContext m_TopicsContext;

		private int roomId;

		private bool isInviteRoom;

		private int teamId;

		private bool isInviteTeam;

		private bool isStackWcsBG;

		protected override Type[] textIds => null;

		public static bool PushOnHomeViewControler(string prefabname, Dictionary<string, object> args = null)
		{
			return false;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		public void OnHeaderFocusChanged(bool setfocus, ViewController focusVc, ViewController prevVc)
		{
		}

		public Color FadeColor(TransitionType type)
		{
			return default(Color);
		}

		public SystemProgress.ProgressType FadeType(TransitionType type)
		{
			return default(SystemProgress.ProgressType);
		}

		private bool IsReadyPlayHomeAction()
		{
			return false;
		}

		private void PlayHomeAction()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void AddInputCallback(SelectionButton button, PadInputDirection direction, SelectionButton target, SelectionButton failedTarget)
		{
		}

		private void OnCreatedAction()
		{
		}

		private void InvitePlatform()
		{
		}

		private void InviteRoomNotificator(object mes)
		{
		}

		private void InviteTeamNotificator(object mes)
		{
		}

		private void CheckParticipationConfirm()
		{
		}

		private void CheckLoginBonus()
		{
		}

		private void CheckForceNotification()
		{
		}

		private void UpdateHome()
		{
		}

		private void UpdateDuelpass()
		{
		}

		private void UpdateWcsf()
		{
		}

		private void InitPopIcons()
		{
		}

		private void UpdatePopIcons()
		{
		}

		private void OpenTopicsList()
		{
		}

		private void SetTopicsData(List<object> topicsList)
		{
		}

		private void SetTopicsButton()
		{
		}

		private GameObject CreateTopics(MDMarkupBannerContext context)
		{
			return null;
		}

		private void UpdateWallpaper()
		{
		}

		private void UpdateWcsBG(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private void UpdateEventNotify()
		{
		}

		private void InitBadgeSettings()
		{
		}

		private void UpdateBadge()
		{
		}

		private void CallAPIUserHome(Action onSuccessed = null)
		{
		}

		private void CallAPIEventNotifyGetList(Action onFinished = null)
		{
		}

		private void CallAPINotificationRead(int id, Action onFinish = null)
		{
		}

		private void CallAPIRoomEntry(int invitedRoomId, Action onFinish = null)
		{
		}

		private Handle APIRoomEntry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
		{
			return null;
		}

		private void CallAPILoginBonusGetList(Action onFinish = null)
		{
		}

		private void CallAPIWcsGetParticipation(Action onFinished = null)
		{
		}
	}
}
