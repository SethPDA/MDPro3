using System;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupGraphWidget
	{
		void OutputMarkupGraph(IMDMarkupContent mdMarkupContent, MDMarkupGraphFactory markupGraphFactory, Action onComplete);
	}
}
