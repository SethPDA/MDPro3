using System;

namespace YgomGame.Duel
{
	public class CardEffectMove : CardEffectBase
	{
		private CardLocator from;

		private CardLocator to;

		private bool isFace;

		private bool isAttack;

		private bool immediate;

		private bool firstUpdate;

		private CardRootTransition transition;

		private Action onStarted;

		private bool finishFlipTurn;

		public static CardEffectMove Create(CardRoot cardRoot, CardLocator from, CardLocator to, bool isFace, bool isAttack, bool immediate, CardRootTransition transition, Action onStarted, Action onFinished)
		{
			return null;
		}

		public static CardEffectMove CreateFlipTurn(CardRoot cardRoot, bool isFace, bool isAttack, bool immediate, Action onStarted, Action onFinished)
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
