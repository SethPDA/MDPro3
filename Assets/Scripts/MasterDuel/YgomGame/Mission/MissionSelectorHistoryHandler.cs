using System;
using System.Collections.Generic;

namespace YgomGame.Mission
{
	public class MissionSelectorHistoryHandler : IMissionSelectorHistoryHandler
	{
		private readonly Func<bool> m_IsSelectedFunc;

		private readonly Action<Dictionary<string, object>> m_SaveSelectorHistoryCallback;

		private readonly Func<Dictionary<string, object>, bool> m_TrySelectHistoryFunc;

		private readonly Dictionary<string, object> m_SaveArgs;

		public bool isSelected => false;

		public MissionSelectorHistoryHandler(Func<bool> isSelectedFunc, Action<Dictionary<string, object>> saveSelectorHistoryCallback, Func<Dictionary<string, object>, bool> trySelectHistoryFunc)
		{
		}

		public void SetSaveArgs(string key, object value)
		{
		}

		public void SaveSelectorHistory()
		{
		}

		public bool TrySelectHistory()
		{
			return false;
		}
	}
}
