using UnityEngine;

namespace YgomGame.Dialog.CommonDialog
{
	public interface IContentWidget
	{
		GameObject gameObject { get; }

		Transform transform { get; }

		CommonDialogContentContainerWidget parentWidget { get; }

		IContentWidget DuplicateInstantiate();

		void Binding(IEntryData entryData);

		void Initialize(CommonDialogContentContainerWidget parentWidget);
	}
}
