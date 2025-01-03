using System.Collections.Generic;
using YgomSystem.UI;

namespace YgomGame.Shop
{
	public class ShowcaseWidgetsController
	{
		public enum SelectBlockOperate
		{
			None = 0,
			CurrentBlock = 1,
			CurrentMainTab = 2,
			CurrentSubTabList = 3,
			HeadProduct = 4
		}

		public enum AcordionOperate
		{
			None = 0,
			Auto = 1,
			Switch = 2,
			Expand = 3,
			Shrink = 4
		}

		private readonly ViewController m_Owner;

		private readonly ShopSettings m_ShopSettings;

		private readonly ShopViewController.ShowcaseData m_ShowcaseData;

		private readonly MainTabListWidget m_MainTabList;

		private readonly SubTabListWidget m_SubTabList;

		private readonly ProductListWidget m_ProductList;

		private Dictionary<int, Dictionary<int, bool>> m_AutoAcordionShrinkMap;

		private bool m_InProgress;

		public bool inProgress => false;

		public ShowcaseWidgetsController(ViewController owner, ShopSettings shopSettings, ShopViewController.ShowcaseData showcaseData, MainTabListWidget mainTabList, SubTabListWidget subTabList, ProductListWidget productList)
		{
		}

		private bool IsAutoAcordionShrink(int categoryId, int subCategoryId)
		{
			return false;
		}

		private void SetAutoAcordionShrink(int categoryId, int subCategoryId, bool value)
		{
		}

		public void ApplyAllImmediate()
		{
		}

		public bool MoveByProductListScroll(int categoryId, int subCategoryId, int sectionId, bool isInitializeSelect = false)
		{
			return false;
		}

		public bool MoveMainCategoryByTab(int categoryIdx, SelectBlockOperate selectBlock = SelectBlockOperate.HeadProduct, bool isInitializeSelect = false)
		{
			return false;
		}

		public bool MoveSubCategoryByTab(int subCategoryIdx, int sectionIdx, AcordionOperate acordionOperate = AcordionOperate.None, SelectBlockOperate selectBlock = SelectBlockOperate.HeadProduct, bool isInitializeSelect = false)
		{
			return false;
		}

		private bool InnerChangeCategories(int categoryId, int subCategoryId, int sectionId, AcordionOperate acordionOperate, SelectBlockOperate selectBlockOperate, bool focusProductList, bool immediate, bool isInitializeSelect = false)
		{
			return false;
		}

		public void OperateTargetAcordion((int, int, int) targetIds, AcordionOperate acordionOperate)
		{
		}

		private void FocusProductListImmediate()
		{
		}

		public void UpdateBgView()
		{
		}

		public bool TrySelectBlock(SelectBlockOperate selectBlockOperate, bool isInitializeSelect = false)
		{
			return false;
		}

		private bool TrySelectHeadProduct(bool isInitializeSelect = false)
		{
			return false;
		}

		private bool TrySelectCurrentSubTab(bool isInitializeSelect = false)
		{
			return false;
		}

		private bool TrySelectMainTab(bool isInitializeSelect = false)
		{
			return false;
		}
	}
}
