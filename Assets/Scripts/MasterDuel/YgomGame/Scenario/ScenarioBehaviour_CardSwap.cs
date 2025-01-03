using System;
using System.Collections.Generic;

namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_CardSwap : ScenarioBehaviour, IScenarioCardActorBehaviour, IScenarioLoadGroupHandleBehaviour
	{
		private ScenarioCardActor m_CardActor;

		private int m_OldMrk;

		private int m_NewMrk;

		private int[] m_ReserveSlots;

		private bool m_PlayTrigger;

		private bool m_PreLoadComplete;

		public ScenarioBehaviour_CardSwap(object commandData)
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

		public void CollectLoadPath(List<(string, Type)> res)
		{
		}

		public void CollectLoadMrk(List<int> res)
		{
		}
	}
}
