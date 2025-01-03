using System.Collections.Generic;

namespace YgomGame.Scenario
{
	public interface IScenarioCardActorBehaviour
	{
		IReadOnlyList<int> GetBehaveCardSlots();

		ScenarioCardContainer.Operations GetBehaveCardOperations();
	}
}
