using UnityEngine;

namespace MDPro3.UI
{
    public class DeviceIcon : MonoBehaviour
    {
        public enum InputDevice
        {
            PointingDevice = 0,
            GamePad = 1
        }
        public InputDevice displayInputDevice;

        public enum DispType
        {
            Graphic = 0,
            GameObject = 1
        }
        public DispType dispTarget;

        private void Awake()
        {
            UserInput.OnControlDeviceChange += OnControlDeviceChange;
            OnControlDeviceChange(UserInput.PlayerInput.currentControlScheme);
        }

        private void OnDestroy()
        {
            UserInput.OnControlDeviceChange -= OnControlDeviceChange;
        }

        private void OnControlDeviceChange(string scheme)
        {
            if(displayInputDevice == InputDevice.GamePad)
            {
                if (scheme == UserInput.GamepadSchemeName)
                    Show();
                else
                    Hide();
            }
            else
            {
                if (scheme == UserInput.GamepadSchemeName)
                    Hide();
                else
                    Show();
            }
        }

        private void Show()
        {
            if (dispTarget == DispType.Graphic)
            {
                var cg = GetComponent<CanvasGroup>();
                cg.alpha = 1f;
                cg.blocksRaycasts = true;
            }
            else
            {
                gameObject.SetActive(true);
            }
        }

        private void Hide()
        {
            if (dispTarget == DispType.Graphic)
            {
                var cg = GetComponent<CanvasGroup>();
                cg.alpha = 0f;
                cg.blocksRaycasts = false;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}