namespace YgomGame.Duel
{
	public class EffectTaskRunSummon : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitSummon = 1
		}

		private bool finished;

		private Step step;

		private Engine.CardStatus st;

		private CardRoot cardRoot;

		private bool camMoved;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskRunSummon(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override void OnDestroy()
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardMoveStep()
		{
		}

		private void WaitSummonStep()
		{
		}
	}
}
