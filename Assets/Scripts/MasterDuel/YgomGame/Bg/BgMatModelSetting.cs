using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Bg
{
	public class BgMatModelSetting : ScriptableObject
	{
		[Serializable]
		public class MatModelInfo
		{
			public int id;

			public string modelName;

			public string seLabel;

			public bool isResources;

			public MatModelInfo Copy()
			{
				return null;
			}
		}

		private const string matModelSettingPath = "Duel/ScriptableObject/Bg/BgMatModelSetting";

		private const string bgModelResPath = "Duel/BG/Mat/Mat_{0:000}/Mat_{0:000}_{1}";

		private const string bgModelResTypePath = "Duel/BG/Mat/Mat_{0:000}/<_RESOURCE_TYPE_>/Mat_{0:000}_{1}";

		private const int defaultMatNo = 2;

		public List<MatModelInfo> infoList;

		public string GetPath(int id)
		{
			return null;
		}

		public int GetModelNo(int id)
		{
			return 0;
		}

		public int GetModelIdFromNo(int no)
		{
			return 0;
		}

		public string GetSeLabel(int id)
		{
			return null;
		}

		public string GetModelResPathFromId(int id, BgUnit.Side side)
		{
			return null;
		}

		public static void Load(Action<BgMatModelSetting> onFinish)
		{
		}

		public static string GetModelResPath(int bgNo, BgUnit.Side side)
		{
			return null;
		}
	}
}
