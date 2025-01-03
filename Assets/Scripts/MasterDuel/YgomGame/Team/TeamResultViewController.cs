using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Team
{
	public class TeamResultViewController : BaseMenuViewController
	{
		internal enum ResultTableStatus
		{
			REPLAY = 1,
			SPECTATE = 2
		}

		internal enum ResultStatus
		{
			WAIT = 0,
			WIN = 1,
			LOSE = 2,
			DRAW = 3
		}

		internal class ResultTableData
		{
			internal MemberData[] members;

			internal string regulation;

			internal ResultStatus myResult;

			internal ResultStatus enemyResult;

			internal int regulationID;

			internal int index;

			internal long did;

			internal int progress;

			public ResultTableData(MemberData[] members, int index, int regulationID, string regulation, ResultStatus myResult, ResultStatus enemyResult, long did, int progress)
			{
			}
		}

		internal class MemberData
		{
			internal int pcode;

			internal string name;

			internal int iconID;

			internal int iconFrameID;

			internal int commentID;

			internal bool isResistedPlatform;

			internal bool isSamePlatform;

			internal string platformName;

			internal int platformID;

			internal int follow_num;

			internal int follower_num;

			internal int level;

			internal int rank;

			internal int rate;

			internal int exp;

			internal int need_exp;

			internal int wallpaper;

			internal ulong xuid;

			internal int avater_id;

			internal int edit;

			internal List<object> tag;

			internal int official;

			internal string onlineID;
		}

		internal class TeamResultRoomInfo
		{
			internal int teamID;

			internal int myCardMrk;

			internal int enemyCardMrk;

			internal int memberNum;

			internal long myTeamMasterID;

			internal long enemyTeamMasterID;

			internal int nextTeamID;
		}

		private static readonly string viewControllerPath;

		protected readonly string OBJ_COMMENT_LABEL;

		protected readonly string OBJ_TABLE_TMP_LABEL;

		protected readonly string TXT_COMMENT_LABEL;

		protected readonly string SCROLL_LABEL;

		protected readonly string IMG_LEFT_BG_CARD_LABEL;

		protected readonly string IMG_RIGHT_BG_CARD_LABEL;

		protected readonly string TXT_TMP_TITLE_LABEL;

		protected readonly string OBJ_RESULTLIST_LABEL;

		protected readonly string OBJ_WLD_AREA_LABEL;

		protected readonly string TEXT_WIN_LABEL;

		protected readonly string TEXT_LOSE_LABEL;

		protected readonly string TEXT_DRAW_LABEL;

		protected readonly string OBJ_PLAYER_LEFT_LABEL;

		protected readonly string OBJ_PLAYER_RIGHT_LABEL;

		protected readonly string OBJ_TEAM_LEFT_CROWN_LABEL;

		protected readonly string OBJ_TEAM_RIGHT_CROWN_LABEL;

		protected readonly string OBJ_TEAM_LEFT_SCORE_LABEL;

		protected readonly string OBJ_TEAM_RIGHT_SCORE_LABEL;

		protected readonly string TXT_TEAM_NAME_LEFT_LABEL;

		protected readonly string TXT_TEAM_NAME_RIGHT_LABEL;

		protected readonly string BTN_EXIT_LABEL;

		protected readonly string BTN_REORGANIZE_LABEL;

		protected readonly string BTN_COMMENT_LEFT_LABEL;

		protected readonly string BTN_REPLAY_LABEL;

		protected readonly string TXT_ROOM_MEMBER_LABEL;

		protected readonly string BTN_PROFILE_LABEL;

		protected readonly string IMG_ICON_LABEL;

		protected readonly string PLATFORM_NAME_LABEL;

		protected readonly string PLATFORM_ICON_LABEL;

		protected long myPcode;

		private int leftScore;

		private int rightScore;

		private bool isFinishedResultEffect;

		private int callingApiCount;

		private string[] tableComments;

		internal Dictionary<int, string> regulationList;

		internal List<ResultTableData> resultTableDataList;

		internal TeamResultRoomInfo teamResultRoomInfo;

		private bool isReorgaButtonActive;

		private ResultStatus teamResultStatus;

		private Dictionary<int, GameObject> _tableTemplates;

		private float pastSec;

		private int myid;

		private bool isResultError;

		private GameObject profileParent;

		protected override Type[] textIds => null;

		private bool isCallingApi => false;

		protected bool existDialog => false;

		public static void Open(ViewControllerManager manager)
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Init()
		{
		}

		private void Update()
		{
		}

		internal void SetBGCard(int mrk, string label, bool off = false)
		{
		}

		protected void OnClickExitButton()
		{
		}

		protected void CreateTableTemplates()
		{
		}

		protected GameObject CreateTableTemplate(GameObject template, UnityAction onClick = null)
		{
			return null;
		}

		private void SetTeamInfo()
		{
		}

		internal void SetTeamTable(bool init = false)
		{
		}

		internal void UpdateTeamResultView()
		{
		}

		private void OnClickRecreateButton()
		{
		}

		public bool OnClickActionWithCheck(UnityAction onFinish)
		{
			return false;
		}

		public bool OnClickActionWithCheckRecreate(UnityAction onFinish)
		{
			return false;
		}

		internal void UpdateTabel()
		{
		}

		private void OnClickReplayButton(ResultTableData data)
		{
		}

		private void OnClickProfileButton(MemberData data)
		{
		}

		private void setActiveFooter(bool active)
		{
		}

		private void ShowTableResultText(ElementObjectManager eom, ResultStatus status)
		{
		}

		private void SetComment(ElementObjectManager playerEom, MemberData member)
		{
		}

		private void ForceSetComment(ElementObjectManager playerEom, bool isSetShow)
		{
		}

		private IEnumerator PlayResultEffect(Action onFinished = null)
		{
			return null;
		}

		private Dictionary<string, object> SetProfCardArgs(MemberData data)
		{
			return null;
		}

		private static Dictionary<string, object> GetTeamResultInfo()
		{
			return null;
		}

		private static List<object> GetTeamResultTableInfoList()
		{
			return null;
		}

		private static List<object> GetTeamResultTableResultList()
		{
			return null;
		}

		private static Dictionary<string, object> GetTeamResultDuelResult()
		{
			return null;
		}

		public static int GetTeamComment(long pcode)
		{
			return 0;
		}

		private static int GetTeamID()
		{
			return 0;
		}

		protected void AddCallingCount()
		{
		}

		protected void DecCallingCount()
		{
		}

		internal void CallAPITeamResultTablePoling(Action onFinish = null)
		{
		}

		internal virtual void CallAPIRoomSetUserComment(int commentID)
		{
		}

		internal void OnErrorCallAPI(TeamCode teamCode)
		{
		}

		internal void CallAPITeamCreate(Action onSuccess)
		{
		}

		internal void CallAPITeamEntryNewTeam(int teamId, Action onSuccess)
		{
		}

		protected void CallAPIPvPWatchDuel(long pcode)
		{
		}

		public static void CallAPIPlayReplay(Util.GameMode gameMode, long did, int idx = 0, int eid = 0, Action<PvPCode> onFailed = null)
		{
		}

		internal void CallAPITeamExitRoom()
		{
		}
	}
}
