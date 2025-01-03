using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor
{
	public class CardPackPackActorContainer : ActorContainerBase<CardPackPackActorContainer>
	{
		private readonly string k_ELabelLocatorFormat;

		private ActorBindingRefs m_BindingRefs;

		private Transform[] m_Locators;

		private readonly Dictionary<int, CardPackPackActor> m_ActorMap;

		public int locatorLength => 0;

		public static CardPackPackActorContainer Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public CardPackPackActor InsertActor(int idx, string packTexPath, ElementObjectManager pref)
		{
			return null;
		}

		public CardPackPackActor GetActor(int idx)
		{
			return null;
		}

		public Renderer GetPackHighlight(int idx)
		{
			return null;
		}

		public void RemoveAllActors()
		{
		}

		public CardPackPackActorContainer()
		{
			//((ActorContainerBase<>)(object)this)._002Ector();
		}
	}
}
