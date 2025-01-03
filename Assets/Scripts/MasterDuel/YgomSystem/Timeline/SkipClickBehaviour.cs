using System;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline
{
	[Serializable]
	public class SkipClickBehaviour : PlayableBehaviour
	{
		private PlayableDirector m_Director;

		[NonSerialized]
		public double endTime;

		[NonSerialized]
		public SelectionButton waitButton;

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

		public void OnClicked()
		{
		}
	}
}
