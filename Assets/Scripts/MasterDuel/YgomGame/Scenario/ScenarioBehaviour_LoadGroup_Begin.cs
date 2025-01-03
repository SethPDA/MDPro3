namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_LoadGroup_Begin : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour
	{
		private int m_InnerStep;

		public bool IsFadeInTransitionCompleted()
		{
			return false;
		}

		public ScenarioBehaviour_LoadGroup_Begin(object commandData)
			: base(null)
		{
		}

		protected override void ProgressInit()
		{
		}
	}
}
