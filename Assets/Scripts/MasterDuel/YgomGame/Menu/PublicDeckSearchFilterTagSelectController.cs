using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class PublicDeckSearchFilterTagSelectController : BaseMenuViewController
	{
		private enum CType
		{
			Category = 0,
			Tag = 1
		}

		private readonly string k_ELabelTitleText;

		private readonly string k_ELabelInputField;

		private readonly string k_ELabelPlaceholder;

		private readonly string k_ELabelScrollView;

		private readonly string k_ELabelEmptyMessage;

		private readonly string k_ELabelEmptyMessageText;

		private readonly string k_ELabelInputButton;

		private readonly string k_ELabelButtonOK;

		private readonly string k_ELabelButtonCancel;

		private TextMeshProUGUI m_TitleText;

		private ElementObjectManager m_InputFieldEom;

		private InputFieldWidget m_InputFieldWidget;

		private ElementObjectManager m_ScrollViewEom;

		private InfinityScrollView m_ScrollView;

		private Transform m_EmptyMessage;

		private TextMeshProUGUI m_EmptyMessageText;

		private Transform m_TitleArea;

		private Transform m_TextFieldArea;

		private SelectionButton m_InputButton;

		private SelectionButton m_ButtonOK;

		private SelectionButton m_ButtonCancel;

		private CType type;

		private string m_Language;

		private List<CategoryReference> m_Categories;

		private List<CategoryReference> m_SelectedCategories;

		private List<CategoryReference> m_tmpSelected;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		private void Start()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void InitializeCategoryList()
		{
		}

		private void SortCategory()
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

		private void OnClickButtonOK()
		{
		}

		private void OnClickButtonCancel()
		{
		}

		private void SetKeyWord(string keyword)
		{
		}

		private string StrConvHiraToKata(string str)
		{
			return null;
		}

		private void CheckNOListMessage(string keyword)
		{
		}

		public string LangKey(string lang)
		{
			return null;
		}
	}
}
