using System;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class DuelistCupResultViewController : BaseMenuViewController, IFadeSupported
	{
		private const string k_ArgKeyCallback = "callback";

		private const string k_ArgkeyGameMode = "gameMode";

		private readonly string k_ELabelBackShortcutButton;

		private readonly string DP_INFO_LABEL;

		private readonly string DP_INFOROOT_LABEL;

		private readonly string TW_WIN_LABEL;

		private readonly string TW_DROW_LABEL;

		private readonly string TW_LOSE_LABEL;

		private readonly string TEXT_TOTAL_DP_LABEL;

		private readonly string TEXT_ADD_DP_LABEL;

		private readonly string TEXT_STAGE_LABEL;

		private readonly string TEXT_RESULTLABEL_LABEL;

		private readonly string TEXT_WIN_LABEL;

		private readonly string TEXT_WIN_NUM_LABEL;

		private readonly string TEXT_BEFORE_DP_LABEL;

		private readonly string IMAGE_ARROW_LABEL;

		private GameObject m_View3D;

		private bool is_initialised;

		private ElementObjectManager m_TargetEom;

		private ElementObjectManager eom;

		private ElementObject bg;

		private Tween BeforeDPTextTween;

		private Tween DiffDPTextTween;

		private Tween TotalDPTextTween;

		private SelectionButton buttonBackArea;

		private Engine.ResultType resultType;

		private bool isStartTween;

		private bool isPlaySE;

		private bool ForceTweenFinished;

		private bool isPlayTween;

		private int bDP;

		private int aDP;

		private Util.GameMode gameMode;

		private string gameModePath;

		protected override Type[] textIds => null;

		private void Update()
		{
		}

		private void clickButtonBackArea()
		{
		}

		public static void Open(Util.GameMode gameMode, Action callback = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void Start()
		{
		}

		private void Play()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private void Initialize()
		{
		}

		private bool checkDuelResultType()
		{
			return false;
		}

		public Color FadeColor(TransitionType type)
		{
			return default(Color);
		}

		public SystemProgress.ProgressType FadeType(TransitionType type)
		{
			return default(SystemProgress.ProgressType);
		}
	}
}
