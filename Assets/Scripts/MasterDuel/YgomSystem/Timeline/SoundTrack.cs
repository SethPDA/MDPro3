using System;
using UnityEngine;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	[TrackColor(0, 1, 1)]
	[TrackClipType(typeof(SoundPlayableAsset))]
	public class SoundTrack : TrackAsset
	{
		public void StopAllSound()
		{
		}

		public void SetMute(bool mute)
		{
		}
	}
}
