using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableCellBanner : ElementWidgetBase, IMDMarkupAsyncWidget, IMDMarkupLayoutWidget
	{
		private readonly string k_ELabelBannerHolder;

		private RectTransform m_BannerHolder;

		private MDMarkupBannerContext m_BannerContext;

		private int m_LoadingCnt;

		private Vector2 m_BannerSize;

		private float m_OverrideHeight;

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

		public bool isReady => false;

		public MDMarkupTableCellBanner(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetAlignment(TextAlignmentOptions alignment)
		{
		}

		public void SetSizeRate(float sizeRate)
		{
		}

		public void SetBanner(MDMarkupBannerContext bannerContext, float overrideHeight)
		{
		}

		public void OnReady()
		{
		}

		public void OnConcreatedLayout()
		{
		}
	}
}
