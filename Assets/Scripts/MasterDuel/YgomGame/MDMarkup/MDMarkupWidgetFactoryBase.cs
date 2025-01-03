namespace YgomGame.MDMarkup
{
	public abstract class MDMarkupWidgetFactoryBase : IMDMarkupWidgetFactory
	{
		public abstract IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget);
	}
}
