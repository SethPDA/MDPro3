using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardRunEffectSetting : ScriptableObject
	{
		public enum PlayType
		{
			Timeline3D = 0,
			TimelineHUD = 1,
			SimpleEffect = 2
		}

		public enum RunTiming
		{
			ChainRun = 0,
			CardBreak = 1,
			CardMove = 2,
			SpecialFx = 3,
			CardDisable = 4,
			Unknown = 65535
		}

		public enum Player
		{
			Myself = 0,
			Rival = 1,
			Any = 2
		}

		public enum RotationType
		{
			None = 0,
			PivotToTarget = 1
		}

		public enum ExtraSetting
		{
			None = 0,
			PositionActivation = 1,
			CardAttackPosition = 2,
			ChangeLayerMagic = 3,
			ChangeLayerOver3D = 4
		}

		[Serializable]
		public class CardRunEffectInfo
		{
			public bool enable;

			public int mrk;

			public Player player;

			public RunTiming runTiming;

			public bool useTargetEffect;

			public PlayType playType;

			public int effectType;

			public string effectPath;

			public RotationType rotationType;

			public Vector3 pivot;

			public float delay;

			public ExtraSetting extraSettings;

			public bool useCenterEffect;

			public PlayType centerPlayType;

			public int centerEffectType;

			public string centerEffectPath;

			public float centerDelay;

			public ExtraSetting centerExtraSettings;

			public string seLabel;

			public bool is3Dse;

			public bool waitFinish;

			public float finishSecond;

			public string cameraShakeType;

			public bool essential;

			public CardRunEffectInfo Copy()
			{
				return null;
			}
		}

		public List<CardRunEffectInfo> infoList;

		public CardRunEffectInfo Get(int mrk, Player player)
		{
			return null;
		}

		public CardRunEffectInfo Get(int mrk)
		{
			return null;
		}
	}
}
