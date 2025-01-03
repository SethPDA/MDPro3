using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourLoadCards : SequenceBehaviour
	{
		private readonly GameObject m_Owner;

		private readonly List<int> m_Mrks;

		private bool m_IsDone;

		protected override bool isAcceptToSkipLoop => false;

		public SequenceBehaviourLoadCards(SequenceBehaviourWork sequenceBehaviourWork, GameObject owner, List<int> mrks)
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

		protected override void OnEnd()
		{
		}
	}
}
