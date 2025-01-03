using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Bg
{
	public class BgStandModelSetting : ScriptableObject
	{
		[Serializable]
		public class StandModelInfo
		{
			public int id;

			public string modelName;

			public StandModelInfo Copy()
			{
				return null;
			}
		}

		private const string standModelSettingPath = "Duel/ScriptableObject/Bg/BgStandModelSetting";

		private const string standModelResPath = "Duel/BG/AvatarStand/AvatarStand_{0}{1:000}/AvatarStand_{0}{1:000}_{2}";

		private const string standModelResTypePath = "Duel/BG/AvatarStand/AvatarStand_{0}{1:000}/<_RESOURCE_TYPE_>/AvatarStand_{0}{1:000}_{2}";

		public List<StandModelInfo> infoList;

		public string GetModelName(int id)
		{
			return null;
		}

		public int GetModelNo(int id)
		{
			return 0;
		}

		public BgUnit.AvatarStandType GetModelType(int id)
		{
			return default(BgUnit.AvatarStandType);
		}

		public string GetModelResPath(int id, BgUnit.Side side)
		{
			return null;
		}

		public static void Load(Action<BgStandModelSetting> onFinish)
		{
		}

		public static string GetModelResPath(BgUnit.AvatarStandType standType, int standNo, BgUnit.Side side)
		{
			return null;
		}

		public static string GetAvatarStandTypeInital(BgUnit.AvatarStandType standType)
		{
			return null;
		}
	}
}
