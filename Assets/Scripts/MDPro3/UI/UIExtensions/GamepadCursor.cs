using UnityEngine;
using UnityEngine.InputSystem;

namespace MDPro3.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class GamepadCursor : MonoBehaviour
    {
        private bool _show = true;
        public bool Show
        {
            get { return _show; }
            set 
            {
                _show = value;
                OnControlDeviceChange(UserInput.PlayerInput.currentControlScheme);
            }
        }

        private void OnEnable()
        {
            UserInput.OnControlDeviceChange += OnControlDeviceChange;
            OnControlDeviceChange(UserInput.PlayerInput.currentControlScheme);
        }

        private void OnDisable()
        {
            UserInput.OnControlDeviceChange -= OnControlDeviceChange;
        }

        private void OnControlDeviceChange(string scheme)
        {
            if (scheme == UserInput.GamepadSchemeName && Show)
                GetComponent<CanvasGroup>().alpha = 1f;
            else
                GetComponent<CanvasGroup>().alpha = 0f;
        }
    }
}
