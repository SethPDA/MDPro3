using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class RunEffectWorker : AbstractRunEffectWorker
	{
		private enum Step
		{
			Initializing = 0,
			Initialized = 1,
			Preparing = 2,
			ExecDuel = 3,
			Terminating = 4,
			Finish = 5
		}

		private delegate Dictionary<string, object> preCreateDelegate(RunEffectWorker worker, int param1, int param2, int param3);

		private delegate EffectTask createDelegate(RunEffectWorker worker, int param1, int param2, int param3);

		private delegate EffectTask createDelegateAdvanced(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork);

		private class RunEffectParam
		{
			public Engine.ViewType viewType;

			public createDelegate createFunc;

			public createDelegateAdvanced createFuncAdvanced;

			public int param1;

			public int param2;

			public int param3;

			public EffectTask task;

			public Dictionary<string, object> immediateWork;
		}

		public enum CountDialogType
		{
			None = 0,
			Discard = 1,
			Ritual = 2
		}

		private Step step;

		private List<RunEffectParam> runEffectParams;

		private Coroutine initializeCoroutine;

		private Coroutine prepareToDuelCoroutine;

		private bool initialized;

		private MessageDialog messageDialogNoResponse;

		private MessageDialog messageDialogNoOperation;

		private bool isForeverInfoMessage;

		private float noOperationTimer;

		private const float noOperationWarningSecond = 30f;

		private const float noOperationSurrenderSecond = 40f;

		public const int SELECT_LOCATION_TEXT_ID = 326;

		public const int UNUSED_ZONE_TEXT_ID = 155;

		public const int SELECT_SIMPLE_TEXT_ID = 591;

		public int attackedMonster;

		public bool autoAttack;

		private Engine.StepType m_BPStep;

		private Engine.DmgStepType m_DMGStep;

		public int[,] tmpFacedCard;

		private float localLeftTime;

		private float localTotalTime;

		private float localTurn;

		private Engine.Phase localPhase;

		private bool cardHappenTaskEnable;

		public SelectingCursorManager selCursorMan;

		private AttackTargetingOperation attackTargetingOperation;

		private bool inputBlockActivated;

		private ZoneCard zoneCardNearGraveIn;

		private ZoneCard zoneCardNearGraveOut;

		private ZoneCard zoneCardNearExcludeIn;

		private ZoneCard zoneCardNearExcludeOut;

		private ZoneCard zoneCardFarGraveIn;

		private ZoneCard zoneCardFarGraveOut;

		private ZoneCard zoneCardFarExcludeIn;

		private ZoneCard zoneCardFarExcludeOut;

		private bool preparedToDuel;

		private bool _isTerminated;

		public List<Engine.ViewType> busyEffectList
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

		public int runEffectParamsCount => 0;

		public Engine.ViewType currentViewType
		{
			[CompilerGenerated]
			get
			{
				return default(Engine.ViewType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isInputViewType => false;

		public Engine.ViewType prevViewType
		{
			[CompilerGenerated]
			get
			{
				return default(Engine.ViewType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int prevViewParam1
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

		public int prevViewParam2
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

		public int prevViewParam3
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

		public DuelGameObjectManager goManager
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

		public DuelHUD duelHUD => null;

		public bool selectAttacked
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

		public DuelOkDialog okDialog
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

		public DuelConfirmDialog confirmDialog
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

		public DuelSelectDialog selectDialog
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

		public DuelPullDownDialog pullDownDialog
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

		public DuelDiceDialog diceDialog
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

		public DuelCoinDialog coinDialog
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

		public DuelRitualDialog ritualDialog
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

		public InstantMessage instantMessage
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

		public InstantCardDisplay instantCardDisplay
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

		public DuelInfoDialog infoDialog
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

		public bool fieldViewing
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

		public override bool isInitialized => false;

		private bool inputting
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

		private string infoMessage
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

		public bool blockAutoSurrener
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

		public bool isRetryRequired
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

		public bool isDuelLiveContinuousRequired
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

		public bool playingPhaseChangeEffect
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

		public bool duelOver
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

		public Engine.MenuActType currentActType
		{
			[CompilerGenerated]
			get
			{
				return default(Engine.MenuActType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CountDialogType currentCountDialog
		{
			[CompilerGenerated]
			get
			{
				return default(CountDialogType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool discardReady
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

		public int discardRemain
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string discardMessage
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

		public int totalLevel
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int ritualRemain
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int dlgTextId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Engine.DialogRitualType ritualType
		{
			[CompilerGenerated]
			get
			{
				return default(Engine.DialogRitualType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int lastDialogTextId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int lastYesNoDialogEffectTextid
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool openCardInfoRByEffectIdFlag
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

		public bool dlgTypeOkResult
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

		public bool surrendered
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

		public bool duelStart
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

		private Dictionary<int, int> lp
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

		private Dictionary<int, int> lpMin
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

		public int battleSrcPlayer
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int battleSrcPosition
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int battleDstPlayer
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int battleDstPosition
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 attackDirection
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Engine.CutinSummonType cutinSummonType
		{
			[CompilerGenerated]
			get
			{
				return default(Engine.CutinSummonType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int currentSelectingPlayer
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int currentSelectingPosition
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int currentSelectingIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SelectionZoneIconController selectionZoneIcon
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

		public CommandOperation commandOperation
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

		public DecideOperation decideOperation
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

		public SelectStandOperation selectStandOperation
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

		public PhaseSelect3D phaseSelect
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

		public FusionEffect fusionEffect
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

		public XyzEffect xyzEffect
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

		public LinkEffect linkEffect
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

		public SynchroEffect synchroEffect
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

		public RitualEffect ritualEffect
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

		public PendulumEffect pendulumEffect
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

		public PendulumReadyEffect pendulumReadyEffect
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

		public MonsterCutinEffect monsterCutinEffect
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

		public RunCoin runCoin
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

		public RunDice runDice
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

		public ResidualEffect residualEffect
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

		public DuelChainManager chainManager
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

		public bool isPlayingMonsterCutin
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

		public bool isMonsterCutinDone
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

		public bool isSpSummonFromExDeckMyself
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

		public bool isSpSummonFromExDeckRival
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

		public int lastCardID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int lastUniqueID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private int attackerUniqueID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool inputAvailable
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

		public FinalBlowEffect finalBlow
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

		public LethalEffect lethalEffect
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

		public bool lethalEffectPlayed => false;

		public bool lethalEffectPlayedMyself
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

		public bool lethalEffectPlayedRival
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

		public SpecialWinBase specialWinEffect
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

		public DrawOperation drawOperation
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

		public bool drawOperationEnabled => false;

		public int preCardMoveFromPlayer
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int preCardMoveFromPosition
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override bool isPreparedToDuel => false;

		public bool isShownUp => false;

		public override bool isTerminated
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public RunEffectWorker(DuelClient host)
			: base(null)
		{
		}

		private IEnumerator InitializeProcess()
		{
			return null;
		}

		public override void PrepareToDuel()
		{
		}

		public void SetGoManager(DuelGameObjectManager goManager)
		{
		}

		private IEnumerator PrepareToDuelProcess()
		{
			return null;
		}

		public override void Terminate()
		{
		}

		public override void OnDestroy()
		{
		}

		private void OnPreRunEffect(Engine.ViewType viewtype, int param1, int param2, int param3)
		{
		}

		private void OnPostRunEffect(Engine.ViewType viewtype, int param1, int param2, int param3)
		{
		}

		public override bool IsBusyEffect(Engine.ViewType viewType)
		{
			return false;
		}

		public void ShowUpOnStartDuel(bool playEffect)
		{
		}

		public void DispSelectingCursor(int team, int position, int index)
		{
		}

		public void HideSelectingCursor()
		{
		}

		public void RefreshSelectingCursor()
		{
		}

		public void OpenPvpNoResponse()
		{
		}

		public void PvpResponsed()
		{
		}

		public void ClosedPvpNoResponse()
		{
		}

		private void OnUpdate()
		{
		}

		private void ExecDuelStep()
		{
		}

		private void TerminatingStep()
		{
		}

		private void FinishStep()
		{
		}

		private void EnqueueTask(Engine.ViewType viewType, createDelegate createFunc, int param1, int param2, int param3)
		{
		}

		private void EnqueueTask(Engine.ViewType viewType, preCreateDelegate preCreateFunc, createDelegateAdvanced createFuncAdvanced, int param1, int param2, int param3)
		{
		}

		private void EnqueueTaskImpl(RunEffectParam runEffectParam)
		{
		}

		private void DequeueTask()
		{
		}

		private void UpdateBusyIds()
		{
		}

		private void PhaseChange(int param1, int param2, int param3)
		{
		}

		private void TurnChange(int param1, int param2, int param3)
		{
		}

		private void TurnChangeMinimum(int param1, int param2, int param3)
		{
		}

		private void DuelStart(int param1, int param2, int param3)
		{
		}

		public void InitializeOnDuelStart(bool playBGM, bool playEntryAnime)
		{
		}

		private void DuelEnd(int param1, int param2, int param3)
		{
		}

		private void BattleAttack(int param1, int param2, int param3)
		{
		}

		private void BattleAttackMinimum(int param1, int param2, int param3)
		{
		}

		private void LifeSet(int param1, int param2, int param3)
		{
		}

		private void LifeSetMinimum(int param1, int param2, int param3)
		{
		}

		private void LifeDamage(int param1, int param2, int param3)
		{
		}

		private void LifeDamageMinimum(int param1, int param2, int param3)
		{
		}

		private void CardSet(int param1, int param2, int param3)
		{
		}

		private void CardIncTurn(int param1, int param2, int param3)
		{
		}

		private void RunFusion(int param1, int param2, int param3)
		{
		}

		private void CutinDraw(int param1, int param2, int param3)
		{
		}

		private void CutinSummon(int param1, int param2, int param3)
		{
		}

		private void CutinActivate(int param1, int param2, int param3)
		{
		}

		private void CutinActivateMinimum(int param1, int param2, int param3)
		{
		}

		private void CutinSet(int param1, int param2, int param3)
		{
		}

		private void CutinTurnEnd(int param1, int param2, int param3)
		{
		}

		private void CutinTurnEndMinimum(int param1, int param2, int param3)
		{
		}

		private void ManaSet(int param1, int param2, int param3)
		{
		}

		private void TuningSet(int param1, int param2, int param3)
		{
		}

		private void TuningReset(int param1, int param2, int param3)
		{
		}

		private void TuningRun(int param1, int param2, int param3)
		{
		}

		private void CutinCoinDice(int param1, int param2, int param3)
		{
		}

		private void WaitFrame(int param1, int param2, int param3)
		{
		}

		private void WaitInput(int param1, int param2, int param3)
		{
		}

		private void RunDialog(int param1, int param2, int param3)
		{
		}

		private void RunList(int param1, int param2, int param3)
		{
		}

		private void BattleInit(int param1, int param2, int param3)
		{
		}

		private void BattleInitMinimum(int param1, int param2, int param3)
		{
		}

		private void BattleRun(int param1, int param2, int param3)
		{
		}

		private void BattleEnd(int param1, int param2, int param3)
		{
		}

		private void HandShuffle(int param1, int param2, int param3)
		{
		}

		private void HandOpen(int param1, int param2, int param3)
		{
		}

		private void DeckShuffle(int param1, int param2, int param3)
		{
		}

		private void DeckFlipTop(int param1, int param2, int param3)
		{
		}

		private void DeckReset(int param1, int param2, int param3)
		{
		}

		private void GraveTop(int param1, int param2, int param3)
		{
		}

		private void CardMove(int param1, int param2, int param3)
		{
		}

		private void CardMoveMinimum(int param1, int param2, int param3)
		{
		}

		private void CardSwap(int param1, int param2, int param3)
		{
		}

		private void CardFlipTurn(int param1, int param2, int param3)
		{
		}

		private void CardFlipTurnMinimum(int param1, int param2, int param3)
		{
		}

		private void CardCheat(int param1, int param2, int param3)
		{
		}

		private void CardVanish(int param1, int param2, int param3)
		{
		}

		private void CardBreak(int param1, int param2, int param3)
		{
		}

		private void CardBreakMinimum(int param1, int param2, int param3)
		{
		}

		private void CardExplosion(int param1, int param2, int param3)
		{
		}

		private void CardExclude(int param1, int param2, int param3)
		{
		}

		private void CardDisable(int param1, int param2, int param3)
		{
		}

		private void CardEquip(int param1, int param2, int param3)
		{
		}

		private void CardUpdate(int param1, int param2, int param3)
		{
		}

		private void MonstShuffle(int param1, int param2, int param3)
		{
		}

		private void TributeSet(int param1, int param2, int param3)
		{
		}

		private void TributeReset(int param1, int param2, int param3)
		{
		}

		private void TributeRun(int param1, int param2, int param3)
		{
		}

		private void MaterialSet(int param1, int param2, int param3)
		{
		}

		private void MaterialReset(int param1, int param2, int param3)
		{
		}

		private void MaterialRun(int param1, int param2, int param3)
		{
		}

		private void ChainRun(int param1, int param2, int param3)
		{
		}

		private void ChainRunMinimum(int param1, int param2, int param3)
		{
		}

		private void RunSummon(int param1, int param2, int param3)
		{
		}

		private void RunSpSummon(int param1, int param2, int param3)
		{
		}

		private void RunCoin(int param1, int param2, int param3)
		{
		}

		private void RunDice(int param1, int param2, int param3)
		{
		}

		private void RunSpecialWin(int param1, int param2, int param3)
		{
		}

		private void OverlaySet(int param1, int param2, int param3)
		{
		}

		private void OverlayReset(int param1, int param2, int param3)
		{
		}

		private void OverlayRun(int param1, int param2, int param3)
		{
		}

		private void LinkSet(int param1, int param2, int param3)
		{
		}

		private void LinkReset(int param1, int param2, int param3)
		{
		}

		private void LinkRun(int param1, int param2, int param3)
		{
		}

		private void ChainStep(int param1, int param2, int param3)
		{
		}

		private void RunJanken(int param1, int param2, int param3)
		{
		}

		private void RunSpecialefx(int param1, int param2, int param3)
		{
		}

		private void RunSpecialefxMinimum(int param1, int param2, int param3)
		{
		}

		private void RunVija(int param1, int param2, int param3)
		{
		}

		private void BattleSelect(int player, int param2, int param3)
		{
		}

		private void CardLockon(int player, int posIdx, int type)
		{
		}

		private void CardHappen(int param1, int param2, int param3)
		{
		}

		private void CardHappenMinimum(int param1, int param2, int param3)
		{
		}

		private void ChainSet(int param1, int param2, int param3)
		{
		}

		private void ChainSetMinimum(int param1, int param2, int param3)
		{
		}

		private void ChainEnd(int param1, int param2, int param3)
		{
		}

		private void ChainEndMinimum(int param1, int param2, int param3)
		{
		}

		private void CpuThinking(int iPlayer, int end, int param3)
		{
		}

		public int GetIndexByViewIndex(int player, int position, int viewIndex)
		{
			return 0;
		}

		public int GetViewIndex(int player, int position, int index)
		{
			return 0;
		}

		private void TapLocatorUnknown(int player, int position, int index)
		{
		}

		private void OnTapDownField(int team, int position, int viewIndex)
		{
		}

		private void OnTapUpField(int player, int position, int viewIndex)
		{
		}

		private void OnCursorEnter(int team, int position, int viewIndex)
		{
		}

		private void OnCursorExit(int team, int position, int viewIndex)
		{
		}

		private void OnSelectField(int team, int position, int viewIndex)
		{
		}

		private void OnDeselectField(int team, int position, int viewIndex)
		{
		}

		private void OnFocusField(int team, int position, int viewIndex)
		{
		}

		private void OnPlayScreenEffect()
		{
		}

		private void OnStopScreenEffect()
		{
		}

		private void OnAudienceReplayFinished()
		{
		}

		public void SetupInfoDialogShowPos(int focusTeam, int focusPosition, bool immediate)
		{
		}

		private void OnUnfocusField(int team, int position, int viewIndex)
		{
		}

		private void OnDecideField(int team, int position, int viewIndex)
		{
		}

		private void OnDoubleClickField(int player, int position, int viewIndex)
		{
		}

		private void OnDragFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		private void OnDragField(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		private void OnDragFieldEnd(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		private void OnHoldFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
		{
		}

		private void OnDecideAttackTarget(int attackerPlayer, int attackerPosition, int attackerIndex, int targetPlayer, int targetPosition, int targetIndex)
		{
		}

		public bool ExecuteCommandLocation()
		{
			return false;
		}

		public void ResetCommandOperation()
		{
		}

		private void ReturnDialogTrue()
		{
		}

		private void ReturnDialogFalse()
		{
		}

		public void ReturnDialogTrueAndFree(bool abort)
		{
		}

		public void ReturnDialogFalseAndFree(bool abort)
		{
		}

		public void ReturnDialogTrueAndFreeWithoutSave(bool abort)
		{
		}

		public void SetInfoMessage(string text, bool isForever = false)
		{
		}

		public string UseInfoMessage()
		{
			return null;
		}

		public void ClearInfoMessage(bool alsoForever = false)
		{
		}

		private void CloseEmotionalList(bool forceclose = false)
		{
		}

		private void ListClosed()
		{
		}

		public void CloseSpecialDialog()
		{
		}

		public void ResumeSpecialDialog()
		{
		}

		public void RestartSpecialDialog()
		{
		}

		public bool IsAnyDialogShowing(bool ignoreFieldViewing = false)
		{
			return false;
		}

		private bool OnBackEvent()
		{
			return false;
		}

		private void listCardSelected(Engine.CardStatus cs, bool isKnown)
		{
		}

		private void OnStartInput()
		{
		}

		private void OnUpdateTimeLimit()
		{
		}

		private void OnCheckTimeOver()
		{
		}

		private void UpdateNoOperation()
		{
		}

		public void StartInput(bool changeCameraView, bool fromPvpNoReponse = false)
		{
		}

		public void FinishInput(bool changeCameraView, bool fromPvpNoResponce = false)
		{
		}

		private void ShowTimer()
		{
		}

		private void OnChangeFieldViewMode(bool bView)
		{
		}

		public void DuelEnd()
		{
		}

		public void AbortInput(bool allHUD = true)
		{
		}

		private void OnSurrender(int param1, int param2, int param3)
		{
		}

		public void OnSurrender()
		{
		}

		public void OpenConfirmDialog(string message, string rightButtonText, string leftButtonText, Action<DuelConfirmDialog.Result, bool> resultCallback, Action openCallback, bool useFieldView)
		{
		}

		public bool IsCommandDecideInExceptField()
		{
			return false;
		}

		public void BattlePositionSelectStart(int uid, int face)
		{
		}

		public bool ExecuteSpSummonLocation()
		{
			return false;
		}

		public bool SetCursorToListIfOpenning()
		{
			return false;
		}

		public bool SetCursorToCommandIfOpenning()
		{
			return false;
		}

		public void FocusCard(int team, int position, int index, DuelClient.FocusCardSituation situation)
		{
		}

		public void UnfocusCard()
		{
		}

		private void OnShowAffectEffect(int team, int position, int index)
		{
		}

		private void OnHideAffectEffect()
		{
		}

		public void BeginAttackTargeting(int attackPlayer, int attackPosition, int targetPlayer, int targetPosition)
		{
		}

		public void SetAttackTargetingLineDisp(bool disp)
		{
		}

		public (int, int, int, int) GetCurrentAttackTargetingInfo()
		{
			return default((int, int, int, int));
		}

		public void EndAttackTargeting()
		{
		}

		private void FinishWaitInput()
		{
		}

		public void HighlightAvailablePlaces(bool enable, uint cmdBit, Action onFinished)
		{
		}

		public SummonEffectBase GetPlayingSummonEffect()
		{
			return null;
		}

		public (Vector3, Quaternion, Vector3) PlayDecideEffect(int player, int position, bool ignoreCard, Action onFinished)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		public void SelectLastHappenedCard()
		{
		}

		public void StartAttackReady(int player, int position)
		{
		}

		public void StartAttackReady(int uniqueID)
		{
		}

		public void FinishAttackReady()
		{
		}

		public bool IsAttackReadyCard(int uniqueID)
		{
			return false;
		}

		public void PlayLethalEffect(int loser, Action onFinished, bool useEffect, Vector3 effectPosition, bool draw, bool isDeckOut, LethalEffect.EffectType type = LethalEffect.EffectType.Normal)
		{
		}

		public bool IsLethalEffectPlayedPlayer(int player)
		{
			return false;
		}

		public void EndCommand()
		{
		}

		public int GetLocalLP(int player)
		{
			return 0;
		}

		public void AddDamageLocalLP(int player, int damage)
		{
		}

		public void SetLocalLP(int player, int lp)
		{
		}

		private void SetupLocalLP()
		{
		}

		private void SetupLocalLPMin()
		{
		}

		public void SetMinLP(int player, int lpt, bool force)
		{
		}

		public ZoneCard GetZoneCard(int player, int position, ZoneCard.Mode mode)
		{
			return null;
		}

		public void Assert(string msg)
		{
		}
	}
}
