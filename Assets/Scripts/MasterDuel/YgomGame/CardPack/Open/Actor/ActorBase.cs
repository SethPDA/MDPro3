using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.Open.Actor
{
	public abstract class ActorBase<T> : ElementWidgetBehaviourBase<T>, IActor where T : ActorBase<T>
	{
		protected ActorBase()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
