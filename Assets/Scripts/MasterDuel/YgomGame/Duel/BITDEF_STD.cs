namespace YgomGame.Duel
{
	internal static class BITDEF_STD
	{
		public const int SHIFT_PLAYERIDC = 0;

		public const int SHIFT_TURN = 32;

		public const int SHIFT_PLAYERIDL = 0;

		public const int SHIFT_PLAYERIDR = 16;

		public const uint BYTEMASK = 255u;

		public const uint SHORTMASK = 65535u;

		public const uint INTMASK = uint.MaxValue;

		public static void SetBitData(ref ulong bitdata, int value, int shift)
		{
		}

		public static void SetBitData(ref uint bitdata, int value, int shift)
		{
		}

		public static byte GetByteData(ulong bitdata, int shift)
		{
			return 0;
		}

		public static short GetShortData(ulong bitdata, int shift)
		{
			return 0;
		}

		public static byte GetByteData(uint bitdata, int shift)
		{
			return 0;
		}

		public static short GetShortData(uint bitdata, int shift)
		{
			return 0;
		}

		public static int GetIntData(ulong bitdata, int shift)
		{
			return 0;
		}
	}
}
