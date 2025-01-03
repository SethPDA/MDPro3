using System.Collections.Generic;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupItemContainWidget
	{
		IReadOnlyList<IMDMarkupItemWidget> itemWidgets { get; }
	}
}
