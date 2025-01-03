using System.Collections;

namespace YgomSystem.Network
{
	public abstract class Protocol
	{
		public abstract IEnumerator Exec(NetworkMain.RequestStructure data);

		public abstract void ApplicationQuitAbort();

		public abstract int GetJobCount();
	}
}
