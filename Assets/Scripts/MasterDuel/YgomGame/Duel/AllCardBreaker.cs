using System.Collections.Generic;

namespace YgomGame.Duel
{
	internal class AllCardBreaker
	{
		public enum Type
		{
			Break = 0,
			DeckOut = 1
		}

		private DuelGameObjectManager goManager;

		private Queue<CardRoot> breakTargets;

		private float timer;

		private const float breakPerSecond = 5f;

		private const float maxSecond = 3f;

		private int numMovings;

		private int targetNum;

		private Type type;

		private float intervalTime => 0f;

		public bool finished => false;

		public void Play(DuelGameObjectManager goManager, int loser, Type type)
		{
		}

		public bool UpdateBreakLoserCard()
		{
			return false;
		}
	}
}
