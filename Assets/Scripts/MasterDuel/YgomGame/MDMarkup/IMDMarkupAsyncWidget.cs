namespace YgomGame.MDMarkup
{
	public interface IMDMarkupAsyncWidget
	{
		bool isReady { get; }

		void OnReady();
	}
}
