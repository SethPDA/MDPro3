using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Duelpass
{
	public class DuelPassViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private DuelpassProgressBarWidget progressBar;

		private DuelpassRewardPanelWidget rewardPanel;

		private DuelpassBulkRecieveButtonWidget bulkRecieveButton;

		private DuelpassPeriodDateWidget dateView;

		private GameObject goldFog;

		private GameObject goldFirefly;

		private GameObject normalFirefly;

		private TMP_Text textMessage;

		private SelectionButton toShopButton;

		private SelectionButton whatDuelpassButton;

		private bool isFirst;

		protected override Type[] textIds => null;

		public DuelpassRecommendItemWidget recommendItemView
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		private void Start()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		public void UpdateView()
		{
		}
	}
}
