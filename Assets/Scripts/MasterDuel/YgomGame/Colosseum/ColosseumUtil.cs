using System;
using System.Collections.Generic;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomGame.Team;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Colosseum
{
	public class ColosseumUtil
	{
		public enum StatusTournament
		{
			NOT_WATCHED_START = -3,
			NOT_ENTRY = -2,
			ENTRY_IMPOSSIBLE = -1,
			ENTRY_POSSIBLE = 0,
			ENTRY = 1,
			JOIN = 2,
			DEFEATED = 3,
			RESULT_UNRECV = 4,
			RESULT_RECV = 5,
			STATUS_RESULT_NO_ENTRY = 6
		}

		public enum StatusTournamentHolding
		{
			PRECEDE = 0,
			ENTRY = 1,
			START = 2,
			FINISH = 3,
			CLOSE = 4
		}

		public enum StatusExhibition
		{
			BEFORE_HOLDING = -1,
			NOT_WATCHED_START = 0,
			HOLDING = 1,
			AFTER_HOLDING = 2
		}

		public enum StatusRankEvent
		{
			TERM_STATUS_PREPARE = 0,
			TERM_STATUS_OPEN = 1,
			TERM_STATUS_START = 2,
			TERM_STATUS_END = 3,
			TERM_STATUS_RESULT_END = 4
		}

		public enum StatusRankEventUser
		{
			STATUS_NONE = 0,
			STATUS_JOIN = 1
		}

		public enum StatusDuelistCup
		{
			USER_STATUS_NO_ENTRY = 0,
			USER_STATUS_ENTRY = 1,
			USER_STATUS_STAGE_1ST = 2,
			USER_STATUS_STAGE_2ND = 3,
			USER_STATUS_PRE_RESULT = 4,
			USER_STATUS_RESULT = 5,
			USER_STATUS_RESULT_COMP = 6
		}

		public enum StatusDuelTrial
		{
			TERM_STATUS_PREPARE = 0,
			TERM_STATUS_OPEN = 1,
			TERM_STATUS_START = 2,
			TERM_STATUS_END = 3,
			TERM_STATUS_RESULT_END = 4
		}

		public enum StatusVersus
		{
			TERM_STATUS_PREPARE = 0,
			TERM_STATUS_OPEN = 1,
			TERM_STATUS_START = 2,
			TERM_STATUS_END = 3,
			TERM_STATUS_RESULT_OPEN = 4,
			TERM_STATUS_RESULT_END = 5
		}

		public enum TransitionProcess
		{
			NONE = 0,
			NORMAL = 1,
			QUICK = 2
		}

		public enum RankingType
		{
			SCORE = 0,
			WINLOSE = 1
		}

		public enum ChallengeMode
		{
			STANDARD = 1,
			BOT = 10
		}

		public enum StandardRank
		{
			ROOKIE = 1,
			BRONZE = 2,
			SILVER = 3,
			GOLD = 4,
			PLATINUM = 5,
			DIAMOND = 6,
			MASTER = 7,
			TEMP08 = 8,
			TEMP09 = 9,
			TEMP10 = 10
		}

		public enum Turn
		{
			FIRST = 0,
			SECOND = 1,
			RANDOM = 2,
			NONE = 10
		}

		public enum PlayMode
		{
			NONE = 0,
			RANK = 1,
			TOURNAMENT = 2,
			ROOM = 3,
			EXHIBITION = 4,
			FREE = 5,
			DUELISTCUP = 6,
			RANKEVENT = 7,
			TEAMMATCH = 8,
			DUELTRIAL = 9,
			WCS = 10,
			VERSUS = 11,
			WCS_FINAL = 12
		}

		public enum Region
		{
			NONE = 0,
			JAPAN = 1,
			ASIA = 2,
			NORTH_AMERICA = 3,
			LATIN_AMERICA = 4,
			EUROPE_OTHER = 5
		}

		public static void CallDuelBeginPvE(ViewControllerManager manager, Util.GameMode gameMode, int tid = 0, bool isSwap = false)
		{
		}

		public static void CallDuelBeginSolo(ViewController swapTarget, ViewControllerManager manager, int chapterID, Turn turn = Turn.NONE)
		{
		}

		public static void StartMatching(ViewControllerManager manager, PvpMenuDefine.MatchingType type, PvpMenuDefine.MatchingType match, int id = 0, int logoId = 0, int rentalState = 0, int researchTime = 0)
		{
		}

		public static void StartMatchingTeam(ViewControllerManager manager, bool isLeader, OpponentTeamInfo oppTeamInfo = null)
		{
		}

		private static void StartMatching(ViewControllerManager manager, PvpMenuDefine.MatchingType type, PvpMenuDefine.MatchingType match, Dictionary<string, object> duelParams, Dictionary<string, object> matchingParams, Dictionary<string, object> otherParams = null)
		{
		}

		public static void CallTournamentEntry(int tid, Action endAction = null)
		{
		}

		public static string GetOrderString(int order, bool changeScale = true)
		{
			return null;
		}

		public static void CallAPIDeckCheck(PlayMode playMode, int tid = 0, Action onFinish = null, int regulationId = 0)
		{
		}

		public static void CallAPIPlayReplay(Util.GameMode gameMode, long did, int idx = 0, int eid = 0, Action<PvPCode> onFailed = null)
		{
		}

		public static string GetResultStringWithColor(Engine.ResultType resultType)
		{
			return null;
		}

		public static void HandleResultCodeDuelMenu(Handle handle, Action onSuccess = null, Action<DuelMenuCode> onFailed = null)
		{
		}

		public static void HandleResultCodeChallenge(Handle handle, Action onSuccess = null, Action<ChallengeCode> onFailed = null)
		{
		}

		public static void HandleResultCodeTournament(Handle handle, Action onSuccess = null, Action<TournamentCode> onFailed = null)
		{
		}

		public static void HandleResultCodeExhibition(Handle handle, Action onSuccess = null, Action<ExhibitionCode> onFailed = null)
		{
		}

		public static void HandleResultCodeCasual(Handle handle, Action onSuccess = null, Action<CasualCode> onFailed = null)
		{
		}

		public static void HandleResultCodeRankEvent(Handle handle, Action onSuccess = null, Action<RankEventCode> onFailed = null)
		{
		}

		public static void HandleResultCodeCup(Handle handle, Action onSuccess = null, Action<CupCode> onFailed = null)
		{
		}

		public static void HandleResultCodeWcs(Handle handle, Action onSuccess = null, Action<WcsCode> onFailed = null)
		{
		}

		public static void HandleResultCodeDuelTrial(Handle handle, Action onSuccess = null, Action<DuelTrialCode> onFailed = null)
		{
		}

		public static void HandleResultCodeVersus(Handle handle, Action onSuccess = null, Action<VersusCode> onFailed = null)
		{
		}

		public static bool PopColosseumViewControler(PlayMode playMode)
		{
			return false;
		}

		public static void OpenItemConfirmDialogUnpackRight(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, Action closeCallback = null, bool hideNum = false, int shopId = 0)
		{
		}
	}
}
