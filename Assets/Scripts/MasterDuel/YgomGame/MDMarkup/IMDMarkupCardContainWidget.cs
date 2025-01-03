using System.Collections.Generic;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupCardContainWidget
	{
		IReadOnlyList<IMDMarkupCardWidget> cardWidgets { get; }
	}
}
