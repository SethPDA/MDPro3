using System.Collections.Generic;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team
{
	public class TeamDesignationViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string VC_PATH = "Team/TeamDesignation";

		private const string ARGKEY_DURATION_CONFIG = "duration_config";

		private TeamLobbyPollingWatcher _watchDog;

		private InputFieldWidget _teamIdInput;

		private SelectionButton _duelDurationSelectBtn;

		private ExtendedTextMeshProUGUI _duelDurationValueText;

		private SelectionButton _applyButton;

		private List<(int, string, int, int)> _duelDurationConfigList;

		private int _selectedDuelDurationIndex;

		public static void Open(ViewControllerManager manager, List<(int, string, int, int)> duelDurationConfigList, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void LoadData()
		{
		}

		private void OnApplyingForMatch()
		{
		}

		private void OnTeamIDInputEnd(string text)
		{
		}

		private void OnDuelDurationSelecting()
		{
		}

		private string AcquireDuelDurationConfigName(int index)
		{
			return null;
		}
	}
}
