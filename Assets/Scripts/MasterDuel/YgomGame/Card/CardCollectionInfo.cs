using System.Collections.Generic;
using UnityEngine;
using YgomGame.Deck;
using YgomGame.TextIDs;

namespace YgomGame.Card
{
	public class CardCollectionInfo
	{
		public enum Rarity
		{
			Normal = 1,
			Rare = 2,
			SuperRare = 3,
			UltraRare = 4
		}

		public enum Regulation
		{
			Forbidden = 0,
			Limited = 1,
			SemiLimited = 2,
			None = 3
		}

		public enum Premium
		{
			Normal = 1,
			Premium1 = 2,
			Premium2 = 3
		}

		public struct SecretPackInfo
		{
			public string nameTextId;

			public bool isExtend;

			public int shopID;

			public int freeNum;

			public int iconType;

			public string iconData;

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public const int REGULATIONID_UNLIMITED = 8;

		public const int REGULATIONID_UNDEFINED = -1;

		public const int CARDINVENTORYTHRESHOLD = 3;

		public const int MASSDISMANTLECAP = 1000;

		private static Content m_cci;

		public const string CLIENTWORK_PATH_CARDS_COLLECTION = "$.Cards.have";

		private const string CLIENTWORK_PATH_CARD_RARITY = "$.Master.CardRare";

		private const string CLIENTWORK_PATH_CARD_CRAFT = "$.Master.CardCr";

		private const string CLIENTWORK_PATH_CREATECOST = "$.Craft.generate_rate_list";

		private const string CLIENTWORK_PATH_DISMANTLECOST = "$.Craft.exchange_rate_list";

		private const string CLIENTWORK_PATH_CARDS_RENTAL = "$.Master.RentalCard";

		private const string KEY_RARITY = "r";

		private const string KEY_SUM = "tn";

		private const string KEY_PREM0 = "n";

		private const string KEY_PREM1 = "p1n";

		private const string KEY_PREM2 = "p2n";

		private const string KEY_PRIZE = "p_";

		private static Dictionary<string, Premium> premTbl;

		private const string CLIENTWORK_PATH_TOURNAMENT_REGULATION = "$.Master.Regulation";

		private const string CLIENTWORK_PATH_COMMON_FORBIDDEN = "$.Master.Regulation.common.available.a0";

		private const string CLIENTWORK_PATH_COMMON_LIMITED = "$.Master.Regulation.common.available.a1";

		private const string CLIENTWORK_PATH_COMMON_SEMILIMITED = "$.Master.Regulation.common.available.a2";

		private const string KEY_COMMON = "common";

		private const string KEY_AVAILABLE = "available";

		private const string KEY_A0 = "a0";

		private const string KEY_A1 = "a1";

		private const string KEY_A2 = "a2";

		private const string KEY_CARDPOOL = "card_pool";

		private const string KEY_MAIN = "main";

		private const string KEY_EXTRA = "extra";

		private const string KEY_REQUIRE = "require";

		private const string KEY_R1 = "r1";

		private const string KEY_R2 = "r2";

		private const string KEY_R3 = "r3";

		private const string KEY_TIMESTAMP = "st";

		private static Dictionary<string, object> m_cardsCollection;

		private static Dictionary<string, object> m_cardRarity;

		private static Dictionary<string, object> m_regulation;

		private static List<int> m_cardCraft;

		private static Dictionary<string, int> m_available;

		private static Dictionary<string, int> m_cardpool;

		private static Dictionary<string, int> m_useavailable;

		private static Dictionary<string, int> m_rental;

		private static Color m_rentalColor;

		private const string CLIENTWORK_PATH_CRAFTPOINT = "$.Item.have.";

		private const string CLIENTWORK_PATH_CRAFTSECRETPACK = "$.Craft.secret_pack_list";

		public static int REGULATIONID_STANDARD => 0;

		public static void Initialize()
		{
		}

		public static void CardsCollectionNotificator(object value)
		{
		}

		public static void CardRarityNotificator(object value)
		{
		}

		public static void CardCraftNotificator(object value)
		{
		}

		public static void RegulationNotificator(object value)
		{
		}

		public static void RentalCardNotificator(object value)
		{
		}

		private static int CardsCollectionGetValue(int id, string val)
		{
			return 0;
		}

		private static long CardsCollectionGetValueLong(int id, string val)
		{
			return 0L;
		}

		public static int CardRarityGetValue(int id)
		{
			return 0;
		}

		public static int GetSumOfCardInCollection(int id)
		{
			return 0;
		}

		public static List<int> GetCardsInCollection(bool noDupes)
		{
			return null;
		}

		public static List<CardBaseData> GetPremiumCardsInCollection(bool nonPrizeOnly = false)
		{
			return null;
		}

		public static int GetPremiumCardTotal(int id, Premium prem, bool nonPrizeOnly = false)
		{
			return 0;
		}

		public static (Premium, bool) GetOwnedHighPremium(int cardID, Premium maxPremium, int numCardInDeckNormal, int numCardInDeckPremium1, int numCardInDeckPremium2)
		{
			return default((Premium, bool));
		}

		public static int GetCardLimitByID(int id, int regulation)
		{
			return 0;
		}

		public static int GetCardRarityID(int id)
		{
			return 0;
		}

		public static Rarity GetCardRarity(int id)
		{
			return default(Rarity);
		}

		public static string GetCardRarityText(int rarityId)
		{
			return null;
		}

		public static string GetCardRarityText(Rarity rarity)
		{
			return null;
		}

		public static IDS_CARD GetCardRarityTextId(Rarity rarity)
		{
			return default(IDS_CARD);
		}

		public static string GetCardStyleText(int styleId)
		{
			return null;
		}

		public static string GetCardStyleText(Premium style)
		{
			return null;
		}

		public static IDS_CARD GetCardStyleTextId(Premium style)
		{
			return default(IDS_CARD);
		}

		public static int GetCraftPoints(int id)
		{
			return 0;
		}

		public static int GetCardCreateCost(Premium prem, Rarity rarity)
		{
			return 0;
		}

		public static int GetCardDismantleCost(Premium prem, Rarity rarity)
		{
			return 0;
		}

		public static bool IsCreatable(CardBaseData data, int num = 1)
		{
			return false;
		}

		public static bool IsDismantleable(CardBaseData data, int num = 1)
		{
			return false;
		}

		public static bool IsOverCraftPoint()
		{
			return false;
		}

		public static List<CardBaseData> GetAllPremiumCards(bool fullStyle)
		{
			return null;
		}

		public static List<CardBaseData> GetAllCards()
		{
			return null;
		}

		public static Regulation GetRegulationStatus(int cardID, int regulationID)
		{
			return default(Regulation);
		}

		public static string GetRegulationName(int regId)
		{
			return null;
		}

		private static bool GetTextGroup(string fullTextId, out string groupId)
		{
			groupId = null;
			return false;
		}

		public static Dictionary<string, object> GetRules()
		{
			return null;
		}

		public static List<int> GetRuleIds()
		{
			return null;
		}

		public static int GetLatestRagulationID(int regulationID)
		{
			return 0;
		}

		public static List<int> GetLimitedCardMrks(int regulationID, Regulation limit)
		{
			return null;
		}

		public static int GetCardTimeObtained(int cardID)
		{
			return 0;
		}

		public static bool IsCraftableCard(int cardID)
		{
			return false;
		}

		public static Dictionary<string, object> FormatForMultiDismantle(int cardID, int n_num, int p1_num, int p2_num)
		{
			return null;
		}

		public static Dictionary<string, object> DismantleSingleCard(int cardID, int n_num, int p1_num, int p2_num)
		{
			return null;
		}

		public static Dictionary<CardBaseData, int> CardBaseDataListToCardBaseDataNumPairs(List<CardBaseData> cards)
		{
			return null;
		}

		public static Dictionary<string, object> DismantleMultiCards(List<CardBaseData> cards)
		{
			return null;
		}

		public static Dictionary<string, object> FormatForMassDismantle()
		{
			return null;
		}

		public static Dictionary<string, object> FormatForMultiCreate(int cardID, int n_num, int p1_num, int p2_num)
		{
			return null;
		}

		public static Dictionary<string, object> FormatForMultiCreate(Dictionary<int, int> lackCards)
		{
			return null;
		}

		public static Dictionary<string, object> CreateSingleCard(int cardID, Premium prem)
		{
			return null;
		}

		public static int GetRedundantCards(int cardID, Premium prem)
		{
			return 0;
		}

		public static Dictionary<KeyValuePair<Rarity, Premium>, int> GetAllRedundantCards()
		{
			return null;
		}

		public static Dictionary<Rarity, int> GetEarnedPoints()
		{
			return null;
		}

		public static Dictionary<Rarity, int> GetEarnedPoints(List<CardBaseData> cards)
		{
			return null;
		}

		public static Dictionary<Rarity, int> GetNeedPoints(List<CardBaseData> cards)
		{
			return null;
		}

		public static Dictionary<KeyValuePair<Rarity, Premium>, int> GetRarityNumPairs(List<CardBaseData> cards)
		{
			return null;
		}

		public static List<SecretPackInfo> GetOpenedSecretPackInfo()
		{
			return null;
		}

		public static Dictionary<int, SecretPackInfo> GetOpenedSecretPacks()
		{
			return null;
		}

		public static List<int> GetRentalCardIDs(int rentalID)
		{
			return null;
		}

		public static int GetRentalCardTotal(int rentalID)
		{
			return 0;
		}

		public static int GetRentalCardNum(int rentalID, int cardID)
		{
			return 0;
		}

		public static Color GetRentalColor()
		{
			return default(Color);
		}
	}
}
