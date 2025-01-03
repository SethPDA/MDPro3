using UnityEngine.Rendering.Universal;

namespace Willow
{
	public class PostProcessVolumeDepthOfField : BasePostProcessVolumeControl
	{
		private DepthOfField m_depthOfField;

		public float m_focusDistance;

		public float m_focalLength;

		public float m_aperture;

		public int m_bladeCount;

		public float m_bladeCurvature;

		public float m_bladeRotation;

		public float m_gaussianMaxRadius;

		private DepthOfFieldMode m_mode;

		private bool m_usedFocusDistance;

		private bool m_usedAperture;

		private bool m_usedFocalLength;

		private bool m_usedBladeCount;

		private bool m_usedBladeCurvature;

		private bool m_usedBladeRotation;

		private bool m_usedGaussianMaxRadius;

		private float m_prevFocusDistance;

		private float m_prevAperture;

		private float m_prevFocalLength;

		private int m_prevBladeCount;

		private float m_prevBladeCurvature;

		private float m_prevBladeRotation;

		private float m_prevGaussianMaxRadius;

		private DepthOfField depthOfField => null;

		protected override void CheckPostProcess()
		{
		}

		protected override void StartPostProcess()
		{
		}

		protected override void UpdatePostProcess()
		{
		}

		private void UpdateBokeh()
		{
		}

		private void UpdateGaussian()
		{
		}
	}
}
