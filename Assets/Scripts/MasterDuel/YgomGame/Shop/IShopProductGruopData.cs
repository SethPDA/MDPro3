namespace YgomGame.Shop
{
	public interface IShopProductGruopData
	{
		int groupId { get; }

		string labelTextId { get; }

		string labelText { get; }

		bool constant { get; }

		bool IsMatchProduct(ProductContext product);

		int FindIntData(string key, int defaultValue = 0);

		string FindStringData(string key, string defaultValue = null);
	}
}
