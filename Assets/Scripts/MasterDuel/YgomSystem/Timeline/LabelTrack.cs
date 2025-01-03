using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	[TrackClipType(typeof(LabelClip))]
	public class LabelTrack : TrackAsset
	{
		protected override void OnCreateClip(TimelineClip clip)
		{
		}

		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			var playable = ScriptPlayable<LoopMixerBehaviour>.Create(graph, inputCount);
			var behaviour = playable.GetBehaviour();

			behaviour.loopClips = new List<TimelineClip>();
			var clips = GetClips();
			foreach(var clip in clips)
			{
				if(clip.asset is LabelClipEX clipEx)
				{
					if(clipEx.wrapmode == LabelDirectorWrapMode.Loop)
                        behaviour.loopClips.Add(clip);
                }
			}
			behaviour.track = this;
            return playable;
		}
	}
}
