using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableFactory : MDMarkupWidgetFactoryBase
	{
		private readonly ElementObjectManager m_Template;

		private readonly MDMarkupTableRowFactory m_RowFactory;

		private readonly MDMarkupTableCellFactory m_CellFactory;

		public MDMarkupTableFactory(ElementObjectManager template, ElementObjectManager rowTemplate, ElementObjectManager cellHeaderTemplate, ElementObjectManager cellNormalTemplate, ElementObjectManager cellImageTemplate, ElementObjectManager cellCardTemplate, ElementObjectManager cellItemTemplate, ElementObjectManager bannerTemplate, ElementObjectManager buttonSTemplate, ElementObjectManager buttonMTemplate, ElementObjectManager buttonLTemplate)
		{
		}

		public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
		{
			return null;
		}
	}
}
