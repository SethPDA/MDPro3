using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class ChainedBezierMotion
	{
		public List<BezierMotionSetting> motionList;

		private int currentMotionIndex;

		private Vector3 currentOriginPosition;

		private Quaternion currentOriginRotation;

		private Vector3 originPosition;

		private Quaternion originRotation;

		private Vector3 targetPosition;

		private Quaternion targetRotation;

		public int motionNum => 0;

		public float totalAnimationTime => 0f;

		public void Initialize()
		{
		}

		public void Initialize(BezierMotionSetting[] motionList)
		{
		}

		public void Initialize(List<BezierMotionSetting> motionList)
		{
		}

		public void AddMotion(BezierMotionSetting motion)
		{
		}

		public void AddMotion(BezierMotionSetting[] motion)
		{
		}

		public void Begin(Vector3 originPosition, Quaternion originRotation, Vector3 targetPosition, Quaternion targetRotation)
		{
		}

		public void SetOrigin(Vector3 originPosition, Quaternion originRotation)
		{
		}

		public void SetTarget(Vector3 targetPosition, Quaternion targetRotation)
		{
		}

		public (Vector3, Quaternion) Update(float time)
		{
			return default((Vector3, Quaternion));
		}

		public (Vector3, Quaternion) UpdateByClampedTime(float clampedTime)
		{
			return default((Vector3, Quaternion));
		}

		public (Vector3, Quaternion) Get(float time, Camera camera = null)
		{
			return default((Vector3, Quaternion));
		}

		public (Vector3, Quaternion) GetByClampedTime(float clampedTime, Camera camera = null)
		{
			return default((Vector3, Quaternion));
		}

		public Vector3 GetStartPosition(int index)
		{
			return default(Vector3);
		}

		public Vector3 GetStartPosition()
		{
			return default(Vector3);
		}

		public Vector3 GetEndPosition(int index)
		{
			return default(Vector3);
		}

		public Vector3 GetEndPosition()
		{
			return default(Vector3);
		}

		public Vector3 GetViaPosition(int index)
		{
			return default(Vector3);
		}

		public (int, float) GetBezierMotionInfo(float time)
		{
			return default((int, float));
		}
	}
}
