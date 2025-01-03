using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Timeline;

namespace Willow
{
	public class CustomTimelineObject : MonoBehaviour, ITimeControl
	{
		private GameObject m_parentObject;

		private Transform m_transform;

		private Transform m_transformParent;

		private Transform m_transformCamera;

		private Transform m_transformAnim;

		private Transform m_transformChild;

		private bool m_init;

		private PositionConstraint m_positionConstraint;

		private RotationConstraint m_rotationConstraint;

		public bool isSyncPosition
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSyncRotation
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSyncScale
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isLookAtCamera
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isIgnoreInitRotation
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isIgnoreInitScale
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isRelayChild
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Transform myTransform => null;

		public Transform transformChild => null;

		public Transform transformSync => null;

		public GameObject targetCameraObject => null;

		public GameObject targetParentObject => null;

		private PositionConstraint positionConstraint => null;

		private RotationConstraint rotationConstraint => null;

		public static Camera cameraSubstituteOfMain
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void OnControlTimeStart()
		{
		}

		public void OnControlTimeStop()
		{
		}

		public void SetTime(double time)
		{
		}

		private void OnValidate()
		{
		}

		private static void GetComponentRoots<T>(Transform t, ICollection<T> roots) where T : Component
		{
		}

		public void SetParentObject(GameObject parent)
		{
		}

		private bool UpdateTransform(Transform target, bool isPosition, bool isRotation, bool isScale)
		{
			return false;
		}

		private void LookAtCamera(Transform target)
		{
		}

		private void ClearConstrain()
		{
		}

		private void SetConstrain(bool isActive)
		{
		}
	}
}
