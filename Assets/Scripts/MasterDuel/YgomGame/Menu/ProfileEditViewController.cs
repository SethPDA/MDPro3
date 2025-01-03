using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu
{
	public class ProfileEditViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		private class TitleArea : MonoBehaviour
		{
			private ElementObjectManager m_Eom;

			private bool isInitialized;

			private ExtendedTextMeshProUGUI m_TitleText;

			private SelectionButton m_CautionButton;

			private void Awake()
			{
			}

			public void InitializeElements()
			{
			}

			public void SetTitleByEditType(EditType editType)
			{
			}

			private void OpenCautionDialog()
			{
			}

			public void DispCautionButton(bool disp)
			{
			}
		}

		private class SideMenu : MonoBehaviour
		{
			private ElementObjectManager m_Eom;

			private bool isInitialized;

			public GameObject sideButtonTemplate
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

			public Selector selector
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

			public SelectionButton m_BackButton
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

			public Action onClickBackButtonCallback
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

			private void InitShottcutBack()
			{
			}
		}

		private class FooterArea : MonoBehaviour
		{
			private ElementObjectManager m_Eom;

			private bool isInitialized;

			private SelectionButton m_PreviewButton;

			private ExtendedTextMeshProUGUI m_PreviewButtonText;

			public Action onClickPreviewButtonCallback
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

			public string buttonText
			{
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
		}

		public enum EditType
		{
			USER_PROFILE = 0,
			ACCESSORY = 1,
			ACCESSORY_TOURNAMENT = 2,
			ACCESSORY_EXHIBITION = 3,
			ACCESSORY_CUP = 4,
			ACCESSORY_WCS = 5,
			ACCESSORY_RANKEVENT = 6,
			ACCESSORY_DUELTRIAL = 7,
			ACCESSORY_VERSUS = 8
		}

		internal abstract class ProfileEdit
		{
			private const string k_ELabelTextOn = "TextOn";

			private const string k_ELabelTextOff = "TextOff";

			protected ElementObjectManager m_Eom;

			protected GameObject m_Edit;

			protected GameObject m_View;

			protected ToggleWidget m_MenuToggle;

			protected GameObject m_Loading;

			protected Selector m_Selector;

			protected Selector m_ParentSelector;

			protected object current;

			protected bool isInitialized;

			internal readonly string clientWorkKeyName;

			internal readonly string saveKeyName;

			protected Action onUpdateViewCallback;

			public Action onClickPreviewCallback;

			public bool isActive => false;

			public ToggleWidget menuToggle => null;

			public GameObject view => null;

			protected ProfileEdit(string clientWorkKeyName, string saveKeyName, GameObject template, Transform parent)
			{
			}

			internal virtual void Init()
			{
			}

			internal virtual object GetCurrent()
			{
				return null;
			}

			internal virtual void SetCurrent(object current)
			{
			}

			internal abstract void EnterFromMenu();

			internal void SetActiveRoot(bool rootActive)
			{
			}

			internal virtual void UpdateView()
			{
			}

			internal virtual void SetView(GameObject view, Action callback)
			{
			}

			internal virtual ToggleWidget CreateSideToggleWidget(GameObject template, Transform parent, string label, bool defaultBtn = false)
			{
				return null;
			}

			internal virtual List<(string, object)> GetSaveData(Dictionary<string, object> dic)
			{
				return null;
			}
		}

		internal class ProfileEditText : ProfileEdit
		{
			private InputFieldWidget m_InputFieldWidget;

			private SelectionButton m_InputButton;

			private readonly string INPUT_NAME_LABEL;

			private readonly string INPUT_NAME_BTN_LABEL;

			internal ProfileEditText(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, int groupPriority)
				: base(null, null, null, null)
			{
			}

			internal override void SetCurrent(object name)
			{
			}

			internal override void Init()
			{
			}

			internal override void EnterFromMenu()
			{
			}
		}

		internal class ProfileEditImage : ProfileEdit
		{
			protected readonly string IMG_SELECTED_LABEL;

			protected readonly string SCROLL_LABEL;

			protected readonly string IMG_LABEL;

			protected readonly string TXT_LABEL;

			protected readonly string TXT_LABEL_ON;

			protected readonly string TXT_LABEL_OFF;

			protected readonly string BTN_LABEL;

			protected readonly string LOADING_LABEL;

			protected TextMeshProUGUI m_ItemName;

			protected TextGroupLoadHolder textGroupLoadHolder;

			protected InfinityScrollView m_InfinityScroll;

			protected List<object> itemList;

			public string itemName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int selectedItemId
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

			public Action onCompleteInitiazeCallback
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

			internal ProfileEditImage(string clientWorkKeyName, string saveKeyName, GameObject template, Transform parent, List<object> itemList, TextGroupLoadHolder textGroupLoadHolder)
				: base(null, null, null, null)
			{
			}

			internal override void Init()
			{
			}

			public void FocusImmidiate(int dataindex, bool selectItem = false, bool isIni = true)
			{
			}

			private IEnumerator DelaySelect(int dataindex, bool selectItem = false, bool isIni = true)
			{
				return null;
			}

			internal virtual void SetActiveViewItem(bool isActive)
			{
			}

			public void OnItemSetData(GameObject gob, int dataindex)
			{
			}

			public void OnGsvStanby()
			{
			}

			internal override void EnterFromMenu()
			{
			}
		}

		internal class ProfileEditPickCards : ProfileEdit
		{
			internal DeckCaseWidget deckCaseWidget;

			internal bool shouldSavePicks;

			public int[] pickupCards;

			public int[] pickupDecos;

			public int deckcaseId;

			public int protectorId;

			private int initialDeckcaseId;

			private int initialProtectorId;

			internal const int PICKUP_MAX = 3;

			internal ProfileEditPickCards(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, int caseId, int sleeveId, Dictionary<string, object> pickCards)
				: base(null, null, null, null)
			{
			}

			public void UpdateDeckcase(int deckcaseId)
			{
			}

			public void UpdateSleeve(int sleeveId)
			{
			}

			public void UpdateCards(Dictionary<string, object> pickCards)
			{
			}

			internal override List<(string, object)> GetSaveData(Dictionary<string, object> dic)
			{
				return null;
			}

			internal override void SetCurrent(object name)
			{
			}

			internal override void EnterFromMenu()
			{
			}

			internal void EnterFromMenu(Dictionary<string, object> updatedDict)
			{
			}
		}

		internal class ProfileEditTag : ProfileEdit
		{
			private class Data
			{
				public bool interactable;

				public object value;

				public Data(bool interactable, object value)
				{
				}
			}

			private const string TEMPLATE_LABEL = "Template";

			private const string OBJ_MYTAG_LABEL = "MyTagField";

			private const string TXT_LABEL_ON = "TextOn";

			private const string TXT_LABEL_OFF = "TextOff";

			private const string IMG_ON_LABEL = "ImageOn";

			private const string IMG_OFF_LABEL = "ImageOff";

			internal readonly int MYTAG_EMPTY;

			private List<GameObject> myTags;

			private List<object> tagList;

			private List<Data> dataList;

			private GameObject myTagTemplate;

			private GameObject myTagField;

			private InfinityScrollView m_InfinityScroll;

			private int editingTagIndex;

			public int selectedItemId
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

			public bool isSelectingTag
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

			public int editingIdx => 0;

			internal ProfileEditTag(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, List<object> tagList)
				: base(null, null, null, null)
			{
			}

			internal override void Init()
			{
			}

			public void SelectEditingMyTag()
			{
			}

			internal override void SetCurrent(object dictionary)
			{
			}

			internal override void EnterFromMenu()
			{
			}

			internal override List<(string, object)> GetSaveData(Dictionary<string, object> dic)
			{
				return null;
			}

			private void OnItemSetData(GameObject gob, int dataindex)
			{
			}

			private void OnGsvStanby()
			{
			}

			private void UpdateMytag()
			{
			}

			private void OnClickMyTag(int tagNo, bool select = true)
			{
			}

			private void UpdateTagScroll()
			{
			}

			private void UpdateMyTagImage()
			{
			}
		}

		private const string k_ELabelTitleArea = "TitleArea";

		private const string k_ELabelFooterArea = "FooterArea";

		private const string k_ELabelRootSideMenu = "RootSideMenu";

		private FooterArea m_FooterArea;

		private TitleArea m_TitleArea;

		private SideMenu m_SideMenu;

		private readonly string ROOT_EDIT_LABEL;

		private readonly string ROOT_VIEW_LABEL;

		private readonly string TMP_TXT_LABEL;

		private readonly string TMP_IMG_LABEL;

		private readonly string TMP_TAG_LABEL;

		private readonly string TMP_PICK_LABEL;

		private readonly string TMP_VIEW_LABEL;

		private readonly string IMG_LABEL;

		private readonly string TEXT_ITEM_NAME_LABEL;

		private bool isSaved;

		private bool isFixedAccsessory;

		private bool isFixedPickCards;

		private ProfileEdit currentEditing;

		private List<ProfileEdit> profileEdits;

		private EditType editType;

		private int deckID;

		private int identifierID;

		private int defaultTabIdx;

		private GameObject rootEdit;

		private GameObject rootView;

		private GameObject tmpEditTxt;

		private GameObject tmpEditImg;

		private GameObject tmpEditTag;

		private GameObject tmpEditPick;

		private GameObject tmpView;

		private TextMeshProUGUI m_CurrentItemNameText;

		private string m_CurrentItemName;

		private ProfileEditPickCards m_PEPC;

		public string currentItemName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static bool isMobile => false;

		public static bool isGamePad => false;

		protected override Type[] textIds => null;

		public static void Open(Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private void SaveEdit(UnityAction callback = null)
		{
		}

		private Dictionary<string, object> CheckUpdatedProfile()
		{
			return null;
		}

		private void EnterMenu(ProfileEdit profileEdit)
		{
		}

		private void SetActiveMenu(ProfileEdit profileEdit)
		{
		}

		private void InitEdit()
		{
		}

		private List<ToggleWidget> InitUserProfileEdit()
		{
			return null;
		}

		private List<ToggleWidget> InitAccessoryEdit()
		{
			return null;
		}

		private void OpenPickupSelectionBrowser()
		{
		}

		private void OpenFieldPreview()
		{
		}

		private void OpenItemPreview()
		{
		}

		private bool IsEdittingAccessorry()
		{
			return false;
		}

		private Dictionary<string, object> GetEditDic(EditType type)
		{
			return null;
		}

		private Dictionary<string, object> GetEditPickCards(EditType type)
		{
			return null;
		}
	}
}
