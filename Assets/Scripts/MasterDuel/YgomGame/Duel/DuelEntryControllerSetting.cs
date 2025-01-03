using System;
using UnityEngine;
using YgomGame.Menu;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class DuelEntryControllerSetting : ScriptableObject
	{
		[Serializable]
		public class DuelEntryTimelineInfoEx
		{
			public PvpMenuDefine.MatchingType match_type;

			public int logo_id;

			public int logo_type;

			public string event_label;

			public string prefab_path;
		}

		[SerializeField]
		private DuelEntryTimelineInfoEx[] m_DuelEntryTimelineInfoExTable;

		private static DuelEntryControllerSetting m_Instance;

		private const string PATH = "Duel/ScriptableObject/DuelEntryControllerSetting";

		protected static DuelEntryControllerSetting Instance => null;

		public static (bool, string, string) GetTimelineExInfo(int logo_mixid)
		{
			return default((bool, string, string));
		}
	}
}
