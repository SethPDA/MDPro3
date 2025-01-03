using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.ActionSheet;
using YgomGame.Card;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.DeckBrowser
{
	public class DeckBrowserViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IBokeSupported
	{
		private enum BrowserType
		{
			Solo = 0,
			SoloNPC = 1,
			StructureShop = 2,
			StructureCopy = 3,
			StructureFirst = 4,
			PublicDeck = 5,
			NeuronMyDeck = 6,
			Confirm = 7,
			ConfirmEvent = 8,
			Select = 9,
			SelectRental = 10,
			PickUpSelection = 11,
			OpponentDeck = 12,
			TrialDraw = 13,
			SelectWCSFinal = 14
		}

		private class DeckBrowserInfo
		{
			public string deckName;

			public Dictionary<string, object> mainCards;

			public Dictionary<string, object> extraCards;

			public Dictionary<string, object> accessory;

			public Dictionary<string, object> pickCards;

			public int box => 0;

			public static DeckBrowserInfo GetInfo(DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, Dictionary<string, object> args)
			{
				return null;
			}
		}

		private const string k_ArgKeyName = "name";

		private const string k_ArgKeyMainCards = "mcards";

		private const string k_ArgKeyExtraCards = "ecards";

		public const string k_ArgKeyRegulationVisible = "regulationVisible";

		public const string k_ArgKeyRarityVisible = "rarityVisible";

		public const string k_ArgKeyMonochromeEnable = "regulationMonochromeEnable";

		public const string k_ArgKeyPremiumCheckEnable = "premiumCheckEnable";

		public const string k_ArgKeyOnStackEntryCallback = "onStackEntryCallback";

		public const string k_ArgKeyShortcutSettings = "shortcutSettings";

		public const string k_ArgKeyAccessories = "accessories";

		public const string k_ArgKeyPickCards = "pickCards";

		public const string k_ArgKeyNumMainCards = "numMainCards";

		public const string k_ArgKeyNumExtraCards = "numExtraCards";

		public const string k_ArgKeyIconDeckId = "iconDeckId";

		public const string k_ArgKeyPopViewEvent = "popViewEvent";

		public const string k_ArgKeyOnClickCopyCallback = "onClickCopyCallback";

		public const string k_ArgKeyOnClickSelectCallback = "onClickSelectCallback";

		public const string k_ArgKeyOnCompleteSelectDeckCallback = "onCompleteSelectDeckCallback";

		public const string k_ArgKeySortEnable = "sortEnable";

		public const string k_ArgKeyDeckNameInit = "deckNameInit";

		public const string k_ArgKeyRegulation = "regulationId";

		public const string k_ArgKeyOpenAsDialog = "openAsDialog";

		public const string k_ArgKeyRarityToggleEnable = "rarityToggleEnable";

		public const string k_ArgKeyRentalCardPool = "rentalCardPool";

		public const string k_ArgKeyEventDeckID = "EventDeckID";

		public const string k_ArgKeyNeuronMyDeck = "NeuronMyDeck";

		private readonly string k_ELabelTitle;

		private readonly string k_ELabelDeckView;

		private readonly string k_ELabelDetailView;

		private readonly string k_ELabelDetailViewMenuRoot;

		private readonly string k_ELabelOptionalAreaLocator;

		private readonly string k_ELabelIconDeck;

		private readonly string k_ELabelNoItemButton;

		private const string k_ELabelGroupCardNum = "GroupCardNum";

		private const string k_ELabelTextCardNum = "TextCardNum";

		private const string k_ELabelDialogBG = "DialogBG";

		private const string k_ELabelDialogCloseButton = "DialogCloseButton";

		private const string k_ELabelRarityToggleButton = "RarityToggleButton";

		private const string k_ELabelRegulationIcon = "RegulationIcon";

		private const string k_ELabelMobileLoadingIcon = "Loading";

		private const string k_ELabelMobileScroll = "Scroll";

		private GameObject m_MobileLoading;

		private GameObject m_MobileScroll;

		public const string COPY_ENABLE = "copyEnable";

		public const string DELETE_ENABLE = "deleteEnable";

		public const string REGULATION_ENABLE = "regulationEnable";

		public const string REGULATION_ICON_ENABLE = "regulationIconEnable";

		public const string TRIAL_DRAW_ENABLE = "trialDrawEnable";

		public const string HAS_CARD_ENABLE = "hasCardEnable";

		public const string HAS_CARD_IS_ON = "hasCardIsOn";

		public const string FOOTER_MENU_ENABLE = "FooterMenuEnable";

		[SerializeField]
		private ElementObjectManager m_UIPrefab;

		[SerializeField]
		private ElementObjectManager m_UIPrefabMobile;

		private ElementObjectManager m_UI;

		private TextMeshProUGUI m_TitleText;

		private DeckViewWidget m_DeckViewWidget;

		private CardDetailWidget m_DetailWidget;

		private GameObject m_NoItemButton;

		private GameObject m_ScrollBlocker;

		private string m_DeckName;

		private ElementObjectManager m_DeckViewEom;

		private DeckView m_DeckView;

		private TMP_Text m_DeckNameText;

		private const int MAX_COL = 8;

		private int m_Regulation;

		private int m_RentalPool;

		private RegulationSelectSheet m_RegulationSelectSheet;

		private bool m_MonochromeEnable;

		private bool m_PremiumCheckEnable;

		private bool m_RegulationVisible;

		private bool m_RarityVisible;

		private bool m_SortEnable;

		private ShortcutKeySetter m_ShortCutSettings;

		private Dictionary<string, object> m_Accessories;

		private Dictionary<string, object> m_PickCards;

		private int m_NumMainCards;

		private int m_NumExtraCards;

		private int m_NumMainCol;

		private int m_UnimplementedMainNum;

		private bool m_IsContainsUnimplemented;

		private List<bool> m_InitCursorFlags;

		private List<object> m_DeckCardMrks;

		private List<object> m_DeckCardPremiums;

		private List<object> m_MainCardMrks;

		private List<object> m_MainCardPremiums;

		private List<bool> m_MonochromeList;

		private List<CardBaseData> m_MainCardBaseData;

		private List<CardBaseData> m_ExtraCardBaseData;

		public SelectionItem m_ExDeckSelector;

		[NonSerialized]
		public GameObject optionalEmbedObj;

		public Transform optionalAreaLocator;

		[SerializeField]
		private SpriteContainer m_IconCardDB;

		private readonly string k_LabelIconJp;

		private readonly string k_LabelIconUniversal;

		private readonly string k_LabelIconKo;

		[SerializeField]
		private SpriteContainer m_ButtonLSprite;

		private readonly string k_LabelButtonSpriteL;

		private readonly string k_LabelButtonSpriteMobileL;

		private readonly string k_LabelButtonSpriteL_Over;

		private readonly string k_LabelButtonSpriteMobileL_Over;

		private DeckSelectViewController2.DeckEventType m_CopyType;

		private const string k_ELabelCopyType = "copyType";

		private GameObject m_UnCraftableIcon;

		private Content cci;

		private bool m_IsDialog;

		private GameObject m_DialogBG;

		private SelectionButton m_DialogCloseButton;

		private Image m_RegulationIcon;

		private SelectionButton m_RarityToggleButton;

		private GameObject m_RarityToggleOn;

		private GameObject m_RarityToggleOff;

		private BrowserType m_BrowserType;

		public Action onPopViewCallback;

		public Action onInitializePickupCardCallback;

		public Action onInitializeTrialDrawCallback;

		public Action<DeckCard, int> onCreatedCardCallback;

		public Func<string, GameObject> createOptionalEmbedObjFunc;

		public Action onCopySccessedCallback;

		public Action onCompleteSelectDeckCallback;

		public bool monochromeEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool premiumCheckEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isMobile => false;

		public bool isGamePad => false;

		public bool isDialog
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private BrowserType browserType
		{
			get
			{
				return default(BrowserType);
			}
			set
			{
			}
		}

		protected override Type[] textIds => null;

		public static void OpenAsOpponentDeckCheck(string deckName, object mainCards, object extraCards, Dictionary<string, object> args = null)
		{
		}

		public static void OpenAsConfirmation(DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, Dictionary<string, object> args = null)
		{
		}

		public static void OpenAsPickupCardSelection(string name, object mainCards, object extraCards, int id, int eventId, int deckcaseId, ProfileEditViewController.EditType editType, Action<DeckBrowserViewController> onStackEntryCallback = null, Dictionary<string, object> args = null)
		{
		}

		private IEnumerator InitPickupCards()
		{
			return null;
		}

		private void InitPickupCardsMobile(PickupCardSelectionWidget pickupCardSelectionWidget)
		{
		}

		public void SetOnClickDetailViewCard(int cardId, int styleId)
		{
		}

		public static void OpenAsPublicDeck(string name, int pickCardId, object mainCards, object extraCards, object categories, object tags, Transform transform = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenAsSelect(DeckSelectViewController2.SelectMode mode, DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, Dictionary<string, object> args = null)
		{
		}

		private void OnClickSelectButton(DeckSelectViewController2.SelectMode mode, int deckID, int eventID)
		{
		}

		private void DeckSetByGameMode(Util.GameMode gameMode, int deckID)
		{
		}

		private void OpenDeckSelectDialog(DeckSelectViewController2.SelectMode mode)
		{
		}

		private Dictionary<string, object> CopyDeckData()
		{
			return null;
		}

		private void SelectDeck(DeckSelectViewController2.SelectMode mode, int deckID, int eventID)
		{
		}

		private void OpenOutOfTermDialog()
		{
		}

		public static void OpenAsSolo(int chapterId, SoloDeckUtil.SoloDeckType soloDeckType, Dictionary<string, object> args = null)
		{
		}

		private static void OpenStructure(int structureId, Action<DeckBrowserViewController> onStackCallback, Dictionary<string, object> args)
		{
		}

		public static void OpenAsStructure(int structureId, Dictionary<string, object> args = null)
		{
		}

		public static void OpenAsFirstStructure(int structureId, Dictionary<string, object> args = null)
		{
		}

		public static void OpenAsStructureDeckCopy(int structureId, Dictionary<string, object> args = null)
		{
		}

		private static void GetFirstStructure(int structureId, DeckBrowserViewController vc, Action completeCallback)
		{
		}

		private static Dictionary<string, object> GetPickupCardsByStructureMaster(object structureMaster)
		{
			return null;
		}

		public static void OpenAsTrialDraw(string deckName, object mainCards, object extraCards, Dictionary<string, object> args = null)
		{
		}

		public static void OpenAsTrialDraw(DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, Dictionary<string, object> args = null)
		{
		}

		public static void OpenTrialDrawView(string name, List<CardBaseData> main, List<CardBaseData> extra)
		{
		}

		private void OpenTrialDrawView()
		{
		}

		private void DispLoadingMobile(bool isLoading)
		{
		}

		public static void Open(string name, object mainCards, object extraCards, Dictionary<string, object> args = null)
		{
		}

		private static List<CardBaseData> GetRentalCards(int rentalPoolID)
		{
			return null;
		}

		private static Dictionary<string, object> ConvertCBDtoDict(List<CardBaseData> cbd)
		{
			return null;
		}

		private static Dictionary<string, object> ConvertPickupCardsListToDict(List<object> ids, List<object> r)
		{
			return null;
		}

		private void InitializeView()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private string GetTitle()
		{
			return null;
		}

		private void Start()
		{
		}

		private IEnumerator InitDeckCards(List<object> mainCardMrks, List<object> mainCardPremiums, List<object> extraCardMrks, List<object> extraCardPremiums, Action onFinish)
		{
			return null;
		}

		private IEnumerator InitDeckCardsMobile(List<object> mainCardMrks, List<object> mainCardPremiums, List<object> extraCardMrks, List<object> extraCardPremiums, Action onFinish)
		{
			return null;
		}

		private void OnCreatedCardCallbackDefault(DeckCard deckCard, int idx)
		{
		}

		private void SetRegulation(int eventID, int deckId, DeckSelectViewController2.DeckEventType regType = DeckSelectViewController2.DeckEventType.ExhibitionDeck)
		{
		}

		private void SetRegulation(int eventID, DeckSelectViewController2.SelectMode mode = DeckSelectViewController2.SelectMode.Exhibition)
		{
		}

		private void SetRegulation(int regulationId)
		{
		}

		public void SetDetailViewCard(CardBaseData cbd)
		{
		}

		public void SetDetailViewCard(int mrk, int premiumId, bool isRental = false)
		{
		}

		public void SetOnClickDetailViewCard(int idx)
		{
		}

		public void RefreshRegulation()
		{
		}

		private void RefreshRegulationIcon()
		{
		}

		public void RefreshRarity()
		{
		}

		private void ApplyHasCardDisplay()
		{
		}

		private void InitMonochromeList()
		{
		}

		private int InitNumMainCol(int numMain)
		{
			return 0;
		}

		private bool IsBottomMainCard(int index)
		{
			return false;
		}

		private void SetMainBottomKeyDownCallback(int mainIndex)
		{
		}

		private IEnumerator DelayedInvokeCallback(Action action)
		{
			return null;
		}

		private bool RegulationCheck()
		{
			return false;
		}

		private bool PossetionCheck(bool distinctPrem)
		{
			return false;
		}

		private void InitCommonSettings(DeckBrowserOptionWidget optionWidget, Dictionary<string, object> args = null)
		{
		}

		private void InitEnableDeckBrowserOptions(DeckBrowserOptionWidget optionWidget, Dictionary<string, object> args = null)
		{
		}

		private void InitDeckBrowserCallBacks(DeckBrowserOptionWidget optionWidget, Dictionary<string, object> args = null)
		{
		}

		private void OnClickCopyButton()
		{
		}

		private void SaveDeck()
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
