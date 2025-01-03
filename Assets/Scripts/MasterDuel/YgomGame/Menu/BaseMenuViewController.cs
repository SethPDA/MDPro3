using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu
{
	public class BaseMenuViewController : TweenViewController
	{
		private const string k_ArgKeyUIPrefOverride = "UIPref";

		[SerializeField]
		protected ViewCreater m_ViewCreater;

		protected ElementObjectManager m_View;

		private Selector m_ViewSelector;

		protected List<GameObject> m_AdditionalTweenTarget;

		private List<IAsyncProgressContent> m_AsyncProgressContents;

		private List<IAsyncProgressContent> m_AsyncProgressDeleteCache;

		private int m_LoadingCount;

		private bool isLoading;

		private bool isStartedProgress;

		private bool isDispedProgress;

		private UnityAction startedProgressCallback;

		protected TextGroupLoadHolder m_TextGroupLoadHolder;

		protected virtual bool setSurfaceActiveOnInitialize => false;

		protected virtual bool setProgressOnInitialize => false;

		protected virtual ResourceManager.UnloadCheckLevel unloadCheckLevel => default(ResourceManager.UnloadCheckLevel);

		protected bool isExistsLoading => false;

		public bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual Type[] textIds => null;

		protected Selector m_Selector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void SetStartedProgressCallback(UnityAction callback = null)
		{
		}

		protected void ResetStartedProgressCallback()
		{
		}

		public override float Progress()
		{
			return 0f;
		}

		public override void ProgressUpdate()
		{
		}

		public override void NotificationStackEntry()
		{
		}

		public override void SetVisibleOnInitialize(bool visible)
		{
		}

		protected void CreateView()
		{
		}

		protected virtual void SetSelectorLabelAsUnique()
		{
		}

		protected virtual void OnCreatedView()
		{
		}

		public override void NotificationStackRemove()
		{
		}

		public override void TransitionStart(TransitionType type)
		{
		}

		protected virtual void OnTransitionStart(TransitionType type)
		{
		}

		public override bool TransitionUpdate(TransitionType type)
		{
			return false;
		}

		protected virtual void OnTransitionEnd(TransitionType type)
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		protected void AssignProgressContent(IAsyncProgressContent progressContent)
		{
		}

		protected void AssignProgressContent(IAsyncProgressContainer progressContainer)
		{
		}

		protected void AddLoadingCount()
		{
		}

		protected void DecLoadingCount()
		{
		}
	}
}
