namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourPackOpen : SequenceBehaviour
	{
		protected override bool isAcceptToSkipLoop => false;

		public SequenceBehaviourPackOpen(SequenceBehaviourWork sequenceBehaviourWork)
			: base(null)
		{
		}
	}
}
