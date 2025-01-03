using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.MDMarkup
{
	public class MDMarkupGraphFactory : MonoBehaviour
	{
		public enum Style
		{
			Default = 0,
			Pager = 1
		}

		private readonly string k_MDTemplateContainerPath;

		private readonly string k_MDTemplateContainerPagerPath;

		private readonly string k_CLabelIndent0Template;

		private readonly string k_CLabelIndent1Template;

		private readonly string k_CLabelIndent2Template;

		private readonly string k_CLabelHeader1Template;

		private readonly string k_CLabelHeader2Template;

		private readonly string k_CLabelTextTemplate;

		private readonly string k_CLabelImageTemplate;

		private readonly string k_CLabelSeparatorTemplate;

		private readonly string k_CLabelSpacerSTemplate;

		private readonly string k_CLabelSpacerMTemplate;

		private readonly string k_CLabelSpacerLTemplate;

		private readonly string k_CLabelTableRootTemplate;

		private readonly string k_CLabelTableRowTemplate;

		private readonly string k_CLabelTableCellTextHeaderTemplate;

		private readonly string k_CLabelTableCellTextNormalTemplate;

		private readonly string k_CLabelTableCellImageTemplate;

		private readonly string k_CLabelTableCellCardTemplate;

		private readonly string k_CLabelTableCellItemTemplate;

		private readonly string k_CLabelTableCellBannerTemplate;

		private readonly string k_CLabelTableCellButtonSTemplate;

		private readonly string k_CLabelTableCellButtonMTemplate;

		private readonly string k_CLabelTableCellButtonLTemplate;

		private readonly string k_CLabelFullImagePageTemplate;

		private readonly string k_CLabelFullTextPageTemplate;

		private readonly string k_CLabelHalfImageTextPageTemplate;

		private readonly string k_CLabelHalfImageMarkupPageTemplate;

		public Style style;

		[SerializeField]
		private AssetLinkContainer m_MDTemplateContainer;

		private Dictionary<MDMarkupDef.MarkupType, IMDMarkupWidgetFactory> m_FactoryCacheMap;

		private MDMarkupIndentFactory m_IndentFactory;

		private Coroutine m_InitializeCoroutine;

		public MDMarkupIndentFactory indentFactory => null;

		private string GetContainerPath(Style style)
		{
			return null;
		}

		public void Initialize(Action onComplete)
		{
		}

		private IEnumerator yInitialize(Action onComplete)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public IEnumerator LoadOrGetMarkupFactory(MDMarkupDef.MarkupType markupType, Action<IMDMarkupWidgetFactory> callback)
		{
			return null;
		}
	}
}
