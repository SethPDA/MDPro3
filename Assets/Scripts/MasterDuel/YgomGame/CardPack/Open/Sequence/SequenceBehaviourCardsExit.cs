namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourCardsExit : SequenceBehaviour
	{
		protected override bool isAcceptToSkipLoop => false;

		public SequenceBehaviourCardsExit(SequenceBehaviourWork sequenceBehaviourWork)
			: base(null)
		{
		}

		protected override bool OnUpdate()
		{
			return false;
		}
	}
}
