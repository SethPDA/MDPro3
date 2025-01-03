using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
    [TrackClipType(typeof(LoopClip))]
    public class LoopTrack : TrackAsset
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
            foreach (var clip in clips)
            {
                if (clip.asset is LoopClip)
                {
                    behaviour.loopClips.Add(clip);
                }
            }
            return playable;
        }
    }
}
