using System;
using System.Collections.Generic;

namespace YgomGame.Help
{
	[Serializable]
	public class HelpSectionData
	{
		public string label;

		public string titleTid;

		public List<HelpRecordData> records;

		private Dictionary<string, HelpRecordData> m_RecordMap;

		public HelpRecordData GetRecordData(string recordLabel)
		{
			return null;
		}
	}
}
