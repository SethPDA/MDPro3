using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class AvatarMotionSetting : ScriptableObject
	{
		public enum MotionID
		{
			WAIT1 = 0,
			WAIT2 = 1,
			WAIT3 = 2,
			MATCHING = 3,
			ENTRY = 4,
			ATTACK = 5,
			DAMAGE = 6,
			COST_DAMAGE = 7,
			VICTORY = 8,
			DEFEAT = 9,
			TAP1 = 10,
			TAP2 = 11,
			TAP3 = 12,
			APPEAL = 13,
			SHOP = 14,
			PROFILE = 15,
			OUTGAME = 16,
			CHANGE = 17
		}

		[Serializable]
		public class AvatarMotionInfo
		{
			public MotionID motionID;

			public string label;

			public AvatarMotionInfo Copy()
			{
				return null;
			}
		}

		private const string avatarMotionSettingPath = "Duel/ScriptableObject/AvatarMotionSetting";

		public List<AvatarMotionInfo> motionInfoList;

		public AvatarMotionInfo GetMotionInfo(MotionID id)
		{
			return null;
		}

		public static AvatarMotionSetting Load()
		{
			return null;
		}
	}
}
