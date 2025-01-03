using UnityEngine;

namespace YgomGame.Scenario
{
	public class ScenarioBehavior_BgFade : ScenarioBehaviour
	{
		private object m_RenderTarget;

		private ScenarioBGActor m_BGActor;

		private float m_TotalFadeSec;

		private float m_fadeSec;

		private Vector3 m_SrcPos;

		private Vector3 m_DstPos;

		private Color m_FromColor;

		private Color m_ToColor;

		public ScenarioBehavior_BgFade(object commandData)
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
