using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor
{
	public class CardPackInfoActorContainer : ActorContainerBase<CardPackInfoActorContainer>
	{
		private readonly string k_ELabelLabelRoot;

		private readonly string k_ELabelLabelRoot_LabelBand;

		private readonly string k_ELabelLabelRoot_LabelText;

		internal const string k_TLabelShow = "Show";

		internal const string k_TLabelHide = "Hide";

		private ActorBindingRefs m_BindingRefs;

		private ElementObjectManager m_LabelRootEom;

		public static CardPackInfoActorContainer Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void SetLabel(int bandStyle, string labelText)
		{
		}

		public void PlayLabelTween(string tweenKey)
		{
		}

		public CardPackInfoActorContainer()
		{
			//((ActorContainerBase<>)(object)this)._002Ector();
		}
	}
}
