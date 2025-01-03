using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomSystem.Home
{
	public class BindingTopicsBanner : MonoBehaviour, IAsyncProgressContainer, ILoadingIconHandler
	{
		[SerializeField]
		private MDMarkupBannerContext m_BannerContext;

		private TopicsBannerWidget m_TopicsBanner;

		private bool m_Visible;

		public MDMarkupBannerContext bannerContext => null;

		public TopicsBannerWidget topicsBanner => null;

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IReadOnlyList<IAsyncProgressContent> asyncProgressContents => null;

		public event Action onReloadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Update()
		{
		}

		public void ApplyContext()
		{
		}

		public bool IsDone()
		{
			return false;
		}

		private void RefreshVisible()
		{
		}
	}
}
