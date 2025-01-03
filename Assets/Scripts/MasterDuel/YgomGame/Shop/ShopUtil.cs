using YgomSystem.Network;

namespace YgomGame.Shop
{
	public static class ShopUtil
	{
		private const string k_CardListPoolConfig = "Definition/CardListBrowser/ShopCardPoolConfig";

		private const string k_CardListPickupConfig = "Definition/CardListBrowser/ShopCardPickupConfig";

		public static bool IsPayItemSpecial(bool isPeriod, int itemCategory, int itemId)
		{
			return false;
		}

		public static int GetPayItemHave(bool isPeriod, int itemCategory, int itemId)
		{
			return 0;
		}

		public static long GetPayItemLimitDateTs(bool isPeriod, int itemCategory, int itemId)
		{
			return 0L;
		}

		public static string GetPayItemLimitDateStr(bool isPeriod, int itemCategory, int itemId)
		{
			return null;
		}

		public static bool CheckHandlingShopSectionMainte(Handle h, bool skipHandling = false)
		{
			return false;
		}

		public static void CheckFocusBGM()
		{
		}

		public static void AbortShop()
		{
		}

		public static void OpenPoolCardListBrowser(int normalCardPoolId)
		{
		}

		public static void OpenPickupCardListBrowser(int pickupCardPoolId)
		{
		}

		private static void OpenCardListBrowser(int cardPoolId, string configPath)
		{
		}
	}
}
