using System.Collections.Generic;

namespace YgomGame.Dialog.CommonDialog
{
	public class EntryItemContentData : IEntryData
	{
		public bool isPeriod;

		public int itemCategory;

		public int itemId;

		public string text;

		public bool effect;

		public string spItemProductLabel;

		public Dictionary<string, object> itemArgs;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryItemContentData()
		{
		}

		public EntryItemContentData(bool isPeriod, int itemCategory, int itemId, string text = null, bool effect = false, Dictionary<string, object> itemArgs = null)
		{
		}
	}
}
