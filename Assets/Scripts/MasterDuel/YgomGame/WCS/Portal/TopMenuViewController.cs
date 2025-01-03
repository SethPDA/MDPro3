using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal
{
	public class TopMenuViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private enum OpenStatus
		{
			Before = 0,
			Open = 1,
			After = 2
		}

		private const string LABEL_BTN_1STSTAGE = "Button1stStage";

		private const string LABEL_BTN_CAMPAIGN = "ButtonCampaign";

		private const string LABEL_BTN_TOURNAMENT = "ButtonTournament";

		private const string LABEL_BTN_WATCH = "ButtonWatch";

		private const string LABEL_BTN_REGULATION = "ButtonRegulation";

		private const string LABEL_ROOT_WINNER = "ResultRoot";

		private const string LABEL_IMG_WINNERICON = "ResultTeamGroupIcon";

		private const string LABEL_TEXT_WINNERAREA = "TextResultTeamGroup";

		private const string LABEL_TEXT_WINNERNAME = "TextResultTeamName";

		private int m_winnerTeamID;

		private GameObject m_uiWinnerRoot;

		private GameObject m_ui1stStageRoot;

		private GameObject m_uiTournamentRoot;

		private GameObject m_uiVoteRewardBadge;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void updateCampaignInfo(bool isOnCreate)
		{
		}

		private void updateAllUI(bool isOnCreate)
		{
		}

		private void setWinnerTeamUI(bool isOnCreate)
		{
		}

		private IEnumerator loadIconImage(Image imageUI, string imagePath)
		{
			return null;
		}

		private void setOpenStatusFooterUI(GameObject root, OpenStatus status, string text)
		{
		}
	}
}
