namespace YgomGame.Duel
{
	public class EffectTaskChainRun : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitChainEffect = 1,
			Finish = 2
		}

		private Step step;

		private bool finished;

		private int num;

		public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
		{
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskChainRun(RunEffectWorker worker, int param1, int param2, int param3)
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

		private void WaitChainEffectStep()
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
