using UnityEngine;

namespace YgomGame.Scenario
{
	public class ScenarioBehavior_BgZoom : ScenarioBehaviour
	{
		private ScenarioBGActor m_BGActor;

		private object m_RenderTarget;

		private float m_TotalFadeSec;

		private float m_FadeSec;

		private float m_CurveDiff;

		private AnimationCurve m_AnimationCurve;

		private float m_SrcScale;

		private float m_DstScale;

		public ScenarioBehavior_BgZoom(object commandData)
			: base(null)
		{
		}

		protected override void ProgressInit()
		{
		}

		protected override void ProgressAction()
		{
		}
	}
}
