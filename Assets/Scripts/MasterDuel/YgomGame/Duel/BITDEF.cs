namespace YgomGame.Duel
{
	internal static class BITDEF
	{
		public const byte ZERO = 0;

		public const byte SHOW = 1;

		public const byte TURN = 2;

		public const byte FACE = 4;

		public const byte INSIGHT = 8;

		public const byte INDENT = 16;

		public const byte TEAM = 32;

		public const byte EXTENDINFO = 64;

		public const byte OVERLAYUNIT = 128;

		public const byte TYPE_SIDE_NONE = 0;

		public const byte TYPE_SIDE_CARD = 1;

		public const byte TYPE_SIDE_ICON = 2;

		public const byte TYPE_CENTER_ACT = 3;

		public const byte TYPE_CENTER_LPC = 4;

		public const byte TYPE_CENTER_CC = 5;

		public const byte TYPE_CENTER_DICE = 6;

		public const byte TYPE_CENTER_COIN = 7;

		public const int FRAMEIDBIAS = 16;

		public const int ICONIDMASK = 255;

		public const int EFFECTIDBIAS = 16;

		public const int EFXBEGINBIAS = 0;

		public const int EFXENDBIAS = 16;

		public const int CARDMASK = 65535;

		public const int EFXMASK = 65535;

		public static bool CheckBit_SHOW(byte src)
		{
			return false;
		}

		public static bool CheckBit_FACE(byte src)
		{
			return false;
		}

		public static bool CheckBit_INSIGHT(byte src)
		{
			return false;
		}

		public static bool CheckBit_INDENT(byte src)
		{
			return false;
		}

		public static bool CheckBit_TEAM(byte src)
		{
			return false;
		}

		public static bool CheckBit_EXTENDINFO(byte src)
		{
			return false;
		}

		public static bool CheckBit_TURN(byte src)
		{
			return false;
		}

		public static bool CheckBit_OVERLAYUNIT(byte src)
		{
			return false;
		}

		public static bool CheckBit_COINRESULT(byte src, int index)
		{
			return false;
		}
	}
}
