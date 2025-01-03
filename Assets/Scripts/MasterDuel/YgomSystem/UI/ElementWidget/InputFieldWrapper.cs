using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomSystem.UI.ElementWidget
{
	public class InputFieldWrapper
	{
		private enum Mode
		{
			uGUI = 0,
			TMP = 1
		}

		public class OnChangedEvent : UnityEvent<string>
		{
			public OnChangedEvent()
			{
				//((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		private Mode mode;

		private ExtendedInputField inputField;

		private TMP_InputField TMPInputField;

		public TextWrapper textComponent
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

		private Selectable selectable => null;

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

		public GameObject gameObject => null;

		public Graphic targetGraphic => null;

		public Transform transform => null;

		public OnChangedEvent onValueChanged
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

		public InputField.ContentType contentType
		{
			get
			{
				return default(InputField.ContentType);
			}
			set
			{
			}
		}

		public int characterLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Graphic placeholder => null;

		public int caretPosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public InputFieldWrapper(ExtendedInputField inputField)
		{
		}

		public InputFieldWrapper(TMP_InputField inputField)
		{
		}

		public void InvokeOnValueChanged(string text)
		{
		}

		public void SetTextWithoutNotify(string text)
		{
		}

		public void ActivateInputField()
		{
		}

		public void DeactivateInputField()
		{
		}
	}
}
