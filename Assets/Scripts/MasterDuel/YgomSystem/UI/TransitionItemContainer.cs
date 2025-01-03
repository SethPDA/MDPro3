using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public class TransitionItemContainer : MonoBehaviour
	{
		[SerializeField]
		private List<SelectionItem> _itemListUp;

		[SerializeField]
		private List<SelectionItem> _itemListDown;

		[SerializeField]
		private List<SelectionItem> _itemListRight;

		[SerializeField]
		private List<SelectionItem> _itemListLeft;

		private List<SelectionItem> itemListUp => null;

		private List<SelectionItem> itemListDown => null;

		private List<SelectionItem> itemListRight => null;

		private List<SelectionItem> itemListLeft => null;

		public SelectionItem GetItem(PadInputDirection direction)
		{
			return null;
		}
	}
}
