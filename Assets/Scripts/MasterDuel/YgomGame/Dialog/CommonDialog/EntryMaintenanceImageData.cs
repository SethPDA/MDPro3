using TMPro;

namespace YgomGame.Dialog.CommonDialog
{
	public class EntryMaintenanceImageData : IEntryData
	{
		public string textTitle;

		public string textDate;

		public string imagePath;

		public TextAlignmentOptions alignment;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryMaintenanceImageData(string textTitle = null, string textDate = null, string imagePath = null, TextAlignmentOptions alignment = TextAlignmentOptions.Midline)
		{
		}
	}
}
