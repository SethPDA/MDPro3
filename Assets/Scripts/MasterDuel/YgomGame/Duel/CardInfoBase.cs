using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class CardInfoBase : MonoBehaviour
	{
		protected enum ValueState
		{
			NORMAL = 0,
			CHANGED = 1,
			UP = 2,
			DOWN = 3
		}

		protected Color m_FontColorNormal;

		protected Color m_FontColorChanged;

		protected const int MAXLINKNUM = 8;

		protected const int BIT_CANTATTACK = 512;

		protected const int BIT_HANDOPEN = 2048;

		public const int INVALID_HIGHLIGHT_TEXTID = 0;

		protected const string SIGN_BRACKET_PRE = "\ufffd";

		protected const string SIGN_BRACKET_SUF = "\ufffd";

		protected const string SIGN_SLASH = "\ufffd";

		protected const string LABEL_TWEEN_SCROLL = "AutoScroll";

		protected const string LABEL_RT_WINDOW = "Window";

		protected const string LABEL_RT_PENDULUMSCALE = "PendulumScale";

		protected const string LABEL_RT_LINKARROWS = "LinkArrows";

		protected const string LABEL_RT_NAMEAREA = "NameArea";

		protected const string LABEL_RT_TEXTAREA = "TextArea";

		protected const string LABEL_RT_STATUEICONS = "StatueIcons";

		protected const string LABEL_RT_ACTIVATEDGROUP = "ActivatedGroup";

		protected const string LABEL_RTXT_CARDNAME = "TextCardName";

		protected const string LABEL_RIMG_CARDIMAGE = "ImageCard";

		protected const string LABEL_IMG_ICONRARITY = "IconRarity";

		protected const string LABEL_IMG_ATTRIBUTEICON = "IconAttribute";

		protected const string LABEL_IMG_ATTROUTLINE = "AttrOutline";

		protected const string LABEL_IMG_TUNERGROUP = "TunerGroup";

		protected const string LABEL_IMG_TUNERICON = "IconTuner";

		protected const string LABEL_IMG_TUNEROUTLINE = "TunerOutline";

		protected const string LABEL_IMG_LINKARROW = "LinkArrow";

		protected const string LABEL_IMG_LINKICON = "IconLink";

		protected const string LABEL_IMG_LEVELICON = "IconLevel";

		protected const string LABEL_IMG_RANKICON = "IconRank";

		protected const string LABEL_IMG_XYZMATICON = "IconXyzMaterial";

		protected const string LABEL_IMG_TYPEGROUP = "TypeGroup";

		protected const string LABEL_IMG_TYPEICON = "IconType";

		protected const string LABEL_IMG_TYPEOUTLINE = "TypeOutline";

		protected const string LABEL_IMG_SPTRTYPEROOT = "SpellTrapType";

		protected const string LABEL_IMG_SPTRTYPE = "IconSpellTrapType";

		protected const string LABEL_IMG_ATKICON = "IconAtk";

		protected const string LABEL_IMG_DEFICON = "IconDef";

		protected const string LABEL_IMG_TURNNUM = "IconTurnCounter";

		protected const string LABEL_IMG_COUNTER = "IconCounter";

		protected const string LABEL_IMG_PLATETITLE = "PlateTitle";

		protected const string LABEL_IMG_PLATEDESCRIPTION = "PlateDescription";

		protected const string LABEL_IMG_ACTIVATEDICON = "IconActivated";

		protected const string LABEL_IMG_PLATEACTIVATED = "PlateActivated";

		protected const string LABEL_TXT_LEVELNUM = "TextLevel";

		protected const string LABEL_TXT_RANKNUM = "TextRank";

		protected const string LABEL_TXT_XYZMATNUM = "TextXyzMaterial";

		protected const string LABEL_TXT_TURNCOUNTERNUM = "TextTurnCounter";

		protected const string LABEL_TXT_PENDULUMSCALENUM = "TextPendulumScale";

		protected const string LABEL_TXT_LINKNUM = "TextLink";

		protected const string LABEL_TXT_SPTRTYPE = "TextSpellTrapType";

		protected const string LABEL_TXT_ATKVALUE = "TextAtk";

		protected const string LABEL_TXT_DEFVALUE = "TextDef";

		protected const string LABEL_TXT_COUNTERNUM = "CounterNum";

		protected const string LABEL_TXT_DSPTITLE = "TextDescriptionItem";

		protected const string LABEL_TXT_DSPCONTENT = "TextDescriptionValue";

		protected const string LABEL_GO_STATUEICON_DISABLEFFECT = "IconStatueDiable";

		protected const string LABEL_GO_STATUEICON_CANTREVIVE = "IconStatueCantRevive";

		protected const string LABEL_GO_STATUEICON_CANTATTACK = "IconStatueCantAttack";

		protected const string LABEL_GO_STATUEICON_HANDOPEN = "IconStatueHandOpen";

		protected const string LABEL_GO_STATUEICON_FUSIONMATERIAL = "IconStatueFusionMat";

		protected const string LABEL_GO_STATUEICON_SYNCMATERIAL = "IconStatueSyncMat";

		protected const string LABEL_GO_STATUEICON_DEMENSIONHOLE = "IconStatueDemensionHole";

		protected const string LABEL_GO_STATUEICON_BYBATTLE = "IconStatueByBattle";

		protected const string LABEL_BTN_CARDAREA = "CardArea";

		protected const string LABEL_ICON_CARDAREA_SHORTCUT = "CardAreaShortcut";

		protected const string LABEL_BAR_TEAM0 = "ColorBarTeam0";

		protected const string LABEL_BAR_TEAM1 = "ColorBarTeam1";

		protected const string HIGHLIGHTTEXTCOLORCODE = "00D2FF";

		protected Dictionary<int, GameObject> m_StatueIconTable;

		protected ElementObjectManager m_EOManager_Property;

		protected RectTransform m_Window_Property;

		protected RectTransform m_LinkArrows_Property;

		protected RectTransform m_PenScale_Property;

		protected RectTransform m_TextArea_Property;

		protected RectTransform m_NameArea_Property;

		protected RectTransform m_StatueIcons_Property;

		protected RectTransform m_SpTrTypeRoot_Property;

		protected RubyTextGX m_CardName_Property;

		protected RawImage m_CardImage_Property;

		protected Image m_GachaRareIcon_Property;

		protected Image m_AttributeIcon_Property;

		protected Image m_AttrOutline_Property;

		protected Image m_TunerIcon_Property;

		protected RectTransform m_TunerGroup_Property;

		protected Image m_TunerOutline_Property;

		protected Image m_LevelIcon_Property;

		protected Image m_LinkIcon_Property;

		protected Image m_RankIcon_Property;

		protected Image m_XyzMatIcon_Property;

		protected Image m_TypeIcon_Property;

		protected RectTransform m_TypeGroup_Property;

		protected RectTransform m_ActivatedGroup_Property;

		protected Image m_TypeOutline_Property;

		protected Image m_SpTrTypeIcon_Property;

		protected Image m_AtkIcon_Property;

		protected Image m_DefIcon_Property;

		protected Image m_NameAreaBg_Property;

		protected Image m_TypeAreaBg_Property;

		protected Image m_TurnElapsedIcon_Property;

		protected Image m_ActivatedIcon_Property;

		protected Image m_ActivatedPlate_Property;

		protected ExtendedTextMeshProUGUI m_XyzMatNum_Property;

		protected ExtendedTextMeshProUGUI m_TurnElapsedNum_Property;

		protected ExtendedTextMeshProUGUI m_PenScaleNum_Property;

		protected ExtendedTextMeshProUGUI m_LinkNum_Property;

		protected ExtendedTextMeshProUGUI m_LevelNum_Property;

		protected ExtendedTextMeshProUGUI m_RankNum_Property;

		protected ExtendedTextMeshProUGUI m_SpTrType_Property;

		protected ExtendedTextMeshProUGUI m_AtkValue_Property;

		protected ExtendedTextMeshProUGUI m_DefValue_Property;

		protected ExtendedTextMeshProUGUI m_DspTitle_Property;

		protected ExtendedTextMeshProUGUI m_DspContent_Property;

		protected SelectionButton m_CardArea_Property;

		protected SelectionItem m_TextAreaItem_Property;

		protected RectTransform m_ColorBarTeam0_Property;

		protected RectTransform m_ColorBarTeam1_Property;

		public bool AlwaysDisp;

		public bool EnableAttributeIcon;

		protected CardInfoData m_CardInfoData;

		protected CardInfoData m_CardInfoDataOld;

		protected Dictionary<int, int> m_HighLightEfxTableForHappening;

		protected Dictionary<int, int> m_HighLightEfxTableForToHappen;

		protected PopUpTextManager m_PutManager;

		protected static Content m_CCI => null;

		protected DuelIconSprites m_DuelIconSprites => null;

		protected ElementObjectManager m_EOManager => null;

		protected RectTransform m_Window => null;

		protected RectTransform m_LinkArrows => null;

		protected RectTransform m_PenScale => null;

		protected RectTransform m_TextArea => null;

		protected RectTransform m_NameArea => null;

		protected RectTransform m_StatueIcons => null;

		protected RectTransform m_SpTrTypeRoot => null;

		protected RubyTextGX m_CardName => null;

		protected RawImage m_CardImage => null;

		protected Image m_GachaRareIcon => null;

		protected Image m_AttributeIcon => null;

		protected Image m_AttrOutline => null;

		protected Image m_TunerIcon => null;

		protected RectTransform m_TunerGroup => null;

		protected Image m_TunerOutline => null;

		protected Image m_LevelIcon => null;

		protected Image m_LinkIcon => null;

		protected Image m_RankIcon => null;

		protected Image m_XyzMatIcon => null;

		protected Image m_TypeIcon => null;

		protected RectTransform m_TypeGroup => null;

		protected RectTransform m_ActivatedGroup => null;

		protected Image m_TypeOutline => null;

		protected Image m_SpTrTypeIcon => null;

		protected Image m_AtkIcon => null;

		protected Image m_DefIcon => null;

		protected Image m_NameAreaBg => null;

		protected Image m_TypeAreaBg => null;

		protected Image m_TurnElapsedIcon => null;

		protected Image m_ActivatedIcon => null;

		protected Image m_ActivatedPlate => null;

		protected ExtendedTextMeshProUGUI m_XyzMatNum => null;

		protected ExtendedTextMeshProUGUI m_TurnElapsedNum => null;

		protected ExtendedTextMeshProUGUI m_PenScaleNum => null;

		protected ExtendedTextMeshProUGUI m_LinkNum => null;

		protected ExtendedTextMeshProUGUI m_LevelNum => null;

		protected ExtendedTextMeshProUGUI m_RankNum => null;

		protected ExtendedTextMeshProUGUI m_SpTrType => null;

		protected ExtendedTextMeshProUGUI m_AtkValue => null;

		protected ExtendedTextMeshProUGUI m_DefValue => null;

		protected ExtendedTextMeshProUGUI m_DspTitle => null;

		protected ExtendedTextMeshProUGUI m_DspContent => null;

		protected SelectionButton m_CardArea => null;

		protected SelectionItem m_TextAreaItem => null;

		protected RectTransform m_ColorBarTeam0 => null;

		protected RectTransform m_ColorBarTeam1 => null;

		public bool isShowing
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public static bool IsTextResourceLoaded()
		{
			return false;
		}

		protected static void LoadCardInfoBaseResource()
		{
		}

		protected static void UnloadCardInfoBaseResource()
		{
		}

		protected CardInfoData UpdateCardInfoDataByUniqueId(int uniqueid)
		{
			return default(CardInfoData);
		}

		protected CardInfoData UpdateCardInfoDataByCardId(int cardid, int styleid, int player = -1)
		{
			return default(CardInfoData);
		}

		protected void SetRubyName(int cardidorg, int cardidDisp)
		{
		}

		protected void SetAttribute(int cardidorg, Content.Attribute attrdisp)
		{
		}

		protected void SetBgColor(Image bg, Content.Frame type)
		{
		}

		protected void SetOwner()
		{
		}

		protected void SetCardImage(int cardidorg, int styleid)
		{
		}

		protected void SetLinkArrows(int cardidorg)
		{
		}

		protected void SetOverlayNum(int cardidorg, int owner, int locate, int index, int overlaynum)
		{
		}

		protected void SetPendulumScale(int cardidorg, int owner, int locate, int index, int scale, int orgscale)
		{
		}

		protected void SetTunerIcon(int cardidorg, int owner, int locate, int index)
		{
		}

		protected void SetTurnElapsed(int owner, int locate, int index, int turncounter)
		{
		}

		protected void SetLevel(int leveldisp, int levelorg)
		{
		}

		protected void SetRank(int rankdisp, int rankorg)
		{
		}

		protected void SetLinkNum(int cardidorg)
		{
		}

		protected void SetType(int typedispid, int typeorg)
		{
		}

		protected void SetAtk(int cardidorg, int atkdisp, int atkorigin, bool ismonsternow)
		{
		}

		protected void SetDef(int cardidorg, int defdisp, int deforigin, bool ismonsternow)
		{
		}

		protected void SetCounters(int owner, int locate, int index, int maxcounternum, List<KeyValuePair<Engine.CounterType, int>> countertable)
		{
		}

		protected void SetSpTrType(int cardidorg, int player, int position, bool hasinstance)
		{
		}

		protected void SetDspTitle(int cardidorg, int typeid, int effectid, int player, int position, bool istuner, bool hasinstance)
		{
		}

		protected void SetActivatedIcon(int cardId, int owner)
		{
		}

		protected Image GetLinkArrow(int index)
		{
			return null;
		}

		protected void AddTypeText(ref string origin, Content.Type type, bool typechanged)
		{
		}

		protected void AddKindText(ref string origin, Content.Kind kind, bool effectchanged, bool tunerchanged, bool isTrap, bool isTrapMonster)
		{
		}

		protected Color GetFontColor(ValueState valuestate)
		{
			return default(Color);
		}

		protected string AddColorTag(string origin, Color color)
		{
			return null;
		}

		protected string AddColorTag(string origin, string colorcode)
		{
			return null;
		}

		protected string AddAlphaTag(string origin, string alphacode)
		{
			return null;
		}

		protected void SetRareIcon(int cardid, RarityIconBinder.Type type)
		{
		}

		protected void SetStatueBar(bool visible)
		{
		}

		protected Image GetCounterImage(int index)
		{
			return null;
		}

		protected ExtendedTextMeshProUGUI GetCounterText(int index)
		{
			return null;
		}

		protected void InitStatueIconTable()
		{
		}

		protected void InitCardInfoData()
		{
		}

		protected void SetStatueIconPopUpText(int index, string text)
		{
		}

		public void SetHighlightEffectHappening(int uniqueid, int textid)
		{
		}

		public void UpdateHighLightTextIdTableForToHappen(int index, int textid)
		{
		}

		public void RemoveHightEffect()
		{
		}

		public void SetAttributeFlag(int flagbit, int cardid, int owner = -1, int locate = -1, int index = -1, bool isfightableoneffect = false)
		{
		}

		protected virtual void InitializeBase()
		{
		}

		private void OnDestroy()
		{
		}

		public static bool CheckHighLightTextIdValid(int textid)
		{
			return false;
		}
	}
}
