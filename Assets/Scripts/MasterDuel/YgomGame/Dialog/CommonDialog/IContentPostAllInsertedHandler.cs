namespace YgomGame.Dialog.CommonDialog
{
	public interface IContentPostAllInsertedHandler
	{
		bool rebuildLayoutOnPostAllInserted { get; }

		void OnPostAllInserted();
	}
}
