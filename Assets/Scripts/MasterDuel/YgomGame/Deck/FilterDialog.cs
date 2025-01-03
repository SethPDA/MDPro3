using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class FilterDialog : SelectDialogViewControllerBase<SearchFilter.Setting, SearchFilter.Setting, List<FilterDialog.FilterGroupType>, SearchFilter.Setting>, IBokeSupported
	{
		public enum FilterGroupType
		{
			Frame = 0,
			Attribute = 1,
			Tribe = 2,
			Level = 3,
			Spell = 4,
			Trap = 5,
			Rarity = 6,
			Ability = 7,
			Style = 8,
			Limit = 9,
			Cutin = 10
		}

		private class FilterGroup : MonoBehaviour
		{
			private const string k_ELabelIcon = "Icon";

			private const string k_ELabelText = "TextTMP";

			private const string k_ELabelButtonArea = "ButtonArea";

			private ElementObjectManager m_Eom;

			private Image m_GroupIconImage;

			private ExtendedTextMeshProUGUI m_GroupNameText;

			private GridLayoutGroup m_GridLayoutGroup;

			private bool isInitialized;

			private FilterGroupType m_Type;

			private Dictionary<string, FilterToggle> m_FilterToggles;

			public RectTransform m_ButtonArea
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

			public RectTransform m_RectTransform
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

			public void InitializeElements()
			{
			}

			private void Awake()
			{
			}

			public void Initialize(FilterGroupType type)
			{
			}

			public void AddFilterToggle(string label, FilterToggle filterToggle)
			{
			}
		}

		[SerializeField]
		private KeyConfigContainer keyConfig;

		private const string PREFAB_PATH_FILTERDIALOG = "DeckEdit/FilterDialog";

		private const string k_ELabelFilterMenuArea = "FilterMenuArea";

		private const string k_ELabelFilterScroll = "FilterScroll";

		private const string k_ELabelFooterArea = "FooterArea";

		private const string k_ELabelTitleText = "TitleText";

		private ElementObjectManager m_FilterMenuEom;

		private ElementObjectManager m_FooterEom;

		private ExtendedTextMeshProUGUI m_TitleText;

		private const string k_ALabelFilterToggleTemplate = "FilterToggleTemplate";

		private GameObject m_FilterToggleTemplate;

		private (SelectorManager.KeyType, SelectorManager.KeyType) keyInfoUpGroup;

		private (SelectorManager.KeyType, SelectorManager.KeyType) keyInfoDownGroup;

		private Coroutine m_InitializeCoroutine;

		private const string Label_Frame_Normal = "\ufffd";

		private const string Label_Frame_Effect = "\ufffd";

		private const string Label_Frame_Fusion = "\ufffd";

		private const string Label_Frame_Ritual = "\ufffd";

		private const string Label_Frame_Synchro = "シ\ufffd";

		private const string Label_Frame_Xyz = "エ\ufffd";

		private const string Label_Frame_Pendulum = "ペン";

		private const string Label_Frame_Link = "リ";

		private const string Label_Frame_Magic = "\ufffd";

		private const string Label_Frame_Trap = "\ufffd";

		private const string Label_Attr_Light = "光";

		private const string Label_Attr_Dark = "闇";

		private const string Label_Attr_Water = "水";

		private const string Label_Attr_Fire = "炎";

		private const string Label_Attr_Earth = "地";

		private const string Label_Attr_Wind = "風";

		private const string Label_Attr_Divine = "神";

		private const string Label_Tribe_SpellCaster = "魔\ufffd";

		private const string Label_Tribe_Dragon = "ド\ufffd";

		private const string Label_Tribe_Zombie = "アン";

		private const string Label_Tribe_Warrior = "戦";

		private const string Label_Tribe_BeastWarrior = "獣\ufffd";

		private const string Label_Tribe_Beast = "\ufffd";

		private const string Label_Tribe_WingedBeast = "鳥";

		private const string Label_Tribe_Machine = "機";

		private const string Label_Tribe_Fiend = "悪";

		private const string Label_Tribe_Fairy = "天";

		private const string Label_Tribe_Insect = "昆";

		private const string Label_Tribe_Dinosaur = "恐";

		private const string Label_Tribe_Reptile = "爬\ufffd";

		private const string Label_Tribe_Fish = "\ufffd";

		private const string Label_Tribe_SeaSerpent = "海";

		private const string Label_Tribe_Aqua = "\ufffd";

		private const string Label_Tribe_Pyro = "\ufffd";

		private const string Label_Tribe_Thunder = "\ufffd";

		private const string Label_Tribe_Rock = "岩";

		private const string Label_Tribe_Plant = "植";

		private const string Label_Tribe_Psychic = "サイ";

		private const string Label_Tribe_Wyrm = "幻";

		private const string Label_Tribe_Cyberse = "サイ";

		private const string Label_Tribe_DivineBeast = "幻\ufffd";

		private const string Label_Lvl0 = "0";

		private const string Label_Lvl1 = "1";

		private const string Label_Lvl2 = "2";

		private const string Label_Lvl3 = "3";

		private const string Label_Lvl4 = "4";

		private const string Label_Lvl5 = "5";

		private const string Label_Lvl6 = "6";

		private const string Label_Lvl7 = "7";

		private const string Label_Lvl8 = "8";

		private const string Label_Lvl9 = "9";

		private const string Label_Lvl10 = "10";

		private const string Label_Lvl11 = "11";

		private const string Label_Lvl12 = "12";

		private const string Label_Lvl13 = "13";

		private const string Label_Spell_Normal = "通\ufffd";

		private const string Label_Spell_Field = "フィ\ufffd";

		private const string Label_Spell_Equip = "装\ufffd";

		private const string Label_Spell_Continuous = "永\ufffd";

		private const string Label_Spell_QuickPlay = "速\ufffd";

		private const string Label_Spell_Ritual = "儀\ufffd";

		private const string Label_Trap_Normal = "通";

		private const string Label_Trap_Continuous = "永";

		private const string Label_Trap_Counter = "カウ";

		private const string Label_Rarity_Normal = "N";

		private const string Label_Rarity_Rare = "R";

		private const string Label_Rarity_SuperRare = "SR";

		private const string Label_Rarity_UltraRare = "UR";

		private const string Label_Style_Normal = "Normal";

		private const string Label_Style_Shine = "Shine";

		private const string Label_Style_Royal = "Royal";

		private const string Label_Limit_0 = "禁\ufffd";

		private const string Label_Limit_1 = "制\ufffd";

		private const string Label_Limit_2 = "準制";

		private const string Label_Limit_3 = "無制";

		private const string Label_Cutin_Exist = "有\ufffd";

		private const string Label_Cutin_NotExist = "無\ufffd";

		private const string Label_Ability_Toon = "トゥ\ufffd";

		private const string Label_Ability_Dual = "デュ\ufffd";

		private const string Label_Ability_Union = "ユニ\ufffd";

		private const string Label_Ability_Spirit = "スピ\ufffd";

		private const string Label_Ability_Tuner = "チュ\ufffd";

		private const string Label_Ability_Reverse = "リバ\ufffd";

		private const string Label_Ability_SpSummon = "特殊\ufffd";

		private SearchFilter.Setting m_setting;

		private static Dictionary<string, SearchFilter.Setting.FRAME> frameSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.ATTR> attrSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.TRIBE> tribeSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.LEVEL> lvlSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.NOTMONSTER> spellSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.NOTMONSTER> trapSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.RARITY> raritySettingTbl;

		private static Dictionary<string, SearchFilter.Setting.STYLE> styleSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.LIMIT> limitSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.CUTIN> cutinSettingTbl;

		private static Dictionary<string, SearchFilter.Setting.ABILITY> abilitySettingTbl;

		private static Dictionary<string, string> frameButtonLabelTbl;

		private static Dictionary<string, Content.Attribute> attrButtonLabelTbl;

		private static Dictionary<string, Content.Type> tribeButtonLabelTbl;

		private static Dictionary<string, Content.Icon> spellButtonLabelTbl;

		private static Dictionary<string, Content.Icon> trapButtonLabelTbl;

		private static Dictionary<string, string> rarityButtonLabelTbl;

		private static Dictionary<string, string> styleButtonLabelTbl;

		private static Dictionary<string, string> limitButtonLabelTbl;

		private static Dictionary<string, string> cutinButtonLabelTbl;

		private static Dictionary<string, string> abilityButtonLabelTbl;

		private static Dictionary<string, string> toggleLabelTbl;

		private const int numToggles = 84;

		private List<FilterToggle> toggles;

		private Dictionary<FilterGroupType, SelectionItem> groupTopItem;

		private ExtendedScrollRect m_FilterScroll;

		private bool contentScrollAnimation;

		private Vector2 targetContentPosition;

		private static SearchFilter.Setting deckEditSetting;

		private static List<FilterGroupType> deckEditFilterGroupTypes;

		private readonly Dictionary<FilterGroupType, int> groupSize;

		private readonly int spacing;

		private readonly int spacingMobile;

		private readonly int paddingTop;

		private readonly int paddingBottom;

		private readonly Dictionary<FilterGroupType, int> groupSizeMobile;

		private const string k_ELabelCancelButton = "CancelButton";

		private const string k_ELabelFilterButton = "FilterButton";

		private const string k_ELabelResetButton = "ResetButton";

		private const string k_ELabelCancelShortcut = "CancelShortcut";

		private const string k_ELabelFilterShortcut = "FilterShortcut";

		private const string k_ELabelResetShortcut = "ResetShortcut";

		private const string k_ELabelResetShortcutMain = "ResetShortcut/ShortcutIcon0";

		private const string k_ELabelResetShortcutSub = "ResetShortcut/ShortcutIcon1";

		private SelectionButton m_CancelButton;

		private SelectionButton m_FilterButton;

		private SelectionButton m_ResetButton;

		private const string k_ELabelFilterGroupFrame = "Frame";

		private const string k_ELabelFilterGroupAttribute = "Attribute";

		private const string k_ELabelFilterGroupSpellTrap = "SpellTrap";

		private const string k_ELabelFilterGroupTribe = "Tribe";

		private const string k_ELabelFilterGroupLevel = "Level";

		private const string k_ELabelFilterGroupRarity = "Rarity";

		private const string k_ELabelFilterGroupAbility = "Ability";

		private const string k_ELabelFilterGroupStyle = "Style";

		private const string k_ELabelFilterGroupLimit = "Limit";

		private const string k_ELabelFilterGroupCutin = "Cutin";

		private List<FilterGroupType> m_FilterGroupTypes;

		public SearchFilter.Setting m_DefaultSetting;

		private static Content m_cci => null;

		public static void Open(SearchFilter.Setting setting, Action<SearchFilter.Setting> callback = null)
		{
		}

		public static void Open(SearchFilter.Setting setting, SearchFilter.Setting defaultSetting, List<FilterGroupType> filterGroupTypes, Action<SearchFilter.Setting> callback = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void InitializeDefault()
		{
		}

		private void InitializeFooter()
		{
		}

		private IEnumerator InitializeFileterMenu()
		{
			return null;
		}

		private void setFilterFrame(FilterToggle ft)
		{
		}

		private void setFilterAttr(FilterToggle ft)
		{
		}

		private void setFilterTribe(FilterToggle ft)
		{
		}

		private void setFilterLevel(FilterToggle ft)
		{
		}

		private void setFilterSpell(FilterToggle ft)
		{
		}

		private void setFilterTrap(FilterToggle ft)
		{
		}

		private void setFilterRarity(FilterToggle ft)
		{
		}

		private void setFilterAbility(FilterToggle ft)
		{
		}

		private void setFilterStyle(FilterToggle ft)
		{
		}

		private void setFilterLimit(FilterToggle ft)
		{
		}

		private void setFilterCutin(FilterToggle ft)
		{
		}

		private void OnReset()
		{
		}

		private void SelectNextGroupTop(FilterGroupType filterGroup)
		{
		}

		private void SelectPrevGroupTop(FilterGroupType filterGroup)
		{
		}

		private void SetupScrollToSelectingItem(SelectionItem item, RectTransform itemRootRect)
		{
		}

		private void InitPadTransition(SelectionButton button, RectTransform buttonArea, FilterGroupType type)
		{
		}

		private void Update()
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		public FilterDialog()
		{
			//((SelectDialogViewControllerBase<, , , >)(object)this)._002Ector();
		}
	}
}
