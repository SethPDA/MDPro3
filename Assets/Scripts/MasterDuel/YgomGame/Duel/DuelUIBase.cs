using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Duel
{
	public abstract class DuelUIBase : MonoBehaviour
	{
		protected RunEffectWorker effectWorker;

		protected UITransitionUtil uiTransition;

		private const string tweenLabelOpen = "Open";

		private const string tweenLabelClose = "Close";

		protected abstract UITransitionUtil.BlockType openCloseBlockType { get; }

		public bool isShowing
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isOpening
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual void Initialize(RunEffectWorker effectWorker)
		{
		}

		protected virtual void Open(Action openedCallback = null)
		{
		}

		protected virtual void Close(Action closedCallback = null)
		{
		}

		protected virtual void OnOpened()
		{
		}

		protected virtual void OnClosed()
		{
		}

		protected virtual void ShowUI()
		{
		}

		protected virtual void HideUI()
		{
		}

		protected virtual void StartUI()
		{
		}

		protected virtual void UpdateUI()
		{
		}

		protected virtual void DestroyUI()
		{
		}

		private void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
