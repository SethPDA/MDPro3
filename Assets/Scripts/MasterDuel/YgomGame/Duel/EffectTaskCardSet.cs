namespace YgomGame.Duel
{
	public class EffectTaskCardSet : EffectTask
	{
		private bool finished;

		public static EffectTask Create(RunEffectWorker workerHUD, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskCardSet(RunEffectWorker workerHUD, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}
	}
}
