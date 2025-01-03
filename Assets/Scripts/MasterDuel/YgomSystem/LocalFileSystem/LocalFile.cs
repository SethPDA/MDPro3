using System;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.LocalFileSystem
{
	public static class LocalFile
	{
		private static LocalFileManager s_manager;

		public static LocalFileManager manager => null;

		static LocalFile()
		{
		}

		public static void Initialize(string env)
		{
		}

		public static void Initialize(RuntimeEnvironment.ServerType serverType)
		{
		}

		public static bool IsInitialized()
		{
			return false;
		}

		public static T GetStorageIO<T>() where T : StorageIO
		{
			return null;
		}

		private static void dispatchLocationNameType(FileNameType nameType, Action nomralCallback, Action plainCallback, Action rawCallback)
		{
		}

		public static bool ExistsFile(Storage storage, string name, FileNameType nameType)
		{
			return false;
		}

		public static bool ExistsFile(Storage storage, string name)
		{
			return false;
		}

		public static bool ExistsFile(FileLocation location)
		{
			return false;
		}

		public static bool ExistsFile(string locationString)
		{
			return false;
		}

		public static void WriteFile(Storage storage, string name, FileNameType nameType, byte[] writeData, bool asNewFile)
		{
		}

		public static void WriteFile(Storage storage, string name, byte[] writeData, bool asNewFile)
		{
		}

		public static void WriteFile(FileLocation location, byte[] writeData, bool asNewFile)
		{
		}

		public static void WriteFile(string locationString, byte[] writeData, bool asNewFile)
		{
		}

		public static void WriteTextFile(Storage storage, string name, FileNameType nameType, string text, bool asNewFile)
		{
		}

		public static void WriteTextFile(Storage storage, string name, string text, bool asNewFile)
		{
		}

		public static void WriteTextFile(FileLocation location, string text, bool asNewFile)
		{
		}

		public static void WriteTextFile(string locationString, string text, bool asNewFile)
		{
		}

		public static byte[] ReadFile(Storage storage, string name, FileNameType nameType)
		{
			return null;
		}

		public static byte[] ReadFile(Storage storage, string name)
		{
			return null;
		}

		public static byte[] ReadFile(FileLocation location)
		{
			return null;
		}

		public static byte[] ReadFile(string locationString)
		{
			return null;
		}

		public static string ReadTextFile(Storage storage, string name, FileNameType nameType)
		{
			return null;
		}

		public static string ReadTextFile(Storage storage, string name)
		{
			return null;
		}

		public static string ReadTextFile(FileLocation location)
		{
			return null;
		}

		public static string ReadTextFile(string locationString)
		{
			return null;
		}

		public static void DeleteFile(Storage storage, string name, FileNameType nameType)
		{
		}

		public static void DeleteFile(Storage storage, string name)
		{
		}

		public static void DeleteFile(FileLocation location)
		{
		}

		public static void DeleteFile(string locationString)
		{
		}

		public static long GetFileSize(Storage storage, string name, FileNameType nameType)
		{
			return 0L;
		}

		public static long GetFileSize(Storage storage, string name)
		{
			return 0L;
		}

		public static long GetFileSize(FileLocation location)
		{
			return 0L;
		}

		public static long GetFileSize(string locationString)
		{
			return 0L;
		}

		public static string GetLocationNativePath(FileLocation location)
		{
			return null;
		}

		public static string GetLocationNativePath(string locationString)
		{
			return null;
		}

		public static string GetHashFileNativePath(Storage storage, string name)
		{
			return null;
		}

		public static bool ExistsHashFile(Storage storage, string name)
		{
			return false;
		}

		public static void WriteHashFile(Storage storage, string name, byte[] writeData, bool asNewFile)
		{
		}

		public static void WriteHashTextFile(Storage storage, string name, string text, bool asNewFile)
		{
		}

		public static byte[] ReadHashFile(Storage storage, string name)
		{
			return null;
		}

		public static string ReadHashTextFile(Storage storage, string name)
		{
			return null;
		}

		public static byte[] ReadFileHeader(Storage storage, string name, int length)
		{
			return null;
		}

		public static void DeleteHashFile(Storage storage, string name)
		{
		}

		public static long GetHashFileSize(Storage storage, string name)
		{
			return 0L;
		}

		public static bool ExistsRawHashFile(Storage storage, string hash)
		{
			return false;
		}

		public static void WriteRawHashFile(Storage storage, string hash, byte[] writeData, bool asNewFile)
		{
		}

		public static byte[] ReadRawHashFile(Storage storage, string hash)
		{
			return null;
		}

		public static byte[] ReadRawHashFileHeader(Storage storage, string hash, int length)
		{
			return null;
		}

		public static void DeleteRawHashFile(Storage storage, string hash)
		{
		}

		public static long GetRawHashFileSize(Storage storage, string hash)
		{
			return 0L;
		}

		public static string GetPlainNativePath(Storage storage, string path)
		{
			return null;
		}

		public static bool ExistsPlainFile(Storage storage, string path)
		{
			return false;
		}

		public static void WritePlainFile(Storage storage, string path, byte[] writeData, bool asNewFile)
		{
		}

		public static void WritePlainTextFile(Storage storage, string path, string text, bool asNewFile)
		{
		}

		public static byte[] ReadPlainFile(Storage storage, string path)
		{
			return null;
		}

		public static string ReadPlainTextFile(Storage storage, string path)
		{
			return null;
		}

		public static void DeletePlainFile(Storage storage, string path)
		{
		}

		public static long GetPlainFileSize(Storage storage, string path)
		{
			return 0L;
		}

		public static void MovePlainFile(Storage storage, string srcPath, string dstPath)
		{
		}

		public static EntryItem[] GetPlainFiles(Storage storage, string path = "", string searchPattern = "")
		{
			return null;
		}

		public static bool ExistsDirectory(Storage storage, string path)
		{
			return false;
		}

		public static void CreateDirectory(Storage storage, string path)
		{
		}

		public static EntryItem[] GetDirectories(Storage storage, string path = "")
		{
			return null;
		}

		public static void DeleteDirectory(Storage storage, string path)
		{
		}

		public static void MoveDirectory(Storage storage, string srcPath, string dstPath)
		{
		}

		public static string GetStreamingAssetNativePath(string name)
		{
			return null;
		}

		public static bool ExistsStreamingAsset(string name)
		{
			return false;
		}

		public static byte[] ReadStreamingAsset(string name)
		{
			return null;
		}

		public static byte[] ReadStreamingAssetHeader(string name, int length)
		{
			return null;
		}

		public static void ReadStreamingAssetCallback(string name, Action<byte[]> readCallback)
		{
		}

		private static string sanitizeAssetBundlePath(string path)
		{
			return null;
		}

		public static bool IsExistAssetBundle(string path)
		{
			return false;
		}

		private static string getAssetBundleNativePathDownload(string sanitizedPath)
		{
			return null;
		}

		public static bool IsExistAssetBundleDownload(string path)
		{
			return false;
		}

		public static AssetBundle LoadAssetBundleFromDownload(string path)
		{
			return null;
		}

		public static LocalFileAssetBundleLoadRequest RequestAssetBundleFromDownload(string path)
		{
			return null;
		}

		private static string getAssetBundleNativePathStreamingAssets(string sanitizedPath, bool relative)
		{
			return null;
		}

		public static string GetStreamingAssetsAssetBundleNativePath(string path)
		{
			return null;
		}

		public static string GetStreamingAssetsAssetBundleRelativePath(string path)
		{
			return null;
		}

		public static bool IsExistStreamingAssetsAssetBundle(string path)
		{
			return false;
		}

		public static AssetBundle LoadAssetBundleFromStreamingAssets(string path)
		{
			return null;
		}

		public static LocalFileAssetBundleLoadRequest RequestAssetBundleFromStreamingAssets(string path)
		{
			return null;
		}

		public static void SetAssetBundleLoadTaskLimit(int num)
		{
		}

		public static void ResetAssetBundleLoadTaskLimit()
		{
		}

		public static void ClearLocalDataStorage(Action finishCallback)
		{
		}

		public static string HashFileName(string path)
		{
			return null;
		}

		public static uint GetFileCRC32(Storage storage, string name, FileNameType nameType)
		{
			return 0u;
		}

		public static byte[] GetFileSHA1(Storage storage, string name, FileNameType nameType)
		{
			return null;
		}
	}
}
