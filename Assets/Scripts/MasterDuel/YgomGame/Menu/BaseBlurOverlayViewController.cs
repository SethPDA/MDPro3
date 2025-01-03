using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class BaseBlurOverlayViewController : BaseMenuViewController
	{
		public const string k_ArgKeyBlurOverlay = "blurOverlay";

		protected bool m_IsBlurOverlay;

		protected virtual bool defaultBlurOverlay => false;

		protected override GameObject m_TweenTarget => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
