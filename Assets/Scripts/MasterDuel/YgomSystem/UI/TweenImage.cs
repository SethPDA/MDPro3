using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenImage : Tween
	{
		[SerializeField]
		public Sprite[] frames;

		private Image image;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
