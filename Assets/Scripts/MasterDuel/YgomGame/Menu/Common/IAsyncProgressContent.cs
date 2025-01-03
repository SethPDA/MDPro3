namespace YgomGame.Menu.Common
{
	public interface IAsyncProgressContent
	{
		bool IsDone();

		void ProgressUpdate();
	}
}
