using UnityEngine;

namespace YgomSystem.UI
{
	public class TweenLayoutElementScalerTo : Tween
	{
		[SerializeField]
		private float m_ToWidthScale;

		[SerializeField]
		private float m_ToHeightScale;

		private float m_FromWidthScale;

		private float m_FromHeightScale;

		private LayoutElementScaler m_LayoutElementScalerCache;

		private LayoutElementScaler layoutElementScaler => null;

		protected override void CaptureFrom()
		{
		}

		protected override void OnSetValue(float par)
		{
		}
	}
}
