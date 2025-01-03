using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class ShopViewController : BaseMenuViewController, IMainTabListWidgetListener, IProductListWidgetListener, ISubTabListWidgetListener, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported, IGemSupported
	{
		private class MainTabListWidgetHandler : IMainTabListWidgetHandler
		{
			private readonly ShowcaseData m_ShowcaseData;

			public int currentIdx => 0;

			public MainTabListWidgetHandler(ShowcaseData showcaseData)
			{
			}

			public void OnUpdateMainTabDataCount(IReadOnlyList<ShopTabWidget> sourceTabWidgets, List<ShopTabWidget> activeTabWidets)
			{
			}

			public void OnUpdateMainTabData(IReadOnlyList<ShopTabWidget> activeTabWidets)
			{
			}
		}

		private class ProductListWidgetHandler : IProductListWidgetHandler, IProductContainerWidgetHandler
		{
			private readonly ProductListWidget m_ProductList;

			private readonly ProductWidgetController m_ProductWidgetController;

			private readonly ShowcaseData m_ShowcaseData;

			private readonly Dictionary<int, Dictionary<int, List<ProductContext>>> m_SubProductsTmpList;

			private List<Vector2> m_SizeListCache;

			public ProductWidgetController productWidgetController => null;

			public int showcaseUnloadUnusedCnt
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

			public ProductListWidgetHandler(ProductListWidget productList, ProductWidgetController productWidgetController, ShowcaseData showcaseData)
			{
			}

			public void SetShowcaseUnloadUnusedCnt(int cnt)
			{
			}

			public bool EqualCurrentCategoryId(int chkCategoryId, int chkSubCategoryId, int chkSectionId)
			{
				return false;
			}

			public void OnUpdateDataCount(List<int> templateIdxList, List<string> headerLabels, Dictionary<int, Dictionary<int, Dictionary<int, int>>> headerDataIdxMap, List<ProductContainerWidget.Context> productContainerCtxs)
			{
			}

			private void InsertListLabel(string label, int categoryId, int subCategoryId, int sectionId, List<int> templateIdxList, List<string> headerLabels, Dictionary<int, Dictionary<int, Dictionary<int, int>>> headerDataIdxMap, List<ProductContainerWidget.Context> productContainerCtxs)
			{
			}

			private void InsertListEmpty(List<int> templateIdxList, List<string> headerLabels, List<ProductContainerWidget.Context> productContainerCtxs)
			{
			}

			private void InsertProducts(List<ProductContext> products, List<int> templateIdxList, List<string> headerLabels, List<ProductContainerWidget.Context> productContainerCtxs, bool wrapAround = false)
			{
			}

			public void UpdateProductWidget(ProductWidget productWidget, ProductContext productCtx)
			{
			}
		}

		public class ShowcaseData
		{
			public enum IdType
			{
				None = 0,
				CategoryId = 1,
				SubCategoryId = 2,
				SectionId = 3
			}

			public enum IdFlag
			{
				None = 0,
				CategoryId = 2,
				SubCategoryId = 4,
				SectionId = 8
			}

			private readonly Dictionary<ShopDef.ShowcaseCategory, ProductContextCollection> m_ProductCollectionMap;

			private readonly Dictionary<int, ProductContext> m_ProductContextMap;

			private readonly List<int> m_CategoryIds;

			private readonly Dictionary<int, IShopProductGruopData> m_CategoryDatas;

			private readonly Dictionary<int, List<int>> m_SubCategoryIds;

			private readonly Dictionary<int, Dictionary<int, IShopProductGruopData>> m_SubCategoryDatas;

			private readonly Dictionary<int, Dictionary<int, List<int>>> m_SectionIds;

			private readonly Dictionary<int, Dictionary<int, Dictionary<int, IShopProductGruopData>>> m_SectionDatas;

			private Dictionary<int, bool> m_TurnoffBadgeMap;

			private int m_CurrentCategoryId;

			private int m_CurrentSubCategoryId;

			private int m_CurrentSectionId;

			private int m_CurrentCategoryIdx;

			private int m_CurrentSubCategoryIdx;

			private int m_CurrentSectionIdx;

			public List<int> categoryIds => null;

			public int currentCategoryId => 0;

			public int currentSubCategoryId => 0;

			public int currentSectionId => 0;

			public int currentCategoryIdx => 0;

			public int currentSubCategoryIdx => 0;

			public int currentSectionIdx => 0;

			public ProductContext GetProductContext(int shopId)
			{
				return null;
			}

			public ProductContextCollection GetProductCollection(int categoryId)
			{
				return null;
			}

			public ProductContextCollection GetProductCollection(ShopDef.ShowcaseCategory productCategory)
			{
				return null;
			}

			public IdFlag DiffCurrentIds(int categoryId, int subCategoryId, int sectionId)
			{
				return default(IdFlag);
			}

			public (int, int, int) GetCurrentIds()
			{
				return default((int, int, int));
			}

			public int GetCategoriesLength()
			{
				return 0;
			}

			public IShopProductGruopData GetCategoryData(int categoryId)
			{
				return null;
			}

			public List<int> GetSubcategories(int categoryId)
			{
				return null;
			}

			public int GetSubcategoriesLength(int categoryId)
			{
				return 0;
			}

			public List<int> GetSections(int categoryId, int subCategoryId)
			{
				return null;
			}

			public int GetSectionsLength(int categoryId, int subCategoryId)
			{
				return 0;
			}

			public IShopProductGruopData GetSubCategoryData(int categoryId, int subCategoryId)
			{
				return null;
			}

			public IShopProductGruopData GetSectionData(int categoryId, int subCategoryId, int sectionId)
			{
				return null;
			}

			public bool ExistsCategories(int categoryId, int subCategoryId = 0, int sectionId = 0)
			{
				return false;
			}

			public bool ExistsCategory(int categoryId)
			{
				return false;
			}

			public int IndexOfCategory(int categoryId)
			{
				return 0;
			}

			public int CategoryOfIndex(int categoryIdx)
			{
				return 0;
			}

			public bool ExistsSubCategory(int categoryId, int subCategoryId)
			{
				return false;
			}

			public int IndexOfSubCategory(int categoryId, int subCategoryId)
			{
				return 0;
			}

			public int SubCategoryOfIndex(int categoryIdx, int subCategoryIdx)
			{
				return 0;
			}

			public bool ExistsSection(int categoryId, int subCategoryId, int sectionId)
			{
				return false;
			}

			public int IndexOfSection(int categoryId, int subCategoryId, int sectionId)
			{
				return 0;
			}

			public int SectionOfIndex(int categoryIdx, int subCategoryIdx, int sectionIdx)
			{
				return 0;
			}

			public bool HasSection(int categoryId, int subCategoryId)
			{
				return false;
			}

			public bool ExistsCategoryBadge(int categoryId, int subCategoryId = 0, int sectionId = 0)
			{
				return false;
			}

			public bool IsBadgeProduct(ProductContext productContext)
			{
				return false;
			}

			private bool IsTrunoff(int shopId)
			{
				return false;
			}

			public List<int> CreateVisitBadgeList()
			{
				return null;
			}

			public void SetCurrentId(int categoryId, int subCategoryId, int sectionId)
			{
			}

			public void ImportAll(ShopSettings shopSettings, CardCategoryData cardCategoryData)
			{
			}

			private void ClearCategory()
			{
			}

			private void AddCategory(IShopProductGruopData categoryData)
			{
			}

			private void ClearSubCategory(int categoryId)
			{
			}

			private void AddSubCategory(int categoryId, IShopProductGruopData subCategoryData)
			{
			}

			private void ClearSection(int categoryId, int subCategoryId)
			{
			}

			private void AddSection(int categoryId, int subCategoryId, IShopProductGruopData sectionData)
			{
			}

			public bool TurnoffCategoryBadges(ShopSettings shopSettings, int categoryId, int subCategoryId = 0, int sectionId = 0)
			{
				return false;
			}
		}

		private class SubTabListWidgetHandler : ISubTabListWidgetHandler
		{
			private readonly ShowcaseData m_ShowcaseData;

			public int currentIdx => 0;

			public int currentSectionIdx => 0;

			public SubTabListWidgetHandler(ShowcaseData showcaseData)
			{
			}

			public (int, int) CategoryIdOfIndex(int dataIdx)
			{
				return default((int, int));
			}

			public void OnUpdateSubTabWidget(List<int> templateIds)
			{
			}

			public void OnUpdateTabWidget(ShopTabWidget widget, int dataIdx)
			{
			}

			public void OnUpdateSectionFactory(ElementEntityFactory entityFactory, int dataIdx)
			{
			}

			public void OnUpdateSectionTabWidget(ShopTabWidget widget, int dataIdx, int sectionIdx)
			{
			}
		}

		private bool m_IsStarted;

		private bool m_ReimportDirty;

		private Selector m_ResumeSelector;

		private int m_ResumeCategoryId;

		private int m_ResumeSubcategoryId;

		private int m_ResumeSectionId;

		private int m_ResumeProductId;

		private string m_ResumeDialogTitle;

		private string m_ResumeDialogMessage;

		public const string k_ArgsLaunchCategory = "category";

		public const string k_ArgsLaunchSubCategory = "subcategory";

		public const string k_ArgsLaunchSection = "section";

		private const string k_ALinkerLabel_BuyView = "BuyView";

		private const string k_ALabelProductWidgetMap = "ProductWidgetMap";

		private const string k_ELabelMainTabs = "CategoryTabs";

		private const string k_ELabelSubTabs = "ShowcaseWidget/SubTabs";

		private const string k_ELabelProductList = "ShowcaseWidget";

		private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

		private const string k_ELabelShortcutButtonBack = "ShortcutButtonBack";

		private const string k_ELabelShortcutButtonCancel = "ShortcutButtonCancel";

		private const string k_ELabelShortcutButtonL1 = "ShortcutButtonL1";

		private const string k_ELabelShortcutButtonR1 = "ShortcutButtonR1";

		private ShopSettings m_ShopSettings;

		private ProductWidgetController m_ProductWidgetController;

		private ShowcaseWidgetsController m_ShowcaseWidgetsController;

		private MainTabListWidget m_MainTabList;

		private SubTabListWidget m_SubTabList;

		private ProductListWidget m_ProductList;

		private CardCategoryData m_CardCategoryData;

		private ShowcaseData m_ShowcaseData;

		private IEnumerator m_InitRoutine;

		private bool m_IsHighEnd;

		private string m_CachedShopBuyUIPath;

		private List<ProductContext> m_BuyProductContexts;

		protected override bool setProgressOnInitialize => false;

		protected override bool setSurfaceActiveOnInitialize => false;

		protected override Type[] textIds => null;

		public void OnInputUpMainTab()
		{
		}

		public void OnInputLeftMainTab()
		{
		}

		public void OnInputRightMainTab()
		{
		}

		public void OnInputDownMainTab()
		{
		}

		public void OnClickMainTab(int idx)
		{
		}

		private void OnActivate()
		{
		}

		private void OnActivateInit()
		{
		}

		private void OnActivateResume()
		{
		}

		private void ResumeShowcase()
		{
		}

		private bool TryResumeFocusProduct()
		{
			return false;
		}

		private bool TryResumeFocusHeadProduct()
		{
			return false;
		}

		private bool TryResumeFocusHeader()
		{
			return false;
		}

		private bool TryResumeFocusSubTab()
		{
			return false;
		}

		private void ResumeFocusMainTab()
		{
		}

		private void OnPreDeactivate()
		{
		}

		private void OnDeactivate()
		{
		}

		public void OnProductListScrolled(Vector2 value)
		{
		}

		public void OnFocusProductLine(ProductContext product)
		{
		}

		public void OnClickProduct(ProductWidget productWidget)
		{
		}

		public bool OnInputDirectionSubCategory(PadInputDirection direction)
		{
			return false;
		}

		private bool TryTransitionSection(int dir, bool isInitializeSelect = false)
		{
			return false;
		}

		private bool TryTransitionSubCategory(int dir, bool isInitializeSelect = false)
		{
			return false;
		}

		public void OnClickSubCategory(int dataIdx)
		{
		}

		public void OnClickSubCategoryGroup(int dataIdx)
		{
		}

		public void OnClickSubCategorySection(int dataIdx, int sectionIdx)
		{
		}

		public static void OpenOnHome(Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override float Progress()
		{
			return 0f;
		}

		public override void ProgressUpdate()
		{
		}

		private IEnumerator yInitialize(Action onComplete)
		{
			return null;
		}

		private void InitializeData()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private bool TryOpenShopBuy(int shopId)
		{
			return false;
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		private void OnInputShortcutL1()
		{
		}

		private void OnInputShortcutR1()
		{
		}
	}
}
