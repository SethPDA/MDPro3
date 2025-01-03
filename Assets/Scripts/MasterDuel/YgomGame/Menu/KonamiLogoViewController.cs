using System.Collections;
using YgomSystem;

namespace YgomGame.Menu
{
	public class KonamiLogoViewController : BaseMenuViewController
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

		private const float KonamiLogoDelayTime = 2f;

		private StepSequencer m_sequencer;

		private float m_KonamiLogoDispTime;

		private bool m_KonamiLogoSkip;

		private void debugLog(string msg)
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

		private void stepInit(StepSequencer seq)
		{
		}

		private void stepTweenPlay(StepSequencer seq, string tweenLabel, Step nextStep)
		{
		}

		private void stepLogoStay(StepSequencer seq)
		{
		}

		private IEnumerator stepFinish(StepSequencer seq)
		{
			return null;
		}
	}
}
