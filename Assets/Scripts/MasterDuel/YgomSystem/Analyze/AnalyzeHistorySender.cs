using System.Collections.Generic;

namespace YgomSystem.Analyze
{
	public class AnalyzeHistorySender
	{
		private readonly int k_SendLimit;

		private static AnalyzeHistorySender s_Instance;

		private Dictionary<HistoryIDs, Dictionary<int, int>> m_HistoryMap;

		private static AnalyzeHistorySender instance => null;

		public static void AddCount(HistoryIDs historyId, int recordId = 0, int count = 1)
		{
		}

		public static Dictionary<string, object> Pop()
		{
			return null;
		}
	}
}
