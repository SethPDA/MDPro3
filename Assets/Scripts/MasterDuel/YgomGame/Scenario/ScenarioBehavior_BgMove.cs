using UnityEngine;

namespace YgomGame.Scenario
{
	public class ScenarioBehavior_BgMove : ScenarioBehaviour
	{
		private object m_RenderTarget;

		private ScenarioBGActor m_BGActor;

		private int m_Direction;

		private float m_TotalFadeSec;

		private float m_FadeSec;

		private float m_CurveDiff;

		private AnimationCurve m_AnimationCurve;

		private Vector3 m_SrcPos;

		private Vector3 m_DstPos;

		public ScenarioBehavior_BgMove(object commandData)
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
