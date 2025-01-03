using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission
{
	public class MissionGoalsPagerWidget : ElementWidgetBase
	{
		private string k_ELabelShortcutKeyIconR;

		private string k_ELabelShortcutKeyIconL;

		public readonly MissionPanelWidget ownerPanel;

		public readonly Selector selector;

		public readonly ScrollRectPageSnap pageSnap;

		public readonly ScrollRectPageSnapButtons pageButtons;

		public readonly InfinityScrollView scrollView;

		public readonly ScrollRect scrollRect;

		public readonly List<MissionGoalsWidget> goalsWidgets;

		public Action<MissionGoalsPagerWidget> onPageChangedCallback;

		public Action onPlayPagingBeginCallback;

		public Action onPlayPagingEndCallback;

		public GameObject shortcutKeyIconR => null;

		public GameObject shortcutKeyIconL => null;

		public MissionGoalsWidget CurrentGoalsWidget => null;

		public bool IsEnabledPrev()
		{
			return false;
		}

		public bool IsEnabledNext()
		{
			return false;
		}

		public MissionGoalsPagerWidget(ElementObjectManager eom, MissionPanelWidget ownerPanel)
			: base(null)
		{
		}

		private void OnPagingTweenEnd()
		{
		}

		private void OnPageChanged()
		{
		}
	}
}
