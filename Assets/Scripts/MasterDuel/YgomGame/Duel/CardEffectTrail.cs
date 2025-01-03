namespace YgomGame.Duel
{
	public class CardEffectTrail : CardEffectBase
	{
		private bool show;

		private DuelEffectPool.Type trailType;

		private bool persistentVision;

		public static CardEffectTrail Create(CardRoot cardRoot, CardPlane.MoveTrailType trailType, bool persistentVision)
		{
			return null;
		}

		public static CardEffectTrail CreateShowTrail(CardRoot cardRoot, DuelEffectPool.Type type, bool persistentVision)
		{
			return null;
		}

		public static CardEffectTrail CreateHideTrail(CardRoot cardRoot)
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
