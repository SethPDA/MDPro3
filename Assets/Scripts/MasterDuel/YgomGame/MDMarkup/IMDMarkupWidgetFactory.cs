namespace YgomGame.MDMarkup
{
	public interface IMDMarkupWidgetFactory
	{
		IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget);
	}
}
