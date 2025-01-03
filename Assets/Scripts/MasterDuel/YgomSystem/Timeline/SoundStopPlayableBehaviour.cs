using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class SoundStopPlayableBehaviour : PlayableBehaviour
	{
		public SoundStopPlayableAsset playableAsset;

		public string stopLabel;

		public bool skipDuplicate;

		public float fade;

		private bool stopped;

		public override void OnGraphStart(Playable playable)
		{
		}

		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}
	}
}
