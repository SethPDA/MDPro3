using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenTransformTo : Tween
	{
		private Vector3 fromPosition;

		private Quaternion fromRotation;

		private Vector3 fromScale;

		[SerializeField]
		public Transform to;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
