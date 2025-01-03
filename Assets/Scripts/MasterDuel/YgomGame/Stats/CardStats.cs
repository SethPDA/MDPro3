using System.Collections;
using System.Collections.Generic;

namespace YgomGame.Stats
{
	public class CardStats
	{
		private static CardStats s_instance;

		private const string CARD_STATS_DATA_PATH = "Stats/CardStats";

		public static CardStats Instance => null;

		public static void Create()
		{
		}

		public static void Destroy()
		{
		}

		public static void Reload()
		{
		}

		public void Initialize()
		{
		}

		public void Terminate()
		{
		}

		private IEnumerator LoadStatsDataAsync()
		{
			return null;
		}

		public static bool IsAvailable()
		{
			return false;
		}

		public static bool IsUseRawData()
		{
			return false;
		}

		public static string GetItemString(int Item)
		{
			return null;
		}

		public static string GetItemUnitString(int Item, double fValue)
		{
			return null;
		}

		public static string GetItemSortType(int Item)
		{
			return null;
		}

		public static List<double> GetItemUnitThreshold(int Item)
		{
			return null;
		}

		public static List<CardStatsData> GetCardStatsData(int mrk)
		{
			return null;
		}

		public static void DebugString(int mrk)
		{
		}
	}
}
