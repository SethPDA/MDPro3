using System;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class PauseClip : PlayableAsset
	{
		public PauseBehaviour template;

		[NonSerialized]
		public double startTime;

		[NonSerialized]
		public double endTime;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}
	}
}
