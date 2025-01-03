using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Shop;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.OpenResult
{
	public class SecretPulldownWidget : ElementWidgetBase
	{
		public class ExpandsWidget : ElementWidgetBase
		{
			private readonly string k_ELabelLineHead;

			private readonly string k_ELabelLineTemplate;

			private readonly string k_ELineLabelText;

			private readonly ElementObjectManager m_LineTemplate;

			private List<ElementObjectManager> m_LineEoms;

			public ExpandsWidget(ElementObjectManager eom)
				: base(null)
			{
			}

			public void Binding(IReadOnlyList<int> shopIds)
			{
			}
		}

		private readonly string k_ELabelLabelRoot;

		private readonly string k_ELabelLabelText;

		private readonly string k_ELabelExpands;

		private readonly string k_TweenOpen;

		private readonly string k_TweenClose;

		public readonly SelectionItem selectionItem;

		private readonly GameObject m_LabelRoot;

		private readonly TMP_Text m_LabelText;

		private readonly ExpandsWidget m_ExpandsWidget;

		private readonly ProductContext m_PackProductContent;

		private List<int> m_ShopIds;

		private bool m_IsExpanded;

		private bool m_ExpandDirty;

		public bool isExpanded => false;

		public SecretPulldownWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Binding(IReadOnlyList<int> shopIds, bool isExpand = false)
		{
		}

		public void OpenExpand(bool isTween = true, bool enableRetry = false)
		{
		}

		public void CloseExpand(bool isTween = true, bool enableRetry = false)
		{
		}

		private void OnTweenOpenStart()
		{
		}

		private void OnTweenCloseEnd()
		{
		}
	}
}
