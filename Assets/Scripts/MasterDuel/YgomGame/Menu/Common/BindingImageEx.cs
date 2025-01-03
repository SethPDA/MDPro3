using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingImageEx : BindingImage, IAsyncProgressContent, ILoadingIconHandler
	{
		private AspectRatioFitter.AspectMode m_AspectMode;

		public AspectRatioFitter.AspectMode aspectMode
		{
			get
			{
				return default(AspectRatioFitter.AspectMode);
			}
			set
			{
			}
		}

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

		public static BindingImageEx Binding(GameObject target, string spritePath, string materialPath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
		{
			return null;
		}

		public static BindingImageEx Binding(Image target, string spritePath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
		{
			return null;
		}

		public static BindingImageEx Binding(RawImage target, string spritePath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
		{
			return null;
		}

		public static void BindingImageOrPrefab(Image target, string path, bool async = true, AspectRatioFitter.AspectMode imageAspectMode = AspectRatioFitter.AspectMode.None, BindingGameObjectEx.FitMode prefabFitMode = BindingGameObjectEx.FitMode.SCALE_FIT_HIGHEST, bool tryUseAssetSize = true, float overrideWidth = 0f, float overrideHeight = 0f, Action onComplete = null, Action handleOnFailedCallback = null)
		{
		}

		private static BindingImageEx InnerBinding(GameObject target, string spritePath, string materialPath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
		{
			return null;
		}

		private bool YgomSystem_002EUI_002EILoadingIconHandler_002EIsDone()
		{
			return false;
		}

		private bool YgomGame_002EMenu_002ECommon_002EIAsyncProgressContent_002EIsDone()
		{
			return false;
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		public override bool OnBinding()
		{
			return false;
		}

		public override void OnRebind()
		{
		}

		private void ApplyAspectRatio()
		{
		}
	}
}
