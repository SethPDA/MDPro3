using System.Collections;
using System.Runtime.CompilerServices;

namespace YgomGame.Download
{
	public class TaskWebRequest : TaskBase
	{
		public enum RequestType
		{
			Bytes = 0,
			Text = 1
		}

		private const float DownloadTimeOut = 60f;

		private const ulong kThresholdDLBytes = 1024uL;

		protected string m_baseUrl;

		protected string m_path;

		protected RequestType m_requestType;

		private IEnumerator m_executor;

		protected bool m_success;

		protected bool m_cancel;

		protected virtual bool m_updateProgressTimeOut
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public byte[] Bytes
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

		public string Text
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

		public DownloadErrorCode errorCode
		{
			[CompilerGenerated]
			get
			{
				return default(DownloadErrorCode);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public TaskWebRequest(string baseUrl, string path, RequestType requestType)
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public virtual bool IsSuccess()
		{
			return false;
		}

		public bool IsError()
		{
			return false;
		}

		public void Cancel()
		{
		}

		public void Exec()
		{
		}

		private IEnumerator yExec()
		{
			return null;
		}

		protected virtual IEnumerator yProgress()
		{
			return null;
		}

		protected IEnumerator yRequest()
		{
			return null;
		}
	}
}
