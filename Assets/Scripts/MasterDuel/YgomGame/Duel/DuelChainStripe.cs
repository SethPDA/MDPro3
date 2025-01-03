using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelChainStripe : MonoBehaviour
	{
		private const float DELTATIME = 0.25f;

		private const float MINFLOAT = 0.0001f;

		private const float UNITLENGTH = 0.75f;

		private const string PATH_PREHAB = "Duel/Effects/Chain/fxp_chn_001/fxp_chn_001";

		private GameObject m_ChainUnitPrehab;

		private Transform m_ShowPool;

		private Transform m_HidePool;

		private Stack<int> m_ChainIdStack;

		private Stack<Transform> m_IdolChainUnitStack;

		private Dictionary<int, ChainIndo> m_ChainInfoTable;

		public static DuelChainStripe Create(DuelChainManager dcmanager)
		{
			return null;
		}

		public int AddChain(Vector3 srcpos, Vector3 dstpos, Action<int> onfinish = null)
		{
			return 0;
		}

		public int RemoveChain()
		{
			return 0;
		}

		private IEnumerator AddChainUnit(int chainid, Transform chainunit, float targetlength)
		{
			return null;
		}

		private IEnumerator RemoveChainUnit(int chainid)
		{
			return null;
		}

		private void HideChainUnit(Transform chainunit)
		{
		}

		private Transform GetAvailableChainUnit()
		{
			return null;
		}

		private void PlayTransTween(Transform chainhead, float duration, float trans, Action onfinished = null)
		{
		}
	}
}
