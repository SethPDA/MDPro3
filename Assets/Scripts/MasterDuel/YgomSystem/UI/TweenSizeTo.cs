using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenSizeTo : Tween
	{
		private RectTransform rtrans;

		private Vector2 from;

		[SerializeField]
		public Vector2 to;

		[SerializeField]
		public bool ignoreWidth;

		[SerializeField]
		public bool ignoreHeight;

		private LayoutElement layout;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
