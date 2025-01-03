using System;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class SkipClip : PlayableAsset
	{
		public SkipBehaviour template;

		[NonSerialized]
		public double endTime;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}
	}
}
