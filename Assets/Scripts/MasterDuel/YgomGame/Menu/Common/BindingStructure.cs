using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu.Common
{
	public class BindingStructure : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
	{
		[SerializeField]
		private int m_ItemId;

		private uint m_PrefCrc;

		private DeckCaseWidget m_DeckCaseWidget;

		private bool m_WidgetDirty;

		public int itemId
		{
			get
			{
				return 0;
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

		public bool IsDone()
		{
			return false;
		}

		public static BindingStructure Binding(GameObject target, int itemId)
		{
			return null;
		}

		private void SourceChange()
		{
		}

		private void Update()
		{
		}

		public void ProgressUpdate()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
