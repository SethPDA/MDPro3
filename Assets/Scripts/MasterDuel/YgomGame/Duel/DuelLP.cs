using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class DuelLP : MonoBehaviour
	{
		public enum Step
		{
			Idle = 0,
			WaitSubEffect = 1,
			TransitionLP = 2,
			WaitToIdle = 3,
			ToIdle = 4
		}

		public enum DispMode
		{
			NormalMode = 0,
			SimpleMode = 1
		}

		public float countTime;

		public float EmergencyPeriod;

		public Color lpColorDamage;

		public Color lpColorRecover;

		public Color lpColorNormal;

		protected const string LAEBL_EO_RVS = "RestValueShow";

		protected const string LAEBL_EO_CONTENT = "Content";

		protected const string LAEBL_EO_LIFEPOINTROOT = "LifePointRoot";

		protected const string LAEBL_EO_CHANGEVALUEROOT = "ChangeValueRoot";

		protected const string LAEBL_EO_LPLABEL = "LPLabel";

		protected const string LAEBL_EO_RECTVALUEBG = "RectValueBg";

		protected const string LAEBL_EO_PLAYERICON = "PlayerIcon";

		protected const string LAEBL_EO_PLAYERICONFRAME = "PlayerIconBorder";

		protected const string LAEBL_EO_PLAYERNAME = "PlayerName";

		protected const string LAEBL_EO_EXTRAIDROOT = "ExtraIdRoot";

		protected const string LAEBL_EO_EXTRAIDNAME = "ExtraIdName";

		protected const string LAEBL_EO_EXTRAIDICON = "ExtraIdIcon";

		protected const string LAEBL_EO_SPECIALACCOUNTICONS = "SpecialAccountIcons";

		protected const string LAEBL_EO_VALPOS = "ValueBirthPos";

		protected const string LAEBL_EO_NETWORKERROR = "NetworkErrorRoot";

		protected const string LAEBL_TP_CSUB = "ChangeValue";

		protected const string LABEL_SE_LP_COUNT = "SE_LP_COUNT";

		protected const string LABEL_SE_LP_ZERO = "SE_LP_ZERO";

		protected const string LABEL_TW_CMAINZOOMIN = "CMainZoomIn";

		protected const string LABEL_TW_CSUBZOOMIN = "CSubZoomIn";

		protected const string LABEL_TW_CSUBZOOMOUT = "CSubZoomOut";

		protected const string CURRENTPLATFORMICONPATH = "Images/PlatformIcon/<_PLATFORM_>/CurrentPlatformS";

		protected const int NUM_DEFAULTCSUBNUM = 2;

		protected int m_LPBeforeTrans;

		protected int m_LPTarget;

		protected int m_LPCurrent;

		protected int m_LPForDisp;

		protected float m_CurrentTime;

		protected float m_WaitTime;

		protected DuelClient m_Host;

		protected Action m_OnFinishedCallBack;

		protected List<LPCounterSub> m_CounterSubs;

		protected Step m_Step;

		protected Dictionary<Step, Action> m_StepActTable;

		protected ElementObjectManager m_EOManager;

		protected DispMode m_DispMode;

		protected DispMode m_TargetDispMode;

		protected string m_CurrentSeLabel;

		protected bool m_IsSimpleViewMode;

		protected bool m_DuelEnd;

		private GameObject m_networkErrorRoot;

		private ExtendedTextMeshProUGUI m_CounterMainTxtShow_Origin;

		private bool m_IsInitialized;

		public int currentLP => 0;

		protected ExtendedTextMeshProUGUI m_RVS => null;

		public static void Create(Transform parent, int player, DuelClient host, Action<DuelLP> onFinished)
		{
		}

		public void Initialize(int playerid, DuelClient host)
		{
		}

		public void SetLP(int lp)
		{
		}

		public void ChangeLP(int afterLP, int damage, Engine.DamageType type, int player, int position, Action onFinished = null)
		{
		}

		public void ChangeMode(DispMode mode)
		{
		}

		protected LPCounterSub AppendLPCounterSub()
		{
			return null;
		}

		protected bool ApplyCounterSub(int targetlp, int changevalue, Engine.DamageType type, int player, int position)
		{
			return false;
		}

		protected Vector2 GetRectPosBy3DPos(RectTransform rect, Vector3 worldpos)
		{
			return default(Vector2);
		}

		protected void ApplyTransLP(Color lpcol, int targetlife)
		{
		}

		protected void IdleStep()
		{
		}

		protected void WaitSubEffectStep()
		{
		}

		protected void TransitionLPStep()
		{
		}

		protected void WaitToIdleStep()
		{
		}

		protected void ToIdleStep()
		{
		}

		protected LPCounterSub GetAvailableLPCounterSub()
		{
			return null;
		}

		protected void EmergencyEffect()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void UpdateLayout()
		{
		}

		public void OnDuelEnd()
		{
		}

		public SelectionButton GetButton()
		{
			return null;
		}

		public void SetDispNetworkError(bool disp)
		{
		}

		public void SetName(int playerid)
		{
		}
	}
}
