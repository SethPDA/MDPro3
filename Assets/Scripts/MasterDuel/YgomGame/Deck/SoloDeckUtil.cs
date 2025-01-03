using System.Collections.Generic;

namespace YgomGame.Deck
{
	public class SoloDeckUtil
	{
		public enum SoloDeckType
		{
			Story = 0,
			NPC = 1
		}

		public static int GetStoryDeckID(int chapterId)
		{
			return 0;
		}

		public static string GetStoryDeckName(int chapterId)
		{
			return null;
		}

		public static string GetStoryDeckDesc(int chapterId)
		{
			return null;
		}

		public static Dictionary<string, object> GetStoryDeck(int chapterId, DeckInfo.DeckType deckType)
		{
			return null;
		}

		public static int GetNPCDeckID(int chapterId)
		{
			return 0;
		}

		public static string GetNPCDeckName(int chapterId)
		{
			return null;
		}

		public static string GetNPCDeckDesc(int chapterId)
		{
			return null;
		}

		public static Dictionary<string, object> GetNPCDeck(int chapterId, DeckInfo.DeckType deckType)
		{
			return null;
		}
	}
}
