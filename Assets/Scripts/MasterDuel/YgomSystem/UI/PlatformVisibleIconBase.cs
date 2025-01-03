using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public abstract class PlatformVisibleIconBase : MonoBehaviour
	{
		public enum DispType
		{
			Graphic = 0,
			GameObject = 1
		}

		public DispType dispTarget;

		private UnityAction<SelectorManager.InputDevice> changeDeviceAction;

		protected bool isDisp;

		protected bool setup;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Setup()
		{
		}

		protected abstract bool IsDispPlatform();

		private void UpdateDisplay()
		{
		}

		private void SetDisp(bool disp)
		{
		}
	}
}
