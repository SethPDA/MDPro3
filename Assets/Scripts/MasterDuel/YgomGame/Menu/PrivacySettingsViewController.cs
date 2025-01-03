using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class PrivacySettingsViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string LABEL_BUTTONOK;

		private readonly string LABEL_BUTTONCANCEL;

		private readonly string LABEL_BUTTON_1;

		private readonly string LABEL_BUTTON_2;

		[SerializeField]
		public int dataCount;

		private bool optOutBool;

		private SelectionButton m_CancelButton;

		private SelectionButton m_OKButton;

		private ElementObject subTitleText1;

		private ElementObject subTitleText2;

		private ElementObjectManager button1;

		private ElementObjectManager button2;

		private SelectionButton leftButton;

		private SelectionButton rightButton;

		private bool leftselect;

		protected override void OnCreatedView()
		{
		}

		private void InitializeOptOut()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void OnClickOKButton()
		{
		}

		private void OnClickButtonCancel()
		{
		}

		private void SetActiveOKButton(bool flag)
		{
		}

		private void setButton()
		{
		}

		private void setUnChangeAble()
		{
		}
	}
}
