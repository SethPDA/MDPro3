using TMPro;

namespace YgomGame.Dialog.CommonDialog
{
	public class EntryTextData : IEntryData
	{
		public string text;

		public TextAlignmentOptions alignment;

		public bool baseVisible;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryTextData(string text = null, TextAlignmentOptions alignment = TextAlignmentOptions.Midline, bool baseVisible = true)
		{
		}
	}
}
