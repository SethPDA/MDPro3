using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DeckBrowser
{
	public class DeckBrowserOptionWidget : ElementWidgetBase
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOption";

		protected string k_ELabelFiveDrawButton;

		protected string k_ELabelRegulationButton;

		protected string k_ELabelRegulationText;

		protected string k_ELabelHasCardOnlyToggle;

		protected string k_ELabelCopyButton;

		protected string k_ELabelDeleteButton;

		protected string k_ELabelDescText;

		protected string k_ELabelUpperMenus;

		protected string k_ELabelFooterMenus;

		protected string k_ELabelExportButton;

		protected string k_ELabelButtonIconCardDB;

		protected SelectionButton m_RegulationButton;

		protected TextMeshProUGUI m_RegulationText;

		protected SelectionButton m_HasCardOnlyButton;

		protected ToggleWidget m_HasCardOnlyToggle;

		protected SelectionButton m_CopyButton;

		protected TextMeshProUGUI m_CopyText;

		protected SelectionButton m_DeleteButton;

		protected TextMeshProUGUI m_DeleteText;

		protected SelectionButton m_FiveDrawButton;

		protected TextMeshProUGUI m_FiveDrawText;

		protected SelectionButton m_ExportButton;

		protected TextMeshProUGUI m_ExportText;

		protected Image m_ExportIconCardDB;

		protected TextMeshProUGUI m_DescText;

		protected Transform m_UpperMenus;

		protected Transform m_FooterMenus;

		private ShortcutKeySetter m_ShortcutSettings;

		public Action onClickFiveDrawCallback;

		public Action onClickExportCallback;

		public Action onClickRegulationCallback;

		public Action<bool> onClickHasCardOnlyCallback;

		public Action onClickCopyCallback;

		public Action onClickDeleteCallback;

		public bool fiveDrawButtonEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string fiveDrawText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool m_ExportButtonEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string ExportText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite ExportIcon
		{
			set
			{
			}
		}

		public bool regulationButtonEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string regulationText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool hasCardOnlyToggleEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool hasCardOnlyToggleIsOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool copyButtonEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string copyButtonText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool deleteButtonEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string deleteButtonText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool descTextEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string descText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool upperMenuEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool footerMenuEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ShortcutKeySetter ShortcutSettings => null;

		public void SetFiveDrawButtonImage(Sprite sprite, Sprite spriteOver)
		{
		}

		public void SetCopyButtonImage(Sprite sprite, Sprite spriteOver)
		{
		}

		public static void Create(Transform parent, Action<DeckBrowserOptionWidget> onCreated)
		{
		}

		public DeckBrowserOptionWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void CopyButtonUpdate()
		{
		}

		public void CopyButtonSetColor(bool active)
		{
		}
	}
}
