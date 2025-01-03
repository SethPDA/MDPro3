namespace YgomGame.Duel
{
	public class EffectTaskDeckShuffle : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitFinish = 1,
			Finished = 2
		}

		private bool finished;

		private Step step;

		private DeckCardPlace deckPlace;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskDeckShuffle(RunEffectWorker worker, int param1, int param2, int param3)
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

		private void FinishedStep()
		{
		}
	}
}
