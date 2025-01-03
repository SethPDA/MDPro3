using UnityEngine;

namespace YgomGame.Shop
{
	public class ShopCategorySetting : ScriptableObject
	{
		[SerializeField]
		private ShopCategoryShowcaseData m_ShowcaseData;

		public ShopCategoryShowcaseData showcaseData => null;

		public ShopCategoryData GetCategoryData(int categoryId)
		{
			return null;
		}
	}
}
