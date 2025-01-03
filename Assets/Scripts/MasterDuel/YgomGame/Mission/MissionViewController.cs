using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Help;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Mission
{
	public class MissionViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		public class MissionInOutPlayer
		{
			private const string k_PLabelSkipSpeed_RecieveFocusScroll = "SkipSpeed_RecieveFocusScroll";

			private const string k_PLabelSkipSpeed_PageSnap = "SkipSpeed_PageSnap";

			private const string k_PLabelSkipSpeed_TM = "SkipSpeed_TM";

			private const string k_PLabelSkipSpeed_GoalRecieveBetweenWait = "SkipSpeed_GoalRecieveBetweenWait";

			private const string k_PLabelSkipSpeed_GoalRecieved = "SkipSpeed_GoalRecieved";

			private const string k_PLabelBuilRecieveSE_Check = "BuilRecieveSE_Check";

			private const string k_PLabelBuilRecieveSE_CheckSkip = "BuilRecieveSE_CheckSkip";

			private readonly List<int> m_EntryMissions;

			private readonly List<int> m_HidedMissions;

			private readonly List<int> m_RemovedMissions;

			private readonly List<int> m_RecievedMissions;

			private readonly List<int> m_RecievedGoalPoss;

			private MissionViewController m_VC;

			private Selector m_CoverSelector;

			private SelectionButton m_SkipButton;

			private float m_PageSnapOriginalDuration;

			private Coroutine m_SequenceRoutine;

			private Action m_OnSkipCallback;

			public bool isPlaying => false;

			public Selector coverSelector => null;

			public SelectionButton skipButton => null;

			public void Init(MissionViewController vc, Selector coverSelector, SelectionButton skipButton)
			{
			}

			public void ClearEntryMissions()
			{
			}

			public void ClearRemoveMissions()
			{
			}

			public void ClearRecievedMissions()
			{
			}

			public void ClearHidedMissions()
			{
			}

			public void AddEntryMission(int missionId)
			{
			}

			public void AddRemoveMission(int missionId)
			{
			}

			public void AddRecievedMissions(List<int> missionIds, List<int> goalposs)
			{
			}

			public void AddHidedMission(int missionId)
			{
			}

			public void Terminate()
			{
			}

			public void Play(bool isResult = false, bool isBulk = false, Action onComplete = null)
			{
			}

			private IEnumerator yPlay(bool isResult = false, bool isBulk = false, Action onComplete = null)
			{
				return null;
			}

			private IEnumerator yPlayRecieved(List<int> recievedMissions, List<int> recievedGoalPoss, List<int> removedMissions, bool isFocus)
			{
				return null;
			}

			private IEnumerator yPlayRecievedResult(List<int> removedMissions, List<int> hidedMissions, bool isBulk = false)
			{
				return null;
			}

			private IEnumerator yPlayEntry(List<int> entryMissions, bool isRemovedMission)
			{
				return null;
			}

			private void CleanupRecieveCtxState()
			{
			}

			private void CleanupRecieveWidgetState()
			{
			}

			private IEnumerator yPlayTweenTarget(GameObject target, string label)
			{
				return null;
			}

			private List<int> PopReservedMissionIds(List<int> source)
			{
				return null;
			}

			private (List<int>, List<int>) PopReservedMissionPairIds(List<int> source, List<int> pairSource)
			{
				return default((List<int>, List<int>));
			}

			private void OnClickSkip()
			{
			}
		}

		private class WidgetFactory
		{
			private readonly PrefabObjectPool m_PrefabObjectPool;

			private readonly GameObject m_PagePref;

			private readonly IReadOnlyDictionary<MissionGoalWidget.GoalType, GameObject> m_GoalPrefMap;

			private readonly Dictionary<GameObject, MissionPanelWidget> m_PanelWidgetMap;

			private readonly Dictionary<GameObject, MissionGoalWidget> m_GoalWidgetMap;

			public Action<GameObject> onCreatedPageCallback;

			public WidgetFactory(Transform root, GameObject pagePref, GameObject goalInProgressPref, GameObject goalRecievablePref, GameObject goalCompletedPref)
			{
			}

			public IEnumerator yInitialReserve(int pageReq, Dictionary<MissionGoalWidget.GoalType, int> goalReq)
			{
				return null;
			}

			public MissionPanelWidget[] GetCreatedPanelWidgets()
			{
				return null;
			}

			public void ReservePage(int count = 1)
			{
			}

			public GameObject RentPage(GameObject owner)
			{
				return null;
			}

			public void ReserveGoal(MissionGoalWidget.GoalType goalType, int count = 1)
			{
			}

			public MissionGoalWidget RentGoal(MissionGoalWidget.GoalType goalType, GameObject owner)
			{
				return null;
			}

			public void ReturnGoal(MissionGoalWidget goalWidget)
			{
			}

			private void OnCreatedGoalPref(GameObject obj, MissionGoalWidget.GoalType goalType)
			{
			}
		}

		private const string k_RLabelTMPanelCompleteMission = "TMPanelCompleteMission";

		private const string k_RLabelTMPanelHideMission = "TMPanelHideMission";

		private const string k_RLabelTMPanelNewMission = "TMPanelNewMission";

		private const string k_RLabelTMPanelFocusMission = "TMPanelFocusMission";

		public const string k_PrefabPath = "Mission/Mission";

		private const string k_ArgKeyTabId = "tabId";

		private const string k_ArgKeyPoolId = "poolId";

		private readonly string k_ELabelFooterOverSelector;

		private readonly string k_ELabelTabList;

		private readonly string k_ELabelMissionList;

		private readonly string k_ELabelEmptyGroup;

		private readonly string k_ELabelEmptyText;

		private readonly string k_ELabelCancelButton;

		private readonly string k_ELabelBackShortcut;

		private readonly string k_ELabelAnalogDirectionItem;

		private readonly string k_ELabelCautionButton;

		private readonly string k_ELabelBulkRecieveButton;

		private readonly string k_ELabelInEffectCover;

		private readonly string k_ELabelInEffectSkipButton;

		private readonly string k_RLabelRecieveDialogListPref;

		[SerializeField]
		private string m_CautionHelpPath;

		private bool m_IsHighEnd;

		private int m_RegistedGoThroughPriority;

		private int m_GaugeStepLimit;

		private AssetReferer m_AssetReferer;

		private PropertyContainer m_PropertyContainer;

		private WidgetFactory m_WidgetFactory;

		private readonly MissionRootContext m_RootContext;

		private MissionInOutPlayer m_InOutPlayer;

		private MissionTabListWidget m_TabListWidget;

		private MissionListWidget m_MissionListWidget;

		private readonly Dictionary<GameObject, MissionTabWidget> m_TabWidgetsMap;

		private readonly Dictionary<GameObject, MissionPanelWidget> m_PanelWidgetsMap;

		private readonly Dictionary<GameObject, MissionGoalsWidget> m_GoalsWidgetsMap;

		private MissionBulkRecieveButtonWidget m_BulkRecieveButtonWidget;

		private readonly MissionSelectorHistory m_SelectorHistory;

		private MissionSelectorHistoryHandler m_MissionSelectorHistoryHandler;

		private HelpMappingData m_HelpMappingData;

		private List<int> m_DeletedBadgeIds;

		protected override bool setSurfaceActiveOnInitialize => false;

		protected override bool setProgressOnInitialize => false;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		private void OnUpdatedAll()
		{
		}

		private void OnUpdatedContainMissions()
		{
		}

		private void OnPrevChangeTabIndex(int oldIdx)
		{
		}

		private void OnChangeTabIndex(int newIdx)
		{
		}

		private void OnUpdatedTabNewEvent(int tabIdx)
		{
		}

		private void OnCreatedGoalHolder(MissionGoalHolderWidget goalHolderWidget)
		{
		}

		private void OnUpdateGoalHolder(MissionGoalHolderWidget goalHolderWidget, int idx)
		{
		}

		private void OnSelectedGoalHolder(MissionGoalHolderWidget goalHolder)
		{
		}

		private void OnDeselectedGoalHolder(MissionGoalHolderWidget goalHolder)
		{
		}

		private void OnClickGoalHolder(MissionGoalHolderWidget goalHolder)
		{
		}

		private void OnCreatedGoalPage(GameObject goalPageEntity, MissionPanelWidget ownerPanel)
		{
		}

		private void OnFocusGoalPage(GameObject goalPageEntity, int dataidx, bool isselect, bool initialize)
		{
		}

		private IReadOnlyList<(SelectionItem, int, int)> OnGoalCollectSelectionItems(GameObject goalPageEntity)
		{
			return null;
		}

		private void OnUpdateGoalPage(GameObject goalPageEntity, int idx)
		{
		}

		private void OnDeactivateGoalPage(GameObject goalPageEntity)
		{
		}

		private bool OnGoalEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		private void OnCreatedPanel(GameObject panelEntity)
		{
		}

		private IReadOnlyList<(SelectionItem, int, int)> OnPanelCollectSelectionItems(GameObject panelEntity)
		{
			return null;
		}

		private void OnActivatePanel(GameObject panelEntity)
		{
		}

		private void OnDeactivatePanel(GameObject panelEntity)
		{
		}

		private void OnUpdatePanel(GameObject panelEntity, int missionIdx)
		{
		}

		private void OnReadyUpdateGoalsPager(MissionGoalsPagerWidget goalsPager, int pageCount, int pageIdx)
		{
		}

		private void OnUpdateLimitTextCallback(TMP_Text text, long remainSec)
		{
		}

		private void OnUpdateRecieveLimitTextCallback(TMP_Text text, long remainSec)
		{
		}

		private bool OnSelectorSelectedPanel()
		{
			return false;
		}

		private void OnFocusPanel(GameObject entity, int idx, bool isSelect, bool isInitializeSelect)
		{
		}

		private void OnPageChanged(MissionGoalsPagerWidget changedPager)
		{
		}

		private void OnPlayGoalPagingBegin()
		{
		}

		private void OnPlayGoalPagingEnd()
		{
		}

		private void OpenRecieveResultSingleDialog(Action callback)
		{
		}

		private void OpenRecieveResultBulkDialog(Action callback)
		{
		}

		private void InsertBulkRecievedMissionContext(MissionBulkRecieveDialogWidget widget, TabContext tabCtx)
		{
		}

		private void InitSelectorHistoryHandlers()
		{
		}

		private MissionSelectorHistoryHandler CreateTabSelectorHistoryHandler()
		{
			return null;
		}

		private MissionSelectorHistoryHandler CreateMissionSelectorHistoryHandler()
		{
			return null;
		}

		private void OnCreatedTab(GameObject entity)
		{
		}

		private void OnClickTab(MissionTabWidget tabWidget)
		{
		}

		private void OnUpdateTab(GameObject entity, int idx)
		{
		}

		private void OnFocusTab(GameObject entity, int idx, bool isselect, bool isinitialselect)
		{
		}

		public static void Open(int tabId = 0, int poolId = 0)
		{
		}

		public static void OpenOnHome(int tabId = 0, int poolId = 0)
		{
		}

		private static void CheckLaunch(int tabId = 0, int poolId = 0, Action onSuccess = null, Action onFailed = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private IEnumerator yInitialize()
		{
			return null;
		}

		private IEnumerator yPreReserveRoutine()
		{
			return null;
		}

		protected override void OnCreatedView()
		{
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		public override void NotificationStackRemove()
		{
		}

		private void RefreshTabList(bool changedCount)
		{
		}

		private void RefreshMissionLabel()
		{
		}

		private void RefreshMissionList(bool changedCount)
		{
		}

		private void RefreshMissionListMessage()
		{
		}

		private void RefreshBulkRecieveButton()
		{
		}

		private void RequestBadgeDelete(Action onComplete = null)
		{
		}

		private void RequestGetMissionListApi(Action omComplete = null)
		{
		}

		private void OnCompleteRecieveReward(Handle h, bool isBulk)
		{
		}

		private void OnRecieveResult(bool isBulk)
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		private void OnClickBulkRecieveButton()
		{
		}

		private IEnumerator yBulkRecieveRoutine()
		{
			return null;
		}
	}
}
