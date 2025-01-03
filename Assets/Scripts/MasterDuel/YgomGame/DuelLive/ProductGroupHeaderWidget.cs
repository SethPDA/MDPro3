using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive
{
	public class ProductGroupHeaderWidget : ElementWidgetBase
	{
		private const string k_ELabelLabel = "Label";

		public readonly TMP_Text label;

		public ProductGroupHeaderWidget(ElementObjectManager eom)
			: base(null)
		{
		}
	}
}
