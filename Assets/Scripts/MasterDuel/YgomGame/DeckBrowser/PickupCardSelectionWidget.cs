using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser
{
	public class PickupCardSelectionWidget : DeckBrowserOptionWidget
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForPickupCardSelection";

		private ShortcutKeySetter m_ShortcutSettings;

		public Action popViewCallback;

		private int m_DeckID;

		private int m_EventID;

		private ProfileEditViewController.EditType m_EditType;

		private int m_DeckCaseId;

		private int m_ProtecterId;

		private int[] m_PickCardIds;

		private int[] m_PickPremiumIds;

		private readonly string k_ELabelDeckCase;

		private GameObject m_DeckCaseImage;

		public PickupCursorManager pickupCursorManager;

		public Action<DeckBrowserViewController> pickupCardsActionCallback;

		public PickupCardSelectionWidget(ElementObjectManager eom, int id, int eventId, int deckcaseId, ProfileEditViewController.EditType editType)
			: base(null)
		{
		}

		public static void Create(Transform parent, int id, int eventId, ProfileEditViewController.EditType editType, int deckcaseId, Action<PickupCardSelectionWidget> onCreated)
		{
		}

		private void InitializeAccsesary()
		{
		}

		private int[] DictToArray(Dictionary<string, object> dict)
		{
			return null;
		}

		public void SavePickups()
		{
		}
	}
}
