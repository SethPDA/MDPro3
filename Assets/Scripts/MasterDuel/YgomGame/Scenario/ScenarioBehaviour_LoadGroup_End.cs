namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_LoadGroup_End : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour
	{
		public bool IsFadeInTransitionCompleted()
		{
			return false;
		}

		public ScenarioBehaviour_LoadGroup_End(object commandData)
			: base(null)
		{
		}

		protected override void ProgressInit()
		{
		}
	}
}
