namespace YgomGame.Scenario
{
	public interface IScenarioScreenActorBehaviour : IScenarioBehaviour
	{
		bool isOverrideBehaveScreen { get; }

		ScenarioScreenContainer.Targets GetBehaveScreenTargets();

		ScenarioScreenContainer.Operations GetBehaveScreenOperations();
	}
}
