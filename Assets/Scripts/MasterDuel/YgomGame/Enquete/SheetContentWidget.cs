using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete
{
	public class SheetContentWidget : ElementWidgetBase//, ISheetContentWidget
	{
		public string label;

		private string YgomGame_002EEnquete_002EISheetContentWidget_002Elabel => null;

		public SheetContentWidget(ElementObjectManager eom, string label)
			: base(null)
		{
		}

		public virtual void ImportInputValues(Dictionary<string, object> importValues)
		{
		}

		public virtual void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
		{
		}

		public virtual void CollectInputValues(Dictionary<string, object> resultValues)
		{
		}
	}
}
