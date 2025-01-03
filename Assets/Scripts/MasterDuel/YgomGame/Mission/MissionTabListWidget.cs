using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission
{
	public class MissionTabListWidget : ElementWidgetBase
	{
		public readonly InfinityScrollView scrollView;

		public readonly ScrollRect scrollRect;

		public bool isSelected => false;

		public MissionTabListWidget(ElementObjectManager eom)
			: base(null)
		{
		}
	}
}
