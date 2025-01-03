using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive
{
	public class ProductShowcaseWidget : ElementWidgetBase
	{
		public class Context
		{
			public List<SubTabListWidget.TabContext> subTabListCtx;

			public readonly ProductListWidget.Context productListCtx;

			public bool existsSubTab => false;
		}

		private const string k_ELabelSubTabs = "SubTabs";

		private readonly SubTabListWidget m_SubTabListWidget;

		private readonly ProductListWidget m_ProductListWidget;

		private readonly Selector[] m_Selectors;

		public readonly Context ctx;

		public SubTabListWidget subTabListWidget => null;

		public ProductListWidget productListWidget => null;

		public ProductShowcaseWidget(ElementObjectManager eom, DuelLiveRootWidget owner, bool frag = false)
			: base(null)
		{
		}

		public void SetActive(bool isActive)
		{
		}

		public bool TrySelectDefault(bool isInitializeSelect = false)
		{
			return false;
		}
	}
}
