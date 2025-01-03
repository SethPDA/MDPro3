using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission
{
	public class MissionTabWidget : ElementWidgetBase
	{
		private GameObject onRoot => null;

		private GameObject offRoot => null;

		public string label
		{
			set
			{
			}
		}

		public bool isOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool badgeVisible
		{
			set
			{
			}
		}

		public bool numBadgeVisible
		{
			set
			{
			}
		}

		public int numBadgeCnt
		{
			set
			{
			}
		}

		public bool completeVisible
		{
			set
			{
			}
		}

		public SelectionButton button => null;

		public MissionTabWidget(ElementObjectManager eom)
			: base(null)
		{
		}
	}
}
