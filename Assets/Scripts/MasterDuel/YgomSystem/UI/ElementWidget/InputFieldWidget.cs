using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.LocalizedFont;

namespace YgomSystem.UI.ElementWidget
{
	public class InputFieldWidget : ElementWidgetBehaviourBase<InputFieldWidget>, ILocalizedFontOwner
	{
		private const string k_ELabelInputField = "InputField";

		private const string k_ELabelTMPInputField = "InputFieldTMP";

		private const string k_ELabelInputButton = "InputButton";

		private const string k_ELabelClearButton = "ClearButton";

		private const string k_ELabelClearButtonRoot = "ClearButtonRoot";

		private const string k_ELabelEditingCover = "EditingCover";

		private const string k_ELabelEditingMask = "Mask";

		private const string k_ELabelShortcutIconGroup = "ShortcutIconGroup";

		private const string k_ELabelInactiveButtonRoot = "InactivateButtonRoot";

		private const string k_ELabelInactiveButton = "InactivateButton";

		private const string k_TweenToEditOn = "ToEditOn";

		private const string k_TweenToEditOff = "ToEditOff";

		private InputFieldWrapper inputFieldWrapper;

		private ExtendedInputField m_InputFieldCache;

		private TMP_InputField m_TMPInputFieldCache;

		private SelectionButton m_InputButtonCache;

		private Button m_ClearButtonCache;

		private GameObject m_EditingCoverCache;

		private RectTransform m_MaskCache;

		private DeviceIcon m_ClearButtonRootCache;

		private DeviceIcon m_ShortcutIconGroup;

		private Selector m_InactivateButtonSelectorCache;

		private SelectionButton m_InactivateButtonCache;

		private bool m_IsEditEndFrame;

		private bool m_requestSubmit;

		private bool m_inputFieldActivated;

		[SerializeField]
		private bool _submitOnClickOuter;

		[SerializeField]
		public TMP_FontAsset fontAsset;

		[SerializeField]
		private LocalizedFontSettingsBase.FontType m_localizedFontType;

		[SerializeField]
		private int m_localizedFontMaterialIndex;

		public readonly InputField.SubmitEvent onSubmitEdit;

		public readonly InputField.OnChangeEvent onFilterdValueChanged;

		public readonly UnityEvent onBeginEdit;

		public readonly UnityEvent onEndEdit;

		private bool useTMP => false;

		public bool interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool submitOnClickOuter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LocalizedFontSettingsBase.FontType localizedFontType
		{
			get
			{
				return default(LocalizedFontSettingsBase.FontType);
			}
			set
			{
			}
		}

		public int localizedFontMaterialIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public InputFieldWrapper inputField => null;

		private ExtendedInputField uInputField => null;

		private TMP_InputField TMPInputField => null;

		public SelectionButton inputButton => null;

		public GameObject editingCover => null;

		public Button clearButton => null;

		public RectTransform mask => null;

		public DeviceIcon clearButtonRoot => null;

		public DeviceIcon shortcutIconGroup => null;

		public Selector inactivateButtonSelector => null;

		public SelectionButton inactivateButton => null;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnClick()
		{
		}

		private void OnClickClear()
		{
		}

		private void OnValueChanged(string input)
		{
		}

		private void OnEndEdit(string res)
		{
		}

		public void ActivateInputField()
		{
		}

		public void InactivateInputField()
		{
		}

		private void UpdateClearButton()
		{
		}

		private void ResizeClearButtonWidth()
		{
		}

		private void PlayToEditOn()
		{
		}

		private void PlayToEditOff()
		{
		}

		public void SetText(string text)
		{
		}

		public InputFieldWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
