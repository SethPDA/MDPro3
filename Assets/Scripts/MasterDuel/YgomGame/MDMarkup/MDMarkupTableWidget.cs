using System.Collections.Generic;
using TMPro;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableWidget : MDMarkupWidgetBase, IMDMarkupCardContainWidget, IMDMarkupItemContainWidget, IMDMarkupLinkContainWidget, IMDMarkupLayoutWidget, IMDMarkupTMPWidget
	{
		private readonly MDMarkupTableRowFactory m_RowFactory;

		private readonly MDMarkupTableCellFactory m_CellFactory;

		private readonly List<IMDMarkupTMPWidget> m_TMPWidgets;

		private readonly List<IMDMarkupAsyncWidget> m_AsyncWidgets;

		private readonly List<IMDMarkupLayoutWidget> m_LayoutWidgets;

		private float[] m_ColSizes;

		public List<IMDMarkupCardWidget> m_CardWidgets;

		public List<IMDMarkupItemWidget> m_ItemWidgets;

		public List<IMDMarkupLinkWidget> m_LinkWidgets;

		public float[] colSizes => null;

		public override bool isReady => false;

		public IReadOnlyList<IMDMarkupCardWidget> cardWidgets => null;

		public IReadOnlyList<IMDMarkupItemWidget> itemWidgets => null;

		public IReadOnlyList<IMDMarkupLinkWidget> linkWidgets => null;

		public MDMarkupTableWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget, MDMarkupTableRowFactory rowFactory, MDMarkupTableCellFactory cellFactory)
			: base(null, null)
		{
		}

		public override void BindContentData(IMDMarkupContent mdMarkupContent)
		{
		}

		public override void OnReady()
		{
		}

		public void OnConcreatedLayout()
		{
		}

		public void AddContainTMPTexts(List<TMP_Text> results)
		{
		}
	}
}
