using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.CardPack;
using YgomGame.Duel;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class ProductViewerWidget : ElementWidgetBase, ILoadingIconHandler
	{
		public class ThumbWidget : ElementWidgetBase
		{
			private const string k_GLabel_DXIcon_Default = "DXIcon_Default";

			private const string k_GLabel_DXIcon_UpperLimitDate = "DXIcon_UpperLimitDate";

			public readonly BindingShopProductThumb bindingShopThumb;

			public readonly BindingMateRenderTexture mateBinder;

			public readonly RawImage summonRawImage;

			public readonly SelectionButton mateButton;

			public readonly GameObject dxIconRoot;

			public bool isSpProduct;

			public BindingGameObjectEx dxIconBinding;

			public void ForceFinishTween()
			{
			}

			public override void Clear()
			{
			}

			public bool IsExistsThumb()
			{
				return false;
			}

			public bool IsExistsSummon()
			{
				return false;
			}

			public bool isReady()
			{
				return false;
			}

			public ThumbWidget(ElementObjectManager eom, bool isMain)
				: base(null)
			{
			}

			public void SwitchDXIconOverriderGroup(bool isExistsLimitDate)
			{
			}

			public void SetActivateByContext(HighlightContext context)
			{
			}

			public void SetActivateToMate()
			{
			}

			public void SetActivateToSummon()
			{
			}

			public void SetActivateToThumb()
			{
			}

			public IAsyncProgressContent ApplyContext(HighlightContext highlightContext)
			{
				return null;
			}

			public void CaptureTo(ThumbWidget target)
			{
			}
		}

		public interface IThumbPlayer
		{
			bool enabled { get; }

			IAsyncProgressContent asyncProgressContent { get; }

			HighlightContext context { get; }

			IEnumerator yPlay(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub);

			void SetImmediate(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub);
		}

		public class ThumbPlayer// : IThumbPlayer
		{
			private readonly string k_TweenFadeInThumb;

			private readonly string k_TweenRollWaitThumb;

			private readonly string k_TweenRollSwapThumb;

			private readonly HighlightContext m_Context;

			public bool enabled;

			private AsyncContainContent m_AsyncContainContent;

			private bool YgomGame_002EShop_002EProductViewerWidget_002EIThumbPlayer_002Eenabled => false;

			public IAsyncProgressContent asyncProgressContent => null;

			public HighlightContext context => null;

			public ThumbPlayer(HighlightContext context)
			{
			}

			public IEnumerator yPlay(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
			{
				return null;
			}

			public void SetImmediate(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
			{
			}
		}

		public class SummonPlayer// : IThumbPlayer
		{
			private readonly ShopPreviewContainer m_PreviewContainer;

			private readonly HighlightContext m_Context;

			public bool enabled;

			public string bgThumbPath;

			private AsyncProgressLoadingCountContent m_AsyncLoadingCountContent;

			private bool YgomGame_002EShop_002EProductViewerWidget_002EIThumbPlayer_002Eenabled => false;

			public IAsyncProgressContent asyncProgressContent => null;

			public HighlightContext context => null;

			public SummonPlayer(ShopPreviewContainer previewContainer, HighlightContext context)
			{
			}

			public IEnumerator yPlay(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
			{
				return null;
			}

			public void SetImmediate(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
			{
			}
		}

		public readonly ThumbWidget thumbMain;

		public readonly ThumbWidget thumbSub;

		public readonly RawImage summonRawImage;

		public readonly GameObject infoRoot;

		public readonly GameObject limitGroup;

		public readonly TMP_Text limitText;

		public readonly GameObject limitDateGroup;

		public readonly TMP_Text limitDateText;

		public readonly GameObject numGroup;

		public readonly TMP_Text numText;

		public readonly CardPackChartWidget chartWidget;

		public readonly GameObject packPickupMessageGroup;

		public readonly TMP_Text packPickupMessage;

		public readonly GameObject loadingCoverRoot;

		private Coroutine m_ThumbRollRoutine;

		private int m_CurrentIdx;

		private int m_DstIdx;

		public int loopStartIdx;

		public int loopBreakIdx;

		private IReadOnlyList<IThumbPlayer> m_ThumbPlayers;

		public bool reverseFrag;

		private ProductContext m_ProductCtx;

		public IReadOnlyList<IThumbPlayer> thumbPlayers => null;

		public bool enabledThumbAspectRatio
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int currentIdx
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isPlayingThumbRoll => false;

		public event Action onChangeIdxEvent
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

		public event Action onReloadEvent
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

		public int GetNextIdx(int baseIdx)
		{
			return 0;
		}

		public int IndexOfContext(HighlightContext context)
		{
			return 0;
		}

		public int IndexOfPlayContext(HighlightContext context)
		{
			return 0;
		}

		public bool IsDone()
		{
			return false;
		}

		public ProductViewerWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Initialize(IReadOnlyList<IThumbPlayer> thumbPlayers, int previewMateId, bool isSpProduct, ProductContext productCtx)
		{
		}

		public void PlayThumbRoll(int startIdx)
		{
		}

		public void PlayThumbOnce(int startIdx, int dstIdx = -1)
		{
		}

		private IEnumerator yPlayCardThumbRoll()
		{
			return null;
		}

		public void StopThumbRoll()
		{
		}

		public void SetThumb(int idx)
		{
		}

		public void PlayMateMotion(AvatarMotionSetting.MotionID motionId)
		{
		}

		private void UpdateLoadingCoverVisible(HighlightContext context)
		{
		}
	}
}
