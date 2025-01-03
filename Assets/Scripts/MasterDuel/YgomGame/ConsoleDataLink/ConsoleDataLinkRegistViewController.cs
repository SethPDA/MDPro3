using System.Collections;
using UnityEngine.Events;
using YgomGame.Menu;

namespace YgomGame.ConsoleDataLink
{
	public class ConsoleDataLinkRegistViewController : ConsoleDataLinkViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private string m_url;

		protected override void OnCreatedView()
		{
		}

		private void Regist()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void CheckRegistered(UnityAction unregesteredEvent)
		{
		}

		private IEnumerator KonamiIDCheckLink_Polling()
		{
			return null;
		}
	}
}
