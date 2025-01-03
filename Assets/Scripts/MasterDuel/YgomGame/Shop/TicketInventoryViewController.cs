using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Shop
{
	public class TicketInventoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class Context : IComparable<Context>
		{
			public readonly int shopId;

			public readonly bool currentShopTarget;

			public readonly bool isPeriod;

			public readonly int itemCategory;

			public readonly int itemId;

			public readonly int priceIdx;

			public readonly ProductContext m_ProductContext;

			public ProductContext productContext => null;

			public long limitdateTs => 0L;

			public string limitdate => null;

			public int itemHave => 0;

			public Context(int shopId, bool currentShopId, bool isPeriod, int itemCategory, int itemId, int priceIdx, ProductContext productContext)
			{
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public int Compare(Context a, Context b)
			{
				return 0;
			}

			public int CompareTo(Context other)
			{
				return 0;
			}
		}

		private const string k_ArgsCurrentShopId = "priceContexts";

		private const string k_ELabelScrollView = "ScrollView";

		private const string k_ELabelTextEmpty = "TextEmpty";

		private const string k_ELabelEntity_On = "On";

		private const string k_ELabelEntity_Off = "Off";

		private const string k_ELabelEntity_TicketThumbHolder = "TicketThumbHolder";

		private const string k_ELabelEntity_ProductThumbHolder = "ProductThumbHolder";

		private const string k_ELabelEntity_TextName = "TextName";

		private InfinityScrollView m_ScrollView;

		private List<Context> m_Contexts;

		private Dictionary<int, ProductContext> m_ProductContextCacheMap;

		private int[] m_UsableShopIds;

		protected override Type[] textIds => null;

		public static void Open(int currentShopId, Dictionary<string, object> args = null)
		{
		}

		private ProductContext TryGetProductContext(int shopId)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		private Context TryCreateTicketContexts(int currentShopId, bool isPeriod, int itemCategory, int itemId, int usableShopId)
		{
			return null;
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void OnUpdateEntity(GameObject entity, int idx)
		{
		}

		private void OnClickEntity(int idx)
		{
		}
	}
}
