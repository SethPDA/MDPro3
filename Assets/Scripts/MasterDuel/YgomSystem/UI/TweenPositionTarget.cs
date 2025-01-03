using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenPositionTarget : Tween
	{
		private RectTransform rtrans;

		[SerializeField]
		public Vector3 from;

		[SerializeField]
		public Vector3 to;

		[SerializeField]
		public bool updateX;

		[SerializeField]
		public bool updateY;

		[SerializeField]
		public bool updateZ;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
