using UnityEngine.UI;

namespace YgomSystem.Home
{
	public class ActiveFalseTargetWithRawImage : ActiveFalseTarget<RawImage>
	{
		protected override bool IsActive()
		{
			return false;
		}

		public ActiveFalseTargetWithRawImage()
		{
			//((ActiveFalseTarget<>)(object)this)._002Ector();
		}
	}
}
