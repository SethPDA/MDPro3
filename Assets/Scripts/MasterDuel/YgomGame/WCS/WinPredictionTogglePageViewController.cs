using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.WCS
{
	public class WinPredictionTogglePageViewController : BaseMenuViewController
	{
		public class TeamData
		{
			public string teamName;

			public bool isActive;

			public int idx;

			public int Id;
		}

		public class ToggleButton
		{
			public ElementObjectManager eom;

			public GameObject onImage;

			public GameObject offImage;

			public SelectionButton button;

			public void SetActive(bool active)
			{
			}

			public ToggleButton(ElementObjectManager elementObjectManager)
			{
			}
		}

		public enum WinPredictionVoteCode
		{
			NONE = 0,
			ERR_OUT_OF_TERM = 4301,
			ERROR_ID_CONFIG = 4313,
			ERR_OUT_OF_VOTE_TERM = 4314,
			ERR_FINAL_SUPPORT_ABSENT = 4315
		}

		private const string ON_BTN_LABEL = "On";

		private const string OFF_BTN_LABEL = "Off";

		private const string ARGS_INDEX_LABEL = "onToggeleIndex";

		private string TEXT_TEAM_GROUP_ON_LABEL;

		private string TEXT_TEAM_GROUP_OFF_LABEL;

		private string TEXT_TEAM_NAME_ON_LABEL;

		private string TEXT_TEAM_NAME_OFF_LABEL;

		private string FOOTER_BTN_LABEL;

		private string TOGGLE_TEMPLATE_LABEL;

		private string CW_TEAM_NAME;

		private string CW_TEAM_ORDER;

		private SelectionButton m_FooterButton;

		private int selectedButtonIndex;

		private List<TeamData> teamDatas;

		private Dictionary<int, ToggleButton> toggleButtons;

		private Dictionary<string, object> m_TeamDataDic;

		public static void Open(int index)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void OnClickFooterButton()
		{
		}

		private void Import()
		{
		}

		private void UpdateView()
		{
		}

		private void ClickButton(int idx)
		{
		}

		private void OpenErrDialog(string title, string text)
		{
		}
	}
}
