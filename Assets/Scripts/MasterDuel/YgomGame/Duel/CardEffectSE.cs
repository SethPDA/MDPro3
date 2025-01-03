namespace YgomGame.Duel
{
	public class CardEffectSE : CardEffectBase
	{
		private string seLabel;

		private bool play;

		private bool is3D;

		public static CardEffectSE CreatePlay(CardRoot cardRoot, string seLabel, bool is3D)
		{
			return null;
		}

		public static CardEffectSE CreateStop(CardRoot cardRoot, string seLabel)
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
