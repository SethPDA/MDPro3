using UnityEngine;

namespace YgomGame.Duel
{
	public class CardRootTransitionArc : CardRootTransitionTimeBase
	{
		private float time;

		private Vector3 viaPos;

		private float p1;

		private float p2;

		private float p3;

		private float dulVal;

		protected override float dulation => 0f;

		public CardRootTransitionArc(Vector3 viaPos, float p1, float p2, float p3, float dulVal)
		{
		}

		protected override void UpdateTransition(float t)
		{
		}
	}
}
