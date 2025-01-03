namespace YgomGame.Shop
{
	public interface ISubTabWidget
	{
		SubTabGroupWidget parentGroup { get; }

		ShopTabWidget tabWidget { get; }
	}
}
