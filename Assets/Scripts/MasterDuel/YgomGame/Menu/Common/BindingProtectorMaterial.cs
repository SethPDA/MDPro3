using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingProtectorMaterial : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private int m_ItemId;

		private RawImage m_TargetCache;

		private bool m_LoadOnStart;

		public int itemid
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private RawImage target => null;

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

		public static BindingProtectorMaterial Binding(RawImage target, int itemid)
		{
			return null;
		}

		private void Start()
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void ProgressUpdate()
		{
		}

		public void ExecuteBinding()
		{
		}
	}
}
