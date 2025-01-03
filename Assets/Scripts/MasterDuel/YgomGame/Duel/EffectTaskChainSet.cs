namespace YgomGame.Duel
{
	public class EffectTaskChainSet : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitChainEffect = 1,
			Finish = 2
		}

		private Step step;

		private bool finished;

		private int player;

		private int position;

		private int num;

		private int uniqueID;

		public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
		{
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskChainSet(RunEffectWorker worker, int param1, int param2, int param3)
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

		private void FinishStep()
		{
		}
	}
}
