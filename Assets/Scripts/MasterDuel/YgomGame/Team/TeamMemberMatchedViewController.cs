using System;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomGame.Team
{
	public class TeamMemberMatchedViewController : BaseMenuViewController, IBokeSupported
	{
		private const string k_ArgKeyCallback = "callback";

		private readonly string E_BG3D;

		private readonly string E_BackShortcutButton;

		private readonly string E_ButtonSkip;

		private readonly string E_RootMatched;

		private readonly string E_Root;

		private readonly string E_Text;

		private GameObject m_View3D;

		private ElementObjectManager m_TargetEom;

		private bool b_IsFinish;

		private bool b_IsSkip;

		private int m_LoadingEffectCount;

		private bool IsLoadingEffect => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public static void Open(Action callback = null)
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
	}
}
