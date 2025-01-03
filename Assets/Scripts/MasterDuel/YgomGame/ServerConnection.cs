using System.Collections;
using YgomSystem.Network;

namespace YgomGame
{
	public static class ServerConnection
	{
		public enum Status
		{
			None = 0,
			Success = 1,
			Maintenance = 2,
			VersionUpRequired = 3,
			Failed = 4
		}

		private static Status m_status;

		private static IEnumerator m_connectCoroutine;

		public static bool isConnecting => false;

		public static Status status => default(Status);

		public static bool isSuccess => false;

		private static Status codeToStatus(ErrorCode code)
		{
			return default(Status);
		}

		private static bool isFatalError(Status st)
		{
			return false;
		}

		private static IEnumerator showFatalErrorDialog()
		{
			return null;
		}

		public static void Reset()
		{
		}

		public static void StartConnect()
		{
		}

		private static IEnumerator connectCoroutine()
		{
			return null;
		}

		private static void timeLog(string msg)
		{
		}
	}
}
