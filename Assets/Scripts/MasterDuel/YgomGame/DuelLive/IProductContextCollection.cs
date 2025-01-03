using System;
using System.Collections.Generic;

namespace YgomGame.DuelLive
{
	public interface IProductContextCollection
	{
		int filterSubId { get; set; }

		List<IDuelLiveProductGruopData> lockedGroups { get; }

		bool isDisplayEmpty { get; }

		List<int> subCategories { get; }

		IProductContext Item { get; }

		int Count { get; }

		IReadOnlyList<IProductContext> importedContexts { get; }

		event Action onUpdatedEvent;

		bool IsEmpty();

		void Import(Dictionary<string, object> productDatas);

		void Filter();
	}
}
