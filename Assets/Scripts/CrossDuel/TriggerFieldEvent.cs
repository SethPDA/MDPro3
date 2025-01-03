using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Willow.InGameField
{
	[CreateAssetMenu]
	public class TriggerFieldEvent : BaseFieldEvent
	{
		private readonly List<TriggerFieldEventListener> m_fieldEventListeners;

		private event Action m_responseTrigger
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnDisable()
		{
		}

		public void RegisterListener(Action action)
		{
		}

		public void UnregisterListener(Action action)
		{
		}

		public void RegisterListener(TriggerFieldEventListener listener)
		{
		}

		public void UnregisterListener(TriggerFieldEventListener listener)
		{
		}

		public void Raise()
		{
		}
	}
}
