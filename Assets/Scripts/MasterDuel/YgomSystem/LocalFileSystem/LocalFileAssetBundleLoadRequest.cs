using UnityEngine;

namespace YgomSystem.LocalFileSystem
{
	public class LocalFileAssetBundleLoadRequest
	{
		private enum Step
		{
			Idle = 0,
			Start = 1,
			ReadFile = 2,
			LoadAssetBundle = 3,
			End = 4
		}

		public enum Result
		{
			None = 0,
			Success = 1,
			Failed = 2,
			Canceled = 3
		}

		private Step m_step;

		private bool m_reqCancel;

		private LocalFileStream m_fileStream;

		private AssetBundleCreateRequest m_assetBundleRequest;

		private ReadRequest m_fileReadRequest;

		public string nativePath;

		public AssetBundle assetBundle;

		public Result result;

		public bool isEmpty => false;

		public bool isDone => false;

		public bool isSuccess => false;

		public bool isError => false;

		public bool isCanceled => false;

		private void clear()
		{
		}

		public void SetStart(string nativePath)
		{
		}

		public void SetCancel()
		{
		}

		public void Update()
		{
		}
	}
}
