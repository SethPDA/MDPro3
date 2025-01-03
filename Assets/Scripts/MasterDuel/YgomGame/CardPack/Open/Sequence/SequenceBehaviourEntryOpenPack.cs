using YgomGame.CardPack.Open.Actor;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourEntryOpenPack : SequenceBehaviour
	{
		private readonly string k_LabelTrack;

		private readonly string k_CardPopLabelFormat;

		private readonly string k_CardPopFinishLabel;

		private readonly DrawPackData m_PackData;

		private CardPackPackActor m_BeforePackActor;

		private CardPackPackActor m_AfterPackActor;

		private double m_CardPopEndTime;

		private double m_CardPopFinishStartTime;

		private int m_TMStep;

		public SequenceBehaviourEntryOpenPack(SequenceBehaviourWork sequenceBehaviourWork, DrawPackData packData)
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
