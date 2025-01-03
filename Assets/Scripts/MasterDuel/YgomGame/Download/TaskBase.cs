namespace YgomGame.Download
{
	public interface TaskBase
	{
		bool IsDone();

		bool IsSuccess();

		bool IsError();

		void Exec();
	}
}
