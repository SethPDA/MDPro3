using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomGame.Utility;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Solo
{
	public class SoloModeViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported, IFadeSupported
	{
		internal class GateManager
		{
			internal Dictionary<int, Data> masterDataDic;
		}

		internal class Data
		{
			internal int gateID;

			private string gateName;

			internal string strOverview;

			internal string strUnlocks;

			private bool isClear;

			private bool isComplete;

			private bool isBadge;

			private bool haveCanUnlockChapter;

			internal bool isUnlocked;

			internal int priority;

			internal long openDate;

			internal long lastPlayDate;

			internal bool isActive;

			internal int parentID;

			internal bool isSelected;

			internal List<int> childs;

			internal GateManager gateManager;

			internal string StrName
			{
				get
				{
					return null;
				}
				private set
				{
				}
			}

			internal bool IsComplete
			{
				get
				{
					return false;
				}
				private set
				{
				}
			}

			internal bool IsClear
			{
				get
				{
					return false;
				}
				private set
				{
				}
			}

			internal bool IsBadge
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			internal bool HaveCanUnlockChapter
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			internal Data(int gateID, string strName, string strOverview, string strUnlocks, bool isUnlocked, bool haveUnlockChapter, int priority, long openDate, long lastPlayDate, bool isActive, int parentID, GateManager gateManager)
			{
			}

			internal void AddChild(int child)
			{
			}

			internal void CheckCompleteClearFlag()
			{
			}

			internal void UpdateDateInSubGate()
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string SCROLL_SUB_LABEL;

		private readonly string OBJ_TUTORIAL_LABEL;

		private readonly string OBJ_BLACKOUT_LABEL;

		private readonly string OBJ_ORB_PLATE_LABEL;

		private readonly string ROOT_LABEL;

		private readonly string ROOT_VIEW_LABEL;

		private readonly string ROOT_SUBGATE_LABEL;

		private readonly string TXT_GATENAME_LABEL;

		private readonly string TXT_CLEAR_LABEL;

		private readonly string TXT_CONDITIONS_LABEL;

		private readonly string TXT_COMPLETE_LABEL;

		private readonly string TXT_OVERVIEW_LABEL;

		private readonly string IMG_LOCK_LABEL;

		private readonly string IMG_GATE_LABEL;

		private readonly string IMG_GATE_LOCK_LABEL;

		private readonly string IMG_ARROW_LABEL;

		private readonly string IMG_BADGE_LABEL;

		private readonly string IMG_CAN_UNLOCK_LABEL;

		private readonly string BTN_LABEL;

		private readonly string SELECTOR_SOLO_TRANSITION;

		private readonly string E_FilterAndSortArea;

		private readonly string E_ClearButton;

		private readonly string E_FilterButton;

		private readonly string E_SortButton;

		private readonly string E_TextEmpty;

		public const string BGM_TUTORIAL = "BGM_TUTORIAL_01";

		public const string BGM_SOLO = "BGM_SOLO_GATE";

		private DefinitionSetting soloDefine;

		private DefinitionSetting soloTransDefine;

		private SoloFlyingCardSettings soloFlyingCardSettings;

		private InfinityScrollView mainScroll;

		private GameObject subScrollRoot;

		private InfinityScrollView subScroll;

		private bool isWhileTutorial;

		private int filterClusterGoThroughPriority;

		private string loadedBgmLabel;

		private bool isReady;

		private bool isReadyTutorial;

		private bool isDispHeader;

		private (bool, bool) isCalledDispUnlock;

		private (int, int) currentMainGate;

		private (int, int) currentSubGate;

		private PlayableDirector soloTransition;

		private GateManager gateManager;

		private List<int> masterMainDataList;

		private List<int> mainDataList;

		private List<int> masterSubDataList;

		private List<int> subDataList;

		private OrbPlateWidget orbPlate;

		private SoloFilterSortUtil.GateFilter currentGateFilter;

		private SoloFilterSortUtil.GateSort currentGateSort;

		public bool IsDispSubScroll => false;

		protected override Type[] textIds => null;

		protected override int selectorPriorityAddRange => 0;

		protected override bool setProgressOnInitialize => false;

		public string LoadedBgmLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void CallAPISoloInfo(bool back = false, Action onSuccess = null)
		{
		}

		private void CallAPISoloGateEntry(int gateID, Action OnSuccess = null)
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

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		private void StartTransitionCoverRoutine(Action onComplete = null)
		{
		}

		public IEnumerator yTransitionCoverRoutine(Action onComplete = null)
		{
			return null;
		}

		public override bool OnBack()
		{
			return false;
		}

		public Color FadeColor(TransitionType type)
		{
			return default(Color);
		}

		public SystemProgress.ProgressType FadeType(TransitionType type)
		{
			return default(SystemProgress.ProgressType);
		}

		private void StartTimeLine()
		{
		}

		private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
		{
			return null;
		}

		private void EndTimeLine(int id, bool isBadge)
		{
		}

		private void OnBackTimeLine()
		{
		}

		private void SetFilterAndSortBtnStatus()
		{
		}

		private string GetSortName(SoloFilterSortUtil.GateSort gateSort)
		{
			return null;
		}

		private void SetFilterCluster(bool isSet)
		{
		}

		private void UpdateFilteringContent(bool isReturnChapterMap = false)
		{
		}

		private void CheckFilterResult(List<int> dataList, (int, int) currentGate, InfinityScrollView scrollView, bool isReturnChapterMap)
		{
		}

		private IEnumerator yMovePage(InfinityScrollView isv, int targetIndex, Action onComplete = null)
		{
			return null;
		}

		private void SetDirtyHeader(bool isDisp)
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		private void UpdateData()
		{
		}

		private bool CheckHaveCanUnlockChapter(int gateID)
		{
			return false;
		}

		private void UpdateBadge()
		{
		}

		private void InitializeScrollDataList()
		{
		}

		private void UpdateScrollDataList()
		{
		}

		private List<int> FilteringGate(List<int> dataList)
		{
			return null;
		}

		private List<int> SortingGate(List<int> dataList)
		{
			return null;
		}

		private void DispUnlockGate()
		{
		}

		private void UpdateView(Data data)
		{
		}

		private void HideView(bool isHide = true)
		{
		}

		private void OnCreatedEntity(GameObject go)
		{
		}

		public void OnItemSetDataMain(GameObject gob, int dataindex)
		{
		}

		public void OnItemSetDataSub(GameObject gob, int dataindex)
		{
		}

		private void OpenSubScroll(List<int> dataList)
		{
		}

		private void CloseSubScroll()
		{
		}
	}
}
