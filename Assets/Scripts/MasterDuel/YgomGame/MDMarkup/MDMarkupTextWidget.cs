using System.Collections.Generic;
using TMPro;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTextWidget : MDMarkupWidgetBase, IMDMarkupTMPWidget
	{
		private readonly string k_ELabelText;

		public readonly TextMeshProUGUI text;

		public MDMarkupTextWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
			: base(null, null)
		{
		}

		public override void BindContentData(IMDMarkupContent contentData)
		{
		}

		public void AddContainTMPTexts(List<TMP_Text> results)
		{
		}
	}
}
