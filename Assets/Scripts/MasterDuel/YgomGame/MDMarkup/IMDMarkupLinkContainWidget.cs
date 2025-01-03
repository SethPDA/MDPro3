using System.Collections.Generic;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupLinkContainWidget
	{
		IReadOnlyList<IMDMarkupLinkWidget> linkWidgets { get; }
	}
}
