using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Deck
{
	public class DeckInfo
	{
		public enum DeckType
		{
			M = 0,
			E = 1,
			S = 2,
			T = 3
		}

		public abstract class BaseDeckInfo
		{
			protected const string KEY_M = "m";

			protected const string KEY_E = "e";

			protected const string KEY_S = "s";

			protected const string KEY_T = "t";

			protected const string KEY_IDS = "ids";

			protected const string KEY_R = "r";

			protected const string KEY_DECKID = "deck_id";

			protected const string KEY_NAME = "name";

			protected const string KEY_ACCESSORY = "accessory";

			protected const string KEY_PICKCARDS = "pick_cards";

			protected const string KEY_EDITTIME = "et";

			protected const string KEY_CREATETIME = "ct";

			protected const string KEY_REG = "regulation_id";

			protected const string KEY_NAME_REG_ID = "name_reg_id";

			protected string deckPath;

			protected string listPath;

			protected string GetStrDeckType(DeckType type)
			{
				return null;
			}

			public virtual Dictionary<int, string> GetDeckIDAndName()
			{
				return null;
			}

			public virtual string GetDeckNameByID(int id)
			{
				return null;
			}

			public virtual List<int> GetDeckListByID(int id, DeckType type)
			{
				return null;
			}

			public virtual List<int> GetCardPremiumByID(int id, DeckType type)
			{
				return null;
			}

			public virtual Dictionary<string, object> GetDeckDictByID(int deckID, DeckType type)
			{
				return null;
			}

			public virtual Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
			{
				return null;
			}

			public virtual List<CardBaseData> GetCardBaseListByID(int id, DeckType type)
			{
				return null;
			}

			public virtual Dictionary<string, object> GetAccessory(int id)
			{
				return null;
			}

			public virtual int[] GetPickUpCardIDs(int id)
			{
				return null;
			}

			public virtual int[] GetPickUpCardPremiums(int id)
			{
				return null;
			}

			public virtual Dictionary<string, object> GetPickUpCardIDs2(int id)
			{
				return null;
			}

			public virtual Dictionary<string, object> GetPickUpCardPremiums2(int id)
			{
				return null;
			}

			public virtual Dictionary<string, object> GetPickUps(int id)
			{
				return null;
			}

			public virtual long GetEditTime(int id)
			{
				return 0L;
			}

			public virtual long GetDeckCreateTime(int id)
			{
				return 0L;
			}
		}

		public class MyDeckInfo : BaseDeckInfo
		{
			public int GetDeckRegByID(int id)
			{
				return 0;
			}
		}

		public class ExhibitionDeckInfo : BaseDeckInfo
		{
		}

		public class DuelistCupDeckInfo : BaseDeckInfo
		{
			public void SetQualifierCupPath()
			{
			}

			public new Dictionary<int, string> GetDeckIDAndName()
			{
				return null;
			}

			public string GetDeckName()
			{
				return null;
			}

			public virtual Dictionary<string, object> GetDeckDict(DeckType type)
			{
				return null;
			}

			public List<int> GetDeckListByID(DeckType type)
			{
				return null;
			}

			public List<int> GetCardPremiumByID(DeckType type)
			{
				return null;
			}

			public List<CardBaseData> GetCardBaseListByID(DeckType type)
			{
				return null;
			}

			public Dictionary<string, object> GetAccessory()
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardIDs()
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardPremiums()
			{
				return null;
			}

			public Dictionary<string, object> GetPickUps()
			{
				return null;
			}

			public int GetStage()
			{
				return 0;
			}
		}

		public class WCSDeckInfo : DuelistCupDeckInfo
		{
			public new Dictionary<int, string> GetDeckIDAndName()
			{
				return null;
			}
		}

		public class WCSFinalDeckInfo : WCSDeckInfo
		{
			public new Dictionary<int, string> GetDeckIDAndName()
			{
				return null;
			}

			public Dictionary<string, object> GetDeckDict(DeckType type, int index, int slot)
			{
				return null;
			}
		}

		public class RankEventDeckInfo : BaseDeckInfo
		{
		}

		public class DuelTrialDeckInfo : BaseDeckInfo
		{
			public string GetDeckNameByID(int trialID, int deckID = 1)
			{
				return null;
			}

			public Dictionary<string, object> GetAccessory(int trialID, int deckID = 1)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardIDs(int trialID, int deckID = 1)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardDecorations(int trialID, int deckID = 1)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUps(int trialID, int deckID = 1)
			{
				return null;
			}

			public new Dictionary<KeyValuePair<int, int>, string> GetDeckIDAndName()
			{
				return null;
			}

			public Dictionary<int, string> GetDeckIDAndNameByTrialID(int trialID)
			{
				return null;
			}

			public List<int> GetDeckListByID(int trialID, int deckID, DeckType type)
			{
				return null;
			}

			public List<int> GetCardPremiumByID(int trialID, int deckID, DeckType type)
			{
				return null;
			}

			public List<CardBaseData> GetCardBaseListByID(int trialID, int deckID, DeckType type)
			{
				return null;
			}
		}

		public class VersusDeckInfo : BaseDeckInfo
		{
			public new Dictionary<KeyValuePair<int, int>, string> GetDeckIDAndName()
			{
				return null;
			}

			public List<CardBaseData> GetCardBaseListByID(int versusId, int groupId, DeckType type)
			{
				return null;
			}

			public List<int> GetDeckListByID(int versusId, int groupId, DeckType type)
			{
				return null;
			}

			public List<int> GetCardPremiumByID(int versusId, int groupId, DeckType type)
			{
				return null;
			}

			public Dictionary<string, object> GetAccessory(int versusId, int versusGroupId)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUps(int versusId, int versusGroupId)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardIDs(int versusId, int versusGroupId)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardPremiums(int versusId, int versusGroupId)
			{
				return null;
			}

			public string GetDeckNameByID(int versusID, int groupID = 1)
			{
				return null;
			}
		}

		public class RentalDeckInfo : BaseDeckInfo
		{
			public static List<int> GetRentalDeckIDs(int exhid)
			{
				return null;
			}

			public string GetDeckNameByID(int eventID, int deckID)
			{
				return null;
			}

			public static string GetDeckDesc(int eventID, int deckID)
			{
				return null;
			}

			public new Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
			{
				return null;
			}

			public Dictionary<string, object> GetAccessory(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUps(int eventID, int deckID)
			{
				return null;
			}
		}

		public class DuelTrialRentalDeckInfo : BaseDeckInfo
		{
			public static List<int> GetRentalDeckIDs(int exhid)
			{
				return null;
			}

			public string GetDeckNameByID(int eventID, int deckID)
			{
				return null;
			}

			public static string GetDeckDesc(int eventID, int deckID)
			{
				return null;
			}

			public new Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
			{
				return null;
			}

			public Dictionary<string, object> GetAccessory(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUps(int eventID, int deckID)
			{
				return null;
			}
		}

		public class VersusRentalDeckInfo : BaseDeckInfo
		{
			public static List<int> GetRentalDeckIDs(int vid, int groupId)
			{
				return null;
			}

			public string GetDeckNameByID(int eventID, int deckID)
			{
				return null;
			}

			public new Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
			{
				return null;
			}

			public Dictionary<string, object> GetAccessory(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
			{
				return null;
			}

			public Dictionary<string, object> GetPickUps(int eventID, int deckID)
			{
				return null;
			}
		}

		public class ReplayDeckInfo : BaseDeckInfo
		{
		}

		private const string CLIENTWORK_PATH_DECK_LISTS = "$.Deck.list";

		private const string CLIENTWORK_PATH_DECKLIST = "$.DeckList";

		private const string CLIENTWORK_PATH_TOURNAMENT = "$.TDeckList";

		private const string CLIENTWORK_PATH_TOURNAMENT_DECK_LIST = "$.TDeck.list";

		private const string CLIENTWORK_PATH_EXHIBITION = "$.EXHDeckList";

		private const string CLIENTWORK_PATH_EXHIBITION_DECK_LIST = "$.EXHDeck.list";

		private const string CLIENTWORK_PATH_CUP = "$.CUPDeckList";

		private const string CLIENTWORK_PATH_CUP_DECK_LIST = "$.CUPDeck";

		private const string CLIENTWORK_PATH_RANKEVENT = "$.REDeckList";

		private const string CLIENTWORK_PATH_RANKEVENT_DECK_LIST = "$.REDeck.list";

		private const string CLIENTWORK_PATH_DUELTRIAL = "$.DTDeckList";

		private const string CLIENTWORK_PATH_DUELTRIAL_DECK_LIST = "$.DTDeck.list";

		private const string CLIENTWORK_PATH_VERSUS = "$.VDeckList";

		private const string CLIENTWORK_PATH_VERSUS_DECK_LIST = "$.VDeck.list";

		private const string CLIENTWORK_PATH_CARD_FAVORITE = "$.Cards.favorite.";

		private const string KEY_DECK_COUNT = "num";

		private const string KEY_DECK_MAX = "empty";

		private const string KEY_DECK_ID = "deck_id";

		private const string KEY_DECK_NAME = "name";

		private const string KEY_DECK_REG = "regulation_id";

		private const string KEY_DECKLIST_MAIN = "m";

		private const string KEY_DECKLIST_EXTRA = "e";

		private const string KEY_DECKLIST_SIDE = "s";

		private const string KEY_DECKLIST_TRAY = "t";

		private const string KEY_DECKLIST_CARDIDS = "ids";

		private const string KEY_DECKLIST_PREMIUMIDS = "r";

		private const string KEY_TOURNAMENT_DECKLIST = "DeckList.1";

		private const string KEY_CARD_FAVOTITE_CARDIDS = "ids";

		private const string KEY_CARD_FAVOTITE_PREMIUMIDS = "r";

		private const string KEY_CARD_FAVOTITE_CARDLIST = "card_list";

		public static readonly int PICKUPCARDS_NUM;

		public static MyDeckInfo myDeckInfo;

		public static ExhibitionDeckInfo exhibitionDeckInfo;

		public static DuelistCupDeckInfo duelistCupDeckInfo;

		public static WCSDeckInfo wcsCupDeckInfo;

		public static WCSFinalDeckInfo wcsFinalDeckInfo;

		public static RankEventDeckInfo rankEventDeckInfo;

		public static DuelTrialDeckInfo duelTrialDeckInfo;

		public static VersusDeckInfo versusDeckInfo;

		public static RentalDeckInfo rentalDeckInfo;

		public static DuelTrialRentalDeckInfo duelTrialRentalDeckInfo;

		public static VersusRentalDeckInfo versusRentalDeckInfo;

		public static ReplayDeckInfo replayDeckInfo;

		public const string k_ArgsKeyDeckCase = "box";

		public const string k_ArgsKeyProtector = "sleeve";

		public const string k_ArgsKeyField = "field";

		public const string k_ArgsKeyObject = "object";

		public const string k_ArgsKeyMateBase = "av_base";

		public const string k_ArgsKeyPickIds = "pickIds";

		public const string k_ArgsKeyPickDecos = "pickDecos";

		public const string k_ArgsKeyRegulation = "regulation";

		public const string k_ArgsKeyEvent = "event";

		public const string k_ArgsKeyLogo = "logo";

		public const string k_ArgsKeyStage = "stage";

		public const string k_ArgsKeyName = "name";

		public static bool isReachDeckNumLimit => false;

		public static int GetDeckNum()
		{
			return 0;
		}

		public static int GetDeckLimit()
		{
			return 0;
		}

		public static Dictionary<string, object> DeckSaveFormatParser(List<CardBaseData> main, List<CardBaseData> extra, List<CardBaseData> side, bool exceptRental = true)
		{
			return null;
		}

		public static List<CardBaseData> GetFavoriteCardBaseData()
		{
			return null;
		}

		private static List<int> GetFavoriteCardIDList()
		{
			return null;
		}

		private static List<int> GetFavoriteCardPremiumList()
		{
			return null;
		}

		public static Dictionary<string, object> FavoriteSaveFormatParser(List<CardBaseData> bookmark)
		{
			return null;
		}

		public static GameObject CreateEmbedObj(Dictionary<string, object> args, ElementObjectManager eom, Transform transform)
		{
			return null;
		}

		public static Dictionary<int, string> GetRankEventDeckIDAndName()
		{
			return null;
		}

		public static List<int> GetRankEventDeckList(int id, DeckType type)
		{
			return null;
		}

		public static List<int> GetRankEventCardPremium(int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetRankEventCardBaseData(int id, DeckType type)
		{
			return null;
		}

		public static Dictionary<string, object> GetRankEventDeckAccessory(int id)
		{
			return null;
		}

		public static string GetCupDeckName()
		{
			return null;
		}

		public static string GetWcsDeckName()
		{
			return null;
		}

		public static string GetRankEventDeckNameByID(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetRankEventPickUpCardIDs(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetRankEventPickUpCardDecorations(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetRankEventPickUps(int tid)
		{
			return null;
		}

		public static Dictionary<int, string> GetDeckIDAndName()
		{
			return null;
		}

		public static string GetDeckNameByID(int id)
		{
			return null;
		}

		public static List<int> GetDeckListByID(int id, DeckType type)
		{
			return null;
		}

		public static List<int> GetCardPremiumByID(int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetCardBaseDataByID(int id, DeckType type)
		{
			return null;
		}

		public static int[] GetDeckPickUpCardIDs(int id)
		{
			return null;
		}

		public static int[] GetDeckPickUpCardDecorations(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetDeckPickUpCardIDs2(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetDeckPickUpCardDecorations2(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetDeckPickUps(int id)
		{
			return null;
		}

		public static long GetDeckEditTime(int id)
		{
			return 0L;
		}

		public static long GetDeckCreateTime(int id)
		{
			return 0L;
		}

		public static Dictionary<string, object> GetDeckAccessory(int id)
		{
			return null;
		}

		public static string GetExhibitionNameByID(int id)
		{
			return null;
		}

		public static List<int> GetExhibitionDeckList(int id, DeckType type)
		{
			return null;
		}

		public static List<int> GetExhibitionCardPremium(int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetExhibitionCardBaseData(int id, DeckType type)
		{
			return null;
		}

		public static Dictionary<string, object> GetExhibitionDeckAccessory(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetExhibitionPickUpCardIDs(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetExhibitionPickUpCardDecorations(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetExhibitionPickUps(int exhid)
		{
			return null;
		}

		public static Dictionary<int, string> GetExhibitionDeckIDAndName()
		{
			return null;
		}

		public static List<int> GetRentalDeckIDs(int exhid)
		{
			return null;
		}

		private static List<int> GetRentalDeckList(int exhid, int id, DeckType type)
		{
			return null;
		}

		private static List<int> GetRentalCardPremium(int exhid, int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetRentalCardBaseData(int exhid, int id, DeckType type)
		{
			return null;
		}

		public static Dictionary<string, object> GetRentalDeckAccessory(int exhid, int id)
		{
			return null;
		}

		private static Dictionary<string, object> GetRentalPickUpCardIDs(int exhid, int id)
		{
			return null;
		}

		public static int[] GetRentalPickUpCardIDArray(int exhid, int id)
		{
			return null;
		}

		private static Dictionary<string, object> GetRentalPickUpCardDecorations(int exhid, int id)
		{
			return null;
		}

		public static int[] GetRentalPickUpCardDecorationArray(int exhid, int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetRentalPickUps(int exhid, int id)
		{
			return null;
		}

		public static string GetRentalDeckName(int exhid, int id)
		{
			return null;
		}

		public static string GetRentalDeckDesc(int exhid, int id)
		{
			return null;
		}

		public static List<int> GetDuelTrialDeckList(int id, DeckType type)
		{
			return null;
		}

		public static List<int> GetDuelTrialCardPremium(int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetDuelTrialCardBaseData(int id, DeckType type, List<int> rentalList = null)
		{
			return null;
		}

		public static List<int> GetDuelTrialDeckIDs(int dtid)
		{
			return null;
		}

		private static List<int> GetDuelTrialDeckList(int dtid, int id, DeckType type)
		{
			return null;
		}

		private static List<int> GetDuelTrialCardPremium(int dtid, int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetDuelTrialCardBaseData(int dtid, int id, DeckType type)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelTrialDeckAccessory(int dtid, int id)
		{
			return null;
		}

		private static Dictionary<string, object> GetDuelTrialPickUpCardIDs(int dtid, int id)
		{
			return null;
		}

		public static int[] GetDuelTrialPickUpCardIDArray(int dtid, int id)
		{
			return null;
		}

		private static Dictionary<string, object> GetDuelTrialPickUpCardDecorations(int dtid, int id)
		{
			return null;
		}

		public static int[] GetDuelTrialPickUpCardDecorationArray(int dtid, int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelTrialPickUps(int dtid, int id)
		{
			return null;
		}

		public static string GetDuelTrialDeckName(int dtid, int id)
		{
			return null;
		}

		public static string GetDuelTrialDeckDesc(int dtid, int id)
		{
			return null;
		}

		public static string GetVersusNameByID(int id)
		{
			return null;
		}

		public static List<int> GetVersusDeckList(int id, DeckType type)
		{
			return null;
		}

		public static List<int> GetVersusCardPremium(int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetVersusCardBaseData(int id, DeckType type)
		{
			return null;
		}

		public static Dictionary<string, object> GetVersusDeckAccessory(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetVersusPickUpCardIDs(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetVersusPickUpCardDecorations(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetVersusPickUps(int exhid)
		{
			return null;
		}

		public static List<int> GetVersusRentalDeckIDs(int vid, int groupId)
		{
			return null;
		}

		private static List<int> GetVersusRentalDeckList(int vid, int id, DeckType type)
		{
			return null;
		}

		private static List<int> GetVersusRentalCardPremium(int exhid, int id, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetVersusRentalCardBaseData(int exhid, int id, DeckType type)
		{
			return null;
		}

		public static Dictionary<string, object> GetVersusRentalDeckAccessory(int vid, int id)
		{
			return null;
		}

		private static Dictionary<string, object> GetVersusRentalPickUpCardIDs(int vid, int id)
		{
			return null;
		}

		public static int[] GetVersusRentalPickUpCardIDArray(int vid, int id)
		{
			return null;
		}

		private static Dictionary<string, object> GetVersusRentalPickUpCardDecorations(int vid, int id)
		{
			return null;
		}

		public static int[] GetVersusRentalPickUpCardDecorationArray(int vid, int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetVersusRentalPickUps(int exhid, int id)
		{
			return null;
		}

		public static string GetVersusRentalDeckName(int vid, int id)
		{
			return null;
		}

		public static string GetVersusRentalDeckDesc(int exhid, int id)
		{
			return null;
		}

		public static List<object> GetReplayDeckList(long did, DeckType type)
		{
			return null;
		}

		public static List<object> GetReplayCardPremium(long did, DeckType type)
		{
			return null;
		}

		public static List<CardBaseData> GetReplayCardBaseData(int did, DeckType type)
		{
			return null;
		}
	}
}
