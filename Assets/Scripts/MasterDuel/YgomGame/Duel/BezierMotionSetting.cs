using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class BezierMotionSetting : ScriptableObject
	{
		public enum InterporationType
		{
			Bezier3Point = 0,
			Lerp2Point = 1
		}

		[Serializable]
		public class PositionOperation
		{
			public BasePositionSetting basePosition;

			public List<OffsetSetting> offsetList;

			public List<OverrideSetting> overrideList;

			public Vector3 Get(Vector3 origin_position, Vector3 target_position, Camera camera = null)
			{
				return default(Vector3);
			}

			public PositionOperation Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class BasePositionSetting
		{
			public BaseVectorValueType type;

			public Vector3 designation;

			public BasePositionSetting Clone()
			{
				return null;
			}
		}

		public enum BaseVectorValueType
		{
			OriginPosition = 0,
			TargetPosition = 1,
			Screen = 2,
			Designation = 3
		}

		[Serializable]
		public class OffsetSetting
		{
			public OffsetVectorValueType type;

			public Vector3 designation;

			public Vector3 rotationCorrection;

			public OffsetIntensityType intensityType;

			public float intensity;

			public OffsetSetting Clone()
			{
				return null;
			}
		}

		public enum OffsetVectorValueType
		{
			NormalizedDeltaTargetOrigin = 0,
			Designation = 1,
			NormalizedDeltaTargetBase = 2
		}

		public enum OffsetIntensityType
		{
			StartToTarget01 = 0,
			Designation = 1
		}

		[Serializable]
		public class OverrideSetting
		{
			public OverrideType type;

			public OverrideDirection directionFlag;

			public Vector3 designation;

			public OverrideSetting Clone()
			{
				return null;
			}
		}

		public enum OverrideType
		{
			OriginPosition = 0,
			TargetPosition = 1,
			Screen = 2,
			Designation = 3
		}

		public enum OverrideDirection
		{
			X = 1,
			Y = 2,
			Z = 4
		}

		[Serializable]
		public class LookElement
		{
			public LookElementType type;

			public LookType fromType;

			public Vector3 fromDesignationPosition;

			public LookType toType;

			public Vector3 toDesignationPosition;

			public Vector3 rotationAngle;

			public LookElement Clone()
			{
				return null;
			}

			public Quaternion Get(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, Vector3 start_position, Vector3 via_position, Vector3 end_position, Camera camera = null)
			{
				return default(Quaternion);
			}
		}

		public enum LookSettingType
		{
			Single = 0,
			Lerp2 = 1,
			Bezier3 = 2
		}

		public enum LookElementType
		{
			OriginRotation = 0,
			TargetRotation = 1,
			CameraRotation = 2,
			PositionDelta = 3
		}

		public enum LookType
		{
			OriginPosition = 0,
			TargetPosition = 1,
			StartPosition = 2,
			ViaPosition = 3,
			EndPosition = 4,
			CameraPosition = 5,
			DesignationPosition = 6
		}

		public InterporationType type;

		public PositionOperation startPositionOperation;

		public PositionOperation viaPositionOperation;

		public PositionOperation endPositionOperation;

		public AnimationCurve accelerationCurve;

		public LookSettingType lookSetting;

		public LookElement lookElement1;

		public LookElement lookElement2;

		public LookElement lookElement3;

		public AnimationCurve rotationAccelerationCurve;

		public int aditionalTurnNum;

		public Vector3 aditionalTurnDirection;

		public AnimationCurve aditionalTurnAccelerationCurve;

		public float animationTime;

		public Vector3 GetStartPosition(Vector3 origin_position, Vector3 target_position, Camera camera = null)
		{
			return default(Vector3);
		}

		public Vector3 GetViaPosition(Vector3 origin_position, Vector3 target_position, Camera camera = null)
		{
			return default(Vector3);
		}

		public Vector3 GetEndPosition(Vector3 origin_position, Vector3 target_position, Camera camera = null)
		{
			return default(Vector3);
		}

		public (Vector3, Quaternion) Get(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, float current_time, Camera camera = null)
		{
			return default((Vector3, Quaternion));
		}

		private Quaternion GetRotation(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, Vector3 start_position, Vector3 via_position, Vector3 end_position, float current_time, Camera camera = null)
		{
			return default(Quaternion);
		}

		private Quaternion GetAditionalTurn(float current_time)
		{
			return default(Quaternion);
		}

		public (Vector3, Quaternion) GetByClampedTime(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, float clamped_time, Camera camera = null)
		{
			return default((Vector3, Quaternion));
		}

		public BezierMotionSetting Clone()
		{
			return null;
		}
	}
}
