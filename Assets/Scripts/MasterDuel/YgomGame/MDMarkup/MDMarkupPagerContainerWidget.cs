using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupPagerContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget
	{
		private readonly string k_ELabelTitleText;

		private readonly string k_ELabelScrollView;

		private readonly string k_ELabelCloseButton;

		private readonly string k_ELabelBackShortcutButton;

		private readonly string k_ELabelFooter;

		private ScrollRect m_ScrollRect;

		private SlidePagerWidget m_SlidePagerWidget;

		private MDMarkupGraphWidget m_MarkupGraphWidget;

		private MDMarkupPagerContainer m_ContainerData;

		private GameObject m_Footer;

		private SelectionButton m_CloseButton;

		private SelectionButton m_BackShortcutButton;

		private List<int> m_FocusedPages;

		public bool titleVisible;

		public MDMarkupDef.CloseButtonType closeButtonType;

		public MDMarkupGraphWidget markupGraph => null;

		public event Action onClickCloseEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public MDMarkupPagerContainerWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(IMDMarkupContainer containerData)
		{
		}

		public void Output(MDMarkupGraphFactory graphFactory, Action onComplete)
		{
		}

		public void OnStart(Dictionary<string, object> args)
		{
		}

		private void OnGraphOutputComplete(MDMarkupGraphWidget graphWidget)
		{
		}

		private void OnPageChanged()
		{
		}
	}
}
