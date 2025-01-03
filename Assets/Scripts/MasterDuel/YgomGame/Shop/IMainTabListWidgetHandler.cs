using System.Collections.Generic;

namespace YgomGame.Shop
{
	public interface IMainTabListWidgetHandler
	{
		int currentIdx { get; }

		void OnUpdateMainTabDataCount(IReadOnlyList<ShopTabWidget> sourceTabWidgets, List<ShopTabWidget> activeTabWidets);

		void OnUpdateMainTabData(IReadOnlyList<ShopTabWidget> activeTabWidets);
	}
}
