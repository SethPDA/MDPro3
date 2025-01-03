using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.MDMarkup
{
	public interface IMDMarkupButtonWidget
	{
		SelectionButton button { get; }

		void SetOnClick(UnityAction callback);
	}
}
