using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableCellItem : ElementWidgetBase, IMDMarkupItemWidget, IMDMarkupButtonWidget
	{
		private readonly string k_ELabelButton;

		private readonly string k_ELabelRoot;

		private readonly string k_ELabelThumbHolder;

		private readonly string k_OVGroupLabel_Default;

		private readonly string k_OVGroupLabel_Structure;

		public readonly PlatformOverriderGroup m_OVGroup;

		public readonly LayoutElement m_LayoutElement;

		public readonly RectTransform m_Root;

		public readonly AspectRatioFitter m_AspectRatioFitter;

		public readonly GameObject m_ThumbHolder;

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

		public bool itemIsPeriod
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int itemCategory
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

		public int itemId
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

		public MDMarkupTableCellItem(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetItem(bool isPeriod, int itemCategory, int itemId, MDMarkupDef.ItemSize itemSize, float overrideHeight = 0f)
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
