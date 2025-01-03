using UnityEngine;

namespace YgomGame.Duel
{
	public class CardRootTransitionShuffle : CardRootTransitionTimeBase
	{
		private enum Step
		{
			GoCenter = 0,
			WaitPause = 1,
			GoToLocator = 2,
			Finish = 3
		}

		private Vector3 pausePos;

		private Step step;

		private const float timeToMove1 = 0f;

		private const float timeToPause = 0.3f;

		private const float timeToMove2 = 0.7f;

		private const float timeOfEnd = 1f;

		public CardRootTransitionShuffle(Vector3 pausePos)
		{
		}

		protected override void UpdateTransition(float t)
		{
		}
	}
}
