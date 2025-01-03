using System.Collections.Generic;
using YgomSystem.UI;

namespace YgomGame.Enquete
{
	public class SheetSelectionItemMap
	{
		private readonly List<List<SelectionItem>> m_SelectionItems;

		private List<SelectionItem> m_SelectionItemSearchList;

		public IReadOnlyList<IReadOnlyList<SelectionItem>> selectionItems => null;

		public void AppendItem(SelectionItem selectionItems)
		{
		}

		public void AppendItemLine(SelectionItem selectionItems)
		{
		}

		public void AppendItemLine(List<SelectionItem> selectionItems)
		{
		}

		public (bool, int, int) SearchItemIdx(SelectionItem searchItem)
		{
			return default((bool, int, int));
		}

		public SelectionItem SearchItem(int xIdx, int yIdx)
		{
			return null;
		}

		public List<SelectionItem> GetAllSelectionItems()
		{
			return null;
		}
	}
}
