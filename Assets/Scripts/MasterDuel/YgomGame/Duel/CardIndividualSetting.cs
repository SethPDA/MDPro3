using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardIndividualSetting : ScriptableObject
	{
		[Serializable]
		public class MrkPowerTable
		{
			public int mrk;

			public EffectTaskCardMove.LandingType power;
		}

		[Serializable]
		public class MonsterCutinTable
		{
			public int mrk;
		}

		private static CardIndividualSetting m_Instance;

		private const string assetPath = "Duel/ScriptableObject/CardIndividualData";

		public List<MrkPowerTable> mrkPowerTable;

		public List<MonsterCutinTable> monsterCutinTable;

		protected static CardIndividualSetting instance => null;

		public static void LoadSetting(Action<CardIndividualSetting> onFinished)
		{
		}

		public static void UnloadSetting()
		{
		}

		public static EffectTaskCardMove.LandingType GetMonsterPower(int cardid)
		{
			return default(EffectTaskCardMove.LandingType);
		}

		public static bool IsMonsterCutin(int cardID)
		{
			return false;
		}
	}
}
