using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableRow : ElementWidgetBase
	{
		private readonly string k_ELabelBG;

		public bool borderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool bgVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MDMarkupTableRow(ElementObjectManager eom)
			: base(null)
		{
		}
	}
}
