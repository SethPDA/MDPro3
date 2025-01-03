using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.LocalFileSystem
{
	public class LocalFileManager : MonoBehaviour
	{
		private bool m_initialized;

		private ulong m_frameCounter;

		private Queue<LocalFileAssetBundleLoadRequest> m_assetBundleLoadQueue;

		private List<LocalFileAssetBundleLoadRequest> m_assetBundleLoadTask;

		private const int defaultLoadTaskLimit = 10;

		private int m_loadTaskLimit;

		public ulong frameCounter => 0uL;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void Initialize(string env, bool enableLog)
		{
		}

		public void SetLoadTaskLimit(int num)
		{
		}

		public void ResetLoadTaskLimit()
		{
		}

		public LocalFileAssetBundleLoadRequest RequestAssetBundleLoad(string nativePath)
		{
			return null;
		}

		public int GetAssetBundleRequestQueueCount()
		{
			return 0;
		}
	}
}
