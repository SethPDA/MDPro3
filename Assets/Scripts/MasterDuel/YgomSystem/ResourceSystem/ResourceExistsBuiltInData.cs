using System.Collections.Generic;

namespace YgomSystem.ResourceSystem
{
	public class ResourceExistsBuiltInData
	{
		private const string kExistsFileName = "ExistsBuiltInFileList.json";

		private HashSet<string> existsFileList;

		private static ResourceExistsBuiltInData s_instance;

		public static ResourceExistsBuiltInData GetInstance()
		{
			return null;
		}

		private void Load()
		{
		}

		private void LoadFromFile()
		{
		}

		public static bool Exists(string path)
		{
			return false;
		}

		public bool exists(string path)
		{
			return false;
		}
	}
}
