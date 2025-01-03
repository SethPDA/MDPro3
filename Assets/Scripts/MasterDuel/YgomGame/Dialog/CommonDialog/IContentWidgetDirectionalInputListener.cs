using UnityEngine;

namespace YgomGame.Dialog.CommonDialog
{
	public interface IContentWidgetDirectionalInputListener
	{
		void OnMainAnalogInput(Vector2 dir);

		void OnSubAnalogInput(Vector2 dir);

		void OnLeftInput();

		void OnRightInput();

		void OnUpInput();

		void OnDownInput();
	}
}
