using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class AttackMotionSetting : ScriptableObject
	{
		public enum EffectTiming
		{
			OnStart = 0,
			OnFinish = 1
		}

		[Serializable]
		public class MotionInfo
		{
			public string label;

			public List<MotionList> motionList;

			public string startSoundLabel;

			public bool useTrailEffect;

			public DuelEffectPool.Type trailEffect;

			public EffectTiming trailTiming;

			public float trailTimingOffset;

			public bool useAttackEffect;

			public DuelEffectPool.Type attackEffect;

			public string attackSoundLabel;

			public EffectTiming attackTiming;

			public float attackTimingOffset;

			public bool useHitEffect;

			public DuelEffectPool.Type hitEffect;

			public string hitSoundLabel;

			public EffectTiming hitTiming;

			public float hitTimingOffset;

			public bool forceHitEffect;

			public bool useShootEffect;

			public DuelEffectPool.Type shootEffect;

			public string shootSoundLabel;

			public EffectTiming shootTiming;

			public float shootTimingOffset;

			public BezierMotionContainer shootMotionSetting;

			public List<TimelineInfo> timelineInfoList;

			public bool forLethalAttack;

			public bool changeCardLayerToOver3D;

			public MotionInfo Copy()
			{
				return null;
			}

			private float GetStartTime(EffectTiming timing, float offset, int motionIndex)
			{
				return 0f;
			}

			public float GetTrailStartTime(int motionIndex)
			{
				return 0f;
			}

			public float GetAttackStartTime(int motionIndex)
			{
				return 0f;
			}

			public float GetHitStartTime(int motionIndex)
			{
				return 0f;
			}

			public float GetShootStartTime(int motionIndex)
			{
				return 0f;
			}

			public float GetTimelineStartTime(int motionIndex, int timelineIndex)
			{
				return 0f;
			}
		}

		[Serializable]
		public class TimelineInfo
		{
			public enum PlayTarget
			{
				Attacker = 0,
				Deffender = 1,
				Origin = 2
			}

			public enum RotationMode
			{
				None = 0,
				LookTarget = 1
			}

			public PlayTarget playTarget;

			public bool line;

			public bool trace;

			public RotationMode rotationMode;

			public bool onlyRotationY;

			public string path;

			public EffectTiming timing;

			public float timingOffset;

			public string soundLabel;

			public bool changeLayerToOver3D;

			public TimelineInfo Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class MotionList
		{
			public List<BezierMotionSetting> settingList;

			public float animationTime => 0f;
		}

		public List<MotionInfo> infoList;

		public MotionInfo Get(string label)
		{
			return null;
		}
	}
}
