namespace YgomGame.Duel
{
	public class EffectTaskCutinSummon : EffectTask
	{
		private enum Step
		{
			Start = 0,
			Wait = 1,
			Finish = 2
		}

		private Engine.CutinSummonType summonType;

		private bool waitEffect;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskCutinSummon(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void FinishStep()
		{
		}
	}
}
