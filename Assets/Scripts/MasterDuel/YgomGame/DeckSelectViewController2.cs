using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomGame
{
	public class DeckSelectViewController2 : BaseMenuViewController, IDynamicHeaderCustomSupported, IDynamicChangeDispHeaderSupported
	{
		public enum DeckCondition
		{
			New = 0,
			Existing = 1
		}

		public enum SelectMode
		{
			Default = 0,
			Ranked = 1,
			PVE = 2,
			Tournament = 3,
			Solo = 4,
			Room = 5,
			Exhibition = 6,
			Rental = 7,
			Free = 8,
			Cup = 9,
			Wcs = 10,
			WcsFinal = 11,
			RankEvent = 12,
			TeamMatch = 13,
			BulkDecksDeletion = 14,
			DuelTrial = 15,
			DuelTrialRental = 16,
			Versus = 17,
			VersusRental = 18
		}

		public enum DeckEventType
		{
			NewDeck = 0,
			MyDeck = 1,
			Neuron = 2,
			TournamentDeck = 3,
			ExhibitionDeck = 4,
			ExhibitionRentalDeck = 5,
			CupDeck = 6,
			WcsDeck = 7,
			WcsFinalDeck = 8,
			RankEventDeck = 9,
			DuelTrialDeck = 10,
			DuelTrialRentalDeck = 11,
			VersusDeck = 12,
			VersusRentalDeck = 13
		}

		private class TournamentReference
		{
			public int id;

			public int logoId;

			public long end_ts;

			public long res_ts;

			public bool is_fixed_accessory;

			public bool is_fixed_pick_cards;

			public int rentalPoolId;
		}

		private enum ChildMenuAction
		{
			None = 0,
			CreateDeck = 1,
			EditDeck = 2,
			DeckBrowser = 3,
			ModifyDeck = 4,
			RemoveDeck = 5,
			PublicDeckSearch = 6,
			StructureDeckCopy = 7,
			EditCopyDeck = 8,
			CardList = 9,
			NeuronMyDecks = 10,
			BulkDecksDeletion = 11
		}

		protected internal class DeckReference
		{
			public int deckID;

			public string name;

			public DeckEventType deckType;

			public int caseID;

			public int protectorID;

			public int fieldID;

			public int objectID;

			public int mateBaseID;

			public int[] pickUpIDs;

			public int[] pickUpDecos;

			public long et;

			public long ct;

			public long endTime;

			public long resTime;

			public bool isFixedAccessories;

			public bool isFixedPickCards;

			public int logoID;

			public int regID;

			public int stage;

			public int eventID;

			public int rentalPoolID;

			public KeyValuePair<DeckEventType, int> GetUIKey()
			{
				return default(KeyValuePair<DeckEventType, int>);
			}

			public void SetAccessory(Dictionary<string, object> accessory)
			{
			}

			public void SetPickUp(int[] pickId, int[] pickDeco)
			{
			}

			public void SetPickUp(Dictionary<string, object> pickupDict)
			{
			}

			public void SetTimes(long editTime, long createTime)
			{
			}

			public Dictionary<string, object> GetAccessory()
			{
				return null;
			}

			public Dictionary<string, object> GetPickCards()
			{
				return null;
			}
		}

		protected SelectMode m_SelectMode;

		private int m_ExhibitionID;

		private int m_ExhibitionRentalID;

		private int m_CupID;

		private int m_WcsID;

		private int m_WcsFinalID;

		private int m_RankEventID;

		private int m_DuelTrialID;

		private int m_DuelTrialRentalID;

		private int m_VersusID;

		private int m_VersusRentalID;

		private int m_RegulationID;

		private int m_EventDeckID;

		private InfinityScrollView m_ScrollView;

		private readonly string k_ELabelHederAreaMenu;

		private readonly string k_ELabelTextHeadline;

		private readonly string k_ELabelDeckNum;

		private readonly string k_ELabelTextDeckNum;

		private readonly string k_ELabelTounamentDeckNum;

		private readonly string k_ELabelTextTounamentDeckNum;

		private readonly string k_ELabelBulkDecksDeletionButton;

		private readonly string k_ELabelBulkDecksDeletionTmp;

		private readonly string k_ELabelBulkDecksDeletionShortcut;

		private readonly string k_ELabelDeleteExecutionButton;

		private readonly string k_ELabelOpenNeuronDecksButton;

		private readonly string k_ELabelOpenNeuronDecksButtonIcon;

		private readonly string k_LabelJpLogoButton;

		private readonly string k_LabelUniversalLogoButton;

		private readonly string k_LabelKoLogoButton;

		protected Transform m_HeaderArea;

		protected TextMeshProUGUI m_TextHeadline;

		private Transform m_DeckNum;

		private TextMeshProUGUI m_TextDeckNum;

		private Transform m_TounamentDeckNum;

		private TextMeshProUGUI m_TextTounamentDeckNum;

		private bool dispPickCards;

		protected ElementObjectManager m_BulkDecksDeletionEom;

		protected SelectionButton m_BulkDecksDeletionButton;

		private SelectionButton m_DeleteExecutionButton;

		protected TextMeshProUGUI m_BulkDecksDeletionTmp;

		[SerializeField]
		private SpriteContainer m_ButtonIconContainer;

		private Image m_NeuronLogoIconButton;

		private readonly string k_ELabelFooterMenu;

		private readonly string k_ELabelPublicDeckButton;

		private readonly string k_ELabelStructureDeckCopyButton;

		public const string k_ArgKeyGameMode = "GameMode";

		public const string k_ArgKeyExhibitionID = "ExhibitionID";

		public const string k_ArgKeyRentalID = "RentalID";

		public const string k_ArgKeyCupID = "CupID";

		public const string k_ArgKeyWcsID = "WcsID";

		public const string k_ArgKeyWcsFinalID = "WcsFinalID";

		public const string k_ArgKeyRankEventID = "RankEventID";

		public const string k_ArgKeyDuelTrialID = "DuelTrialID";

		public const string k_ArgKeyDuelTrialRentalID = "DuelTrialRentalID";

		public const string k_ArgKeyVersusID = "VersusID";

		public const string k_ArgKeyVersusRentalID = "VersusRentalID";

		public const string k_ArgKeyEventDeckID = "EventDeckID";

		public const string k_ArgKeyRegulationID = "RegulationID";

		private readonly string k_ELabelPickupCardButton;

		protected Transform m_FooterArea;

		private SelectionButton m_PublicDeckButton;

		private SelectionButton m_StructureDeckCopyButton;

		private readonly string k_ELabelNewStructureBadge;

		private GameObject m_StructureBadge;

		private SelectionButton m_OpenNeuronDecksButton;

		private SelectionButton m_PickupCardButton;

		private ElementObjectManager m_PickupCardButtonEom;

		private Transform m_PickupCardButtonOn;

		private Transform m_PickupCardButtonOff;

		public const string PREFAB_PATH_DECKEDIT_VC = "DeckEdit/DeckEdit";

		public const string PREFAB_PATH_CARDDIRECTORY_VC = "DeckEdit/CardDirectory";

		private const string Label_BGM = "BGM_MENU_01";

		private readonly string k_ALabelOverview;

		private ElementObjectManager DeckOverviewPrefab;

		private List<string> m_DeckActionDialogButtonLabels;

		private Dictionary<string, UnityAction> m_DeckActionDialogCallBacks;

		private Dictionary<int, TournamentReference> m_Exhibitions;

		private TournamentReference m_Cup;

		private TournamentReference m_Wcs;

		private Dictionary<int, TournamentReference> m_RankEvents;

		private Dictionary<int, TournamentReference> m_DuelTrials;

		private Dictionary<KeyValuePair<int, int>, TournamentReference> m_VSs;

		protected List<DeckReference> m_Decks;

		private List<int> m_TemplateList;

		protected Dictionary<KeyValuePair<DeckEventType, int>, DeckBox> m_DeckUIs;

		private ChildMenuAction m_currentMenu;

		private bool m_firstFocusPassed;

		private int lastSet;

		private DeckEventType m_backupDeckType;

		private bool m_isLinkageCgdbDeck;

		private const int BulkDecksLimit = 10;

		private List<int> m_SelectedDecks;

		private Dictionary<string, List<Tween>> m_HeaderTweens;

		private Dictionary<string, List<Tween>> m_FooterTweens;

		private readonly string k_LabelHideTween;

		private readonly string k_LabelShowTween;

		protected override Type[] textIds => null;

		protected override int selectorPriorityAddRange => 0;

		private void Start()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public static void Open(Dictionary<string, object> args = null)
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		private void enterChildMenu(ChildMenuAction type)
		{
		}

		private void ReturnFromChildMenu()
		{
		}

		private IEnumerator DelayResetList(int deckId)
		{
			return null;
		}

		private void UpdateStructureBadge()
		{
		}

		private void ResetDeckList(int skipIndex)
		{
		}

		private void UpdateDeckList()
		{
		}

		private void OpenPublicDeckSearch()
		{
		}

		private void GetNeuronToken()
		{
		}

		private void OpenNeuronDeckSearch(bool isFirst = false)
		{
		}

		private void OpenStructureDeckCopy()
		{
		}

		private void CreateNewDeck()
		{
		}

		private void GetDeckList(DeckReference deckRef, Action<DeckReference> onCompleteAction)
		{
		}

		private void OpenOutOfTermDialog()
		{
		}

		private void OpenEditDeck(DeckReference deckRef)
		{
		}

		private void OpenDeckEditView(DeckReference deckRef)
		{
		}

		private void OpenConfirmDeckBrowser(DeckReference deckRef)
		{
		}

		private void OpenConfirmBrowser(DeckReference deckRef)
		{
		}

		private void OpenSelectDeckBrowser(DeckReference deckRef)
		{
		}

		private void OpenSelectBrowser(DeckReference deckRef)
		{
		}

		private void OpenAccessoryEdit(DeckReference deckRef)
		{
		}

		private void InitializeDeckData()
		{
		}

		private void InitializeExhibitionInfo()
		{
		}

		private void InitializeExhibitionDeckData()
		{
		}

		private void InitializeCupInfo()
		{
		}

		private void InitializeCupDeckData()
		{
		}

		private void InitializeWcsInfo()
		{
		}

		private void InitializeWcsDeckData()
		{
		}

		private void InitializeRankEventInfo()
		{
		}

		private void InitializeRankEventDeckData()
		{
		}

		private void InitializeDuelTrialInfo()
		{
		}

		private void InitializeDuelTrialDeckData()
		{
		}

		private void InitializeVersusInfo()
		{
		}

		private void InitializeVersusDeckData()
		{
		}

		private void InitializeMyDeckData()
		{
		}

		private void InitializeRentalDeckData()
		{
		}

		private void InitializeDuelTrialRentalDeckData()
		{
		}

		private void InitializeVersusRentalDeckData()
		{
		}

		private void UpdateDeckNum()
		{
		}

		private void UpdateEventDeckNum()
		{
		}

		private void DispPickupCards()
		{
		}

		private void SetActionLabels(DeckReference deckRef)
		{
		}

		private void SetActionCallBacks()
		{
		}

		private void UpdateTemplateList()
		{
		}

		public void OnItemInitialize(GameObject gob)
		{
		}

		public void OnGsvStanby()
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		private void OnClick(DeckReference deckRef)
		{
		}

		private void BulkDecksDeletion()
		{
		}

		private UnityAction GetDeckActionCallBack(int i)
		{
			return null;
		}

		private GameObject CreateEmbedObj(DeckReference deckRef)
		{
			return null;
		}

		private void DeleteDecks()
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}
	}
}
