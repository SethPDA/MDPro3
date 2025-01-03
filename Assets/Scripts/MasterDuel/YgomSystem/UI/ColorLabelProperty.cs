using System;
using UnityEngine;

namespace YgomSystem.UI
{
	[Serializable]
	public class ColorLabelProperty
	{
		[ColorLabelString]
		public string label;

		public Color rgba;

		public Color GetColor()
		{
			return default(Color);
		}
	}
}
