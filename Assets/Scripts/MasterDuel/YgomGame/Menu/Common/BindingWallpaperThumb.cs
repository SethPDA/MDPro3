using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	[DisallowMultipleComponent]
	public class BindingWallpaperThumb : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private int m_WallpaperId;

		private Image m_ImageCache;

		private bool m_Visible;

		private IEnumerator m_OnBindingRoutine;

		public int wallpaperId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Image image => null;

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

		public bool validIconId => false;

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

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void VisibleRefresh()
		{
		}

		public void SourceChanged()
		{
		}

		public void OnRebind()
		{
		}

		public void ProgressUpdate()
		{
		}

		private IEnumerator yOnBindingRoutine()
		{
			return null;
		}
	}
}
