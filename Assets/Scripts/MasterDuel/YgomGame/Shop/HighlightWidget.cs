using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class HighlightWidget : ElementWidgetBase
	{
		public interface IThumbWidget
		{
			ShopDef.HighlightType highlightType { get; }

			int page { get; }

			int idx { get; }

			bool isHead { get; }

			int widthAmount { get; }

			SelectionButton button { get; }

			GameObject playRoot { get; }

			SelectionButton playButton { get; }

			event Action<IThumbWidget> onClickEvent;

			event Action<IThumbWidget> onClickPlayEvent;
		}

		public class PageWidget : ElementWidgetBase
		{
			public abstract class ThumbBase : ElementWidgetBase//, IThumbWidget
			{
				private readonly string k_ELabel_ThumbButton;

				private readonly string k_ELabel_PlayRoot;

				private readonly string k_ELabel_PlayButton;

				public readonly int page;

				public readonly int idx;

				public BindingShopProductThumb bindingShopThumb;

				public SelectionButton button
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public GameObject playRoot
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public SelectionButton playButton
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public abstract int widthAmount { get; }

				public abstract ShopDef.HighlightType highlightType { get; }

				public bool isHead => false;

				public bool interactable
				{
					get
					{
						return false;
					}
					set
					{
					}
				}

				private int YgomGame_002EShop_002EHighlightWidget_002EIThumbWidget_002Epage => 0;

				private int YgomGame_002EShop_002EHighlightWidget_002EIThumbWidget_002Eidx => 0;

				public event Action<IThumbWidget> onClickEvent
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

				public event Action<IThumbWidget> onClickPlayEvent
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

				public ThumbBase(ElementObjectManager eom, int page, int idx, HighlightContext context)
					: base(null)
				{
				}

				private void OnClick()
				{
				}

				private void OnClickPlay()
				{
				}
			}

			public class CardThumbWidget : ThumbBase//, IThumbWidget
			{
				private readonly string k_ELabelCardImage;

				private readonly string k_ELabelRarityIcon;

				public readonly int mrk;

				public override int widthAmount => 0;

				public override ShopDef.HighlightType highlightType => default(ShopDef.HighlightType);

				public CardThumbWidget(ElementObjectManager eom, int page, int idx, HighlightContext context)
					: base(null, 0, 0, null)
				{
				}
			}

			public class WideThumbWidget : ThumbBase//, IThumbWidget
			{
				private readonly string k_ELabelThumbImage;

				public readonly string thumbPath;

				public override int widthAmount => 0;

				public override ShopDef.HighlightType highlightType => default(ShopDef.HighlightType);

				public WideThumbWidget(ElementObjectManager eom, int page, int idx, HighlightContext context)
					: base(null, 0, 0, null)
				{
				}
			}

			private readonly string k_ELabelCardThumbTemplate;

			private readonly string k_ELabelWideThumbTemplate;

			private readonly ElementObjectManager m_CardThumbTemplate;

			private readonly ElementObjectManager m_WideThumbTemplate;

			public PageWidget(ElementObjectManager eom)
				: base(null)
			{
			}

			public IThumbWidget CreateThumb(HighlightContext context, int page, int idx, int shopId, ShopSettings shopSettings)
			{
				return null;
			}

			private IThumbWidget CreateCardThumb(HighlightContext context, int page, int idx)
			{
				return null;
			}

			private IThumbWidget CreateWideThumb(HighlightContext context, int page, int idx)
			{
				return null;
			}
		}

		private readonly string k_ELabelPageTemplate;

		private readonly string k_IndicatorChildTemplate;

		private readonly string k_PrevButton;

		private readonly string k_NextButton;

		private readonly string k_PrevShortcutIcon;

		private readonly string k_NextShortcutIcon;

		private readonly int k_PageChildAmountMax;

		private readonly ScrollRectPageSnap m_PageSnap;

		private readonly SelectionButton m_PrevButton;

		private readonly SelectionButton m_NextButton;

		public readonly Selector selector;

		public IReadOnlyList<HighlightContext> contexts;

		public List<IThumbWidget> m_ThumbWidgets;

		public Action onUpInputCallback;

		public SelectionButton prevButton => null;

		public SelectionButton nextButton => null;

		public bool existPage => false;

		public bool shortcutIconVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<IThumbWidget> onClickThumbEvent
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

		public event Action<IThumbWidget> onClickPlayEvent
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

		public HighlightWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetContexts(IReadOnlyList<HighlightContext> contexts, ProductContext productCtx, ShopSettings shopSettings)
		{
		}

		private void UpdateButtons()
		{
		}

		private void PlayIndicatorsTween()
		{
		}

		private PageWidget CreatePageWidget(ElementObjectManager template)
		{
			return null;
		}

		private GameObject CreateIndicatorChild(GameObject template)
		{
			return null;
		}

		public void SelectItem(int idx, bool initializeSelection = false)
		{
		}

		private void MovePage(int dstPage)
		{
		}

		private IEnumerator yMovePage(int dstPage, Action onComplete)
		{
			return null;
		}
	}
}
