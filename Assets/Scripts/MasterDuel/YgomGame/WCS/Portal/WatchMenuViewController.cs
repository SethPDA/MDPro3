using UnityEngine;
using YgomGame.Menu;

namespace YgomGame.WCS.Portal
{
	public class WatchMenuViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string LABEL_BTN_JUMP = "ButtonJump";

		private bool m_isPC;

		private bool m_isMobile;

		private bool m_isIOS;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void setupWatchSection(GameObject root, string url, string titleText, string buttonText)
		{
		}
	}
}
