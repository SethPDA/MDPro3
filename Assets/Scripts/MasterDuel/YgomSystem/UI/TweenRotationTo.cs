using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenRotationTo : Tween
	{
		private Vector3 from;

		public Vector3 to;

		public bool quaternionLerp;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
