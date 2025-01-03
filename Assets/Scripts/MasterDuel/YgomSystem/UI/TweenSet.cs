using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenSet : Tween
	{
		[Flags]
		public enum Target
		{
			position = 1,
			scale = 2,
			rotation = 4,
			color = 8,
			gameObject = 0x10
		}

		[Serializable]
		public class Param
		{
			public Vector3 position;

			public Vector3 scale;

			public Quaternion rotation;

			public Color color;

			public GameObject gameObject;
		}

		[SerializeField]
		public Param from;

		[SerializeField]
		public Param to;

		[SerializeField]
		[EnumFlags]
		public Target target;

		private Color fromColor;

		private RectTransform rtrans;

		private Graphic graphic;

		private int crntParam;

		private List<KeyValuePair<Graphic, Color>> childGraps;

		private void ScanChildGraphic(GameObject obj)
		{
		}

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
