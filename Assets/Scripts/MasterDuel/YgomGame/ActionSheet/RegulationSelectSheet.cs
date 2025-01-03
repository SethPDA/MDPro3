using System;
using System.Collections.Generic;
using YgomGame.Menu;

namespace YgomGame.ActionSheet
{
	public class RegulationSelectSheet
	{
		private List<int> m_RegulationIds;

		private List<ActionSheetViewController.EntryData> m_Entrys;

		public List<int> regulationIds => null;

		public List<ActionSheetViewController.EntryData> regulationNames => null;

		public void SetInPeriodTournaments(bool checkBox = false, int defaultReg = 0, Dictionary<string, object> ruleInfo = null)
		{
		}

		public void Open(Action<int, string> callback)
		{
		}

		public (int, string) GetFirstRegulationInfo()
		{
			return default((int, string));
		}

		public string GetRegLabel(int regId)
		{
			return null;
		}

		private bool GetTextGroup(string fullTextId, out string groupId)
		{
			groupId = null;
			return false;
		}

		public void OpenInPeriodTournament(Action<int, string> callback, bool checkBox = false, int defaultReg = 0)
		{
		}
	}
}
