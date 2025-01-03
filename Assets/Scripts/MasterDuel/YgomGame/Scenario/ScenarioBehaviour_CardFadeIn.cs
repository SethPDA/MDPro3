using System;
using System.Collections.Generic;

namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_CardFadeIn : ScenarioBehaviour, IScenarioCardActorBehaviour, IScenarioLoadGroupHandleBehaviour
	{
		private class PlayData
		{
			public readonly ScenarioCardActor cardActor;

			public readonly string seLabel;

			public PlayData(ScenarioCardActor cardActor, string seLabel)
			{
			}
		}

		private List<ScenarioCardActor> m_CardActorLoads;

		private Queue<PlayData> m_CardActorQueue;

		private PlayData m_PlayingData;

		private List<int> m_ReserveSlots;

		private List<int> m_Mrks;

		public ScenarioBehaviour_CardFadeIn(object commandData)
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
