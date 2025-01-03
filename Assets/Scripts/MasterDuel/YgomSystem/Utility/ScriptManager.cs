using System;
using System.Collections.Generic;

namespace YgomSystem.Utility
{
	public class ScriptManager
	{
		public interface IScriptContextOwner
		{
			IScriptContext GetScriptContext(string lang);
		}

		public interface IScriptContext
		{
			void Exec(string code);
		}

		private static SortedDictionary<string, Func<object, IScriptContext>> scriptctxgen;

		private static SortedDictionary<string, IScriptContext> globalctx;

		public static void AddScript(string lang, Func<object, IScriptContext> ctxgen)
		{
		}

		public static void ResetGlobalContext()
		{
		}

		public static IScriptContext CreateContext(string lang, object ctx)
		{
			return null;
		}

		public static string LoadImmediateText(string url)
		{
			return null;
		}

		public static void ExecUrlScript(string url, object ctx)
		{
		}

		public static IScriptContext GetGlobalContext(string lang)
		{
			return null;
		}

		public static void ExecLoadScript(string lang, string srcurl, object ctx)
		{
		}

		public static void ExecScript(string lang, string code, object ctx)
		{
		}
	}
}
