using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomGame.Shop;

namespace YgomGame.Prize.TurnOverPrize
{
	public class TurnOverPrizeOpenViewController : BaseMenuViewController
	{
		private const string k_VCPath = "Prize/TurnOverPrize/TurnOverPrizeOpen";

		private const string k_ArgKeyPrizeId = "prizeId";

		internal const string k_ArgKeyPurchaseHandler = "priceContext";

		private bool m_BeforePostProcessing;

		private ShopBuyViewController.PurchaseHandler m_PurchaseHandler;

		private string m_CoverPath;

		private List<object> m_PrizeDatas;

		private List<string> m_LoadedAssetsPath;

		private GameObject m_Root3D;

		private ActorRoot m_ActorRoot;

		private int m_DecidedIdx;

		protected override Type[] textIds => null;

		public static void Open(int prizeId, ShopBuyViewController.PurchaseHandler purchaseHandler, Dictionary<string, object> args)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator yMainRoutine()
		{
			return null;
		}

		private IEnumerator yPlayShuffle()
		{
			return null;
		}

		private IEnumerator ySelectPrize()
		{
			return null;
		}

		private IEnumerator yPlayResult()
		{
			return null;
		}

		private void SetAllPrizes(bool setArrowVisible = false)
		{
		}

		private void SetPrizeByPos(int pos, bool setArrowVisible = false)
		{
		}

		private void SetPrizesAsBeforeSuffle()
		{
		}

		private void SetPrizeOnUnlock(int idx)
		{
		}
	}
}
