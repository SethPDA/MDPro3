using System;
using System.Collections.Generic;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario
{
	public class ScenarioCardContainer : ScenarioContainerBase
	{
		public enum Operations
		{
			InitMrk = 1,
			PlayAnimation = 2
		}

		public class InitializeData
		{
			public ElementObjectManager cardModelPref;

			public ElementObjectManager cardPopPref;

			public ScenarioCardActor.TimelineAssets timelineAssets;
		}

		public readonly int k_LocatorLen;

		private readonly string k_ELabelLocatorFormat;

		private readonly string k_ELabelCardLocator;

		private readonly string k_ELabelPopLocator;

		private readonly ElementObjectManager[] m_Locators;

		private ElementObjectManager m_CardModelPref;

		private ElementObjectManager m_CardPopPref;

		private ScenarioCardActor.TimelineAssets m_TimelineAssets;

		private Dictionary<int, ScenarioCardActor> m_CardActorMap;

		public Action<ScenarioCardActor> onCreateCallback;

		public int[] allExistsIdxs => null;

		public ScenarioCardActor Item => null;

		public bool Contains(int index)
		{
			return false;
		}

		public ScenarioCardContainer(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(InitializeData initializeData)
		{
		}

		public ScenarioCardActor CreateActor(int index)
		{
			return null;
		}

		public ScenarioCardActor SearchByMrk(int mrk)
		{
			return null;
		}

		public int GetSlotByMrk(int mrk)
		{
			return 0;
		}

		public bool IsReadyControllBehaviour(IScenarioCardActorBehaviour controllBehaviour)
		{
			return false;
		}
	}
}
