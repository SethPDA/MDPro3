using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline
{
	public static class TimelineUtlity
	{
		public static TrackAsset GetTrackAsset(this PlayableDirector pd, string tracklabel)
		{
			return null;
		}

		public static TimelineClip GetTimelineClip(this TrackAsset ta, string cliplabel)
		{
			return null;
		}

		public static TimelineClip GetTimelineClip(this PlayableDirector pd, string tracklabel, string cliplabel)
		{
			return null;
		}

		public static TimelineClip GetTimelineClip(this PlayableDirector pd, string cliplabel)
		{
			return null;
		}

		public static SignalEmitter GetSignalEmitter(this PlayableDirector pd, string label)
		{
			return null;
		}

		public static T GetTrack<T>(this PlayableDirector pd) where T : TrackAsset
		{
			return null;
		}

		public static List<T> GetTracks<T>(this PlayableDirector pd) where T : TrackAsset
		{
			return null;
		}

		public static TrackAsset GetTrack(this PlayableDirector pd, string label)
		{
			return null;
		}

		public static List<TrackAsset> GetTracks(this PlayableDirector pd, string label)
		{
			return null;
		}

		public static T GetTrack<T>(this PlayableDirector pd, string label) where T : TrackAsset
		{
			return null;
		}

		public static List<T> GetTracks<T>(this PlayableDirector pd, string label) where T : TrackAsset
		{
			return null;
		}

		public static void SetSpeed(this PlayableDirector pd, double speed)
		{
		}
	}
}
