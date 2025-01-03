using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame
{
	public class DeckEditViewController2 : BaseMenuViewController
	{
		public enum DisplayMode
		{
			Simple = 0,
			Detailed = 1,
			Rarity = 2
		}

		public enum EditMode
		{
			Default = 0,
			Exhibition = 1,
			Cup = 2,
			Wcs = 3,
			RankEvent = 4,
			DuelTrial = 5,
			Versus = 6
		}

		private enum ViewType
		{
			None = 0,
			CardCollection = 1,
			Deck = 2,
			Unknown = 3
		}

		private enum SelectedCardType
		{
			None = 0,
			CollectionCard = 1,
			DeckCard = 2,
			RelatedCard = 3
		}

		private enum SaveDialogType
		{
			Back = 0,
			SecretPack = 1
		}

		private delegate void craftCallBack();

		private int m_ExhibitionID;

		private int m_CupID;

		private int m_WcsID;

		private int m_RankEventID;

		private int m_DuelTrialID;

		private int m_VersusID;

		private int m_VersusGroupID;

		private int m_RegulationID;

		private int m_RoomRegulationID;

		private int m_RentalCardID;

		private ElementObjectManager m_UI;

		private Action<int> onSavedDeckCallback;

		private bool isDismantleMode;

		private bool isScratch;

		private static bool isRunningFilterAndSort;

		private bool firstSort;

		private Content m_cci;

		public const string k_ArgsKeyDefaultDeck = "DeckName";

		public const string k_ArgsKeyEventDeckName = "EventDeckName";

		public const string k_ArgsKeyDeckID = "DeckId";

		public const string k_ArgsKeyExhibitionDeck = "ExhibitionID";

		public const string k_ArgsKeyCupDeck = "CupID";

		public const string k_ArgsKeyWcsDeck = "WcsID";

		public const string k_ArgsKeyRankEventDeck = "RankEventID";

		public const string k_ArgsKeyDuelTrialDeck = "DuelTrialID";

		public const string k_ArgsKeyVersusDeck = "VersusID";

		public const string k_ArgsKeyVersusGroupDeck = "VersusGroupID";

		public const string k_ArgsKeyIsScratch = "Scratch";

		public const string k_ArgsKeySecretPack = "SecretPack";

		public const string k_ArgsKeyRegulation = "RegulationID";

		public const string k_ArgsKeyRoomRegulation = "RoomRegulationID";

		public const string PREFAB_PATH_DECKLISTVIEW = "DeckEdit/DeckList";

		public const string PREFAB_PATH_CARDACTIONMENU = "DeckEdit/CardActionMenu";

		public const string PREFAB_PATH_CARDDETAIL = "DeckEdit/CardDetail";

		public const string PREFAB_PATH_CARDCOLLECTIONVIEW = "DeckEdit/CardCollection";

		public const string PREFAB_PATH_CARDHISTORYVIEW = "DeckEdit/CardHIstory";

		public const string PREFAB_PATH_LOOTSOURCE_VC = "DeckEdit/LootSource";

		private const string LABEL_HEADER = "Header";

		private const string LABEL_OVERHEADER = "OverHeader";

		private const string LABEL_TXT_TOURNAMENTTITLE = "TextRegulation";

		private const string LABEL_DECKVIEW = "DeckView";

		private const string LABEL_CARDACTIONMENU = "CardActionMenu";

		private const string LABEL_DETAILVIEW = "DetailView";

		private const string LABEL_COLLECTIONVIEW = "CollectionView";

		private const string LABEL_HISTORYVIEW = "HistoryView";

		private const string LABEL_TEMPLATEFOOTERDESC = "TemplateFooterDesc";

		private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

		private const string LABEL_DROPAREA = "DropArea";

		private const string LABEL_DRAGCARD = "DragCard";

		private const string LABEL_RT_SELECTEDWINDOW = "CursorWindowSelect";

		private const string LABEL_RT_FOOTER = "Footer";

		public const string SG_DeckList = "DeckListGroup";

		public const string SG_Collection = "CardCollectionGroup";

		public const string SG_History = "CardHistoryGroup";

		public const string SG_CardActionMenu = "CardActionMenu";

		public const string SG_FilterDialog = "FilterDialog";

		public const string SG_CraftDialog = "CraftDialog";

		private const string LABEL_SBN_DISPLAYMODE = "ButtonInfoSwitching";

		private const string LABEL_RT_DISPLAYMODE0 = "ButtonInfoSwitching/IconInfoSwitching0";

		private const string LABEL_RT_DISPLAYMODE1 = "ButtonInfoSwitching/IconInfoSwitching1";

		private const string LABEL_RT_DISPLAYMODE2 = "ButtonInfoSwitching/IconInfoSwitching2";

		private const string LABEL_SBN_REGUBUTTON = "ButtonRegulation";

		private const string LABEL_IMG_REGU = "ButtonRegulation/Logo";

		private const string LABEL_SBN_SAVEBUTTON = "ButtonSave";

		private const string LABEL_SBN_MENUBUTTON = "ButtonMenu";

		private const string LABEL_SBN_CANCELBUTTON = "ButtonCancel";

		private const string LABEL_SBN_BACKBUTTON = "Back";

		private const string LABEL_TXT_NUMCPN = "NumTextCPN";

		private const string LABEL_TXT_NUMCPR = "NumTextCPR";

		private const string LABEL_TXT_NUMCPSR = "NumTextCPSR";

		private const string LABEL_TXT_NUMCPUR = "NumTextCPUR";

		private const string LABEL_SBN_SECRETPACK = "ButtonSecretPack";

		private const string LABEL_SBN_REGLATION = "ButtonReglation";

		private const string LABEL_TXT_NUMSECRETPACK = "NumBadgeText";

		private const string LABEL_BADGE_SECRETPACK = "NumBadge";

		private const string Label_BGM = "BGM_MENU_02";

		private ElementObjectManager m_HeaderEom;

		private ElementObjectManager m_OverHeaderEom;

		private ElementObjectManager m_DeckViewEom;

		private ElementObjectManager m_CardActionMenuEom;

		private ElementObjectManager m_DetailViewEom;

		private ElementObjectManager m_CollectionViewEom;

		private CraftEffect craftEffect;

		private bool fromDeckSelect;

		private Action<int, List<int>> shopTransitionCallback;

		private SelectionButton m_DisplayModeButton;

		private RectTransform m_DisplayMode0;

		private RectTransform m_DisplayMode1;

		private RectTransform m_DisplayMode2;

		private SelectionButton m_RegulationButton;

		private Image m_RegulationImage;

		private SelectionButton m_SaveButton;

		private SelectionButton m_MenuButton;

		private SelectionButton m_CancelButton;

		private SelectionButton m_BackButton;

		private SelectionButton m_SecretPackButton;

		private GameObject m_BadgeSecretPack;

		private ExtendedTextMeshProUGUI m_NumSecretPackText;

		private ExtendedTextMeshProUGUI m_NumCPN;

		private ExtendedTextMeshProUGUI m_NumCPR;

		private ExtendedTextMeshProUGUI m_NumCPSR;

		private ExtendedTextMeshProUGUI m_NumCPUR;

		private ElementObjectManager m_templateFooterDesc;

		private RectTransform m_Footer;

		private AnalogDirectionListener m_AnalogManager;

		private DeckView m_DeckView;

		private CardActionMenu m_CardActionMenu;

		private CardCollectionView m_CollectionView;

		private CardDetailView m_DetailView;

		private bool isCardActionMenuOpen;

		private List<CardBaseData> m_MainDeckCards;

		private List<CardBaseData> m_ExtraDeckCards;

		private List<CardBaseData> m_BookmarkedCards;

		private List<CardBaseData> m_HistoryCards;

		private List<CardBaseData> m_DismanlteCards;

		[SerializeField]
		private TransitionCard prefabTransitionCard;

		private DeckEditFooter m_DeckEditFooter;

		private const string LABEL_DropArea_Collection = "CardCollection";

		private const string LABEL_DropArea_Deck = "DeckList";

		private Dictionary<string, UnityAction> dropAreaActions;

		private Dictionary<string, DropArea> dropAreas;

		private Camera m_Camera;

		private SearchFilter.Setting m_FilterSettings;

		private const string FilterOptionsFileName = "FilterOptions";

		private string m_SearchKeyword;

		private SortComparer.Sorter m_Sorter;

		private float holdTime;

		private SecretPackEffect secretPackEffect;

		private int relatedCardID;

		private ViewType currentView;

		private SelectedCardType footerSelectingCard;

		private bool option1Activate;

		private bool option2Activate;

		private bool option1ActivateChecker;

		private bool option2ActivateChecker;

		private bool mainViewActivated;

		[SerializeField]
		private KeyConfigContainer keyConfig;

		[SerializeField]
		private BezierMotionContainer bezierCraftCreate;

		[SerializeField]
		private BezierMotionContainer bezierCraftDismantle;

		private const int MAX_BOOKMARK_CARDNUM = 100;

		private const int MAX_HISTORY_CARDNUM = 30;

		private bool horizontalSwipe;

		private Vector2 pressedPoint;

		private Dictionary<int, CardCollectionInfo.SecretPackInfo> secretPacks;

		private const int MULTIDISMANTLEMAX = 60;

		private bool requestUpdateView;

		private DisplayMode m_DisplayMode
		{
			[CompilerGenerated]
			get
			{
				return default(DisplayMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private EditMode m_EditMode
		{
			[CompilerGenerated]
			get
			{
				return default(EditMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private int m_OldRegulationID
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

		private DragCard dragCard => null;

		private List<CardBaseData> m_CardCollection
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

		private List<CardBaseData> m_CardListBuff
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

		private List<CardBaseData> m_RelatedCardList
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

		public int m_DeckID
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

		public string m_DeckName
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

		public string m_EventDeckName
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

		public string m_OldDeckName
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

		private bool showAllCards
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool m_IsCopyDeckEdit
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

		private bool isMobile => false;

		private void InitializeElements()
		{
		}

		public bool IsImplemented(int cardId)
		{
			return false;
		}

		public override void NotificationStackEntry()
		{
		}

		private void InitializeView()
		{
		}

		private void SetShortcutSettings()
		{
		}

		private void InitDeckList()
		{
		}

		private void InitRentalCards()
		{
		}

		private void OnDisable()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		private void MainViewActivated()
		{
		}

		private void MainViewDeactivated()
		{
		}

		private void Start()
		{
		}

		private void SortDeckViewCards()
		{
		}

		public void InitializeCardCollectionView()
		{
		}

		private void LateUpdate()
		{
		}

		public void OnSubmitDeckName(string deckName)
		{
		}

		public void OnResetSearchButton()
		{
		}

		public void OnSubmitSearch(string text)
		{
		}

		public void OnClickFilterButton()
		{
		}

		public void ToggleShowAllCards()
		{
		}

		private List<CardBaseData> getTargetCardCollection()
		{
			return null;
		}

		public void OnClickRelatedCardButton(int cardID)
		{
		}

		private List<CardBaseData> getRelatedCardList(int cardID, bool fullStyle)
		{
			return null;
		}

		private void CloseRelatedCard()
		{
		}

		private bool AddToBookmark(CardBaseData cbd)
		{
			return false;
		}

		private bool RemoveFromBookmark(CardBaseData cbd)
		{
			return false;
		}

		public void AddToCardHistory(int id, int premiumID)
		{
		}

		public void AddToCardHistory(CardBaseData cbd)
		{
		}

		public void OnClickSortButton()
		{
		}

		private bool IsBookmarked(CardBaseData cbd)
		{
			return false;
		}

		private bool IsHistoried(CardBaseData cbd)
		{
			return false;
		}

		private int GetDataIndex(CardBaseData cbd, List<CardBaseData> target)
		{
			return 0;
		}

		private void OpenCPOverDialog()
		{
		}

		public void OnClickMassDismantleButton()
		{
		}

		public Dictionary<int, int> GetLackCards()
		{
			return null;
		}

		private List<CardBaseData> FormatLackCards(Dictionary<int, int> lackCards)
		{
			return null;
		}

		public void OpenMultiCreateCraftDialog()
		{
		}

		public void OnClickMultiDismantleButton()
		{
		}

		public void OpenCardActionMenu(CardBaseData baseData, bool fromDeckList = true, int idx = -1)
		{
		}

		private void CraftCreate(CardBaseData baseData, bool actionMenu)
		{
		}

		private void CraftDismantle(CardBaseData baseData, bool actionMenu)
		{
		}

		public void CloseActionDialog()
		{
		}

		private bool updateInDeckCards(DeckInfo.DeckType type)
		{
			return false;
		}

		private bool NeedSave()
		{
			return false;
		}

		private void initializeDetailView(CardBaseData baseData)
		{
		}

		private void initializeCard(DeckCard card, bool setData, int idx = -1)
		{
		}

		private void initializeCard(CardStrip card, bool historyView)
		{
		}

		private void OnCreateCardInDeck(CardBaseData baseData, int craftNum, bool invokeFromActionMenu)
		{
		}

		private void OnDismantleCardInDeck(CardBaseData baseData, int craftNum, bool invokeFromActionMenu, int compensationId)
		{
		}

		public DeckCard AddToMainOrExtraDeck(CardBase card, Vector3? basePos = null, Vector3? targetPos = null)
		{
			return null;
		}

		public DeckCard AddToMainOrExtraDeck(CardBaseData baseData)
		{
			return null;
		}

		public DeckCard AddForDismantle(CardBase card, Vector3? basePos = null, Vector3? targetPos = null)
		{
			return null;
		}

		public DeckCard AddForDismantle(CardBaseData baseData)
		{
			return null;
		}

		private bool ShowAddableMessage(DeckView.AddableType type)
		{
			return false;
		}

		public void RemoveFromDeck(DeckCard card, bool isDrag = false, Vector3? pos = null)
		{
		}

		public DeckCard RemoveFromDeck(CardBaseData baseData)
		{
			return null;
		}

		public void RemoveFromDismantle(DeckCard card, bool isDrag = false, Vector3? pos = null)
		{
		}

		public DeckCard RemoveFromDismantle(CardBaseData baseData)
		{
			return null;
		}

		private void StartCardTransition(CardBase baseCard, CardBase targetCard, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
		{
		}

		private void StartCardTransition(Vector3 baseCardPosition, CardBase targetCard, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
		{
		}

		private void StartCardTransition(CardBase baseCard, Vector3 targetPosition, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
		{
		}

		private void StartCardTransition(CardBaseData cbd, Vector3 baseCardPosition, Vector3 targetPosition, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
		{
		}

		private void StartCardAddEffect(CardBase targetCard, TransitionCard.Size size)
		{
		}

		public bool BookmarkCard(CardBaseData baseData)
		{
			return false;
		}

		public void OnClickBackButton()
		{
		}

		private void ShowModifiedDialog(SaveDialogType type, Action onAccept, Action onCancel)
		{
		}

		public void OnClickSaveButton()
		{
		}

		private string GetSaveAlertMessage()
		{
			return null;
		}

		private Dictionary<string, object> GetCurrentPickCards()
		{
			return null;
		}

		private void SaveDeck(Action finishedCallback = null, bool blockInput = false)
		{
		}

		private void OpenOutOfTermDialog()
		{
		}

		private void SaveBookmark(Action finishedCallback = null)
		{
		}

		private void ShowMenu()
		{
		}

		private void RefreshRegulation(int regId)
		{
		}

		private void OnClickRegulation()
		{
		}

		private void OnClickSecretPack()
		{
		}

		private void ShowSecretPackActivateEffect()
		{
		}

		private void SetDispSecretPackButton(bool disp)
		{
		}

		private void SetActiveDropAreas(bool b, int cardId = 0)
		{
		}

		private void SetActiveExclusiveDropAreas(bool active, string label = null, int cardId = 0, bool canDrop = true)
		{
		}

		private void onCraftCreateCard(CardBaseData cbd, int craftNum, craftCallBack callback, bool invokeFromActionMenu)
		{
		}

		private string GetCraftCreateResultMessage(CardBaseData cbd, int numNormal, int numShine, int numRoyal)
		{
			return null;
		}

		private void UpdatePremNum(CardBaseData cbd, int premID)
		{
		}

		private void onCraftDismantleCard(CardBaseData cbd, int craftNum, craftCallBack callback, bool invokeFromActionMenu, int compensationId)
		{
		}

		private void UpdateCardBaseData(List<CardBaseData> list, int cardID, int premiumID)
		{
		}

		private void StartCreateEffect(RectTransform targetCard, RectTransform targetPoint, bool invokeFromActionMenu)
		{
		}

		private void StartDismantleEffect(RectTransform targetCard, RectTransform targetPoint, bool invokeFromActionMenu)
		{
		}

		private RectTransform GetHeaderCraftPointRectTransform(int rarityID)
		{
			return null;
		}

		private void saveFilterOptions()
		{
		}

		private void loadFilterOptions()
		{
		}

		private void SetDisplayMode(DisplayMode displayMode, bool updateView)
		{
		}

		private void toggleDisplayMode()
		{
		}

		private int getRemainPremiumCard(int id, CardCollectionInfo.Premium prem)
		{
			return 0;
		}

		private void toggleSelectedWindow(ViewType viewType, SelectedCardType selectingCard)
		{
		}

		private void UpdateSelectedWindow()
		{
		}

		private void SetupFooter()
		{
		}

		private void ClearFooterDescription()
		{
		}

		private void ShowFooterDescription(ViewType viewType, SelectedCardType selectingCard)
		{
		}

		private Task AsyncFilterAndSort(Action onFinish, bool setAll = true, SortComparer.Sorter? targetSorter = null, bool filter = true)
		{
			return null;
		}

		public void UpdateCraftPointNum(int rarityID)
		{
		}

		public void UpdateCraftPointNum()
		{
		}

		public void ToggleDismantleMode(bool b)
		{
		}

		public void CancelDismantleModeCheck()
		{
		}

		public IEnumerator InitialSetMainDeck()
		{
			return null;
		}

		public IEnumerator InitialSetExtraDeck()
		{
			return null;
		}

		public bool CheckStyleFilling()
		{
			return false;
		}

		private bool CheckStyleFilling(CardBaseData cbd)
		{
			return false;
		}

		public int GetNumInDeck(int cardID, int premiumID)
		{
			return 0;
		}

		public IEnumerator InitialSetDeck(Action onFinish)
		{
			return null;
		}

		private void OpenStyleFillingDialog()
		{
		}

		private bool CheckReglationExistence()
		{
			return false;
		}

		private void OpenReglationFillingDialog(Action onFinish = null)
		{
		}

		private void OpenRoomRegulationCheck(Action onFinish = null)
		{
		}

		public void OnClickLootSourceButton(CardBaseData data)
		{
		}

		private Dictionary<string, object> GetRepCards()
		{
			return null;
		}

		private Dictionary<string, object> CheckRepCards()
		{
			return null;
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		private void CheckFirstVisitRentalCard()
		{
		}
	}
}
