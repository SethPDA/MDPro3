using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomGame.Shop
{
	public class ConfirmRegDialogProductWidget : ContentWidgetBase<ConfirmRegDialogProductWidget, EntryInsertWidgetData>
	{
		public string headerText;

		public string hasText;

		public string numText;

		public static ConfirmRegDialogProductWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void InnerBinding(EntryInsertWidgetData entryData)
		{
		}

		public ConfirmRegDialogProductWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
