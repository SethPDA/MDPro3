using System.Collections.Generic;
using YgomGame.Card;

namespace YgomGame.Duel
{
	public class EngineApiUtil
	{
		public struct Place
		{
			public int player;

			public int position;

			public int index;

			//public Place(int player, int position, int index)
			//{
			//}
		}

		public const int uniqueIdStart = 1;

		public static CardCollectionInfo.Regulation GetRegulation(int cardId)
		{
			return default(CardCollectionInfo.Regulation);
		}

		public static CardCollectionInfo.Regulation GetRegulation(int cardId, int regid)
		{
			return default(CardCollectionInfo.Regulation);
		}

		public static bool GetCardRealFace(int player, int position, int index)
		{
			return false;
		}

		public static bool GetCardFace(int player, int position, int index)
		{
			return false;
		}

		public static bool IsHandOpen(int player, bool defaultValue = false)
		{
			return false;
		}

		public static bool IsFieldPosition(int position)
		{
			return false;
		}

		public static bool IsMonsterPosition(int position)
		{
			return false;
		}

		public static bool IsMainMonsterPosition(int position)
		{
			return false;
		}

		public static bool IsExMonsterPosition(int position)
		{
			return false;
		}

		public static bool IsPendulumPosition(int position)
		{
			return false;
		}

		public static bool IsMagicPosition(int position, bool includeField = false)
		{
			return false;
		}

		public static bool IsXyzMaterialPosition(int position, int index)
		{
			return false;
		}

		public static bool IsCardKnown(int player, int position, int index, bool face)
		{
			return false;
		}

		public static bool IsCardKnown(int player, int position, int index)
		{
			return false;
		}

		public static bool IsCardKnown(int uniqueID)
		{
			return false;
		}

		public static bool IsCardKnown(Engine.CardStatus status)
		{
			return false;
		}

		public static bool IsMagicOrTrap(int cardID)
		{
			return false;
		}

		public static bool IsMagicOrTrapByUniqueID(int uniqueID)
		{
			return false;
		}

		public static ushort ToCardPos(int player, int position, int index)
		{
			return 0;
		}

		public static (int, int, int) FromCardPos(ushort cardPos)
		{
			return default((int, int, int));
		}

		public static bool IsInsight(int player, int position, int index)
		{
			return false;
		}

		public static bool IsInsight(Engine.CardStatus status)
		{
			return false;
		}

		public static (int, int) BreakLong(int param)
		{
			return default((int, int));
		}

		public static (int, int) BreakWord(int param)
		{
			return default((int, int));
		}

		public static bool GetCardExist(int player, int position)
		{
			return false;
		}

		public static bool IsMonsterNow(int position, int locate)
		{
			return false;
		}

		public static int GetCardUniqueID(int player, int position, int index)
		{
			return 0;
		}

		public static List<Place> GetAttackableMonsterPlaces()
		{
			return null;
		}

		public static bool IsAnythingCanDo()
		{
			return false;
		}

		public static bool IsAnyCommand(int playerid)
		{
			return false;
		}

		public static uint RemoveNoneDuelCommandFlag(uint commandMask)
		{
			return 0u;
		}

		public static uint GetCommandMaskRemoveNoneDuelFlag(int player, int position, int index)
		{
			return 0u;
		}

		public static List<Engine.CommandType> GetCommandList(int player, int position, int index)
		{
			return null;
		}

		public static List<Engine.CommandType> GetCommandList(uint commandMask)
		{
			return null;
		}

		public static int GetTargetTopCardIndex(int player, int position, int index)
		{
			return 0;
		}

		public static bool ContainsAttribute(int bitMask, Engine.ListAttribute attribute)
		{
			return false;
		}

		public static List<Engine.ListAttribute> GetAttributeList(int bitMask)
		{
			return null;
		}
	}
}
