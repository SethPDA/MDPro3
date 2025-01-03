using System.Collections.Generic;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioScreenContainer : ScenarioContainerBase
	{
		public enum Targets
		{
			None = 0,
			TextUnder = 1,
			TextOver = 2
		}

		public enum Operations
		{
			None = 0,
			Color = 1
		}

		private readonly List<IScenarioScreenActorBehaviour> m_RegistedBehaviours;

		private readonly List<IScenarioScreenActorBehaviour> m_ReserveRemoveBehaviours;

		private readonly Image m_ScreenTextUnder;

		private readonly Image m_ScreenTextOver;

		public ScenarioScreenContainer(ElementObjectManager eom, Image screenTextUnder, Image screenTextOver)
			: base(null)
		{
		}

		public Image GetScreen(Targets target)
		{
			return null;
		}

		public bool IsReadyControllBehaviour(IScenarioScreenActorBehaviour controllBehaviour)
		{
			return false;
		}

		public bool AssignBehaviour(IScenarioScreenActorBehaviour controllBehaviour)
		{
			return false;
		}

		public bool RemoveBehaviour(IScenarioScreenActorBehaviour controllBehaviour)
		{
			return false;
		}
	}
}
