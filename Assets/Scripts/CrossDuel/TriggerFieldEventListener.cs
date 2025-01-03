namespace Willow.InGameField
{
	public class TriggerFieldEventListener : BaseFieldEventListener
	{
		public TriggerFieldEvent target;

		public ResponseTriggerEvent responseTrigger;

		public bool dontUnregisterOnDisabled;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnEventRaised()
		{
		}

		public override BaseFieldEvent GetTargetFieldEvent()
		{
			return null;
		}

		public override void SetOrOverwriteEvent(BaseFieldEvent fieldEvent)
		{
		}
	}
}
