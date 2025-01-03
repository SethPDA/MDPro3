using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupHeaderFactory : MDMarkupWidgetFactoryBase
	{
		private readonly ElementObjectManager m_Template;

		public MDMarkupHeaderFactory(ElementObjectManager template)
		{
		}

		public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
		{
			return null;
		}
	}
}
