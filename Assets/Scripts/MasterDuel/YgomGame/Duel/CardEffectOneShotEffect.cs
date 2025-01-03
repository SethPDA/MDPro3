using UnityEngine;

namespace YgomGame.Duel
{
	public class CardEffectOneShotEffect : CardEffectBase
	{
		public enum Mode
		{
			TraceRootPosition = 0,
			TraceRootPosture = 1,
			TraceCardPosition = 2,
			TraceCardPosture = 3,
			Child = 4
		}

		protected DuelEffectPool.Type type;

		protected bool waitEffect;

		protected Mode mode;

		protected Quaternion rotation;

		protected SimpleEffect effect;

		public static CardEffectOneShotEffect Create(CardRoot cardRoot, DuelEffectPool.Type type, Mode mode, bool waitEffect, Quaternion rotation)
		{
			return null;
		}

		public override void StartEffect()
		{
		}
	}
}
