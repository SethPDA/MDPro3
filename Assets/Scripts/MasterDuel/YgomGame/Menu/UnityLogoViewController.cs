using UnityEngine;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class UnityLogoViewController : TweenViewController
	{
		private enum Step
		{
			Init = 0,
			StartFade = 1,
			LogoIn = 2,
			LogoStay = 3,
			LogoOut = 4,
			EndFade = 5,
			Finish = 6
		}

		private enum ConnectionStatus
		{
			None = 0,
			Connecting = 1,
			Success = 2,
			Failed = 3
		}

		private static bool s_enableUnityLogoSkip;

		private const float UnityLogoDelayTime = 2f;

		[SerializeField]
		private ElementObjectManager prefabUI;

		private ElementObjectManager m_ui;

		private StepSequencer m_sequencer;

		private float m_UnityLogoDispTime;

		private bool m_UnityLogoSkip;

		private void Awake()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void Update()
		{
		}

		private void stepInit(StepSequencer seq)
		{
		}

		private void stepTweenPlay(StepSequencer seq, string tweenLabel, Step nextStep)
		{
		}

		private void stepLogoStay(StepSequencer seq)
		{
		}

		private void stepFinish(StepSequencer seq)
		{
		}
	}
}
