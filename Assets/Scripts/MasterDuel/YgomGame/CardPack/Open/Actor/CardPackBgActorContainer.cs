using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor
{
	public class CardPackBgActorContainer : ActorContainerBase<CardPackBgActorContainer>
	{
		private readonly string k_ELabelBGSmoke01;

		private readonly string k_ELabelBGSmoke02;

		private readonly string k_ELabelBGSmoke03;

		private readonly string k_ELabelScrollBg;

		private readonly string k_ELabelScrollBgSub;

		private readonly string k_ELabelBottomBg;

		private readonly string k_ELabelBottomBgSub;

		private SpriteRenderer m_ScrollBgRenderer;

		private SpriteRenderer m_ScrollBgSubRenderer;

		private SpriteRenderer m_BottomBgRenderer;

		private SpriteRenderer m_BottomBgSubRenderer;

		public SpriteRenderer scrollBgRenderer => null;

		public SpriteRenderer scrollBgSubRenderer => null;

		public SpriteRenderer bottomBgRenderer => null;

		public SpriteRenderer bottomBgSubRenderer => null;

		public void SetSmokeType(int smokeType)
		{
		}

		public static CardPackBgActorContainer Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public CardPackBgActorContainer()
		{
			//((ActorContainerBase<>)(object)this)._002Ector();
		}
	}
}
