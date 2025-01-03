using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

namespace YgomSystem
{
	[Serializable]
	public class PostEffectPlayableAsset : PlayableAsset
	{
		public ExposedReference<Volume> Volume;

		public ExposedReference<VolumeProfile> VolumeProfile;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}
	}
}
