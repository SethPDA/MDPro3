using System;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class SkipClickClip : PlayableAsset
	{
		public SkipClickBehaviour template;

		[NonSerialized]
		public double endTime;

		[NonSerialized]
		public SelectionButton waitButton;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}
	}
}
