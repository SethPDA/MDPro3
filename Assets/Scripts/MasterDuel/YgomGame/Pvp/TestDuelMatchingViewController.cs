using System.Collections;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.YGomTMPro;

namespace YgomGame.Pvp
{
	public class TestDuelMatchingViewController : BaseMenuViewController
	{
		public enum View
		{
			SEARCHING = 0,
			MATCHING = 1,
			TIMEOUT = 2
		}

		[SerializeField]
		private GameObject DuelStartPrefab;

		private readonly string BTN_CANCEL_LABEL;

		private readonly string BTN_BACK_LABEL;

		private readonly string TXT_TIME_LABEL;

		private readonly string ROOT_SEARCH_LABEL;

		private readonly string ROOT_MATCH_LABEL;

		private readonly string ROOT_TIMEOUT_LABEL;

		private readonly string IMG_ICON_LABEL;

		private readonly int RESEARCH_TIME;

		private ExtendedTextMeshProUGUI m_TextTime;

		private int m_ElapsedTime;

		private GameObject m_rootSearch;

		private GameObject m_rootMatch;

		private GameObject m_rootTimeout;

		private View m_currentView;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void SetActiveView(View state)
		{
		}

		private string ConvertDispTime(int time)
		{
			return null;
		}

		private IEnumerator yInit()
		{
			return null;
		}

		private IEnumerator yMatch()
		{
			return null;
		}

		private IEnumerator Start()
		{
			return null;
		}
	}
}
