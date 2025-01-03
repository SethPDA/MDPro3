using YgomGame.Card;
using YgomGame.CardPack.Open.Actor;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourPackOpenShakeUpgrade : SequenceBehaviour
	{
		private readonly CardCollectionInfo.Rarity m_FromPackType;

		private readonly CardCollectionInfo.Rarity m_DstPackType;

		private string m_PackImagePath;

		private CardPackPackActor m_BeforePackActor;

		private CardPackPackActor m_AfterActor;

		protected override bool isAcceptToSkipLoop => false;

		public SequenceBehaviourPackOpenShakeUpgrade(SequenceBehaviourWork sequenceBehaviourWork, string packImagePath, CardCollectionInfo.Rarity fromPackType, CardCollectionInfo.Rarity dstPackType)
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
