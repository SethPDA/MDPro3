using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class ScrollRectPageSnap : MonoBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler
	{
		[SerializeField]
		public int m_HorizontalPages;

		[SerializeField]
		public int m_VerticalPages;

		public bool wheelScrollEnable;

		[SerializeField]
		public Tween.Easing easing;

		[SecField]
		[SerializeField]
		public float duration;

		[SerializeField]
		public float sensitivity;

		[SerializeField]
		public float backlash;

		[SerializeField]
		public UnityEvent onPageChanged;

		[SerializeField]
		public UnityEvent onPageTotalChanged;

		public Action<int> onReleaseDragCallback;

		private int draggingId;

		private ScrollRect scrollrect;

		private float tweenTime;

		private float tweenMaxTime;

		private Vector2 startNormalized;

		private Vector2 endNormalized;

		private int vpage;

		private int hpage;

		private int vspage;

		private int hspage;

		private List<bool> hpageEnableList;

		private List<bool> vpageEnableList;

		private bool isBarDragging;

		public bool dragScrollEnabled;

		public int horizontalPages
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int verticalPages
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int hPage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int vPage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isDragging => false;

		public bool isTweening => false;

		public ScrollRect target => null;

		private void Start()
		{
		}

		public void OnScroll(PointerEventData eventData)
		{
		}

		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public int calcPageIndex(float norm, int pages, int startpage)
		{
			return 0;
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void ReleaseDrag(Vector2 delta)
		{
		}

		private void Awake()
		{
		}

		private void OnStartBarDrag()
		{
		}

		private void OnBarDragging()
		{
		}

		private void OnEndBarDrag()
		{
		}

		private void CalcPositionToPage()
		{
		}

		private void Update()
		{
		}

		private void ChangeNormalized(float ex, float ey)
		{
		}

		public void SetVPageEnable(bool enable, int page = -1)
		{
		}

		public void SetHPageEnable(bool enable, int page = -1)
		{
		}

		public void ForceSnap()
		{
		}

		public void LoopHorizontal()
		{
		}

		public void PseudoLoopHorizontalView()
		{
		}
	}
}
