using System.Collections;
using System.Collections.Generic;

namespace YgomSystem.Network
{
	public class ProtocolHttpDeckExt : Protocol
	{
		private bool appQuitAbort;

		private int jobCount;

		private static Dictionary<string, object> GetUrl(string cmd)
		{
			return null;
		}

		private static Dictionary<string, object> GetUrls()
		{
			return null;
		}

		public static bool ContainsUrl(string cmd)
		{
			return false;
		}

		public static string GetCommandName(string cmd)
		{
			return null;
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
	}
}
