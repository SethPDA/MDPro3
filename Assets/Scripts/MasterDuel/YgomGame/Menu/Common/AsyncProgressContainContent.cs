using System.Collections.Generic;

namespace YgomGame.Menu.Common
{
	public class AsyncProgressContainContent : IAsyncProgressContent
	{
		private List<IAsyncProgressContent> m_AsyncContents;

		public bool IsDone()
		{
			return false;
		}

		public void Clear()
		{
		}

		public void Assign(IAsyncProgressContent progressContent)
		{
		}

		public void ProgressUpdate()
		{
		}
	}
}
