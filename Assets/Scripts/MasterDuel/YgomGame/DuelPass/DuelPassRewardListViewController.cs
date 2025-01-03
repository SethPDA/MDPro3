using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DuelPass
{
	public class DuelPassRewardListViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class ItemContext
		{
			public int grade;

			public bool isPeriod;

			public int itemCategory;

			public int itemId;

			public int itemCount;

			public bool isRecommend;

			public ItemContext(int grade, bool isPeriod, int itemCategory, int itemId, int itemCount, bool isRecommend)
			{
			}

			public bool IsSameItem(ItemContext itemContext)
			{
				return false;
			}
		}

		private readonly string k_ELabelScrollView;

		private readonly string k_ELabelThumbHolder;

		private readonly string k_ELabelGradeText;

		private readonly string k_ELabelNumText;

		private readonly string k_ELabelItemRow;

		private readonly string k_ELabelTotalItemRow;

		private readonly string k_ELabelText;

		private readonly string k_ELabelItemTemplate;

		private readonly string k_ELabelTotalItemTemplate;

		private readonly string k_ELabelAnalogDirectionItem;

		private readonly List<string> m_cloneTotalItemNameList;

		private readonly List<string> m_cloneItemNameList;

		private readonly string k_grade;

		private readonly string k_isPeriod;

		private readonly string k_itemCategory;

		private readonly string k_itemId;

		private readonly string k_itemCount;

		private readonly string k_isRecommend;

		private const int k_TextTNo = 0;

		private const int k_TotalItemRowTNo = 1;

		private const int k_ItemRowTNo = 2;

		private static string k_ArgDuelPassDic;

		[SerializeField]
		private readonly int MAX_COL_CONSOLE;

		[SerializeField]
		private readonly int MAX_COL_MOBILE;

		private int m_maxCol;

		private int m_maxTotalItemRow;

		private int m_maxItemRow;

		private readonly int GRADE_TOTALITEM;

		private int m_itemRowStartNum;

		private int m_totalItemRowStartNum;

		private List<ItemContext> m_totalItemContexts;

		private List<int> m_templates;

		private List<List<ItemContext>> m_totalItemContextGrid;

		private List<List<ItemContext>> m_itemContextGrid;

		private GameObject m_itemTemplateGO;

		private GameObject m_totalItemTemplateGO;

		private InfinityScrollView m_scrollView;

		protected override Type[] textIds => null;

		public static void Open(Dictionary<string, object> shopDuelPassDic)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void AddTotalItemContext(ItemContext itemContext)
		{
		}

		private void CreateTotalItemContextGrid()
		{
		}

		private IReadOnlyList<(SelectionItem, int, int)> OnItemCollectSelectionItems(GameObject go)
		{
			return null;
		}

		public void OnUpdateEntity(GameObject gob, int dataindex)
		{
		}

		private void SetItemWidget(ElementObjectManager itemWidget, ItemContext itemContext)
		{
		}

		private bool IsSelectableDataIndex(int dataindex)
		{
			return false;
		}

		private void OnClickItem(ItemContext itemContext)
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}
	}
}
