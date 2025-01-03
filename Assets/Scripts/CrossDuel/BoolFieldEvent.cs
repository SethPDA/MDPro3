using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Willow.InGameField
{
	[CreateAssetMenu]
	public class BoolFieldEvent : BaseFieldEvent
	{
		private readonly List<BoolFieldEventListener> m_fieldEventListeners;

		private event Action<bool> m_responseBool
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

		public void RegisterListener(Action<bool> action)
		{
		}

		public void UnregisterListener(Action<bool> action)
		{
		}

		public void RegisterListener(BoolFieldEventListener listener)
		{
		}

		public void UnregisterListener(BoolFieldEventListener listener)
		{
		}

		public void Raise(bool value)
		{
		}
	}
}
