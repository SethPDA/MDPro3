using System.Collections.Generic;

namespace YgomGame.Mission
{
	public class TabContextImportable : TabContext
	{
		public TabContextImportable(MissionTabType tabType, int campaignPoolId = 0, long campaignBeginTs = 0L, string tabNameTextId = null, string tabShortNameTextId = null)
			: base(default(MissionTabType), 0, 0L)
		{
		}

		public void ImportOverride(List<Dictionary<string, object>> masters, List<Dictionary<string, object>> datas)
		{
		}

		public void ImportOverride(Dictionary<string, object> master, Dictionary<string, object> data)
		{
		}

		private void InnerImportOverride(Dictionary<string, object> master, Dictionary<string, object> data)
		{
		}
	}
}
