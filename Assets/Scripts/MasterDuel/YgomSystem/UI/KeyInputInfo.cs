using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.UI
{
	public class KeyInputInfo
	{
		private Dictionary<SelectorManager.KeyType, SelectorManager.KeyStatus> keyStatus;

		private Dictionary<SelectorManager.AnalogType, Vector2> analogInput;

		private Dictionary<SelectorManager.MouseType, SelectorManager.KeyStatus> mouseStatus;

		private Vector2 screenPoint;

		private Vector2 screenPointDelta;

		private bool onScreen;

		private float padInputContinueTime;

		private SelectorManager.KeyType currentDirection;

		private SelectorManager.KeyType[] keyPrioriority;

		private SelectorManager.MouseType[] mousePriority;

		private SelectorManager.AnalogType[] analogPriority;

		public int onKeyCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float padInputRepeatStartTime => 0f;

		public static float padInputRepeatIntervalTime => 0f;

		public void Initialize()
		{
		}

		public void ResetInputInfo()
		{
		}

		public bool UpdatePadKeyInputInfo(GamePad pad)
		{
			return false;
		}

		private int UpdatePadKeyInputInfo(GamePad pad, SelectorManager.KeyType keyType, ref bool isReleased, ref bool isOnPush, ref bool isPushed, ref bool isOnRelease)
		{
			return 0;
		}

		public bool UpdateAnalogInput(GamePad pad)
		{
			return false;
		}

		public bool UpdatePadDirectionalInputInfo(GamePad pad)
		{
			return false;
		}

		private int GetGamePadKeyConfig(SelectorManager.KeyType keyType)
		{
			return 0;
		}

		public static (int, int) GetGamePadKeyConfig(SelectorManager.AnalogType analogType)
		{
			return default((int, int));
		}

		private KeyCode[] GetKeyboardKeyConfig(SelectorManager.KeyType keyType)
		{
			return null;
		}

		private static bool GetKey(GamePad pad, int gamepad_key_id, KeyCode[] key_code)
		{
			return false;
		}

		public bool UpdateBackkeyInputInfo(bool on_back_key)
		{
			return false;
		}

		private SelectorManager.KeyStatus UpdateKeyStatus(SelectorManager.KeyType key_type, bool on_key)
		{
			return default(SelectorManager.KeyStatus);
		}

		private bool UpdateAnalogInput(SelectorManager.AnalogType type, Vector2 input)
		{
			return false;
		}

		public bool UpdateMouseInputInfo(bool on_left, bool on_right, bool on_center, float wheel, Vector2 screenPoint, bool onScreen)
		{
			return false;
		}

		private bool UpdateMouseStatus(SelectorManager.MouseType mouse_type, bool on_key)
		{
			return false;
		}

		public SelectorManager.KeyStatus GetKeyStatus(SelectorManager.KeyType key_type)
		{
			return default(SelectorManager.KeyStatus);
		}

		public Vector2 GetAnalogInput(SelectorManager.AnalogType analog_type)
		{
			return default(Vector2);
		}

		public SelectorManager.KeyStatus GetMouseStatus(SelectorManager.MouseType mouse_type)
		{
			return default(SelectorManager.KeyStatus);
		}

		public (bool, Vector2, Vector2) GetScreenPoint()
		{
			return default((bool, Vector2, Vector2));
		}

		public SelectorManager.KeyType GetKeyType(SelectorManager.KeyStatus status)
		{
			return default(SelectorManager.KeyType);
		}

		public SelectorManager.MouseType GetMouseType(SelectorManager.KeyStatus status)
		{
			return default(SelectorManager.MouseType);
		}

		public SelectorManager.AnalogType GetAnalogType()
		{
			return default(SelectorManager.AnalogType);
		}
	}
}
