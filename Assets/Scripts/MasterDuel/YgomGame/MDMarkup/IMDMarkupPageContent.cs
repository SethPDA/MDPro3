using System;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupPageContent : IMDMarkupContent
	{
		event Action<bool> onFocusPageEvent;

		void InvokeOnFocusPageEvent(bool isFirst);
	}
}
