namespace YgomGame.Duel
{
	public abstract class EffectTask
	{
		protected RunEffectWorker worker;

		public virtual bool Update()
		{
			return false;
		}

		public virtual void OnDestroy()
		{
		}

		public EffectTask(RunEffectWorker worker)
		{
		}
	}
}
