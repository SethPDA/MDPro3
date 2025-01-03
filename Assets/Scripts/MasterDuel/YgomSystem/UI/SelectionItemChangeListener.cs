using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.UI
{
	public class SelectionItemChangeListener : MonoBehaviour
	{
		private SelectionItem m_LastSelectItem;

		public event Action<SelectionItem, SelectionItem> onChangedSelectionItemEvent
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

		public static SelectionItemChangeListener Attach(GameObject owner)
		{
			return null;
		}

		private void LateUpdate()
		{
		}
	}
}
