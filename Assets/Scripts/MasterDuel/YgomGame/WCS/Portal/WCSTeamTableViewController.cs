using System.Collections;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal
{
	public class WCSTeamTableViewController : WCSTeamTableViewControllerBase, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string VC_PREFAB_PATH = "WCS/Portal/WCSTeamTableForPortal";

		private const string ARG_KEY_ROOM_ID = "room_id";

		private const string ARG_KEY_ROOM_UNIQUE_ID = "room_unique_id";

		private int _roomId;

		private string _roomUniqueId;

		private IEnumerator _pollingRoutine;

		protected virtual float pollingPeriod => 0f;

		public int roomId => 0;

		public string roomUniqueId => null;

		protected virtual object roomInfo => null;

		public static void Open(ViewControllerManager manager, int roomId, string roomUniqueId)
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void InitializeView()
		{
		}

		protected virtual void ApplyData()
		{
		}

		private void OpenTeamIntroduction(int teamId)
		{
		}

		protected virtual void CallWatchDuelAPI(int roomId, string roomUniqueId, int tableIndex)
		{
		}

		private void StartPolling()
		{
		}

		private void EndPolling()
		{
		}

		protected virtual Handle CallPollingAPI()
		{
			return null;
		}

		private IEnumerator Polling()
		{
			return null;
		}

		protected virtual bool IsForceLeaving(WcsCode err)
		{
			return false;
		}
	}
}
