using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenPositionTargetFrom : Tween
	{
		private RectTransform rtrans;

		[SerializeField]
		public Vector3 from;

		[SerializeField]
		public bool updateX;

		[SerializeField]
		public bool updateY;

		[SerializeField]
		public bool updateZ;

		private Vector3 to;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
