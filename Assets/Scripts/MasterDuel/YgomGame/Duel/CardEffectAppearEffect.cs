using System;

namespace YgomGame.Duel
{
	public class CardEffectAppearEffect : CardEffectBase
	{
		private bool isToken;

		private bool waitEffect;

		private Action onEffectFinished;

		public static CardEffectAppearEffect Create(CardRoot cardRoot, bool isToken, bool waitEffect, Action onEffectFinished)
		{
			return null;
		}

		public override void StartEffect()
		{
		}
	}
}
