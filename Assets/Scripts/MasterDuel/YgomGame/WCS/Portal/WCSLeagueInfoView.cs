using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal
{
	public class WCSLeagueInfoView : WCSBattleInfoBaseViewController.View
	{
		private enum BattleResult
		{
			UNKOWN = 0,
			WIN = 1,
			LOSE = 2,
			DRAW = 3
		}

		private class Table
		{
			internal const int TEAM_MAX = 4;

			private const string LABEL_DUELICON = "DuelIcon";

			private ElementObjectManager _eom;

			private ElementObjectManager _tableHeaderEom;

			private ElementObjectManager[] _teamRowEom;

			private ElementObjectManager[,] _eachBattleRecordsEom;

			private SelectionButton[] _teamSituationButtons;

			internal int rowNum => 0;

			internal int colNum => 0;

			internal Table(ElementObjectManager eom)
			{
			}

			internal void Terminate()
			{
			}

			internal void SetHeaderGroupName(string name)
			{
			}

			internal void SetTeamIconOnHeader(int colIndex, string spritePath)
			{
			}

			internal void SetTeamInfo(int rowIndex, string areaName, string name, string iconSpritePath)
			{
			}

			internal void SetTeamWinCount(int rowIndex, int winCount)
			{
			}

			internal void HideTeamWinCount(int rowIndex)
			{
			}

			internal void SetIndivisualWinDiff(int rowIndex, int deltaNum)
			{
			}

			internal void HideIndivisualWinDiff(int rowIndex)
			{
			}

			internal void SetRank(int rowIndex, int rank, bool top2Fixed)
			{
			}

			internal void HideRank(int rowIndex)
			{
			}

			internal void SetBattleRecord(int rowIndex, int columnIndex, BattleResult? result, int myWinCount, int oppWinCount)
			{
			}

			internal void SetStatusBattleRecord(int rowIndex, int columnIndex, bool inDuel)
			{
			}

			internal void RegisterTeamSituationBtnAction(int rowIndex, int columnIndex, UnityAction callback, out bool cursorMoving)
			{
				cursorMoving = default(bool);
			}

			internal bool FocusButtonCursor()
			{
				return false;
			}
		}

		private Table[] _tableList;

		private ElementObjectManager _topEom;

		private SelectionButton _ruleButton;

		public WCSLeagueInfoView(ElementObjectManager topEom, ElementObjectManager scrollEom, ViewControllerManager manager)
			: base(null, null)
		{
		}

		public override void Terminate()
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

		private void TestCode(int tableIndex)
		{
		}
	}
}
