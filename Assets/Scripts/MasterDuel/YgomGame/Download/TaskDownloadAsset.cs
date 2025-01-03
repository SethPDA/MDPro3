using System;
using System.Collections;

namespace YgomGame.Download
{
	public class TaskDownloadAsset : TaskWebRequest
	{
		private DLCList.DLCInfo m_info;

		private Action<DLCList.DLCInfo> m_completeAction;

		private bool IsEnableTask => false;

		public long size => 0L;

		public TaskDownloadAsset(string _baseUrl, string _path)
			: base(null, null, default(RequestType))
		{
		}

		public TaskDownloadAsset(string _baseUrl, DLCList.DLCInfo _info)
			: base(null, null, default(RequestType))
		{
		}

		public void SetCompleteHandler(Action<DLCList.DLCInfo> callback)
		{
		}

		protected override IEnumerator yProgress()
		{
			return null;
		}

		private IEnumerator InstallDataAsync(string path, byte[] data)
		{
			return null;
		}

		private void InstallData(string path, byte[] data)
		{
		}
	}
}
