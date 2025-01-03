namespace YgomGame.Duel
{
	public class EffectTaskPhaseChange : EffectTask
	{
		private enum Step
		{
			Tutorial = 0,
			WaitEffect = 1,
			Finish = 2
		}

		private int player;

		private Engine.Phase phase;

		private Step step;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskPhaseChange(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		private void PlayPhaseChangeEffect()
		{
		}

		public override bool Update()
		{
			return false;
		}
	}
}
