using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.DuelLive
{
	[Serializable]
	public class DuelLiveShowcaseImportData
	{
		[SerializeField]
		private DuelLiveImportSettingData[] settingData;

		private Dictionary<string, object> m_Data;

		public DuelLiveImportSettingData[] GetSettingData()
		{
			return null;
		}

		public Dictionary<string, object> GetReplayData()
		{
			return null;
		}

		public void AddData(DuelLiveImportSettingData data)
		{
		}
	}
}
