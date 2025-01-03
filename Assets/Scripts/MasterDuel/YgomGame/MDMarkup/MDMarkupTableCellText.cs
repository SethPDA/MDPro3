using System.Collections.Generic;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableCellText : ElementWidgetBase, IMDMarkupTMPWidget
	{
		private readonly string k_ELabelText;

		public readonly TextMeshProUGUI text;

		public bool borderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MDMarkupTableCellText(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetAlignment(TextAlignmentOptions alignment)
		{
		}

		public void SetText(string text)
		{
		}

		public void SetSizeRate(float sizeRate)
		{
		}

		public void AddContainTMPTexts(List<TMP_Text> results)
		{
		}
	}
}
