using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_ScreenFade : ScenarioBehaviour, IScenarioScreenActorBehaviour, IScenarioBehaviour
	{
		private ScenarioScreenContainer.Targets m_ScreenTarget;

		private Graphic m_FadeTarget;

		private Color m_FromColor;

		private Color m_ToColor;

		private float m_FadeTime;

		private float m_CrntTime;

		public bool isOverrideBehaveScreen => false;

		public ScenarioBehaviour_ScreenFade(object commandData)
			: base(null)
		{
		}

		public ScenarioScreenContainer.Targets GetBehaveScreenTargets()
		{
			return default(ScenarioScreenContainer.Targets);
		}

		public ScenarioScreenContainer.Operations GetBehaveScreenOperations()
		{
			return default(ScenarioScreenContainer.Operations);
		}

		protected override void ProgressInit()
		{
		}

		protected override void ProgressAction()
		{
		}

		protected override void ProgressFinish()
		{
		}

		public override bool IsOverrideBehaviour(ScenarioBehaviour target)
		{
			return false;
		}
	}
}
