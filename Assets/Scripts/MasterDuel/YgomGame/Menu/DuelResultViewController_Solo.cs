using System;
using System.Collections;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class DuelResultViewController_Solo : BaseMenuViewController
	{
		public interface IResultPlayer
		{
			IEnumerator Play();
		}

		[Serializable]
		private class LevelUpPlayer : TweenResultPlayer
		{
			[SerializeField]
			private float m_GaugeSpeedPerUnitLevel;

			private float m_increasedExpAmount;

			private int m_bLevel;

			private float m_bExpPercent;

			private int m_aLevel;

			private int m_aExp;

			private int m_aNeedExp;

			private bool m_isFinish;

			protected override bool isFinish => false;

			protected override Selector selector => null;

			public override void Initialize(ElementObjectManager eom, int selectorGroupPriority)
			{
			}

			public override void ImportWork(object workData)
			{
			}

			public override IEnumerator Play()
			{
				return null;
			}

			protected override void OnClickClose()
			{
			}
		}

		private abstract class TweenResultPlayer : IResultPlayer
		{
			protected readonly string k_TweenOpenKey;

			protected readonly string k_TweenCloseKey;

			protected readonly string k_CloseButtonLabel;

			protected ElementObjectManager m_Eom;

			protected virtual Selector selector => null;

			protected virtual bool isFinish => false;

			public virtual void Initialize(ElementObjectManager eom, int selectorGroupPriority)
			{
			}

			public abstract void ImportWork(object workData);

			public virtual IEnumerator Play()
			{
				return null;
			}

			protected virtual void OnClickClose()
			{
			}
		}

		private readonly string LEVELINFO_LABEL;

		private readonly string BTN_RETRY_LABEL;

		private readonly string BTN_SAVE_LABEL;

		private readonly string BTN_BACK_LABEL;

		[SerializeField]
		private LevelUpPlayer m_LevelupPlayer;

		private SelectionButton RetryButton;

		private SelectionButton SaveButton;

		private SelectionButton BackButton;

		private Util.GameMode m_GameMode;

		private static IEnumerator coroutine;

		private int remainAddRangeCount;

		protected override Type[] textIds => null;

		protected override int selectorPriorityAddRange => 0;

		private int GetRemainAddRange()
		{
			return 0;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public IEnumerator StartResult()
		{
			return null;
		}
	}
}
