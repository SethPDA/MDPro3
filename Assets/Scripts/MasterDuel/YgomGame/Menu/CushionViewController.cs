using System;
using System.Collections.Generic;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class CushionViewController : BaseMenuViewController
	{
		public const string PREFAB_PATH = "Utility/CushionView";

		public const string k_ArgsKeyRootView = "RootView";

		public const string k_ArgsKeyPushAction = "PushAction";

		public const string k_ArgsKeyPopAction = "PopAction";

		private ViewController m_RootView;

		private Action m_PushAction;

		private Action m_PopAction;

		public static void Open(ViewController rootView, Action pushAction, Action popAction)
		{
		}

		public static void Open(Dictionary<string, object> args)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}
	}
}
