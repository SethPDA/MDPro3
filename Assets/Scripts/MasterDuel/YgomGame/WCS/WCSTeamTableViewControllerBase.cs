using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS
{
	public class WCSTeamTableViewControllerBase : BaseMenuViewController
	{
		public enum Side
		{
			LEFT = 0,
			RIGHT = 1
		}

		private enum Result
		{
			NONE = 0,
			WIN = 1,
			LOSE = 2,
			DRAW = 3
		}

		private class TeamInfo
		{
			private bool _update;

			internal ExtendedTextMeshProUGUI uiGroupText;

			internal ExtendedTextMeshProUGUI uiNameText;

			internal ExtendedTextMeshProUGUI uiScoreText;

			internal GameObject uiWinnerIcon;

			internal SelectionButton uiInfoBtn;

			internal Image uiTeamIcon;

			internal bool win
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal string areaName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal string name
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal int score
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal string teamIconPath
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal void Terminate()
			{
			}

			internal void UpdateUI()
			{
			}

			internal void EnableInfoButton(bool on)
			{
			}

			internal void SetInfoButtonListener(UnityAction callback)
			{
			}

			internal void SetTeamInfo(string areaName, string name, int? score, string iconPath)
			{
			}

			internal void SetResult(bool win)
			{
			}
		}

		private class Table
		{
			internal Player[] players;

			private bool _update;

			internal SelectionButton uiStatusButton;

			internal ExtendedTextMeshProUGUI uiStatusButtonText;

			internal string statusText
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			private Table()
			{
			}

			internal static Table[] CreateTables(uint count)
			{
				return null;
			}

			internal void Terminate()
			{
			}

			internal void UpdateUI()
			{
			}

			internal void SetStatusButton(bool pushable)
			{
			}

			internal void SetStatusButtonText(string labelText)
			{
			}

			internal void SetStatusButtonListener(UnityAction callback)
			{
			}

			internal void SetWin(Side which)
			{
			}

			internal void SetDraw()
			{
			}

			internal void ResetBothResult()
			{
			}
		}

		private class Player
		{
			private bool _update;

			internal ExtendedTextMeshProUGUI uiPlayerName;

			internal GameObject uiPlayerIcon;

			internal ExtendedTextMeshProUGUI uiResultText;

			internal Result result
			{
				[CompilerGenerated]
				get
				{
					return default(Result);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal string name
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal (int, int) iconIDs
			{
				[CompilerGenerated]
				get
				{
					return default((int, int));
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			internal void UpdateUI()
			{
			}

			internal void SetPlayerInfo(string name, (int, int)? profileIconIDs)
			{
			}

			internal void SetResult(Result result)
			{
			}
		}

		private const int DEFAULT_TABLE_NUM = 3;

		internal const string ARG_KEY_TABLE_NUM = "table_num";

		internal const string ARG_KEY_DRYRUN = "dryrun";

		private TeamInfo[] _teamList;

		private Table[] _tableDataList;

		protected InfinityScrollView _scrollView;

		protected override Type[] textIds => null;

		protected bool dryrun
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected bool initialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected int teamCount => 0;

		protected int tableCount => 0;

		protected virtual void OnDestroy()
		{
		}

		private void Terminate()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected sealed override void OnCreatedView()
		{
		}

		protected virtual void InitializeView()
		{
		}

		private void Update()
		{
		}

		private void UpdateTeamInfo()
		{
		}

		private void UpdateTableData(GameObject gob, int index)
		{
		}

		protected void SetTitle(string title)
		{
		}

		protected void SetLeftTeamInfo(string areaName, string name, int? score, string iconPath)
		{
		}

		protected void SetRightTeamInfo(string areaName, string name, int? score, string iconPath)
		{
		}

		protected void EnableLeftTeamInfoBtn(bool on)
		{
		}

		protected void EnableRightTeamInfoBtn(bool on)
		{
		}

		protected void SetTeamWin(Side which)
		{
		}

		protected void ResetTeamResult()
		{
		}

		protected void SetTableStatusText(int index, string text)
		{
		}

		protected void SetLeftPlayerInfo(int index, string name, (int, int)? profileIconIDs)
		{
		}

		protected void SetRightPlayerInfo(int index, string name, (int, int)? profileIconIDs)
		{
		}

		protected void SetPlayerWin(int tableIndex, Side which)
		{
		}

		protected void SetResultDraw(int tableIndex)
		{
		}

		protected void ResetBothPlayerResult(int tableIndex)
		{
		}

		protected void SetLeftTeamInfoButtonListener(UnityAction callback)
		{
		}

		protected void SetRightTeamInfoButtonListener(UnityAction callback)
		{
		}

		protected void SetTableStatusButton(int index, bool pushable)
		{
		}

		protected void SetTableStatusButtonListener(int index, UnityAction callback)
		{
		}
	}
}
