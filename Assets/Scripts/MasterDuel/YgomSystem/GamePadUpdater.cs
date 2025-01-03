using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem
{
	public class GamePadUpdater : MonoBehaviour
	{
		private UnityEvent m_updateEvent;

		private static bool s_applicationFocused;

		public static bool ApplicationFocused => false;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void RegisterUpdateEvent(UnityAction onUpdate)
		{
		}

		public void UnregisterUpdateEvent(UnityAction onUpdate)
		{
		}

		private void OnApplicationFocus(bool focusStatus)
		{
		}
	}
}
