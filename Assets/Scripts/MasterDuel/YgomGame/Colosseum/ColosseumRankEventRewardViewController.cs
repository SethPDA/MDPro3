using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum
{
	public class ColosseumRankEventRewardViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		internal class ItemData
		{
			internal int itemID;

			internal int quantity;

			internal int itemCategory;

			internal bool is_period;

			internal ItemData(int itemID, int quantity, int itemCategory, bool is_period = false)
			{
			}
		}

		internal class Data
		{
			internal List<ItemData> itemDatas;

			internal int rank;

			internal int tier;

			internal bool received;

			public Data(int rank, int tier, bool received)
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string IMG_ITEM_LABEL;

		private readonly string IMG_ICON_LABEL;

		private readonly string IMG_RANK_LABEL;

		private readonly string IMG_RANK_BG_LABEL;

		private readonly string IMG_RECEIVED_LABEL;

		private readonly string IMG_ARROW_LABEL;

		private readonly string TXT_QUANTITY_LABEL;

		private readonly string TXT_MESSAGE_LABEL;

		private readonly string TXT_RANK_LABEL;

		private readonly string TXT_TIER_LABEL;

		private InfinityScrollView isv;

		private List<Data> dataList;

		private int defaultCursorIndex;

		private bool isSelectedDefault;

		private int id;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		private void UpdateView()
		{
		}

		public void OnItemInitialize(GameObject gob)
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		private string RankEventConvert(int rank)
		{
			return null;
		}

		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
		{
			return null;
		}
	}
}
