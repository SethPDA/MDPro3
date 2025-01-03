using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Settings;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DuelHUD : MonoBehaviour
	{
		private const string SE_DUEL_SELECT = "SE_DUEL_SELECT";

		[SerializeField]
		private GameObject prefabUI;

		[SerializeField]
		private GameObject handStatusLabelSrc;

		[SerializeField]
		private GameObject placeStatusLabelSrc;

		[SerializeField]
		private GameObject placeStatusLabelRootSrc;

		[SerializeField]
		private UnityEngine.Object screenFadeSrc;

		private ElementObjectManager ui;

		private DamageFrame damageFrame;

		private const int LATENCY_THRESHOLD = 127;

		private ReplayControl replayCtrl;

		private GameObject buttonDuelMenu;

		private AudienceInfo audienceInfo;

		private ElementObjectManager logButton;

		private GameObject duelLogOnIcon;

		private GameObject duelLogOffIcon;

		private SelectionButton cancelButton;

		private Action onClickCancelButton;

		private SelectionButton decisionButton;

		private Action onClickDecisionButton;

		private GameObject phaseButtonIcon;

		private const string KEY_WATCH = "w";

		private bool duelEnd;

		private Coroutine initializeCoroutine;

		private Coroutine prepareToDuelCoroutine;

		public GameObject root
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DuelClient host
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ActivateConfirmToggle activateToggle
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DuelStatusViewer statusViewer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DuelCursorJump cursorJump
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PlaceStatusManager placeStatus
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ManaSetManager manaSetManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isShowingSettingMenu
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

		public bool isCancelButtonActivated => false;

		public bool isDecisionButtonActivated => false;

		public CardInfo cardInfoL
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CardInfo cardInfoR
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CardReportTelopManager cardReportTelopManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DuelLogController duellog
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GenericCardListController genericCardList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GenericCardListEx relativeCardList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CardInfoDetailForDuel cardInfoDetail
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CpuThinkingIcon cpuThinkingIcon
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CardSelectionList cardSelectionList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PhaseSelectWindow phaseWindow
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FullScreenUiBg fullScreenUiBg
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool duelOver => false;

		public bool isInitialized
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

		public bool isTerminated
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

		public bool isPrepared
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

		private GameObject bgFade
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DuelLP nearLPCounter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DuelLP farLPCounter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isReplayPause => false;

		public bool isVisibleAllPlaceStatusLabel => false;

		private void Update()
		{
		}

		public void Initialize(DuelClient host)
		{
		}

		private IEnumerator InitializeProcess()
		{
			return null;
		}

		private void SetupSettingMenu()
		{
		}

		private void OpenSettingMenu()
		{
		}

		public void Terminate()
		{
		}

		public void PrepareToDuel()
		{
		}

		private IEnumerator PrepareToDuelProcess()
		{
			return null;
		}

		public void DuelStart()
		{
		}

		public void DuelEnd()
		{
		}

		public void HideButtons()
		{
		}

		public void CloseDialog()
		{
		}

		public void SetLP(SharedDefinition.Location side, int lp)
		{
		}

		public void ChangeLP(SharedDefinition.Location side, int afterLP, int damage, Engine.DamageType type, Action onFinished = null)
		{
		}

		public void SetDisp(bool disp)
		{
		}

		public void ShowAllCardStatusLabel()
		{
		}

		public void HideAllCardStatusLabel()
		{
		}

		public PlaceStatusLabel UsePlaceStatusLabel(SharedDefinition.Location location, bool lieDown, bool hand)
		{
			return null;
		}

		public void UnusePlaceStatusLabel(PlaceStatusLabel instance)
		{
		}

		public void ShowAllPlaceStatusLabel()
		{
		}

		public void HideAllPlaceStatusLabel()
		{
		}

		public void ShowDamageFrame()
		{
		}

		public void SetBgColor(Color color)
		{
		}

		private void updateNetworkStatus()
		{
		}

		private void UpdateActivateToggle(SettingsUtil.DuelParam.MANUAL_TYPE type)
		{
		}

		public void OnClickReplayStop()
		{
		}

		private void OnClickReplayFast()
		{
		}

		public void OnChangeWatcherNum(int num)
		{
		}

		private void UpdateWatcherNum()
		{
		}

		private void OnClickDuelLogButton()
		{
		}

		public void OpenDuelLog()
		{
		}

		public void CloseDuelLog(bool forMobile)
		{
		}

		private void OnChangeDuelLogOpenClose(bool isOpen)
		{
		}

		private void SetDuelLogButtonStatus(bool isOpen)
		{
		}

		private void SetupCardinfoL(CardInfo instance, Transform parent, bool ismobilelayout)
		{
		}

		private void SetupCardinfoR(CardInfo instance)
		{
		}

		public void CloseCardInfoDetail()
		{
		}

		public void SetOnClickCancelButtonCallback(Action callback)
		{
		}

		public void SetDispCancelButton(bool disp)
		{
		}

		public void ActivateCancelButton(Action clickCallback)
		{
		}

		public void DeactivateCancelButton()
		{
		}

		public void SetOnClickDecisionButtonCallback(Action callback)
		{
		}

		public void SetDispDecisionButton(bool disp)
		{
		}

		public void ActivateDecisionButton(Action clickCallback)
		{
		}

		public void DeactivateDecisionButton()
		{
		}

		public void OpenCardInfo(int team, int position, int index, bool isLeft = true, bool lockDisp = true, bool force = true, bool miniDisp = true, bool setTargetTopCardIndex = false)
		{
		}

		public void OpenCardInfo(bool isLeft = true)
		{
		}

		public void OpenCardInfoByUniqueID(int uniqueID, bool isLeft = true, bool lockDisp = true, bool showToHappenHighlight = false, int highlightRfxTableIndex = -1)
		{
		}

		public void CloseCardInfo(bool isLeft = true)
		{
		}

		public void CloseCardInfoMini(bool isLeft = true)
		{
		}

		public void SetCardInfoMiniPos(CardInfo.ShowPos miniPos, bool isLeft = true)
		{
		}

		public void SetPhaseButtonIconPosition(Vector3 worldPosition)
		{
		}

		public void SetDispPhaseButtonIcon(bool disp)
		{
		}

		public void SetActivateShortcutIcon(bool activate)
		{
		}
	}
}
