using System.Collections.Generic;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupHalfBannerMarkupPageWidget : MDMarkupPageWidgetBase
	{
		public MDMarkupHalfBannerMarkupPageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
			: base(null, null)
		{
		}

		protected override MDMarkupBannerContext GetBannerContext(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected override GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected override GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
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
