namespace YgomGame.Duel
{
	public class EffectTaskDuelEnd : EffectTask
	{
		private Engine.ResultType exactResultType;

		private Engine.ResultType resultType;

		private Engine.FinishType finishType;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskDuelEnd(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}
	}
}
