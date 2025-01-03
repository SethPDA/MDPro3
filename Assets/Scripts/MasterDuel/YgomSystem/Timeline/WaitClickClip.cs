using System;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class WaitClickClip : PlayableAsset
	{
		public WaitClickBehaviour template;

		[NonSerialized]
		public double startTime;

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
