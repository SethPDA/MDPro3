using System.Collections.Generic;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;

namespace YgomSystem.Home
{
	public class TopicsBannerWidget : IAsyncProgressContainer
	{
		private List<IAsyncProgressContent> m_AsyncProgressContents;

		public ElementObjectManager rootEom;

		public IReadOnlyList<IAsyncProgressContent> asyncProgressContents => null;

		public static TopicsBannerWidget Create(GameObject parent, MDMarkupBannerContext bannerContext)
		{
			return null;
		}

		private TopicsBannerWidget InnerBinding(GameObject parent, string prefPath, Dictionary<string, object> prefArgs)
		{
			return null;
		}

		private TopicsBannerWidget FailedInnerBinding(Dictionary<string, object> prefArgs)
		{
			return null;
		}

		private void ClearProgressContent()
		{
		}

		private void AssignProgressContent(IAsyncProgressContent progressContent)
		{
		}
	}
}
