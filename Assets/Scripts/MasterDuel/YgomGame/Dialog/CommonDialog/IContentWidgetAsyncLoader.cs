using System;

namespace YgomGame.Dialog.CommonDialog
{
	public interface IContentWidgetAsyncLoader
	{
		void AsyncBinding(IEntryData entryData, Action onComplete);
	}
}
