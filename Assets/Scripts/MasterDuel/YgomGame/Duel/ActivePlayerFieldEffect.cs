using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class ActivePlayerFieldEffect : MonoBehaviour
	{
		private enum PlauableGuideTrigger
		{
			CHANGE = 0,
			APPEAR = 1,
			OUT = 2
		}

		private enum Step
		{
			WaitInitialize = 0,
			Idle = 1,
			Duel = 2,
			Terminating = 3
		}

		private class DelayAction
		{
			private const float DELAYTIME_S = 1f;

			private const float DELAYTIME_L = 2f;

			private UnityAction<int, bool> action;

			private bool changeflag;

			private float delaytime;

			private bool isInterrupted;

			private bool isOnTime => false;

			private bool IsPlayerActive(bool isinterrupt)
			{
				return false;
			}

			public void SetAction(UnityAction<int, bool> action)
			{
			}

			public void SetTeamInstant(int turnplayer)
			{
			}

			public void ToInterrupt(bool isLongDelay)
			{
			}

			public void ToTurnPlayer(bool forceswitch, bool isLongDelay)
			{
			}

			public void Update()
			{
			}
		}

		private const string PATH_GUIDE_NEAR = "Duel/BG/Timer/PlayableGuide_c001/PlayableGuide_c001_near";

		private const string PATH_GUIDE_FAR = "Duel/BG/Timer/PlayableGuide_c001/PlayableGuide_c001_far";

		private const string LABEL_TRIGGER_APPEAR = "Apper";

		private const string LABEL_TRIGGER_NOTICE = "Notice";

		private const string LABEL_TRIGGER_CHANGE = "Change";

		private const string LABEL_TRIGGER_OUT = "Out";

		private const string LABEL_TRIGGER_END = "End";

		private const float WAIT_INPUT_NOTICE_INTERVAL = 15f;

		private const int LATENCY_THRESHOLD = 127;

		private Animator m_GuideNear;

		private Animator m_GuideFar;

		private ElementObjectManager m_EOManager;

		private bool m_IsNearReady;

		private bool m_IsFarReady;

		private DelayAction m_DelayAction;

		private Step m_Step;

		private float m_WaitInputTime;

		public bool IsShow;

		public int currentActivePlayer
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

		public bool isInitialized => false;

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

		public static ActivePlayerFieldEffect Create(DuelGameObjectManager goManager, GameObject root, string name)
		{
			return null;
		}

		public void InitGuide(int firstPlayer)
		{
		}

		public void OnDuelStart()
		{
		}

		public void SwitchGuide(int team, bool forceswitch = false)
		{
		}

		public void TurnPhaseChange()
		{
		}

		public void FinishGuide()
		{
		}

		protected void Initialize()
		{
		}

		private void SetGuideNotice()
		{
		}

		private void WaitInitializeStep()
		{
		}

		private void DuelStep()
		{
		}

		private void TerminatingStep()
		{
		}

		private void Update()
		{
		}

		private void UpdateHintEffect()
		{
		}

		private bool CheckIsShow()
		{
			return false;
		}

		private void SetGuideEnable(bool isnear, bool enable, bool turnchange = false)
		{
		}

		public void Terminate()
		{
		}
	}
}
