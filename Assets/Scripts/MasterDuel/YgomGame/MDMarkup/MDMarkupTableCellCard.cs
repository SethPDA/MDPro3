using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableCellCard : ElementWidgetBase, IMDMarkupCardWidget, IMDMarkupButtonWidget
	{
		private readonly string k_ELabelButton;

		private readonly string k_ELabelRoot;

		private readonly string k_ELabelImage;

		public readonly LayoutElement m_LayoutElement;

		public readonly RectTransform m_Root;

		public readonly AspectRatioFitter m_AspectRatioFitter;

		public readonly RawImage m_CardImage;

		public bool borderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int cardMrk
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int cardPremire
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SelectionButton button
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MDMarkupTableCellCard(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetCard(int mrk, int premire, MDMarkupDef.CardSize cardSize, float overrideHeight = 0f)
		{
		}

		public void SetAlignment(TextAlignmentOptions alignment)
		{
		}

		public void SetSizeRate(float sizeRate)
		{
		}

		public void SetOnClick(UnityAction callback)
		{
		}
	}
}
