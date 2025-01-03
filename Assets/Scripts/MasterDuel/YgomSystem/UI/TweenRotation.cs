using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenRotation : Tween
	{
		public Vector3 from;

		public Vector3 to;

		public bool quaternionLerp;

		protected override void OnSetValue(float par)
		{
		}
	}
}
