using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace Willow.InGameField
{
	[Preserve]
	public class FieldParamEventController_SignalReceiver : MonoBehaviour, INotificationReceiver
	{
		public FieldParamEventController fieldParamEventController;

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

		public void OnNotify(Playable origin, INotification notification, object context)
		{
		}
	}
}
