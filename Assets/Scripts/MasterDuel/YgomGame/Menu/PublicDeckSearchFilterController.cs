using System.Collections.Generic;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class PublicDeckSearchFilterController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		private readonly string k_ELabelCategoryScrollView;

		private readonly string k_ELabelAddCategoryButton;

		private readonly string k_ELabelTagScrollView;

		private readonly string k_ELabelAddTagButton;

		private readonly string k_ELabelCancelButton;

		private readonly string k_ELabelSearchButton;

		private InfinityScrollView m_CategoryScrollView;

		private SelectionButton m_AddCategoryButton;

		private InfinityScrollView m_TagScrollView;

		private SelectionButton m_AddTagButton;

		private SelectionButton m_CancelButton;

		private SelectionButton m_SearchButton;

		private List<CategoryReference> m_SelectedCategories;

		private List<CategoryReference> m_SelectedTags;

		protected override int selectorPriorityAddRange => 0;

		public override void NotificationStackEntry()
		{
		}

		private void Start()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		private void OpenCategorySelectUI()
		{
		}

		private void OpenTagSelectUI()
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

		private void OnClickCategoryButton(int dataindex, CategoryReference categoryRef, SelectionButton button)
		{
		}

		public void OnItemInitialize2(GameObject gob)
		{
		}

		public void OnGsvStanby2()
		{
		}

		public void OnItemSetData2(GameObject gob, int dataindex)
		{
		}

		private void OnClickTagButton(int dataindex, CategoryReference tagRef, SelectionButton button)
		{
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		private void OnClickButtonOK()
		{
		}
	}
}
