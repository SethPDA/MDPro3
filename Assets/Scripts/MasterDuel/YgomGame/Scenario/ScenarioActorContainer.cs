using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioActorContainer : ScenarioContainerBase
	{
		private readonly string k_ELabelUnitGroup;

		private readonly string k_ELabelCardGroup;

		public readonly ScenarioUnitContainer unitContainer;

		public readonly ScenarioCardContainer cardContainer;

		public ScenarioActorContainer(ElementObjectManager eom)
			: base(null)
		{
		}
	}
}
