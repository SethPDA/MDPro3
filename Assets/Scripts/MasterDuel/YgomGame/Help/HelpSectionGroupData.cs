using System;
using System.Collections.Generic;

namespace YgomGame.Help
{
	[Serializable]
	public class HelpSectionGroupData
	{
		public string label;

		public string titleTid;

		public bool visibleFromHelp;

		public List<HelpSectionData> sections;

		private Dictionary<string, HelpSectionData> m_SectionMap;

		public HelpSectionData GetSectionData(string sectionLabel)
		{
			return null;
		}
	}
}
