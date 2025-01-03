using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class LethalEffect : MonoBehaviour
	{
		public enum EffectType
		{
			Normal = 0,
			DarkMagician = 1,
			BlueEyes = 2,
			RedEyes = 3
		}

		private AllCardBreaker allCardBreaker;

		private AllCardBreaker allCardBreakerOtherSide;

		private bool playedSlow;

		private DuelGameObjectManager goManager;

		private Action onFinished;

		public bool playing
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static LethalEffect Create(DuelGameObjectManager goManager)
		{
			return null;
		}

		public void Play(int loser, Action onFinished, bool useEffect, Vector3 effectPosition, bool draw, bool isDeckOut, EffectType effectType, Vector3 attackDirection)
		{
		}

		private void Update()
		{
		}
	}
}
