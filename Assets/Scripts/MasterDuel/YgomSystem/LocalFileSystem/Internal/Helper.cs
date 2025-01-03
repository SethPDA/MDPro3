using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace YgomSystem.LocalFileSystem.Internal
{
	public static class Helper
	{
		private static readonly StorageData[] s_storageDescriptions;

		private static Dictionary<int, StorageData> s_storages;

		public static LocalFileManager manager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static StorageIO storageIO
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void Initialize(string env, LocalFileManager managerInstance, bool enableLog)
		{
		}

		public static void Cleanup()
		{
		}

		public static T GetStorageIO<T>() where T : StorageIO
		{
			return null;
		}

		private static StorageIO createStorageIO()
		{
			return null;
		}

		public static Stream CreateIOStream(string nativePath, StreamOpenMode openMode, FileLocation location)
		{
			return null;
		}

		private static FileStream createSystemIOFileStream(string nativePath, StreamOpenMode openMode)
		{
			return null;
		}

		public static string GetNativePath(Storage storage, string name, FileNameType nameType)
		{
			return null;
		}

		public static string LocationToNativePath(FileLocation location)
		{
			return null;
		}

		public static StorageData GetStorageData(Storage storage)
		{
			return null;
		}

		public static string GetStorageName(Storage storage)
		{
			return null;
		}

		public static Storage NameToStorage(string name, bool ignoreCase)
		{
			return default(Storage);
		}

		public static Storage NameToStorage(string name)
		{
			return default(Storage);
		}

		public static string HashFileName(string name)
		{
			return null;
		}

		public static string[] SplitHash(string hash)
		{
			return null;
		}
	}
}
