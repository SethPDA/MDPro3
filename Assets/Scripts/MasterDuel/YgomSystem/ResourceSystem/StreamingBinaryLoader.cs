using System;
using System.Collections;
using System.IO;

namespace YgomSystem.ResourceSystem
{
	public class StreamingBinaryLoader : BinaryLoader
	{
		protected override byte[] LoadFromFile(string path)
		{
			return null;
		}

		protected override string GetNativePath(string path)
		{
			return null;
		}

		protected override IEnumerator LoadFromStreamFile(string path, Action<byte[]> callback)
		{
			return null;
		}

		private static int StreamLoad(Stream readStream, MemoryStream writeStream, int bufsize = 1048576)
		{
			return 0;
		}
	}
}
