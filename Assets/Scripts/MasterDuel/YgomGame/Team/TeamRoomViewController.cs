using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team
{
	public class TeamRoomViewController : BaseMenuViewController, TeamLobbyPollingWatcher.ICallback, IHeaderBorderSupported
	{
		internal abstract class TeamBehaviour
		{
			internal class TableData
			{
				internal MemberData member;

				internal string regulation;

				internal int regulationID;

				internal int index;

				internal bool entry
				{
					[CompilerGenerated]
					get
					{
						return false;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public TableData(MemberData member, int regulationID, string regulation, int index, bool entry)
				{
				}
			}

			internal class MemberData
			{
				internal long pcode;

				internal string name;

				internal int iconID;

				internal int iconFrameID;

				internal int commentID;

				internal bool isResistedPlatform;

				internal bool isSamePlatform;

				internal string platformName;

				internal string regulation;

				internal bool isMyAccount;
			}

			internal class TeamRoomInfo
			{
				internal int teamID;

				internal string roomName;

				internal long roomMasterID;

				internal int memberNum;

				internal int roomSpecterID;

				internal int specterNum;

				internal int memberMax;

				internal int regID;

				internal string regulation;

				internal int roomComment;

				internal int cardMrk;
			}

			protected readonly string BTN_LABEL;

			protected readonly string TXT_LABEL;

			protected readonly string ROOT_MENU_LABEL;

			protected readonly string TMP_BTN_MENU_LABEL;

			protected readonly string BTN_EXIT_LABEL;

			protected readonly string BTN_DECK_LABEL;

			protected readonly string BTN_DECK_READONLY_LABEL;

			protected readonly string CARD_AREA_LABEL;

			protected readonly string IMG_ICON_LABEL;

			protected readonly string PLATFORM_NAME_LABEL;

			protected readonly string PLATFORM_ICON_LABEL;

			protected readonly string TXT_TITLE_LABEL;

			protected readonly string TXT_ROOM_MEMBER_LABEL;

			protected readonly string TXT_TEAM_NAME_LABEL;

			protected readonly string BTN_COMMENT_LEFT_LABEL;

			protected readonly string BTN_ENTRY_LABEL;

			protected readonly string TXT_ENTRY_BUTTON_STATUS_LABEL;

			protected readonly string BTN_LEAVE_LABEL;

			protected readonly string OBJ_COMMENT_LABEL;

			protected readonly string TXT_COMMENT_LABEL;

			protected readonly string OBJ_CARDIMAGE_LABEL;

			protected readonly string TMP_SMALLBUTTON_LABEL;

			protected readonly string OBJ_SMALLBUTTON_GROUP_LABEL;

			protected readonly string BTN_REGULATION_LABEL;

			protected readonly string BTN_DECIDE_LABEL;

			protected readonly string BTN_DECIDE_DESIGNATION_LABEL;

			internal readonly ViewControllerManager manager;

			internal readonly TeamRoomViewController vc;

			internal readonly ElementObjectManager viewEom;

			protected long myPcode;

			protected bool isSitting;

			protected string beforeRoomName;

			protected readonly string[] tableComments;

			internal Dictionary<int, string> regulationList;

			internal int mySelectRegulationId;

			private int callingApiCount;

			internal int currentDeckId;

			internal TeamRoomInfo teamRoomInfo;

			internal List<TableData> tableDataList;

			protected DeckCaseWidget deckCase;

			protected StringBuilder deckNameBuf;

			internal int dataCount;

			internal int teamCardId;

			internal bool isRoomInfoExist;

			internal bool isStartTeamDuelMatching;

			internal bool isStartTeamMateMatching;

			internal bool isOpenWatingWindow;

			internal bool isTeamMemberRecruted;

			internal bool isSearchedMember;

			internal bool isClickedTeamMemberMatching;

			protected bool _isLeader;

			internal Dictionary<int, GameObject> _tableTemplates;

			protected internal TeamLobbyPollingWatcher watchDog;

			protected List<(int, string, int, int)> _duelDurationConfigItems;

			internal bool isCallingApi => false;

			internal TeamBehaviour(ViewControllerManager manager, TeamRoomViewController vc, ElementObjectManager viewEom)
			{
			}

			internal virtual void PlayDUELBtnTextChanging(string text)
			{
			}

			internal virtual void StopDUELBtnTextChanging()
			{
			}

			internal virtual void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
			{
			}

			internal virtual void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
			{
			}

			internal virtual void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
			{
			}

			internal virtual void Onterminal()
			{
			}

			internal abstract void Initialize();

			protected abstract void CreateMenuButtons(Action onFinished = null);

			internal void OnRemove()
			{
			}

			public bool OnClickActionWithCheckSitting(UnityAction onFinish)
			{
				return false;
			}

			public void OnClickActionStartDuel(UnityAction onFinish)
			{
			}

			public void OnClickExitButton()
			{
			}

			public void ShowCompleteEffect()
			{
			}

			protected SelectionButton CreateMenuButton(Selector selector, GameObject template, string label, UnityAction onClick = null, bool isDefaultItem = false, bool isCheck = false)
			{
				return null;
			}

			protected void ChangeButtonCallback(SelectionButton button, UnityAction newAction, bool isSittingCheck = false)
			{
			}

			internal void SetCallbackInputLeft(SelectionButton btn)
			{
			}

			protected GameObject CreateTableTemplate(GameObject template)
			{
				return null;
			}

			internal virtual void SetTeamRoomInfo()
			{
			}

			internal void SetBGCard(int mrk, bool active = true)
			{
			}

			internal virtual void UpdateRoom()
			{
			}

			internal virtual void UpdateTable()
			{
			}

			internal virtual void SetTeamTable(bool isUpdateDataCount = false)
			{
			}

			internal void UpdateDeck()
			{
			}

			internal virtual bool SetDeck(int did)
			{
				return false;
			}

			protected void LoadDuelDurationConfig()
			{
			}

			public static Dictionary<string, object> GetTeamInfo()
			{
				return null;
			}

			public static List<object> GetTeamTable()
			{
				return null;
			}

			public static Dictionary<string, object> GetTeamMemberInfo(long pcode)
			{
				return null;
			}

			public static int GetTeamComment(long pcode)
			{
				return 0;
			}

			public static Dictionary<string, object> GetTeamRegulation()
			{
				return null;
			}

			public static Dictionary<string, object> GetDeckInfo()
			{
				return null;
			}

			protected void AddCallingCount()
			{
			}

			protected void DecCallingCount()
			{
			}

			internal virtual void CallAPIDeckCheck(Action onFinish = null)
			{
			}

			internal void CallAPITeamExitRoom()
			{
			}

			internal void CallAPITeamRoomTablePoling(Action onFinish = null, bool init = false)
			{
			}

			internal void OnTablePollingResponsed(Handle handle, Action onFinish, bool init)
			{
			}

			internal virtual void CallAPITeamTableArrive(int tableNo)
			{
			}

			internal virtual void CallAPITeamTableLeave(UnityAction onSuccess = null)
			{
			}

			internal virtual void CallAPIRoomSetUserComment(int commentID)
			{
			}

			internal void OnErrorCallAPI(TeamCode teamCode)
			{
			}
		}

		internal class TeamBehaviourNormal : TeamBehaviour
		{
			private enum MenuBtn
			{
				NONE = 0,
				INFO = 1,
				MEMBER = 2,
				INVITE = 3,
				RECRUIT = 4,
				REGULATION = 5,
				DECK = 6,
				DECK_READONLY = 7,
				APPLY_TEAM_ID = 8
			}

			private Dictionary<int, SelectionButton> _menuButtonmap;

			private SelectionButton _duelButton_random;

			private SelectionButton _duelButton_designation;

			private List<string> regulationStringList;

			private int[] regulationIntList;

			private bool NotAllMR;

			private ExtendedTextMeshProUGUI _teamIdApplyText;

			public TeamBehaviourNormal(ViewControllerManager manager, TeamRoomViewController vc, ElementObjectManager viewEom)
				: base(null, null, null)
			{
			}

			internal override void Initialize()
			{
			}

			internal override void SetTeamRoomInfo()
			{
			}

			internal override void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
			{
			}

			internal override void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
			{
			}

			internal override void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
			{
			}

			protected void CreateTableTemplates()
			{
			}

			internal override void SetTeamTable(bool isEntry = false)
			{
			}

			protected override void CreateMenuButtons(Action onFinished = null)
			{
			}

			private void setRegualtionIntList(Dictionary<string, object> value)
			{
			}

			private void RestrictMenuButtons(bool on)
			{
			}

			private void RestrictEachMenuButton(MenuBtn kind, SelectionButton button, bool on)
			{
			}

			internal override void UpdateTable()
			{
			}

			private void SetComment(ElementObjectManager playerEom, MemberData member)
			{
			}

			private void ForceSetComment(ElementObjectManager playerEom, bool isSetShow)
			{
			}

			private void SetDUELButtonPushable(bool pushable)
			{
			}

			internal override void PlayDUELBtnTextChanging(string text)
			{
			}

			internal override void StopDUELBtnTextChanging()
			{
			}

			private void ChangeTeamIDDesignateButton(bool designatable)
			{
			}

			private void OnClickDeck()
			{
			}

			private void OnGoingToDesignation()
			{
			}

			private void OnCancelingDesignation()
			{
			}
		}

		[SerializeField]
		private ElementObjectManager _deckOverview;

		private TeamBehaviour teamBehaviour;

		private bool isBackDuelClientError;

		protected override Type[] textIds => null;

		protected bool existDialog => false;

		private IEnumerator waitPolling()
		{
			return null;
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

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		protected override void OnCreatedView()
		{
		}

		public void OnPollingResponse(Handle handle)
		{
		}

		public void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
		{
		}

		public void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
		{
		}

		public void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
		{
		}
	}
}
