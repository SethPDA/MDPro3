using UnityEngine;

namespace YgomSystem.UI
{
	//[CreateAssetMenu]
	public class TweenColorToInfo : TweenGenerateInfo
	{
		[ColorLabelString]
		public string toLabel;

		public Color to;

		public bool isRecusive;
	}
}
