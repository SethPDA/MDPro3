using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenScale : Tween
	{
		[SerializeField]
		public Vector3 from;

		[SerializeField]
		public Vector3 to;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
