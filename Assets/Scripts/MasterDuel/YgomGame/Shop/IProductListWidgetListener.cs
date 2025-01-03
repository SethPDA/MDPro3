using UnityEngine;

namespace YgomGame.Shop
{
	public interface IProductListWidgetListener
	{
		void OnProductListScrolled(Vector2 value);

		void OnFocusProductLine(ProductContext product);

		void OnClickProduct(ProductWidget productWidget);
	}
}
