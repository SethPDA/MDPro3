using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.CardPack.Open.Widget
{
	public class CardPackFoundKey : MonoBehaviour
	{
		private SpriteRenderer m_KeyTemplate;

		private readonly List<SpriteRenderer> m_KeyCaches;

		private int m_Idx;

		private int m_FoundCnt;

		private Action<CardPackFoundKey> m_OnFinishCallback;

		[NonSerialized]
		public int sortingOrderBase;

		public int foundCnt => 0;

		public void Initialize(int idx, SpriteRenderer keyTemplate)
		{
		}

		public void SetPlay(int foundCnt, Action<CardPackFoundKey> onFinishCallback)
		{
		}

		private void OnDisable()
		{
		}
	}
}
