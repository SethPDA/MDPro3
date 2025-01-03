using System;
using YgomGame.Utility;

namespace YgomGame.Shop
{
	[Serializable]
	public class ShopSubCategoryData : ShopProductGroupTreeData<ShopSubCategorySectionData>
	{
		public ItemUtil.Category itemCategory;

		public override string labelText => null;

		public string GetProductLabel(ProductContext product)
		{
			return null;
		}

		public override bool IsMatchProduct(ProductContext product)
		{
			return false;
		}

		public ShopSubCategoryData()
		{
			//((ShopProductGroupTreeData<>)(object)this)._002Ector();
		}
	}
}
