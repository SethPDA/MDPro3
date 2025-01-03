using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingWallpaper : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private BindingWallpaperContext m_Context;

		[SerializeField]
		private bool m_PlayLoopTween;

		private IAsyncProgressContent m_AsyncProgress;

		private bool m_LoadOnStart;

		private GameObject m_Wallpaper;

		public bool visible => false;

		public BindingWallpaperContext context => null;

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

		public static BindingWallpaper Binding(RawImage target, BindingWallpaperContext mateContext)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateData(BindingWallpaperContext mateContext)
		{
		}

		private void Load()
		{
		}

		private void OnReadyWallpaper()
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}
	}
}
