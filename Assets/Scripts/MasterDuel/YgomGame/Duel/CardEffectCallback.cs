using System;

namespace YgomGame.Duel
{
	public class CardEffectCallback : CardEffectBase
	{
		private float delay;

		private float currentTime;

		public static CardEffectCallback Create(CardRoot cardRoot, float delay, Action onFinished)
		{
			return null;
		}

		public override void StartEffect()
		{
		}

		public override bool UpdateEffect()
		{
			return false;
		}
	}
}
