using System;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team
{
	public class TeamInfoViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string VC_PATH = "Team/TeamInfo";

		private SelectionButton _copyBtn;

		private int _joiningNum;

		private int _joiningMax;

		private int _teamId;

		private string _regulationSetName;

		private string[] _regulationNames;

		private int _mrk;

		protected override Type[] textIds => null;

		public static void Open(ViewControllerManager manager)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void LoadData()
		{
		}

		protected override void OnCreatedView()
		{
		}
	}
}
