using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.MDMarkup
{
	public class MDMarkupBoardContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget
	{
		private class Footer : ElementWidgetBase
		{
			private readonly SelectionButton m_ButtonTemplate;

			private readonly TMP_Text m_TextTemplate;

			public Footer(ElementObjectManager eom)
				: base(null)
			{
			}

			public SelectionButton InsertButton()
			{
				return null;
			}

			public TMP_Text InsertText()
			{
				return null;
			}
		}

		private readonly string k_ELabelTitleText;

		private readonly string k_ELabelBadge;

		private readonly string k_ELabelOptionalText;

		private readonly string k_ELabelScrollView;

		private readonly string k_ELabelFooter;

		private Footer m_Footer;

		private ScrollRect m_ScrollRect;

		private FreeScrollView m_FreeScrollView;

		private MDMarkupBoardContainer m_ContainerData;

		public ScrollRect scrollRect => null;

		public bool existsFooter => false;

		public TextMeshProUGUI titleText => null;

		public GameObject badge => null;

		public TextMeshProUGUI optionalText => null;

		public MDMarkupBoardContainerWidget(ElementObjectManager eom)
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
	}
}
