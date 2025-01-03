using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomGame.Mission
{
	public class MissionRootContext
	{
		private readonly List<TabContext> m_Tabs;

		private readonly List<int> m_TabTemplates;

		private readonly List<TabContextImportable> m_ImportableTabs;

		private readonly TabAllContext m_TabAll;

		private readonly Dictionary<int, TabContextImportable> m_CampaignTabMap;

		private bool m_IsInitialized;

		private int m_TabIdx;

		public readonly BulkRecieveContext bulkRecieve;

		public List<TabContext> tabs => null;

		public List<int> tabTemplates => null;

		public int tabIdx
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TabContext currentTab => null;

		public event Action<int> onPrevChangeTabIdxEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> onChangeTabIdxEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onUpdatedAllEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onUpdatedContainMissionsEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void InitResidentTabs()
		{
		}

		public void SearchInOutMissions(Dictionary<string, object> datas, Dictionary<string, object> completeDatas, Dictionary<string, object> hideDatas, List<int> resEntries, List<int> resRemoves, List<int> resHides)
		{
		}

		public void ImportMissions(Dictionary<string, object> master, Dictionary<string, object> data, int initTabPoolId = 0, MissionTabType initTabType = MissionTabType.All)
		{
		}

		public void ImportContainMissionsUpdate(Func<int, int, Dictionary<string, object>> missionDataGetterFunc)
		{
		}

		public void ImportMissionsOverride(Dictionary<string, object> master, Dictionary<string, object> data, int initTabPoolId = 0, MissionTabType initTabType = MissionTabType.All)
		{
		}

		public void TurnOffNew(int tabIdx)
		{
		}

		private void OnUpdatedContainMissions()
		{
		}
	}
}
