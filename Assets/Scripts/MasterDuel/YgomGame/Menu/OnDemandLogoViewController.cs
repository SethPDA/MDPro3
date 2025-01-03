using System;
using System.Collections;
using YgomSystem;

namespace YgomGame.Menu
{
	public class OnDemandLogoViewController : BaseMenuViewController
	{
		private enum Step
		{
			Loading = 0,
			StartFade = 1,
			LogoIn = 2,
			LogoStay = 3,
			LogoOut = 4,
			EndFade = 5,
			Finish = 6
		}

		private const float LogoDelayTime = 1.5f;

		private StepSequencer m_sequencer;

		private OnDemandLogoData m_logoData;

		private float m_logoDispTime;

		private bool m_skipLogo;

		private Action m_resultCallback;

		private static void debugLog(string msg)
		{
		}

		private static void timeLog(string msg)
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

		private void Update()
		{
		}

		private IEnumerator stepLoading(StepSequencer seq)
		{
			return null;
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
