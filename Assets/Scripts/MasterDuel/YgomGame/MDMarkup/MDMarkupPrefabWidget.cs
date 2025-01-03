namespace YgomGame.MDMarkup
{
	public class MDMarkupPrefabWidget : MDMarkupWidgetBase
	{
		private readonly MDMarkupPrefabsFactory m_PrefabsFactory;

		public MDMarkupPrefabWidget(MDMarkupIndentWidget indentWidget, MDMarkupPrefabsFactory prefabsFactory)
			: base(null, null)
		{
		}

		public override void BindContentData(IMDMarkupContent contentData)
		{
		}
	}
}
