using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingItemThumb : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		public enum DxBadgeMode
		{
			None = 0,
			Floating = 1,
			Based = 2
		}

		[SerializeField]
		private bool m_IsPeriod;

		[SerializeField]
		private int m_ItemCategory;

		[SerializeField]
		private int m_ItemId;

		[SerializeField]
		private bool m_IsLargeIcon;

		[SerializeField]
		private bool m_IconScaleEnabled;

		[SerializeField]
		private DxBadgeMode m_DxBadgeMode;

		[SerializeField]
		private bool m_IsReverse;

		private bool m_LoadOnStart;

		private bool m_DirtyChild;

		private GameObject m_BindChild;

		private GameObject m_DXBadge;

		private IAsyncProgressContent m_BindProgress;

		public bool isPeriod => false;

		public int itemCategory => 0;

		public int itemId => 0;

		public bool isLargeIcon => false;

		public bool iconScaleEnabled => false;

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

		public static BindingItemThumb Binding(GameObject target, bool isPeriod, int itemCategory, int itemId, bool isLargeIcon = false, DxBadgeMode dxBadgeMode = DxBadgeMode.None)
		{
			return null;
		}

		private void Start()
		{
		}

		private void UpdateData(bool isPeriod, int itemCategory, int itemId, bool isLargeIcon, DxBadgeMode dxBadgeMode = DxBadgeMode.None, bool isReverse = false)
		{
		}

		private void LoadItemThumb()
		{
		}

		private bool YgomSystem_002EUI_002EILoadingIconHandler_002EIsDone()
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
	}
}
