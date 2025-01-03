using System;
using System.Collections.Generic;

namespace YgomGame.Scenario
{
	public class ScenarioBehavior_Bg : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour, IScenarioLoadGroupHandleBehaviour
	{
		private readonly float k_SrcFadeAlpha;

		private readonly float k_DstFadeAlpha;

		private bool m_IsLoaded;

		private float m_TotalFadeSec;

		private float m_FadeSec;

		private object m_RenderTarget;

		private object m_SubRenderTarget;

		public ScenarioBehavior_Bg(object commandData)
			: base(null)
		{
		}

		public bool IsFadeInTransitionCompleted()
		{
			return false;
		}

		protected override void ProgressInit()
		{
		}

		protected override void ProgressAction()
		{
		}

		public void CollectLoadPath(List<(string, Type)> res)
		{
		}

		public void CollectLoadMrk(List<int> res)
		{
		}
	}
}
