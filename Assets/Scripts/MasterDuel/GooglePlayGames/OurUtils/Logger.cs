namespace GooglePlayGames.OurUtils
{
	public class Logger
	{
		private static bool debugLogEnabled;

		private static bool warningLogEnabled;

		public static bool DebugLogEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool WarningLogEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void d(string msg)
		{
		}

		public static void w(string msg)
		{
		}

		public static void e(string msg)
		{
		}

		public static string describe(byte[] b)
		{
			return null;
		}

		private static string ToLogMessage(string prefix, string logType, string msg)
		{
			return null;
		}
	}
}
