using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission
{
	public class MissionGoalHolderWidget : ElementWidgetBase
	{
		public int idx;

		public readonly MissionGoalsWidget ownerGoals;

		public readonly SelectionButton button;

		public readonly GameObject root;

		public MissionGoalWidget goalWidget;

		private LayoutElement m_LayoutElementCache;

		public Action<MissionGoalHolderWidget> onClickCallback;

		public Action<MissionGoalHolderWidget> onSelectedCallback;

		public Action<MissionGoalHolderWidget> onDeselectedCallback;

		public LayoutElement layoutElement => null;

		public MissionGoalHolderWidget(ElementObjectManager eom, MissionGoalsWidget ownerGoals)
			: base(null)
		{
		}

		private void OnClick()
		{
		}

		private void OnSelected()
		{
		}

		private void OnDeselected()
		{
		}
	}
}
