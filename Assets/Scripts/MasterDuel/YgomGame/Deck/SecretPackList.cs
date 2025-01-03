using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Deck
{
	public class SecretPackList : BaseMenuViewController, IBokeSupported, IBackButtonSupported, IHeaderBorderSupported
	{
		private List<CardCollectionInfo.SecretPackInfo> packList;

		private InfinityScrollView infinityScroll;

		private Action<int, List<int>> decideCallback;

		public const string argsKeyPackList = "PackList";

		public const string argsKeyCallback = "DecideCallback";

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		private void Start()
		{
		}

		public void OnCreateEntity(GameObject obj)
		{
		}

		public void OnUpdateEntity(GameObject obj, int idx)
		{
		}
	}
}
