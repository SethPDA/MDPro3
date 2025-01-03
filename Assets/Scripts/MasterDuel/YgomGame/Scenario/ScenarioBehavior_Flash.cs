using UnityEngine;

namespace YgomGame.Scenario
{
	public class ScenarioBehavior_Flash : ScenarioBehaviour, IScenarioScreenActorBehaviour, IScenarioBehaviour
	{
		private readonly string k_TweenFlash;

		private GameObject m_TargetGo;

		private int m_TotalCnt;

		private int m_Cnt;

		public bool isOverrideBehaveScreen => false;

		public ScenarioBehavior_Flash(object commandData)
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
