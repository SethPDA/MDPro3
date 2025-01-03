using System;
using YgomGame.Utility;

namespace YgomGame.Shop
{
	[Serializable]
	public class ShopSubCategorySectionData : ShopProductGroupData
	{
		public ItemUtil.Category itemCategory;

		public override string labelText => null;

		public override bool IsMatchProduct(ProductContext product)
		{
			return false;
		}
	}
}
