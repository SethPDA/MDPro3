using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class AvatarModelSetting : ScriptableObject
	{
		[Serializable]
		public class ChangeCondition
		{
			public Character.SubAvatarChange condition;

			public List<int> param;

			public ChangeCondition(Character.SubAvatarChange condition)
			{
			}
		}

		[Serializable]
		public class AvatarModelInfo
		{
			public int id;

			public string path;

			public string seLabel;

			public SubAvatarInfo subAvatarInfo;

			public AvatarModelInfo Copy()
			{
				return null;
			}
		}

		[Serializable]
		public class SubAvatarInfo
		{
			public int subAvatarId;

			public string changeEffectPath;

			public List<ChangeCondition> conditionList;

			public bool useChangeMotion;

			public float changeDelay;
		}

		private const string avatarModelSettingPath = "Duel/ScriptableObject/AvatarModelSetting";

		public List<AvatarModelInfo> infoList;

		public string GetPath(int id)
		{
			return null;
		}

		public string GetSeLabel(int id)
		{
			return null;
		}

		public int GetSubAvatarlId(int id)
		{
			return 0;
		}

		public string GetSubAvatarPath(int id)
		{
			return null;
		}

		public string GetChangeEffectPath(int id)
		{
			return null;
		}

		public Dictionary<Character.SubAvatarChange, List<int>> GetSubAvatarChangeCondition(int id)
		{
			return null;
		}

		public SubAvatarInfo GetSubAvatarInfo(int id)
		{
			return null;
		}

		public string LoadSoundXml(int id)
		{
			return null;
		}

		public static AvatarModelSetting LoadImmediate()
		{
			return null;
		}

		public static void Load(Action<AvatarModelSetting> onFinish)
		{
		}
	}
}
