namespace YgomGame.Duel
{
	public class EffectTaskChainStep : EffectTask
	{
		private enum Step
		{
			Init = 0,
			WaitEffect = 1,
			Finish = 2
		}

		private Step step;

		private int mrk;

		private bool finished;

		private int player;

		private int position;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskChainStep(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void OnCardUniqueEffect()
		{
		}

		private void FinishStep()
		{
		}
	}
}
