using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class PhaseSelect3D : MonoBehaviour
	{
		private const string PATH_BUTTON = "Duel/BG/Timer/Timer_c001/PhaseButton_c001";

		private const string PATH_BUTTON_SP = "Duel/BG/Timer/Timer_013/PhaseButton_013";

		private const string LABEL_EO_TEXTPHASE = "Text";

		private const string LABEL_EO_TEXTSTEP = "Text02";

		private const string LABEL_EO_TEXTTURN = "Text03";

		private const string LABEL_EO_BUTTON = "Button";

		private const string LABEL_EO_PLAYERBASE = "PlayerBase";

		private const string LABEL_EO_PLAYERSURFACE = "PlayerSurface";

		private const string LABEL_EO_OPPONENTBASE = "OpponentBase";

		private const string LABEL_EO_OPPONENTSURFACE = "OpponentSurface";

		private const string LABEL_EO_GUIDEFAR = "PlayableGuide_far";

		private const string LABEL_EO_GUIDENEAR = "PlayableGuide_near";

		private const string LABEL_EO_PADICON = "Position2";

		private const string LABEL_EO_POSITION = "Position";

		private const string LABEL_EO_HINTEFFECT = "HintEffect";

		private const string LABEL_TWEEN_TEXTZOOMOUT = "TextZoomOut";

		private const string LABEL_TWEEN_SWITCHTURN0 = "SwitchTurn0";

		private const string LABEL_TWEEN_SWITCHTURN1 = "SwitchTurn1";

		private const string LABEL_TWEEN_MOUSEOVERIN = "MouseOverIn";

		private const string LABEL_TWEEN_MOUSEOVEROUT = "MouseOverOut";

		private const string LABEL_TWEEN_PRESSBUTTONIN = "PressButtonIn";

		private const string LABEL_TWEEN_PRESSBUTTONOUT = "PressButtonOut";

		private const string LABEL_TWEEN_ACTIVEON = "ActiveOn";

		private const string LABEL_TWEEN_ACTIVEOFF = "ActiveOff";

		private const string LABEL_SHADER_SWITCHTURN = "_SwitchTurn";

		private const string LABEL_SHADER_ACTIVE = "_Active";

		private const string LABEL_TEXT_START = "S";

		private const string LABEL_TEXT_DAMAGE1 = "D1";

		private const string LABEL_TEXT_DAMAGE2 = "D2";

		private const string LABEL_TEXT_DAMAGE3 = "D3";

		private const string LABEL_TEXT_DAMAGE4 = "D4";

		private const string LABEL_TEXT_DAMAGE5 = "D5";

		private const string LABEL_TEXT_END = "E";

		private const string PATH_PHASECHANGE_DP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelDrawPhase_near";

		private const string PATH_PHASECHANGE_DP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelDrawPhase_far";

		private const string PATH_PHASECHANGE_SP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelStanbyPhase_near";

		private const string PATH_PHASECHANGE_SP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelStanbyPhase_far";

		private const string PATH_PHASECHANGE_MP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain01Phase_near";

		private const string PATH_PHASECHANGE_MP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain01Phase_far";

		private const string PATH_PHASECHANGE_BP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelBattlePhase_near";

		private const string PATH_PHASECHANGE_BP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelBattlePhase_far";

		private const string PATH_PHASECHANGE_M2P0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain02Phase_near";

		private const string PATH_PHASECHANGE_M2P1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain02Phase_far";

		private const string PATH_PHASECHANGE_EP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelEndPhase_near";

		private const string PATH_PHASECHANGE_EP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelEndPhase_far";

		private const string TAG_TURN = "Turn";

		private const string TAG_PHASE = "Phase";

		private const string TAG_BATTLE_NEAR = "BattlePhase_near";

		private const string TAG_BATTLE_FAR = "BattlePhase_far";

		public bool duelStart;

		public bool duelEnd;

		public UnityAction onPhaseChangedCallBack;

		public UnityAction<bool> onChangeActive;

		private ElementObjectManager m_RootManager;

		private SelectionButton m_Button;

		private Tween m_TweenSurface0;

		private Tween m_TweenBase0;

		private Tween m_TweenSurface1;

		private Tween m_TweenBase1;

		private Tween m_TweenText;

		private MeshRenderer m_RendererSurface0;

		private MeshRenderer m_RendererSurface1;

		private MeshRenderer m_RendererBase0;

		private MeshRenderer m_RendererBase1;

		private ExtendedTextMeshPro m_PhaseName;

		private ExtendedTextMeshPro m_StepName;

		private ExtendedTextMeshPro m_TurnNum;

		private Transform m_PadIcon;

		private Transform m_Position;

		private Transform m_HintEffect;

		private Engine.Phase m_NextPhase;

		private bool m_Pressing;

		private bool m_Entering;

		private Dictionary<Engine.StepType, string> m_BStepTextDict;

		private Dictionary<string, Color> m_StepColorDict;

		private Dictionary<Engine.DmgStepType, string> m_DStepTextDict;

		private Dictionary<Engine.Phase, string> m_PhaseTimelineDict0;

		private Dictionary<Engine.Phase, string> m_PhaseTImelineDict1;

		private Dictionary<Engine.Phase, string> m_PhaseSoundDict0;

		private Dictionary<Engine.Phase, string> m_PhaseSoundDict1;

		private DuelClient m_Host;

		private Queue<UnityAction> m_TaskQueue;

		private TimelineObject m_CurrentTimeline;

		private int m_TurnPlayer => 0;

		public static void Create(DuelClient host, Transform parent, UnityAction<PhaseSelect3D> onFinish, bool isEsportsVer)
		{
		}

		public void PhaseChange(Engine.Phase nextphase)
		{
		}

		public void PhaseChangeSE()
		{
		}

		public void OnDuelStart()
		{
		}

		public void PhaseChangeProcess()
		{
		}

		public void UpdateTurnText()
		{
		}

		public void TurnChange(int team, Action onFinished)
		{
		}

		public void UpdateStatus(int turnplayer, Engine.Phase nextphase)
		{
		}

		public void SkipTimeline()
		{
		}

		public void UpdateStepIcon(Engine.StepType battlestep, Engine.DmgStepType damagestep)
		{
		}

		public bool IsPhaseMovable(Engine.Phase phase)
		{
			return false;
		}

		public void OnClickButtonPhase()
		{
		}

		public SelectionButton GetButton()
		{
			return null;
		}

		public Vector3 GetPadIconPosition()
		{
			return default(Vector3);
		}

		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		public void SetHintEffectVisible(bool visible)
		{
		}

		private void Update()
		{
		}

		private void InitTables()
		{
		}

		private void InitComponent()
		{
		}

		private void InitSelectorBotton()
		{
		}

		private void SetupSelectorPriority()
		{
		}

		private void OnSelected()
		{
		}

		private void OnDeselect()
		{
		}

		private void OnPointerEnter()
		{
		}

		private void OnPointerExit()
		{
		}

		private void OnPointerDown()
		{
		}

		private void OnPointerUp()
		{
		}

		private void SetPhaseButton()
		{
		}

		private void SetActive(bool active)
		{
		}

		private void SetMaterialParam(string paramname, float value)
		{
		}

		private void UpdateMovablePhaseIcon()
		{
		}

		private void Initialize(DuelClient host)
		{
		}

		private void OnDestroy()
		{
		}

		private void Terminate()
		{
		}
	}
}
