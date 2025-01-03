namespace YgomGame.Duel
{
	public class EffectTaskRunSpecialWin : EffectTask
	{
		private enum Step
		{
			Wait = 0,
			Finish = 1
		}

		private Step step;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskRunSpecialWin(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}
	}
}
