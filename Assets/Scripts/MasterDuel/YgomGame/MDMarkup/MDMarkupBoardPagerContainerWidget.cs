using System;
using System.Collections;
using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupBoardPagerContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget
	{
		public class Context
		{
			public bool badge;

			public string dateStr;
		}

		private readonly string k_ELabel_MMATemplate;

		private readonly string k_ELabel_PagerGroup;

		private readonly string k_ELabel_NextButton;

		private readonly string k_ELabel_PrevButton;

		private readonly string k_TLabelPagingNextOut;

		private readonly string k_TLabelPagingBackOut;

		private readonly string k_TLabelPagingNextIn;

		private readonly string k_TLabelPagingBackIn;

		private int m_CacheLimit;

		private ElementObjectManager m_MMATemplate;

		private MDMarkupContentCustomBoardPageHandler m_Handler;

		private Context m_Context;

		private MDMarkupGraphFactory m_GraphFactory;

		private MDMarkupBoardContainer[] m_BoardContainers;

		private int m_Idx;

		private Queue<(int, MDMarkupBoardContainerWidget)> m_MMACaches;

		private SelectionButton prevButton => null;

		private SelectionButton nextButton => null;

		private string GetTLabelPagingOut(int direction)
		{
			return null;
		}

		private string GetTLabelPagingIn(int direction)
		{
			return null;
		}

		private bool ValidIdx(int idx)
		{
			return false;
		}

		private bool ContainCache(int idx)
		{
			return false;
		}

		private MDMarkupBoardContainerWidget TryGetCache(int idx)
		{
			return null;
		}

		public MDMarkupBoardPagerContainerWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(IMDMarkupContainer containerData)
		{
		}

		public void Output(MDMarkupGraphFactory graphFactory, Action onComplete)
		{
		}

		public void OnStart(Dictionary<string, object> args)
		{
		}

		private void OutputGraph(int idx, Action onComplete = null)
		{
		}

		private IEnumerator yOutputGraph(int idx, Action onComplete = null)
		{
			return null;
		}

		private IEnumerator yCreateMMA(int idx)
		{
			return null;
		}

		private IEnumerator yPlayOut(int prevIdx, int dstIdx)
		{
			return null;
		}

		private IEnumerator yPlayIn(int prevIdx, int dstIdx)
		{
			return null;
		}

		private void RefreshButtons()
		{
		}

		private void OnClickNext()
		{
		}

		private void OnClickPrev()
		{
		}
	}
}
