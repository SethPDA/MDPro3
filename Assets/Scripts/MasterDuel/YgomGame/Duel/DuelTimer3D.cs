using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelTimer3D : MonoBehaviour
	{
		private enum Step
		{
			WaitInitialize = 0,
			Idle = 1,
			Duel = 2,
			Terminating = 3
		}

		private static bool ActivePre;

		private const int EMERTGENCYTIME = 30;

		private const string LABEL_TWEEN_ACTIVE = "Active";

		private const string LABEL_TWEEN_INACTIVE = "Inactive";

		private const string LABEL_TWEEN_ALERT = "Alert";

		private const string LABEL_TWEEN_NORMAL = "Normal";

		private const string LABEL_TWEEN_COUNTDOWN = "CountDown";

		private const string LABEL_TWEEN_DUELSTART = "DuelStart";

		private const string LABEL_TWEEN_DUELEND = "DuelEnd";

		private const string LABEL_TIMERBODY = "Timer";

		private const string LABEL_TIMERTEXT = "Text";

		private const string LABEL_ZONEEFFECTROOT = "ZoneEffect";

		private const string LABEL_ZONEEFFECT_SEC1 = "Section01";

		private const string LABEL_ZONEEFFECT_SEC2 = "Section02";

		private const string LABEL_ZONEEFFECT_SEC2Y = "Section02Yellow";

		private const string LABEL_SHINYEFFECTROOT = "ShinyEffect";

		private const string LABEL_SHINYEFFECT_BLUE = "LeadTime";

		private const string LABEL_SHINYEFFECT_GOLD = "BaseTime";

		private const string LABEL_SHADER_MAXTIME = "_MaxTime";

		private const string LABEL_SHADER_ADDTIME = "_AddTime";

		private const string LABEL_SHADER_ACTIVE = "_Active";

		private const string PATH_PREHAB = "Duel/BG/Timer/Timer_c001/Timer_c001";

		private const string PATH_PREHAB_SP = "Duel/BG/Timer/Timer_013/Timer_013";

		private GameObject m_TimerModel;

		private ElementObjectManager m_EOManager;

		private MeshRenderer m_TimerBody;

		private ExtendedTextMeshPro m_TimerText;

		private ElementObjectManager m_ShinyEffectEom;

		private ElementObjectManager m_ZoneEffectEom;

		private int m_MaxDuelTime;

		private bool m_Visilble;

		private int m_MaxTurnTime;

		private int m_RemainTimeIntOrg;

		private bool m_IsPlayerInput;

		private float m_RemainInDuel;

		private float m_RemainInTurn;

		private float m_RemainInTurnPre;

		private float m_RealTimePreFrame;

		private Step m_Step;

		public bool Active
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

		private float MAXTIME => 0f;

		private float m_RemainTotal => 0f;

		private int m_RemainTimeInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsPlayerTimeOver => false;

		private Material m_TimerMat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static DuelTimer3D Create(DuelGameObjectManager goManager, string name, bool isEsportsVer)
		{
			return null;
		}

		public void PrepareToDuel()
		{
		}

		private void ResetTimer()
		{
		}

		public void SetRemainTime(float dueltime, float turntime)
		{
		}

		public void OnDuelStart()
		{
		}

		public void OnDuelEnd()
		{
		}

		public void SetPlayerInput(bool value)
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

		private void UpdateTimerCage()
		{
		}

		protected void EmergencyEffect()
		{
		}

		protected void Initialize(bool isEsportsVer)
		{
		}

		protected void Terminate()
		{
		}
	}
}
