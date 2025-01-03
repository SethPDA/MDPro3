using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class PreHomeViewController : ViewController
	{
		private enum Step
		{
			WaitDownload = 0,
			Idle = 1,
			Wait1 = 2,
			Wait2 = 3,
			Wait3 = 4,
			GoHome = 5
		}

		public const string PREFAB_PATH = "Home/PreHome";

		private Step step;

		private bool m_soundLoadFinish;

		private bool m_shouldDownload;

		public override void NotificationStackEntry()
		{
		}

		public override float Progress()
		{
			return 0f;
		}

		public override void ProgressUpdate()
		{
		}

		private bool IsWaitFinish()
		{
			return false;
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}
	}
}
