using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public class DeviceIcon : MonoBehaviour
	{
		public enum DispType
		{
			Graphic = 0,
			GameObject = 1
		}

		private UnityAction<SelectorManager.InputDevice> changeDeviceAction;

		public SelectorManager.InputDevice displayInputDevice;

		public bool alwaysShowOnConsole;

		public DispType dispTarget;

		protected bool isDisp;

		protected bool setup;

		protected bool _isActivate;

		public UnityEvent onChanged
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isActivate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Setup()
		{
		}

		protected virtual void UpdateDisplay(Action onCompleted = null)
		{
		}

		public void SetDisp(bool disp)
		{
		}
	}
}
