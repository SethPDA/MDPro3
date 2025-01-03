using UnityEngine;

namespace YgomGame.Duel
{
	public class CardRootTransitionBezieMotion : CardRootTransitionTimeBase
	{
		private ChainedBezierMotion motion;

		private Camera camera;

		protected override float dulation => 0f;

		public CardRootTransitionBezieMotion(BezierMotionSetting[] motion, Camera camera)
		{
		}

		public CardRootTransitionBezieMotion(BezierMotionSetting motion, Camera camera)
		{
		}

		public override void SetCardLocator(CardLocator fromLocator, CardLocator toLocator)
		{
		}

		protected override void UpdateTransition(float t)
		{
		}
	}
}
