using System;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class LabelClipEX : LabelClip
	{
		public bool overrideWrapMode;

		public LabelDirectorWrapMode wrapmode;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
            var playable = ScriptPlayable<LabelBehaviour>.Create(graph);
            template = playable.GetBehaviour();
            return playable;
        }
    }
}
