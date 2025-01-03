using System.Collections.Generic;
using UnityEngine;

namespace Willow.InGameField
{
	public class Blackboard : ScriptableObject
	{
		private Dictionary<int, BaseFieldEvent> m_fieldEventMap;

		public Dictionary<int, BaseFieldEvent> fieldEventMap => null;

		public void SetEventFromRecipe(EventRecipe eventRecipe)
		{
		}

		public void SetEvent(BaseFieldEvent fieldEvent, EventScope eventScope = EventScope.Global)
		{
		}

		public bool HasChildEvent(BaseFieldEvent targetEvent)
		{
			return false;
		}

		public bool HasChildEvent(string targetEventName)
		{
			return false;
		}

		public T GetChildEvent<T>(BaseFieldEvent targetEvent) where T : BaseFieldEvent
		{
			return null;
		}

		public BaseFieldEvent GetChildEvent(BaseFieldEvent targetEvent)
		{
			return null;
		}

		public T GetChildEvent<T>(string targetEventName) where T : BaseFieldEvent
		{
			return null;
		}

		public BaseFieldEvent GetChildEvent(string targetEventName)
		{
			return null;
		}
	}
}
