using System;
using System.Collections.Generic;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class HomeActionViewController : BaseMenuViewController, ICommonHeaderSupported, IGemSupported, IConfigButtonSupported
	{
		public const string PREFAB_PATH = "Home/HomeAction";

		public const int P_HELP = 100;

		public const int P_ROOM_INVITE = 50;

		public const int P_PARTICIPATION_CONFIRM = 40;

		public const int P_LOGIN_BONUS = 30;

		public const int P_FORCE_NOTIFY = 20;

		public const int P_EVENT_NOTIFY = 10;

		public const int P_DEFAULT = 0;

		private const string ARG_KEY_ACTIONS = "Actions";

		private List<HomeAction> actionList;

		private int isPlayingCount;

		private bool isAcceptedPop;

		private int currentActionIndex;

		private bool IsPlaying => false;

		protected override Type[] textIds => null;

		public static void Open(List<HomeAction> actionList)
		{
		}

		private void Update()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void PlayHomeAction()
		{
		}
	}
}
