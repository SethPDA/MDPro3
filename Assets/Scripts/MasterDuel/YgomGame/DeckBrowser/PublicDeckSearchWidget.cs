using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser
{
	public class PublicDeckSearchWidget : DeckBrowserOptionWidget
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForPublicDeckSearch";

		private readonly string k_ELabelTagArea;

		private readonly Transform m_TagArea;

		private readonly InfinityScrollView m_TagScrollView;

		private List<CategoryReference> m_SelectedCategories;

		private List<CategoryReference> m_SelectedTags;

		private ShortcutKeySetter m_ShortcutSettings;

		public PublicDeckSearchWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public static void Create(Transform parent, Action<PublicDeckSearchWidget> onCreated)
		{
		}

		private void InitializeInfinityScrollView()
		{
		}

		public void OnItemInitialize(GameObject gob)
		{
		}

		public void OnGsvStanby()
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public void SetCategories(List<int> categoryIds)
		{
		}

		public void SetTags(List<int> tagIds)
		{
		}

		public string LangKey(string lang)
		{
			return null;
		}
	}
}
