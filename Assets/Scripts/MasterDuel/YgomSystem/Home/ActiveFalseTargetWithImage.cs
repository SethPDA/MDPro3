using UnityEngine.UI;

namespace YgomSystem.Home
{
	public class ActiveFalseTargetWithImage : ActiveFalseTarget<Image>
	{
		protected override bool IsActive()
		{
			return false;
		}

		public ActiveFalseTargetWithImage()
		{
			//((ActiveFalseTarget<>)(object)this)._002Ector();
		}
	}
}
