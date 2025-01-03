using TMPro;

namespace YgomGame.Dialog.CommonDialog
{
	public class EntryScrollTextData : IEntryData
	{
		public string text;

		public int maxHeight;

		public TextAlignmentOptions alignment;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryScrollTextData(string text = null, int maxHeight = 32, TextAlignmentOptions alignment = TextAlignmentOptions.Midline)
		{
		}
	}
}
