using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class SoundPlayableAsset : PlayableAsset
	{
		public string startLabel;

		public bool mute;

		public bool skipDuplicate;

		public LabeledPlayableController LabeledPlayableController;

		public override double duration => 0.0;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			var playable = ScriptPlayable<SoundPlayableBehaviour>.Create(graph);
			var behaviour = playable.GetBehaviour();
			behaviour.playableAsset = this;
			behaviour.startLabel = startLabel;
			behaviour.skipDuplicate = skipDuplicate;
			return playable;
		}
	}
}
