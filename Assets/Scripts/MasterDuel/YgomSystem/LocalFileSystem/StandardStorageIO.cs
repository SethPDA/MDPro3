using System;

namespace YgomSystem.LocalFileSystem
{
	public class StandardStorageIO : StorageIO
	{
		private const int HASHDIRNUM = 256;

		private const string PLAINROOTDIR = "root";

		protected void setupStorageDirectory(Storage storage, string mountPath)
		{
		}

		private static void createStorageDirectory(string hashRoot, string plainRoot)
		{
		}

		protected override void OnInitialize()
		{
		}

		public override bool ExistsFile(string nativePath)
		{
			return false;
		}

		public override void DeleteFile(string nativePath)
		{
		}

		public override long GetFileSize(string nativePath)
		{
			return 0L;
		}

		public override void MoveFile(string srcNativePath, string dstNativePath)
		{
		}

		public override bool ExistsDirectory(string nativePath)
		{
			return false;
		}

		public override void CreateDirectory(string nativePath)
		{
		}

		public override string[] GetDirectories(string nativePath)
		{
			return null;
		}

		public override string[] GetFiles(string nativePath, string searchPattern)
		{
			return null;
		}

		public override void DeleteDirectory(string nativePath)
		{
		}

		public override void MoveDirectory(string srcNativePath, string dstNativePath)
		{
		}

		public override string GetStreamingAssetNativePath(string name)
		{
			return null;
		}

		public override bool ExistsStreamingAsset(string name)
		{
			return false;
		}

		public override byte[] ReadStreamingAsset(string name)
		{
			return null;
		}

		public override void ReadStreamingAssetCallback(string name, Action<byte[]> readCallback)
		{
		}

		public override void ClearLocalDataStorage(Action finishCallback)
		{
		}
	}
}
