using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenStretch : TweenStretchTo
	{
		[SerializeField]
		public StretchOffset from;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
