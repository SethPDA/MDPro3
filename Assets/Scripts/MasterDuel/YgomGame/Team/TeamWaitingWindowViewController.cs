using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team
{
	public class TeamWaitingWindowViewController : BaseMenuViewController
	{
		public const string PREFAB_PATH = "Team/TeamWaitingWindow";

		private const string KEY_MESSAGE = "message";

		private readonly string E_ButtonCancel;

		private readonly string E_RootText;

		private readonly string E_TextSearching;

		public static void Open(ViewControllerManager manager, string message = "")
		{
		}

		public static bool Close(ViewControllerManager manager)
		{
			return false;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}
	}
}
