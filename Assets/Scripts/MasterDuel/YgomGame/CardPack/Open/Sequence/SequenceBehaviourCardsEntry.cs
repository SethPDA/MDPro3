using System.Collections.Generic;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourCardsEntry : SequenceBehaviour
	{
		private readonly DrawPackData m_DrawPackData;

		private double m_WaitSec;

		private List<int> m_ExistsPosList;

		protected override bool isAcceptToSkipLoop => false;

		public SequenceBehaviourCardsEntry(SequenceBehaviourWork sequenceBehaviourWork, DrawPackData drawPackData)
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
	}
}
