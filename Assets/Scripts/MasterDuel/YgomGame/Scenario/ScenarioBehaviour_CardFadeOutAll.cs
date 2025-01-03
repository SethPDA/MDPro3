using System.Collections.Generic;

namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_CardFadeOutAll : ScenarioBehaviour, IScenarioCardActorBehaviour
	{
		private List<int> m_CardSlots;

		private ScenarioCardActor[] m_CardActors;

		private bool m_PlayTrigger;

		public ScenarioBehaviour_CardFadeOutAll(object commandData)
			: base(null)
		{
		}

		public IReadOnlyList<int> GetBehaveCardSlots()
		{
			return null;
		}

		public ScenarioCardContainer.Operations GetBehaveCardOperations()
		{
			return default(ScenarioCardContainer.Operations);
		}

		protected override void ProgressInit()
		{
		}

		protected override void ProgressAction()
		{
		}

		public override bool IsOverrideBehaviour(ScenarioBehaviour target)
		{
			return false;
		}
	}
}
