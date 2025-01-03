using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class TweenScroll : Tween
	{
		public enum SCROLL_TYPE
		{
			HORIZONTAL = 0,
			VERTICAL = 1
		}

		[SerializeField]
		public float from;

		[SerializeField]
		public float to;

		[SerializeField]
		public SCROLL_TYPE scrollType;

		[SerializeField]
		public bool normalize;

		private ScrollRect m_ScrollRect;

		private ScrollRect scrollRect => null;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
