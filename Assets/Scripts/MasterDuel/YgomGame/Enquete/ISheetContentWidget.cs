using System.Collections.Generic;

namespace YgomGame.Enquete
{
	public interface ISheetContentWidget
	{
		string label { get; }

		void ImportInputValues(Dictionary<string, object> importValues);

		void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap);

		void CollectInputValues(Dictionary<string, object> resultValues);
	}
}
