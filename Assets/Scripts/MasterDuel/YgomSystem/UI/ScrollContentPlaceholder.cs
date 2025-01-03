using UnityEngine;

namespace YgomSystem.UI
{
	public abstract class ScrollContentPlaceholder<Content> where Content : class
	{
		protected RectTransform m_RectTransform;

		private Content m_Content;

		protected ScrollContentPlaceholder(Transform parent, RectTransform viewport)
		{
		}

		private void OnChangeContainViewport(bool isContain)
		{
		}

		protected abstract Content CreateContent();

		protected abstract void UpdateContent(Content content);

		protected virtual void OnReleaseContent(Content content)
		{
		}
	}
}
