using UnityEngine;

namespace YgomSystem.UI
{
	//[CreateAssetMenu]
	public class TweenColorInfo : TweenGenerateInfo
	{
		[ColorLabelString]
		public string fromLabel;

		public Color from;

		[ColorLabelString]
		public string toLabel;

		public Color to;

		public bool isOverride;

		public bool isRecusive;
	}
}
