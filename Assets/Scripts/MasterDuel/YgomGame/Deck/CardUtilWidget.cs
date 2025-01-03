using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public abstract class CardUtilWidget : CardParameterWidget
	{
		protected Material m_TextBGMaterial;

		protected UnityAction m_OnClickCraftCreate;

		protected UnityAction m_OnClickCraftDismantle;

		protected UnityAction m_OnClickRelatedCards;

		protected UnityAction m_OnClickButtonAddCard;

		protected UnityAction m_OnClickButtonRemoveCard;

		protected UnityAction m_OnClickBackButton;

		protected UnityAction m_OnClickButtonBookmark;

		protected UnityAction m_OnClickLootSource;

		protected abstract Image m_AtkIcon { get; }

		protected abstract ExtendedTextMeshProUGUI m_AtkText { get; }

		protected abstract Image m_DefIcon { get; }

		protected abstract ExtendedTextMeshProUGUI m_DefText { get; }

		protected abstract RectTransform m_SpellTrapType { get; }

		protected abstract ExtendedTextMeshProUGUI m_SpellTrapTypeText { get; }

		protected abstract ExtendedScrollRect m_TextArea { get; }

		protected abstract ExtendedTextMeshProUGUI m_CardDesc { get; }

		protected abstract ExtendedTextMeshProUGUI m_CardDescHeading { get; }

		protected abstract Image m_NameAreaBG { get; }

		protected abstract Image m_DescAreaBG { get; }

		protected abstract RubyTextGX m_CardName { get; }

		protected abstract SelectionButton m_CreateButton { get; }

		protected abstract SelectionButton m_DismantleButton { get; }

		protected abstract SelectionButton m_AddCardButton { get; }

		protected abstract SelectionButton m_RemoveCardButton { get; }

		protected abstract SelectionButton m_BookmarkButton { get; }

		protected abstract SelectionButton m_HowToGetButton { get; }

		protected abstract SelectionButton m_RelatedCardButton { get; }

		protected void setCardName()
		{
		}

		protected void setAttack()
		{
		}

		protected void setDefence()
		{
		}

		protected void setDescriptionHeading()
		{
		}

		private void setCardText()
		{
		}

		protected void setCardNameBG()
		{
		}

		protected void setDescAreaBG()
		{
		}

		protected void setSpellTrapType()
		{
		}

		public void SetOnClickAddToMainButtonCallBack(UnityAction callback)
		{
		}

		public void SetOnClickRemoveFromMainButtonCallBack(UnityAction callback)
		{
		}

		public void SetOnClickBookmarkButtonCallBack(UnityAction callback)
		{
		}

		public void SetOnClickCraftCreateButtonCallBack(UnityAction callback)
		{
		}

		public void SetOnClickCraftDismantleButtonCallBack(UnityAction callback)
		{
		}

		public void SetOnClickRelatedCardsButton(UnityAction callback)
		{
		}

		public void SetOnClickLootSourceButton(UnityAction callback)
		{
		}

		public void SetOnClickBackButton(UnityAction callback)
		{
		}
	}
}
