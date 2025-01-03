using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MarkupTextFactory : MDMarkupWidgetFactoryBase
	{
		private readonly ElementObjectManager m_Template;

		public MarkupTextFactory(ElementObjectManager template)
		{
		}

		public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
		{
			return null;
		}
	}
}
