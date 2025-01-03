using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class ShopPreviewContainer : ElementWidgetBase
	{
		private readonly string k_ELabelSummonCamera;

		private readonly string k_ELabelSummonFieldRoot;

		private readonly GameObject m_RootGo;

		private readonly Camera m_SummonCamera;

		private readonly GameObject m_SummonFieldRoot;

		private RenderTexture m_StrongSummonRenderTexture;

		private MonsterCutinEffect m_StrongSummonEffect;

		private Coroutine m_SummonPlayRoutine;

		public event Action onPlaySummonStart
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

		public event Action onPlaySummonEnd
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

		public ShopPreviewContainer(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Terminate()
		{
		}

		public void Release()
		{
		}

		public void PlayStrongSummon(RawImage rawImage, int mrk, Action onReady = null, Action onFinish = null)
		{
		}

		private IEnumerator yPlayStrongSummon(RawImage rawImage, int mrk, Action onReady = null, Action onFinish = null)
		{
			return null;
		}
	}
}
