using UnityEngine.Playables;

namespace YgomGame.CardPack.Open.Sequence
{
	public class SequenceBehaviourPlayTM : SequenceBehaviour
	{
		private PlayableAsset m_PlayableAsset;

		protected override bool isAcceptToSkipLoop => false;

		public SequenceBehaviourPlayTM(SequenceBehaviourWork sequenceBehaviourWork, PlayableAsset playableAsset)
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
