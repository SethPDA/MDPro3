using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CardInstancePool : MonoBehaviour
	{
		private enum Step
		{
			Initializing = 0,
			Instantiate = 1,
			Idle = 2,
			Terminating = 3
		}

		private Step step;

		private UnityEngine.Object srcObject;

		private int counter;

		private List<CardRoot> list;

		private Queue<CardRoot> queue;

		public bool isInitialized
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

		public bool isTerminated
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

		public DuelGameObjectManager goManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CardInstancePool Create(DuelGameObjectManager goManager, GameObject root, string name)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Terminate()
		{
		}

		public CardRoot RentInstance()
		{
			return null;
		}

		public void ReturnInstance(CardRoot cardRoot)
		{
		}

		private void Update()
		{
		}

		private void InitializingStep()
		{
		}

		private void InstantiateStep()
		{
		}

		private void IdleStep()
		{
		}

		private void TerminatingStep()
		{
		}

		private void CreateInstance()
		{
		}

		private void EnqueueInstance(CardRoot cardRoot)
		{
		}

		public bool IsEffectPlaying(CardRoot excludeCard = null)
		{
			return false;
		}

		public bool IsEffectPlaying(Type type, CardRoot excludeCard = null)
		{
			return false;
		}

		public bool IsZoneEffectPlaying(ZoneCard.Zone zone, ZoneCard.Mode mode, CardRoot excludeCard = null)
		{
			return false;
		}

		public bool IsMoveEffectRequested(CardRoot excludeCard = null)
		{
			return false;
		}
	}
}
