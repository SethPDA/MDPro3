using System.Collections.Generic;

namespace YgomSystem.ResourceSystem
{
	public class ResourceExistsConvertData
	{
		private const string kExistsFileName = "ExistsFileList.json";

		private HashSet<string> existsFileList;

		public void Load()
		{
		}

		public bool Exists(string path)
		{
			return false;
		}

		public void Clear()
		{
		}

		private void LoadFromFile()
		{
		}
	}
}
