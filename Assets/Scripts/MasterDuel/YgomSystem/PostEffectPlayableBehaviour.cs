using UnityEngine.Playables;
using UnityEngine.Rendering;

namespace YgomSystem
{
	public class PostEffectPlayableBehaviour : PlayableBehaviour
	{
		public Volume volume;

		public VolumeProfile volumeProfile;

		public PlayableDirector playableDirector;

		public override void OnGraphStart(Playable playable)
		{
		}

		public override void OnGraphStop(Playable playable)
		{
		}

		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}
	}
}
