using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Utility;

namespace YgomGame.Mission
{
	public class MissionContext : IComparable<MissionContext>
	{
		public readonly int idx;

		public readonly int poolId;

		public readonly int missionId;

		public readonly MissionCategory category;

		private string m_MissionNameCache;

		private readonly int m_LogicNo;

		private readonly List<object> m_NameParams;

		public readonly long endTimeStamp;

		public readonly long resultEndTimeStamp;

		public readonly string hintSfx;

		public readonly int progress;

		public readonly bool isExistsProgressData;

		public readonly List<List<GoalContext>> goalPages;

		public bool focusEffectVisible;

		public bool completeEffectVisible;

		public int goalPageIdx;

		public int goalProgressPageIdx;

		public int goalCursorIdx;

		public bool isNew
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

		public int progressGoalPage
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

		public bool isExpire
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

		public int hideGoalIdx
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

		public long orderTs
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GoalContext[] goals
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

		public string hintPath => null;

		public bool isExistsRewardUnlocked => false;

		public int GetLastGoalRequire()
		{
			return 0;
		}

		public bool IsProgressCompleted()
		{
			return false;
		}

		public bool IsCompleteAndReceived()
		{
			return false;
		}

		public string MakeMissionName(TextGroupLoadHolder textGroupLoadHolder)
		{
			return null;
		}

		public MissionContext(int idx, Dictionary<string, object> data, Dictionary<string, object> master)
		{
		}

		public void ImportOverride(Dictionary<string, object> data)
		{
		}

		public void TurnOffNew()
		{
		}

		private void ClampCursorIdx(int setCursorIdx)
		{
		}

		public int GetCursorLimit()
		{
			return 0;
		}

		public IReadOnlyList<GoalContext> GetCurrentGoals()
		{
			return null;
		}

		private static int GetCategoryOrder(MissionCategory category)
		{
			return 0;
		}

		public int Compare(MissionContext a, MissionContext b)
		{
			return 0;
		}

		public int CompareTo(MissionContext other)
		{
			return 0;
		}
	}
}
