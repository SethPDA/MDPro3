namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourPacksEntryNext : SequenceBehaviour
	{
		private readonly int m_PackTotal;

		private readonly int m_PackIdx;

		private readonly DrawPackData m_DrawPackData;

		public SequenceBehaviourPacksEntryNext(SequenceBehaviourWork sequenceBehaviourWork, int packTotal, int packIdx, DrawPackData drawPackData)
			: base(null)
		{
		}

		protected override void OnBegin()
		{
		}

		protected override bool OnUpdate()
		{
			return false;
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
