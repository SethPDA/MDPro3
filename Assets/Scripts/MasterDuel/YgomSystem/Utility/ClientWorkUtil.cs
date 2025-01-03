using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.CardPack;
using YgomGame.Colosseum;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomGame.Shop;

namespace YgomSystem.Utility
{
	public static class ClientWorkUtil
	{
		private static long ServerUnixTimeDiff;

		private static DateTime UnixEpoch;

		public static bool HasServerTimeLag => false;

		public static bool IsExistAccount()
		{
			return false;
		}

		public static string GetToken()
		{
			return null;
		}

		public static void SetPushNotificationToken(string token)
		{
		}

		public static string GetPushNotificationToken()
		{
			return null;
		}

		public static string GetAdId()
		{
			return null;
		}

		public static void SetSocialId(string id)
		{
		}

		public static string GetSocialId()
		{
			return null;
		}

		public static void SetLanguage(string lang, bool noSave = false)
		{
		}

		public static long GetMyPlayerCode()
		{
			return 0L;
		}

		public static string GetMyPlayerCodeStringForAppIdentifier()
		{
			return null;
		}

		public static bool IsCrossPlayOK()
		{
			return false;
		}

		public static bool IsCrossPlayOKOnGame()
		{
			return false;
		}

		public static bool IsMultiPlayOKByPlatform()
		{
			return false;
		}

		public static bool IsCrossPlayOKByPlatform()
		{
			return false;
		}

		public static bool IsOptOut()
		{
			return false;
		}

		public static bool DownloadCompleted()
		{
			return false;
		}

		public static void DownloadFinish()
		{
		}

		public static List<string> GetDownloadList()
		{
			return null;
		}

		public static List<Dictionary<string, string>> GetDownloadUrls()
		{
			return null;
		}

		public static string GetDownloadRevision()
		{
			return null;
		}

		public static string GetDownloadPass()
		{
			return null;
		}

		public static string GetDownloadSalt()
		{
			return null;
		}

		public static string GetLocalDownloadRevision()
		{
			return null;
		}

		public static int GetLocalDownladListIndex()
		{
			return 0;
		}

		public static int GetFirstDownloadNum()
		{
			return 0;
		}

		public static bool GetShouldDownload()
		{
			return false;
		}

		public static string GetTakeOverUrl()
		{
			return null;
		}

		public static string GetRegistUrl()
		{
			return null;
		}

		public static bool GetInheritEnable()
		{
			return false;
		}

		public static bool IsDoubleNotationCandidate()
		{
			return false;
		}

		public static bool IsRealtimeDuelWatchAvailable()
		{
			return false;
		}

		public static int GetPvpRank()
		{
			return 0;
		}

		public static bool GetChatEnable()
		{
			return false;
		}

		public static int ObjectToInt(object i)
		{
			return 0;
		}

		public static float ObjectToFloat(object i)
		{
			return 0f;
		}

		public static Color ObjectToColor(object c)
		{
			return default(Color);
		}

		public static Vector2 ObjectToVector2(object c)
		{
			return default(Vector2);
		}

		public static T[] ListToTypedArray<T>(List<object> dic)
		{
			return null;
		}

		public static int[] ListToIntArray(List<object> dic)
		{
			return null;
		}

		public static long GetUnixTime()
		{
			return 0L;
		}

		private static long GetRawUnixTime()
		{
			return 0L;
		}

		public static void ServerTimeNotificator(object v)
		{
		}

		public static int getIntWithCache(string jsonPath, int defaultValue = 0)
		{
			return 0;
		}

		public static float getFloatWithCache(string jsonPath, float defaultValue = 0f)
		{
			return 0f;
		}

		public static string getStringWithCache(string jsonPath, string defaultValue = "")
		{
			return null;
		}

		public static bool getBoolByJsonPathWithCache(string jsonPath, bool defaultValue = false)
		{
			return false;
		}

		public static Dictionary<string, object> getDictionaryWithCache(string jsonPath, Dictionary<string, object> defaultValue = null)
		{
			return null;
		}

		public static List<object> getListWithCache(string jsonPath, List<object> defaultValue = null)
		{
			return null;
		}

		public static object getObjectWithCache(string jsonPath, object defaultValue = null)
		{
			return null;
		}

		public static void RegisterNotificator()
		{
		}

		public static void ResetData()
		{
		}

		public static string GetPeriodItemName(int pCategory, int pItemId)
		{
			return null;
		}

		public static string GetPeriodItemThumb(int pCategory, int pItemId)
		{
			return null;
		}

		public static long GetPeriodLimitDateTs(int pCategory, int pItemId)
		{
			return 0L;
		}

		public static string GetRankLabelId(int rank)
		{
			return null;
		}

		public static string GetRankLabel(int rank, int tier)
		{
			return null;
		}

		public static Dictionary<string, object> GetCardTermData(int mrk, int termType)
		{
			return null;
		}

		public static Dictionary<string, object> GetCardTermData(int termId)
		{
			return null;
		}

		public static IReadOnlyDictionary<string, object> GetStructureFirstData()
		{
			return null;
		}

		public static object GetStructureMaster(int structureId)
		{
			return null;
		}

		public static Dictionary<string, object> GetUserProfile()
		{
			return null;
		}

		public static string GetUserName()
		{
			return null;
		}

		public static int GetUserLevel(int defaultValue = 1)
		{
			return 0;
		}

		public static int GetUserRank(int defaultValue = 1)
		{
			return 0;
		}

		public static int GetUserTier(int defaultValue = 5)
		{
			return 0;
		}

		public static int GetUserWallpaper(int defaultValue = 1)
		{
			return 0;
		}

		public static long GetUserPcode()
		{
			return 0L;
		}

		public static Dictionary<string, object> GetFriendProfile()
		{
			return null;
		}

		public static Dictionary<string, object> GetUserReplays()
		{
			return null;
		}

		public static Dictionary<string, object> GetFriendReplays()
		{
			return null;
		}

		public static bool IsFriendInBattle(object friendData)
		{
			return false;
		}

		public static bool IsFriendOnline(object friendData)
		{
			return false;
		}

		public static Dictionary<string, object> GetUserHistory(int mode)
		{
			return null;
		}

		public static long GetUserHistoryReplayLimit()
		{
			return 0L;
		}

		public static Dictionary<string, object> GetUserAchievements()
		{
			return null;
		}

		public static bool IsExistsUserReview()
		{
			return false;
		}

		public static IReadOnlyDictionary<string, object> GetUserReview()
		{
			return null;
		}

		public static IReadOnlyDictionary<string, object> GetGemShopProducts()
		{
			return null;
		}

		public static IReadOnlyDictionary<string, object> GetGemShopProduct(long shopPaidId)
		{
			return null;
		}

		public static List<object> GetGemShopConfirmRegDatas(int confirmRegId)
		{
			return null;
		}

		public static IReadOnlyDictionary<string, object> GetGemShopBuyResult()
		{
			return null;
		}

		public static IReadOnlyDictionary<string, object> GetGemShopInform()
		{
			return null;
		}

		public static Dictionary<string, object> GetShopProductsByCategory(ShopDef.ShowcaseCategory productCategory)
		{
			return null;
		}

		public static (ShopDef.ShowcaseCategory, Dictionary<string, object>) GetShopProductData(int shopId)
		{
			return default((ShopDef.ShowcaseCategory, Dictionary<string, object>));
		}

		public static Dictionary<string, object> GetProductByCategory(ShopDef.ShowcaseCategory productCategory, int shopId)
		{
			return null;
		}

		public static List<object> GetShopConfirmRegDatas(int confirmRegId)
		{
			return null;
		}

		public static Dictionary<string, object> GetShopTicketInfo()
		{
			return null;
		}

		public static bool IsShopPayItemSpecial(bool isPeriod, int itemCategory, int itemId)
		{
			return false;
		}

		public static int GetShopPeriodItemHave(int pItemCategory, int pItemId)
		{
			return 0;
		}

		public static string GetShopPeriodItemLimitDateStr(int pItemCategory, int pItemId)
		{
			return null;
		}

		public static Dictionary<string, object> GetAllProductPickup()
		{
			return null;
		}

		public static Dictionary<string, object> GetProductPickup(int shopId)
		{
			return null;
		}

		public static Dictionary<string, object> GetAllPackDatas()
		{
			return null;
		}

		public static (ShopDef.ShowcaseCategory, Dictionary<string, object>) GetProduct(int shopId)
		{
			return default((ShopDef.ShowcaseCategory, Dictionary<string, object>));
		}

		public static Dictionary<string, object> GetPackDatasInTypes(params CardPackDef.PackType[] packTypes)
		{
			return null;
		}

		public static Dictionary<string, object> GetProductPack(int shopId)
		{
			return null;
		}

		public static bool IsExistsSecretPack()
		{
			return false;
		}

		public static Dictionary<string, object> GetAllProductStructure()
		{
			return null;
		}

		public static Dictionary<string, object> GetProductStructure(int shopId)
		{
			return null;
		}

		public static Dictionary<string, object> GetAllProductSpecial()
		{
			return null;
		}

		public static Dictionary<string, object> GetProductSpecial(int shopId)
		{
			return null;
		}

		public static Dictionary<string, object> GetAllProductAccessory()
		{
			return null;
		}

		public static Dictionary<string, object> GetProductAccessory(int shopId)
		{
			return null;
		}

		public static bool ContainsGachaDrawInfo()
		{
			return false;
		}

		public static Dictionary<string, object> GetGachaDrawInfo()
		{
			return null;
		}

		public static List<object> GetGachaDrawCardInfo()
		{
			return null;
		}

		public static Dictionary<string, object> GetGachaResult()
		{
			return null;
		}

		public static bool IsExistsGachaCardList(int cardListId)
		{
			return false;
		}

		public static IReadOnlyList<object> GetGachaCardList(int cardListId)
		{
			return null;
		}

		public static object GetGachaRateData()
		{
			return null;
		}

		public static Dictionary<string, object> GetPrizeData(int prizeId)
		{
			return null;
		}

		public static Dictionary<string, object> GetPrizeResultInfo()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuStandard()
		{
			return null;
		}

		public static int GetDuelMenuStandardSeason()
		{
			return 0;
		}

		public static Dictionary<string, object> GetDuelMenuStandardHolding()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuTournament()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuExhibition()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuTournament(int tid)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuExhibition(int exhid)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuTournamentHolding(int tid)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuExhibitionHolding(int tid)
		{
			return null;
		}

		public static bool IsHoldingTournament(int tid)
		{
			return false;
		}

		public static bool IsHoldingExhibition(int exid)
		{
			return false;
		}

		public static bool IsHoldingStandard()
		{
			return false;
		}

		public static bool IsMatchingStandard()
		{
			return false;
		}

		public static Dictionary<string, object> GetDuelMenuFree()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuFreeHolding()
		{
			return null;
		}

		public static bool IsHoldingFree()
		{
			return false;
		}

		public static Dictionary<string, object> GetDuelMenuTeamMatchHolding()
		{
			return null;
		}

		public static bool IsHoldingTeam()
		{
			return false;
		}

		public static Dictionary<string, object> GetDuelMenuTeamMatchPreTeamInfo()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuRankEvent()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuRankEvent(int eid)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuRankEventHolding(int rank_event_id)
		{
			return null;
		}

		public static bool IsHoldingRankEvent(int rank_event_id)
		{
			return false;
		}

		public static Dictionary<string, object> GetDuelMenuFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuHoldingFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
		{
			return null;
		}

		public static bool IsHoldingFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
		{
			return false;
		}

		private static bool IsHoldingCup(ColosseumUtil.PlayMode mode)
		{
			return false;
		}

		public static Dictionary<string, object> GetFirstDlvFromPlayMode(ColosseumUtil.PlayMode mode)
		{
			return null;
		}

		public static Dictionary<string, object> GetFinalFromPlayMode(ColosseumUtil.PlayMode mode)
		{
			return null;
		}

		public static bool GetRankingExistFromPlayMode(ColosseumUtil.PlayMode mode)
		{
			return false;
		}

		public static Dictionary<string, object> GetDuelMenuDuelTrial()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuDuelTrial(int tid)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelMenuDuelTrialHolding(int tid)
		{
			return null;
		}

		public static bool IsHoldingDuelTrial(int tid)
		{
			return false;
		}

		public static Dictionary<string, object> GetMasterTournament()
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterExhibition()
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterRankEvent()
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterDuelTrial()
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterDuelTrial(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterVersusl()
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterVersusl(int id)
		{
			return null;
		}

		public static string GetTournamentNameTextID(int id)
		{
			return null;
		}

		public static int GetRegulationId(int mode, int identifier = 0)
		{
			return 0;
		}

		public static int GetRegulationId(Util.GameMode mode, int identifier = 0)
		{
			return 0;
		}

		public static int GetTournamentRegulationID(int id)
		{
			return 0;
		}

		public static int GetCupRegulationID()
		{
			return 0;
		}

		public static int GetWcsRegulationID()
		{
			return 0;
		}

		public static int GetRankEventRegulationID(int id)
		{
			return 0;
		}

		public static int GetDuelTrialRegulationID(int id)
		{
			return 0;
		}

		public static int GetVersusGroupID(int id)
		{
			return 0;
		}

		public static int GetVersusRegulationID(int id, int groupId)
		{
			return 0;
		}

		public static int GetMasterTournamentGroupNum(int id)
		{
			return 0;
		}

		public static string GetExhibtionNameTextID(int id)
		{
			return null;
		}

		public static int GetExhibitionRegulationID(int id)
		{
			return 0;
		}

		public static Dictionary<string, object> GetDuelMenuExhibitionRentalDeckInfo(int exhid)
		{
			return null;
		}

		public static int GetDuelMenuExhibitionRentalState(int exhid, int defaultValue = 0)
		{
			return 0;
		}

		public static Dictionary<string, object> GetTournamentInfo()
		{
			return null;
		}

		public static Dictionary<string, object> GetTournamentInfo(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetTournamentResult()
		{
			return null;
		}

		public static int GetMasterTournamentStatus(int id)
		{
			return 0;
		}

		public static List<object> GetTournamentRankingMembers(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetTournamentRankingMyself(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetTournamentRecvResult()
		{
			return null;
		}

		public static List<object> GetMasterTournamentRewardInfo(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterDuelTrialRewards(int duel_trial_id)
		{
			return null;
		}

		public static Dictionary<string, object> GetExhibitionRewardInfo(int id)
		{
			return null;
		}

		public static Dictionary<string, object> GetChallengeInfo(int mode = 1)
		{
			return null;
		}

		public static List<object> GetChallengeInfoRankInfoHistory(int mode = 1)
		{
			return null;
		}

		public static List<object> GetChallengeRankingMembers(int mode = 1)
		{
			return null;
		}

		public static Dictionary<string, object> GetChallengeRankingMyself(int mode = 1)
		{
			return null;
		}

		public static int GetChallengeSelectDeck(int mode = 1)
		{
			return 0;
		}

		public static Dictionary<string, object> GetChallengeRewardList(int mode = 1)
		{
			return null;
		}

		public static Dictionary<string, object> GetTDeckList(int tid)
		{
			return null;
		}

		public static Dictionary<string, object> GetEXHDeckList(int exhid)
		{
			return null;
		}

		public static Dictionary<string, object> GetRankEvent(int rank_event_id = 1)
		{
			return null;
		}

		public static Dictionary<string, object> GetRankEventInfo(int rank_event_id = 1)
		{
			return null;
		}

		public static int GetRankEventInfoRankInfoNowRank(int rank_event_id, int defaultValue = 1)
		{
			return 0;
		}

		public static int GetRankEventInfoRankInfoNowTier(int rank_event_id, int defaultValue = 1)
		{
			return 0;
		}

		public static string GetCupNameTextID()
		{
			return null;
		}

		public static string GetWcsNameTextID()
		{
			return null;
		}

		public static string GetRankEventNameTextID(int id)
		{
			return null;
		}

		public static string GetDuelTrialNameTextID(int id)
		{
			return null;
		}

		public static string GetVersusNameTextID(int id, int index)
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelTrial(int duel_trial_id = 1)
		{
			return null;
		}

		public static Dictionary<string, object> GetVersus(int versus_id = 1)
		{
			return null;
		}

		public static long GetVersusGroupTotalPoint(int versus_id, int group_id, long defaultValue = 0L)
		{
			return 0L;
		}

		public static long GetVersusGroupTotalPercent(int versus_id, int group_id, long defaultValue = 0L)
		{
			return 0L;
		}

		public static Dictionary<string, object> GetRoom()
		{
			return null;
		}

		public static Dictionary<string, object> GetRoomInfo()
		{
			return null;
		}

		public static string GetRoomName(long pcode)
		{
			return null;
		}

		public static bool GetRoomInfoIsJoinPlayer(bool defaultValue = true)
		{
			return false;
		}

		public static List<object> GetRoomInfoTable()
		{
			return null;
		}

		public static Dictionary<string, object> GetRoomInfoBattleSetting()
		{
			return null;
		}

		public static Dictionary<string, object> GetRoomInfoRoomMembers()
		{
			return null;
		}

		public static Dictionary<string, object> GetRoomInfoRoomMember(long pcode)
		{
			return null;
		}

		public static Dictionary<string, object> GetRoomInfoLeaveRoomMember(long pcode)
		{
			return null;
		}

		public static int GetRoomInfoNewComment(long pcode)
		{
			return 0;
		}

		public static Dictionary<string, object> GetRoomInfoInvitedList()
		{
			return null;
		}

		public static List<object> GetRoomList()
		{
			return null;
		}

		public static Dictionary<string, object> GetRoomRuleList()
		{
			return null;
		}

		public static Dictionary<string, object> GetRoomHoldingRuleList()
		{
			return null;
		}

		public static List<object> GetRoomInfoBattleResultList()
		{
			return null;
		}

		public static int GetPlatformRoomInviteId()
		{
			return 0;
		}

		public static int GetPlatformTeamInviteId()
		{
			return 0;
		}

		public static Dictionary<string, object> GetMasterSoloGate()
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterSoloChapter(int gateID)
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterSoloUnlock(int unlockID)
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterSoloUnlockItem(int setID)
		{
			return null;
		}

		public static Dictionary<string, object> GetMasterSoloReward(int setID)
		{
			return null;
		}

		public static int GetSoloGateClearChapter(int gateID)
		{
			return 0;
		}

		public static Dictionary<string, object> GetSoloChapter(int chapterID)
		{
			return null;
		}

		public static bool IsExistsSoloChapterDetail(int chapterID)
		{
			return false;
		}

		public static bool GetSoloClearedGate(int gateID)
		{
			return false;
		}

		public static long GetSoloLastPlayDate(int gateId)
		{
			return 0L;
		}

		public static bool GetSoloClearedChapter(int chapterID)
		{
			return false;
		}

		public static bool GetSoloClearedChapter(int chapterID, out int status)
		{
			status = default(int);
			return false;
		}

		public static bool GetSoloClearedChapter(int chapterID, bool isRental)
		{
			return false;
		}

		public static bool IsClearedTutorialChapter()
		{
			return false;
		}

		public static Dictionary<string, object> GetSoloClearedChapterDic(int gateID)
		{
			return null;
		}

		public static List<object> GetSoloResultRewards()
		{
			return null;
		}

		public static Dictionary<string, object> GetSoloResultGateClear()
		{
			return null;
		}

		public static bool GetSoloResultIsPresentSend()
		{
			return false;
		}

		public static Dictionary<string, object> GetSoloDeckInfo()
		{
			return null;
		}

		public static Dictionary<string, object> GetSoloNotify()
		{
			return null;
		}

		public static Dictionary<string, object> GetMissionAllMasters()
		{
			return null;
		}

		public static bool ContainsCampaignPoolMaster(int poolId)
		{
			return false;
		}

		public static Dictionary<string, object> GetMissionAllDatas()
		{
			return null;
		}

		public static bool IsNewMission(int poolId, int missionId)
		{
			return false;
		}

		public static Dictionary<string, object> GetMissionData(int poolId, int missionId)
		{
			return null;
		}

		public static Dictionary<string, object> GetMissionRecievedRewardData()
		{
			return null;
		}

		public static Dictionary<string, object> GetMissionRecieveCompletes()
		{
			return null;
		}

		public static Dictionary<string, object> GetMissionRecieveHides()
		{
			return null;
		}

		public static Dictionary<string, object> GetPresentBoxHave()
		{
			return null;
		}

		public static Dictionary<string, object> GetPresentBoxRecieveResult()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuel()
		{
			return null;
		}

		public static Dictionary<string, object> GetDuelResult()
		{
			return null;
		}

		public static object GetDuelTeam(int myid)
		{
			return null;
		}

		public static Dictionary<string, object> GetTeamRegulationSetList()
		{
			return null;
		}

		public static Dictionary<string, object> GetTeamInfo()
		{
			return null;
		}

		public static int GetTeamDeckId()
		{
			return 0;
		}

		public static Dictionary<string, object> GetTeamDeckInfo()
		{
			return null;
		}

		public static Dictionary<string, object> GetTeamInvitedList()
		{
			return null;
		}

		public static int GetTeamNameCardID()
		{
			return 0;
		}

		public static Dictionary<string, object> GetNotificationNotification()
		{
			return null;
		}

		public static Dictionary<string, object> GetNotificationMaintenance()
		{
			return null;
		}

		public static Dictionary<string, object> GetNotificationBug()
		{
			return null;
		}

		internal static (NotificationViewController.Type, Dictionary<string, object>) GetNotificationByID(int id)
		{
			return default((NotificationViewController.Type, Dictionary<string, object>));
		}

		public static List<object> GetTopics()
		{
			return null;
		}

		public static List<object> GetEventNotifyNotify()
		{
			return null;
		}

		public static Dictionary<string, object> GetEventNotifyBadge()
		{
			return null;
		}

		public static List<object> GetLoginBonus()
		{
			return null;
		}

		public static Dictionary<string, object> GetPromoCodesAllData()
		{
			return null;
		}

		public static Dictionary<string, object> GetPromoCodesData(int promoCodeId)
		{
			return null;
		}

		public static Dictionary<string, object> GetPromoCodesResult()
		{
			return null;
		}

		public static IReadOnlyDictionary<string, object> GetOperationDialog()
		{
			return null;
		}

		public static int GetFriendPollingSpan()
		{
			return 0;
		}

		public static IReadOnlyDictionary<string, object> GetFriendRefreshDic()
		{
			return null;
		}

		public static IReadOnlyList<object> GetFriendSearchProfileTags()
		{
			return null;
		}

		public static Dictionary<string, object> GetFollowPlayers()
		{
			return null;
		}

		public static object GetFollowPlayer(long pcode)
		{
			return null;
		}

		public static bool GetFollowPin(long pcode)
		{
			return false;
		}

		public static (List<object>, bool) GetFollowerPlayers()
		{
			return default((List<object>, bool));
		}

		public static Dictionary<string, object> GetBlockPlayers()
		{
			return null;
		}

		public static (List<object>, bool) GetFriendSearchResult()
		{
			return default((List<object>, bool));
		}

		public static object GetUpdatedFriend()
		{
			return null;
		}

		public static string GetCardIllustType()
		{
			return null;
		}

		public static string GetOtherCardIllustType()
		{
			return null;
		}

		public static bool IsWhileTutorial()
		{
			return false;
		}

		public static bool IsWhileTutorial(out int step)
		{
			step = default(int);
			return false;
		}

		public static IReadOnlyList<object> GetFirstStructureDeckIds()
		{
			return null;
		}

		public static bool InPeriod(long startTs, long endTs)
		{
			return false;
		}
	}
}
