using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.MDMarkup
{
	public class MDMarkupGraphWidget : MonoBehaviour
	{
		private MDMarkupGraphFactory m_MarkupGraphFactory;

		private readonly int k_TMPGryphTryAddSpan;

		private readonly Stack<MDMarkupIndentWidget> m_IndentStack;

		private List<object> m_CardMrks;

		private List<object> m_CardPremires;

		private List<IMDMarkupWidget> m_ContentWidgets;

		private Queue<IMDMarkupContent> m_ContentRequestQueue;

		private Coroutine m_OutputCoroutine;

		public List<IMDMarkupWidget> contentWidgets => null;

		public bool isReady => false;

		public event Action<MDMarkupGraphWidget> onOutputCompleteEvent
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

		public static MDMarkupGraphWidget Create(Transform owner, MDMarkupGraphFactory graphFactory = null)
		{
			return null;
		}

		public static MDMarkupGraphWidget Create(GameObject owner, MDMarkupGraphFactory graphFactory = null)
		{
			return null;
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void InsertContents(IReadOnlyList<IMDMarkupContent> contentDatas)
		{
		}

		public void InsertContent(IMDMarkupContent mdMarkupContent)
		{
		}

		public void Output(Action onComplete = null)
		{
		}

		private IEnumerator yOutput(Action onComplete = null)
		{
			return null;
		}

		private MDMarkupIndentWidget ProcessIndent(int targetIndent)
		{
			return null;
		}

		private void OnClickCard(int cardIdx)
		{
		}

		private void OnClickItem(bool isPeriod, int itemCategory, int itemId)
		{
		}

		private void OnClickLink(string link)
		{
		}
	}
}
