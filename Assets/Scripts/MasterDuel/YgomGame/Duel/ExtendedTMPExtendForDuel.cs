using TMPro;

namespace YgomGame.Duel
{
	public static class ExtendedTMPExtendForDuel
	{
		public const int MAXDISPBATTLEPOWER = 99999999;

		public const int MAXDISPLIFEPOINT = 999999;

		public const int MAX2DIGITNUM = 99;

		public static void SetLifePoint(this TextMeshPro exTmp, int value, int digitnum = 0, bool coloring = false)
		{
		}

		public static void SetLifePoint(this TextMeshProUGUI exTmp, int value, int digitnum = 0, bool coloring = false)
		{
		}

		public static void Set2DigitNum(this TextMeshPro exTmp, int value, int orgvalue)
		{
		}

		public static void Set2DigitNum(this TextMeshProUGUI exTmp, int value, int orgvalue)
		{
		}

		public static void SetOverlayUnit(this TextMeshPro exTmp, int value)
		{
		}

		public static void SetOverlayUnit(this TextMeshProUGUI exTmp, int value)
		{
		}

		private static string GetLifePointStr(int value, int digitnum = 0, bool coloring = false)
		{
			return null;
		}

		private static string GetLevelRankStr(int value, int orgvalue)
		{
			return null;
		}
	}
}
