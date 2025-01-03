using System;
using System.Collections;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class PrivacyPolicyViewController : CommonScreenViewController
	{
		private UserAgreementType m_type;

		private SelectionButton m_agreeButton;

		private IEnumerator m_openGDPRPrivacyNotice;

		private Action<int> m_resultCallback;

		private void setupButton(string element, string text, Action callback)
		{
		}

		private void closeButton(string element)
		{
		}

		private IEnumerator openGDPRPrivacyNotice(string url)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private static void debugLog(string str)
		{
		}
	}
}
