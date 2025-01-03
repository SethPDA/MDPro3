using UnityEngine;

namespace YgomGame.Shop
{
	public class ShopSettings : ScriptableObject
	{
		internal const string k_Path = "Definition/Shop/ShopSettings";

		[SerializeField]
		private ShopCategorySetting m_CategorySetting;

		[SerializeField]
		private ShopProductTypeSetting m_ProductTypeSetting;

		[SerializeField]
		private ShopInformButtonSettings m_ShopInformButtonSettings;

		[SerializeField]
		private int m_ShowcaseUnloadUnusedCnt;

		public ShopProductTypeSetting productTypeSetting => null;

		public int showcaseUnloadUnusedCnt => 0;

		public ShopCategoryShowcaseData GetShowcaseData()
		{
			return null;
		}

		public ShopCategoryData GetCategoryData(int categoryId)
		{
			return null;
		}

		public ShopSubCategoryData GetSubCategoryData(int categoryId, int subCategoryId)
		{
			return null;
		}

		public ShopSubCategorySectionData GetSubCategorySectionData(int categoryId, int subCategoryId, ProductContext product)
		{
			return null;
		}

		public ShopSubCategorySectionData GetSubCategorySectionData(int categoryId, int subCategoryId, int sectionId)
		{
			return null;
		}

		public bool FindBoolSetting(int categoryId, int subCategoryId, ProductContext product, string key, bool defaultValue = false)
		{
			return false;
		}

		public bool FindBoolSetting(int categoryId, int subCategoryId, int sectionId, string key, bool defaultValue = false)
		{
			return false;
		}

		public int FindIntSetting(int categoryId, int subCategoryId, ProductContext product, string key, int defaultValue = 0)
		{
			return 0;
		}

		public int FindIntSetting(int categoryId, int subCategoryId, int sectionId, string key, int defaultValue = 0)
		{
			return 0;
		}

		public string FindStringSetting(int categoryId, int subCategoryId, ProductContext product, string key, string defaultValue = null)
		{
			return null;
		}

		public string FindStringSetting(int categoryId, int subCategoryId, int sectionId, string key, string defaultValue = null)
		{
			return null;
		}

		public ShopInformButtonData[] GetProductInfoButtonDatas(ProductContext product)
		{
			return null;
		}
	}
}
