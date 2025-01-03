using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.WCS
{
	public class WinPredictionRewardViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class ChangeFormWidget : ElementWidgetBase
		{
			public readonly DirectionalToggleGroupWidget rewardsToggleWidget;

			public ChangeFormWidget(ElementObjectManager eom)
				: base(null)
			{
			}
		}

		internal abstract class ModeBehaviour
		{
			protected readonly string BTN_LABEL;

			protected readonly string BTN_ICON_LABEL;

			protected readonly string IMG_LINE_LABEL;

			protected readonly string TXT_ORDER_LABEL;

			protected readonly string TXT_NAME_LABEL;

			protected readonly string TXT_DATE_LABEL;

			protected readonly string TXT_EXPLAIN_LABEL;

			protected readonly string IMG_RECEIVED_LABEL;

			protected readonly WinPredictionRewardViewController vc;

			protected readonly InfinityScrollView isv;

			protected readonly ElementObjectManager eom;

			protected readonly int id;

			protected readonly string endDateReward;

			protected readonly bool isTabChange;

			protected ModeBehaviour(WinPredictionRewardViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string endDateReward, bool isTabChange)
			{
			}

			internal abstract void CallAPI();

			internal abstract void UpdateView();

			internal abstract void OnUpdateEntity(GameObject go, int dataIndex);

			internal abstract void InitializeScroll();
		}

		internal class WcsWinPredictionBehaviour : ModeBehaviour
		{
			private class Data
			{
				internal List<ItemDataDC> itemDatas;

				internal int indexNum;

				internal string title;

				public Data(int indexNum)
				{
				}

				public Data(string title)
				{
				}
			}

			private class ItemData
			{
				internal int itemID;

				internal int quantity;

				public ItemData(int itemID, int quantity)
				{
				}
			}

			private class ItemDataDC
			{
				public int itemCategory;

				public int itemId;

				public int num;

				public int needDlv;

				public bool isPeriod;

				public bool focus;

				public bool received;

				public bool isSpecial;

				public ItemDataDC(int itemCategory, int itemId, int num, bool isPeriod, int needDlv, bool focus, bool received, bool isSpecial = false)
				{
				}
			}

			private List<Data> dataList;

			public WcsWinPredictionBehaviour(WinPredictionRewardViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string endDateReward, bool isTabChange)
				: base(null, null, null, 0, null, isTabChange: false)
			{
			}

			protected virtual string GetIdsRewardsInfoSecond()
			{
				return null;
			}

			internal override void CallAPI()
			{
			}

			private IEnumerator wait()
			{
				return null;
			}

			internal override void InitializeScroll()
			{
			}

			internal override void OnUpdateEntity(GameObject go, int dataIndex)
			{
			}

			internal override void UpdateView()
			{
			}

			private void SetItemData(List<object> list, int index, bool isSpecial, Data data)
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
			{
				return null;
			}
		}

		private readonly string SCROLL_LABEL;

		private ModeBehaviour modeBehaviour;

		private InfinityScrollView isv;

		private List<SelectionItem> isvEdgeSelectSearchList;

		private readonly string k_ELabelAnalogDirectionItem;

		private string endDateReward;

		private int id;

		private const int NormalRewardType = 1;

		private const int SpecialRewardType = 2;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private ModeBehaviour GetModeBehaviour(string txtDate, bool isTabChange)
		{
			return null;
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}
	}
}
