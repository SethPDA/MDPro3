using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class CardStatusLabel3D
	{
		private enum StatusType
		{
			Monster = 0,
			Magic = 1,
			PendulumCard = 2
		}

		private enum StateIconType
		{
			DISABLE = 0,
			UNATTACKABLE = 1,
			TRUNER = 2
		}

		public const int UNINITIALIZEDVALUE = 0;

		private const int STATUSICONCOUNT = 5;

		private const string LABEL_EO_TR_STATUSLABEL = "StatusLabelRoot";

		private const string LABEL_EO_TR_OVERLAYUNITS = "MonsterMaterialsRoot";

		private const string LABEL_EO_TR_POWERPOINT = "CardAttackBody";

		private const string LABEL_EO_TR_ATTRBUTE = "CardAttribute";

		private const string LABEL_EO_TR_ATTRBUTEOUTLINE = "IconAttributeChange";

		private const string LABEL_EO_TR_LINKNUM = "LinkCount";

		private const string LABEL_EO_TR_LAVELRANK = "CardLevel";

		private const string LABEL_EO_TR_PENDULUM = "CardPendulumBody";

		private const string LABEL_EO_TR_PENDULUM_L = "PendulumLeft";

		private const string LABEL_EO_TR_PENDULUMTEXT_L = "TextPendulumLeftRoot";

		private const string LABEL_EO_TR_PENDULUM_R = "PendulumRight";

		private const string LABEL_EO_TR_PENDULUMTEXT_R = "TextPendulumRightRoot";

		private const string LABEL_EO_TR_TYPE = "CardType";

		private const string LABEL_EO_TR_TYPEICONOUTLINE = "IconTypeChange";

		private const string LABEL_EO_TR_TUNERICON = "TunerIconRoot";

		private const string LABEL_EO_TR_TUNERICONOUTLINE = "TunerIconOutline";

		private const string LABEL_EO_TR_MAGICTYPE = "MagicTypeBase";

		private const string LABEL_EO_TR_COUNTER = "CardCounter";

		private const string LABEL_EO_TR_LINKMARKERROOT = "LinkMarkerRoot";

		private const string LABEL_EO_TR_LINKMARKER = "LinkMarker";

		private const string LABEL_EO_TR_DEFAULTSHOW = "DefaultShow";

		private const string LABEL_EO_TR_DEFAULTHIDE = "DefaultHide";

		private const string LABEL_EO_TR_SWITCHTWEENROOT = "FieldCardChangeIcon";

		private const string LABEL_EO_TR_STATEICONNROOT = "StatusIcon";

		private const string LABEL_EO_TXT_POWERPOINT = "TextPowerPoint";

		private const string LABEL_EO_TXT_OVERLAYUNITS = "TextMonsterMaterials";

		private const string LABEL_EO_TXT_LINKNUM = "TextLinkCount";

		private const string LABEL_EO_TXT_LAVELRANK = "TextLevel";

		private const string LABEL_EO_TXT_PENDULUM_L = "TextPendulumLeft";

		private const string LABEL_EO_TXT_PENDULUM_R = "TextPendulumRight";

		private const string LABEL_EO_TXT_COUNTER = "TextCounter";

		private const string LABEL_EO_IMG_ATTRIBUTE = "IconAttribute";

		private const string LABEL_EO_IMG_LEVELICON = "IconLevel";

		private const string LABEL_EO_IMG_TYPEICON = "IconType";

		private const string LABEL_EO_IMG_MAGICTYPE = "MagicType";

		private const string LABEL_EO_IMG_MAGICTYPEOUTLINE = "MagicTypeChange";

		private const string LABEL_EO_IMG_COUNTER = "IconCounter";

		private const string LABEL_EO_IMG_STATUS = "IconStatus";

		private const string LABEL_TW_SCALEOUT = "ScaleOut";

		private const string LABEL_TW_SCALEIN = "ScaleIn";

		private const string LABEL_TW_CHANGECOUNTER = "ChangeCounter";

		private const string LABEL_TW_ATTACK = "Attack";

		private const string LABEL_TW_DEFENCE = "Defense";

		private const string LABEL_TW_SHOWLABEL = "ShowLabel";

		private const string LABEL_TW_HIDELABEL = "HideLabel";

		public static List<CardStatusLabel3D> m_LabelPool;

		private CardRoot m_CardRoot;

		private Transform m_RootStatesLabel;

		private Transform m_RootOverlayUnits;

		private Transform m_RootPowerPoint;

		private Transform m_RootArribute;

		private Transform m_RootLinkNum;

		private Transform m_RootLinkMarker;

		private Transform m_RootLavelRank;

		private Transform m_RootPendulum;

		private Transform m_RootPendulumL;

		private Transform m_RootPendulumTextL;

		private Transform m_RootPendulumR;

		private Transform m_RootPendulumTextR;

		private Transform m_RootType;

		private Transform m_RootMagicType;

		private Transform m_RootCounter;

		private Transform m_RootDefaultShow;

		private Transform m_RootDefaultHide;

		private Transform m_RootStateIcons;

		private Transform m_RootTunerIcon;

		private Transform m_OutlineMagicType;

		private Transform m_OutlineTunerIcon;

		private Transform m_OutlineArribute;

		private Transform m_OutlineMonsterTypeIcon;

		private TextMeshPro m_TmpPower;

		private TextMeshPro m_TmpOverlayUnits;

		private TextMeshPro m_TmpLinkNum;

		private TextMeshPro m_TmpLavelRank;

		private TextMeshPro m_TmpPendulumL;

		private TextMeshPro m_TmpPendulumR;

		private TextMeshPro m_TmpCounter;

		private SpriteRenderer m_SrLavelRank;

		private SpriteRenderer m_SrAttribute;

		private SpriteRenderer m_SrTypeIcon;

		private SpriteRenderer m_SrMagicTypeIcon;

		private SpriteRenderer m_SrCounter;

		private bool m_AtkInitialized;

		private bool m_DefInitialized;

		private bool m_BackAtkDefInitialized;

		private bool m_Visible;

		private int m_ShowAtk;

		private int m_ShowDef;

		private Tween m_TwChangeCounter;

		private Tween m_TwAtkToDef;

		private Tween m_TwDefToAtk;

		private Tween m_TwShowLabel;

		private Tween m_TwHideLabel;

		private int m_CurrentCounterIndex;

		protected List<Transform> m_RotateItemList;

		protected Dictionary<int, int> m_MarkerPosTable;

		private ElementObjectManager m_RootSwitchTween;

		private bool m_LinkMarkerShowing;

		public bool ShowFullStatus;

		private int m_SlhFontSize => 0;

		private int m_ActiveFontSize => 0;

		private int m_InactiveFontSize => 0;

		public static bool visibleAll
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

		public static void ResetLabelPool()
		{
		}

		public static CardStatusLabel3D Create(CardRoot cardroot)
		{
			return null;
		}

		private void InitComponent()
		{
		}

		private void InitRotationList()
		{
		}

		public void InitParameters()
		{
		}

		private IEnumerator UpdatePowerPointProcess()
		{
			return null;
		}

		private void UpdateLevelRank()
		{
		}

		private void UpdateAttribute()
		{
		}

		private void UpdtaeLink()
		{
		}

		private void UpdateType()
		{
		}

		private void UpdateMagicType()
		{
		}

		private void UpdateTunerIcon()
		{
		}

		private void UpdatePendulumScale()
		{
		}

		private void UpdateOverlayUnits()
		{
		}

		private void UpdateCounter()
		{
		}

		private void UpdateLinkMarker()
		{
		}

		private void UpdateStateIcons()
		{
		}

		private void ChangeCounter()
		{
		}

		private int ChangePowerPoint(int powernow, int powertarget)
		{
			return 0;
		}

		private string GetPowerPointString(int powershow, int powerorg, bool active)
		{
			return null;
		}

		private void UpdatePowerPointImpl()
		{
		}

		private SpriteRenderer GetStateIcon(int index)
		{
			return null;
		}

		private bool AddStateIcon(StateIconType icontype, int iconindex)
		{
			return false;
		}

		private Color GetValueColor(int valuedisp, int valueorg)
		{
			return default(Color);
		}

		private void LinkMarkerZoomIn()
		{
		}

		private void LinkMarkerZoomOut()
		{
		}

		private void SetLinkMarkerShineEnable(bool enable)
		{
		}

		private void Initialize(CardRoot cardroot)
		{
		}

		public void UpdateCardStatues()
		{
		}

		public void AtkDefSwitch()
		{
		}

		public void DefAtkSwitch()
		{
		}

		public void Hide(bool immediate = false)
		{
		}

		public void Show(bool immediate = false)
		{
		}

		public void StopAllTween()
		{
		}

		public void StopStateChangeTween()
		{
		}

		public void StopShowHideTween()
		{
		}

		public void RotateStatueLabel(Quaternion rotation)
		{
		}

		public static void HideAll(bool immediate = false)
		{
		}

		public static void ShowAll(bool immediate = false)
		{
		}
	}
}
