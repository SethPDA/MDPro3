using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenAlpha : Tween
	{
		[SerializeField]
		public float from;

		[SerializeField]
		public float to;

		public bool isRecusive;

		private CanvasGroup canvasGroup;

		private List<KeyValuePair<Graphic, Color>> childGraps;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
