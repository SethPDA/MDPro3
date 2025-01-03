using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser
{
	public class ConfirmationWidget : DeckBrowserOptionWidget
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForConfirmation";

		private ShortcutKeySetter m_ShortcutSettings;

		private int m_DeckID;

		private int m_EventID;

		private DeckSelectViewController2.DeckEventType m_DeckType;

		private Dictionary<string, object> m_Accsesories;

		public Action popViewCallback;

		public Action deleteWCSFinalDeckCallback;

		public ConfirmationWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public static void Create(Transform parent, Action<ConfirmationWidget> onCreated)
		{
		}

		public void Binding(int deckId, int eventId, DeckSelectViewController2.DeckEventType deckType, Dictionary<string, object> accsesories = null)
		{
		}

		private void DeleteDeckDialog()
		{
		}

		private void GetNeuronToken()
		{
		}

		private void ExportMyDeck(bool isFirst = false)
		{
		}

		private void DeleteDeck()
		{
		}
	}
}
