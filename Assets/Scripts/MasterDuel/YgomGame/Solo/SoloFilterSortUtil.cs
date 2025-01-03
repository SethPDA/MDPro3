using System;

namespace YgomGame.Solo
{
	public class SoloFilterSortUtil
	{
		[Flags]
		public enum GateFilter
		{
			NONE = 1,
			NOT_CLEAR = 2,
			CLEAR = 4,
			LOCK = 8,
			COMPLETE = 0x10
		}

		public enum GateSort
		{
			ASC_DEFAULT = 1,
			DESC_DEFAULT = 2,
			ASC_RECENT_RELEASE = 3,
			DESC_RECENT_RELEASE = 4,
			ASC_RECENT_PLAY = 5,
			DESC_RECENT_PLAY = 6
		}

		private const string PATH_SOLO_SAVE = "SoloSave";

		private const string KEY_FILTER = "Filter";

		private const string KEY_SORT = "Sort";

		public static void SaveFilterSort(GateFilter gateFilter, GateSort gateSort)
		{
		}

		public static (GateFilter, GateSort) LoadFilterSort()
		{
			return default((GateFilter, GateSort));
		}
	}
}
