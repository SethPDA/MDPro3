using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace YgomGame.Scenario
{
	public class ScenarioController
	{
		private readonly ScenarioWork m_Work;

		private readonly StringBuilder m_PreGenerateTextBuilder;

		private ScenarioBehaviour m_HeadBehaviour;

		private readonly List<ScenarioBehaviour> m_AllBehaviours;

		private readonly List<IScenarioLogBehavior> m_LogBehaviors;

		private readonly Queue<ScenarioBehaviour> m_PlayQueueBehaviours;

		private readonly List<ScenarioBehaviour> m_PlayBehaviours;

		private readonly List<ScenarioBehaviour> m_RemoveBehavioursReserver;

		public ScenarioWork work => null;

		public bool isFadeInTransitionCompleted
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isFailed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isFinish => false;

		public bool isComplete => false;

		public List<ScenarioBehaviour> allBehaviours => null;

		public List<IScenarioLogBehavior> logBehaviors => null;

		public StringBuilder preGenerateTextBuilder => null;

		public ScenarioController(ScenarioWork work)
		{
		}

		public void Update()
		{
		}

		private bool ProgressPlayBehaviours()
		{
			return false;
		}

		private void ProgressFetchBehaviours()
		{
		}

		private void OnChangeStepBehaviour(ScenarioBehaviour behabiour, ScenarioBehaviour.Step step)
		{
		}

		public int ReadScenarioData(string scenarioName, List<object> commandList, bool loadCommand = false)
		{
			return 0;
		}

		private void AddBehavior(ScenarioBehaviour b)
		{
		}

		public static bool IsSupportedAsyncCommand(string command)
		{
			return false;
		}

		public ScenarioBehaviour GetActiveScenarioBehavior()
		{
			return null;
		}

		private void AbortByError(ScenarioBehaviour errorBehaviour)
		{
		}
	}
}
