namespace YgomGame.Dialog.CommonDialog
{
	public class EntryIconTextData : IEntryData
	{
		public CommonDialogIconTextWidget.IconType iconType;

		public string text;

		public string iconPath;

		public string numText;

		public bool itemIsPeriod;

		public int itemCategory;

		public int itemId;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryIconTextData(CommonDialogIconTextWidget.IconType iconType, string text, string numText = null)
		{
		}

		public EntryIconTextData(string iconPath, string text, string numText = null)
		{
		}

		public EntryIconTextData(bool itemIsPeriod, int itemCategory, int itemId, string text, string numText = null)
		{
		}
	}
}
