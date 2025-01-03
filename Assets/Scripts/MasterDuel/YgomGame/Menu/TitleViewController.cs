using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class TitleViewController : BaseMenuViewController, IFadeSupported
	{
		private enum Step
		{
			Title = 0,
			DemoStart = 1,
			GameStart = 2
		}

		private enum LayoutType
		{
			None = 0,
			LogoOnly = 1,
			LogoAndMonster = 2,
			AutoStart = 3
		}

		private StepSequencer m_sequencer;

		private bool m_autoStart;

		private float m_autoStartWaitTimer;

		private readonly string BTN_START_LABEL;

		private readonly string BTN_SETTING_LABEL;

		private readonly string BTN_DATALINK_LABEL;

		private readonly string BTN_KONAMI_LABEL;

		private readonly string BTN_BACKKEYSHORTCUT_LABEL;

		private readonly string MONSTER_WALLPAPER_LABEL;

		private readonly string ICON_PLATFORM_LABEL;

		private readonly string ICON_START_LABEL;

		private readonly string TITLELOGO_LABEL;

		private readonly string PRESSMSGTEXT_LABEL;

		private readonly string CODEVER_LABEL;

		private readonly string PLAYERID_LABEL;

		private readonly string TEXT_GAMESTART_LABEL;

		private GameObject m_currentWallpaperMonster;

		private TitleOverlayBGController m_overlayBG;

		private PlayableDirector titleLogoDirector;

		[SerializeField]
		private PlayableAsset beginTimeline;

		[SerializeField]
		private PlayableAsset fadeInTimeline;

		[SerializeField]
		private PlayableAsset fadeOutTimeline;

		private bool m_demoDataReady;

		private const float DefaultDemoStartTime = 45f;

		private float m_demoTimer;

		private bool m_demoTimerActive;

		private LayoutType m_layout;

		private static TitleViewController s_instance;

		protected override Type[] textIds => null;

		private bool isEnableAction => false;

		private static bool enablePlatformIcon => false;

		public static TitleViewController Instance => null;

		private void clickAction(Action action)
		{
		}

		private static bool isMobile()
		{
			return false;
		}

		private void OnClickStart()
		{
		}

		private void OnClickSettingMenu()
		{
		}

		private void OnClickDataLink()
		{
		}

		private void OnClickCompany()
		{
		}

		private void OnClickBackKey()
		{
		}

		private static void openMainteDialog()
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

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void stepTitle(StepSequencer seq)
		{
		}

		private void stepDemoStart(StepSequencer seq)
		{
		}

		private IEnumerator stepGameStart(StepSequencer seq)
		{
			return null;
		}

		private void PrepareLayout(LayoutType type)
		{
		}

		private bool SetTitleBGMonster()
		{
			return false;
		}

		private void PrepareOverlayBG()
		{
		}

		private void OnClickPlatformIcon()
		{
		}

		public void OpenDataLink()
		{
		}

		public void StartGame()
		{
		}

		public float GetDemoStartTime()
		{
			return 0f;
		}
	}
}
