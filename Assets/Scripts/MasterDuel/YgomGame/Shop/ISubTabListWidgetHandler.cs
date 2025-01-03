using System.Collections.Generic;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public interface ISubTabListWidgetHandler
	{
		int currentIdx { get; }

		int currentSectionIdx { get; }

		(int, int) CategoryIdOfIndex(int dataIdx);

		void OnUpdateSubTabWidget(List<int> templateIds);

		void OnUpdateTabWidget(ShopTabWidget widget, int dataIdx);

		void OnUpdateSectionFactory(ElementEntityFactory entityFactory, int dataIdx);

		void OnUpdateSectionTabWidget(ShopTabWidget widget, int dataIdx, int sectionIdx);
	}
}
