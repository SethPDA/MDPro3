using System.Collections.Generic;
using YgomGame.Card;

namespace YgomGame.Deck
{
	public static class CardData
	{
		public enum INFOKIND
		{
			Monster = 0,
			Spell = 1,
			Trap = 2,
			ExMon = 3,
			Error = 4
		}

		private static int refCount;

		private static bool created;

		private static List<int> allCardList;

		private static bool allCardListReq;

		public static bool IsValid => false;

		public static bool IsReady => false;

		public static void AddRef()
		{
		}

		public static void Release()
		{
		}

		public static Content.Frame GetFrame(int mrk)
		{
			return default(Content.Frame);
		}

		public static Content.Attribute GetAttr(int mrk)
		{
			return default(Content.Attribute);
		}

		public static Content.Type GetType(int mrk)
		{
			return default(Content.Type);
		}

		public static int GetStar(int mrk)
		{
			return 0;
		}

		public static Content.Icon GetIcon(int mrk)
		{
			return default(Content.Icon);
		}

		public static int GetOriginalID2(int mrk)
		{
			return 0;
		}

		public static bool IsMainDeck(int mrk)
		{
			return false;
		}

		public static bool IsMainDeck(Content.Frame f, int mrk = -1)
		{
			return false;
		}

		public static bool IsMonster(int mrk)
		{
			return false;
		}

		public static bool IsMonster(Content.Frame f, int mrk = -1)
		{
			return false;
		}

		public static bool HasLevel(int mrk)
		{
			return false;
		}

		public static bool HasLevel(Content.Frame f, int mrk = -1)
		{
			return false;
		}

		public static bool IsValidCard(int mrk)
		{
			return false;
		}

		public static INFOKIND GetInfoKind(int mrk)
		{
			return default(INFOKIND);
		}

		public static INFOKIND GetInfoKind(Content.Frame f, int mrk = -1)
		{
			return default(INFOKIND);
		}

		public static List<int> GetAllCardList()
		{
			return null;
		}
	}
}
