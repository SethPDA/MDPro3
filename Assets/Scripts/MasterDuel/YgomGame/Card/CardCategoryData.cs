using System;
using System.Collections.Generic;

namespace YgomGame.Card
{
	public class CardCategoryData
	{
		public class Category
		{
			public readonly int id;

			public readonly Dictionary<string, string> globalNameMap;

			public Category(int id, Dictionary<string, string> globalNameMap)
			{
			}

			public string GetName()
			{
				return null;
			}
		}

		private const string k_SnapshotPath = "External/CardCategory/CardCategory";

		private Dictionary<int, Category> m_CategoryMap;

		public IReadOnlyDictionary<int, Category> categoryMap => null;

		public static void LoadAsync(Action<CardCategoryData> onComplete)
		{
		}

		public void Import(List<object> snapshotDatas)
		{
		}
	}
}
