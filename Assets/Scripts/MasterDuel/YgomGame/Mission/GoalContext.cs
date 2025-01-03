using System.Collections.Generic;

namespace YgomGame.Mission
{
	public class GoalContext
	{
		public readonly int idx;

		public readonly int requirement;

		public readonly bool isPeriod;

		public readonly int itemCategory;

		public readonly int itemId;

		public readonly int itemCount;

		public bool isRewardUnlocked;

		public bool recievedIconVisible;

		public MissionGoalWidget.GoalType GetGoalType(MissionContext missionContext)
		{
			return default(MissionGoalWidget.GoalType);
		}

		public GoalContext(int idx, Dictionary<string, object> data, Dictionary<string, object> master)
		{
		}

		public void Import(Dictionary<string, object> data)
		{
		}
	}
}
