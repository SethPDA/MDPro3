namespace YgomGame.Dialog.CommonDialog
{
	public class EntryInsertWidgetData : IEntryData
	{
		public IContentWidget insertWidget;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryInsertWidgetData(IContentWidget insertWidget)
		{
		}
	}
}
