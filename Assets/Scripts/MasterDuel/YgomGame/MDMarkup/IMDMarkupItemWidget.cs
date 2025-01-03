namespace YgomGame.MDMarkup
{
	public interface IMDMarkupItemWidget : IMDMarkupButtonWidget
	{
		bool itemIsPeriod { get; }

		int itemCategory { get; }

		int itemId { get; }
	}
}
