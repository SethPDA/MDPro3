namespace YgomGame.Duel
{
	public class EffectTaskLifeSet : EffectTask
	{
		private enum Step
		{
			WaitCardEffectToBreakAllCards = 0,
			WaitBreakAllCards = 1,
			Finish = 2
		}

		private Step step;

		private int team;

		private bool isLethal;

		public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
		{
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskLifeSet(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}
	}
}
