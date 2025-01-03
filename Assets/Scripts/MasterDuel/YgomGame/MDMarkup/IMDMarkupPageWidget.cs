using System;
using System.Collections.Generic;
using YgomSystem.UI;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupPageWidget
	{
		List<SelectionButton> buttons { get; }

		event Action<bool> onFocusPageEvent;
	}
}
