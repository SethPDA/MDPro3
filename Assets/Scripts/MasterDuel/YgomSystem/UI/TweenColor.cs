using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenColor : Tween
	{
		[SerializeField]
		[ColorLabelString]
		public string fromLabel;

		[SerializeField]
		public Color from;

		[ColorLabelString]
		[SerializeField]
		public string toLabel;

		[SerializeField]
		public Color to;

		public bool isOverride;

		public bool isRecusive;

		private List<KeyValuePair<Graphic, Color>> childGraps;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
