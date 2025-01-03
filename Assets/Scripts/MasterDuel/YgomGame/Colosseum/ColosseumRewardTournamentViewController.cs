using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum
{
	public class ColosseumRewardTournamentViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
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

			protected readonly string E_ImageReceived;

			protected readonly ColosseumRewardTournamentViewController vc;

			protected readonly InfinityScrollView isv;

			protected readonly ElementObjectManager eom;

			protected readonly int id;

			protected readonly string startDateReward;

			protected readonly string endDateReward;

			protected ModeBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
			{
			}

			internal abstract void CallAPI();

			internal abstract void UpdateView();

			internal abstract void OnUpdateEntity(GameObject go, int dataIndex);

			internal abstract void InitializeScroll();
		}

		internal class TournamentBehaviour : ModeBehaviour
		{
			private class Data
			{
				internal List<ItemData> itemDatas;

				internal int maxRank;

				internal int minRank;

				public Data(int maxRank, int minRank)
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

			private List<Data> dataList;

			public TournamentBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
				: base(null, null, null, 0, null, null)
			{
			}

			internal override void CallAPI()
			{
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

			private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
			{
				return null;
			}
		}

		internal class ExhibitionBehaviour : ModeBehaviour
		{
			private class Data
			{
				internal readonly int itemCategory;

				internal readonly int itemID;

				internal readonly int needToken;

				internal readonly int quantity;

				internal bool isPeriod;

				internal bool received;

				public Data(int itemCategory, int itemID, int needToken, int quantity, bool isPeriod, bool received)
				{
				}
			}

			private List<Data> dataList;

			public ExhibitionBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
				: base(null, null, null, 0, null, null)
			{
			}

			internal override void CallAPI()
			{
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
		}

		internal class DuelTrialBehaviour : ModeBehaviour
		{
			private class Data
			{
				internal List<ItemData> itemDatas;

				internal string winText;

				public Data(string winText)
				{
				}
			}

			private class ItemData
			{
				internal int itemCategory;

				internal int itemID;

				internal int num;

				internal bool isPeriod;

				internal int shopId;

				public ItemData(int itemCategory, int itemID, int num, bool isPeriod, int shopId)
				{
				}
			}

			private List<Data> dataList;

			public DuelTrialBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
				: base(null, null, null, 0, null, null)
			{
			}

			internal override void CallAPI()
			{
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

			private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
			{
				return null;
			}
		}

		internal class VersusBehaviour : ModeBehaviour
		{
			private class Data
			{
				internal readonly int itemCategory;

				internal readonly int itemID;

				internal readonly int needToken;

				internal readonly int quantity;

				internal bool isPeriod;

				internal bool received;

				public Data(int itemCategory, int itemID, int needToken, int quantity, bool isPeriod, bool received)
				{
				}
			}

			private List<Data> dataList;

			public VersusBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
				: base(null, null, null, 0, null, null)
			{
			}

			internal override void CallAPI()
			{
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
		}

		private readonly string SCROLL_LABEL;

		private ModeBehaviour modeBehaviour;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}
	}
}
