namespace YgomGame.DuelLive
{
	public interface IDuelLiveProductGruopData
	{
		int groupId { get; }

		string labelTextId { get; }

		string labelText { get; }

		bool IsMatchProduct(IProductContext product);
	}
}
