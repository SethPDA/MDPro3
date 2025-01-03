using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Actor
{
	public class CardPackCardActorContainer : ActorContainerBase<CardPackCardActorContainer>
	{
		private readonly string k_ELabelLocatorFormat;

		private readonly string k_ELabelLocatorFoundKey;

		private readonly string k_ELabelLocatorFrontModel;

		private readonly string k_ELabelCardSlideEffectSet;

		private readonly string k_ELabelPickUpSet;

		private readonly string k_ELabelSelectHeadCardItem;

		private const string k_ELabelCardsCenteringLocator = "CardsCenteringLocator";

		private const string k_TLabelCardsCentering_Default = "Default";

		private const string k_TLabelCardsCentering_Modify = "Modify";

		private const string k_TLabelCardsCentering_Modify_01 = "Modify_01";

		private ActorBindingRefs m_BindingRefs;

		private Transform[] m_Locators;

		private GameObject[] m_SecretKeys;

		private GameObject m_CardSlideEffectSet;

		private GameObject m_PickUpGroupLabel;

		private readonly Dictionary<int, CardPackCardActor> m_ActorMap;

		public IReadOnlyList<CardPackCardActor> allCardActors => null;

		public SelectionItem selectHeadCardItem => null;

		public GameObject[] secretKeys => null;

		public bool cardSlideEffectVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool pickUpGroupLabelVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int LocatorLength => 0;

		public static CardPackCardActorContainer Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public int IndexOf(CardPackCardActor cardActor)
		{
			return 0;
		}

		public void SetCardCentering(bool isModify, int cardCnt)
		{
		}

		public CardPackCardActor InsertActor(int idx, ElementObjectManager pref)
		{
			return null;
		}

		public Renderer GetFrontEffectRenderer(int idx)
		{
			return null;
		}

		public CardPackCardActor GetActorByIdx(int idx)
		{
			return null;
		}

		public void RemoveAllActors()
		{
		}

		public bool SelectHeadActor()
		{
			return false;
		}

		public CardPackCardActorContainer()
		{
			//((ActorContainerBase<>)(object)this)._002Ector();
		}
	}
}
