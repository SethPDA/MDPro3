using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Shop
{
	public class BindingCardPackThumb : Binding, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private string m_ThumbName;

		private Image m_ImageCache;

		private IAsyncProgressContent m_AsyncProgressContent;

		public Image targetImage => null;

		public bool visible => false;

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

		public bool IsDone()
		{
			return false;
		}

		public override void OnRebind()
		{
		}

		public override bool OnBinding()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}
	}
}
