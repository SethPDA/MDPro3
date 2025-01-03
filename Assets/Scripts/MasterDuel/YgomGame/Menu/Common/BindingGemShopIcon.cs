using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.GemShop;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	[DisallowMultipleComponent]
	public class BindingGemShopIcon : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		private const string k_ELabelIconImage = "IconImage";

		private const string k_ELabelEffectRoot = "EffectRoot";

		private const string k_ELabelFxpPrefix = "fxp_UI_Gem";

		private const string k_ELabelFxpFormat = "fxp_UI_Gem_{0:D2}";

		[SerializeField]
		private int m_IconId;

		[SerializeField]
		private bool m_UseEffect;

		[SerializeField]
		private GemShopIconSetting m_Setting;

		private Image m_IconImageCache;

		private GameObject m_EffectRootCache;

		private bool m_Visible;

		private IEnumerator m_OnBindingRoutine;

		public int iconId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Image iconImage => null;

		public GameObject effectRoot => null;

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
