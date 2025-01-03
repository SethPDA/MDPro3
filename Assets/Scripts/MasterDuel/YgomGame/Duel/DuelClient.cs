using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Bg;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class DuelClient : ViewController, IFadeSupported
	{
		public delegate void EffectHandler(int param1, int param2, int param3);

		public enum GUIPriority
		{
			Low = 0,
			Middle = 1,
			High = 2,
			CountDown = 3,
			Command = 4,
			DuelLog = 5,
			ProfileCard = 6,
			InstantMessage = 7,
			CardReportTelop = 8,
			FadePlane = 9,
			PhaseWindow = 10,
			CardInfoDetail = 11,
			CardInfo = 12,
			MessageDialog = 13,
			TutorialNavigatorTop = 14,
			TutorialNavigatorCenter = 15
		}

		public enum DuelSpeed
		{
			Normal = 0,
			Fastest = 1
		}

		public enum ActivateConfirmMode
		{
			Default = 0,
			Off = 1,
			On = 2
		}

		public enum FocusCardSituation
		{
			TYPICAL = 0,
			TYPICAL_FIX = 1,
			CARD_MOVE = 2,
			TARGET_SELECT = 3,
			IGNORE_RESET_ONCE = 4
		}

		public delegate void onShowAffectDelegate(int player, int position, int index);

		public delegate void onHideAffectDelegate();

		public delegate void onTapDownFieldDelegate(int team, int position, int viewIndex);

		public delegate void onTapUpFieldDelegate(int team, int position, int viewIndex);

		public delegate void onTapEnterFieldDelegate(int team, int position, int viewIndex);

		public delegate void onTapExitFieldDelegate(int team, int position, int viewIndex);

		public delegate void onCursorEnterFieldDelegate(int team, int position, int viewIndex);

		public delegate void onCursorExitFieldDelegate(int team, int position, int viewIndex);

		public delegate void onSelectFieldDelegate(int team, int position, int viewIndex);

		public delegate void onDeselectFieldDelegate(int team, int position, int viewIndex);

		public delegate void onFocusFieldDelegate(int team, int position, int viewIndex);

		public delegate void onUnfocusFieldDelegate(int team, int position, int viewIndex);

		public delegate void onDecideFieldDelegate(int team, int position, int viewIndex);

		public delegate void onDoubleClickFieldDelegate(int team, int position, int viewIndex);

		public delegate void onDragFieldBeginDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

		public delegate void onDragFieldDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

		public delegate void onDragFieldEndDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

		public delegate void onHoldFieldBeginDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

		public delegate void onDecideAttackTargetDelegate(int attackerPlayer, int attackerPosition, int attackerIndex, int targetPlayer, int targetPosition, int targetIndex);

		public delegate void onFieldViewChangedDelegate(bool fieldViewing);

		public delegate void onChangeActivateConfirmMode(ActivateConfirmMode mode);

		public delegate void onChangeDetailShowing(bool showing);

		public delegate void onFieldBackKey();

		public delegate void onPlayScreenEffect();

		public delegate void onStopScreenEffect();

		private enum Step
		{
			InitLoadRes = 0,
			WaitLoadRes = 1,
			InitializeProcess = 2,
			FinishInitialize = 3,
			WaitConnecting = 4,
			InitEngine = 5,
			InitSound = 6,
			WaitSound = 7,
			InitLoadSound = 8,
			WaitLoadSound = 9,
			WaitGameObjectInit = 10,
			PrepareProcess = 11,
			FinishPrepare = 12,
			WaitCameraWork = 13,
			ShowUpDuel = 14,
			WaitShowUp = 15,
			ExecDuel = 16,
			EndDuel = 17,
			WaitEndNetwork = 18,
			DuelEnd = 19,
			InitTerm = 20,
			WaitTerm = 21,
			End = 22,
			WaitDestroy = 23,
			ConnectingError = 24,
			Beginning = 25,
			InitSequenceStart = 0,
			InitSequenceEnd = 12
		}

		private enum InitStep
		{
			Start = 0,
			StartDuelHUD = 1,
			WaitDuelHUD = 2,
			StartEffectWorker = 3,
			AdoptiveGoManager = 4,
			Finish = 5
		}

		private enum PrepareStep
		{
			Start = 0,
			StartDuelHUD = 1,
			WaitDuelHUD = 2,
			StartEffectWorker = 3,
			WaitEffectWorker = 4,
			StartTutorial = 5,
			WaitTutorial = 6,
			Finished = 7
		}

		private static DuelClient instance;

		private Dictionary<Engine.ViewType, EffectHandler> effectTable;

		private Dictionary<Engine.ViewType, EffectHandler> audienceReplayEffectTable;

		private bool isSetLastBgmLabel;

		private bool isPlatformChecker;

		private DuelSpeed duelSpeed;

		private List<AbstractRunEffectWorker> workers;

		private Dictionary<GUIPriority, GameObject> childRoots;

		[SerializeField]
		private UnityEngine.Object duelHUDSrc;

		private GameObject inputBlocker;

		private int inputBlockCounter;

		private InputBlockerFlexible fieldInputBlocker;

		private string lastBgmLabel;

		private int pvpErrorCount;

		private bool pvpError;

		private bool pvpTimeout;

		private float replayTimeMargin;

		private bool replayRealtime;

		private bool quitReplay;

		private bool pauseReplay;

		private bool detailShowing;

		private Step m_Step;

		private InitStep initStep;

		private PrepareStep prepareStep;

		private Dictionary<string, object> dicResult;

		private bool resultSending;

		private ReplayStream replayStream;

		private RecordManager recordManager;

		private bool isEngineInitialized;

		private const int ExistWorkSize = 512;

		private float networkTimeOutThrethold;

		private float networkTimeOutTimer;

		private const int DEFAULT_TIMEOUT_TIME = 30;

		private bool isAbend_s;

		private bool isAbend_c;

		private bool isKicked;

		private List<Func<bool>> OnBackList
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

		public EngineInitializer engineInitializer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DuelHUD duelHUD
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

		public HandCardManager handCardManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public RunEffectWorker effectWorker
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

		public static DuelCursor cursor
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

		public ActivateConfirmMode activateConfirmMode
		{
			[CompilerGenerated]
			get
			{
				return default(ActivateConfirmMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override int selectorPriorityAddRange => 0;

		public bool pvpProgress
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

		private Step step
		{
			get
			{
				return default(Step);
			}
			set
			{
			}
		}

		public DuelEndOperation duelEndOperation
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

		public bool IsEngineInitialized => false;

		public int chapterId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isRentalDeck
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

		private float initProgress => 0f;

		public event Action OnUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<Engine.ViewType, int, int, int> onPreRunEffect
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<Engine.ViewType, int, int, int> onPostRunEffect
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onAudienceReplayFinished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onShowAffectDelegate onShowAffectHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onHideAffectDelegate onHideAffectHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onTapDownFieldDelegate onTapDownFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onTapUpFieldDelegate onTapUpFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onTapEnterFieldDelegate onTapEnterFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onTapExitFieldDelegate onTapExitFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onCursorEnterFieldDelegate onCursorEnterFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onCursorExitFieldDelegate onCursorExitFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onSelectFieldDelegate onSelectFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onDeselectFieldDelegate onDeselectFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onFocusFieldDelegate onFocusFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onUnfocusFieldDelegate onUnfocusFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onDecideFieldDelegate onDecideFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onDoubleClickFieldDelegate onDoubleClickFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onDragFieldBeginDelegate onDragFieldBeginHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onDragFieldDelegate onDragFieldHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onDragFieldEndDelegate onDragFieldEndHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onHoldFieldBeginDelegate onHoldFieldBeginHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onDecideAttackTargetDelegate onDecideAttackTargetHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onFieldViewChangedDelegate onFieldViewChangedHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onChangeActivateConfirmMode onChangeActivateConfirmModeHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onChangeDetailShowing onChangeDetailShowingHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onFieldBackKey onFieldBackKeyHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onPlayScreenEffect onPlayScreenEffectHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event onStopScreenEffect onStopScreenEffectHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public GameObject GetChildRoot(GUIPriority priority)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public bool IsFinishedOtherWorker<T>(Engine.ViewType viewType) where T : AbstractRunEffectWorker
		{
			return false;
		}

		public override float Progress()
		{
			return 0f;
		}

		public override void ProgressUpdate()
		{
		}

		private void Update()
		{
		}

		public static int RunEffect(int id, int param1, int param2, int param3)
		{
			return 0;
		}

		private int RunEffectImpl(int id, int param1, int param2, int param3)
		{
			return 0;
		}

		public static int IsBusyEffect(int id)
		{
			return 0;
		}

		private int IsBusyEffectImpl(int id)
		{
			return 0;
		}

		public void AddEffectHandler(Engine.ViewType type, EffectHandler eh)
		{
		}

		public void RemoveEffectHandler(Engine.ViewType type, EffectHandler eh)
		{
		}

		public void AddAudienceReplayEffectHandler(Engine.ViewType type, EffectHandler eh)
		{
		}

		public void RemoveAudienceReplayEffectHandler(Engine.ViewType type, EffectHandler eh)
		{
		}

		public void AddBackEvent(Func<bool> func, bool first = false)
		{
		}

		public void RemoveBackEvent(Func<bool> func)
		{
		}

		public Color FadeColor(TransitionType type)
		{
			return default(Color);
		}

		public SystemProgress.ProgressType FadeType(TransitionType type)
		{
			return default(SystemProgress.ProgressType);
		}

		public void SetActiveInputBlocker(bool active)
		{
		}

		private void DeactiveInputBlocker(bool force)
		{
		}

		public void SetActiveFieldInputBlocker(bool active)
		{
		}

		private void SetupPvp()
		{
		}

		private void FinishPvP()
		{
		}

		private void PvpNetworkCompleteHandler(PvP.Event ev, int code)
		{
		}

		private void PvpNetworkErrorHandler(PvP.Event ev, int code)
		{
		}

		private void PvpNetworkFatalErrorHandler(PvP.Event ev, int code)
		{
		}

		private void PvpProgress(bool enable)
		{
		}

		private void ReplayRealtime(bool replayQueued, bool mainQueued)
		{
		}

		public bool GetPvpTimeout()
		{
			return false;
		}

		public bool IsReplayRealtime()
		{
			return false;
		}

		public void ResetReplayRealtimeFlag()
		{
		}

		public bool UseMinimumEffect()
		{
			return false;
		}

		public static void InvokeShowAffect(int player, int position, int index)
		{
		}

		public static void InvokeHideAffect()
		{
		}

		public static void InvokeTapDownField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeTapUpField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeTapEnterField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeTapExitField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeCursorEnterField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeCursorExitField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeSelectField(SharedDefinition.Location location, int position, int viewIndex)
		{
		}

		public static void InvokeSelectField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeDeselectField(SharedDefinition.Location location, int position, int viewIndex)
		{
		}

		public static void InvokeDeselectField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeFocusField(SharedDefinition.Location location, int position, int viewIndex)
		{
		}

		public static void InvokeFocusField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeUnfocusField(SharedDefinition.Location location, int position, int viewIndex)
		{
		}

		public static void InvokeUnfocusField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeDecideField(SharedDefinition.Location location, int position, int viewIndex)
		{
		}

		public static void InvokeDecideField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeDoubleClickField(int player, int position, int viewIndex)
		{
		}

		public static void InvokeDragFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		public static void InvokeDragField(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		public static void InvokeDragFieldEnd(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		public static void InvokeHoldFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		public static void InvokeDecideAttackTarget(int attackerPlayer, int attackerPosition, int attackerIndex, int targetPlayer, int targetPosition, int targetIndex)
		{
		}

		public static void InvokeFieldViewChanged(bool fieldViewing)
		{
		}

		public static void InvokeChangeActivateConfirmModeCheck(ActivateConfirmMode mode)
		{
		}

		public static void InvokeChangeDetailShowing(bool showing)
		{
		}

		public static void InvokeFieldBackKey()
		{
		}

		public static void InvokePlayScreenEffect()
		{
		}

		public static void InvokeStopScreenEffect()
		{
		}

		public static bool GetFieldCardFace(int player, int position, int index)
		{
			return false;
		}

		public static int GetFieldCardID(int player, int position, int index)
		{
			return 0;
		}

		public static int GetLP(int player)
		{
			return 0;
		}

		public static DuelSpeed GetDuelSpeed()
		{
			return default(DuelSpeed);
		}

		public static void SetDuelSpeed(DuelSpeed duelSpeed)
		{
		}

		public static float GetDuelDeltaTime()
		{
			return 0f;
		}

		public static float GetDuelTimeScale()
		{
			return 0f;
		}

		public static void QuitReplay()
		{
		}

		public static void SetPauseReplay(bool pause)
		{
		}

		public static Vector3 PositionToScreenPoint(int player, int position, int index = 0)
		{
			return default(Vector3);
		}

		public static Vector3 PositionToScreenLocalPoint(int player, int position)
		{
			return default(Vector3);
		}

		public static Vector3 PositionToScreenLocalPoint(int player, int position, int index)
		{
			return default(Vector3);
		}

		public static Vector3 ScreenPointToLocalPointDuelClient(Vector3 pos)
		{
			return default(Vector3);
		}

		public static Vector3 MateToScreenLocalPoint(BgUnit.Side side)
		{
			return default(Vector3);
		}

		public static Vector3 ScreenPointToDuelCameraWorldPosition(Vector3 screenPoint)
		{
			return default(Vector3);
		}

		public static Vector2 PositionToHighlightPoint(int player, int position)
		{
			return default(Vector2);
		}

		public static (int, int, int) GetCardPosition(Vector2 screenPoint)
		{
			return default((int, int, int));
		}

		public static bool IsDetailShowing()
		{
			return false;
		}

		private float GetProgress(Step current, Step start, Step end)
		{
			return 0f;
		}

		private void InitEngineImpl()
		{
		}

		private void EvalEachSteps()
		{
		}

		private void UpdateInitStep()
		{
		}

		private void UpdateExecAndTermStep()
		{
		}

		private void BeginningStep()
		{
		}

		private void InitLoadResStep()
		{
		}

		private void WaitLoadResStep()
		{
		}

		private void InitializeProcessStep()
		{
		}

		private void FinishInitializeStep()
		{
		}

		private void WaitConnectingStep()
		{
		}

		private void InitEngineStep()
		{
		}

		private void InitSoundStep()
		{
		}

		private void WaitSoundStep()
		{
		}

		private void InitLoadSoundStep()
		{
		}

		private void WaitLoadSoundStep()
		{
		}

		private void WaitGameObjectInitStep()
		{
		}

		private void PrepareProcessStep()
		{
		}

		private void FinishPrepareStep()
		{
		}

		private void WaitCameraWork()
		{
		}

		private void ShowUpDuelStep()
		{
		}

		private void WaitShowUpStep()
		{
		}

		private void InitDuel()
		{
		}

		private void ExecDuelStep()
		{
		}

		private bool IsToMainQueueIsEmpty()
		{
			return false;
		}

		private void EndDuelStep()
		{
		}

		private void DuelEndStep()
		{
		}

		private void InitTermStep()
		{
		}

		private void WaitTermStep()
		{
		}

		private void WaitEndNetworkStep()
		{
		}

		private void EndStep()
		{
		}

		private void WaitDestroyStep()
		{
		}

		private void ConnectingErrorStep()
		{
		}

		private void ShowErrorDialog(string msg, Step nextStep)
		{
		}

		private void DestroyStep()
		{
		}

		private void ReleaseResources()
		{
		}

		private void WriteResultToSendWork()
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
