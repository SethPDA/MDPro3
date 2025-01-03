using System;
using System.Collections.Generic;

namespace YgomGame.DuelLive
{
	public abstract class ProductContextBase<T> : IComparable<T>, IProductContext
	{
		protected Dictionary<string, object> m_ProductData;

		public long duelLiveId => 0L;

		public int menuId => 0;

		public int replayIdx => 0;

		public int categoryId => 0;

		public int categoryIdx => 0;

		public int subCategoryId => 0;

		public int subCategoryIdx => 0;

		public int sectionId => 0;

		public int widgetType => 0;

		public List<object> mrk => null;

		public string imagePath => null;

		public string name1 => null;

		public string name2 => null;

		public int sort => 0;

		public void Import(Dictionary<string, object> productData)
		{
		}

		public abstract int Compare(T a, T b);

		public abstract int CompareTo(T other);
	}
}
