using System;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public class PendulumReadyEffect
	{
		private PlayableDirector timeline;

		private bool playing;

		private bool loopout;

		private bool cancel;

		public void Play(bool near, Action onFinished)
		{
		}

		public void LoopOut()
		{
		}

		public void Cancel()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}
	}
}
