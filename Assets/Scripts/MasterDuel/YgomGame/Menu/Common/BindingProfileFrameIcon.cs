using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingProfileFrameIcon : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		private readonly string k_MatLabelFrameTex;

		[SerializeField]
		private int m_BaseId;

		[SerializeField]
		private int m_FrameId;

		[SerializeField]
		private bool m_IsLarge;

		private bool m_Async;

		private uint m_BaseSpriteCrc;

		private uint m_FrameSpriteCrc;

		private uint m_FrameMatCrc;

		private Image m_ImageCache;

		private Material m_ModiedMaterial;

		private IEnumerator m_BindingRoutine;

		public int baseId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int frameId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isLarge
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private Image image => null;

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

		public static BindingProfileFrameIcon Binding(Image target, int baseId = 0, int frameId = 0, bool isLarge = false, bool async = true)
		{
			return null;
		}

		public static BindingProfileFrameIcon Binding(GameObject target, int baseId, int frameId, bool isLarge = false, bool async = true)
		{
			return null;
		}

		public static BindingProfileFrameIcon BindingBase(Image target, int baseId, bool isLarge = false, bool async = true)
		{
			return null;
		}

		public static BindingProfileFrameIcon BindingBase(GameObject target, int baseId, bool isLarge = false, bool async = true)
		{
			return null;
		}

		public static BindingProfileFrameIcon BindingFrame(Image target, int frameId, bool isLarge = false, bool async = true)
		{
			return null;
		}

		public static BindingProfileFrameIcon BindingFrame(GameObject target, int frameId, bool isLarge = false, bool async = true)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void SourceChanged()
		{
		}

		private void Update()
		{
		}

		public void ProgressUpdate()
		{
		}

		private IEnumerator yBindingRoutine(int baseId, int frameId, bool isLarge, bool async)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
