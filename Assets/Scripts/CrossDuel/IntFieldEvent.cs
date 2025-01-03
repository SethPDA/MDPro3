using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace Willow.InGameField
{
	[CreateAssetMenu]
	[Preserve]
	public class IntFieldEvent : BaseFieldEvent
	{
		private readonly List<IntFieldEventListener> m_fieldEventListeners;

		private event Action<int> m_responseInt
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

		[Preserve]
		private void OnDisable()
		{
		}

		[Preserve]
		public void RegisterListener(Action<int> action)
		{
		}

		[Preserve]
		public void UnregisterListener(Action<int> action)
		{
		}

		[Preserve]
		public void RegisterListener(IntFieldEventListener listener)
		{
		}

		[Preserve]
		public void UnregisterListener(IntFieldEventListener listener)
		{
		}

		[Preserve]
		public void Raise(int value)
		{
		}
	}
}
