using System;
using System.Collections.Generic;
using KonamiCommonIAB;
//using Steamworks;
using YgomSystem.Network;

namespace YgomSystem.Billing
{
	public class Billing_Steam : Billing_Base
	{
		//protected Callback<MicroTxnAuthorizationResponse_t> m_MicroTxnAuthorizationResponse;

		//protected Callback<SteamServerConnectFailure_t> m_SteamServerConnectFailureCallback;

		//protected Callback<SteamServersDisconnected_t> m_SteamServerDisconnectedCallback;

		protected ProductInfo m_ProductInfo;

		public override bool canMakePayment()
		{
			return false;
		}

		public override void Initialize()
		{
		}

		protected override Handle API_Billing_re_store(Purchase purchase)
		{
			return null;
		}

		protected override bool BuyItemFromPlatform(ProductInfo product, IabDelegate.OnBuyFinishedDelegate cb)
		{
			return false;
		}

		protected override void checkUnfinishedPurchase(ProductInfo product, Action<ResultCode, Purchase> callback)
		{
		}

		protected override void checkUnfinishedPurchase(Action<ResultCode, List<Purchase>> callback)
		{
		}

		protected override void GetItemList(string[] productIds, Action<List<ProductInfo>> callback)
		{
		}

		protected List<Purchase> GetUnfinishedPurchaseItemList()
		{
			return null;
		}

		protected override void OnPurchaseFinished(Purchase purchase)
		{
		}

		//private void OnMicroTxnAuthorizationResponse(MicroTxnAuthorizationResponse_t response)
		//{
		//}

		//private void OnSteamServerConnectFailure(SteamServerConnectFailure_t response)
		//{
		//}

		//private void OnSteamServersDisconnected(SteamServersDisconnected_t response)
		//{
		//}

		//protected void RequestPurchase(MicroTxnAuthorizationResponse_t response, Action<ResultCode> callback)
		//{
		//}

		private void RegistCallback()
		{
		}

		private void UnregistCallback()
		{
		}
	}
}
