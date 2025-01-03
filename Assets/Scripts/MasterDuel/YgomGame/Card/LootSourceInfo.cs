using System.Collections.Generic;
using YgomGame.TextIDs;

namespace YgomGame.Card
{
	public class LootSourceInfo
	{
		public enum LootCategory
		{
			Pack = 1,
			Solo = 2,
			Tournament = 3,
			Exhibition = 4,
			FreeStruct = 5,
			PaidStruct = 6,
			Mission = 7,
			DuelReward = 8,
			Set = 9,
			Etc = 99
		}

		public static Dictionary<LootCategory, IDS_DECKEDIT> CategoryTextTbl;

		private const string CLIENTWORK_PATH_ROUTE = "$.Route";

		private const string KEY_CATEGORY = "route_category";

		private const string KEY_PARAM = "route_param";

		private const string KEY_OPEN = "route_open";

		private const string KEY_NAMEID = "route_name_id";

		private const string KEY_ICONTYPE = "route_icon_type";

		private const string KEY_ICONDATA = "route_icon_data";

		public static List<object> GetLootSource()
		{
			return null;
		}

		public static int GetLootCategoryID(Dictionary<string, object> dic)
		{
			return 0;
		}

		public static int GetLootParam(Dictionary<string, object> dic)
		{
			return 0;
		}

		public static int GetLootIconType(Dictionary<string, object> dic)
		{
			return 0;
		}

		public static string GetLootIconData(Dictionary<string, object> dic)
		{
			return null;
		}

		public static bool IsLootAvailable(Dictionary<string, object> dic)
		{
			return false;
		}

		public static string GetLootSourceString(Dictionary<string, object> dic)
		{
			return null;
		}
	}
}
