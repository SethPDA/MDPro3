using UnityEngine;
using UnityEngine.Scripting;

namespace Willow.InGameField
{
	[RequireDerived]
	public abstract class BaseFieldEventListener : MonoBehaviour
	{
		public abstract BaseFieldEvent GetTargetFieldEvent();

		public abstract void SetOrOverwriteEvent(BaseFieldEvent fieldEvent);
	}
}
