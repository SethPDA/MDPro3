using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioObjectContainer : ScenarioContainerBase
	{
		public readonly ScenarioObjectContainer3D container3D;

		public readonly ScenarioObjectContainerUI containerUI;

		public ScenarioObjectContainer(ElementObjectManager eom3D, ElementObjectManager eomUI)
			: base(null)
		{
		}

		public void Initialize(ScenarioWork work)
		{
		}

		public void OnStackRemove()
		{
		}

		public ScenarioContainerBase GetShakeTarget(int targetNo)
		{
			return null;
		}
	}
}
