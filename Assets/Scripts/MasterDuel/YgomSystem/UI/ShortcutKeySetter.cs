using System;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomSystem.UI
{
	public class ShortcutKeySetter : MonoBehaviour
	{
		[Serializable]
		public class Setting
		{
			[SerializeField]
			private string m_ButtonLabel;

			[SerializeField]
			private SelectorManager.KeyType m_KeyType;

			[SerializeField]
			private SelectorManager.KeyType m_KeyTypeSub;

			[SerializeField]
			private string m_IconLabel;

			[SerializeField]
			private GamePadIconUtil.Variation m_IconVariation;

			public string buttonLabel
			{
				get
				{
					return null;
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

			public string iconLabel
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public GamePadIconUtil.Variation iconVariation
			{
				get
				{
					return default(GamePadIconUtil.Variation);
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
			private string m_ButtonLabel;

			[SerializeField]
			private SelectorManager.MouseType m_MouseType;

			public string buttonLabel
			{
				get
				{
					return null;
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
		private string m_MouseCancelLabel;

		[SerializeField]
		private string[] m_MouseCancelAdditionalLabels;

		[SerializeField]
		private Setting[] m_Settings;

		private int m_LoadingCount;

		public bool isLoading => false;

		public void Initialize(Action onComplete = null)
		{
		}

		public void Initialize(ElementObjectManager eom, Action onComplete = null)
		{
		}

		public static bool SetShortcut(ElementObjectManager eom, Setting setting, Action onComplete = null)
		{
			return false;
		}

		public static bool SetShortcut(ElementObjectManager eom, string buttonLabel, string iconLabel, SelectorManager.KeyType keyType, SelectorManager.KeyType keyTypeSub = SelectorManager.KeyType.None, GamePadIconUtil.Variation iconVariation = GamePadIconUtil.Variation.Var00, Action onComplete = null)
		{
			return false;
		}

		public static bool SetShortcutKey(ElementObjectManager eom, string buttonLabel, SelectorManager.KeyType keyType, SelectorManager.KeyType keyTypeSub = SelectorManager.KeyType.None)
		{
			return false;
		}

		public static bool SetShortcutIcon(ElementObjectManager eom, string iconLabel, SelectorManager.KeyType keyType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, Action onComplete = null)
		{
			return false;
		}

		public static bool SetShortcutIcon(ElementObjectManager eom, string iconLabelMain, string iconLabelSub, string iconLabelPlus, SelectorManager.KeyType keyTypeMain, SelectorManager.KeyType keyTypeSub, GamePadIconUtil.Variation variationMain = GamePadIconUtil.Variation.Var00, GamePadIconUtil.Variation variationSub = GamePadIconUtil.Variation.Var00, Action onComplete = null)
		{
			return false;
		}

		public static bool SetMouseCancelShortcutKey(ElementObjectManager eom, string buttonLabel)
		{
			return false;
		}
	}
}
