using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomGame.Settings;

namespace YgomGame.Duel
{
	public class Util
	{
		public enum GameMode
		{
			Normal = 0,
			Free = 1,
			Single = 2,
			Rank = 3,
			Tournament = 4,
			TournamentSingle = 5,
			Audience = 6,
			Replay = 7,
			RankSingle = 8,
			SoloSingle = 9,
			Room = 10,
			Exhibition = 11,
			DuelistCup = 12,
			RankEvent = 13,
			TeamMatch = 14,
			DuelTrial = 15,
			WCS = 16,
			Versus = 17,
			WcsFinal = 18,
			Null = 19
		}

		public enum EvalType
		{
			Advantage = 0,
			Normal = 1,
			Danger = 2
		}

		public enum AttackLevel
		{
			Small = 0,
			Medium = 1,
			Large = 2,
			Largest = 3
		}

		public enum OpeningMessageType
		{
			None = 0,
			Promotion = 1,
			Demotion = 2
		}

		public enum PlatformID
		{
			Invalid = 0,
			Android = 1,
			iOS = 2,
			Steam = 3,
			PS4 = 4,
			NX = 5,
			XboxOne = 6,
			Stadia = 7,
			PS5 = 8,
			XboxSX = 9,
			Editor = 100
		}

		public enum PublicLevel
		{
			AllClose = 0,
			FrontOpen = 1,
			AllOpen = 2
		}

		public enum DisplayType
		{
			Vista = 0,
			Standard = 1,
			MobileDevice = 2
		}

		public static Dictionary<int, int> initDeckNum;

		public static Dictionary<int, int> initExDeckNum;

		private static GameObject profileCardParent;

		private static List<Engine.SpSummonType> playedSpSummonEffect;

		private static List<int> playedMonsterCutinCardID;

		private static List<int> playedCardRunEffectCardID;

		private const string PLAYER_NAME_MASKED = "DUELIST";

		private const string PLAYER_NAME_MASKED_A = "DUELIST A";

		private const string PLAYER_NAME_MASKED_B = "DUELIST B";

		private const string PLAYER_NAME_MASKED_C = "DUELIST C";

		private const string PLAYER_NAME_MASKED_D = "DUELIST D";

		private const string PLAYER_NAME_MASKED_E = "DUELIST E";

		private const int SpAccessoryId_WCS = 2002;

		public const int PosPhaseButton = 19;

		public static void Initiaize()
		{
		}

		public static int ShowResult()
		{
			return 0;
		}

		public static GameMode GetGameMode()
		{
			return default(GameMode);
		}

		public static bool IsSingleMode()
		{
			return false;
		}

		public static bool IsQuestionMode()
		{
			return false;
		}

		public static bool IsAudience()
		{
			return false;
		}

		public static bool IsReplay()
		{
			return false;
		}

		public static bool IsOnlineMode()
		{
			return false;
		}

		public static EvalType EvaluatorGetEval(int player)
		{
			return default(EvalType);
		}

		public static string GetNextPath()
		{
			return null;
		}

		public static int[] GetMrkByFinishType(Engine.FinishType finishType)
		{
			return null;
		}

		public static int GetSleeveId(int uniqueId)
		{
			return 0;
		}

		public static int GetSleeveIdFromPlayer(int player)
		{
			return 0;
		}

		public static int GetFaceIconIdFromPlayer(int player)
		{
			return 0;
		}

		public static int GetFaceIconFrameIdFromPlayer(int player)
		{
			return 0;
		}

		public static int GetAvatarIconIdFromPlayer(int player)
		{
			return 0;
		}

		public static int GetAvatarStandIdFromPlayer(int player)
		{
			return 0;
		}

		public static int GetGraveIdFromPlayer(int player)
		{
			return 0;
		}

		public static int GetMatIdFromPlayer(int player)
		{
			return 0;
		}

		public static long GetPcodeFromPlayer(int player)
		{
			return 0L;
		}

		public static bool IncludeMySelf()
		{
			return false;
		}

		public static int GetRankFromPlayer(int player)
		{
			return 0;
		}

		public static PlatformID GetPlatformID(int player)
		{
			return default(PlatformID);
		}

		public static int Myself()
		{
			return 0;
		}

		public static int FirstPlayer()
		{
			return 0;
		}

		public static OpeningMessageType GetOpeningMessageType(int player)
		{
			return default(OpeningMessageType);
		}

		public static string GetOpeningMessageBgPath(int player)
		{
			return null;
		}

		public static string GetOpeningMessageText(int player)
		{
			return null;
		}

		public static string GetUserName(int player)
		{
			return null;
		}

		public static string GetMaskedName(int idx)
		{
			return null;
		}

		public static int GetSpAccountTypeid(int player)
		{
			return 0;
		}

		public static bool IsBlockRelativeCardList()
		{
			return false;
		}

		public static bool IsSpFieldUsed()
		{
			return false;
		}

		public static int GetDuelistLevel(int player)
		{
			return 0;
		}

		public static string GetRankText(int player)
		{
			return null;
		}

		public static string[] GetRankIconPaths(int player)
		{
			return null;
		}

		public static string GetUserDetailBgPath(int player)
		{
			return null;
		}

		public static int GetCountryId(int player)
		{
			return 0;
		}

		public static string GetCountryName(int player)
		{
			return null;
		}

		public static bool IsNewCountry(int player)
		{
			return false;
		}

		public static string[] GetFreeTextOfWin(int player)
		{
			return null;
		}

		public static bool FreeTextOfWinExists(int player)
		{
			return false;
		}

		public static string GetFreeTextOfTurnChange(int player)
		{
			return null;
		}

		public static bool FreeTextOfTurnChangeExists(int player)
		{
			return false;
		}

		public static bool GetRealtimeSpectate()
		{
			return false;
		}

		public static (int, int, PvpMenuDefine.MatchingType) GetLogoInfo(int logoMixID)
		{
			return default((int, int, PvpMenuDefine.MatchingType));
		}

		public static (int, int, PvpMenuDefine.MatchingType) GetLogoInfoFromClientWork()
		{
			return default((int, int, PvpMenuDefine.MatchingType));
		}

		public static int GetDuelLiveContinuousCount()
		{
			return 0;
		}

		public static bool IsDuelLiveCoutinuous()
		{
			return false;
		}

		public static void DecDuelLiveContinuousCount()
		{
		}

		public static void SetDuelLiveCoutinuousCount(int count)
		{
		}

		public static AttackLevel GetAttackLevel(int atk)
		{
			return default(AttackLevel);
		}

		public static byte[] GetQuestionData(int qid)
		{
			return null;
		}

		public static string GetDuelEndReasonTextFormat(Engine.ResultType resultType, Engine.FinishType finishType, string playerNameNear, string playerNameFar)
		{
			return null;
		}

		public static string GetDuelEndReasonText(string textFormat, Engine.ResultType resultType, Engine.FinishType finishType, string playerNameNear, string playerNameFar)
		{
			return null;
		}

		public static int PvpNetworkTimedOutThrethold(int defaultTime = 30)
		{
			return 0;
		}

		public static int GetCardOwner(int uniqueId)
		{
			return 0;
		}

		public static bool IsPveMode()
		{
			return false;
		}

		public static bool IsPvPMode()
		{
			return false;
		}

		public static int GetReplayMaxTurn()
		{
			return 0;
		}

		public static PublicLevel GetPublicLevel()
		{
			return default(PublicLevel);
		}

		public static int GetChapter()
		{
			return 0;
		}

		public static bool IsRentalDeck()
		{
			return false;
		}

		public static Dictionary<string, object> GetPlayerProfile(int player, bool isMyself)
		{
			return null;
		}

		public static bool GetIsSameOS(int player, bool myself)
		{
			return false;
		}

		public static string GetOnlineID(int player, bool isSameOS)
		{
			return null;
		}

		public static DisplayType GetDisplayType()
		{
			return default(DisplayType);
		}

		public static bool IsMobileLayout()
		{
			return false;
		}

		public static bool IsCameraTypeNear()
		{
			return false;
		}

		public static Vector3 ScreenPointToFixedHeightWorldPoint(Vector2 screenPoint, float height, Camera camera)
		{
			return default(Vector3);
		}

		public static bool IsStrategicTutorial()
		{
			return false;
		}

		public static bool IsTutorialDone()
		{
			return false;
		}

		public static SettingsUtil.DuelParam.CHAIN_TYPE GetChainTypeSetting()
		{
			return default(SettingsUtil.DuelParam.CHAIN_TYPE);
		}

		public static bool IsDecisionActivationOrder()
		{
			return false;
		}

		public static bool IsAutoLocation()
		{
			return false;
		}

		public static bool UseRetry()
		{
			return false;
		}

		public static bool IsAutoShowCardInfo(bool cardShow)
		{
			return false;
		}

		public static bool IsShowCardReport()
		{
			return false;
		}

		public static bool IsShowAudienceInfo()
		{
			return false;
		}

		public static bool IsShowBattleStep()
		{
			return false;
		}

		public static bool IsShowSetCard()
		{
			return false;
		}

		public static SettingsUtil.DuelParam.MANUAL_TYPE GetManualType()
		{
			return default(SettingsUtil.DuelParam.MANUAL_TYPE);
		}

		public static SettingsUtil.SHOW_HAPPENEDEFFECT_TYPE GetHappenedEffectType()
		{
			return default(SettingsUtil.SHOW_HAPPENEDEFFECT_TYPE);
		}

		public static bool IsFastestReplay()
		{
			return false;
		}

		public static bool IsSkipSummonEffect(Engine.SpSummonType spSummonType)
		{
			return false;
		}

		public static void RecordPlayedSpSummonEffectType(Engine.SpSummonType spSummonType)
		{
		}

		public static bool IsSkipMonsterCutin(int cardID)
		{
			return false;
		}

		public static void RecordPlayedMonsterCutinCardID(int cardID)
		{
		}

		public static bool IsSkipCardRunEffect(int cardID)
		{
			return false;
		}

		public static void RecordPlayedCardRunEffectCardID(int cardID)
		{
		}

		public static bool IsHidePlayerName()
		{
			return false;
		}

		public static bool UseDoubleClickDecide()
		{
			return false;
		}

		public static (SharedDefinition.Location, int, int, int, int) GetCrossPos(SharedDefinition.Location location, int centerPosition)
		{
			return default((SharedDefinition.Location, int, int, int, int));
		}

		public static bool IsInsightTargetCard(int player, int position, bool showSetCardOption)
		{
			return false;
		}

		public static bool IsStatusDetailTargetCard(int position)
		{
			return false;
		}

		public static int GetTotalAtk(int player)
		{
			return 0;
		}

		public static void ShowProfileCard(Transform parent, Transform buttonParent, int player, bool isMyself, bool force, Dictionary<string, object> profileData = null)
		{
		}

		public static GameObject ShowProfileCard(Transform parent, Transform buttonParent, bool force, Dictionary<string, object> profileData)
		{
			return null;
		}

		public static bool IsFixedPositonCommand()
		{
			return false;
		}

		public static int GetStyleID(int uniqueID)
		{
			return 0;
		}

		public static bool UseKeyActivateToggle()
		{
			return false;
		}

		public static void UpdateOverrider(GameObject gob, bool force = false)
		{
		}
	}
}
