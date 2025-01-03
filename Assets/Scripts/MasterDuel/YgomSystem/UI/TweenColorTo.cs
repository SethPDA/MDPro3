using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenColorTo : Tween
	{
		[SerializeField]
		public ColorLabelProperty toLabel;

		[SerializeField]
		public Color to;

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
