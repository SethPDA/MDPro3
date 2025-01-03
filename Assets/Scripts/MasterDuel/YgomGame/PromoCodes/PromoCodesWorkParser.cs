using System.Collections.Generic;

namespace YgomGame.PromoCodes
{
	public static class PromoCodesWorkParser
	{
		public static int ParsePromoCodesId(this Dictionary<string, object> data)
		{
			return 0;
		}

		public static int ParseInputLength(this Dictionary<string, object> data)
		{
			return 0;
		}

		public static PromoCodeFormat ParseInputFormat(this Dictionary<string, object> data)
		{
			return default(PromoCodeFormat);
		}

		public static bool ParseCompleted(this Dictionary<string, object> data)
		{
			return false;
		}

		public static string ParseC(this Dictionary<string, object> data)
		{
			return null;
		}

		public static List<object> ParseResult_Rewards(this Dictionary<string, object> result)
		{
			return null;
		}

		public static bool ParseResult_IsSendPresent(this Dictionary<string, object> result)
		{
			return false;
		}

		public static bool ParseResult_Reward_IsPeriod(this Dictionary<string, object> result)
		{
			return false;
		}

		public static int ParseResult_Reward_ItemCategory(this Dictionary<string, object> result)
		{
			return 0;
		}

		public static int ParseResult_Reward_ItemId(this Dictionary<string, object> result)
		{
			return 0;
		}

		public static int ParseResult_Reward_Num(this Dictionary<string, object> result)
		{
			return 0;
		}

		public static OnErrorBehaviour ParseResult_OnErrorBehaviour(this Dictionary<string, object> result)
		{
			return default(OnErrorBehaviour);
		}
	}
}
