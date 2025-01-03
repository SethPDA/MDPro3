namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_Title : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour, IScenarioPreGenerateTextBehaviour, IScenarioLogBehavior
	{
		private string m_TitleText;

		private ScenarioBGActor m_BGActor;

		private float m_CurrentSec;

		private int m_InnerStep;

		public override bool isReady => false;

		public bool IsFadeInTransitionCompleted()
		{
			return false;
		}

		public ScenarioBehaviour_Title(object commandData)
			: base(null)
		{
		}

		public string GetPreGenerateText()
		{
			return null;
		}

		protected override void ProgressInit()
		{
		}
	}
}
