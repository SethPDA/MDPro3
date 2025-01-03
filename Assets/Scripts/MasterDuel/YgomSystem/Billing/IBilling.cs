using System;
using System.Collections.Generic;
using KonamiCommonIAB;

namespace YgomSystem.Billing
{
	public interface IBilling
	{
		bool initialized { get; }

		bool canMakePayment();

		void Initialize();

		void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback);

		ProductInfo GetItem(string productId);

		void DoRestore(Action<ResultCode> callback = null);

		void DoRestore(Action<ResultCode, List<Purchase>> callback);

		void BuyItem(int shopId, string productId, Action<ResultCode> callback = null);
	}
}
