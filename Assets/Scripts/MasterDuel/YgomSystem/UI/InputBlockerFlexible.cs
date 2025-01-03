namespace YgomSystem.UI
{
	public class InputBlockerFlexible : AbstractInputBlocker
	{
		public int _blockPriority;

		protected override int blockPriority => 0;

		public void SetBlockPriority(int priority)
		{
		}
	}
}
