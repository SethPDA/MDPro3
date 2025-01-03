using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace YgomGame.Duel
{
	public class DuelChainManager : MonoBehaviour
	{
		public struct ChainSpotData
		{
			public int uniqueid;

			public int cardid;

			public int styleid;

			public int player;

			public int position;

			public int chainnum;

			public Vector3 worldpos;

			//public ChainSpotData(int uniqueid, int player, int position, int chainnum, Vector3 worldpos)
			//{
			//}
		}

		private enum ChainStep
		{
			IDLE = 0,
			ACTIVE = 1,
			CHAINSET = 2,
			CHAINRESOLVE1 = 3,
			CHAINRESOLVE2 = 4,
			EFFECTRESOLVE = 5
		}

		private class ChainStepMachine
		{
			public ChainStep step
			{
				[CompilerGenerated]
				get
				{
					return default(ChainStep);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void Increase()
			{
			}

			public void Decrease()
			{
			}

			public void Reset()
			{
			}
		}

		public UnityAction onAdded;

		private ChainStepMachine m_StateMachine;

		private List<ChainSpotData> m_ChainSpotDataList;

		private List<Dictionary<int, List<DuelChainSpot>>> m_PosChainSpotTable;

		private PlayableDirector m_CurrentTimeline;

		private Queue<ChainSpotData> m_ChainSpotDataQueue;

		private int m_MinimumChainEndCount;

		private int m_MinimumChainRunCount;

		private DuelClient m_Host;

		public bool isChainSet => false;

		public bool isChainRevolve => false;

		public bool IsTimelinePlaying => false;

		private DuelChainSpot m_LastChainSpot => null;

		public static DuelChainManager Create(Transform parent, DuelClient host)
		{
			return null;
		}

		public void ActiveEffect(int uniqueid, int player, int position, int chainnum, Vector3 dstpos, UnityAction onAdded = null, bool mutesound = false)
		{
		}

		public void ActiveEffectMinimum(int uniqueid, int player, int position, int chainnum, Vector3 dstpos)
		{
		}

		public void OnAudienceReplayFinished()
		{
		}

		public void ResolveEffect(int chainnum, Action onRemoved = null)
		{
		}

		public void RemoveChainSpotMinimum()
		{
		}

		public void ResolveEffectMinimum()
		{
		}

		public void SkipTimeline()
		{
		}

		public int CheckChainIdByUniqueId(int uniqueid)
		{
			return 0;
		}

		public int GetCardidByChainId(int chainid)
		{
			return 0;
		}

		public int CurrentChainStackCount()
		{
			return 0;
		}

		public void RemoveChainSpot()
		{
		}

		private void Initialize()
		{
		}

		private void AddChainSpot(int uniqueid, int player, int position, int chainnum, Vector3 worldpos, bool mutesound = false)
		{
		}

		private DuelChainSpot GetChainSpot()
		{
			return null;
		}

		private void RemoveSpot()
		{
		}

		private void SetChainSpotCircle(List<DuelChainSpot> spotlist, int count, Vector3 centerpos)
		{
		}

		private void ResolveChain(Action onRemoved, bool isFirst)
		{
		}

		private void SetChain()
		{
		}

		private void OnChainTimelineEnd()
		{
		}

		private void DuelChainNumSE()
		{
		}
	}
}
