using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Menu
{
	public class ContentBlurOverlay : MonoBehaviour
	{
		[SerializeField]
		private string m_TweenShow;

		[SerializeField]
		private string m_TweenHide;

		private static ContentBlurOverlay s_Instance;

		private readonly List<GameObject> m_ContentViews;

		private void Awake()
		{
		}

		public static bool isAssigned(GameObject contentView)
		{
			return false;
		}

		public static void Assign(GameObject contentView)
		{
		}

		public static void Remove(GameObject contentView)
		{
		}

		private void CheckContent()
		{
		}

		private void PlayShow()
		{
		}

		private void PlayHide()
		{
		}

		private void OnClickClose()
		{
		}

		private void OnPlayShowBegin()
		{
		}

		public void OnPlayHideFinish()
		{
		}
	}
}
