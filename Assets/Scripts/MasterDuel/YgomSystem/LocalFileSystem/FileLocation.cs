namespace YgomSystem.LocalFileSystem
{
	public struct FileLocation
	{
		public Storage storage;

		public string name;

		public FileNameType nameType;

		private static readonly string s_locationDelimiter;

		private static string[] s_locationSeparators;

		public static FileLocation nullLocation;

		public bool isNull => false;

		//public FileLocation(Storage storage, string name, FileNameType nameType)
		//{
		//}

		//public FileLocation(string str)
		//{
		//}

		public override string ToString()
		{
			return null;
		}

		public static string GetLocationString(Storage storage, string name, FileNameType nameType)
		{
			return null;
		}

		public static FileLocation ParseLocationString(string str)
		{
			return default(FileLocation);
		}
	}
}
