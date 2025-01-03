using System;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupContentAsyncLoader
	{
		void LoadAsync(Action onComplete);
	}
}
