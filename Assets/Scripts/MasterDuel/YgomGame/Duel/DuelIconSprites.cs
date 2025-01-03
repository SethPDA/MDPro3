using System;
using UnityEngine;
using YgomGame.Card;

namespace YgomGame.Duel
{
	public class DuelIconSprites : CardIconSprites
	{
		[Serializable]
		public struct PositionIconable
		{
			public bool player;

			public int position;

			public Sprite icon;

			//public PositionIconable(bool _player, int _position, Sprite _icon)
			//{
			//}
		}

		[Serializable]
		public struct CounterIconTable
		{
			public Engine.CounterType counter;

			public Sprite icon;

			//private CounterIconTable(Engine.CounterType _counter, Sprite _icon)
			//{
			//}
		}

		[Serializable]
		public struct DuelLogIconTable
		{
			public LOGACTIONTYPE type;

			public Sprite icon;

			//private DuelLogIconTable(LOGACTIONTYPE _type, Sprite _icon)
			//{
			//}
		}

		[Serializable]
		public struct NumIconTable
		{
			public int number;

			public Sprite icon;

			//private NumIconTable(int _number, Sprite _icon)
			//{
			//}
		}

		[Serializable]
		public struct BattleStepIcon
		{
			public Engine.StepType step;

			public Sprite icon;
		}

		[Serializable]
		public struct DamageStepIcon
		{
			public Engine.DmgStepType step;

			public Sprite icon;
		}

		[Serializable]
		public struct ListTypeIcon
		{
			public GenericCardListController.ListType type;

			public Sprite icon;
		}

		[Serializable]
		public struct DiceIconTable
		{
			public int dicenum;

			public bool isnear;

			public Sprite sprite;
		}

		[Serializable]
		public struct CoinIconTable
		{
			public bool face;

			public Sprite sprite;
		}

		private static DuelIconSprites m_Instance;

		private const string PATH = "Duel/ScriptableObject/DuelIconObject";

		[SerializeField]
		private Sprite[] circle;

		[SerializeField]
		private PositionIconable[] positionIcons;

		[SerializeField]
		private Sprite iconFieldAreaNear;

		[SerializeField]
		private Sprite iconFieldAreaFar;

		[SerializeField]
		private Sprite iconFieldZone;

		[SerializeField]
		private Sprite iconCheckTiming;

		[SerializeField]
		private Sprite iconTuner;

		[SerializeField]
		private Sprite iconOverlay;

		[SerializeField]
		private Sprite iconCardMoveArrow;

		[SerializeField]
		private Sprite iconAttackArrow;

		[SerializeField]
		private Sprite iconCslGroupBgI;

		[SerializeField]
		private Sprite iconCslGroupBgO;

		[SerializeField]
		private Sprite iconCslGroupBgL;

		[SerializeField]
		private Sprite iconCslGroupBgR;

		[SerializeField]
		private Sprite iconLevel;

		[SerializeField]
		private Sprite iconRank;

		[SerializeField]
		private Sprite iconScale;

		[SerializeField]
		private CounterIconTable[] counterIcons;

		[SerializeField]
		private Sprite disableIcon;

		[SerializeField]
		private Sprite unAttackableIcon;

		[SerializeField]
		private DuelLogIconTable[] duellogIcons;

		[SerializeField]
		private NumIconTable[] numberIcons;

		[SerializeField]
		private NumIconTable[] numberIconsForDuelChain;

		[SerializeField]
		private BattleStepIcon[] battleStepIcons;

		[SerializeField]
		private DamageStepIcon[] damageStepIcons;

		[SerializeField]
		private ListTypeIcon[] listTypeIcon;

		[SerializeField]
		private DiceIconTable[] diceIcons;

		[SerializeField]
		private CoinIconTable[] coinIcons;

		public new static DuelIconSprites instance => null;

		public Sprite GetCircle(bool myself)
		{
			return null;
		}

		public Sprite GetPosIcon(int player, int position)
		{
			return null;
		}

		public Sprite GetLevelIcon()
		{
			return null;
		}

		public Sprite GetRankIcon()
		{
			return null;
		}

		public Sprite GetScaleIcon()
		{
			return null;
		}

		public Sprite GetTunerIcon()
		{
			return null;
		}

		public Sprite GetOverlayIcon()
		{
			return null;
		}

		public Sprite GetFieldAreaIcon(int player)
		{
			return null;
		}

		public Sprite GetFieldZoneIcon()
		{
			return null;
		}

		public Sprite GetCheckTimingIcon()
		{
			return null;
		}

		public Sprite GetArrowIcon(bool isbattlearrow)
		{
			return null;
		}

		public Sprite GetCounterIcon(Engine.CounterType counter)
		{
			return null;
		}

		public Sprite GetDiceIcon(int dicenum, bool isnear)
		{
			return null;
		}

		public Sprite GetDuelLogIcon(LOGACTIONTYPE type)
		{
			return null;
		}

		public Sprite GetNumberIcon(int number)
		{
			return null;
		}

		public Sprite GetNumberIconForDuelChain(int number)
		{
			return null;
		}

		public Sprite GetDisableIcon()
		{
			return null;
		}

		public Sprite GetUnAttackableIcon()
		{
			return null;
		}

		public Sprite GetBattleStepIcon(Engine.StepType step)
		{
			return null;
		}

		public Sprite GetDamageStepIcon(Engine.DmgStepType step)
		{
			return null;
		}

		public Sprite GetListTypeIcon(GenericCardListController.ListType type)
		{
			return null;
		}

		public Sprite GetCardSelectionListGroupBg(int index)
		{
			return null;
		}

		public Sprite GetCoinIcon(bool face)
		{
			return null;
		}
	}
}
