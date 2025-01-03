using System;

namespace YgomGame.Duel
{
	public class CardEffectWait : CardEffectBase
	{
		private Func<bool> waitFunc;

		public static CardEffectWait Create(Func<bool> waitFunc)
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
