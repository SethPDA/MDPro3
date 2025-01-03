using UnityEngine;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupWidget : IMDMarkupAsyncWidget
	{
		GameObject gameObject { get; }

		Transform transform { get; }

		MDMarkupIndentWidget indentWidget { get; }

		void BindContentData(IMDMarkupContent mdMarkupContent);
	}
}
