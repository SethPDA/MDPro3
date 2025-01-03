using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class SoundStopPlayableAsset : PlayableAsset
	{
		public string stopLabel;

		public float fade;

		public bool mute;

		public override double duration => 0.0;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}
	}
}
