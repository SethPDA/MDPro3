using System;
using System.Collections.Generic;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class YgomUrlScheme
	{
		private class DelayCallUrl
		{
			public string delayLabel;

			public float delayTime;

			public long delayUnixTime;

			public object url;

			public bool inputMask;

			public DelayCallUrl(object url_, bool imask, float time, long utime, string label)
			{
			}
		}

		private struct SchemeInfo
		{
			public string url;

			public object option;

			public object context;

			//public SchemeInfo(string arg_url, object arg_option = null, object arg_context = null)
			//{
			//}
		}

		private static List<DelayCallUrl> delayCall;

		private static Dictionary<string, Action<Dictionary<string, object>>> callSchemeFuncs;

		private static Dictionary<string, int> callSchemeRefCounter;

		private const string URLQUEPATH = "UrlQueue";

		private static Dictionary<string, string> transitionCall;

		public static string NOTIFICATIONPATH;

		private static List<SchemeInfo> keepSchemeContainer;

		public static void CleanupYgomScheme()
		{
		}

		public static void SetDelayUrlOpen(object url, bool inputMask, float time, long utime, string label)
		{
		}

		public static void DelayUpdate()
		{
		}

		private static void transitionHandle(ViewController.TransitionType tt, ViewController vc, ViewController preVc)
		{
		}

		private static void transitionHandleClear()
		{
		}

		public static void RegistYgomArgCommand()
		{
		}

		public static void RegistYgomScheme()
		{
		}

		private static bool isScheme(ref string url, string scheme)
		{
			return false;
		}

		public static Handle CallWabApi(string url, object option = null, string schemename = "webapi://", float timeout = 30f)
		{
			return null;
		}

		public static Handle CallWabApiWithClientWork(string url, object option = null, string schemename = "webapicw://", float timeout = 30f)
		{
			return null;
		}

		public static void ResponseNotificator(object value)
		{
		}

		public static void RegisterCallSchemeFunction(string callName, Action<Dictionary<string, object>> act)
		{
		}

		public static void UnregisterCallSchemeFunction(string callName)
		{
		}

		public static bool IsCallSchemeFunction(string callName)
		{
			return false;
		}

		public static void AddKeepScheme(string url, object option = null, object context = null)
		{
		}

		public static void ClearKeepScheme()
		{
		}

		public static void OpenKeepScheme()
		{
		}

		private static bool checkMultiPlay()
		{
			return false;
		}

		private static void parsePlayModeMenuUrl(string url, Action<Dictionary<string, object>> homepushAction)
		{
		}
	}
}
