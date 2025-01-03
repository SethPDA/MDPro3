using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class CardInfoDetail : CardInfoBase
	{
		protected const int MAXCOUNTERNUM = 6;

		protected const string PATH_PREHAB = "Prefabs/Duel/UI/CardInfoDetail";

		internal const string PATH_PREHAB_DOWNLOAD = "Prefabs/Duel/UI/CardInfoDetail_Download";

		internal const string PATH_PREHAB_BROWSER = "Prefabs/Duel/UI/CardInfoDetail_Browser";

		protected const string WORD_EFFECT = "\ufffd";

		protected const string WORD_TUNER = "チ\ufffd";

		protected const string LABEL_EO_BUTTONBACK = "ButtonBack";

		protected const string LABEL_EO_COUNTERNUM = "CounterNum";

		protected const string LABEL_EO_ICONCOUNTER = "IconCounter";

		protected const string LABEL_EO_ICONLIMIT = "IconLimit";

		protected const string LABEL_EO_ICONSTATUEBYBATTLE = "IconStatueByBattle";

		protected const string LABEL_EO_ICONSTATUECANTREVIVE = "IconStatueCantRevive";

		protected const string LABEL_EO_ICONSTATUEDEMENSIONHOLE = "IconStatueDemensionHole";

		protected const string LABEL_EO_ICONSTATUEDISABLE = "IconStatueDiable";

		protected const string LABEL_EO_ICONSTATUEFUSIONMAT = "IconStatueFusionMat";

		protected const string LABEL_EO_ICONSTATUELIGHTFORCE = "IconStatueLightForce";

		protected const string LABEL_EO_ICONSTATUESYNCMAT = "IconStatueSyncMat";

		protected const string LABEL_EO_ICONSTATUECANTATTACK = "IconStatueCantAttack";

		protected const string LABEL_EO_ROOTTUNER = "TunerGroup";

		protected const string LABEL_EO_ROOTTYPE = "TypeGroup";

		protected const string LABEL_EO_PENDULUMDESCAREA = "PendulumDescriptionArea";

		protected const string LABEL_EO_PLATEDESC = "PlateDescription";

		protected const string LABEL_EO_PLATEPARAMATOR = "PlateParamator";

		protected const string LABEL_EO_PLATEPENDESC = "PlatePendulumDescription";

		protected const string LABEL_EO_TEXTPENDESCVALUE = "TextPendulumDescriptionValue";

		protected const string LABEL_EO_TEXTPENDESC = "TextPendulumDescriptionItem";

		protected const string LABEL_EO_PARAMATORAREABOTTOM = "ParamatorAreaBottom";

		protected int m_RegId;

		protected bool m_EnableScrollByAnalogStick;

		protected SelectionItem m_DspTextArea;

		protected SelectionItem m_PenTextArea;

		protected UiSwitchTweenAnimationController m_UiSwitchTweenAnimationController;

		protected FullScreenUiBg m_FullScreenUiBg;

		protected RectTransform m_PendulumArea => null;

		protected Transform m_TunerRoot => null;

		protected Image m_LimitIcon => null;

		protected Image m_DescAreaBg => null;

		protected Image m_ParamAreaBg => null;

		protected Image m_PenDescAreaBg => null;

		protected ExtendedTextMeshProUGUI m_DspPendulum => null;

		protected SelectionButton m_BackButton => null;

		protected RectTransform m_ParaAreaBottom => null;

		public static bool IsResourceLoaded()
		{
			return false;
		}

		public static void LoadResource()
		{
		}

		public static void UnloadResource()
		{
		}

		public static void Create(Transform parent, Action finishedCallback, string prefPath)
		{
		}

		public void SetFullScreenUiBg(FullScreenUiBg fullScreenUiBg)
		{
		}

		public void Show()
		{
		}

		public void SetCardByCardInfoData(CardInfoData cardInfoData)
		{
		}

		public void SetCardByUniqueId(int uniqueId)
		{
		}

		public void SetCardByCardId(int cardid, int styleid = 1)
		{
		}

		public void Close(bool closebg = true)
		{
		}

		public void SetRegulationId(int regid)
		{
		}

		public void SetScrollByAnalogStickEnable(bool enable)
		{
		}

		protected override void InitializeBase()
		{
		}

		protected void ResetNameScroll()
		{
		}

		protected void SetTitleAreaByBasicVal(int cardIdOrg, ref Engine.BasicVal basicalval)
		{
		}

		protected void SetTitleAreaByCardId(int cardid)
		{
		}

		protected void SetCardArea(CardInfoData cardinfodata)
		{
		}

		protected void SetParameterArea(CardInfoData cardinfodata)
		{
		}

		protected void SetDescriptionArea(CardInfoData cardinfodata)
		{
		}

		protected void SetPendulumTag()
		{
		}

		protected void SetParaAreaBottom()
		{
		}

		protected void SetDspContent(int cardidorg, int effectid, bool isInField = false, bool hasPenScale = false, int effflag = 0)
		{
		}

		protected void SetLimitIcon(int cardid)
		{
		}
	}
}
