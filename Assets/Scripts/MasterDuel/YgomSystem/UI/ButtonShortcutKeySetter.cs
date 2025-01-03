using System;
using UnityEngine;

namespace YgomSystem.UI
{
	public class ButtonShortcutKeySetter : MonoBehaviour
	{
		public enum InputType
		{
			Always = 0,
			OnSelected = 1
		}

		[Serializable]
		public class Setting
		{
			[SerializeField]
			private InputType m_InputType;

			[SerializeField]
			private SelectorManager.KeyType m_KeyType;

			[SerializeField]
			private SelectorManager.KeyType m_KeyTypeSub;

			public InputType inputType
			{
				get
				{
					return default(InputType);
				}
				set
				{
				}
			}

			public SelectorManager.KeyType keyType
			{
				get
				{
					return default(SelectorManager.KeyType);
				}
				set
				{
				}
			}

			public SelectorManager.KeyType keyTypeSub
			{
				get
				{
					return default(SelectorManager.KeyType);
				}
				set
				{
				}
			}
		}

		[Serializable]
		public class MouseSetting
		{
			[SerializeField]
			private InputType m_InputType;

			[SerializeField]
			private SelectorManager.MouseType m_MouseType;

			public InputType inputType
			{
				get
				{
					return default(InputType);
				}
				set
				{
				}
			}

			public SelectorManager.MouseType mouseType
			{
				get
				{
					return default(SelectorManager.MouseType);
				}
				set
				{
				}
			}
		}

		[SerializeField]
		private Setting[] m_Settings;

		[SerializeField]
		private MouseSetting[] m_MouseSettings;

		private SelectionButton m_ButtonCache;

		private SelectionButton button => null;

		private void Start()
		{
		}

		private bool OnSelectedKeyUp()
		{
			return false;
		}

		private void OnSelectedMounseUp(bool pointerEnter)
		{
		}
	}
}
