namespace YgomGame.Scenario
{
	public class ScenarioBehaviour_BlurLayer : ScenarioBehaviour
	{
		private ScenarioBlurLayerActor m_BlurLayerActor;

		private float m_TotalFadeSec;

		private float m_FadeSec;

		private float m_FromEffectVal;

		private float m_ToEffectVal;

		public ScenarioBehaviour_BlurLayer(object commandData)
			: base(null)
		{
		}

		protected override void ProgressInit()
		{
		}

		protected override void ProgressAction()
		{
		}
	}
}
