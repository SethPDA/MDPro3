using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using KonamiCommonIAB;
using YgomSystem.Network;

namespace YgomSystem.Billing
{
	public abstract class Billing_Base : IBilling
	{
		protected InAppBilling m_inAppBilling;

		protected Dictionary<string, ProductInfo> m_productDic;

		private Action<ResultCode> OnBuyCallback;

		public int NetworkErrorCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual bool initialized => false;

		public abstract bool canMakePayment();

		protected abstract void GetItemList(string[] productIds, Action<List<ProductInfo>> callback);

		protected abstract void checkUnfinishedPurchase(ProductInfo product, Action<ResultCode, Purchase> callback);

		protected abstract void checkUnfinishedPurchase(Action<ResultCode, List<Purchase>> callback);

		protected abstract bool BuyItemFromPlatform(ProductInfo product, IabDelegate.OnBuyFinishedDelegate cb);

		protected abstract void OnPurchaseFinished(Purchase purchase);

		protected virtual Handle API_Billing_reservation(int shopID, int merchId, ProductInfo product)
		{
			return null;
		}

		protected virtual Handle API_Billing_purchase(Purchase purchase)
		{
			return null;
		}

		protected virtual Handle API_Billing_re_store(Purchase purchase)
		{
			return null;
		}

		protected bool CheckMaintenance(Handle handle, out ResultCode res)
		{
			res = default(ResultCode);
			return false;
		}

		protected void LockUI()
		{
		}

		protected void UnLockUI()
		{
		}

		public virtual void Initialize()
		{
		}

		public void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback)
		{
		}

		public ProductInfo GetItem(string productId)
		{
			return null;
		}

		public void DoRestore(Action<ResultCode> callback = null)
		{
		}

		public void DoRestore(Action<ResultCode, List<Purchase>> callback)
		{
		}

		public void BuyItem(int shopId, string productId, Action<ResultCode> callback = null)
		{
		}

		protected virtual void RequestRevervation(int shopId, ProductInfo product)
		{
		}

		private void CheckUserAge(int shopId, ProductInfo product)
		{
		}

		public void OpenUserAgeSelectSheet(Action<int> selectedCallback, Action canceledCallback)
		{
		}

		private void OpenUserAgeConfirm(string selectedLabel, Action decidedCallback, Action canceledCallback)
		{
		}

		protected virtual void OnBuyPlatformFinish(Result result, Purchase purchase)
		{
		}

		protected virtual void RequestPurchase(Purchase purchase, Action<ResultCode> callback)
		{
		}

		protected void RequestAddItem(Purchase purchase, Action<ResultCode> callback)
		{
		}

		protected void RequestCancel(Action<ResultCode> callback = null)
		{
		}

		protected virtual void RequestRestore(List<Purchase> purchases, Action<ResultCode> callback)
		{
		}

		protected virtual void RequestRestore(List<Purchase> purchases, List<Purchase> compPurchases, Action<ResultCode, List<Purchase>> callback)
		{
		}

		protected virtual void RequestRestore(Purchase purchase, Action<ResultCode> callback)
		{
		}

		protected void OnBuyFinish(ResultCode code)
		{
		}

		protected virtual void PurchaseFinishTransaction(Purchase purchase)
		{
		}

		public string GetDoubleNotationDisplayPrice(string productId)
		{
			return null;
		}

		public virtual string GetDoubleNotationDisplayPrice(ProductInfo productInfo)
		{
			return null;
		}

		protected void SetErrorMsg(string msg)
		{
		}
	}
}
