using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class CardCollectionView : MonoBehaviour
	{
		public abstract class PartialView
		{
			protected ElementObjectManager m_Eom;

			protected bool isInitialized;

			public GameObject gameObject => null;

			protected abstract void InitializeElements();

			protected void Initialize(ElementObjectManager eom)
			{
			}
		}

		public enum Area
		{
			Collection = 0,
			Bookmark = 1,
			History = 2
		}

		public class TabArea : PartialView
		{
			private class TabButton : PartialView
			{
				public SelectionButton button
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

				public RectTransform imageOn
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

				public RectTransform imageOff
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

				public ShortcutIcon shortcutIcon
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

				public TabButton(ElementObjectManager eom)
				{
				}

				protected override void InitializeElements()
				{
				}

				public void Toggle(bool isOn)
				{
				}
			}

			private const string k_ELabelImageOn = "ImageOn";

			private const string k_ELabelImageOff = "ImageOff";

			private const string k_ELabelShortcutIcon = "ShortcutIcon";

			private const string k_ELabelCardListButton = "CardListButton";

			private const string k_ELabelBookmarkButton = "BookmarkButton";

			private const string k_ELabelHistoryButton = "HistoryButton";

			private TabButton m_CardListTab;

			private TabButton m_BookmarkTab;

			private TabButton m_HistoryTab;

			private Dictionary<Area, TabButton> m_Tabs;

			private Action OnClickCardListButtonCallback;

			private Action OnClickBookmarkButtonCallback;

			private Action OnClickHistoryButtonCallback;

			public SelectionButton m_CardListButton => null;

			public SelectionButton m_BookmarkButton => null;

			public SelectionButton m_HistoryButton => null;

			public Action<Area> onChagedAreaCallback
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

			public TabArea(ElementObjectManager eom)
			{
			}

			protected override void InitializeElements()
			{
			}

			public void SetOnOnClickCardListButtonCallback(Action callback)
			{
			}

			public void SetOnOnClickBookmarkButtonCallback(Action callback)
			{
			}

			public void SetOnOnClickHistoryButtonCallback(Action callback)
			{
			}

			public void ToggleByArea(Area area)
			{
			}

			public void DispShotcutIconByArea(Area area)
			{
			}

			public void DispShortcutIcons(bool isDisp)
			{
			}

			public void SetShortcutIcons(SelectorManager.KeyType main, SelectorManager.KeyType sub)
			{
			}
		}

		public class FilterAndSearchArea : PartialView
		{
			private const string k_ELabelInputField = "InputField";

			private const string k_ELabelNotOwnedButton = "NotOwnedButton";

			private const string k_ELabelSortButton = "SortButton";

			private const string k_ELabelFilterButton = "FilterButton";

			private const string k_ELabelClearButton = "ClearButton";

			private ElementObjectManager m_SortButtonEom;

			private const string k_ELabelSortIconAsc = "IconAsc";

			private const string k_ELabelSortIconDesc = "IconDesc";

			private const string k_ELabelSortText = "TextTMP";

			private RectTransform m_SortIconAsc;

			private RectTransform m_SortIconDesc;

			private ExtendedTextMeshProUGUI m_SortText;

			private Action OnClickSortButtonCallback;

			private ElementObjectManager m_FilterButtonEom;

			private const string k_ELabelFilterOnIcon = "IconOn";

			private const string k_ELabelFilterOffIcon = "IconOff";

			private const string k_ELabelFilterOnImage = "On";

			private const string k_ELabelFilterOffImage = "Off";

			private RectTransform m_FilterButtonImageOn;

			private RectTransform m_FilterButtonImageOff;

			private RectTransform m_FilterButtonIconOn;

			private RectTransform m_FilterButtonIconOff;

			private Action OnClickFilterButtonCallback;

			private Action<string> OnEndSubmitEditCallback;

			private ElementObjectManager m_ClearButtonEom;

			private Action OnClickClearButtonCallback;

			private ElementObjectManager m_NotOwnButtonEom;

			private const string k_ELabelNotOwnOnIcon = "IconOn";

			private const string k_ELabelNotOwnOffIcon = "IconOff";

			private const string k_ELabelNotOwnOnImage = "On";

			private const string k_ELabelNotOwnOffImage = "Off";

			private RectTransform m_NotOwnButtonImageOn;

			private RectTransform m_NotOwnButtonImageOff;

			private RectTransform m_NotOwnButtonIconOn;

			private RectTransform m_NotOwnButtonIconOff;

			private Action OnClickNotOwnButtonCallback;

			public SelectionButton m_SortButton
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

			public SelectionButton m_FilterButton
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

			public InputFieldWidget m_InputField
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

			public SelectionButton m_ClearButton
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

			public SelectionButton m_NotOwnButton
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

			public DeviceIcon m_SortShortcutIcon
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

			public DeviceIcon m_FilterShortcutIcon
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

			public DeviceIcon m_InputFieldShortcutIcon
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

			public DeviceIcon m_ClearShortcutIcon
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

			public DeviceIcon m_NotOwnShortcutIcon
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

			public FilterAndSearchArea(ElementObjectManager eom)
			{
			}

			protected override void InitializeElements()
			{
			}

			private void InitializeSortButtonElements()
			{
			}

			public void SetOnOnClickSortButtonCallback(Action callback)
			{
			}

			public void SetSortIcon(SortComparer.Sorter s)
			{
			}

			private void InitializeDispButtonElements()
			{
			}

			public void SetOnOnClickFilterButtonCallback(Action callback)
			{
			}

			public void ToggleFilterButton(bool isFiltered)
			{
			}

			private void InitializeInputFieldElements()
			{
			}

			public void SetOnEndSubmitCallback(Action<string> callback)
			{
			}

			public void ClearKeyword()
			{
			}

			private void InitializeClearButtonElements()
			{
			}

			public void SetOnOnClickClearButtonCallback(Action callback)
			{
			}

			private void InitializeNotOwnButtonElements()
			{
			}

			public void SetOnOnClickNotOwnButtonCallback(Action callback)
			{
			}

			public void ToggleNotOwnButton(bool isDispNotOwned)
			{
			}

			public void SetInteractableButtons(bool isInteractable)
			{
			}

			public void SetShortcutIcons(bool isActivate)
			{
			}
		}

		public class RelatedArea : PartialView
		{
			private const string k_ELabelRelatedCardRoot = "RelatedCard";

			private const string k_ELabelRelatedCardText = "RelatedCardText";

			private const string k_ELabelRelatedCardButton = "RelatedCardButton";

			private ElementObjectManager m_RelatedCardEom;

			private Transform m_CardRoot;

			private RawImage m_CardImage;

			private ExtendedTextMeshProUGUI m_CardText;

			private int relatedCardID;

			private Action OnSetRelatedCardCallback;

			private Action OnDispRelatedCardCallback;

			private Action<int> OnClickRelatedCardButtonCallback;

			private Action<int> OnSelectdRelatedCardButtonCallback;

			private Action<int> OnSelectdRelatedCardButtonKetyDownCallback;

			private const string k_ELabelCloseButton = "CloseButton";

			private Action OnClickCloseButtonCallback;

			private Action OnSelectdCloseButtonCallback;

			public SelectionButton m_CardButton
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

			public SelectionButton m_CloseButton
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

			private bool isActive => false;

			public bool isSet => false;

			public RelatedArea(ElementObjectManager eom)
			{
			}

			protected override void InitializeElements()
			{
			}

			private void InitializeRelatedCardElements()
			{
			}

			public void SetRelatedCardId(int cardId)
			{
			}

			public void SetOnSetRelatedCardCallback(Action callback)
			{
			}

			public void DispRelatedCard(bool b)
			{
			}

			public void SetOnDispRelatedCardCallback(Action callback)
			{
			}

			public void SetOnOnClickRelatedCardButtonCallback(Action<int> callback)
			{
			}

			public void SetOnSelectedRelatedCardButtonCallback(Action<int> callback)
			{
			}

			public void SetOnSelectdRelatedCardButtonKetyDownCallback(SelectorManager.KeyType main, SelectorManager.KeyType sub, Action<int> callback)
			{
			}

			private void InitializeCloseButtonElement()
			{
			}

			public void SetOnClickCloseButtonCallback(Action callback)
			{
			}

			public void SetOnSelectCloseButtonCallback(Action callback)
			{
			}
		}

		public class CardDropArea : PartialView
		{
			private const string k_ELabelAddBookmarkImage = "AddBookmarkImage";

			private const string k_ELabelRemoveDeckImage = "RemoveDeckImage";

			private const string k_ELabelDropAreaOver = "DropAreaOver";

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

			public RectTransform m_RemoveDeckImage
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

			public RectTransform m_AddBookmarkImage
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

			public RectTransform m_DropAreaOver
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

			public CardDropArea(ElementObjectManager eom)
			{
			}

			protected override void InitializeElements()
			{
			}
		}

		public class CardListArea : PartialView
		{
			private const int numPreLoad = 12;

			private const string k_ELabelInfinityScroll = "CardList";

			private const string k_ELabelLoadingIcon = "Loading";

			private const string k_ELabelNoItemButton = "NoItemButton";

			private const string k_ELabelNoItemText = "NoItemText";

			private const string k_ELabelCollection = "CollectionAreaCenter";

			private GridLayoutGroup m_GridLayout;

			private CanvasGroup m_CardListCanavsGroup;

			private EntityPoolController entityPoolController;

			public CardCollectionView cardCollectionView
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

			public InfinityScrollView m_InfinityScroll
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

			public RectTransform m_LoadingIcon
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

			public SelectionButton m_NoItemButton
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

			public ExtendedTextMeshProUGUI m_NoItemText
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

			public ExtendedScrollRect m_ExtendedScrollRect
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

			public RectTransform m_CollectionAreaCenter
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

			private int constraintCount => 0;

			private int constraintCount2 => 0;

			private List<CardBaseData> m_CardList => null;

			private int regulationId => 0;

			private DeckEditViewController2.DisplayMode displayMode => default(DeckEditViewController2.DisplayMode);

			private Area currentArea => default(Area);

			public Action<CardStrip, bool> onCreateCardCallback
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

			public Action<SelectionItem> onSelectedCardCallback
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

			public Action<bool, CardBaseData> onUpdateViewCallback
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

			public Action<SelectionItem> onInputLeftEdge
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

			public Action onInputUpEdge
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

			public CardListArea(ElementObjectManager eom)
			{
			}

			protected override void InitializeElements()
			{
			}

			public void InitializeTemplate()
			{
			}

			public void InitializeScroll()
			{
			}

			private void OnCreateEntity(GameObject obj)
			{
			}

			private void OnUpdateEntity(GameObject obj, int idx)
			{
			}

			private void OnRemoveEntity(GameObject obj, int idx, bool isTop)
			{
			}

			public void UpdateView(bool updateDataCount, bool select = true)
			{
			}

			public int GetIndex(int cardID, int premiumID = -1)
			{
				return 0;
			}

			public void CursorJumpUp()
			{
			}

			public void CursorJumpDown()
			{
			}

			public void CursorJumpRight()
			{
			}

			public void CursorJumpLeft()
			{
			}

			public void FocusItemAt(int index, bool immediate, bool select)
			{
			}

			private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
			{
				return false;
			}

			public void SelectLeftEdgeClosestItem(Vector2 screenPoint, float angleDot, bool isIni = false)
			{
			}

			public void StopScroll()
			{
			}

			private void SetDispNoItem(bool disp)
			{
			}

			public void DispLoadingIcon(bool disp)
			{
			}

			private void InitilizeNoItem()
			{
			}
		}

		private ElementObjectManager m_Eom;

		private static Content m_cci;

		private const string k_ELabelShortcutIconGroup = "ShortcutIconGroup";

		private const string k_ELabelShortcutIcon0 = "Icon0";

		private const string k_ELabelShortcutIcon1 = "Icon1";

		private const string k_ELabelShortcutIconPlus = "IconPlus";

		private const string k_ELabelFilterAndSortArea = "FilterAndSortArea";

		private const string k_ELabelRelatedArea = "RelatedArea";

		private const string k_ELabelTabArea = "TabArea";

		private const string k_ELabelDropArea = "DropArea";

		private const string k_ELabelCardListArea = "CardListArea";

		private const string k_ELabelSelectedWindowCursor = "SelectedWindowCursor";

		private ElementObjectManager m_FilterAndSortEom;

		private ElementObjectManager m_RelatedEom;

		private ElementObjectManager m_TabEom;

		private ElementObjectManager m_DropEom;

		private ElementObjectManager m_CardListEom;

		private RectTransform m_SelectedWindowCursor;

		protected List<int> pooledHistoryCardIDs;

		protected List<int> pooledBookmarkCardIDs;

		private SelectionItem currentItem;

		private DeckEditViewController2.DisplayMode displayMode;

		private int regulationID;

		private bool isModified;

		private bool isCurrentView;

		public FilterAndSearchArea m_FilterAndSearchArea
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

		public RelatedArea m_RelatedArea
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

		public TabArea m_TabArea
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

		public CardDropArea m_CardDropArea
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

		public CardListArea m_CardListArea
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

		public Func<List<CardBaseData>> m_CollectionCardGetter
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

		public Func<List<CardBaseData>> m_BookmarkCardGetter
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

		public Func<List<CardBaseData>> m_HistoryCardGetter
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

		public List<CardBaseData> m_DataList => null;

		public bool isRelatedCardActive
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

		public Area m_Area
		{
			[CompilerGenerated]
			get
			{
				return default(Area);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isDismantleMode
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

		public SelectionButton m_CollectionTab => null;

		public bool isLoading => false;

		public RectTransform m_CollectionAreaLayoutGroup => null;

		public void SetReguration(int regulationID)
		{
		}

		public void SetDirty()
		{
		}

		public bool IsModified()
		{
			return false;
		}

		public void OnSaved()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void ToggleTabAndArea(Area a)
		{
		}

		private void ToggleTab(Area a)
		{
		}

		public void ToggleNextTabAndArea()
		{
		}

		public void SetupTabShortcutIcon(Area currentArea)
		{
		}

		public void HideTabShortcutIcon()
		{
		}

		public void SetOnClickCollectionTabButton(UnityAction callback)
		{
		}

		public void SetOnClickBookmarkTabButton(UnityAction callback)
		{
		}

		public void SetOnClickHistoryTabButton(UnityAction callback)
		{
		}

		public void SetTabChangeShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		public void ToggleFilterButton(bool filtered)
		{
		}

		public void ToggleShowAllCardsButton(bool showNotOwned)
		{
		}

		public void SetInteractableFilterSort(bool interactable)
		{
		}

		public void SetSearchKeyWord(string s)
		{
		}

		public void SetOnSubmitSearch(UnityAction<string> callback)
		{
		}

		public void SetOnClickResetSearchButton(UnityAction callback)
		{
		}

		public void SetOnClickFilterButton(UnityAction callback)
		{
		}

		public void SetOnClickShowAllCardsButton(UnityAction callback)
		{
		}

		public void SetOnClickSortButton(UnityAction callback)
		{
		}

		public void SetFilterButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		public void SetSortButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		public void SetResetSearchButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		public void SetShowAllCardsButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		public void ActivateSearchInput()
		{
		}

		public void SetTextSearchShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		public void SetUncurrentView()
		{
		}

		public void SetCurrentView()
		{
		}

		public void SetDismantleMode(bool b)
		{
		}

		public void SetSortButtonLabel(SortComparer.Sorter sorter)
		{
		}

		public void SetOnSelectCloseRelatedCard(UnityAction callback)
		{
		}

		public void SetOnClickCloseRelatedCard(UnityAction callback)
		{
		}

		public void SetActiveRelatedCard(bool b, int id = 0)
		{
		}

		private void SetDispRelatedCard(bool disp)
		{
		}

		public void SetOnSelectRelatedCard(UnityAction<int> callback)
		{
		}

		public void SetOnClickRelatedCard(UnityAction<int> callback)
		{
		}

		public void SetSelectedShortcutRelatedCard(SelectorManager.KeyType main, SelectorManager.KeyType sub, Action<int> callback)
		{
		}

		private void SetShortcut(SelectionButton button, DeviceIcon deviceIcon, SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		public void SetDispDropArea(bool disp)
		{
		}

		public void SetDispDropAreaOver(bool disp)
		{
		}

		public void CursorJumpUp()
		{
		}

		public void CursorJumpDown()
		{
		}

		public void CursorJumpRight()
		{
		}

		public void CursorJumpLeft()
		{
		}

		public void FocusItemAt(int index, bool immediate, bool select)
		{
		}

		public int GetIndex(int cardID, int premiumID = -1)
		{
			return 0;
		}

		public void UpdateDisplayMode(DeckEditViewController2.DisplayMode mode, bool updateScroll = true)
		{
		}

		public void UpdateView(bool updateDataCount, bool select = true)
		{
		}

		public void ShowLoading()
		{
		}

		public void HideLoading()
		{
		}

		public void SelectLeftEdgeClosestItem(Vector2 screenPoint, float angleDot, bool isIni = false)
		{
		}

		public void SetActiveScroll(bool condition)
		{
		}

		private IEnumerator waitDecrementDragCounter()
		{
			return null;
		}

		public void SelectLeftUpEdgeItem(bool isIni = true)
		{
		}

		public void SetOnSelectNoItemButton(UnityAction callback)
		{
		}
	}
}
