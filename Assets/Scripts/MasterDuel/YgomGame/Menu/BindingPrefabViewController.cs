using System;
using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class BindingPrefabViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		private const string k_ArgsPrefPath = "prefPath";

		private const string k_ArgsOnStackEntryCallback = "onStackEntryCallback";

		private const string k_ArgsOnCreateViewCallback = "onCreateViewCallback";

		private const string k_ArgsOnStackRemoveCallback = "onStackRemoveCallback";

		public HeaderViewController.IsDispHeader headerDispFlags;

		public ElementObjectManager view => null;

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		public static void PushOpen(ViewControllerManager manager, string prefPath, Action<BindingPrefabViewController> onStackEntryCallback, Action<BindingPrefabViewController> onCreateViewCallback, Action<BindingPrefabViewController> onStackRemoveCallback, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}
	}
}
