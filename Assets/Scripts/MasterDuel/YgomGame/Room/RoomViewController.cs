using System;
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
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room
{
	public class RoomViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		internal abstract class RoomBehaviour
		{
			internal enum TableStatus
			{
				WAIT = 1,
				READY_RIGHT = 2,
				READY_LEFT = 3,
				DUEL = 4,
				SPECTATE = 5
			}

			internal class TableData
			{
				internal MemberData[] members;

				internal TableStatus status;

				internal bool myPlayerEntry
				{
					[CompilerGenerated]
					get
					{
						return false;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public TableData(MemberData[] members, TableStatus status, bool myPlayerEntry)
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
			}

			internal class RoomInfo
			{
				internal int roomID;

				internal string roomName;

				internal long roomMasterID;

				internal int memberNum;

				internal int roomSpecterID;

				internal int specterNum;

				internal int memberMax;

				internal int regID;

				internal string regulation;

				internal int roomComment;

				internal bool canEnterFree;

				internal bool canWatchRoom;

				internal bool canWatchEnterFree;

				internal int havePlayTime;

				internal int LP;

				internal bool canWatchReplay;

				internal int regID_in_client => 0;
			}

			protected readonly string BTN_LABEL;

			protected readonly string ROOT_MENU_LABEL;

			protected readonly string TMP_BTN_MENU_LABEL;

			protected readonly string TXT_LABEL;

			protected readonly string BTN_EXIT_LABEL;

			protected readonly string BTN_DECK_LABEL;

			protected readonly string BTN_DECK_READONLY_LABEL;

			protected readonly string BTN_ENTRY_LABEL;

			protected readonly string BTN_COMMENT_RIGHT_LABEL;

			protected readonly string BTN_COMMENT_LEFT_LABEL;

			protected readonly string BTN_LEAVE_LABEL;

			protected readonly string TXT_ROOM_MEMBER_LABEL;

			protected readonly string TXT_ROOM_NAME_LABEL;

			protected readonly string TXT_ROOM_WATCHER_LABEL;

			protected readonly string ROOT_ROOM_WATCHER_LABEL;

			protected readonly string IMG_ICON_LABEL;

			protected readonly string TXT_TITLE_LABEL;

			protected readonly string TXT_REGULATION_LABEL;

			protected readonly string ICON_REGULATION_LABEL;

			protected readonly string PLATFORM_NAME_LABEL;

			protected readonly string PLATFORM_ICON_LABEL;

			protected readonly string TXT_STATUS_LABEL;

			protected readonly string TXT_COMMENT_LABEL;

			protected readonly string OBJ_COMMENT_LABEL;

			private int callingApiCount;

			internal readonly ViewControllerManager manager;

			internal readonly RoomViewController vc;

			internal readonly ElementObjectManager viewEom;

			internal readonly InfinityScrollView isv;

			internal RoomInfo roomInfo;

			internal List<TableData> tableDataList;

			protected long myPcode;

			protected bool isSittingPlayer;

			protected readonly string[] tableComments;

			protected string beforeRoomName;

			internal bool isCallingAPI => false;

			internal RoomBehaviour(ViewControllerManager manager, RoomViewController vc, ElementObjectManager viewEom, InfinityScrollView isv)
			{
			}

			internal virtual void OnTerminal()
			{
			}

			internal abstract void InitRoom();

			internal virtual void UpdateTable(ElementObjectManager eom, int index)
			{
			}

			internal virtual void OnCreatedEntity(GameObject go)
			{
			}

			private void SetComment(ElementObjectManager playerEom, MemberData member)
			{
			}

			private void ForceSetComment(ElementObjectManager playerEom, bool isSetShow)
			{
			}

			public bool OnClickActionWithCheckSitting(UnityAction onFinish)
			{
				return false;
			}

			protected abstract void CreateMenuButtons();

			protected SelectionButton CreateMenuButton(Selector selector, GameObject template, string label, UnityAction onClick = null, bool isDefaultItem = false)
			{
				return null;
			}

			internal virtual void SetRoomInfo()
			{
			}

			internal virtual void UpdateRoom()
			{
			}

			internal virtual void SetTable(bool isUpdateDataCount = false)
			{
			}

			protected void OnClickExitButton()
			{
			}

			protected void AddCallingCount()
			{
			}

			protected void DecCallingCount()
			{
			}

			protected virtual void CallAPIRoomExit()
			{
			}

			internal virtual void CallAPIRoomTablePoling(Action onFinish = null, bool isInit = false)
			{
			}

			internal virtual void CallAPIRoomTableArrive(int tableNo)
			{
			}

			internal virtual void CallAPIRoomTableLeave(UnityAction onSuccess = null)
			{
			}

			internal virtual void CallAPIRoomBattleReady(bool isReady, long rivalPcode = 0L)
			{
			}

			internal virtual void CallAPIRoomSetUserComment(int commentID)
			{
			}

			protected void CallAPIPvPWatchDuel(long pcode)
			{
			}

			internal void OnErrorCallAPI(RoomCode roomCode)
			{
			}
		}

		internal class RoomBehaviourNormal : RoomBehaviour
		{
			private enum MenuBtn
			{
				NONE = 0,
				INFO = 1,
				MEMBER = 2,
				REPLAY = 3,
				INVITE = 4,
				DECK = 5,
				DECK_READONLY = 6
			}

			private enum DeckSelectKind
			{
				EDIT = 0,
				CHANGE = 1,
				CONFIRM = 2
			}

			private Dictionary<int, SelectionButton> _menuButtonmap;

			protected DeckCaseWidget deckCase;

			protected StringBuilder deckNameBuf;

			private int currentDeckId;

			public RoomBehaviourNormal(ViewControllerManager manager, RoomViewController vc, ElementObjectManager viewEom, InfinityScrollView isv)
				: base(null, null, null, null)
			{
			}

			internal override void OnTerminal()
			{
			}

			protected override void CreateMenuButtons()
			{
			}

			internal override void InitRoom()
			{
			}

			internal override void UpdateTable(ElementObjectManager eom, int index)
			{
			}

			internal override void OnCreatedEntity(GameObject go)
			{
			}

			private void UpdateDeck()
			{
			}

			internal virtual bool SetDeck(int did)
			{
				return false;
			}

			internal virtual void CallAPIDeckCheck(Action onFinish = null)
			{
			}

			private void OnClickDeck()
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject entity)
			{
				return null;
			}

			internal override void SetTable(bool isUpdateDataCount = false)
			{
			}

			private void RestrictMenuButtons(bool on)
			{
			}

			private void GotoDeckSelect()
			{
			}

			private void OnSelectInActionSheet(int select)
			{
			}
		}

		internal class RoomBehaviourSpecter : RoomBehaviour
		{
			internal RoomBehaviourSpecter(ViewControllerManager manager, RoomViewController vc, ElementObjectManager viewEom, InfinityScrollView isv)
				: base(null, null, null, null)
			{
			}

			protected override void CreateMenuButtons()
			{
			}

			internal override void InitRoom()
			{
			}

			internal override void UpdateTable(ElementObjectManager eom, int index)
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject entity)
			{
				return null;
			}
		}

		private static class Util
		{
			internal static int GetValueFromAccessory(Dictionary<string, object> accessory, string keyName)
			{
				return 0;
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string SC_BACK_LABEL;

		[SerializeField]
		private ElementObjectManager _deckOverview;

		private RoomBehaviour roomBehaviour;

		private InfinityScrollView isv;

		private RoomEntryViewController.Mode mode;

		private float pastSec;

		protected override Type[] textIds => null;

		protected override int selectorPriorityAddRange => 0;

		protected bool existDialog => false;

		private void Update()
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

		protected override void OnCreatedView()
		{
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		public override bool OnBack()
		{
			return false;
		}

		private void UpdateEntity(GameObject gob, int index)
		{
		}

		public GameObject CreateEmbedObj(int deckId)
		{
			return null;
		}
	}
}
