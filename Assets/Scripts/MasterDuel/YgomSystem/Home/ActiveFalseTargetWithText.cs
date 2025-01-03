using YgomSystem.YGomTMPro;

namespace YgomSystem.Home
{
	public class ActiveFalseTargetWithText : ActiveFalseTarget<ExtendedTextMeshProUGUI>
	{
		protected override bool IsActive()
		{
			return false;
		}

		public ActiveFalseTargetWithText()
		{
			//((ActiveFalseTarget<>)(object)this)._002Ector();
		}
	}
}
