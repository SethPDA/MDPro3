using System.Collections.Generic;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class PlaceHolderDialogViewController : BaseMenuViewController, IBokeSupported
	{
		private ViewController m_Owner;

		public static PlaceHolderDialogViewController PushOpen(ViewController owner, Dictionary<string, object> args = null)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		private void OnContentTransition(TransitionType transitionType, ViewController hideVc, ViewController showVc)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
