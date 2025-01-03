using System.Collections;

namespace YgomSystem.ResourceSystem
{
	public class NetworkLoader : BaseLoader
	{
		public ResourceManager.ProgressHandler progressHandler;

		public ResourceManager.RetryHandler retryHandler;

		public float HttpTimeOut;

		public override bool DisablePathForErrorHandler => false;

		public override void Load(Resource res, uint crc)
		{
		}

		public override IEnumerator LoadAsync(Resource res, uint key)
		{
			return null;
		}
	}
}
