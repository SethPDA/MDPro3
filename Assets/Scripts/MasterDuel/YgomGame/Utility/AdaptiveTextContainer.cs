using UnityEngine.UI;

namespace YgomGame.Utility
{
	public class AdaptiveTextContainer : ContentSizeFitter
	{
		public enum Mode
		{
			HorizontalEx = 0,
			VerticalEx = 1
		}

		public int maxWidth;

		public int maxHeight;

		public Mode mode;

		protected override void Awake()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}
	}
}
