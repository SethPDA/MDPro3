namespace Willow.InGameField
{
	public class BoolFieldEventListener : BaseFieldEventListener
	{
		public BoolFieldEvent target;

		public ResponseBoolEvent responseBool;

		public ResponseStringEvent responseString;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnEventRaised(bool value)
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
