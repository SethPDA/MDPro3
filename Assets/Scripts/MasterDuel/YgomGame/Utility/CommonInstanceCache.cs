using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Utility
{
	public class CommonInstanceCache : MonoBehaviour
	{
		internal const string k_HelpMapping = "HelpMapping";

		private static CommonInstanceCache s_Instance;

		private Dictionary<string, object> m_CacheMap;

		private static CommonInstanceCache instance => null;

		public static T GetCache<T>(string key) where T : class
		{
			return null;
		}

		public static object GetCache(string key)
		{
			return null;
		}

		public static void AssignCache(string key, object value)
		{
		}
	}
}
