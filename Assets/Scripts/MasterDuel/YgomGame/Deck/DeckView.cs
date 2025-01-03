using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.TextIDs;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class DeckView : MonoBehaviour
	{
		private class HeaderArea : MonoBehaviour
		{
			private ElementObjectManager m_Eom;

			private bool isInitialized;

			public bool isIni => false;

			public InputFieldWidget m_DeckNameInput
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

			public Image m_DeckIcon
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

			public ExtendedTextMeshProUGUI m_EventDeckName
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

			public ExtendedTextMeshProUGUI m_DismantleBatchCount
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

			public SelectionButton m_DismantleBatchButton
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

			public ExtendedTextMeshProUGUI m_DismantleCardTitle
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

			public SelectionButton m_DismantleResetButton
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

			public DeviceIcon m_DismantleBatchButtonShortcutIcon
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

			public UnityAction<string> onSubmitDeckNameAction
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

			public UnityAction onClickMultiDismantle
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

			public UnityAction onSelectMultiDismantle
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

			public UnityAction<SelectionItem> onInputRightMultiDismantle
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

			public UnityAction<SelectionItem> onInputDownMultiDismantle
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

			private void Awake()
			{
			}

			public void InitializeElements()
			{
			}

			private void InitilaizeDeckNameElements()
			{
			}

			public void SetDeckName(string str)
			{
			}

			public void SetEventDeckName(string str)
			{
			}

			public void SetDeckCaseIcon(int deckcaseId)
			{
			}

			private void InitializeDismantleElements()
			{
			}

			public void SetDismantleCount(int count)
			{
			}

			public void SetActiveDismantleButton(bool active)
			{
			}

			public void SetDismantleMode(bool isDismantleMode)
			{
			}
		}

		public enum AddableType
		{
			Addable = 0,
			OverCapacity = 1,
			OverCardNum = 2,
			OverLimit0 = 3,
			OverLimit1 = 4,
			OverLimit2 = 5
		}

		private class DeckContentWidget
		{
			public enum Type
			{
				Header = 0,
				CardGroup = 1
			}

			public enum DeckType
			{
				Main = 0,
				Extra = 1,
				Dismantle = 2
			}

			private class DeckContent
			{
				public Type type;

				public DeckType deckType;

				public string headerTitle;

				public static DeckContent CreateHeader(DeckType deckType, IDS_DECKEDIT title)
				{
					return null;
				}

				public static DeckContent CreateCardGroup(DeckType deckType)
				{
					return null;
				}

				public bool CheckType(DeckType deckType, Type type)
				{
					return false;
				}

				public int GetTemplateIndex()
				{
					return 0;
				}
			}

			private List<DeckContent> deckContents;

			public List<int> templateIndexer
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

			public int GetCardGroupHeadIndex(DeckType deckType)
			{
				return 0;
			}

			public int GetCardGroupTailIndex(DeckType deckType)
			{
				return 0;
			}

			public void AddCardGroup(DeckType deckType)
			{
			}

			public void AddCardGroup(DeckType deckType, int index)
			{
			}

			public void AddHeader(DeckType deckType, IDS_DECKEDIT title, int index)
			{
			}

			public void RemoveHeader(DeckType deckType)
			{
			}

			private void AddDeckContent(DeckContent deckContent, int index)
			{
			}

			public void RemoveCardGroup(DeckType deckType)
			{
			}

			public int GetMaxCardNum(DeckType deckType)
			{
				return 0;
			}

			public int GetContentNum()
			{
				return 0;
			}

			public (int, int) GetDisplayCardIndex(int index)
			{
				return default((int, int));
			}

			public Type GetContentType(int index)
			{
				return default(Type);
			}

			public DeckType GetContentDeckType(int index)
			{
				return default(DeckType);
			}

			public string GetHeaderTitle(int index)
			{
				return null;
			}

			public void ClearContent()
			{
			}
		}

		private float removedWait;

		private ElementObjectManager m_Eom;

		private const string k_ELabelHeaderArea = "HeaderArea";

		private HeaderArea m_HeaderArea;

		private ElementObjectManager m_MainDeckEom;

		private ElementObjectManager m_ExtraDeckEom;

		private RectTransform m_SelectedWindowCursor;

		private const string k_ELabelMobileScroll = "Scroll";

		private bool isScrollReady;

		private const string k_ELabelDeckNumCounter = "DeckNumCounter";

		private List<DeckCard> mainDeckCards;

		private List<DeckCard> extraDeckCards;

		private List<DeckCard> dismantlePoolCards;

		private const int MAX_CARDS_MAIN = 65;

		private const int THRESHOLD_CARDS_MAIN = 50;

		private const int DEFAULT_ROWS_MAIN = 5;

		private const int DEFAULT_COLUMNS_MAIN = 10;

		private const int MIN_COLUMNS_MAIN = 15;

		private const int MAX_COLUMNS_MAIN = 15;

		private const int MAX_CARDS_EX = 20;

		private const int THRESHOLD_CARDS_EX = 20;

		private const int DEFAULT_ROWS_EX = 2;

		private const int DEFAULT_COLUMNS_EX = 10;

		private const int MIN_COLUMNS_EX = 20;

		private const int MAX_COLUMNS_EX = 15;

		private const int MAX_CARDS_DISMANTLE_POOL = 60;

		private const int MAX_CARDS_DECKCONTENT_CARDGROUP = 5;

		public static int m_MaxCol;

		private bool m_RegulationVisible;

		private int m_RegulationID;

		private int m_RentalCardID;

		private bool m_RarityVisble;

		private bool m_MonochromeEnable;

		private bool m_PremiumCheckEnable;

		private Vector2Int AspectRatioMainDeck;

		private Vector2Int AspectRatioExDeck;

		private DeckCard template_DeckCard;

		private SortComparer.Sorter deckSorter;

		private DeckCard currentCard;

		private DeckContentWidget deckContents;

		public List<CardBaseData> mainCardDataList;

		public List<CardBaseData> extraCardDataList;

		private int currentSelectIndex;

		private DeckEditViewController2.DisplayMode displayMode;

		private EntityPoolController entityPoolController;

		private List<CardBaseData> dismantlePoolDataList;

		private SortComparer.Sorter dismantlePoolSorter;

		public bool isMobileLayout
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

		public bool isLoading
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

		public bool isDismantleBatchMode
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

		public bool isSelected
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

		private RectTransform m_MainDeckContent
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

		private ExtendedTextMeshProUGUI m_MainDeckCardSumText
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

		private RectTransform m_ExtraDeckContent
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

		private ExtendedTextMeshProUGUI m_ExtraDeckCardSumText
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

		private ElementObjectManager m_DismantleBatchEom
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

		private RectTransform m_DismantleBatchContent
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

		private ElementObjectManager m_ScrollEom
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

		private ExtendedScrollRect m_Scroll
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

		private InfinityScrollView m_InfinityScroll
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

		public RectTransform m_ScrollContent
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

		private ElementObjectManager m_DeckNumCounterEom
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

		private TMP_Text m_DeckNumCounterTextMain
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

		private TMP_Text m_DeckNumCounterTextExtra
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

		private GameObject m_ScrollBlocker
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

		private SelectionButton m_NoItemButton
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

		private ExtendedTextMeshProUGUI m_NoItemButtonText
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

		private RectTransform m_Loading
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

		private RectTransform m_Viewport
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

		public DropArea m_DropArea
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

		private RectTransform m_DropAreaOver
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

		private static Content m_cci => null;

		public bool isPremiumCheckEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Action<DeckCard, bool, int> onCreateDeckCardIdx
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

		public Action<DeckCard, bool> onCreateDeckCard
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

		public Action<DeckCard, int> onCreateDeckCard2
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

		public Action onNoItemButtonSelectedCallback
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

		public Action onNoItemButtonInputCallback
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

		public List<CardBaseData> dismantleList => null;

		public void SetDeckName(string s)
		{
		}

		public void SetEventDeckName(string s)
		{
		}

		public void ActivateEventDeckName(bool isActive)
		{
		}

		public void SetOnSubmitDeckName(UnityAction<string> callback)
		{
		}

		public void ActivateDeckNameInput()
		{
		}

		public void SetDeckCaseIcon(int deckcaseId)
		{
		}

		public void SetDeckNameButtonActive(bool b)
		{
		}

		public void SetDismantlePoolCount()
		{
		}

		public void SetActiveMultiDismantleButton(bool active)
		{
		}

		public void SetCurrentView(bool current)
		{
		}

		public void SetOnClickMultiDismantleButton(UnityAction callback)
		{
		}

		public void SetOnSelectMultiDismantleButton(UnityAction callback)
		{
		}

		public void SetOnInputRightMultiDismantleButton(UnityAction<SelectionItem> callback)
		{
		}

		private void sortMainDeckCards()
		{
		}

		private void sortExtraDeckCards()
		{
		}

		private void sortDismantlePoolCards()
		{
		}

		private void SortbyLoc(DeckCard.LocationInDeck loc)
		{
		}

		public void SortInDeckCards()
		{
		}

		public void SortInDeckCards(SortComparer.Sorter sorter)
		{
		}

		public void InitializeDeckContents()
		{
		}

		private void Awake()
		{
		}

		private void InitMobileLayout()
		{
		}

		private void InitilaizeConsoleElements()
		{
		}

		private void Start()
		{
		}

		private DeckCard InstantiateDeckCard(CardBaseData data, RectTransform parent, int regID, DeckEditViewController2.DisplayMode mode = DeckEditViewController2.DisplayMode.Simple)
		{
			return null;
		}

		private float calculateSpacing(float length, float width, float columns)
		{
			return 0f;
		}

		private int getSizeOfColumn(Vector2 aspect, int num, int minSum)
		{
			return 0;
		}

		public int GetCurrentColumnNum(DeckCard.LocationInDeck loc)
		{
			return 0;
		}

		private int GetIndexInDeck(DeckCard card, DeckCard.LocationInDeck loc)
		{
			return 0;
		}

		public int GetIndexInDeck(DeckCard card)
		{
			return 0;
		}

		public bool IsLeftmostCard(DeckCard card, DeckCard.LocationInDeck loc)
		{
			return false;
		}

		public bool IsRightmostCard(DeckCard card, DeckCard.LocationInDeck loc)
		{
			return false;
		}

		public bool IsBottommostCard(DeckCard card, DeckCard.LocationInDeck loc)
		{
			return false;
		}

		public bool IsTopmostCard(DeckCard card, DeckCard.LocationInDeck loc)
		{
			return false;
		}

		private DeckCard GetCardAt(int index, DeckCard.LocationInDeck loc)
		{
			return null;
		}

		public int GetCardNum(DeckCard.LocationInDeck loc)
		{
			return 0;
		}

		public int GetCardSumInDeck(int cardID)
		{
			return 0;
		}

		private void setMainDeckGridSpacing()
		{
		}

		private void setExtraDeckGridSpacing()
		{
		}

		private void setCardSum(DeckCard.LocationInDeck loc)
		{
		}

		public void SetInDeckCardSum()
		{
		}

		public AddableType GetAddableType(int cardID, int regulation)
		{
			return default(AddableType);
		}

		public bool IsAddable(int cardID, int regulation)
		{
			return false;
		}

		public bool CheckNumLimit(int regulation)
		{
			return false;
		}

		public DeckCard AddToDeck(int id, int prem = 1, bool owned = true, bool isRental = false, int reg = -1, bool sort = true, bool isIni = false, DeckCard.LocationInDeck location = DeckCard.LocationInDeck.NA, bool noAdd = false)
		{
			return null;
		}

		public bool IsRemovable(int id, int premiumID)
		{
			return false;
		}

		public void UpdateDeckNumCounter()
		{
		}

		private List<DeckCard> getTargetCardsInDeck(int cardID)
		{
			return null;
		}

		private List<DeckCard> getTargetCardsInDeck(int cardID, int premiumID, bool isRental = false)
		{
			return null;
		}

		private List<DeckCard> getTargetCardsInDismantlePool(CardBaseData data)
		{
			return null;
		}

		public void SetDispNoItemButton(bool disp)
		{
		}

		private bool isMainDeckFull()
		{
			return false;
		}

		private bool isExtraDeckFull()
		{
			return false;
		}

		public (CardCollectionInfo.Premium, bool, bool) GetLowPremiumInDeck(int cardID)
		{
			return default((CardCollectionInfo.Premium, bool, bool));
		}

		public List<CardBaseData> GetInDeckCards(DeckInfo.DeckType type)
		{
			return null;
		}

		public int GetCardTotalInDeck(DeckInfo.DeckType type)
		{
			return 0;
		}

		public List<CardBaseData> GetInDeckAll()
		{
			return null;
		}

		public List<DeckCard> GetDeckCards()
		{
			return null;
		}

		public int GetPremiumCardSumInDeck(int id, CardCollectionInfo.Premium premiumID, bool isRental = false)
		{
			return 0;
		}

		public InDeckNumInfo GetInDeckInfo(int cardID)
		{
			return null;
		}

		public int GetAlterCardSumInDeck(int id, CardCollectionInfo.Premium premiumID, bool isRental = false)
		{
			return 0;
		}

		public int GetPremiumCardSumInDismantlePool(CardBaseData data)
		{
			return 0;
		}

		public bool IsContainsUncraftedCard()
		{
			return false;
		}

		public void UpdateIsOwned(bool styleFilling = true)
		{
		}

		public void UpdateIsOwned(int cardID, bool isRental, bool styleFilling = true)
		{
		}

		private CardBaseData UpdateIsOwned(CardBaseData baseData, ref int numN, ref int numP1, ref int numP2, bool styleFilling = true)
		{
			return default(CardBaseData);
		}

		public bool IsModified(List<CardBaseData> oldMainCards, List<CardBaseData> oldExtraCards)
		{
			return false;
		}

		public void SetRegulation(int regulationID)
		{
		}

		public void SetRentalID(int rentalID)
		{
		}

		public void UpdateRegulation(int regulationID)
		{
		}

		public void UpdateDisplayMode(DeckEditViewController2.DisplayMode mode, bool updateScroll = true)
		{
		}

		public void UpdateDisplayModeForDeckBrowser(bool regulationVisible, int regulationID, bool rarityVisble, bool hasCard)
		{
		}

		private void UpdateDeckCard(DeckCard deckCard, bool isMonocro)
		{
		}

		public void UpdateView(bool updateDataCount)
		{
		}

		public void StopScroll()
		{
		}

		private DeckCard GetHeadDeckCard(DeckCard.LocationInDeck loc)
		{
			return null;
		}

		public SelectionItem GetDefaultFocusItem()
		{
			return null;
		}

		public void SelectDefaultFocusedItem()
		{
		}

		public void SetCurrentCard(DeckCard card)
		{
		}

		public void CursorJumpUp()
		{
		}

		public void CursorJumpDown()
		{
		}

		public void CursorJumpLeft()
		{
		}

		public void CursorJumpRight()
		{
		}

		public bool IsTailCard(DeckCard card, DeckCard.LocationInDeck location)
		{
			return false;
		}

		public void SelectRightEdgeClosestItem(Vector2 screenPoint, float angleDot)
		{
		}

		private List<DeckCard> GetRightEdgeCards(List<DeckCard> cardList, DeckCard.LocationInDeck loc)
		{
			return null;
		}

		private void SelectTopEdgeItem(Vector2 screenPoint, float angleDot)
		{
		}

		private List<DeckCard> GetTopEdgeCards(List<DeckCard> cardList, DeckCard.LocationInDeck loc)
		{
			return null;
		}

		public void OnCreateEntity(GameObject obj)
		{
		}

		public void OnUpdateEntity(GameObject obj, int idx)
		{
		}

		public void SetActiveScroll(bool condition)
		{
		}

		private IEnumerator waitDecrementDragCounter()
		{
			return null;
		}

		private (int, int) GetIndexMainDeckCard(List<CardBaseData> cardList, int cardID, int premiumID)
		{
			return default((int, int));
		}

		public void SetMaxCol(int col)
		{
		}

		public void SetDispDropAreaOver(bool disp)
		{
		}

		public void InitializeDismantlePool()
		{
		}

		public void SetDismantleMode(bool b)
		{
		}

		public void ShowLoading()
		{
		}

		public void HideLoading()
		{
		}

		public void PostMultiDismantle()
		{
		}

		public void ClearAllCards()
		{
		}

		private List<CardBaseData> GetDataList(DeckCard.LocationInDeck loc)
		{
			return null;
		}

		private DeckContentWidget.DeckType GetDeckType(DeckCard.LocationInDeck loc)
		{
			return default(DeckContentWidget.DeckType);
		}

		private List<DeckCard> GetCards(DeckCard.LocationInDeck loc)
		{
			return null;
		}

		private RectTransform GetContent(DeckCard.LocationInDeck loc)
		{
			return null;
		}

		private DeckCard AddCard(CardBaseData cbd, DeckCard.LocationInDeck loc, int reg, bool sort = true, bool isIni = false, bool noAdd = false)
		{
			return null;
		}

		public DeckCard AddToMainDeckByID(int id, int prem = 1, bool owned = true, bool isRental = false, int reg = -1, bool sort = true, bool isIni = false, bool noAdd = false)
		{
			return null;
		}

		public DeckCard AddToExtraDeckByID(int id, int prem = 1, bool owned = true, bool isRental = false, int reg = -1, bool sort = true, bool isIni = false, bool noAdd = false)
		{
			return null;
		}

		public DeckCard AddToDismantlePool(CardBaseData cbd, int reg = -1, bool sort = true)
		{
			return null;
		}

		private DeckCard RemoveCard(CardBaseData cbd, DeckCard.LocationInDeck loc, bool sort = true)
		{
			return null;
		}

		public void RemoveCardFromMainOrExtra(int id, int premiumID, out DeckCard removedCard)
		{
			removedCard = null;
		}

		public void RemoveFromDismantlePool(CardBaseData cbd, out DeckCard removedCard, bool sort = true)
		{
			removedCard = null;
		}
	}
}
