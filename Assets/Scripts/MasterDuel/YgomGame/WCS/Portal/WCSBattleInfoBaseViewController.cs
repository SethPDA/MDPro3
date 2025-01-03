using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal
{
	public class WCSBattleInfoBaseViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		public enum ViewType
		{
			LEAGUE = 0,
			FINAL = 1
		}

		public abstract class View
		{
			protected ViewControllerManager _manager;

			protected ElementObjectManager _eom;

			public string cwJsonPath
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Func<bool> isHoldingChecker
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public View(ElementObjectManager eom, ViewControllerManager manager)
			{
			}

			public virtual void Terminate()
			{
			}

			public void ApplyData()
			{
			}

			protected abstract void ApplyFromCW(object baseData);
		}

		private const string ARG_KEY_PAGETYPE = "pagetype";

		private static readonly string[] VC_PATH;

		[SerializeField]
		private ViewType _viewType;

		private ElementObjectManager _scrollEom;

		private View _innerView;

		private Func<Handle> _callPollingAPI;

		private IEnumerator _pollingRoutine;

		private Func<int> _pollingPeriodUpdater;

		private bool _dryrun;

		protected override Type[] textIds => null;

		public static void Go(ViewType type, ViewControllerManager manager)
		{
		}

		private void OnDestroy()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		public override void NotificationStackRemove()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void Start()
		{
		}

		private void StartPolling()
		{
		}

		private void EndPolling()
		{
		}

		private IEnumerator Polling()
		{
			return null;
		}
	}
}
