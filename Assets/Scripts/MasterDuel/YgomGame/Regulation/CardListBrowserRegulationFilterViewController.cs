using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Regulation
{
	public class CardListBrowserRegulationFilterViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class CardWidget : ElementWidgetBase
		{
			private readonly string k_ECardLabelButton;

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
			private readonly string k_ELabelFilterLimitTabs;

			public readonly DirectionalToggleGroupWidget limitToggleWidget;

			public FilterFormWidget(ElementObjectManager eom)
				: base(null)
			{
			}
		}

		public const string k_ArgRegulationId = "regulationId";

		public const string k_ArgRegulationName = "regulationName";

		private readonly string k_ELabelRegulationNameText;

		private readonly string k_ELabelCardList;

		private readonly string k_ELabelEmptyText;

		private readonly string k_ELabelFilterForm;

		private readonly string k_ELabelShortcutButtonRarityBack;

		private readonly string k_ELabelShortcutButtonRarityNext;

		private readonly string k_ELabelFilterButton;

		private readonly string k_ELabelDisplayInFilterText;

		private const string k_ELabelFilterOnIcon = "IconOn";

		private const string k_ELabelFilterOffIcon = "IconOff";

		private const string k_ELabelFilterOnImage = "On";

		private const string k_ELabelFilterOffImage = "Off";

		private const string k_ELabelRegulationLogo = "RegulationLogo";

		private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

		private List<int> m_DisplayCardMrks;

		private bool m_RegulationVisible;

		private int m_RegulationId;

		private InfinityScrollView m_ScrollView;

		private TMP_Text m_EmptyText;

		private Image m_RegulationLogoImage;

		private TMP_Text m_DisplayInFilterText;

		private bool isFiltered;

		private FilterFormWidget m_FilterFormWidget;

		private RectTransform m_FilterButtonImageOn;

		private RectTransform m_FilterButtonImageOff;

		private RectTransform m_FilterButtonIconOn;

		private RectTransform m_FilterButtonIconOff;

		private Dictionary<GameObject, CardWidget> m_CardWidgetDic;

		private List<int>[] m_regMrksLists;

		private FilterDialogManager m_FilterDialogManager;

		private SelectionButton m_FilterButton;

		private List<FilterDialog.FilterGroupType> m_FilterGroupTypes;

		private SearchFilter.Setting m_DefaultSetting;

		protected override Type[] textIds => null;

		private void InitDefaultSetting()
		{
		}

		public static void Open(string regulationName, int regulationId, ViewControllerManager manager = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenHome(string regulationName, int regulationId, ViewControllerManager manager = null, Dictionary<string, object> args = null)
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

		private void RemoveExtraCard()
		{
		}

		private List<int>[] CreateStandardLists()
		{
			return null;
		}

		private void SubtractStandard()
		{
		}

		private void CreateRegMrksList()
		{
		}

		private List<int> SelectInCardRare(List<int> rawList)
		{
			return null;
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

		private void FilteredCallBack()
		{
		}

		private void ToggleFilterButton(bool isFiltered)
		{
		}

		private void InitializeFilterButton()
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}
	}
}
