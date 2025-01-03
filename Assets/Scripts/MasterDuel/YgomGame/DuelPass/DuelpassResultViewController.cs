using System;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Duelpass
{
	public class DuelpassResultViewController : BaseMenuViewController
	{
		private DuelpassResultProgressBarWidget resultProgressBar;

		private DuelpassRewardPanelWidget rewardPanel;

		private SelectionButton toDuelResultButton;

		private GameObject goldFirefly;

		private GameObject normalFirefly;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void ResultView()
		{
		}

		private void Start()
		{
		}

		private void OnStartProgressBarAnimation()
		{
		}

		private void OnEndProgressBarAnimation()
		{
		}

		private void OnGradeUp(int grade)
		{
		}
	}
}
