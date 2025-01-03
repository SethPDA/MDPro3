using System.Collections;
using YgomSystem.Utility;

namespace YgomSystem.Network
{
	public class ProtocolHttp : Protocol
	{
		private bool appQuitAbort;

		private int jobCount;

		public static void GetServerDefaultUrl(RuntimeEnvironment.ServerType type, out string url, out string pollingUrl)
		{
			url = null;
			pollingUrl = null;
		}

		public override void ApplicationQuitAbort()
		{
		}

		public override int GetJobCount()
		{
			return 0;
		}

		public override IEnumerator Exec(NetworkMain.RequestStructure data)
		{
			return null;
		}

		private void AbortRequest(NetworkMain.RequestStructure chaindata, Status states = Status.FAILED)
		{
		}

		private static bool isRebootableCode(int code)
		{
			return false;
		}

		private static void postProcessRequestData(NetworkMain.RequestStructure data)
		{
		}
	}
}
