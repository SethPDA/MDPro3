using System.Collections;
using System.Collections.Generic;
using YgomGame.Card;

namespace YgomGame.Deck
{
	public static class SearchFilter
	{
		public class Setting
		{
			public enum OPTIONS
			{
				NotOwned = 0,
				SIZE = 1
			}

			public enum FRAME
			{
				Normal = 0,
				Effect = 1,
				Fusion = 2,
				Ritual = 3,
				Synchro = 4,
				Xyz = 5,
				Pendulum = 6,
				Link = 7,
				Magic = 8,
				Trap = 9,
				SIZE = 10
			}

			public enum ATTR
			{
				Light = 0,
				Dark = 1,
				Water = 2,
				Fire = 3,
				Earth = 4,
				Wind = 5,
				Divine = 6,
				SIZE = 7
			}

			public enum TRIBE
			{
				SpellCaster = 0,
				Dragon = 1,
				Zombie = 2,
				Warrior = 3,
				BeastWarrior = 4,
				Beast = 5,
				WingedBeast = 6,
				Machine = 7,
				Fiend = 8,
				Fairy = 9,
				Insect = 10,
				Dinosaur = 11,
				Reptile = 12,
				Fish = 13,
				SeaSerpent = 14,
				Aqua = 15,
				Pyro = 16,
				Thunder = 17,
				Rock = 18,
				Plant = 19,
				Psychic = 20,
				Wyrm = 21,
				Cyberse = 22,
				DivineBeast = 23,
				SIZE = 24
			}

			public enum LEVEL
			{
				Lvl0 = 0,
				Lvl1 = 1,
				Lvl2 = 2,
				Lvl3 = 3,
				Lvl4 = 4,
				Lvl5 = 5,
				Lvl6 = 6,
				Lvl7 = 7,
				Lvl8 = 8,
				Lvl9 = 9,
				Lvl10 = 10,
				Lvl11 = 11,
				Lvl12 = 12,
				Lvl13 = 13,
				SIZE = 14
			}

			public enum NOTMONSTER
			{
				NormalSpell = 0,
				FieldSpell = 1,
				EquipSpell = 2,
				ContinuousSpell = 3,
				QuickPlaySpell = 4,
				RitualSpell = 5,
				NormalTrap = 6,
				ContinuousTrap = 7,
				CounterTrap = 8,
				SIZE = 9
			}

			public enum RARITY
			{
				Normal = 0,
				Rare = 1,
				SuperRare = 2,
				UltraRare = 3,
				SIZE = 4
			}

			public enum STYLE
			{
				Normal = 0,
				Shine = 1,
				Royal = 2,
				SIZE = 3
			}

			public enum LIMIT
			{
				Limit0 = 0,
				Limit1 = 1,
				Limit2 = 2,
				Limit3 = 3,
				SIZE = 4
			}

			public enum CUTIN
			{
				Exist = 0,
				NotExist = 1,
				SIZE = 2
			}

			public enum ABILITY
			{
				Toon = 0,
				Dual = 1,
				Union = 2,
				Spirit = 3,
				Tuner = 4,
				Reverse = 5,
				SpSummon = 6,
				SIZE = 7
			}

			public enum REGULATION
			{
				Forbidden = 0,
				Limited = 1,
				SemiLimited = 2,
				None = 3,
				SIZE = 4
			}

			public BitArray Options;

			public BitArray Frame;

			public BitArray Attr;

			public BitArray Tribe;

			public BitArray Level;

			public BitArray NotMonster;

			public BitArray Rarity;

			public BitArray Style;

			public BitArray Limit;

			public BitArray Cutin;

			public BitArray Ability;

			public BitArray Regulation;

			public bool IsFiltered()
			{
				return false;
			}

			private static bool checkAny(BitArray ba)
			{
				return false;
			}

			public BitArray GetFrameSetting()
			{
				return null;
			}

			public BitArray GetAttrSetting()
			{
				return null;
			}

			public BitArray GetTribeSetting()
			{
				return null;
			}

			public BitArray GetLevel()
			{
				return null;
			}

			public BitArray GetNotMonster()
			{
				return null;
			}

			public BitArray GetRarity()
			{
				return null;
			}

			public BitArray GetStyle()
			{
				return null;
			}

			public BitArray GetLimit()
			{
				return null;
			}

			public BitArray GetCutin()
			{
				return null;
			}

			public BitArray GetAbility()
			{
				return null;
			}

			public BitArray GetRegulation()
			{
				return null;
			}

			public BitArray GetOption()
			{
				return null;
			}

			public void SetRarityFilter(RARITY val, bool b)
			{
			}

			public void SetStyleFilter(STYLE val, bool b)
			{
			}

			public void SetLimitFilter(LIMIT val, bool b)
			{
			}

			public void SetCutinFilter(CUTIN val, bool b)
			{
			}

			public void SetAbilityFilter(ABILITY val, bool b)
			{
			}

			public void SetFrameFilter(FRAME val, bool b)
			{
			}

			public void SetNotMonsterFilter(NOTMONSTER val, bool b)
			{
			}

			public void SetAttrFilter(ATTR val, bool b)
			{
			}

			public void SetTribeFilter(TRIBE val, bool b)
			{
			}

			public void SetLevelFilter(LEVEL val, bool b)
			{
			}

			public void SetOptionSetting(OPTIONS val, bool b)
			{
			}

			public Setting Clone()
			{
				return null;
			}
		}

		private enum AbilityMask
		{
			Toon = 1,
			Dual = 2,
			Union = 4,
			Spirit = 8,
			Tuner = 0x10,
			Reverse = 0x20,
			SpSummon = 0x40
		}

		public static int nowRegulationID;

		private static string[] searchKeywords;

		private static Dictionary<Content.Frame, Setting.FRAME> frameTbl;

		private static Dictionary<Content.Frame, Setting.FRAME> pendulumFrameTbl;

		private static Dictionary<Content.Attribute, Setting.ATTR> attrTbl;

		private static Dictionary<Content.Type, Setting.TRIBE> tribeTbl;

		private static Dictionary<int, Setting.LEVEL> levelTbl;

		private static Dictionary<Content.Icon, Setting.NOTMONSTER> spellTbl;

		private static Dictionary<Content.Icon, Setting.NOTMONSTER> trapTbl;

		private static Dictionary<CardCollectionInfo.Rarity, Setting.RARITY> rarityTbl;

		private static Dictionary<CardCollectionInfo.Premium, Setting.STYLE> styleTbl;

		private static Dictionary<int, Setting.LIMIT> limitTbl;

		private static Dictionary<bool, Setting.CUTIN> cutinTbl;

		private static Dictionary<AbilityMask, Setting.ABILITY> abilityTbl;

		private static Dictionary<CardCollectionInfo.Regulation, Setting.REGULATION> regulationTbl;

		private const int HAN_SPACE = 32;

		private const int HAN_YEN = 92;

		private const int HAN_ALPHA_START = 33;

		private const int HAN_ALPHA_END = 126;

		private const int ZEN_SPACE = 12288;

		private const int ZEN_YEN = 65509;

		private const int ZEN_ALPHA_START = 65281;

		private const int ZEN_ALPHA_OFFSET = 65248;

		private const int HIRA_START = 12352;

		private const int HIRA_END = 12442;

		private const int KATA_START = 12448;

		private const int KATA_OFFSET = 96;

		private const int ZAL_START = 65313;

		private const int ZAL_END = 65338;

		private const int ZAS_START = 65345;

		private const int ZAS_OFFSET = 32;

		private static void getSetting(Setting setting, out BitArray frame, out BitArray attr, out BitArray tribe, out BitArray level, out BitArray notmonster, out BitArray rarity, out BitArray style, out BitArray limit, out BitArray cutin, out BitArray ability, out BitArray regulation, out BitArray option)
		{
			frame = null;
			attr = null;
			tribe = null;
			level = null;
			notmonster = null;
			rarity = null;
			style = null;
			limit = null;
			cutin = null;
			ability = null;
			regulation = null;
			option = null;
		}

		private static void getRawSetting(Setting setting, out BitArray frame, out BitArray attr, out BitArray tribe, out BitArray level, out BitArray notmonster, out BitArray rarity, out BitArray style, out BitArray limit, out BitArray cutin, out BitArray ability, out BitArray regulation, out BitArray option)
		{
			frame = null;
			attr = null;
			tribe = null;
			level = null;
			notmonster = null;
			rarity = null;
			style = null;
			limit = null;
			cutin = null;
			ability = null;
			regulation = null;
			option = null;
		}

		public static List<CardBaseData> Filter(List<CardBaseData> list, Setting setting, string keyword, bool includeDesc = true)
		{
			return null;
		}

		private static bool predicate(int cardID, BitArray frame, BitArray attr, BitArray tribe, BitArray level, BitArray notmonster, BitArray rarity, BitArray style, BitArray limit, BitArray cutin, BitArray ability, BitArray regulation, BitArray option, int rareID = -1, int styleID = -1, bool includeDesc = true)
		{
			return false;
		}

		private static bool checkEmpty(BitArray ba)
		{
			return false;
		}

		private static bool checkFrame(Content.Frame val, BitArray ba)
		{
			return false;
		}

		private static bool checkAttr(Content.Attribute val, BitArray ba)
		{
			return false;
		}

		private static bool checkTribe(Content.Type val, BitArray ba)
		{
			return false;
		}

		private static bool checkLevel(int val, BitArray ba)
		{
			return false;
		}

		private static bool checkSpellIcon(Content.Icon val, BitArray ba)
		{
			return false;
		}

		private static bool checkTrapIcon(Content.Icon val, BitArray ba)
		{
			return false;
		}

		private static bool checkRarity(CardCollectionInfo.Rarity val, BitArray ba)
		{
			return false;
		}

		private static bool checkStyle(CardCollectionInfo.Premium val, BitArray ba)
		{
			return false;
		}

		private static bool checkLimit(int val, BitArray ba)
		{
			return false;
		}

		private static bool checkCutin(bool val, BitArray ba)
		{
			return false;
		}

		private static bool checkAbility(AbilityMask val, BitArray ba)
		{
			return false;
		}

		private static bool checkRegulation(CardCollectionInfo.Regulation val, BitArray ba)
		{
			return false;
		}

		private static void checkCollectionSetting(string keywordsString)
		{
		}

		private static bool checkCollection(int mrk, bool includeDesc = true)
		{
			return false;
		}

		public static bool checkCollectionIDList(List<int> mrkList, string keywordsString, List<int> hitList, bool includeDesc = true)
		{
			return false;
		}

		private static string convertSearchText(string src)
		{
			return null;
		}

		private static string toZenkaku(string src)
		{
			return null;
		}

		private static string toKatakana_Komoji(string src)
		{
			return null;
		}
	}
}
