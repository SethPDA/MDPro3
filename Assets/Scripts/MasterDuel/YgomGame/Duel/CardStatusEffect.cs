using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardStatusEffect : DuelEffectHandle
	{
		private MeshAlphaFader alphaFader;

		private TextMesh textMesh;

		private bool m_isPlaying;

		private int m_order;

		private bool m_showOrder;

		public override bool isPlaying => false;

		public float fadeDulation
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int order
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool showOrder
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnInitialize()
		{
		}

		protected override void OnTerminate()
		{
		}

		protected override void OnPlay()
		{
		}

		protected override void OnStop()
		{
		}

		public virtual void SetTarget(ICardStatusIconAnchor anchor)
		{
		}

		public void Show(Action onFinished)
		{
		}

		public void Hide(Action onFinished)
		{
		}
	}
}
