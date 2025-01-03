using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class ActionSheetViewController : SelectDialogViewControllerBase<string, ActionSheetViewController.EntryData[], int>, IBokeSupported
	{
		public enum ButtonStyle
		{
			Positive = 0,
			Destructive = 1,
			Disable = 2,
			Toggle = 3
		}

		[Serializable]
		public class EntryData
		{
			public string text;

			public ButtonStyle buttonStyle;

			public bool interactable;

			public string overrideSeClick;

			public bool active;

			public string label;

			public bool useCheckBox;

			public bool isOn;

			public string imagePath;

			public bool badge;

			public EntryData()
			{
			}

			public EntryData(string text)
			{
			}

			public EntryData(string text, ButtonStyle buttonStyle)
			{
			}

			public EntryData(string text, ButtonStyle buttonStyle, string overrideSeClick)
			{
			}

			public EntryData(string text, bool interactable, ButtonStyle buttonStyle)
			{
			}

			public EntryData(string text, bool interactable = true, ButtonStyle buttonStyle = ButtonStyle.Positive, string overrideSeClick = null, bool active = true, string label = null, bool useCheckBox = false, bool isOn = false, string imagePath = null, bool badge = false)
			{
			}

			public static EntryData[] CreateEntrys(IReadOnlyList<string> entrys, int destructiveLength = 0)
			{
				return null;
			}
		}

		public class EntryButtonsScrollWidget : ElementWidgetBase
		{
			public readonly InfinityScrollView scrollView;

			//public readonly ScrollRect scrollRect;

			//public readonly LayoutElement layoutElement;

			//public readonly LayoutGroup contentLayoutGroup;

			public EntryButtonsScrollWidget(ElementObjectManager eom)
				: base(null)
			{
			}
		}

		public class EntryButtonWidget : ElementWidgetBase
		{
			public readonly string k_ELabelText;

			public readonly string k_ELabelToggle;

			public readonly string k_ELabelImage;

			public readonly string k_ELabelBadge;

			public readonly SelectionButton button;

			public readonly TMP_Text text;

			//public readonly Toggle toggle;

			//public readonly Image image;

			public readonly GameObject badge;

			public readonly string defaultSoundLabelClick;

			public Action<EntryButtonWidget> onClickCallback;

			public EntryButtonWidget(ElementObjectManager eom)
				: base(null)
			{
			}

			private void OnClick()
			{
			}
		}

		public class EntryButtonWidgetToggle : EntryButtonWidget
		{
			public readonly string k_ELabelImageOff;

			public readonly string k_ELabelImageOn;

			public readonly string k_ELabelOff;

			public readonly string k_ELabelOn;

			public readonly string k_ELabelTextOff;

			public readonly string k_ELabelTextOn;

			public readonly string k_ELabelToggleOff;

			public readonly string k_ELabelToggleOn;

			private readonly string k_SEToggleOn;

			private readonly string k_SEToggleOff;

			public EntryButtonWidgetToggle(ElementObjectManager eom)
				: base(null)
			{
			}

			public void OnUpdate(EntryData entryData)
			{
			}
		}

		private const string k_PrefPath = "Common/ActionSheet/ActionSheet";

		private const string k_ArgKeyMessage = "message";

		private const string k_ArgKeyEmbedObject = "embedObject";

		public const string k_ArgKeyOnCancel = "onCancelCallback";

		private const string k_ArgKeyCustomButtonMap = "customButtonMap";

		private const string k_ArgKeyCustomOnCreateButtonCallback = "customOnCreateButtonCallback";

		private const string k_ArgKeyCustomOnUpdateButtonCallback = "customOnUpdateButtonCallback";

		private const string k_ArgKeyAdditionalFooterOnClick = "additionalFooterOnClick";

		private const string k_ArgKeyAdditionalFooterText = "additionalFooterText";

		private const string k_ArgKeyOffCloseButton = "offCloseButton";

		private readonly string k_ELabelCloseButton;

		private readonly string k_ELabelTitleText;

		private readonly string k_ELabelMessageArea;

		private readonly string k_ELabelEmbedObjectArea;

		private readonly string k_ELabelEntryButtonsScrollView;

		private readonly string k_ELabelCancelButton;

		private readonly string k_ELabelText;

		private readonly string k_ELabelShortcutIcon;

		private readonly string k_SEFooterDecide;

		private EntryButtonsScrollWidget m_EntryButtonsScrollWidget;

		private Dictionary<GameObject, EntryButtonWidget> m_EntryButtonWidgetMap;

		private List<EntryData> m_EntryButtonDatas;

		private List<EntryData> m_DisplayEntryButtonDatas;

		private List<int> m_EntryButtonTemplateIdxs;

		private Action<ButtonStyle, EntryButtonWidget> m_CustomOnCreateCallback;

		private Action<ButtonStyle, EntryButtonWidget, EntryData, int> m_CustomOnUpdateButtonCallback;

		protected override int selectorPriorityAddRange => 0;

		protected override EntryData[] arg2 => null;

		protected override Action<int> arg3 => null;

		public GameObject embedObject => null;

		public static void Open(string title, IReadOnlyList<string> entrys)
		{
		}

		public static void Open(string title, IReadOnlyList<string> entrys, Action<int> callback)
		{
		}

		public static void Open(string title, IReadOnlyList<string> entrys, Action<int> callback, Action onCancel)
		{
		}

		public static void Open(string title, IReadOnlyList<string> entrys, int destructiveLength = 0, Action<int> callback = null, Action onCancel = null)
		{
		}

		public static void Open(string title, EntryData[] entrys, Action<int> callback = null, Action onCancel = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenCustomSheet(string title, EntryData[] entrys, Dictionary<ButtonStyle, GameObject> customButtonMap, Action<ButtonStyle, EntryButtonWidget> customOnCreateCallback, Action<ButtonStyle, EntryButtonWidget, EntryData, int> customOnUpdateButtonCallback, Action<int> callback = null, Action onCancel = null, string message = null, GameObject embedObject = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenCustomToggleGroup(string title, EntryData[] entrys, string additionalFooterText, Action<bool[]> callback = null, Action onCancel = null, string message = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenMessage(string title, string message, IReadOnlyList<string> entrys, Action<int> callback = null, Action onCancel = null)
		{
		}

		public static void OpenMessage(string title, string message, IReadOnlyList<string> entrys, int destructiveLength = 0, Action<int> callback = null, Action onCancel = null)
		{
		}

		public static void OpenMessage(string title, string message, EntryData[] entrys, Action<int> callback = null, Action onCancel = null)
		{
		}

		public static void OpenWithEmbedObject(string title, GameObject embedObject, IReadOnlyList<string> entrys, int destructiveLength = 0, Action<int> callback = null, Action onCancel = null)
		{
		}

		public static void OpenWithEmbedObject(string title, GameObject embedObject, EntryData[] entrys, Action<int> callback = null, Action onCancel = null, Dictionary<string, object> args = null)
		{
		}

		public static bool TryGetLaunchedInstance(out ActionSheetViewController instance)
		{
			instance = null;
			return false;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public EntryData GetEntry(string label)
		{
			return null;
		}

		public void UpdateEntries()
		{
		}

		private void OnCreateButtonEntity(GameObject buttonEntity)
		{
		}

		private void OnUpdateButtonEntity(GameObject buttonEntity, int idx)
		{
		}

		private bool CustomButtonEntityInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return false;
		}

		private void OnClickButtonEntity(EntryButtonWidget buttonWidget)
		{
		}

		private void OnCancel()
		{
		}

		public ActionSheetViewController()
		{
			//((SelectDialogViewControllerBase<, , >)(object)this)._002Ector();
		}
	}
}
