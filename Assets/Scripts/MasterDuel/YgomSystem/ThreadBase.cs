using System.Threading;

namespace YgomSystem
{
	public class ThreadBase
	{
		private const int WaitOneFrame = 16;

		private Thread ThreadInstance;

		private bool IsExec;

		public virtual bool Run(object parameter = null)
		{
			return false;
		}

		public virtual void Terminate()
		{
		}

		public virtual bool IsRun()
		{
			return false;
		}

		public virtual void Join()
		{
		}

		protected virtual void Sleep(int msec)
		{
		}

		protected virtual bool InitThread(object parameter)
		{
			return false;
		}

		protected virtual bool ExecThread(object parameter)
		{
			return false;
		}

		protected virtual void ExitThread(object parameter)
		{
		}

		private void ThreadProc(object parameter)
		{
		}
	}
}
