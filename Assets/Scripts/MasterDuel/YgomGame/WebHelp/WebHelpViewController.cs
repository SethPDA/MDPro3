using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.WebHelp
{
	public class WebHelpViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string TEXT_TOP_LABEL;

		private readonly string TEXT_DESC1_LABEL;

		private readonly string TEXT_DESC2_LABEL;

		private readonly string TEXT_BUTTON_LABEL;

		private readonly string BUTTON_LABEL;

		private ExtendedTextMeshProUGUI m_topText;

		private ExtendedTextMeshProUGUI m_desc1Text;

		private ExtendedTextMeshProUGUI m_desc2Text;

		private ExtendedTextMeshProUGUI m_urlText;

		private ExtendedTextMeshProUGUI m_buttonText;

		private SelectionButton m_helpButton;

		private readonly string TEXT_URL_LABEL;

		private string m_url;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public static void Open()
		{
		}

		private void SetUpView()
		{
		}

		private void JumpToLink()
		{
		}
	}
}
