using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Shop
{
	public class BindingShopProductThumb : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		public enum ThumbType
		{
			CardIllust = 1,
			Image = 2,
			Prefab = 3
		}

		[Serializable]
		public class Context
		{
			public ThumbType thumbType;

			public ShopCardThumbSettings.Format format;

			public int mrk;

			public string path;

			public void ImportWork(int thumbType, string thumbData)
			{
			}

			public bool IsEqualParams(Context other)
			{
				return false;
			}

			public void Import(Context other)
			{
			}
		}

		private ShopCardThumbSettings m_ShopCardThumbSettings;

		private IAsyncProgressContent m_AsyncProgressContent;

		private RectTransform m_RectTransform;

		private RectTransform m_RectMask;

		private AspectRatioFitter m_RectAspectRatioFitter;

		private RawImage m_RawImage;

		private Texture m_RawImageTex;

		private Rect m_RawImageUV;

		private AspectRatioFitter m_ImageAspectRatioFitter;

		private GameObject m_BindiedObject;

		[SerializeField]
		private Context m_Context;

		private Action m_OnLoadedSettingCallback;

		private bool m_Visible;

		private bool m_Initialized;

		public Context context => null;

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

		public bool enabledAspectRatio
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

		public bool isReady => false;

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

		private void Start()
		{
		}

		public static BindingShopProductThumb Attach(RectTransform root)
		{
			return null;
		}

		public static BindingShopProductThumb Binding(RectTransform root, Context context)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void Update()
		{
		}

		private void OnSourceChange()
		{
		}

		private void OnUpdatedRawImage()
		{
		}

		private void OnAbort()
		{
		}

		private void OnReady()
		{
		}

		private void RefreshVisible()
		{
		}

		public void Binding()
		{
		}

		private void InnerCardIllustBinding()
		{
		}

		private void InnerImageBinding()
		{
		}

		private void InnerPrefabBinding()
		{
		}

		public void CaptureTo(BindingShopProductThumb target)
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		private void OnLoadCardTextureComplete(int mrk, bool onSettingsComplete = false)
		{
		}

		private void OnLoadImageTextureComplete(Texture2D texture)
		{
		}

		private void OnLoadPrefabComplete(GameObject bindedObject)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
