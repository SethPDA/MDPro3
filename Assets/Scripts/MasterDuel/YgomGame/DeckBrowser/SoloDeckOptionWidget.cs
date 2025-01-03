using System;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser
{
	public class SoloDeckOptionWidget : DeckBrowserOptionWidget
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForSoloDeck";

		private ShortcutKeySetter m_ShortcutSettings;

		public SoloDeckOptionWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public static void Create(Transform parent, Action<SoloDeckOptionWidget> onCreated)
		{
		}
	}
}
