using System.Collections.Generic;

namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_CardFadeOut : ScenarioBehaviour, IScenarioCardActorBehaviour
	{
		private ScenarioCardActor m_CardActor;

		private bool m_PlayTrigger;

		private int m_Mrk;

		private int[] m_ReserveSlots;

		public ScenarioBehaviour_CardFadeOut(object commandData)
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
