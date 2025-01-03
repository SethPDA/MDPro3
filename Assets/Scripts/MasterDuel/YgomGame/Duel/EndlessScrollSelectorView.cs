using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class EndlessScrollSelectorView : EndlessScrollView
	{
		public bool loopInScrollView;

		private bool m_IsItemInHere;

		private int m_SelectedItemIndex;

		private Vector2 m_OldPos;

		[HideInInspector]
		public List<int> unselectableIndexList;

		public List<int> uninteractableIndexList;

		public Dictionary<ManualTransition, SelectionItem> manualTransitionTable;

		private RectTransform m_CurrentItemRT => null;

		private RectTransform m_ViewportRT => null;

		public Selector selector => null;

		private Vector2 m_ViewportTopPos => default(Vector2);

		private Vector2 m_ViewportBottomPos => default(Vector2);

		private bool ishorizontalscroll => false;

		private void SetCallBack()
		{
		}

		private bool IsCurrentItemInHere()
		{
			return false;
		}

		protected void InputCallBack(PadInputDirection direction)
		{
		}

		public bool SetSelectItemByDataIndex(int dataIndex, bool forceSelect = false)
		{
			return false;
		}

		protected override void Update()
		{
		}

		public override void Initialize(Func<int> getDataNum, Action<GameObject, int> onItemUpdate, Action<GameObject> onItemInitialize = null)
		{
		}

		private void SetItemTrsnsitionMode(ref SelectionItem selitem, int dataindex, PadInputDirection direction, SelectionItem.TransitionMode defaultMode)
		{
		}

		private int NextDataIndex(PadInputDirection direction)
		{
			return 0;
		}

		private bool IsObeyScrollDirection(SelectorGroup.Direction direction)
		{
			return false;
		}

		private bool IsCurrentDataInViewport()
		{
			return false;
		}

		private bool IsDataInViewport(int dataindex)
		{
			return false;
		}

		private float GetCurrentDataViewportBias()
		{
			return 0f;
		}

		private float GetDataViewportBias(int dataindex)
		{
			return 0f;
		}
	}
}
