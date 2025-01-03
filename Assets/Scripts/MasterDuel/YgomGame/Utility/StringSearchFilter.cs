namespace YgomGame.Utility
{
	public static class StringSearchFilter
	{
		private const int HAN_SPACE = 32;

		private const int HAN_YEN = 92;

		private const int HAN_ALPHA_START = 33;

		private const int HAN_ALPHA_END = 126;

		private const int ZEN_SPACE = 12288;

		private const int ZEN_YEN = 65509;

		private const int ZEN_ALPHA_START = 65281;

		private const int ZEN_ALPHA_OFFSET = 65248;

		private const int HIRA_START = 12352;

		private const int HIRA_END = 12442;

		private const int KATA_START = 12448;

		private const int KATA_OFFSET = 96;

		private const int ZAL_START = 65313;

		private const int ZAL_END = 65338;

		private const int ZAS_START = 65345;

		private const int ZAS_OFFSET = 32;

		public static bool SplitFilter(string keywordStr, string sourceStr)
		{
			return false;
		}

		public static string convertSearchText(string src)
		{
			return null;
		}

		private static string toZenkaku(string src)
		{
			return null;
		}

		private static string toKatakana_Komoji(string src)
		{
			return null;
		}
	}
}
