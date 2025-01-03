using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Willow
{
	[Serializable]
	public class ActiveObjectTrack : TrackAsset
	{
		public const string kTrackName = "Active Object Track";

		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
            return Playable.Create(graph, inputCount);
        }

		protected override void OnCreateClip(TimelineClip clip)
		{
			
		}

		private void ChangeDisplayName(TimelineClip clip)
		{
		}
	}
}
