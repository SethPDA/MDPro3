using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public class SelectorManager : MonoBehaviour
	{
		public enum KeyType
		{
			None = 0,
			Accept = 1,
			Cancel = 2,
			Sub1 = 3,
			Sub2 = 4,
			Left1 = 5,
			Left2 = 6,
			Left3 = 7,
			Right1 = 8,
			Right2 = 9,
			Right3 = 10,
			Option1 = 11,
			Option2 = 12,
			DirectionUp = 13,
			DirectionDown = 14,
			DirectionLeft = 15,
			DirectionRight = 16,
			BackKey = 17,
			Any = 18
		}

		public enum AnalogType
		{
			None = 0,
			Main = 1,
			Sub = 2,
			Wheel = 3
		}

		public enum MouseType
		{
			None = 0,
			Main = 1,
			Sub1 = 2,
			Sub2 = 3
		}

		public enum KeyStatus
		{
			Released = 0,
			OnPush = 1,
			Pushed = 2,
			OnRelease = 3
		}

		public enum CombiKeyStatus
		{
			SubOffMainReleased = 0,
			SubOffMainOnPush = 1,
			SubOffMainPushed = 2,
			SubOffMainOnRelease = 3,
			SubOnMainReleased = 4,
			SubOnMainOnPush = 8,
			SubOnMainPushed = 16,
			SubOnMainOnRelease = 32
		}

		public enum KeyTypeMask
		{
			None = 0,
			Accept = 2,
			Cancel = 4,
			Sub1 = 8,
			Sub2 = 0x10,
			Left1 = 0x20,
			Left2 = 0x40,
			Left3 = 0x80,
			Right1 = 0x100,
			Right2 = 0x200,
			Right3 = 0x400,
			Option1 = 0x800,
			Option2 = 0x1000,
			DirectionUp = 0x2000,
			DirectionDown = 0x4000,
			DirectionLeft = 0x8000,
			DirectionRight = 0x10000,
			BackKey = 0x20000
		}

		public enum AnalogTypeFlag
		{
			None = 0,
			Main = 2,
			Sub = 4,
			Wheel = 8
		}

		public struct ScreenInputInfo
		{
			public bool onScreen;

			public Vector2 screenPoint;

			public bool pressMain;

			public bool pressSub1;

			public bool pressSub2;

			public bool IsChanged(ScreenInputInfo info)
			{
				return false;
			}
		}

		public enum InputDevice
		{
			PointingDevice = 0,
			GamePad = 1
		}

		public class ChangeDeviceEvent : UnityEvent<InputDevice>
		{
			public ChangeDeviceEvent()
			{
				//((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		private delegate bool ClusterFunc(SelectorCluster cluster);

		private static Dictionary<int, SelectorCluster> clusters;

		private static ClusterFunc selectCurrentItemCallback;

		private static ClusterFunc selectHighestPriorityItemCallback;

		private static ClusterFunc getCurrentItemCallback;

		private static ClusterFunc protectActivationClusterCallback;

		private static ClusterFunc activateClusterCallback;

		private static ClusterFunc resetCallbackManagerPriorityCallback;

		private static ClusterFunc setCallbackManagerPriorityCallback;

		private GamePad _pad;

		private KeyInputInfo _keyInputInfo;

		[SerializeField]
		private float _padInputRepeatStartTime;

		[SerializeField]
		private float _padInputRepeatIntervalTime;

		private ScreenInputInfo currentInputInfo;

		private ScreenInputInfo screenInputInfo;

		[SerializeField]
		private float _dragStartThreshold;

		[SerializeField]
		private float _flickThreshold;

		private Vector3 preMousePosition;

		private bool dragging;

		private bool dragSuccess;

		private float holdTime;

		private bool holding;

		private bool holdCheck;

		private Vector2 pressedPoint;

		private const float clickInterval = 0.2f;

		private float preClickedTime;

		private static bool screenInputUpdateRequest;

		private static Dictionary<int, int> inputBlockCounter;

		private static int highestInputBlockPriority;

		private static List<SelectionItem> provisionalRegistedItem;

		private static List<SelectionItem> provisionalSelectedItem;

		private static List<Selector> provisionalRegistedSelector;

		private SelectorCallbackManager callbackManager;

		public static SelectorManager instance;

		public static InputDevice defaultInputDevice;

		private static bool deviceLock;

		private static bool usePointingDeviceInput;

		private static bool useGamePadInput;

		private static int useKeyboardPadKeyBlockCounter;

		private static Dictionary<KeyType, int> gamePadButtonKeyConfig;

		private static Dictionary<AnalogType, int[]> gamePadAnalogKeyConfig;

		private static Dictionary<KeyType, KeyCode[]> keyboardButtonKeyConfig;

		private static Dictionary<MouseType, int> mouseKeyConfig;

		private KeyType currentOnPushKeyType;

		private KeyType currentPushedKeyType;

		private KeyType currentOnReleaseKeyType;

		private KeyType currentSubKeyType;

		private MouseType currentOnPushMouseType;

		private MouseType currentPushedMouseType;

		private MouseType currentOnReleaseMouseType;

		private AnalogType currentAnalogType;

		public static SelectorCluster currentCluster
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

		public static SelectionItem currentItem => null;

		private GamePad pad => null;

		private KeyInputInfo keyInputInfo => null;

		public static float padInputRepeatStartTime => 0f;

		public static float padInputRepeatIntervalTime => 0f;

		public static float dragStartThreshold => 0f;

		public static float flickThreshold => 0f;

		public static float dragDistance => 0f;

		public SelectionItem pressedItem
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

		public SelectionItem draggingItem
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

		public SelectionItem holdingItem
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

		public SelectionItem currentPointedItem
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

		public SelectionItem preClickedItem
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

		public static Vector2 flickSpeed
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int padInputBlocker
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

		public int mouseButtonInputBlocker
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

		public static Dictionary<KeyType, int> noCountKeyInput
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

		public static bool acceptKeyboadInput
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool anyInput => false;

		public static bool pointingInput
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

		public static bool padInputDirection
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

		public static bool padInputKey
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

		public static bool padInputAnalog
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

		public static InputDevice currentInputDevice
		{
			[CompilerGenerated]
			get
			{
				return default(InputDevice);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static ChangeDeviceEvent onDeviceChangeEvent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int deviceLockCounter
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

		public static Action onBackKeyNoActionCallback
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private static bool useKeyboardPadKey => false;

		public static KeyType onPushKeyType => default(KeyType);

		public static KeyType pushedKeyType => default(KeyType);

		public static KeyType onReleaseKeyType => default(KeyType);

		public static KeyType subKeyType => default(KeyType);

		public static MouseType onPushMouseType => default(MouseType);

		public static MouseType pushedMouseType => default(MouseType);

		public static MouseType onReleaseMouseType => default(MouseType);

		public static AnalogType analogType => default(AnalogType);

		public static bool isGamePadInput => false;

		public static bool isPointingInput => false;

		private static SelectionItem GetCurrentItem()
		{
			return null;
		}

		private static SelectorCluster GetCluster(int priority)
		{
			return null;
		}

		public static SelectorCluster GetCluster(SelectorGroup group)
		{
			return null;
		}

		public static int GetGroupPriority(SelectorGroup group)
		{
			return 0;
		}

		private void Awake()
		{
		}

		public static SelectorManager Create(string name, Transform parent)
		{
			return null;
		}

		private static void CreateInstance()
		{
		}

		public static SelectorGroup AddSelector(string group_label, Selector selector, int new_group_priority, out bool is_new_group)
		{
			is_new_group = default(bool);
			return null;
		}

		public static void RemoveSelector(string group_label, Selector selector)
		{
		}

		public static void ActivateClusterHighestPriority()
		{
		}

		private void SetCallbackManagerClusterPriority()
		{
		}

		public static (int, SelectorCluster) GetHighestPriorityCluster(int maxPriority = -1)
		{
			return default((int, SelectorCluster));
		}

		public static void ChangeGroupPriority(SelectorGroup group, int priority)
		{
		}

		public static void DeselectItemActiveCluster()
		{
		}

		public static void DeselectItemActiveCluster(SelectorCluster targetCluster)
		{
		}

		public static SelectorCluster GetHigherActiveCluster(SelectorCluster targetCluster)
		{
			return null;
		}

		public static SelectorCluster GetHigherCluster(SelectorCluster targetCluster)
		{
			return null;
		}

		private void Update()
		{
		}

		private void UpdateInputInfo()
		{
		}

		private void UpdateCurrentKeyInfo()
		{
		}

		private void ChangeInputDevice(InputDevice inputDevice)
		{
		}

		public static void LockDeviceChange()
		{
		}

		public static void UnlockDeviceChange()
		{
		}

		private void UpdateDirectionInput(SelectorCluster target_cluster)
		{
		}

		public static bool ChangeSelectionItem(Vector2 position, Vector2 normalized_direction, SelectionItem baseItem)
		{
			return false;
		}

		private void UpdateScreenInput(ScreenInputInfo current, SelectorCluster rootCluster, bool blockClick)
		{
		}

		private void UpdateScreenInput(SelectorCluster target_cluster, bool blockClick, bool reset)
		{
		}

		public static void RequestScreenInputUpdate()
		{
		}

		private bool GetScreenInputInfo(ref ScreenInputInfo res)
		{
			return false;
		}

		private bool GetScreenInputInfoTouch(ref ScreenInputInfo res)
		{
			return false;
		}

		private bool GetScreenInputInfoMouse(ref ScreenInputInfo res)
		{
			return false;
		}

		private bool IsOnScreen(Vector2 point)
		{
			return false;
		}

		public static KeyStatus GetKeyStatus(KeyType key_type)
		{
			return default(KeyStatus);
		}

		public static CombiKeyStatus GetKeyStatus(KeyType key_type_main, KeyType key_type_sub)
		{
			return default(CombiKeyStatus);
		}

		public static bool GetKeyStatusFlag(KeyStatus keyStatus, ref bool isReleased, ref bool isOnPush, ref bool isPushed, ref bool isOnRelease)
		{
			return false;
		}

		public static Vector2 GetAnalogInput(AnalogType analog_type)
		{
			return default(Vector2);
		}

		public static KeyStatus GetMouseStatus(MouseType mouse_type)
		{
			return default(KeyStatus);
		}

		public static void BlockInput(int block_priority)
		{
		}

		public static void DeblockInput(int block_priority)
		{
		}

		public static void ClearInputBlockCounter()
		{
		}

		public static void Reboot()
		{
		}

		private static void UpdateHighestInputBlockPriority()
		{
		}

		public void BlockPadInput()
		{
		}

		public void DeblockPadInput()
		{
		}

		public static bool IsPadInputBlocked()
		{
			return false;
		}

		public void BlockMouseButtonInput()
		{
		}

		public void DeblockMouseButtonInput()
		{
		}

		public static bool IsMouseButtonInputBlocked()
		{
			return false;
		}

		public static void SetNoCountKeyInput(KeyType keyType, bool regist)
		{
		}

		public static bool IsNoCountKeyInput(KeyType keyType)
		{
			return false;
		}

		public static SelectionItem GetItem(Vector2 view_position)
		{
			return null;
		}

		public static SelectionItem GetItem(Vector2 view_position, int cluster_priority)
		{
			return null;
		}

		public static void AddProvisionalRegistedItem(SelectionItem item)
		{
		}

		public static void RegistAllProvisionalRegistedItem()
		{
		}

		public static void AddProvisionalSelectedItem(SelectionItem item)
		{
		}

		public static void SelectAllProvisionalSelectedItem()
		{
		}

		public static void AddProvisionalRegistedSelector(Selector selector)
		{
		}

		public static void RegistAllProvisionalRegistedSelector()
		{
		}

		public static int GetGamePadKeyConfig(KeyType key_type)
		{
			return 0;
		}

		public static (int, int) GetGamePadKeyConfig(AnalogType analog_type)
		{
			return default((int, int));
		}

		public static KeyCode[] GetKeyboardKeyConfig(KeyType key_type)
		{
			return null;
		}

		public static void BlockKeyboardPadKey(bool block)
		{
		}

		public static int[] GetGamePadAnalogKeyConfig(AnalogType analog_type)
		{
			return null;
		}

		public static int GetMouseKeyConfig(MouseType mouse_type)
		{
			return 0;
		}

		public static Vector2 GetCurrentScreenPoint()
		{
			return default(Vector2);
		}

		public static bool IsScreenInputActive()
		{
			return false;
		}

		public static void AddClusterGoThroughCounter(int clusterPriority)
		{
		}

		public static void RemoveClusterGoThroughCounter(int clusterPriority)
		{
		}

		private static SelectorCluster ActionForHighestPriorityCluster(ClusterFunc callback)
		{
			return null;
		}

		public static KeyType ButtonTypeToKeyType(int buttonType)
		{
			return default(KeyType);
		}

		public static uint AddSelectedCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
		{
			return 0u;
		}

		public static List<uint> RemoveSelectedCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
		{
			return null;
		}

		public static List<uint> RemoveSelectedCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog)
		{
			return null;
		}

		public static List<uint> ClearSelectedCallback(SelectionItem item)
		{
			return null;
		}

		public static List<uint> RemoveCallback(uint id)
		{
			return null;
		}

		public static uint AddShortcutCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
		{
			return 0u;
		}

		public static List<uint> RemoveShortcutCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
		{
			return null;
		}

		public static List<uint> RemoveShortcutCallback(SelectionItem item, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog)
		{
			return null;
		}

		public static List<uint> ClearShortcutCallback(SelectionItem item)
		{
			return null;
		}

		public static uint AddShortcutCallback(int priority, KeyStatus status, KeyType main, KeyType sub, MouseType mouse, AnalogType analog, Func<bool> callback)
		{
			return 0u;
		}
	}
}
