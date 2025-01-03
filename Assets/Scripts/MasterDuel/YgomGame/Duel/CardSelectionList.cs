using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel
{
	public class CardSelectionList : MonoBehaviour, IGenericScrollViewSupport
	{
		private class SeperateInfo
		{
			public int startindex;

			public int endindex;

			public int playerid;

			public CardLocateType locate;

			public CardSelectionListGroupLabel grouplabel;

			public RectTransform grouplabelrt => null;

			public SeperateInfo(CardLocateType locate, int playerid, CardSelectionListGroupLabel grouplabel)
			{
			}
		}

		public enum CardLocateType
		{
			FieldArea = 0,
			FieldZone = 12,
			Hand = 13,
			Grave = 16,
			Exclusion = 17,
			ExDeck = 14,
			MainDeck = 15,
			OverlayUnit = 32,
			CheckTiming = 33,
			None = 18
		}

		private class SetListDesc
		{
			public ListType type;

			public Action onFinished;

			public string title;

			public bool nocancel;

			public bool decidable;

			public Action onCancelled;

			public bool isWaitInput;

			public bool isSort;

			public SetListDesc(ListType type, Action onFinished, string title, bool nocancel = false, bool decidable = false, Action onCancelled = null, bool isWaitInput = false, bool isSort = true)
			{
			}
		}

		public enum ListType
		{
			Summon = 0,
			SpSummon = 1,
			MonsterEffect = 2,
			MagicTrap = 3,
			FlipTurn = 4,
			Attack = 5,
			Chain = 6,
			CheckTiming = 7,
			NoramlList = 8,
			NoramlListSetResult = 9,
			Selection = 10,
			BasicGrave = 11,
			BasicEx = 12,
			BasicDeck = 13,
			OpponentHand = 14,
			MyDeckTop = 15,
			OpponentDeckTop = 16,
			CheckCard = 17,
			BlindSelect = 18,
			SelAllCard = 19,
			SelAllDeck = 20,
			SelAllMonst = 21,
			SelAllMonst2 = 22,
			SelAllGadget = 23,
			SelAllIndeck = 24,
			None = 25
		}

		public enum CountMode
		{
			None = 0,
			Star = 1,
			Link = 2,
			Atk = 3
		}

		private const string PATH_PREHAB = "Prefabs/Duel/CardSelectionList";

		private const string PATH_PREHAB_MOBILE = "Prefabs/Duel/CardSelectionList_Mobile";

		private const string LABEL_EO_TEXTTITLE = "TextTitle";

		private const string LABEL_EO_TITLE = "Title";

		private const string LABEL_EO_DECIDEBUTTON = "DecideButton";

		private const string LABEL_EO_DECISIONBUTTON = "DecisionButton";

		private const string LABEL_EO_CLOSEBUTTON = "CloseButton";

		private const string LABEL_EO_VIEWTOGGLE = "ViewToggle";

		private const string LABEL_EO_SCROLLVIEW = "ScrollView";

		private const string LABEL_EO_DECIDETEXT = "DecideText";

		private const string LABEL_EO_CLOSETEXT = "CloseText";

		private const string LABEL_EO_LISTWINDOW = "ListWindow";

		private const string LABEL_EO_GROUPLABELTEMPLATE = "GroupLabelTemplate";

		private const string LABEL_EO_GROUPLABELPOOL = "GroupLabelPool";

		private const string LABEL_EO_GROUPSCROLLLEFT = "GroupScrollLeftShortCutSbtn";

		private const string LABEL_EO_GROUPSCROLLRIGHT = "GroupScrollRightShortCutSbtn";

		private const string LABEL_EO_FIELDVIEWBUTTON = "FieldViewButton";

		private const string LABEL_EO_FIELDVIEWON = "FieldViewOn";

		private const string LABEL_EO_FIELDVIEWOFF = "FieldViewOff";

		private const string LABEL_EO_FIELDVIEWSHORTCUT = "FieldViewShortcut";

		private const string LABEL_EO_COUNTERGROUP = "CounterGroup";

		private const string LABEL_EO_STARGROUP = "StarGroup";

		private const string LABEL_EO_STARTEMPLATE = "StarTemplate";

		private const string LABEL_EO_LINKGROUP = "LinkGroup";

		private const string LABEL_EO_LINKTEMPLATE = "LinkTemplate";

		private const string LABEL_EO_ATTACKGROUP = "AttackGroup";

		private const string LABEL_EO_CURRENTPARAM = "CurrentParam";

		private const string LABEL_EO_REQUIREPARAM = "RequireParam";

		private const string LABEL_EO_DICARDGROUP = "DiscardGroup";

		private const string LABEL_EO_DICARDREMAIN = "DiscardRemain";

		private const string LABEL_EO_INPUTFIELD = "InputField";

		private const string LABEL_EO_NOHITTEXT = "NoHitText";

		private const string LABEL_EO_CARDNAME = "CardName";

		private const string LABEL_EO_ARROWLEFT = "ArrowLeft";

		private const string LABEL_EO_ARROWRIGHT = "ArrowRight";

		private const string LABEL_EO_INPUTBUTTON = "InputButton";

		private const string LABEL_TW_OPEN = "In";

		private const string LABEL_TW_VIEWTOGGLE = "ViewToggle";

		private const string LABEL_TW_DECIDEBUTTON = "DecideButton";

		private const string LABEL_TW_CLOSEBUTTON = "CloseButton";

		private const string LABEL_TW_FADEIN = "FadeIn";

		private const string LABEL_TW_FADEOUT = "FadeOut";

		private const string LABEL_TW_NORMALLIST = "Normal";

		private const string LABEL_TW_CHAINLIST = "Chain";

		public const int INVALIDRUNLISTINEDX = -1;

		private const int TITLETEXT_INDEX_DEFAULT = -1;

		private const int TITLETEXT_INDEX_GENERIC = 266;

		private bool m_IsWaitInput;

		private Transform m_Parent;

		private static readonly Dictionary<ListType, uint> CmdMask;

		[SerializeField]
		private float MaxWidth;

		[SerializeField]
		private float MinWidth;

		private DuelClient m_DuelClient;

		private ExtendedTextMeshProUGUI m_TextTitle;

		private Selector m_Selector;

		private Selector[] m_SelectorGroup;

		private ElementObjectManager m_Eom;

		private GenericScrollView m_Gsv;

		private ScrollRect m_ScrollRect;

		private SelectionButton m_DecideButton;

		private SelectionButton m_CloseButton;

		private SelectionButton m_DecisionButton;

		private RectTransform m_ListWindowRT;

		private InputFieldWidget m_InputFiled;

		private GameObject m_NoHitText;

		private GameObject m_GroupLabelTemplate;

		private List<ListCardData> m_GroupedDataList;

		private List<int> m_SelectedList;

		private List<SeperateInfo> m_SeperateInfoList;

		private Stack<CardSelectionListGroupLabel> m_GroupLabelFreeStack;

		private RectTransform m_GroupLabelPool;

		private ExtendedTextMeshProUGUI m_CardName;

		private GameObject m_FieldViewIconOn;

		private GameObject m_FieldViewIconOff;

		private SelectionButton m_ArrowLeft;

		private SelectionButton m_ArrowRight;

		private GameObject counterGroup;

		private GameObject starGroup;

		private GameObject linkGroup;

		private GameObject atkGroup;

		private ElementObjectManager starTemplate;

		private ElementObjectManager linkTemplate;

		private ExtendedTextMeshProUGUI textRequireParam;

		private ExtendedTextMeshProUGUI textCurrentParam;

		private CountMode currentCountMode;

		private int maxCount;

		private int currentCount;

		private List<ElementObjectManager> countObjects;

		private GameObject discardGroup;

		private ExtendedTextMeshProUGUI textDiscardRemain;

		private bool m_FieldViewing;

		private bool m_Closing;

		private bool m_Opening;

		private bool m_Cancable;

		private bool m_UseDecideButton;

		private int m_ChangeTitleFlag;

		private int m_SelectMaxNum;

		private int m_SelectMinNum;

		private string m_Titlemsg;

		private ListType m_ListType;

		private CanvasGroup m_CanvasGroup;

		private PopUpTextForSelectionList m_PppupText;

		private List<int> candidateCards;

		private Queue<SetListDesc> m_DescQueue;

		private Tween m_OpenTween;

		private Tween m_CloseTween;

		private int m_InputBlockCounter;

		private string cachedFmt;

		public Action OnFinished;

		public Action OnCanceled;

		public Action<Engine.CardStatus, bool> OnSelected;

		public Action OnUnselect;

		public int CurrentCursoredDataIndex;

		private string LABEL_TW_CLOSE => null;

		private bool m_IsDecisionActive => false;

		private bool m_IsDecideActive => false;

		private bool m_IsCloseActive => false;

		private string remainFormat => null;

		public Action OnOpenBegin
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

		public Action OnOpenEnd
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

		public Action OnCloseBegin
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

		public Action OnCloseEnd
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

		public bool IsActive => false;

		public bool IsDisp => false;

		public bool isCancelable => false;

		public bool isTweenPlaying => false;

		public bool isFieldViewing => false;

		public Action<bool, List<int>> decidedCallback
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

		public static void Create(DuelClient client, Transform parent, UnityAction<CardSelectionList> onFisnih)
		{
		}

		private void Initialize(DuelClient client, Transform parent)
		{
		}

		public void SetList(ListType type, Action onFinished, string title, bool nocancel = false, bool decidable = false, Action onCancelled = null, bool isWaitInput = false, bool isSort = true)
		{
		}

		private void InitComponents()
		{
		}

		private void OnScrollRectValueChange(Vector2 bias)
		{
		}

		private int GetSeperateInfoIndexByDataIndex(int dataindex)
		{
			return 0;
		}

		private void InitVariables()
		{
		}

		private CardSelectionListGroupLabel GetGroupLabel(int player, CardLocateType locate)
		{
			return null;
		}

		private void SetDecideVisible(bool visible, ListType type = ListType.Attack)
		{
		}

		private void SetDecisionVisible(bool visible)
		{
		}

		private void SetDecisionEnable(bool enable)
		{
		}

		private void SetCloseVisible(bool visible, bool decidable)
		{
		}

		private void SetCloseEnable(bool enable)
		{
		}

		private void SetDecideButtonTransition()
		{
		}

		private void SetCloseButtonTransition()
		{
		}

		private void SetDecisionButtonTransition()
		{
		}

		private void SetDecideEnable(bool valid, bool reachMax = false)
		{
		}

		private void SetFieldViewActive(bool field_view_active)
		{
		}

		private void SetArrowVisible()
		{
		}

		private void SwitchTween(string startlabel, string stoplabel = "")
		{
		}

		private void SetSelectionListWidth(int itemcount)
		{
		}

		private ListCardData CreateChainData(int position, int index)
		{
			return null;
		}

		private ListCardData CreateListCardData(int player, int position, int index, ListCardData.DataSource dataSource, bool forceinsight = false)
		{
			return null;
		}

		private List<ListCardData> CreateActivableList(ListType type)
		{
			return null;
		}

		private List<ListCardData> CreateDeckList(List<ListCardData> ret = null)
		{
			return null;
		}

		private List<ListCardData> CreatePosSelectList(List<ListCardData> ret = null)
		{
			return null;
		}

		private List<ListCardData> CreateNormalList()
		{
			return null;
		}

		private List<ListCardData> CreateSelectionList()
		{
			return null;
		}

		private List<ListCardData> CreateOpponentHandList()
		{
			return null;
		}

		private List<ListCardData> CreateDeckTopList(int player)
		{
			return null;
		}

		private List<ListCardData> CreateCheckCardList()
		{
			return null;
		}

		private void RemoveCardBadge(int dataindex, ref ListCardData selecteddata)
		{
		}

		private IEnumerator SelectIndex(int dataindexsort)
		{
			return null;
		}

		private void ChangeDecideButtonText(ListCardData cardData)
		{
		}

		private void AddTitleInfo()
		{
		}

		private void SetCursor(int dataindex)
		{
		}

		private void OnClickCard(ListCard card)
		{
		}

		private void OnHoldCard(ListCard card)
		{
		}

		private void OnDoubleClickCard(ListCard card)
		{
		}

		private List<ListCardData> GetGroupedDataList(List<ListCardData> infoList, bool isSort = true)
		{
			return null;
		}

		private List<ListCardData> ListGroupByLocate(List<ListCardData> infoList, int playerid, bool isSort = true)
		{
			return null;
		}

		private void CombineList(List<ListCardData> orglist, List<ListCardData> dstlist, CardLocateType locate, int playerid)
		{
		}

		private void RecycleGroupLabel()
		{
		}

		private List<ListCardData> ListSortByCard(List<ListCardData> infoList)
		{
			return null;
		}

		private int GetMonsterSortPoint(int cardid)
		{
			return 0;
		}

		private void SetupSearchList(string path)
		{
		}

		private void SetListImpl(ListType type, Action callback, bool decidable, bool nocancel, Action cancelCb, bool isSort = true)
		{
		}

		public void Open()
		{
		}

		public void Close(bool forceclose = false)
		{
		}

		public void OnDecide()
		{
		}

		public void OnCancel(bool decide, bool playse = true)
		{
		}

		public bool OnBack()
		{
			return false;
		}

		public bool OnDecideCardInField(int player, int position, int index)
		{
			return false;
		}

		public void OnFinishClose()
		{
		}

		private void SetSelectorsEnable(bool enable)
		{
		}

		private void ManualDownTransition(float position)
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public void OnItemInitialize(GameObject gob)
		{
		}

		public void OnGsvStanby()
		{
		}

		public void SetCursorToCurrentIndex()
		{
		}

		public bool SelectCardByUniqueId(int uniqueid)
		{
			return false;
		}

		private void SetTitle(string title)
		{
		}

		private List<ListCardData> CreateSearchList(string searchText)
		{
			return null;
		}

		private void SetupSelectorPriority()
		{
		}

		public void ShowCounter(Engine.DialogRitualType type, int remainCount, int maxCount)
		{
		}

		public void HideOptionalGroup()
		{
		}

		private void SetupCounterMethod(bool show, Engine.DialogRitualType type, int remainCount, int maxCount)
		{
		}

		private void SetupCounter(Engine.DialogRitualType type, int remainCount, int maxCount)
		{
		}

		private IEnumerator SetStartScale()
		{
			return null;
		}

		private void SetupCountGroup(CountMode mode, int maxCount)
		{
		}

		public void SetCount(int remainNum)
		{
		}

		private void DestroyCountObjectList()
		{
		}

		private void SetStarFadeEnable(bool enable, ListCard card)
		{
		}

		public void ShowDiscardRemain(int remain)
		{
		}

		private void SetupDiscardMethod(bool dispDiscard, int remain)
		{
		}

		public void SetRemain(int remainNum)
		{
		}

		public void OnItemExit(GameObject gob, int dataindex)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
