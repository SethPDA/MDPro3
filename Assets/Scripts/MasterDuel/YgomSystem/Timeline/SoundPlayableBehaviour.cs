using MDPro3;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class SoundPlayableBehaviour : PlayableBehaviour
	{
		public SoundPlayableAsset playableAsset;

		public string startLabel;

		public bool skipDuplicate;

		public override void OnGraphStart(Playable playable)
		{

        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
            AudioManager.PlaySE(startLabel);
        }
    }
}
