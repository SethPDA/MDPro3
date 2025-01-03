using System;
using System.Collections.Generic;

namespace YgomGame.Dialog.CommonDialog
{
	public class EntryCheckBoxListData : IEntryData
	{
		public class EntryCheckBoxData
		{
			public string text;

			public bool isOn;

			public bool interactive;

			public EntryCheckBoxData(string text, bool isOn = false, bool interactive = true)
			{
			}
		}

		public List<EntryCheckBoxData> checkBoxList;

		public Action<List<bool>> callback;

		public bool isEnableMulti;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryCheckBoxListData(List<EntryCheckBoxData> checkBoxList, Action<List<bool>> callback, bool isEnableMulti = true)
		{
		}
	}
}
