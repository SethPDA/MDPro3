using UnityEngine.Scripting;

namespace Willow.InGameField
{
	[Preserve]
	public class IntFieldEventListener : BaseFieldEventListener
	{
		public IntFieldEvent target;

		public ResponseIntEvent responseInt;

		public ResponseStringEvent responseString;

		public bool dontUnregisterOnDisabled;

		[Preserve]
		private void OnEnable()
		{
		}

		[Preserve]
		private void OnDisable()
		{
		}

		[Preserve]
		private void OnDestroy()
		{
		}

		[Preserve]
		public void OnEventRaised(int value)
		{
		}

		[Preserve]
		public override BaseFieldEvent GetTargetFieldEvent()
		{
			return null;
		}

		[Preserve]
		public override void SetOrOverwriteEvent(BaseFieldEvent fieldEvent)
		{
		}
	}
}
