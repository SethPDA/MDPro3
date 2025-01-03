using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenCounterText : Tween
	{
		[SerializeField]
		public string format;

		[SerializeField]
		public float from;

		[SerializeField]
		public float to;

		private MDText text;

		private TMP_Text tmpText;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}

		private string GetCurrentCounterText(float par)
		{
			return null;
		}
	}
}
