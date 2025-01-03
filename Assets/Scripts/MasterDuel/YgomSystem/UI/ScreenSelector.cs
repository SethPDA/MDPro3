using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI
{
	public class ScreenSelector : Selector
	{
		public enum Type
		{
			FullScreen = 0,
			Untouchable = 1
		}

		private List<SelectionButton> buttonList;

		public static ScreenSelector Create(Transform parent, string group_label, int group_priority)
		{
			return null;
		}

		public SelectionButton AddShortCutKeyReceiver(SelectorManager.KeyType key_type, Type type, UnityAction click_event)
		{
			return null;
		}

		public void DeleteAllShortCutButton()
		{
		}
	}
}
