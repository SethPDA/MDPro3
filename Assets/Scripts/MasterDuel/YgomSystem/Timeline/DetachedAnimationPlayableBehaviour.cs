using System;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class DetachedAnimationPlayableBehaviour : PlayableBehaviour
	{
		public AnimationClip animClip;

		[NonSerialized]
		public Animator target;

		private PlayableGraph m_PlayableGraph;

		public override void OnPlayableCreate(Playable playable)
		{
		}

		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		public override void OnPlayableDestroy(Playable playable)
		{
		}
	}
}
