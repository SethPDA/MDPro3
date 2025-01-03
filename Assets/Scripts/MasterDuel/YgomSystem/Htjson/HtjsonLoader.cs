using System;
using System.Collections.Generic;

namespace YgomSystem.Htjson
{
	public class HtjsonLoader
	{
		private static Dictionary<string, object> commonStyles;

		private static Func<string, byte[]> byteloader;

		public static void OverrideByteLoader(Func<string, byte[]> loader)
		{
		}

		public static Dictionary<string, object> GetCommonStyles()
		{
			return null;
		}

		public static object byteToJsonObject(byte[] data)
		{
			return null;
		}

		public static Dictionary<string, object> byteToDictionary(byte[] data)
		{
			return null;
		}

		public static List<object> byteToList(byte[] data)
		{
			return null;
		}

		public static Dictionary<string, object> loadedImmediateResourceDictionary(string path)
		{
			return null;
		}

		public static List<object> loadedImmediateResourceList(string path)
		{
			return null;
		}

		public static object loadedImmediateJson(string url)
		{
			return null;
		}

		public static void loadSchemeUrl(string url, Action<object> loaded, Action failed)
		{
		}
	}
}
