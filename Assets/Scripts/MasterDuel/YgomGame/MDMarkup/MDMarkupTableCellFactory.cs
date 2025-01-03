using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableCellFactory
	{
		private readonly ElementObjectManager m_NormalTextTemplate;

		private readonly ElementObjectManager m_HeaderTextTemplate;

		private readonly ElementObjectManager m_ImageTemplate;

		private readonly ElementObjectManager m_CardTemplate;

		private readonly ElementObjectManager m_ItemTemplate;

		private readonly ElementObjectManager m_BannerTemplate;

		private readonly ElementObjectManager m_ButtonSTemplate;

		private readonly ElementObjectManager m_ButtonMTemplate;

		private readonly ElementObjectManager m_ButtonLTemplate;

		public MDMarkupTableCellFactory(ElementObjectManager normalTemplate, ElementObjectManager headerTemplate, ElementObjectManager imageTemplate, ElementObjectManager cardTemplate, ElementObjectManager itemTemplate, ElementObjectManager bannerTemplate, ElementObjectManager buttonSTemplate, ElementObjectManager buttonMTemplate, ElementObjectManager buttonLTemplate)
		{
		}

		private ElementObjectManager GetTextCellTemplate(MDMarkupDef.TableRowStyle rowStyle)
		{
			return null;
		}

		public MDMarkupTableCellText CreateTextCell(MDMarkupTableRow parentRow, MDMarkupDef.TableRowStyle rowStyle)
		{
			return null;
		}

		public MDMarkupTableCellImage CreateImageCell(MDMarkupTableRow parentRow)
		{
			return null;
		}

		public MDMarkupTableCellCard CreateCardCell(MDMarkupTableRow parentRow)
		{
			return null;
		}

		public MDMarkupTableCellItem CreateItemCell(MDMarkupTableRow parentRow)
		{
			return null;
		}

		public MDMarkupTableCellBanner CreateBannerCell(MDMarkupTableRow parentRow)
		{
			return null;
		}

		public MDMarkupTableCellButton CreateButtonCell(MDMarkupTableRow parentRow, MDMarkupDef.ButtonStyle buttonStyle)
		{
			return null;
		}
	}
}
