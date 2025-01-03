using System.Collections.Generic;
using YgomSystem;

namespace YgomGame.Duel
{
	public static class DuelHapticsUtil
	{
		public enum Type
		{
			None = 0,
			MonsterCutin = 1,
			LandingMiddle = 2,
			LandingHigh = 3,
			CardBreak = 4,
			AttackLow = 5,
			AttackHigh = 6,
			DirectAttack = 7,
			EffectDamage = 8,
			BgBreak = 9,
			LethalEffect = 10
		}

		private static Dictionary<Type, GamePad.VIBRATION> intensityList;

		public static void SetVibrateFlag(bool enable)
		{
		}

		public static void Vibrate(Type type)
		{
		}
	}
}
