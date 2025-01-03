using System;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public class FinalBlowEffect
	{
		public enum State
		{
			None = 0,
			Load = 1,
			In = 2,
			Loop = 3,
			Out = 4,
			Finish = 5
		}

		private PlayableDirector timeline;

		private const string prefabPath = "Duel/Timeline/Duel/Universal/DuelFinalBlow/ACDuelFinalBlow";

		private State state;

		private float timer;

		private const float waitTime = 1f;

		private Action<State> onStateChanged;

		public static FinalBlowEffect Create()
		{
			return null;
		}

		public void Terminate()
		{
		}

		public void Play(Action<State> onStateChanged)
		{
		}

		public void Update()
		{
		}

		private void SetState(State state)
		{
		}

		private void InvokeStateChanged(State state)
		{
		}

		public void Stop()
		{
		}
	}
}
