namespace YgomGame.Duel
{
	public class EffectTaskChainEnd : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitTutorial = 1,
			Finish = 2
		}

		private bool finished;

		private Step step;

		public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
		{
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskChainEnd(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardEffectStep()
		{
		}

		private void OnFinishChainEffect()
		{
		}

		private void FinishStep()
		{
		}
	}
}
