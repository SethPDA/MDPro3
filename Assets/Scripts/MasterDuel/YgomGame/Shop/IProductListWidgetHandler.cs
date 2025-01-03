using System.Collections.Generic;

namespace YgomGame.Shop
{
	public interface IProductListWidgetHandler : IProductContainerWidgetHandler
	{
		ProductWidgetController productWidgetController { get; }

		int showcaseUnloadUnusedCnt { get; }

		bool EqualCurrentCategoryId(int chkCategoryId, int chkSubCategoryId, int chkSectionId);

		void OnUpdateDataCount(List<int> templateIdxList, List<string> headerLabels, Dictionary<int, Dictionary<int, Dictionary<int, int>>> headerDataIdxMap, List<ProductContainerWidget.Context> productContainerCtxs);
	}
}
