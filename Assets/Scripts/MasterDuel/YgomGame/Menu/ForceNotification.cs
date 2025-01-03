using System;

namespace YgomGame.Menu
{
	public class ForceNotification
	{
		private const string FORCE_NOTIFY_SAVE_PATH = "LastForceNotify";

		private static DateTime lastDispDateCache;

		private static void Open(Action onClosed)
		{
		}

		public static void OpenWithSaveLastDate(Action onClosed)
		{
		}

		public static bool IsDispForceNotification()
		{
			return false;
		}

		public static void RemoveLastDispDate()
		{
		}

		public static void InitLastDispDate()
		{
		}

		private static bool EqualCurrentDate(DateTime targetDate)
		{
			return false;
		}

		private static void SaveLastDate()
		{
		}
	}
}
