using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame
{
	public class LootSourceViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private const string LABEL_IMG_IMAGECARD = "ImageCard";

		private const string LABEL_SCV_SOURCESCROLL = "SourceScroll";

		private const string LABEL_SBN_BACK = "Back";

		private const string LABEL_EMPTY_MESSAGE_ROOT = "EmptyMessageRoot";

		public const string argsKeyCardID = "CardID";

		public const string argsKeyCallBack = "DecideCallback";

		private int m_CardID;

		private GameObject m_EmptyMessageRoot;

		private List<object> m_DataList;

		private List<int> m_ShopList;

		private Action<int, List<int>> decideCallback;

		private RawImage m_CardImage => null;

		private SelectionButton m_BackButton => null;

		public InfinityScrollView m_InfinityScroll => null;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public void InitializeScroll()
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
