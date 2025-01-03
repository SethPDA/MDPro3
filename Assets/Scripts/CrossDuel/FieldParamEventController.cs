using UnityEngine;

namespace Willow.InGameField
{
	public class FieldParamEventController : MonoBehaviour
	{
		public Blackboard blackboard;

		public void Init()
		{
		}

		public void AttachAnimationEventReceiver(GameObject target)
		{
		}

		public void AttachFieldParamEventController_SignalReceiver(GameObject root)
		{
		}

		public void RaiseFromFieldCommandSet(Object fieldEventCommandSet)
		{
		}

		public void RaiseFromFieldCommandSetInt(IntFieldEventCommandSet intFieldEventCommandSet)
		{
		}

		public void RaiseFromFieldCommandSetBool(BoolFieldEventCommandSet boolFieldEventCommandSet)
		{
		}

		public void RaiseFromFieldCommandSetTrigger(TriggerFieldEventCommandSet triggerFieldEventCommandSet)
		{
		}

		public void RaiseIntEvent(string targetEventName, int intValue)
		{
		}

		public void RaiseBoolEvent(string targetEventName, bool boolValue)
		{
		}

		public void RaiseTriggerEvent(string targetEventName)
		{
		}
	}
}
