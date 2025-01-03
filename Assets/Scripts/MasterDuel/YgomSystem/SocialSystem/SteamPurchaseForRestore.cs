using System.Runtime.CompilerServices;
using KonamiCommonIAB;

namespace YgomSystem.SocialSystem
{
	public class SteamPurchaseForRestore : Purchase
	{
		public override string productId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public long OrderID
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		public long TransationID
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		public SteamPurchaseForRestore(long order_id, long transaction_id, string product_id)
		{
		}

		public override ProductInfo getProductInfo()
		{
			return null;
		}

		public override string getReceipt()
		{
			return null;
		}
	}
}
