namespace YgomGame.Dialog.CommonDialog
{
	public class EntryTitleData : IEntryData
	{
		public string text;

		public CommonDialogTitleWidget.IconType iconType;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryTitleData(string text = null, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None)
		{
		}
	}
}
