using System;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class LabelMixerBehaviour : PlayableBehaviour
	{
		private PlayableDirector m_Director;

		private Dictionary<string, TimelineClip> m_TrackClips;

		public IReadOnlyDictionary<string, TimelineClip> trackClips => null;

		public void Initialize(IReadOnlyList<TimelineClip> trackClips)
		{
		}

		public override void OnPlayableCreate(Playable playable)
		{

		}
	}
}
