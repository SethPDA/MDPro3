using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Download
{
	public sealed class DownloadController
	{
		private struct DownloadData
		{
			public string path;

			public string index;
		}

		public delegate void EventHandler();

		public delegate void StepHandler(DownloadStep step);

		public DownloadStep m_step;

		private EventHandler downloadCompleteHandler;

		private EventHandler downloadErrorHandler;

		private StepHandler stepHandler;

		private int completeNum;

		private int requestEndNum;

		private long m_totalSize;

		private long m_requestEndSize;

		private long m_compSize;

		private List<DownloadData> m_dataList;

		private List<DLCList> m_targetList;

		private DLCList m_downloadList;

		private DLCList m_compList;

		private DLCList m_local;

		private IEnumerator downloadCoroutine;

		private bool bAppQuitAbort;

		private Action abortCallback;

		public DownloadStep step
		{
			get
			{
				return default(DownloadStep);
			}
			private set
			{
			}
		}

		public float TotalProgress => 0f;

		public int TotalNum
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CompleteNum => 0;

		public void SetStepHandler(StepHandler handler)
		{
		}

		public void ReleaseStepHandler(StepHandler handler)
		{
		}

		public void RequestAppQuitAbort(Action callback)
		{
		}

		private void DownloadCompleteEvent()
		{
		}

		private void DownloadErrorEvent()
		{
		}

		public void ShowLoading()
		{
		}

		public void HideLoading()
		{
		}

		public void StartDownload(EventHandler complete, EventHandler error)
		{
		}

		public void RefreshCache()
		{
		}

		public void Destroy()
		{
		}

		private IEnumerator yDownload()
		{
			return null;
		}

		private IEnumerator yDeleteUnusedData()
		{
			return null;
		}

		private IEnumerator DownloadItem(string baseUrl, DLCList target, Action<bool> callback)
		{
			return null;
		}

		private void SendComplete()
		{
		}

		private void OpenAlertDialog(string message, Action callbackTitle, Action callbackRetry)
		{
		}
	}
}
