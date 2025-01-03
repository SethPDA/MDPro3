using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Help
{
	[Serializable]
	public class HelpMappingData
	{
		public const string k_JsonPath = "Help/HelpMapping";

		[SerializeField]
		public List<HelpSectionGroupData> groups;

		private Dictionary<string, HelpSectionGroupData> m_SectionGroupMap;

		public static void GetAsync(Action<HelpMappingData> onComplete)
		{
		}

		public static HelpMappingData FromJson(string json)
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}

		public bool ValidHelpPath(string fullPath)
		{
			return false;
		}

		public HelpSectionData GetSectionData(string groupLabel, string sectionLabel)
		{
			return null;
		}
	}
}
