using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.UI
{
	public class ContainRectTrigger : MonoBehaviour
	{
		private RectTransform m_Container;

		private RectTransform m_Target;

		public bool isContain
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event Action<bool> onChangeEvent
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

		public static ContainRectTrigger Attach(RectTransform target, RectTransform container, Action<bool> onChangeCallback = null)
		{
			return null;
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private bool IsInViewport()
		{
			return false;
		}
	}
}
