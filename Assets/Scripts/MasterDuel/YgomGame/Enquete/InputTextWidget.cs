using System.Collections.Generic;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete
{
	public class InputTextWidget : SheetContentWidget
	{
		public readonly InputFieldWidget inputField;

		private readonly MDText m_ValidatedText;

		public InputTextWidget(ElementObjectManager eom, string label)
			: base(null, null)
		{
		}

		public override void ImportInputValues(Dictionary<string, object> importValues)
		{
		}

		public override void CollectInputValues(Dictionary<string, object> resultValues)
		{
		}

		public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
		{
		}

		public void ToValidatedText()
		{
		}
	}
}
