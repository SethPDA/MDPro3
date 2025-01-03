using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	public class DetachedAnimationPlayableAsset : PlayableAsset
	{
		public DetachedAnimationPlayableBehaviour template;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}
	}
}
