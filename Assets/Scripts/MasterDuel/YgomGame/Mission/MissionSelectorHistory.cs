using System.Collections.Generic;

namespace YgomGame.Mission
{
	public class MissionSelectorHistory
	{
		private List<IMissionSelectorHistoryHandler> m_Handlers;

		public void Assign(IMissionSelectorHistoryHandler handler)
		{
		}

		public void Save()
		{
		}

		public bool TrySelect()
		{
			return false;
		}
	}
}
