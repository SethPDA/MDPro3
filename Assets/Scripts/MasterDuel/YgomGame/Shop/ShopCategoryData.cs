using System;

namespace YgomGame.Shop
{
	[Serializable]
	public class ShopCategoryData : ShopProductGroupTreeData<ShopSubCategoryData>
	{
		public ShopDef.ShowcaseCategory category => default(ShopDef.ShowcaseCategory);

		public override bool IsMatchProduct(ProductContext product)
		{
			return false;
		}

		public ShopCategoryData()
		{
			//((ShopProductGroupTreeData<>)(object)this)._002Ector();
		}
	}
}
