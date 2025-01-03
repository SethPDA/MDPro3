using System;
using System.Collections.Generic;

namespace YgomSystem.Utility
{
	public class UrlScheme
	{
		private static SortedDictionary<string, Action<string, object, object>> schemeFuncs;

		private static Dictionary<string, Func<string, object>> argsCommands;

		public static bool fatalAbort;

		public static string LatestUrl;

		public static Dictionary<string, object> GetArgs(string url)
		{
			return null;
		}

		public static bool SplitArgs(string url, out string baseUrl, out Dictionary<string, object> args)
		{
			baseUrl = null;
			args = null;
			return false;
		}

		public static bool OpenList(object urls, object option = null, object context = null)
		{
			return false;
		}

		public static string ProcRelativePath(string path)
		{
			return null;
		}

		public static bool SplitUrl(string url, out string scheme, out string host, out string option)
		{
			scheme = null;
			host = null;
			option = null;
			return false;
		}

		public static (bool, string[], Dictionary<string, object>) AnalyzeUrl(string url)
		{
			return default((bool, string[], Dictionary<string, object>));
		}

		public static void AddScheme(string url, Action<string, object, object> act)
		{
		}

		public static void AddArgsCommand(string cmd, Func<string, object> act)
		{
		}

		public static object ExecuteArgsCommand(string val)
		{
			return null;
		}

		public static bool IsUrlScheme(string url)
		{
			return false;
		}

		public static bool Open(string url, object option = null, object context = null)
		{
			return false;
		}

		private static int GetUrlEndTokenIndex(string str, char endToken, int startIndex = 0)
		{
			return 0;
		}
	}
}
