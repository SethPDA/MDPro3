namespace YgomGame.Duel
{
	public class EffectTaskWaitFrame : EffectTask
	{
		private bool finished;

		private float waitTime;

		private float totalTime;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskWaitFrame(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}
	}
}
