using System.Collections.Generic;

namespace YgomGame.DuelLive
{
	public interface IProductContext
	{
		int menuId { get; }

		int replayIdx { get; }

		long duelLiveId { get; }

		int categoryId { get; }

		int categoryIdx { get; }

		int subCategoryId { get; }

		int subCategoryIdx { get; }

		int sectionId { get; }

		int widgetType { get; }

		List<object> mrk { get; }

		string imagePath { get; }

		string name1 { get; }

		string name2 { get; }

		int sort { get; }

		void Import(Dictionary<string, object> productData);
	}
}
