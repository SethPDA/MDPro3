using System.Text.RegularExpressions;
using YgomGame.Card;

namespace YgomGame.Utility
{
	public class TextTagConverter
	{
		private const string tagCardRegex = "<card(.+?)/>";

		private const string mrkRegex = "mrk\\s*=\\s*'\\d{4,5}'";

		private const string getCardRegex = "get\\s*=\\s*'(name|poss|rare)'";

		private const string paramMrkRegex = "'\\d{4,5}'";

		private const string paramGetCardRegex = "'(name|poss|rare)'";

		private const string tagItemRegex = "<item(.+?)/>";

		private const string idRegex = "id\\s*=\\s*'\\d+'";

		private const string getItemRegex = "get\\s*=\\s*'(name|poss|type)'";

		private const string paramIdRegex = "'\\d+'";

		private const string paramGetItemRegex = "'(name|poss|type)'";

		private const string tagPeriodItemRegex = "<periodItem(.+?)/>";

		private const string categoryRegex = "category\\s*=\\s*'\\d+'";

		private const string tagCardPackRegex = "<cardpack(.+?)/>";

		private const string getCardPackRegex = "get\\s*=\\s*'name'";

		private const string paramGetCardPackRegex = "'name'";

		private const string idRegex2 = "id\\s*=\\s*'\\d{2}'";

		private const string idRegex3 = "id\\s*=\\s*'\\d{3}'";

		private const string tagModeRegex = "<mode(.+?)/>";

		private const string tagRankRegex = "<rank(.+?)/>";

		private const string tagTournamentRegex = "<tournament(.+?)/>";

		private const string tagExhibitionRegex = "<exhibition(.+?)/>";

		private const string tagRankEventRegex = "<(rankevent.+?)/>";

		private const string tagDuelistCupRegex = "<duelistcup(.+?)/>";

		private const string tagDuelTrialRegex = "<(dueltrial.+?)/>";

		private const string tagEventRegex = "<event(.+?)/>";

		private const string tagRarityRegex = "<rarity(.+?)/>";

		private const string tagPremiumRegex = "<prem(.+?)/>";

		private const string tagCwRegex = "<cw(.+?)/>";

		private const string pathRegex = "path\\s*=\\s*'(.+?)'";

		private const string paramRegex = "'(.+?)'";

		private const int startIdxComma = 1;

		private const int lengthComma = 2;

		private static Content cci => null;

		public static string Convert(string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static void LoadDependencieTextDatas()
		{
		}

		public static void UnloadDependencieTextDatas()
		{
		}

		private static int GetIdAsInt(string src)
		{
			return 0;
		}

		private static int GetCategoryAsInt(string src)
		{
			return 0;
		}

		private static string GetPathStr(string src)
		{
			return null;
		}

		private static void ReplaceMatch(ref string src, ref int diffIdx, Match match, string word)
		{
		}

		private static void ConvertNoBreakSpace(ref string src)
		{
		}

		private static void ConvertCardTag(ref string src)
		{
		}

		private static void ConvertItemTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertPeriodItemTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertCardPackTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertDuelModeTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertRankTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertTournamentNameTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertExhibitionNameTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertRankEventNameTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertDuelistCupNameTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertDuelTrialNameTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertRarityNameTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertPremiumNameTag(ref string src, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private static void ConvertClientWorkPath(ref string src)
		{
		}
	}
}
