using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardMoveMotionSetting : ScriptableObject
	{
		[Serializable]
		public class MotionInfo
		{
			public TeamType teamType;

			public PositionType fromPositon;

			public PositionType toPosition;

			public CardType cardType;

			public int cardPower;

			public FaceType faceType;

			public List<BezierMotionSetting> motionList;

			public string seCode;

			public MotionInfo Copy()
			{
				return null;
			}
		}

		public enum TeamType
		{
			Both = 0,
			Myself = 1,
			Rival = 2
		}

		public enum PositionType
		{
			Unknown = 0,
			Deck = 1,
			ExtraDeck = 2,
			Hand = 3,
			MonsterZone = 4,
			MagicZone = 5,
			Grave = 6,
			Exclude = 7,
			XyzMaterial = 8
		}

		public enum CardType
		{
			Normal = 0,
			Soul = 1,
			Both = 2
		}

		public enum FaceType
		{
			Face = 0,
			Back = 1,
			Both = 2
		}

		public List<MotionInfo> infoList;

		private const string motionSettingPath = "Duel/ScriptableObject/BezierMotion/CardMoveMotion/CardMoveMotionSetting";

		public static CardMoveMotionSetting instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MotionInfo GetInfo(SharedDefinition.Location fromLocation, int fromPosition, int fromIndex, SharedDefinition.Location toLocation, int toPosition, int toIndex, CardType cardType, int cardPower, FaceType faceType)
		{
			return null;
		}

		private PositionType PositionToPositionType(int position, int index)
		{
			return default(PositionType);
		}

		public MotionInfo GetInfo(SharedDefinition.Location fromLocation, PositionType fromPosition, SharedDefinition.Location toLocation, PositionType toPosition, CardType cardType, int cardPower, FaceType faceType)
		{
			return null;
		}

		public MotionInfo GetInfo(SharedDefinition.Location fromLocation, int fromPosition, int fromIndex, SharedDefinition.Location toLocation, int toPosition, int toIndex, bool toFace, CardType cardType, int cardPower = 0)
		{
			return null;
		}

		public BezierMotionSetting[] GetMotion(SharedDefinition.Location fromLocation, int fromPosition, int fromIndex, SharedDefinition.Location toLocation, int toPosition, int toIndex, bool toFace, CardType cardType, int cardPower = 0)
		{
			return null;
		}

		public List<MotionInfo> GetInfo(PositionType fromPosition, PositionType toPosition)
		{
			return null;
		}

		public int GetInfoIndex(MotionInfo info)
		{
			return 0;
		}

		public static string GetMoveStartSE(string seCode)
		{
			return null;
		}

		public static void Load(Action onFinished)
		{
		}
	}
}
