using System;
using System.Runtime.CompilerServices;

namespace YgomGame.MDMarkup
{
	public abstract class MDMarkupContentPageBase : MDMarkupContentBase, IMDMarkupPageContent, IMDMarkupContent
	{
		public sealed override int contentIndent => 0;

		public event Action<bool> onFocusPageEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void InvokeOnFocusPageEvent(bool isFirst)
		{
		}
	}
}
