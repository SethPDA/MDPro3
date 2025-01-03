using System;
using System.Collections.Generic;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTabsContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget
	{
		private readonly string k_ELabelTitleText;

		private readonly string k_ELabelScrollViewTemplate;

		private readonly string k_ELabelTabGroup;

		private readonly string k_ELabelTabTemplate;

		private readonly string k_ELabelTabOnLabel;

		private readonly string k_ELabelTabOffLabel;

		private readonly string k_ELabelShortcutButtonBack;

		private readonly string k_ELabelShortcutButtonNext;

		private ScrollRect[] m_ScrollRects;

		private MDMarkupGraphWidget[] m_MarkupGraphs;

		private ToggleGroupWidget m_ToggleGroupWidget;

		private MDMarkupTabsContainer m_ContainerData;

		private MDMarkupGraphFactory m_GraphFactory;

		public MDMarkupTabsContainerWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(IMDMarkupContainer containerData)
		{
		}

		public void Output(MDMarkupGraphFactory graphFactory, Action onComplete)
		{
		}

		private void OutputGraph(int idx, Action onComplete)
		{
		}

		public void OnStart(Dictionary<string, object> args)
		{
		}

		private void OnChangeIdx(int newIdx)
		{
		}
	}
}
