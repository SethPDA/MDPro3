using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class SubTabSingleWidget : ElementWidgetBase, ISubTabWidget
	{
		private readonly SubTabGroupWidget m_ParentGroupWidget;

		private readonly ShopTabWidget m_TabWidget;

		public ShopTabWidget tabWidget => null;

		public SubTabGroupWidget parentGroup => null;

		public SubTabSingleWidget(ElementObjectManager eom, SubTabGroupWidget parentGroupWidget = null)
			: base(null)
		{
		}
	}
}
