using System;
using System.Runtime.CompilerServices;

namespace YgomSystem
{
	public class DebugUtil
	{
		public static void Log(string message)
		{
		}

		public static void LogFormat(string format, params object[] args)
		{
		}

		public static void LogWarning(string message)
		{
		}

		public static void LogError(string message)
		{
		}

		public static void ThreadLog(string message, [CallerMemberName] string member = "")
		{
		}

		public static void ThreadLogWarning(string message, [CallerMemberName] string member = "")
		{
		}

		public static void ThreadLogError(string message, [CallerMemberName] string member = "")
		{
		}

		private static string makeThreadLogString(string member, string message)
		{
			return null;
		}

		public static void TimeStampLog(string message)
		{
		}

		public static void Assert(bool condition)
		{
		}

		public static void Assert(bool condition, string message)
		{
		}

		public static void Assert(bool condition, Func<string> getMessage)
		{
		}

		public static void PrintObj(object obj, string label = "")
		{
		}
	}
}
