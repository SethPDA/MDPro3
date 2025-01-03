using System;
using YgomGame.Menu;
using YgomSystem.UI.ElementWidget;

namespace YgomGame
{
	public class PasswordDialogViewController : DialogViewControllerBase
	{
		public static readonly string argKeyCallback;

		private readonly string INPUT_LABEL;

		private readonly string BTN_OK_LABEL;

		private readonly string BTN_CANCEL_LABEL;

		private InputFieldWidget m_inputFieldWidget;

		private string m_inputText;

		private Action<string> m_callback;

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
