namespace YgomGame.Duel
{
	public class Evaluator
	{
		public static bool MaybeFinishingBlow(int player)
		{
			return false;
		}

		public static bool MaybeLastAttack(int player, int srcLocate, int dstLocate)
		{
			return false;
		}

		private static bool MaybeLastAttackImpl(int player, int srcLocate, int dstLocate)
		{
			return false;
		}

		public static int GetMaxDamage(int turnPlayer)
		{
			return 0;
		}

		public static int GetTotalAtk(int player)
		{
			return 0;
		}
	}
}
