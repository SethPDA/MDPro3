using System.Collections;
using YgomSystem.Network;

namespace YgomGame.Menu
{
	public class PvpMenuUtility
	{
		public static bool IsRetryableMatchingResult(int code)
		{
			return false;
		}

		public static void GetErrorDialogText(PvPCode errorCode, ref string title, ref string msg)
		{
		}

		public static IEnumerator yShowMatchingErrorDialog(PvPCode errorCode)
		{
			return null;
		}

		public static IEnumerator yShowMatchingErrorToast(PvPCode errorCode)
		{
			return null;
		}
	}
}
