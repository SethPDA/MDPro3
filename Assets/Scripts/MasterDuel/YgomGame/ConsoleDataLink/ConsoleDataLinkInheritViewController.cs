using System.Collections;
using YgomGame.Menu;

namespace YgomGame.ConsoleDataLink
{
	public class ConsoleDataLinkInheritViewController : ConsoleDataLinkViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private bool inheritFrag;

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void Inherit()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private IEnumerator KonamiIDCheckInherit_Polling()
		{
			return null;
		}
	}
}
