using UnityEngine;

namespace Willow.InGameField
{
	public class FieldParamEventController_AnimationEventReceiver : MonoBehaviour
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
			//fieldParamEventController.RaiseFromFieldCommandSetBool(boolFieldEventCommandSet);
			var name = boolFieldEventCommandSet.boolFieldEvent.name.Replace("_event", "");
			//Debug.Log(boolFieldEventCommandSet.boolFieldEvent.name + "-" + boolFieldEventCommandSet.boolValue);
			foreach(var t in transform.GetComponentsInChildren<Transform>(true))
			{
				if(t.name.Contains(name))
					t.gameObject.SetActive(boolFieldEventCommandSet.boolValue);
			}

        }
	}
}
