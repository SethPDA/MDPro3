namespace YgomGame.Mission
{
	public interface IMissionSelectorHistoryHandler
	{
		bool isSelected { get; }

		void SaveSelectorHistory();

		bool TrySelectHistory();
	}
}
