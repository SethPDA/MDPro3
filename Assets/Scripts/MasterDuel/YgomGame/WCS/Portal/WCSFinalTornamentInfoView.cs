using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal
{
	public class WCSFinalTornamentInfoView : WCSBattleInfoBaseViewController.View
	{
		private enum SlotPos
		{
			SEMI_FINAL_POS1 = 0,
			SEMI_FINAL_POS2 = 1,
			SEMI_FINAL_POS3 = 2,
			SEMI_FINAL_POS4 = 3,
			FINAL_POS1 = 4,
			FINAL_POS2 = 5,
			CHAMPION_POS = 6
		}

		private enum WinningLinePos
		{
			SEMI_FINAL_LEFT = 0,
			SEMI_FINAL_RIGHT = 1,
			FINAL = 2
		}

		private enum WinningLineStatus
		{
			NO_WINNER = 0,
			LEFT_WINNER = 1,
			RIGHT_WINNER = 2
		}

		private ElementObjectManager _topEom;

		private ElementObjectManager[] _slotEoms;

		private ElementObjectManager[] _winningLineEoms;

		private SelectionButton[] _slotButtons;

		private SelectionButton _ruleButton;

		private static string GetDefaultSlotName(SlotPos pos)
		{
			return null;
		}

		public WCSFinalTornamentInfoView(ElementObjectManager topEom, ElementObjectManager scrollEom, ViewControllerManager manager)
			: base(null, null)
		{
		}

		public override void Terminate()
		{
		}

		private void SetChampionCrownIcon(bool disp)
		{
		}

		private void SetTeamInfo(SlotPos pos, string areaName, string teamName, string teamDesc)
		{
		}

		private void SetTeamIcon(SlotPos pos, string iconSpritePath)
		{
		}

		private void SetTeamWinner(SlotPos pos, bool on)
		{
		}

		private void SetWinningLineStatus(WinningLinePos pos, WinningLineStatus status)
		{
		}

		private void SetBattleScoreText(WinningLinePos pos, string score)
		{
		}

		private void SetWinningLineStatusFromWinner(SlotPos winnerPos)
		{
		}

		private void RegisterTeamSituationBtnAction(SlotPos pos, UnityAction callback)
		{
		}

		protected override void ApplyFromCW(object baseData)
		{
		}

		private void OpenExplanationPage()
		{
		}

		private void OpenDuelRoom(int roomId, string roomUniqueId)
		{
		}

		private void TestCode()
		{
		}
	}
}
