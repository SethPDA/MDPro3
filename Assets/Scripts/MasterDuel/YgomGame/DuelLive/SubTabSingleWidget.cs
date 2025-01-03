using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive
{
	public class SubTabSingleWidget : ElementWidgetBase, ISubTabWidget
	{
		private readonly SubTabGroupWidget m_ParentGroupWidget;

		private readonly DuelLiveTabWidget m_TabWidget;

		public DuelLiveTabWidget tabWidget => null;

		public SubTabGroupWidget parentGroup => null;

		public SubTabSingleWidget(ElementObjectManager eom, SubTabGroupWidget parentGroupWidget = null)
			: base(null)
		{
		}
	}
}
