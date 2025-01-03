namespace YgomGame
{
	public static class DeepLinkInfo
	{
		public static bool isAvailable => false;

		public static bool SetUrl(string url)
		{
			return false;
		}

		public static string GetUrl()
		{
			return null;
		}

		public static string GetDestination()
		{
			return null;
		}

		public static void Clear()
		{
		}

		public static void Abort()
		{
		}
	}
}
