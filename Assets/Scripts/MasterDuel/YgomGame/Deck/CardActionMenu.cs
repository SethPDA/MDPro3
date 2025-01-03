using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class CardActionMenu : CardUtilWidget
	{
		public enum TweenType
		{
			Open = 0,
			Close = 1,
			Update = 2,
			Prev = 3,
			Next = 4
		}

		private class TitleArea : ElementWidget
		{
			public RubyTextGX m_CardName
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

			public RectTransform m_NameArea
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

			public Image m_NameAreaBG
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

			public Image m_AttrIcon
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

			protected override void InitializeElements()
			{
			}
		}

		private class ParameterArea : ElementWidget
		{
			public class ParamIcon : ElementWidget
			{
				public Image m_IconImage
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

				public ExtendedTextMeshProUGUI m_IconText
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

				protected override void InitializeElements()
				{
				}
			}

			public ParamIcon m_TunerIcon
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

			public ParamIcon m_TypeIcon
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

			public ParamIcon m_PendScaleIcon
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

			public ParamIcon m_LvlIcon
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

			public ParamIcon m_RankIcon
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

			public ParamIcon m_LinkIcon
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

			public ParamIcon m_AtkIcon
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

			public ParamIcon m_DefIcon
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

			public RectTransform m_SpellTrapType
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

			public Image m_SpellTrapIconImage
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

			public ExtendedTextMeshProUGUI m_SpellTrapIconText
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

			protected override void InitializeElements()
			{
			}
		}

		private class DescriptionArea : ElementWidget
		{
			public ExtendedScrollRect m_PendulumTextArea
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

			public RectTransform m_PendulumDescArea
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

			public ExtendedTextMeshProUGUI m_CardDescPend
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

			public ExtendedTextMeshProUGUI m_CardDescHeadingPendulum
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

			public ExtendedScrollRect m_TextArea
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

			public ExtendedTextMeshProUGUI m_CardDesc
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

			public ExtendedTextMeshProUGUI m_CardDescHeading
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

			public Image m_DescAreaBG
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

			public Image m_PendulumDescAreaBG
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

			protected override void InitializeElements()
			{
			}
		}

		private class CardArea : ElementWidget
		{
			private int m_CardID;

			private CardCollectionInfo.Premium m_Premium;

			private Image m_RentalImage;

			private bool m_IsRental;

			private ElementObjectManager m_PremiumNumGroupEom;

			private ElementObject m_DismantleCardNumGroup;

			private ElementObject m_RentalCardTextGroup;

			private ExtendedTextMeshProUGUI m_PremNum0;

			private ExtendedTextMeshProUGUI m_PremNum1;

			private ExtendedTextMeshProUGUI m_PremNum2;

			private Image m_PremSelector0;

			private Image m_PremSelector1;

			private Image m_PremSelector2;

			private Image m_IndicatorRental;

			private Image m_Indicator0;

			private Image m_Indicator1;

			private Image m_Indicator2;

			private int inDeckR;

			private int inDeckN;

			private int inDeckP1;

			private int inDeckP2;

			private List<Image> m_IndicatorsR;

			private List<Image> m_IndicatorsN;

			private List<Image> m_IndicatorsP1;

			private List<Image> m_IndicatorsP2;

			private int inDeckAlterR;

			private int inDeckAlterN;

			private int inDeckAlterP1;

			private int inDeckAlterP2;

			private List<Image> m_IndicatorsAlterR;

			private List<Image> m_IndicatorsAlterN;

			private List<Image> m_IndicatorsAlterP1;

			private List<Image> m_IndicatorsAlterP2;

			public RawImage m_CardImage
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

			public Image m_LimitIcon
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

			public Image m_RarityIcon
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

			public ExtendedTextMeshProUGUI m_CardTotalText
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

			public ExtendedTextMeshProUGUI m_NonPrizeCardTotalText
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

			public void SetCard(int cardId, CardCollectionInfo.Premium premium, bool isRental)
			{
			}

			protected override void InitializeElements()
			{
			}

			private void InitializeCardImage()
			{
			}

			public void SetRentalImage(bool isRental)
			{
			}

			private void InitializeCardNumText()
			{
			}

			public void SetPrems()
			{
			}

			private void InitializeIndicator()
			{
			}

			public void SetInDeckSum(int numN, int alterN, int numP1, int alterP1, int numP2, int alterP2, int numR, int alterR)
			{
			}

			private void AdjustIndicator(int oldNum, int newNum, List<Image> list, Image template, bool isAlter = false)
			{
			}

			public void SetInDeckIndicatorColor(bool isFull)
			{
			}
		}

		private class CraftArea : ElementWidget
		{
			private class CraftButtonWidget : ElementWidget
			{
				public SelectionButton m_Button;

				public ExtendedTextMeshProUGUI m_ButtonText;

				public Image m_IconCP;

				public ExtendedTextMeshProUGUI m_TextCP;

				public Image m_IconEnabled;

				public Image m_IconDisabled;

				protected override void InitializeElements()
				{
				}
			}

			private CraftButtonWidget CraftCreateButton;

			private CraftButtonWidget CraftDismantleButton;

			public SelectionButton CreateButton => null;

			public SelectionButton DismantleButton => null;

			protected override void InitializeElements()
			{
			}

			public void SetCraftable(bool craftable, int rarityID)
			{
			}

			public void SetDismantable(bool dismantable, int rarityID, CardCollectionInfo.Premium premium)
			{
			}
		}

		private class MenuArea : ElementWidget
		{
			private RectTransform m_BookmarkOn;

			private RectTransform m_BookmarkOff;

			public SelectionButton m_BookmarkButton
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

			public SelectionButton m_HowToGetButton
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

			public SelectionButton m_RelatedCardButton
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

			public SelectionButton m_AddCardButton
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

			public SelectionButton m_RemoveCardButton
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

			public Selector m_Selector
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

			protected override void InitializeElements()
			{
			}

			public void ToggleBookmark(bool isBookmarked)
			{
			}

			public void SetActiveAddCardButtons(bool isActive)
			{
			}
		}

		private ElementObjectManager m_Eom;

		private bool isIni;

		private const string tweenLabelIn = "In";

		private const string tweenLabelOut = "Out";

		private SelectionButton m_PrevButton;

		private SelectionButton m_NextButton;

		private SelectionButton m_FlickButton;

		private bool horizontalSwipe;

		private Vector2 pressedPoint;

		private CardBaseData m_PrevCard;

		private CardBaseData m_NextCard;

		private DeckView m_DeckView;

		private CardCollectionView m_CollectionView;

		private bool fromDeck;

		private int regulationID;

		private int rentalID;

		private Action<CardActionMenu, CardBaseData> onInitAction;

		private CardCollectionInfo.Premium m_CurrentPremium;

		private bool m_CurrentRental;

		private int m_CurrentIdx;

		private TitleArea m_TitleArea;

		private ParameterArea m_ParameterArea;

		private DescriptionArea m_DescriptionArea;

		private CardArea m_CardArea;

		private CraftArea m_CraftArea;

		private MenuArea m_MenuArea;

		public CanvasGroup m_Window;

		public SelectionItem m_WindowItem;

		private SelectionButton m_ButtonBack;

		protected override Image m_AttrIcon => null;

		protected override Image m_TunerIcon => null;

		protected override Image m_TypeIcon => null;

		protected override Image m_SpellTrapTypeIcon => null;

		protected override Image m_PendScaleIcon => null;

		protected override ExtendedTextMeshProUGUI m_PendScaleText => null;

		protected override Image m_LvlIcon => null;

		protected override ExtendedTextMeshProUGUI m_LvlText => null;

		protected override Image m_RankIcon => null;

		protected override ExtendedTextMeshProUGUI m_RankText => null;

		protected override Image m_LinkIcon => null;

		protected override ExtendedTextMeshProUGUI m_LinkText => null;

		protected override Image m_AtkIcon => null;

		protected override ExtendedTextMeshProUGUI m_AtkText => null;

		protected override Image m_DefIcon => null;

		protected override ExtendedTextMeshProUGUI m_DefText => null;

		protected override RectTransform m_SpellTrapType => null;

		protected override ExtendedTextMeshProUGUI m_SpellTrapTypeText => null;

		protected override Image m_RegulationIcon => null;

		protected override Image m_RarityIcon => null;

		protected override ExtendedScrollRect m_TextArea => null;

		protected override ExtendedTextMeshProUGUI m_CardDesc => null;

		protected override ExtendedTextMeshProUGUI m_CardDescHeading => null;

		protected override Image m_DescAreaBG => null;

		protected override SelectionButton m_CreateButton => null;

		protected override SelectionButton m_DismantleButton => null;

		protected override SelectionButton m_AddCardButton => null;

		protected override SelectionButton m_RemoveCardButton => null;

		protected override SelectionButton m_BookmarkButton => null;

		protected override SelectionButton m_HowToGetButton => null;

		protected override SelectionButton m_RelatedCardButton => null;

		protected override Image m_NameAreaBG => null;

		protected override RubyTextGX m_CardName => null;

		private ExtendedScrollRect m_PendulumTextArea => null;

		private RectTransform m_PendulumDescArea => null;

		private ExtendedTextMeshProUGUI m_CardDescPend => null;

		private ExtendedTextMeshProUGUI m_CardDescHeadingPendulum => null;

		private Image m_PendulumDescAreaBG => null;

		public Action onClickPrevButton
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action onClickNextButton
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private int m_CurrentCardID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetActiveAddCardArea(bool isActive)
		{
		}

		public void SetActiveButtonCraftCreate(bool active)
		{
		}

		public void SetActiveButtonAddCard(bool active)
		{
		}

		public void SetActiveButtonRemoveCard(bool active)
		{
		}

		public void SetActiveButtonCraftDismantle(bool active)
		{
		}

		protected void SetCraftPoint()
		{
		}

		public void UpdateCraftPoint()
		{
		}

		public void ToggleBookmark(bool isBookmarked)
		{
		}

		public void SetActiveSubMenuButton(bool activeRelatedCard, bool activeSourceButton)
		{
		}

		public void InitializeElements()
		{
		}

		private void OnDestroy()
		{
		}

		private void Awake()
		{
		}

		private void InnerOpen(int id, int inDeckN, int inDeckAlterN, int inDeckP1, int inDeckAlterP1, int inDeckP2, int inDeckAlterP2, int inDeckR, int inDeckAlterR, bool isFull, CardCollectionInfo.Premium prem, bool isRental, bool isBatchDismantleMode, int reg, int rent, TweenType tweenType = TweenType.Open)
		{
		}

		public void Open(TweenType tweenType = TweenType.Open, Action onUpdate = null)
		{
		}

		public void Open(int cardID, int inDeckN, int inDeckAlterN, int inDeckP1, int inDeckAlterP1, int inDeckP2, int inDeckAlterP2, int inDeckR, int inDeckAlterR, CardCollectionInfo.Premium prem, bool isFull, bool isBatchDismantleMode, int regulationID, int rentalID)
		{
		}

		public void OpenFromCollectionView(int cardID, int premID, InDeckNumInfo inDeckInfo, bool isFull, bool isBatchDismantleMode, int regulationID, int rentalID, DeckView deckView, CardCollectionView collectionView, Action<CardActionMenu, CardBaseData> initAction, TweenType tweenType = TweenType.Open)
		{
		}

		public void OpenFromDeckView(int idx, InDeckNumInfo inDeckInfo, bool isFull, bool isBatchDismantleMode, int regulationID, int rentalID, DeckView deckView, CardCollectionView collectionView, Action<CardActionMenu, CardBaseData> initAction, TweenType tweenType = TweenType.Open)
		{
		}

		public void Close()
		{
		}

		private IEnumerator yPlayPaging(TweenType tweenType = TweenType.Next, Action onFinish = null, Action onUpdate = null)
		{
			return null;
		}

		public void PagingCheck(CardBaseData baseData, bool added)
		{
		}

		public void SetBatchDismantleMode(bool active)
		{
		}

		public void SetInteractableWindow(bool b)
		{
		}

		private new void setDescriptionHeading()
		{
		}

		protected void setCardText()
		{
		}

		protected new void setDescAreaBG()
		{
		}

		public void SetInDeckIndicators(int numN, int alterN, int numP1, int alterP1, int numP2, int alterP2, int numR, int alterR, bool isFull)
		{
		}

		public void SetInDeckIndicators(InDeckNumInfo inDeckInfo, bool isFull)
		{
		}

		public void SetPremiums()
		{
		}

		public void SetCardPremiumType(CardCollectionInfo.Premium prem)
		{
		}

		public void SetCardTotals(int rentalID = 0, bool isRental = false)
		{
		}

		public RectTransform GetCardImageRectTransform()
		{
			return null;
		}

		protected new void setRarity(bool b = true)
		{
		}

		public void SetRentalImageOverlay(bool active)
		{
		}
	}
}
