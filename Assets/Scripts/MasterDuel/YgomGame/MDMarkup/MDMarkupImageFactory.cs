using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupImageFactory : MDMarkupWidgetFactoryBase
	{
		private readonly ElementObjectManager m_Template;

		public MDMarkupImageFactory(ElementObjectManager template)
		{
		}

		public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
		{
			return null;
		}
	}
}
