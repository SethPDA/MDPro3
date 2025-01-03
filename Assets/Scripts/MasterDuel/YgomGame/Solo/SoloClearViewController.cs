using System;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Solo
{
	public class SoloClearViewController : BaseMenuViewController, IFadeSupported
	{
		public enum ClearType
		{
			RENTAL = 0,
			MYDECK = 1,
			COMPLETE = 2,
			GOAL = 3
		}

		private const string k_ArgKeyCallback = "callback";

		private const string k_ArgKeyType = "type";

		private readonly string k_ELabelBG3D;

		private readonly string k_ELabelBackShortcutButton;

		private readonly string k_ELabelButtonSkip;

		private readonly string k_ELabelRootChapter;

		private readonly string k_ELabelRootComplete;

		private readonly string k_ELabelRootGoal;

		private readonly string k_ELabelRoot;

		private readonly string IMG_CLEAR_RENTAL_LABEL;

		private readonly string IMG_BLANK_RENTAL_LABEL;

		private readonly string IMG_CLEAR_MYDECK_LABEL;

		private readonly string IMG_BLANK_MYDECK_LABEL;

		private GameObject m_View3D;

		private ElementObjectManager m_TargetEom;

		private bool b_IsFinish;

		private bool b_IsWhileTutorial;

		private bool b_IsSkip;

		private int m_LoadingEffectCount;

		private ClearType type;

		private bool IsLoadingEffect => false;

		protected override Type[] textIds => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public static void Open(ClearType type, Action callback = null)
		{
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

		public override bool OnBack()
		{
			return false;
		}

		private void Initialize()
		{
		}

		private void Play()
		{
		}

		private void PlayEffect(string effectPath)
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
	}
}
