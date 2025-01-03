using System;
using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive
{
	public class DuelLiveRootWidget : ElementWidgetBase
	{
		public class Context
		{
			public readonly DuelLiveSettings duelLiveSettings;

			public readonly ProductContextCollection<DuelLiveProductContext> productCollection;

			public Context(DuelLiveSettings duelLiveSettings)
			{
			}

			public void ImportAll()
			{
			}
		}

		private const string k_ELabelMonsterImage = "MonsterImage";

		private const string k_ALabelGroupHeaderPref = "DuelLiveGroupHeaderWidget";

		private const string k_ALabelGroupEmptyPref = "DuelLiveGroupEmptyWidget";

		private const string k_ALabelContainerWidget = "DuelLiveContainerWidget";

		private const string k_ALabelProductWidgetPref = "DuelLiveProductWidget";

		private const string k_ALabelProductRandomWidgetPref = "DuelLiveProductRandomWidget";

		private const string k_ALabelProductVSWidgetPref = "DuelLiveProductVSWidget";

		private const string k_ALabelProductEventWidgetPref = "DuelLiveProductEventWidget";

		private const string k_ALabelProductOfficialAccountWidgetPref = "DuelLiveProductOfficialAccountWidget";

		private const string k_ALabelProductCommingSoonWidgetPref = "DuelLiveProductCommingSoonWidget";

		public readonly ProductShowcaseWidget productShowcase;

		private Context m_Context;

		public bool isPopWallPaper;

		private List<List<IProductContext>> m_SubProductsTmpList;

		public Context context => null;

		public int currentSubTabIdx => 0;

		public int currentSubTabSectionIdx => 0;

		public ProductShowcaseWidget currentShowcase => null;

		public ProductShowcaseWidget.Context currentShowcaseCtx => null;

		public ProductListWidget currentProductList => null;

		public ProductListWidget.Context currentProductListCtx => null;

		public SubTabListWidget currentSubTabList => null;

		public List<SubTabListWidget.TabContext> currentSubTabListCtxs => null;

		public SubTabListWidget.TabContext currentSubTabListCtx => null;

		public int currentSubTabSectionLength => 0;

		public int GetSectionIdxByProduct(IProductContext product)
		{
			return 0;
		}

		public DuelLiveRootWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void InitContext(Context context)
		{
		}

		public void InitData()
		{
		}

		private void InitProductGruopData()
		{
		}

		private void InitBGImage()
		{
		}

		public void InitSubCategoryTab()
		{
		}

		public void InitProduct(Action onComplete)
		{
		}

		public void UpdateProductContexts()
		{
		}

		public void UpdateShowcase(int asyncCnt = 0, bool resetPos = true, Action onComplete = null)
		{
		}

		public void UpdateProductList(int asyncCnt = 0, bool resetPos = true, Action onComplete = null)
		{
		}

		public void UpdateSubTabList()
		{
		}
	}
}
