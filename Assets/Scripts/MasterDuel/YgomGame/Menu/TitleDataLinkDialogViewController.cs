using System;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu
{
	public class TitleDataLinkDialogViewController : BaseMenuViewController, IBokeSupported
	{
		private readonly string content_LABEL;

		private readonly string button1_LABEL;

		private readonly string button0_LABEL;

		private readonly string title_LABEL;

		private ElementObject content;

		private ElementObject buttonGrp0;

		private ElementObject buttonGrp1;

		private ElementObject titleGrp;

		private ExtendedTextMeshProUGUI MainText;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void OnBsck()
		{
		}

		private void Start()
		{
		}
	}
}
