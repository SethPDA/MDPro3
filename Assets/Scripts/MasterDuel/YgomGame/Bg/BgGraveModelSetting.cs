using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Bg
{
	public class BgGraveModelSetting : ScriptableObject
	{
		[Serializable]
		public class GraveModelInfo
		{
			public int id;

			public string modelName;

			public GraveModelInfo Copy()
			{
				return null;
			}
		}

		private const string graveModelSettingPath = "Duel/ScriptableObject/Bg/BgGraveModelSetting";

		private const string graveResPath = "Duel/BG/Grave/Grave_{0}{1:000}/Grave_{0}{1:000}_{2}";

		private const string graveResTypePath = "Duel/BG/Grave/Grave_{0}{1:000}/<_RESOURCE_TYPE_>/Grave_{0}{1:000}_{2}";

		private const int defaultGraveNo = 2;

		public List<GraveModelInfo> infoList;

		public string GetModelName(int id)
		{
			return null;
		}

		public int GetModelNo(int id)
		{
			return 0;
		}

		public BgGrave.GraveType GetModelType(int id)
		{
			return default(BgGrave.GraveType);
		}

		public string GetModelResPath(int id, BgUnit.Side side)
		{
			return null;
		}

		public static void Load(Action<BgGraveModelSetting> onFinish)
		{
		}

		public static string GetModelResPath(BgGrave.GraveType graveType, int graveNo, BgUnit.Side side)
		{
			return null;
		}

		public static string GetGraveTypeInital(BgGrave.GraveType graveType)
		{
			return null;
		}
	}
}
