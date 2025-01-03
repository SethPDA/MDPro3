using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.ActionSheet;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.CardBrowser
{
	public class CardListBrowserViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class CardWidget : ElementWidgetBase
		{
			private readonly string k_ECardLabelButton;

			private readonly string k_ECardLabelNoCard;

			private readonly string k_ECardLabelHighlight;

			private readonly string k_ECardLabelIconRarity;

			private readonly string k_ECardLabelLimitIcon;

			private readonly string k_ECardLabelNumTextArea;

			private readonly string k_ECardLabelNumText;

			private readonly string k_ECardLabelNewIcon;

			private int m_Idx;

			private int m_Mrk;

			private int m_StyleId;

			private readonly RawImage m_CardRawImage;

			private BindingCardMaterial m_BindingCardMaterial;

			public int regurationId;

			public int idx => 0;

			public bool highlightVisible
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool newIconVisible
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool limitIconVisible
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Image limitIconImage => null;

			public bool innerTextVisible
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public TMP_Text innerText => null;

			public SelectionButton button => null;

			public GameObject noCard => null;

			public BindingCardMaterial bindingCardMaterial => null;

			public event Action<CardWidget> onClickEvent
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

			public static CardWidget Create(ElementObjectManager eom)
			{
				return null;
			}

			public CardWidget(ElementObjectManager eom)
				: base(null)
			{
			}

			public virtual void Binding(int idx, int mrk, int styleId = 1)
			{
			}

			protected virtual void OnClick()
			{
			}
		}

		private class FilterFormWidget : ElementWidgetBase
		{
			private readonly string k_ELabelDisplayInFilterText;

			private readonly string k_ELabelFilterRarityTabs;

			private readonly string k_ELabelNumGroup;

			private readonly string k_ELabelNumText;

			public readonly DirectionalToggleGroupWidget rarityToggleWidget;

			public InputFieldWidget nameInputWidget;

			public TMP_Text displayInFilterText;

			public GameObject numGroup => null;

			public TMP_Text numText => null;

			public FilterFormWidget(ElementObjectManager filterFormEom, InputFieldWidget filterInputField)
				: base(null)
			{
			}
		}

		public const string k_ArgOpenOnHome = "onHome";

		private const string k_ArgTitle = "title";

		private const string k_ArgCardMrks = "cardMrks";

		public const string k_ArgRegulationVisible = "regulationVisible";

		public const string k_ArgRegulationId = "regulationId";

		public const string k_ArgRegulationSelectorVisible = "regulationSelectorVisible";

		public const string k_ArgShowOwnedNumToggleVisible = "showOwnedNumToggleVisible";

		public const string k_ArgRequestCardTermData = "requestCardInfo";

		public const string k_ArgShowHighlightReleasedCardsToggleVisible = "showHighlightReleasedCardsToggleVisible";

		public const string k_ArgHasNumVisible = "hasNumVisible";

		public const string k_ArgHasNumMonochrome = "hasNumMonochrome";

		public const string k_ArgHighlightReleasedCards = "HighlightReleasedCards";

		public const string k_ArgEnableFilterForm = "EnablefilterForm";

		public const string k_ArgEnableDisplayFilterNum = "DisplayFilterNum";

		private const int k_DisplayIdx_All = 0;

		private const int k_DisplayIdx_HasNum = 1;

		private const int k_DisplayIdx_HighlightReleasedCards = 2;

		[SerializeField]
		private string m_ELabelRegulationButton;

		private const string k_ELabelRegulationIcon = "RegulationIcon";

		private readonly string k_VLabelDefault;

		private readonly string k_VLabelFiltered;

		private readonly string k_ELabelAnalogDirectionItem;

		private readonly string k_ELabelTitleText;

		private readonly string k_ELabelCardList;

		private readonly string k_ELabelEmptyText;

		private readonly string k_ELabelRegulationButtonRoot;

		private readonly string k_ELabelShowOwnedNumToggleRoot;

		private readonly string k_ELabelShowOwnedNumToggle;

		private readonly string k_ELabelDisplaySelectButtonRoot;

		private readonly string k_ELabelDisplaySelectButton;

		private readonly string k_ELabelDisplaySelectText;

		private readonly string k_ELabelFilterInputFieldRoot;

		private readonly string k_ELabelFilterForm;

		private readonly string k_ELabelFilterInputField;

		private readonly string k_ELabelShortcutButtonRarityBack;

		private readonly string k_ELabelShortcutButtonRarityNext;

		private List<int> m_CardMrks;

		private List<int> m_DisplayCardMrks;

		private bool m_RegulationVisible;

		private bool m_HasNumVisible;

		private bool m_HasNumMonochrome;

		private bool m_HighlightReleasedCards;

		private int m_RegulationId;

		private int m_CurrentDisplayIdx;

		private ActionSheetViewController.EntryData[] m_DisplaySheetEntries;

		private ToggleWidget m_ShowOwnedNumToggle;

		private SelectionButton m_DisplaySelectButton;

		private TMP_Text m_DisplaySelectText;

		private InfinityScrollView m_ScrollView;

		private TMP_Text m_EmptyText;

		private RegulationSelectSheet m_RegulationSelectSheet;

		private FilterFormWidget m_FilterFormWidget;

		private Dictionary<GameObject, CardWidget> m_CardWidgetDic;

		private List<int> m_TmpSearchMrks;

		protected override Type[] textIds => null;

		public static void OpenByConfig(string configPath, IReadOnlyList<int> cardMrks, Dictionary<string, object> args = null)
		{
		}

		public static void Open(string title, IReadOnlyList<int> cardMrks, ViewControllerManager manager = null, Dictionary<string, object> args = null)
		{
		}

		public static void Open(ViewControllerManager manager = null, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void UpdateListDisplay()
		{
		}

		private void ApplyCurrentDisplay()
		{
		}

		private void UpdateRegulationIcon()
		{
		}

		public void OnEntityCreated(GameObject gob)
		{
		}

		public void OnEntityUpdate(GameObject gob, int dataindex)
		{
		}

		private void OnClickEntity(CardWidget clickedWidget)
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		private void OpenRegurationSelectSheet()
		{
		}
	}
}
