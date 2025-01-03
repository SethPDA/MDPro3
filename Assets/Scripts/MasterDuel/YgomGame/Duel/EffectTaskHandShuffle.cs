namespace YgomGame.Duel
{
	public class EffectTaskHandShuffle : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitShuffle = 1
		}

		private bool finished;

		private Step step;

		private int team;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskHandShuffle(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardMoveStep()
		{
		}
	}
}
