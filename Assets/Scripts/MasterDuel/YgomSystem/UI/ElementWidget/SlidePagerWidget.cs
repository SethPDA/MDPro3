using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;

namespace YgomSystem.UI.ElementWidget
{
	public class SlidePagerWidget : ElementWidgetBehaviourBase<SlidePagerWidget>
	{
		private readonly string k_ELabelIndicatorTemplate;

		private readonly string k_ELabelPrevButton;

		private readonly string k_ELabelNextButton;

		[SerializeField]
		private string m_TweenIndicatorOn;

		[SerializeField]
		private string m_TweenIndicatorOff;

		private ScrollRectPageSnap m_PageSnap;

		private SelectionButton m_PrevButton;

		private SelectionButton m_NextButton;

		private List<GameObject> m_Indicators;

		private Coroutine m_yMovePageRoutine;

		private Selector m_Selector;

		private InfinityScrollView m_Isv;

		private List<SelectionItem> m_TmpOrderItems;

		public int startPage;

		public bool isLoop;

		public ScrollRectPageSnap pageSnap => null;

		public SelectionButton prevButton => null;

		public SelectionButton nextButton => null;

		public event Action onPageChanged
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

		private bool IsValidIdx(int idx)
		{
			return false;
		}

		private bool IsEnablePrev()
		{
			return false;
		}

		private bool IsEnableNext()
		{
			return false;
		}

		public static SlidePagerWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		private void Start()
		{
		}

		public void SetPageTotal(int pageTotal)
		{
		}

		private void PlayIndicatorTween(bool immediate = false)
		{
		}

		private void UpdateButtons()
		{
		}

		public void InitMovePage(Selector seletor, InfinityScrollView isv)
		{
		}

		public bool MovePage(int dstPage)
		{
			return false;
		}

		private void OnClickNext()
		{
		}

		private void OnClickPrev()
		{
		}

		private void OnPageChanged()
		{
		}

		private IEnumerator yMovePage(int dstPage, Action onComplete = null)
		{
			return null;
		}

		public SlidePagerWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
