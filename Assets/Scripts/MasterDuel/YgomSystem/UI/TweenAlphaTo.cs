using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenAlphaTo : Tween
	{
		[SerializeField]
		public float to;

		public bool isRecusive;

		private CanvasGroup canvasGroup;

		private float canvasAlpha;

		private List<KeyValuePair<Graphic, Color>> childGraps;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
