using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Deck
{
	public static class DeckEditUtil
	{
		public enum SelectorPriority
		{
			DeckEditor = 0,
			ActionMenu = 1,
			CardDetail = 2
		}

		private static SortComparer.Sorter deckSorter;

		public static int selectorPriorityBase
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int GetSelectorPriority(int priority)
		{
			return 0;
		}

		public static int GetSelectorPriority(SelectorPriority priority)
		{
			return 0;
		}

		public static void SortCardDataList(List<CardBaseData> list)
		{
		}

		public static void SortCardDataList(List<CardBaseData> list, SortComparer.Sorter sorter)
		{
		}

		public static bool IsDifferentCardList(List<CardBaseData> deckA, List<CardBaseData> deckB)
		{
			return false;
		}
	}
}
