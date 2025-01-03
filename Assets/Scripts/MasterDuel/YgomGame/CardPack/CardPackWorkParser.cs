using System.Collections.Generic;

namespace YgomGame.CardPack
{
	public static class CardPackWorkParser
	{
		public static List<object> ParseGachaDrawInfo_Packs(this Dictionary<string, object> drawInfo)
		{
			return null;
		}

		public static List<object> ParseGachaDrawInfo_Packs_PackInfo(this Dictionary<string, object> packs)
		{
			return null;
		}

		public static Dictionary<string, object> ParseGachaDrawInfo_Packs_PackInfo_Effects(this Dictionary<string, object> packInfo)
		{
			return null;
		}

		public static List<object> ParseGachaDrawInfo_Packs_PackInfo_CardInfo(this Dictionary<string, object> packInfo)
		{
			return null;
		}

		public static Dictionary<string, object> ParseGachaDrawInfo_Packs_Effects(this Dictionary<string, object> packs)
		{
			return null;
		}

		public static string ParseGachaDrawInfo_Packs_Effects_ImageName(this Dictionary<string, object> effects)
		{
			return null;
		}

		public static Dictionary<string, object> ParseGachaDrawInfo_Options(this Dictionary<string, object> drawInfo)
		{
			return null;
		}

		public static bool ParseGachaDrawInfo_Options_Skippable(this Dictionary<string, object> options)
		{
			return false;
		}

		public static bool ParseGachaResult_IsSendGift(this Dictionary<string, object> packResult)
		{
			return false;
		}

		public static IReadOnlyList<object> ParseGachaResult_ObtainItems(this Dictionary<string, object> packResult)
		{
			return null;
		}

		public static bool ParseGachaResult_IsShowFoundSecret(this Dictionary<string, object> packResult)
		{
			return false;
		}

		public static bool ParseGachaResult_IsNextFinalizedUR(this Dictionary<string, object> packResult)
		{
			return false;
		}

		public static string ParseGachaResult_NextFinalizedURNameTextId(this Dictionary<string, object> packResult)
		{
			return null;
		}

		public static List<object> ParseGachaResult_ExtraCardGroups(this Dictionary<string, object> packResult)
		{
			return null;
		}

		public static int ParseGachaResult_ExtraCardGroup_Id(this Dictionary<string, object> extraGroup)
		{
			return 0;
		}

		public static string ParseGachaResult_ExtraCardGroup_LabelTextId(this Dictionary<string, object> extraGroup)
		{
			return null;
		}

		public static List<object> ParseGachaResult_ExtraCardGroup_LabelArgs(this Dictionary<string, object> extraGroup)
		{
			return null;
		}

		public static List<object> ParseGachaResult_ExtraPackGroups(this Dictionary<string, object> packResult)
		{
			return null;
		}

		public static List<object> ParseGachaResult_ExtraPackGroups_Packs(this Dictionary<string, object> extraPackGroup)
		{
			return null;
		}

		public static string ParseGachaResult_ExtraPackGroups_IconPath(this Dictionary<string, object> extraPackGroup)
		{
			return null;
		}
	}
}
