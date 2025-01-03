namespace YgomGame.Duel
{
	public abstract class CardRootTransitionTimeBase : CardRootTransition
	{
		private float time;

		protected virtual float dulation => 0f;

		protected abstract void UpdateTransition(float t);

		protected override bool OnUpdate()
		{
			return false;
		}

		protected override void OnImmediate()
		{
		}
	}
}
