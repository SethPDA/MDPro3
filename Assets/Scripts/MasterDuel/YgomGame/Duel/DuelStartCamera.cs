using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelStartCamera : IMainCameraOperation
	{
		private float time;

		public ChainedBezierMotion motion
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

		public DuelStartCamera(ChainedBezierMotion motion, Vector3 targetPosition, Quaternion targetRotation)
		{
		}

		public void LateUpdateOperation(MainCameraOrganizer mainCamera)
		{
		}

		public void UpdateOperation(MainCameraOrganizer mainCamera)
		{
		}
	}
}
