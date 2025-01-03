using System.Collections.Generic;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourPacksEntryStart : SequenceBehaviour
	{
		private readonly bool m_isBegin;

		private readonly int m_PackTotal;

		private readonly int m_PackIdx;

		private readonly List<DrawPackData> m_DrawPackDatas;

		private readonly int m_SmokeType;

		private readonly bool m_IsPickup;

		private readonly int m_LabelType;

		private readonly string m_LabelText;

		public SequenceBehaviourPacksEntryStart(SequenceBehaviourWork sequenceBehaviourWork, bool isBegin, int packTotal, int packIdx, List<DrawPackData> drawPackDatas, int smokeType, bool isPickup, int labelType, string labelText)
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

		public override bool OnBack()
		{
			return false;
		}
	}
}
