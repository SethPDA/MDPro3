using System.Collections.Generic;

namespace YgomSystem.ResourceSystem
{
	public static class StreamAssetList
	{
		private const string kStreamAssetListFileName = "streamAssetList.json";

		private static HashSet<string> assetList;

		static StreamAssetList()
		{
		}

		public static bool IsEnable()
		{
			return false;
		}

		private static void LoadFromFile()
		{
		}

		public static bool Exists(string relativePath)
		{
			return false;
		}

		public static bool ExistsAssetBundle(string relativePath)
		{
			return false;
		}
	}
}
