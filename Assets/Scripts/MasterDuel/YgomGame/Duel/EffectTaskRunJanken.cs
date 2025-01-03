namespace YgomGame.Duel
{
	public class EffectTaskRunJanken : EffectTask
	{
		private enum HandType
		{
			Rock = 0,
			Scissors = 1,
			Paper = 2,
			Num = 3
		}

		private enum Result
		{
			Win = 0,
			Lose = 1,
			Draw = 2
		}

		private bool finished;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskRunJanken(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private Result Janken(HandType handMyself, HandType handRival)
		{
			return default(Result);
		}
	}
}
