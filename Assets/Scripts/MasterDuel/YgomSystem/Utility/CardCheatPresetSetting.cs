using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSystem.Utility
{
	public class CardCheatPresetSetting : ScriptableObject
	{
		public enum PositionType
		{
			Field = 0,
			Hand = 1,
			Deck = 2,
			Grave = 3,
			Exclude = 4
		}

		[Serializable]
		public class CheatInfo
		{
			public SharedDefinition.Location location;

			public PositionType position;

			public int cardID;

			public int createNum;

			public string note;

			public CheatInfo Copy()
			{
				return null;
			}
		}

		[Serializable]
		public class CheatPreset
		{
			public int presetID;

			public List<CheatInfo> infoList;

			public string note;

			public CheatPreset Copy()
			{
				return null;
			}
		}

		public List<CheatPreset> presetList;

		private const string path = "Debug/ScriptableObjects/CardCheatPresetSetting";

		private static CardCheatPresetSetting _instance;

		public static CardCheatPresetSetting instance => null;

		public CheatPreset GetAt(int index)
		{
			return null;
		}

		public CheatPreset Get(int presetID)
		{
			return null;
		}

		public int GetIndex(int presetID)
		{
			return 0;
		}

		public int GetNum()
		{
			return 0;
		}
	}
}
