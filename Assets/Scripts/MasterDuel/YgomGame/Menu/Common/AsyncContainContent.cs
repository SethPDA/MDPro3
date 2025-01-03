namespace YgomGame.Menu.Common
{
	public class AsyncContainContent : IAsyncProgressContent
	{
		private AsyncProgressLoadingCountContent m_LoadingCountContent;

		private AsyncProgressContainContent m_AsyncProgressContainContent;

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		public void Clear()
		{
		}

		public void AddLoadingCount()
		{
		}

		public void DecLoadingCount()
		{
		}

		public void AssignProgressContent(IAsyncProgressContent progressContent)
		{
		}
	}
}
