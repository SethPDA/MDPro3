using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class DropArea : MonoBehaviour
	{
		private UnityAction m_OnDropAction;

		public string label;

		private RectSelectionItem item;

		private static readonly List<string> LABEL;

		private bool isDeckList;

		private bool setup;

		private void Awake()
		{
		}

		private void Setup()
		{
		}

		public void SetOnDropAction(UnityAction callback)
		{
		}

		public void OnDropAction()
		{
		}

		public void SetActiveDropArea(bool b, bool canDrop)
		{
		}

		public bool IsContainsPoint(Vector2 point)
		{
			return false;
		}
	}
}
