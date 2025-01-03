using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public class UiSwitchTweenAnimationController : MonoBehaviour
	{
		public bool activeControl;

		public string labelShow;

		public string labelShow_Event;

		public string labelHide;

		public string labelHide_Event;

		public string labelChain;

		public string labelChain_Event;

		public event UnityAction onShow
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

		public event UnityAction onHide
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

		public event UnityAction<int> onChain
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

		private void OnEnable()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void Chain()
		{
		}

		private void OnShow()
		{
		}

		private void OnHide()
		{
		}

		private void OnChain(int index)
		{
		}

		private void RegistChainTween(bool isEventTween)
		{
		}

		private void StopAllTween()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
