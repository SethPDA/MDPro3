using System;
using YgomGame.Menu;

namespace YgomGame.Colosseum
{
	public abstract class ColosseumConfirmViewControllerBase : BaseMenuViewController, IDynamicHeaderCustomSupported, IDynamicChangeDispHeaderSupported
	{
		protected const string E_Image = "Image";

		protected const string E_TextTitle = "TextTitle";

		protected const string E_TextExplain = "TextExplain";

		protected const string E_TextAlert = "TextAlert";

		protected const string E_DescGroup = "DescGroup";

		protected const string E_DescScrollRect = "DescScrollRect";

		protected const string E_DescText = "DescText";

		protected const string E_TemplateButtonInfo = "TemplateButtonInfo";

		protected const string E_AgreementGroup = "AgreementGroup";

		protected const string E_TemplateButtonGroup = "TemplateButtonGroup";

		protected const string E_ConfirmGroup = "ConfirmGroup";

		protected const string E_TemplateButtonBottom = "TemplateButtonBottom";

		protected const string E_Button = "Button";

		protected const string E_Text = "Text";

		protected const string E_TextSelecting = "TextSelecting";

		protected const string ARGKEY_LOGO = "logoId";

		protected const string ARGKEY_ID = "identifier";

		protected const string ARGKEY_ONSUCCESS = "onSuccess";

		protected int logoId;

		protected int identifier;

		protected Action onSuccess;

		protected abstract void UpdateView();

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void UpdateLogo()
		{
		}

		private void Initialize()
		{
		}

		private void CheckText()
		{
		}

		private void CheckSetActiveText(string label)
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}
	}
}
