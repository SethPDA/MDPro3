using System;
using System.Collections.Generic;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupContainerWidget
	{
		void Initialize(IMDMarkupContainer containerData);

		void Output(MDMarkupGraphFactory graphFactory, Action onComplete);

		void OnStart(Dictionary<string, object> args);
	}
}
