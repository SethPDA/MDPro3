using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupPagerFactory : MDMarkupWidgetFactoryBase
	{
		private readonly ElementObjectManager m_Template;

		private readonly MDMarkupDef.MarkupType markupType;

		public MDMarkupPagerFactory(ElementObjectManager template, MDMarkupDef.MarkupType markupType)
		{
		}

		public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
		{
			return null;
		}
	}
}
