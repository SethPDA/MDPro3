using System;
using System.Collections;

namespace YgomSystem.ResourceSystem
{
	public class BinaryLoader : BaseLoader
	{
		public override void Load(Resource res, uint crc)
		{
		}

		public override IEnumerator LoadAsync(Resource res, uint key)
		{
			return null;
		}

		protected virtual byte[] LoadFromFile(string path)
		{
			return null;
		}

		protected virtual string GetNativePath(string path)
		{
			return null;
		}

		protected virtual IEnumerator LoadFromStreamFile(string path, Action<byte[]> callback)
		{
			return null;
		}
	}
}
