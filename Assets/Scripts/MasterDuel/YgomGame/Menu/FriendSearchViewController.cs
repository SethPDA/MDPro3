using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using UnityEngine;
using YgomGame.Friend;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class FriendSearchViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		private interface ISearchForm
		{
			GameObject gameObject { get; }

			long currentPcode { get; }

			void Clear();

			bool TrySelectChild(bool initializeSelection = false);

			bool OnPadBack();
		}

		private class PlayerListView
		{
			private readonly string EMPTY_ROOT_LABEL;

			private readonly string LIST_ROOT_LABEL;

			private readonly string LIST_TITLE_LABEL;

			private readonly string LIST_SCROLL_VIEW_LABEL;

			private ElementObjectManager m_Eom;

			private GameObject m_EmptyRoot;

			private GameObject m_ListRoot;

			private TMP_Text m_ListTitleText;

			private InfinityScrollView m_ListScrollView;

			private Dictionary<string, object> m_PlayerDataMap;

			private Dictionary<GameObject, FriendWidget> m_FriendWidgetMap;

			private List<string> m_PlayerList;

			public GameObject gameObject => null;

			public IReadOnlyList<string> playerList => null;

			public long currentPcode => 0L;

			public event Action<long> onClickPlayerEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public PlayerListView(ElementObjectManager eom)
			{
			}

			public void Initialize(Action onComplete = null)
			{
			}

			private void OnCreatedEntity(GameObject gob)
			{
			}

			private void OnUpdateEntity(GameObject gob, int dataindex)
			{
			}

			public void ApplyResult(List<object> hitPlayerList, bool isExcess, bool resetPosition = true)
			{
			}

			public bool TrySelectIdx(int idx)
			{
				return false;
			}

			public bool IsContainSelectedItem()
			{
				return false;
			}
		}

		private class SearchFormId : ISearchForm
		{
			private readonly string k_ELabelResultMessage;

			private readonly string ID_INPUT_LABEL;

			private readonly string ID_INPUTOVERRIDE_TEXT_LABEL;

			private readonly string PLAYER_BOARD_LABEL;

			private ElementObjectManager m_Eom;

			private readonly InputFieldWidget m_InputFieldWidget;

			private readonly TMP_Text m_InputFieldOverrideText;

			private readonly TMP_Text m_ResultMessage;

			private readonly FriendWidget m_FriendWidget;

			private int m_LastCaretPos;

			private int pcodeLength;

			private StringBuilder m_Sb;

			private bool m_InputGuard;

			public GameObject gameObject => null;

			public long currentPcode
			{
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public event Action<long> onDecideEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event Action<long> onClickPlayerEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public SearchFormId(ElementObjectManager eom)
			{
			}

			public void Initialize(int pcodeLength)
			{
			}

			public void Clear()
			{
			}

			public void CheckCaretPosition()
			{
			}

			private void OnValueChanged(string input)
			{
			}

			private void OnSubmitInputField(string input)
			{
			}

			public void ApplySearchResult(long searchPcode, List<object> hitPlayerList, string failedMessage = null)
			{
			}

			public bool TrySelectChild(bool initializeSelection = false)
			{
				return false;
			}

			public bool OnPadBack()
			{
				return false;
			}
		}

		private class SearchFormTag : ISearchForm
		{
			private readonly string TAG_FORM_LABEL;

			private readonly string TAG_RESULT_FORM_LABEL;

			private readonly string TAG_SELECT_FORM_LABEL;

			private ElementObjectManager m_Eom;

			private readonly TagSelector m_TagForm;

			private readonly TagListView m_TagListView;

			private readonly PlayerListView m_ResultPlayerList;

			private readonly SelectionButton m_TagSearchToggle;

			private bool m_IsSelectMode;

			private Action m_OnComplete;

			private int m_LoadincCnt;

			private bool m_IsEntryMode;

			public GameObject gameObject => null;

			public TagSelector tagForm => null;

			public TagListView tagListView => null;

			public IReadOnlyList<int> searchTagIdList => null;

			public long currentPcode => 0L;

			public event Action onSearchDecideEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event Action<long> onClickPlayerEvent
			{
				add
				{
				}
				remove
				{
				}
			}

			public SearchFormTag(ElementObjectManager eom, SelectionButton tagSearchToggle)
			{
			}

			public void Initialize(Action onComplete = null)
			{
			}

			private void CheckInitializeCallback()
			{
			}

			public void ApplySearchResult(List<object> hitPlayerList, bool isExcess, bool resetPosition = true)
			{
			}

			public void Clear()
			{
			}

			private void ToEntrySelectForm()
			{
			}

			private void ToSelectForm()
			{
			}

			private void ToResultForm(List<object> hitPlayerList, bool isExcess, bool resetPosition = true)
			{
			}

			public bool TrySelectDefault(bool initializeSelection = false)
			{
				return false;
			}

			public bool TrySelectChild(bool initializeSelection = false)
			{
				return false;
			}

			public bool OnPadBack()
			{
				return false;
			}
		}

		private class TagListView
		{
			private readonly string SCROLL_VIEW_LABEL;

			private readonly string ITEM_ON;

			private readonly string ITEM_OFF;

			private readonly string ITEM_TAG_LABEL_ON;

			private readonly string ITEM_TAG_LABEL_OFF;

			private ElementObjectManager m_Eom;

			private readonly InfinityScrollView m_ScrollView;

			private readonly SelectionItem m_UpperSelectTarget;

			public readonly List<int> searchTagIds;

			public readonly IReadOnlyList<int> selectedList;

			public bool removeInteractable;

			public GameObject gameObject => null;

			public InfinityScrollView scrollView => null;

			public event Action<int> onClickTagEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public TagListView(ElementObjectManager eom, IReadOnlyList<object> searchTagIds, IReadOnlyList<int> selectedList, SelectionItem upperSelectTarget = null)
			{
			}

			public void Initialize(Action complete = null)
			{
			}

			private void OnUpdateEntity(GameObject gob, int dataindex)
			{
			}

			public bool SelectItemByIdx(int idx)
			{
				return false;
			}

			public void Refresh(bool selectDefault = false)
			{
			}

			public void Clear()
			{
			}

			public bool IsContainSelectedItem()
			{
				return false;
			}
		}

		private class TagSelector
		{
			private readonly int k_TagMax;

			private readonly string TAG_ITEM_ROOT_LABEL;

			private readonly string TAG_ITEM_LABEL_OFF_LABEL;

			private readonly string TAG_ITEM_LABEL_ON_LABEL;

			private readonly string TAG_ITEM_ADD_LABEL;

			private readonly string SEARCH_BUTTON_LABEL;

			private ElementObjectManager m_Eom;

			private readonly ToggleGroupWidget m_ToggleGroupWidget;

			public readonly SelectionButton searchButton;

			private readonly List<int> m_TagList;

			private int k_AddIdx => 0;

			public GameObject gameObject => null;

			public IReadOnlyList<int> tagList => null;

			public int currentIdx => 0;

			public int focusTagId => 0;

			public event Action<int> onClickTagEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public event Action onClickSearchEvent
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public TagSelector(ElementObjectManager eom)
			{
			}

			public void Initialize()
			{
			}

			public void Clear()
			{
			}

			public void ToAllOff()
			{
			}

			public bool SelectDefaultCursor()
			{
				return false;
			}

			public bool IsContainSelectedItem(Selector selector)
			{
				return false;
			}

			public void Refresh()
			{
			}

			public void SetTag(int tagId, bool isInvokeChangeEvent = true)
			{
			}

			public void AddTag(int tagId)
			{
			}

			public void RemoveTag(int tagId)
			{
			}

			public void ReplaceTag(int fromTagId, int toTagId)
			{
			}
		}

		public const string PREFAB_NAME = "Friend/FriendSearch";

		private readonly string BTN_BACK_PAD_BUTTON_LABEL;

		private readonly string k_ELabelTitleBg_Result;

		private readonly string k_ELabelGuideMessage_Default;

		private readonly string k_ELabelGuideMessage_Result;

		private readonly string IDSEARCH_TOGGLE_LABEL;

		private readonly string TAGSEARCH_TOGGLE_LABEL;

		private readonly string SEARCHFORM_ID_LABEL;

		private readonly string SEARCHFORM_TAG_LABEL;

		private readonly string SHORTCUT_BUTTON_L1;

		private readonly string SHORTCUT_BUTTON_R1;

		private const int k_ID_SEARCH_FORM = 0;

		private const int k_TAG_SEARCH_FORM = 1;

		private long m_ReserveSearchPcode;

		private FriendDefinitionSetting m_FriendDefinitionSetting;

		private ToggleGroupWidget m_SearchFormTab;

		private ISearchForm[] m_SearchForms;

		private bool m_IsReady;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnPadBack()
		{
		}

		private bool TagListEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		public override bool OnBack()
		{
			return false;
		}

		private void OpenPlayerProfile(long pcode)
		{
		}

		private void RequestSearchId()
		{
		}

		private void RequestSearchIdExecute(long searchPcode)
		{
		}

		private void RequestSearchTag(bool resetPosition = true)
		{
		}

		private void RequestSearchTag(Action callback, bool resetPosition = true)
		{
		}
	}
}
