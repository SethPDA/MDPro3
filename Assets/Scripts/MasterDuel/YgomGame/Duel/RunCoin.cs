using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public class RunCoin
	{
		private class Coin
		{
			public enum State
			{
				Wait = 0,
				Playing = 1,
				Played = 2
			}

			public PlayableDirector timeline;

			public GameObject obj;

			public float timer;

			public State state;

			public bool isFace;

			public bool turned;

			public bool decideSePlayed;
		}

		private enum STEP
		{
			MAIN = 0,
			PRE_END = 1,
			END = 2
		}

		private float timer;

		private bool isSkipped;

		private List<Coin> coins;

		private STEP step;

		public RunCoin(int numThrows, int faceBits, int shineBits, bool sameTime)
		{
		}

		public bool Update()
		{
			return false;
		}

		private bool UpdateCoin(Coin coin)
		{
			return false;
		}

		public void Skip()
		{
		}

		public void Terminate()
		{
		}
	}
}
