namespace YgomGame.Dialog.CommonDialog
{
	public class EntryImageData : IEntryData
	{
		public string path;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryImageData(string path = null)
		{
		}
	}
}
