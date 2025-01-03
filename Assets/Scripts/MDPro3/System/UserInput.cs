using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

#if !UNITY_ANDROID || UNITY_EDITOR
using UnityEngine.InputSystem.Switch;
using UnityEngine.InputSystem.UI;
#endif

namespace MDPro3
{
    public class UserInput : MonoBehaviour
    {
        public static UserInput instance;
        public static PlayerInput PlayerInput;
        public static string KeyboardSchemeName = "Keyboard&Mouse";
        public static string GamepadSchemeName = "Gamepad";
        public static bool NextSelectionIsAxis;
        public static GameObject HoverObject;

        public static bool draging;

        public enum GamepadType
        {
            None,
            Xbox,
            PlayStation,
            Nintendo
        }
        public static GamepadType gamepadType = GamepadType.None;

        public static Vector2 MoveInput;
        public static Vector2 MousePos;
        public static Vector2 LeftScrollWheel;
        public static Vector2 RightScrollWheel;

        public static bool WasCancelPressed;
        public static bool WasSubmitPressed;
        public static bool WasLeftPressed;
        public static bool WasRightPressed;
        public static bool WasUpPressed;
        public static bool WasDownPressed;
        public static bool WasGamepadButtonWestPressed;
        public static bool WasGamepadButtonNorthPressed;
        public static bool WasLeftStickPressed;
        public static bool WasRightStickPressed;
        public static bool WasLeftShoulderPressed;
        public static bool WasRightShoulderPressed;
        public static bool WasLeftShoulderPressing;
        public static bool WasRightShoulderPressing;
        public static bool WasLeftTriggerPressed;
        public static bool WasRightTriggerPressed;

        public static bool MouseLeftDown;
        public static bool MouseRightDown;
        public static bool MouseMiddleDown;
        public static bool MouseLeftPressing;
        public static bool MouseRightPressing;
        public static bool MouseMiddlePressing;
        public static bool MouseLeftUp;
        public static bool MouseRightUp;
        public static bool MouseMiddleUp;

        public delegate void MouseMoveAction();
        public static event MouseMoveAction OnMouseMovedAction;

        public delegate void ControlDeviceChange(string scheme);
        public static event ControlDeviceChange OnControlDeviceChange;

        public delegate void MouseCursorHide();
        public static event MouseCursorHide OnMouseCursorHide;

        private InputAction moveAction;
        private InputAction cancelAction;
        private InputAction submitAction;
        private InputAction mouseAction;
        private InputAction leftClickAction;
        private InputAction rightClickAction;
        private InputAction middleClickAction;
        private InputAction leftScrollAction;
        private InputAction rightScrollAction;
        private InputAction gamepadButtonWestAction;
        private InputAction gamepadButtonNorthAction;
        private InputAction leftStickAction;
        private InputAction rightStickAction;
        private InputAction leftShoulderAction;
        private InputAction rightShoulderAction;
        private InputAction leftTriggerAction;
        private InputAction rightTriggerAction;

        private Vector2 lastMousePos;

        private Gamepad pad;
        private Coroutine stopRumbleAfterTimeCoroutine;
        public static string gamePadName;

        private float leftPressingTime;
        private float rightPressingTime;
        private float upPressingTime;
        private float downPressingTime;
        private const float moveRepeatDelay = 0.4f;
        private const float moveRepeatRate = 0.2f;

        private void Awake()
        {
            instance = this;
            PlayerInput = GetComponent<PlayerInput>();
            PlayerInput.onControlsChanged += OnControlsChanged;

            moveAction = PlayerInput.actions["Navigate"];
            cancelAction = PlayerInput.actions["Cancel"];
            submitAction = PlayerInput.actions["Submit"];
            mouseAction = PlayerInput.actions["MousePos"];
            leftClickAction = PlayerInput.actions["Click"];
            rightClickAction = PlayerInput.actions["RightClick"];
            middleClickAction = PlayerInput.actions["MiddleClick"];
            leftScrollAction = PlayerInput.actions["LeftScrollWheel"];
            rightScrollAction = PlayerInput.actions["RightScrollWheel"];

            gamepadButtonWestAction = PlayerInput.actions["GamepadButtonWest"];
            gamepadButtonNorthAction = PlayerInput.actions["GamepadButtonNorth"];
            leftStickAction = PlayerInput.actions["LeftStickPress"];
            rightStickAction = PlayerInput.actions["RightStickPress"];
            leftShoulderAction = PlayerInput.actions["LeftShoulderPress"];
            rightShoulderAction = PlayerInput.actions["RightShoulderPress"];
            leftTriggerAction = PlayerInput.actions["LeftTriggerPress"];
            rightTriggerAction = PlayerInput.actions["RightTriggerPress"];

            OnMouseMovedAction += ShowCursor;
        }

        private void Update()
        {
            MoveInput = moveAction.ReadValue<Vector2>();
            MousePos = mouseAction.ReadValue<Vector2>();
            LeftScrollWheel = leftScrollAction.ReadValue<Vector2>();
            RightScrollWheel = rightScrollAction.ReadValue<Vector2>();

            if (MousePos != lastMousePos)
            {
                MouseMovedEvent();
            }

            if(MoveInput != Vector2.zero)
            {
                if (Cursor.lockState == CursorLockMode.None)
                {
                    HideCursor();
                }
            }

            WasCancelPressed = cancelAction.WasPressedThisFrame();

            WasSubmitPressed = submitAction.WasPressedThisFrame();
            WasGamepadButtonWestPressed = gamepadButtonWestAction.WasPressedThisFrame();
            WasGamepadButtonNorthPressed = gamepadButtonNorthAction.WasPressedThisFrame();
            WasLeftStickPressed = leftStickAction.WasPressedThisFrame();
            WasRightStickPressed = rightStickAction.WasPressedThisFrame();
            WasLeftShoulderPressed = leftShoulderAction.WasPressedThisFrame();
            WasRightShoulderPressed = rightShoulderAction.WasPressedThisFrame();
            WasLeftShoulderPressing = leftShoulderAction.IsPressed();
            WasRightShoulderPressing = rightShoulderAction.IsPressed();
            WasLeftTriggerPressed = leftTriggerAction.WasPressedThisFrame();
            WasRightTriggerPressed = rightTriggerAction.WasPressedThisFrame();

            #region Mouse
            MouseLeftDown = leftClickAction.WasPressedThisFrame();
            MouseRightDown = rightClickAction.WasPressedThisFrame();
            MouseMiddleDown = middleClickAction.WasPressedThisFrame();
            MouseLeftPressing = leftClickAction.IsPressed();
            MouseMiddlePressing = middleClickAction.IsPressed();
            MouseRightPressing = rightClickAction.IsPressed();
            MouseLeftUp = leftClickAction.WasReleasedThisFrame();
            MouseRightUp = rightClickAction.WasReleasedThisFrame();
            MouseMiddleUp = middleClickAction.WasReleasedThisFrame();

            lastMousePos = MousePos;
            #endregion

            #region Navigation
            if (MoveInput.x > 0f)
            {
                if(rightPressingTime == 0f)
                    WasRightPressed = true;
                else
                    WasRightPressed = false;

                rightPressingTime += Time.unscaledDeltaTime;
            }
            else
            {
                rightPressingTime = 0f;
                WasRightPressed = false;
            }
            if (rightPressingTime > 0f && !WasRightPressed)
            {
                if(rightPressingTime > moveRepeatDelay)
                {
                    var overDelay = rightPressingTime - moveRepeatDelay;
                    if(overDelay > moveRepeatRate)
                    {
                        WasRightPressed = true;
                        rightPressingTime -= moveRepeatRate;
                    }
                }
            }

            if (MoveInput.x < 0f)
            {
                if (leftPressingTime == 0f)
                    WasLeftPressed = true;
                else
                    WasLeftPressed = false;

                leftPressingTime += Time.unscaledDeltaTime;
            }
            else
            {
                leftPressingTime = 0f;
                WasLeftPressed = false;
            }
            if (leftPressingTime > 0f && !WasLeftPressed)
            {
                if (leftPressingTime > moveRepeatDelay)
                {
                    var overDelay = leftPressingTime - moveRepeatDelay;
                    if (overDelay > moveRepeatRate)
                    {
                        WasLeftPressed = true;
                        leftPressingTime -= moveRepeatRate;
                    }
                }
            }

            if (MoveInput.y > 0f)
            {
                if (upPressingTime == 0f)
                    WasUpPressed = true;
                else
                    WasUpPressed = false;

                upPressingTime += Time.unscaledDeltaTime;
            }
            else
            {
                upPressingTime = 0f;
                WasUpPressed = false;
            }
            if (upPressingTime > 0f && !WasUpPressed)
            {
                if (upPressingTime > moveRepeatDelay)
                {
                    var overDelay = upPressingTime - moveRepeatDelay;
                    if (overDelay > moveRepeatRate)
                    {
                        WasUpPressed = true;
                        upPressingTime -= moveRepeatRate;
                    }
                }
            }

            if (MoveInput.y < 0f)
            {
                if (downPressingTime == 0f)
                    WasDownPressed = true;
                else
                    WasDownPressed = false;

                downPressingTime += Time.unscaledDeltaTime;
            }
            else
            {
                downPressingTime = 0f;
                WasDownPressed = false;
            }
            if (downPressingTime > 0f && !WasDownPressed)
            {
                if (downPressingTime > moveRepeatDelay)
                {
                    var overDelay = downPressingTime - moveRepeatDelay;
                    if (overDelay > moveRepeatRate)
                    {
                        WasDownPressed = true;
                        downPressingTime -= moveRepeatRate;
                    }
                }
            }
            #endregion

            #region Hover Object
            HoverObject = null;
            if (Program.instance.camera_.cameraMain.gameObject.activeInHierarchy
                && !EventSystem.current.IsPointerOverGameObject())
            {
                Ray ray = Program.instance.camera_.cameraMain.ScreenPointToRay(MousePos);
                if (Physics.Raycast(ray, out var hit))
                    HoverObject = hit.collider.gameObject;
            }
            #endregion
        }

        private void MouseMovedEvent()
        {
            if(PlayerInput.currentControlScheme != GamepadSchemeName)
                OnMouseMovedAction?.Invoke();
        }

        private void OnControlsChanged(PlayerInput input)
        {
            StartCoroutine(OnControlsChangedAsync(input));
        }

        IEnumerator OnControlsChangedAsync(PlayerInput input)
        {
            yield return null;
            gamepadType = GamepadType.None;
            if (PlayerInput.currentControlScheme == GamepadSchemeName)
            {
                gamepadType = GamepadType.Xbox;

                if (Gamepad.current is DualShockGamepad)
                    gamepadType = GamepadType.PlayStation;
#if !UNITY_ANDROID || UNITY_EDITOR
                else if (Gamepad.current is SwitchProControllerHID)
                    gamepadType = GamepadType.Nintendo;
#endif
            }
            OnControlDeviceChange?.Invoke(input.currentControlScheme);
        }

        public static bool NeedDefaultSelect()
        {
            if (PlayerInput.currentControlScheme == GamepadSchemeName)
                return true;
            else if (Cursor.lockState == CursorLockMode.Locked)
                return true;

            return false;
        }

        public static void SetMoveRepeatRate(float rate)
        {
            var module = instance.GetComponent<InputSystemUIInputModule>();
            module.moveRepeatRate = rate;
        }

        #region Rumble
        public void Rumble(float lowFrequency, float highFrequence, float duration)
        {
            if (!Config.GetBool("Rumble", true))
                return;
            if (PlayerInput.currentControlScheme != GamepadSchemeName)
                return;

            pad = Gamepad.current;
            if (pad == null)
                return;

            Gamepad.current.SetMotorSpeeds(lowFrequency, highFrequence);
            if(stopRumbleAfterTimeCoroutine != null)
                StopCoroutine(stopRumbleAfterTimeCoroutine);
            stopRumbleAfterTimeCoroutine = StartCoroutine(StopRumble(duration, pad));
        }

        private IEnumerator StopRumble(float duration, Gamepad pad)
        {
            float elapsedTime = 0f;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.unscaledDeltaTime;
                yield return null;
            }

            pad?.SetMotorSpeeds(0f, 0f);
            stopRumbleAfterTimeCoroutine = null;
        }

        public static void RumbleForUp()
        {
            instance.Rumble(0.1f, 1f, 0.1f);
        }
        public static void RumbleForDown()
        {
            instance.Rumble(1f, 0.1f, 0.1f);
        }

        #endregion

        #region CursorVisibility
        private bool ignoreNextCursorMove;
        private void ShowCursor()
        {
            if (ignoreNextCursorMove)
            {
                ignoreNextCursorMove = false;
                return;
            }

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        private void HideCursor()
        {
            ignoreNextCursorMove = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            OnMouseCursorHide?.Invoke();
        }
        #endregion
    }
}
