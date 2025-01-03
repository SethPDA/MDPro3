using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Extension
{
	public static class PlayableAssetExtension
	{
		public static Dictionary<string, TimelineClip> CollectTrackClipsMap(this PlayableAsset playableAsset, string trackName)
		{
			return null;
		}

		public static TrackAsset FindTrack(this PlayableAsset playableAsset, string trackName)
		{
			return null;
		}

		public static TimelineClip FindClicp(this TrackAsset trackAsset, string clipName)
		{
			var clips = trackAsset.GetClips();
            foreach (var clip in clips)
            {
                if(clip.displayName == clipName)
					return clip;
            }
            return null;
		}

		public static PlayableDirector GetSourcePlayableDirector(this ControlPlayableAsset controlClip, PlayableDirector director)
		{
			return null;
		}
	}
}
