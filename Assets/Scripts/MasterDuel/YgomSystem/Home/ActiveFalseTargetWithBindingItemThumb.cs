using YgomGame.Menu.Common;

namespace YgomSystem.Home
{
	public class ActiveFalseTargetWithBindingItemThumb : ActiveFalseTarget<BindingItemThumb>
	{
		protected override bool IsActive()
		{
			return false;
		}

		public ActiveFalseTargetWithBindingItemThumb()
		{
			//((ActiveFalseTarget<>)(object)this)._002Ector();
		}
	}
}
