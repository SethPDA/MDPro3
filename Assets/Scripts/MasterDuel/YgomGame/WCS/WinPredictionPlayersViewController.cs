using System;
using System.Collections;
using System.Collections.Generic;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.WCS
{
	public class WinPredictionPlayersViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class PlayerData
		{
			public string name;

			public Dictionary<string, string> QandAList;

			public int iconId;

			public int iconFrameId;

			public bool isReader;

			public bool isOpenProf;

			public int pcode;
		}

		private class TeamData
		{
			public int id;

			public string teamName;

			public List<PlayerData> players;

			public TeamData()
			{
			}

			public TeamData(int id, string teamName)
			{
			}
		}

		private readonly string k_ELabelPrevButton;

		private readonly string k_ELabelNextButton;

		private readonly string k_TLabelPagingNextOut;

		private readonly string k_TLabelPagingBackOut;

		private readonly string k_TLabelPagingNextIn;

		private readonly string k_TLabelPagingBackIn;

		private readonly string k_ELabelShortcutButtonL1;

		private readonly string k_ELabelShortcutButtonR1;

		private SelectionButton m_PrevButton;

		private SelectionButton m_NextButton;

		private static readonly string K_ArgSinglePage;

		private static readonly string k_ArgPageIndex;

		private static readonly string k_ArgCallback;

		private static readonly string k_ArgIdOrderList;

		private readonly string CW_TEAM_NAME;

		private readonly string CW_PLAYER_QandA;

		private readonly string CW_PLAYER_ISLEADER;

		private readonly string CW_PLAYER_ICON;

		private readonly string CW_PLAYER_ICONFRAME;

		private readonly string CW_PLAYER_NAME;

		private readonly string CW_PLAYER_PCODE;

		private readonly string LABEL_PROFILE_TEMPLATE;

		private readonly string LABEL_HEADER1_TXT;

		private readonly string LABEL_TEMPLATE1_TXT;

		private readonly string LABEL_PLATFORM_PLAYER_NAME;

		private readonly string LABEL_TEAM_NAME_TXT;

		private readonly string LABEL_AREA_TXT;

		private readonly string LABEL_TEAM_ICON;

		private readonly string LABEL_ICON;

		private readonly string LABEL_MAIN;

		private readonly string LABEL_TEAM_AREA;

		private readonly string LABEL_PLAYER_PROFILE;

		private int m_PageIdx;

		private int m_PageCount;

		private bool isSinglePage;

		private TeamData teamData;

		private const int TEAM_MEMBER_NUM = 3;

		private Dictionary<int, ElementObjectManager> playersEom;

		private Dictionary<int, ElementObjectManager> playersProfileEom;

		private ElementObjectManager teamArea;

		private List<int> instancedTemplateNum;

		private Dictionary<int, List<ElementObjectManager>> templateList;

		private List<int> dataIdOrderList;

		private ExtendedScrollRect m_ScrollView;

		protected override Type[] textIds => null;

		public static void Open(int id, bool isSinglePage, Action callback = null)
		{
		}

		public static void Open(int id, bool isSinglePage, List<int> list, Action callback = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Import(int idx, bool isRefresh = false)
		{
		}

		private void RefreshPage()
		{
		}

		private void UpdateView()
		{
		}

		private void OnClickProfileButton(int pcode)
		{
		}

		private void InActiveAllTemplate(ElementObjectManager eom)
		{
		}

		private void OnClickNextButton()
		{
		}

		private void OnClickPrevButton()
		{
		}

		private void ToNextPage()
		{
		}

		private void ToPrevPage()
		{
		}

		private void ChangePage(int dstIdx, int direction = 0)
		{
		}

		private IEnumerator yPlayPaging(int direction = 0)
		{
			return null;
		}

		private string GetTLabelPagingOut(int direction)
		{
			return null;
		}

		private string GetTLabelPagingIn(int direction)
		{
			return null;
		}

		private void CallEntryAPI()
		{
		}

		private Dictionary<string, object> GetTeamDatas(int idx)
		{
			return null;
		}

		private Dictionary<string, object> GetPlayersDatas(int idx)
		{
			return null;
		}

		private Dictionary<string, object> GetDataRoot()
		{
			return null;
		}

		private Dictionary<string, object> GetQuestions()
		{
			return null;
		}
	}
}
