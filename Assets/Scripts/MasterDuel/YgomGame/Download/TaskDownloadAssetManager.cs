using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Download
{
	public class TaskDownloadAssetManager
	{
		private enum State
		{
			None = 0,
			Progress = 1,
			Success = 2,
			Cancel = 3,
			Error = 4,
			Wait = 5
		}

		private const int kEnableTaskMax = 4;

		private State m_state;

		private string m_baseUrl;

		private List<TaskDownloadAsset> m_tasks;

		private Queue<DLCList.DLCInfo> m_requestTask;

		private Action<DLCList.DLCInfo> m_updateHandler;

		private Action m_completeHandler;

		private Action m_errorHandler;

		private Action m_cancelHandler;

		public DownloadErrorCode errorCode
		{
			[CompilerGenerated]
			get
			{
				return default(DownloadErrorCode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int completeNum
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

		public long completeSize
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long totalSize
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsDone()
		{
			return false;
		}

		public void SetRequest(string baseUrl, DLCList dlcList, Action<DLCList.DLCInfo> updateHandler, Action completeHandler, Action errorHandler, Action cancelHandler)
		{
		}

		public void Update()
		{
		}

		private void UpdateProgress()
		{
		}

		private void UpdateError()
		{
		}

		private void UpdateCancel()
		{
		}

		public void Retry()
		{
		}

		public void Cancel()
		{
		}
	}
}
