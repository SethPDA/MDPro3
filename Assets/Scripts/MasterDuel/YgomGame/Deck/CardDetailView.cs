using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class CardDetailView : MonoBehaviour
	{
		public abstract class ElementWidget : MonoBehaviour
		{
			protected ElementObjectManager m_Eom;

			protected bool isInitialized;

			public bool isIni => false;

			public void Initialize()
			{
			}

			private void Awake()
			{
			}

			protected abstract void InitializeElements();
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

		public class CardArea : ElementWidget
		{
			private int m_CardID;

			private CardCollectionInfo.Premium m_Premium;

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

			public SelectionButton m_CardButton
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

			public Image m_RentalImage
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

			public RectTransform m_CardNumRoot
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

			public void SetCard(int cardId, CardCollectionInfo.Premium premium)
			{
			}

			protected override void InitializeElements()
			{
			}

			private void InitializeCardImage()
			{
			}

			private void InitializeCardNumText()
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

			public GameObject m_RentalCardText;

			private ElementObjectManager m_PremiumNumGroupEom;

			private ExtendedTextMeshProUGUI m_PremNum0;

			private ExtendedTextMeshProUGUI m_PremNum1;

			private ExtendedTextMeshProUGUI m_PremNum2;

			private Image m_PremSelector0;

			private Image m_PremSelector1;

			private Image m_PremSelector2;

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

			public RectTransform m_SpellTrapTypeRoot
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

			public RectTransform m_DismantleableRoot
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

			public ExtendedTextMeshProUGUI m_DismantleableValueText
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

			public void SetAsRental(bool isRental, bool dispDismantleableText = false)
			{
			}

			public void SetPrems(int cardId, CardCollectionInfo.Premium prem, bool isRental)
			{
			}

			protected override void InitializeElements()
			{
			}
		}

		private class MenuArea : ElementWidget
		{
			private class CraftButtonWidget : ElementWidget
			{
				public SelectionButton m_Button;

				public Transform m_CPGroup;

				public ExtendedTextMeshProUGUI m_ButtonText;

				public Image m_IconCP;

				public ExtendedTextMeshProUGUI m_TextCP;

				public Image m_IconEnabled;

				public Image m_IconDisabled;

				protected override void InitializeElements()
				{
				}
			}

			private RectTransform m_BookmarkOn;

			private RectTransform m_BookmarkOff;

			private CraftButtonWidget m_CraftCreateButton;

			private CraftButtonWidget m_CraftDismantleButton;

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

			public SelectionButton m_CreateButton => null;

			public SelectionButton m_DismantleButton => null;

			public RectTransform m_CardGroupRoot
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

			public RectTransform m_MenuGroupRoot
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

			public RectTransform m_CraftGroupRoot
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

			private void InitializeCraftElements()
			{
			}

			public void SetCraftable(bool craftable, int rarityID)
			{
			}

			public void SetDismantable(bool dismantable, int rarityID, CardCollectionInfo.Premium premium)
			{
			}
		}

		private ElementObjectManager m_Eom;

		private ElementObjectManager m_eom;

		private bool isIni;

		protected int m_Rarity;

		protected CardIconSprites m_CardIconSprites;

		private TitleArea m_TitleArea;

		protected CardArea m_CardArea;

		private ParameterArea m_ParameterArea;

		private MenuArea m_MenuArea;

		private const string LABEL_SB_WINDOW = "Window";

		protected const string LABEL_Tween_AutoScroll = "AutoScroll";

		protected Material m_TextBGMaterial;

		protected ContentSizeFitter m_DescTextSizeFitter;

		protected SelectionButtonUntouchable m_Window;

		private UnityAction m_OnClickCraftCreate;

		private UnityAction m_OnClickCraftDismantle;

		private UnityAction m_OnClickRelatedCards;

		private UnityAction m_OnClickButtonBookmark;

		private UnityAction m_OnClickCheckSource;

		private UnityAction m_OnClickAddCard;

		private UnityAction m_OnClickRemoveCard;

		private UnityAction m_OnClickCardButton;

		public ToggleWidget bookmarkToggle;

		protected int m_CardID
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

		public CardBaseData card => default(CardBaseData);

		protected CardCollectionInfo.Premium m_Premium
		{
			[CompilerGenerated]
			get
			{
				return default(CardCollectionInfo.Premium);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool m_IsRental
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private static Content m_cci => null;

		protected Image m_AttrIcon => null;

		protected Image m_NameAreaBG => null;

		protected RubyTextGX m_CardName => null;

		protected RectTransform m_NameArea => null;

		protected SelectionButton m_CardButton => null;

		protected RawImage m_CardImage => null;

		protected Image m_RarityIcon => null;

		protected Image m_RegulationIcon => null;

		protected ExtendedTextMeshProUGUI m_CardTotalText => null;

		protected RectTransform m_CardNumRoot => null;

		protected Image m_TunerIcon => null;

		protected Image m_TypeIcon => null;

		protected Image m_PendScaleIcon => null;

		protected Image m_LvlIcon => null;

		protected Image m_RankIcon => null;

		protected Image m_LinkIcon => null;

		protected Image m_AtkIcon => null;

		protected Image m_DefIcon => null;

		protected ExtendedTextMeshProUGUI m_PendScaleText => null;

		protected ExtendedTextMeshProUGUI m_LvlText => null;

		protected ExtendedTextMeshProUGUI m_RankText => null;

		protected ExtendedTextMeshProUGUI m_LinkText => null;

		protected ExtendedTextMeshProUGUI m_AtkText => null;

		protected ExtendedTextMeshProUGUI m_DefText => null;

		protected RectTransform m_SpellTrapType => null;

		protected Image m_SpellTrapTypeIcon => null;

		protected ExtendedTextMeshProUGUI m_SpellTrapTypeText => null;

		protected RectTransform m_DismantleableRoot => null;

		protected ExtendedTextMeshProUGUI m_DismantleableValue => null;

		protected SelectionButton m_AddCardButton => null;

		protected SelectionButton m_RemoveCardButton => null;

		protected SelectionButton m_BookmarkButton => null;

		protected SelectionButton m_HowToGetButton => null;

		protected SelectionButton m_RelatedCardButton => null;

		protected SelectionButton m_CreateButton => null;

		protected SelectionButton m_DismantleButton => null;

		protected RectTransform m_MenuGroup => null;

		protected RectTransform m_CraftGroup => null;

		protected ExtendedTextMeshProUGUI m_DescText => null;

		protected ExtendedTextMeshProUGUI m_DescTitleText => null;

		protected Image m_DescAreaBG => null;

		protected ExtendedScrollRect m_TextAreaScroll => null;

		private ExtendedScrollRect m_TextArea
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

		private ExtendedTextMeshProUGUI m_CardDesc
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

		private ExtendedTextMeshProUGUI m_CardDescHeading
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

		private Image m_DescAreaBG_
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

		public void SetActiveButtonCraftCreate(bool active)
		{
		}

		public void SetActiveButtonCraftDismantle(bool active)
		{
		}

		protected void setCraftPoint(bool isRental = false)
		{
		}

		public void UpdateCraftPoint()
		{
		}

		protected void SetPrems(int cardId, CardCollectionInfo.Premium prem, bool isRental)
		{
		}

		private void OnDestroy()
		{
		}

		private void InitializeElements()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		protected void setCardImage()
		{
		}

		protected void setRentalCardImage(bool isRental, bool dispDismantleableText = false)
		{
		}

		protected void setCardName()
		{
		}

		protected void setTextBGMat()
		{
		}

		protected void setCardText()
		{
		}

		protected void setAttribute()
		{
		}

		protected void setAttack()
		{
		}

		protected void setDefence()
		{
		}

		protected void setTuner()
		{
		}

		protected void setPendulumScale()
		{
		}

		protected void setLevel()
		{
		}

		protected void setRank()
		{
		}

		protected void setLinkRating()
		{
		}

		protected void setType()
		{
		}

		protected void setSpellTrapType()
		{
		}

		protected void setRarity()
		{
		}

		protected void setDescriptionTitle()
		{
		}

		public void SetInventory(int rentalID = 0, bool isRental = false)
		{
		}

		protected void setDismantleableValue()
		{
		}

		protected void setRegulationIcon(int id)
		{
		}

		public void SetActiveButtons(bool b)
		{
		}

		public void SetBookmark(bool b)
		{
		}

		public void SetBlank(bool b)
		{
		}

		public virtual void SetCard(CardBaseData data, int rent = 0, int reg = -1, bool bookmark = false, bool dispDismantleableText = false)
		{
		}

		public void SetOnClickBookmarkCallBack(UnityAction callback)
		{
		}

		public void SetOnClickCreateCallBack(UnityAction callback)
		{
		}

		public void SetOnClickDismantleCallBack(UnityAction callback)
		{
		}

		public void SetOnClickRelatedCardsCallBack(UnityAction callback)
		{
		}

		public void SetOnClickCheckSourceCallBack(UnityAction callback)
		{
		}

		public void SetOnClickAddCardCallBack(UnityAction callback)
		{
		}

		public void SetActiveAddCard(bool enabled)
		{
		}

		public void SetOnClickRemoveCardCallBack(UnityAction callback)
		{
		}

		public void SetActiveRemove(bool enabled)
		{
		}

		public void SetOnClickCardImage(UnityAction callback)
		{
		}

		public void SetCardButtonShortcutKey(SelectorManager.KeyType keyMain, SelectorManager.KeyType keySub)
		{
		}

		public RectTransform GetCardImageRectTransform()
		{
			return null;
		}

		public void SetDimsmantleMode(bool b)
		{
		}

		public void SetActiveSubMenuButton(bool activeRelatedCard, bool activeSourceButton)
		{
		}

		public void SetActiveCardMenu(bool b)
		{
		}
	}
}
