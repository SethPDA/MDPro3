using System;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser
{
	public class OptionalStructureWidget : DeckBrowserOptionWidget
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForStructureDeck";

		private readonly string k_ELabelDeckCaseIcon;

		private readonly Image m_DeckCaseIcon;

		private ShortcutKeySetter m_ShortcutSettings;

		private int m_structureId;

		protected string k_ELabelGetFirstStructureButton;

		protected SelectionButton m_GetFirstStructureButton;

		public Action onGetFirstStructureCallback;

		public bool getFirstStructureButtonEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OptionalStructureWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public static void Create(int structureId, Transform parent, Action<OptionalStructureWidget> onCreated)
		{
		}

		private void SetStructureId(int structureId)
		{
		}
	}
}
