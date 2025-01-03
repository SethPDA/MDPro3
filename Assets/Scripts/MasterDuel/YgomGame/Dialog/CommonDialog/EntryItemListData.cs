using System.Collections.Generic;

namespace YgomGame.Dialog.CommonDialog
{
	public class EntryItemListData : IEntryData
	{
		public class Context
		{
			public bool isPeriod;

			public int itemCategory;

			public int itemId;

			public int num;

			public Context()
			{
			}

			public Context(bool isPeriod, int itemCategory, int itemId, int num)
			{
			}

			public Context(object data)
			{
			}

			public void Import(object data)
			{
			}

			public void Import(Dictionary<string, object> data)
			{
			}

			public static Context CreateFromData(object data)
			{
				return null;
			}
		}

		public List<Context> contexts;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public int Count => 0;

		public EntryItemListData()
		{
		}

		public EntryItemListData(List<Context> contexts)
		{
		}

		public EntryItemListData(IReadOnlyList<Context> contexts)
		{
		}

		public EntryItemListData(Context context)
		{
		}

		public void Import(IReadOnlyList<object> list)
		{
		}

		public void AddContext(Context context)
		{
		}
	}
}
