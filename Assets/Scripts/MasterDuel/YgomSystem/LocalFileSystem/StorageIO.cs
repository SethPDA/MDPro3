using System;
using System.Runtime.CompilerServices;

namespace YgomSystem.LocalFileSystem
{
	public abstract class StorageIO
	{
		public class StorageInfo
		{
			public Storage storage;

			public string mountPath;

			public bool isWritable;

			public string envRoot;

			public string writeHashRoot;

			public bool useHashDir;

			public string writePlainRoot;

			public StorageInfo(Storage st)
			{
			}
		}

		private StorageInfo[] m_storageInfos;

		protected string environment
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

		protected StorageInfo getStorageInfo(Storage type)
		{
			return null;
		}

		protected void setupStorageInfo(Storage storage, string mountPath, string envRoot, string hashRootPath, bool useHashDir, string plainRootPath)
		{
		}

		public void Initialize(string envName)
		{
		}

		public void Terminate()
		{
		}

		public StorageInfo GetStorageInfo(Storage type)
		{
			return null;
		}

		public string GetMountNativePath(Storage storage)
		{
			return null;
		}

		public string GetEnvRootNativePath(Storage storage)
		{
			return null;
		}

		public string GetHashedFileNativePath(Storage storage, string hash)
		{
			return null;
		}

		public string GetPlainNativePath(Storage storage, string path)
		{
			return null;
		}

		protected abstract void OnInitialize();

		protected virtual void OnTerminate()
		{
		}

		public abstract bool ExistsFile(string nativePath);

		public abstract void DeleteFile(string nativePath);

		public abstract long GetFileSize(string nativePath);

		public abstract void MoveFile(string srcNativePath, string dstNativePath);

		public abstract bool ExistsDirectory(string nativePath);

		public abstract void CreateDirectory(string nativePath);

		public abstract string[] GetDirectories(string nativePath);

		public abstract string[] GetFiles(string nativePath, string searchPattern);

		public abstract void DeleteDirectory(string nativePath);

		public abstract void MoveDirectory(string srcNativePath, string dstNativePath);

		public abstract string GetStreamingAssetNativePath(string name);

		public abstract bool ExistsStreamingAsset(string name);

		public abstract byte[] ReadStreamingAsset(string name);

		public abstract void ReadStreamingAssetCallback(string name, Action<byte[]> readCallback);

		public abstract void ClearLocalDataStorage(Action finishCallback);
	}
}
