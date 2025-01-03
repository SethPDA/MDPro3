using System;
using UnityEngine.Playables;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class PauseBehaviour : PlayableBehaviour
	{
		private PlayableDirector m_Director;

		[NonSerialized]
		public double startTime;

		[NonSerialized]
		public double endTime;

		private bool m_Ready;

		private bool m_IsCompletePause;

		private bool m_IsCompleteResume;

		public override void OnPlayableCreate(Playable playable)
		{
		}

		public override void OnGraphStart(Playable playable)
		{
		}

		public override void OnGraphStop(Playable playable)
		{
		}

		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		public override void OnPlayableDestroy(Playable playable)
		{
		}
	}
}
