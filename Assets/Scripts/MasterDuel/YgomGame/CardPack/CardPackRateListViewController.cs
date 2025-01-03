using System;
using System.Collections.Generic;
using YgomGame.CardPack.RateMMAData;
using YgomGame.Menu;

namespace YgomGame.CardPack
{
	public class CardPackRateListViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string k_ArgPackId = "packId";

		private const string k_ArgShopId = "shopId";

		protected override Type[] textIds => null;

		public static void Open(int packId, int shopId, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void LaunchMDMarkupAsset()
		{
		}

		private IMMAData CreateMMAData(Dictionary<string, object> mmaData)
		{
			return null;
		}
	}
}
