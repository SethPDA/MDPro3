using System;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class WaitClickBehaviour : PlayableBehaviour
	{
		private PlayableDirector m_Director;

		private bool m_WaitTrigger;

		private bool m_Waited;

		private bool m_IsLooping;

		public bool isLoop;

		[NonSerialized]
		public double startTime;

		[NonSerialized]
		public double endTime;

		[NonSerialized]
		public SelectionButton waitButton;

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

		public void OnClicked()
		{
		}
	}
}
