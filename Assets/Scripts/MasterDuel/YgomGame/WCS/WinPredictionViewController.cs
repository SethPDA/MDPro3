using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS
{
	public class WinPredictionViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		public enum WinPredictionHomeCode
		{
			NONE = 0,
			ERR_OUT_OF_TERM = 4301
		}

		public enum BgType
		{
			NONE = 0,
			ADVANCED = 1,
			BEST8 = 2,
			CHAMPION = 3
		}

		public class TeamData
		{
			public int order;

			public int Id;

			public string name;

			public string areaName;

			public int areaId;
		}

		public enum isPresentSentFrag
		{
			NONE = 0,
			NORMAL = 1,
			SPECIAL = 2,
			OTHERS = 4
		}

		private string TEAMSELECT_GROUP_LABEL;

		private string TEAMSELECT_BTN_UNSELECT_LABEL;

		private string TEAMSELECT_BTN_LABEL;

		private string TEMPLATE_LABEL;

		private string REWARD_BTN_LABEL;

		private string TEXT_TEAM_SELECT_GROUP_LABEL;

		private string TEXT_TEAM_SELECT_NAME_LABEL;

		private string ICON_TEAM_LABEL;

		private string TEAM_SELECT_CHEER_ICON_LABEL;

		private string TEAM_SELECT_CHEER_ICON_RESULT_LABEL;

		private string TEXT_TEAM_SELECT_LABEL;

		private string TEXT_DATE_TEXT_LABEL;

		private string TEXT_HOLDING_TEXT_LABEL;

		private string TEXT_DESC_LABEL;

		private string TEXT_RESULT_LABEL;

		private string IMG_RESULT_BG_LABEL;

		private string TEAM_NAME_LABEL;

		private string TEAM_GROUP_LABEL;

		private string CW_TEAM_NAME;

		private string CW_TEAM_AREA;

		private string CW_TEAM_ORDER;

		private int m_SelectedTeamIndex;

		private Dictionary<int, ElementObjectManager> templatesMap;

		private List<TeamData> teamDatas;

		private List<int> orderList;

		private Dictionary<string, object> teamDicData;

		private SelectionButton rewardButton;

		private SelectionButton teamSelectButton;

		private SelectionButton teamSelectUnselectButton;

		private ElementObjectManager teamSelectGroup;

		private ExtendedTextMeshProUGUI resultTextEo;

		private GameObject resultBg;

		private ExtendedTextMeshProUGUI m_TeamSelectAreaText;

		private ExtendedTextMeshProUGUI m_TeamSelectNameText;

		private ExtendedTextMeshProUGUI m_TeamSelectText;

		private Image m_SelectTeamIcon;

		private GameObject m_CheerIcon;

		private GameObject m_CheerIconResult;

		private Queue<Action> actionsQueue;

		private bool OpenningFrag;

		private bool isOutOfVote;

		private bool isDecidedTeamResult;

		private IEnumerator rewardCoroutine;

		private Dictionary<string, object> supportDictionary;

		private string infoText;

		private isPresentSentFrag m_InitFrag;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private IEnumerator rewardDisp()
		{
			return null;
		}

		private void SetViewElements()
		{
		}

		private void UpdateButtonView()
		{
		}

		private void Initialize()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void OnClickTeamSelect()
		{
		}

		private void OnClickRewardButton()
		{
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		private void Import(Action OnCompleted = null)
		{
		}

		private void UpdateTemplateView(Action OnCompleted = null)
		{
		}

		private void UpdateTeamSelectText()
		{
		}

		private void ActiveTweenIcon(bool active)
		{
		}

		private IEnumerator DelaySE()
		{
			return null;
		}

		private void OnClickTemplate(int idx)
		{
		}

		private void SetCallbackInputDown(int order)
		{
		}

		private void SetCallBackInputUp()
		{
		}

		private void CallApi(Action onComplited = null)
		{
		}

		private void OpenErrDialog(string title, string text)
		{
		}

		private bool CheckStatus()
		{
			return false;
		}

		private void SetResultBgView(BgType bgType)
		{
		}

		private IEnumerator TweenWait(string label)
		{
			return null;
		}

		private string GetResultText(int orderIndex)
		{
			return null;
		}

		private string GetProgressResultText(int orderIndex)
		{
			return null;
		}

		private Dictionary<string, object> GetCWSupport()
		{
			return null;
		}

		private Dictionary<string, object> GetCWTeam()
		{
			return null;
		}
	}
}
