using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission
{
	public class MissionBulkRecieveButtonWidget : ElementWidgetBase
	{
		public readonly SelectionButton button;

		public readonly GameObject numBadge;

		public readonly TMP_Text numBadgeText;

		public MissionBulkRecieveButtonWidget(ElementObjectManager eom)
			: base(null)
		{
		}
	}
}
