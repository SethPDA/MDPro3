using System.Collections.Generic;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceController
	{
		public readonly SequenceBehaviourWork work;

		public readonly List<ISequenceBehaviour> behaviourList;

		private int m_BehaviourIdx;

		public bool isDone => false;

		public SequenceController(SequenceBehaviourWork work)
		{
		}

		public bool Update()
		{
			return false;
		}

		public void Skip()
		{
		}

		public bool OnBack()
		{
			return false;
		}
	}
}
