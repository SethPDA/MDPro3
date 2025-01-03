using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class SnapContentManager : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
	{
		private const int TEMPLATE_NUM = 3;

		private int templateNum;

		private ScrollRectPageSnap m_pageSnap;

		private ScrollRect m_scrollRect;

		private int m_pastIdx;

		public int currentPage;

		public int m_maxPage;

		public string templateLabel;

		private List<GameObject> templateGOList;

		public Action<GameObject> onCreatedEntityCallback;

		public Action<GameObject, int> onSetEntityCallback;

		public Action onPageChangedCallBack;

		private int m_pageBuff;

		private bool m_isTouching;

		private bool m_isLoop;

		public ScrollRect.ScrollRectEvent onValueChanged => null;

		public void InitializeContent(int maxPage, Action onCompleteCallBack = null, bool isLoop = false)
		{
		}

		public void SetFirstPage(int firstPage = 0)
		{
		}

		public bool ToNextPage()
		{
			return false;
		}

		public bool ToPrevPage()
		{
			return false;
		}

		public void SetScrollDisabled()
		{
		}

		public bool IsContainViewport(GameObject entity)
		{
			return false;
		}

		private void OnIdxChanged()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void OnReleaseDrag(int idx)
		{
		}

		private void ChangePage(int diff)
		{
		}

		private void RearrangeTemplate(int idxDiff)
		{
		}
	}
}
