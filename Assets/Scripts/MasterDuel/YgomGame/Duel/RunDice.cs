using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public class RunDice
	{
		public enum STEP
		{
			MAIN = 0,
			END = 1
		}

		private class Dice
		{
			public GameObject obj;

			public PlayableDirector timeline;

			public float timer;

			public int number;

			public bool turned;

			public int seid1;

			public int seid2;

			public bool playing;
		}

		private bool myself;

		private static Vector3[] rotsMyself;

		private static Vector3[] rotsRival;

		public STEP step;

		private List<Dice> dices;

		private const float TOTAL_FRAME = 80f;

		private const float N_STABLE_FRAME = 0.675f;

		public RunDice(int numThrows, int number, bool myself)
		{
		}

		public bool Update(bool isSkip)
		{
			return false;
		}

		private bool UpdateDice(Dice dice, bool isSkip)
		{
			return false;
		}

		public void Terminate()
		{
		}
	}
}
