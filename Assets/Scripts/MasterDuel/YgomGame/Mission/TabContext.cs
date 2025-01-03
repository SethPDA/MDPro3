using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Mission
{
	public class TabContext : IComparable<TabContext>
	{
		public readonly MissionTabType tabType;

		public readonly int campaignPoolId;

		public readonly long campaignBeginTs;

		public readonly string tabNameTextId;

		public readonly string tabShortNameTextId;

		protected readonly List<MissionContext> m_Missions;

		protected readonly Dictionary<int, MissionContext> m_MissionMap;

		public IReadOnlyList<MissionContext> missions => null;

		public IReadOnlyDictionary<int, MissionContext> missionMap => null;

		public string tabNameText
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

		public string tabShortNameText
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

		public bool inRewardUnlocked => false;

		public bool completed => false;

		public (bool, int) SearchBadgeInfos()
		{
			return default((bool, int));
		}

		public TabContext(MissionTabType tabType, int campaignPoolId = 0, long campaignBeginTs = 0L, string tabNameTextId = null, string tabShortNameTextId = null)
		{
		}

		public void Clear()
		{
		}

		public void SortMissions()
		{
		}

		public void LoadTexts()
		{
		}

		public int Compare(TabContext a, TabContext b)
		{
			return 0;
		}

		public int CompareTo(TabContext other)
		{
			return 0;
		}
	}
}
