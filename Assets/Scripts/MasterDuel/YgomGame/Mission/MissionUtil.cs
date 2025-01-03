using System.Collections.Generic;

namespace YgomGame.Mission
{
	public static class MissionUtil
	{
		public static bool IsResidentTab(this MissionTabType tabType)
		{
			return false;
		}

		public static bool ExistsUnlockResidentTab(this MissionTabType tabType)
		{
			return false;
		}

		public static int GetOrder(this MissionTabType tabType)
		{
			return 0;
		}

		public static MissionTabType ToResidentTabType(this MissionCategory category)
		{
			return default(MissionTabType);
		}

		public static string GetMissionName(int logicNo, List<object> logicParams)
		{
			return null;
		}
	}
}
