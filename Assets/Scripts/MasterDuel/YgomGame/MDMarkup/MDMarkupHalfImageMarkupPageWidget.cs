using System.Collections.Generic;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupHalfImageMarkupPageWidget : MDMarkupPageWidgetBase
	{
		public MDMarkupHalfImageMarkupPageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
			: base(null, null)
		{
		}

		protected override GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected override GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected override string GetResourcePath(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected override List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected override List<IMDMarkupContent> GetMarkupContents(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}
	}
}
