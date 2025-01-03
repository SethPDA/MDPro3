using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum
{
	public class ColosseumRewardDuelistCupViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
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

			protected readonly string TXT_TITLE_LABEL;

			protected readonly string TXT_DATE_LABEL;

			protected readonly string TXT_EXPLAIN_LABEL;

			protected readonly string IMG_RECEIVED_LABEL;

			protected readonly ColosseumRewardDuelistCupViewController vc;

			protected readonly InfinityScrollView isv;

			protected readonly ElementObjectManager eom;

			protected readonly int id;

			protected readonly string endDateReward;

			protected readonly ColosseumUtil.StatusDuelistCup status;

			protected readonly bool isTabChange;

			protected ModeBehaviour(ColosseumRewardDuelistCupViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string endDateReward, ColosseumUtil.StatusDuelistCup status, bool isTabChange)
			{
			}

			internal abstract void CallAPI();

			internal abstract void UpdateView();

			internal abstract void OnUpdateEntity(GameObject go, int dataIndex);

			internal abstract void InitializeScroll();
		}

		internal class DuelistCupBehaviour : ModeBehaviour
		{
			private class Data
			{
				internal List<ItemDataDC> itemDatas;

				internal int indexNum;

				public Data(int indexNum)
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

				public ItemDataDC(int itemCategory, int itemId, int num, bool isPeriod, int needDlv, bool focus, bool received)
				{
				}
			}

			private ColosseumUtil.StatusDuelistCup statusDuelistCup;

			protected ColosseumUtil.PlayMode mode;

			private List<Data> dataList;

			private int rewardDlv;

			private int maxDLv;

			private bool isChanged;

			public DuelistCupBehaviour(ColosseumRewardDuelistCupViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string endDateReward, ColosseumUtil.StatusDuelistCup status, bool isTabChange)
				: base(null, null, null, 0, null, default(ColosseumUtil.StatusDuelistCup), isTabChange: false)
			{
			}

			protected virtual void SetTabLabel(ElementObjectManager eom)
			{
			}

			protected virtual string GetIdsRewardsInfoSecond()
			{
				return null;
			}

			internal override void CallAPI()
			{
			}

			internal override void InitializeScroll()
			{
			}

			private string orderTextConvert(Data data, bool isSingleRank = false, Data nextData = null)
			{
				return null;
			}

			internal override void OnUpdateEntity(GameObject go, int dataIndex)
			{
			}

			internal override void UpdateView()
			{
			}

			private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
			{
				return null;
			}
		}

		internal class WCSBehaviour : DuelistCupBehaviour
		{
			public WCSBehaviour(ColosseumRewardDuelistCupViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string endDateReward, ColosseumUtil.StatusDuelistCup status, bool isTabChange)
				: base(null, null, null, 0, null, default(ColosseumUtil.StatusDuelistCup), isTabChange: false)
			{
			}

			protected override void SetTabLabel(ElementObjectManager eom)
			{
			}

			protected override string GetIdsRewardsInfoSecond()
			{
				return null;
			}
		}

		private readonly string SCROLL_LABEL;

		private ModeBehaviour modeBehaviour;

		private InfinityScrollView isv;

		private List<SelectionItem> isvEdgeSelectSearchList;

		private ChangeFormWidget m_changeFormWidget;

		private readonly string k_ELabelchangeRewardsTabs;

		private readonly string k_ELabelShortcutButtonRarityBack;

		private readonly string k_ELabelShortcutButtonRarityNext;

		private readonly string k_ELabelAnalogDirectionItem;

		private ColosseumUtil.StatusDuelistCup status;

		private ColosseumUtil.PlayMode mode;

		private string endDate;

		private string endDateReward;

		private int id;

		private int currentTabIdx;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void UpdateDisplay()
		{
		}

		private ModeBehaviour GetModeBehaviour(ColosseumUtil.PlayMode playMode, string txtDate, ColosseumUtil.StatusDuelistCup status, bool isTabChange)
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
