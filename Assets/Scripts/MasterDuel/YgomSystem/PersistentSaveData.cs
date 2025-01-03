using System.Collections.Generic;

namespace YgomSystem
{
	public static class PersistentSaveData
	{
		public const string SYSTEM_SAVE_PATH = "SteamPersistence.System";

		public const string APP_SAVE_PATH = "SteamPersistence.App";

		public const string CACHE_SAVE_PATH = "SteamPersistence.Cache";

		public static bool ignoreUpdateEvent;

		private static void LogData(Dictionary<string, object> data, string basePath)
		{
		}

		public static Dictionary<string, object> LoadPersistenceSystem()
		{
			return null;
		}

		public static Dictionary<string, object> LoadPersistenceApp()
		{
			return null;
		}

		public static Dictionary<string, object> LoadPersistenceCache()
		{
			return null;
		}

		public static void OnUpdatePersistenceSystem(object obj)
		{
		}

		public static void OnUpdatePersistenceApp(object obj)
		{
		}

		public static void OnUpdatePersistenceCache(object obj)
		{
		}

		private static void saveToFile(Dictionary<string, object> dic, string savePath)
		{
		}

		private static Dictionary<string, object> loadFromFile(string savePath)
		{
			return null;
		}
	}
}
