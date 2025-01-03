using System;
using System.Collections;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Tutorial
{
	public class InitialSettingsViewController : BaseMenuViewController
	{
		private readonly string INPUT_LABEL;

		private readonly string BTN_LABEL;

		private readonly string BTN_CAUTION_LABEL;

		private SelectionButton m_ButtonOK;

		private InputFieldWidget _inputFieldWidget;

		private string _nameCanditate;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator VerifyName(string newName, Action<bool> onEnd)
		{
			return null;
		}

		private void OpenCautionDialog()
		{
		}

		private IEnumerator SelectDelayOK()
		{
			return null;
		}
	}
}
