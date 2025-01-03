namespace YgomGame.Duel
{
	public class CardEffectSummonMaterial : CardEffectBase
	{
		private SharedDefinition.SummonMaterialType type;

		public static CardEffectSummonMaterial Create(CardRoot cardRoot, SharedDefinition.SummonMaterialType type)
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
