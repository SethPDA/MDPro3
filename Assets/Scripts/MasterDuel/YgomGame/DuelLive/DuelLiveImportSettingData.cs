using System;

namespace YgomGame.DuelLive
{
	[Serializable]
	public class DuelLiveImportSettingData
	{
		public string key;

		public KeyValueString[] stringDictionary;

		public KeyValueList[] listDictionary;
	}
}
